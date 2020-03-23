using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Data.OleDb;

namespace MIS_RequestHistory
{
    public partial class MIS_RequestHistory : Form
    {
        int valErr = 0;
        string varPath = "";
        string varAttachedFile = "";
        int varSEQ = 0;

        //  SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");

        public MIS_RequestHistory()
        {
            InitializeComponent();
        }

        private void MIS_RequestHistory_Load(object sender, EventArgs e)
        {
            conn.Open();
            
            int varindex = 0;

            dataGridView2.Rows.Clear();
            dataGridView2.ColumnCount = 2;

            dataGridView2.Columns[varindex].Name = "Attached_File";
            dataGridView2.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView2.Columns[varindex].Name = "Path";
            dataGridView2.Columns[varindex].Width = 200;

            Showdata();
            ClearData();
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[varindex].Name = "RequestNo";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "User";
            dataGridView1.Columns[varindex].Width = 80;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Description";
            dataGridView1.Columns[varindex].Width = 340;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Date";
            dataGridView1.Columns[varindex].Width = 80;
         
            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "SEQ";
            dataGridView1.Columns[varindex].Width = 30;

            string sql = "";

            if (txtSearch.Text == "")
            {
                sql = "Select * from MIS_RequestData order by RequestNo desc";
            }
            else
            {
                sql = "Select * from MIS_RequestData where RequestNo like '%' + '" + txtSearch.Text + "' + '%' or Requestor like '%' + '" + txtSearch.Text + "' + '%' or Other like '%' + '" + txtSearch.Text + "' + '%' order by RequestNo desc";
            }

            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {              
                dataGridView1.Rows.Add(dr["RequestNo"].ToString(), dr["Requestor"].ToString(), dr["Other"].ToString(), dr["RequestDate"].ToString(), dr["SEQ"].ToString());            
            }
            dr.Close();
        }

        private void CheckError()
        {
            valErr = 0;
            if (txtRequestNo.Text.Trim() == "")
            {
                MessageBox.Show("please input RequestNo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return;
            }
            else if (txtUserID.Text.Trim() == "") { MessageBox.Show("please input UserID/Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtDescription.Text.Trim() == "") { MessageBox.Show("please input Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtDate.Text.Trim() == "") { MessageBox.Show("please input Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
        
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            CheckError();
            string RequestNo = txtRequestNoYear.Text + "-" + txtRequestNo.Text;

            if (valErr == 0)
            {
                String sql = "INSERT INTO MIS_RequestData (RequestNo,Requestor,Other,RequestDate)VALUES ('" + RequestNo + "','" + txtUserID.Text + "','" + txtDescription.Text + "','" + txtDate.Text + "')";

                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                GetLastSEQ();
                varPath = "";
                varAttachedFile = "";
                for (int Ix = 0; Ix <= 99; Ix++)
                {
                    try
                    {
                        varAttachedFile = dataGridView2.Rows[Ix].Cells["Attached_File"].Value.ToString();
                        varPath = dataGridView2.Rows[Ix].Cells["Path"].Value.ToString();
                    }
                    catch
                    {
                        break;
                    }

                    string UploadPath = @"D:\MyProject\MIS_RequestHistory\MIS_RequestHistory\bin\Debug\AttachedFile\" + varSEQ;
                    if (System.IO.Directory.Exists(UploadPath))
                    {
                    }
                    else { System.IO.Directory.CreateDirectory(UploadPath); }

                    string varFileName = "Attached#" + Convert.ToString(Ix) + ".PDF";
                    string varDestFile = @UploadPath + @"\" + varFileName;
                    System.IO.File.Copy(varPath, varDestFile, true);

                    String sql2 = "INSERT INTO MIS_RequestAttachedFile (SEQ,AttachedFile,Path)VALUES ('" + varSEQ + "','" + varFileName + "','" + varDestFile + "')";
                    OleDbCommand com2 = new OleDbCommand(sql2, conn);
                    com2.ExecuteNonQuery();
                }

                MessageBox.Show("Add completed");

                ClearData();
                Showdata();              
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            CheckError();
            string RequestNo = txtRequestNoYear.Text + "-" + txtRequestNo.Text;
            if (valErr != 0) { return; }
            if (txtSEQ.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
            }

            if (MessageBox.Show("Do you want to Update the data ? " + RequestNo, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Update MIS_RequestData SET RequestNo = '" + RequestNo + "', Requestor = '" + txtUserID.Text + "', Other = '" + txtDescription.Text + "' , RequestDate = '" + txtDate.Text + "'  where SEQ = '" + txtSEQ.Text + "'";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                for (int Ix = 0; Ix <= 99; Ix++)
                {
                    try
                    {
                        varAttachedFile = dataGridView2.Rows[Ix].Cells["Attached_File"].Value.ToString();
                        varPath = dataGridView2.Rows[Ix].Cells["Path"].Value.ToString();
                    }
                    catch
                    {
                        break;
                    }

                    string UploadPath = @"D:\MyProject\MIS_RequestHistory\MIS_RequestHistory\bin\Debug\AttachedFile\" + varSEQ;
                    if (System.IO.Directory.Exists(UploadPath))
                    { }
                    else
                    {
                        System.IO.Directory.CreateDirectory(UploadPath);
                    }

                    string varDestFile = @UploadPath + @"\" + varAttachedFile;

                    if ((System.IO.File.Exists(@varDestFile)))
                    { }
                    else
                    {
                        string varFileName = "";
                        varFileName = "Attached#" + Convert.ToString(Ix) + ".PDF";
                        varDestFile = @UploadPath + @"\" + varFileName;
                        System.IO.File.Copy(varPath, varDestFile, true);
                        String sql1 = "INSERT INTO MIS_RequestAttachedFile (SEQ,AttachedFile,Path)VALUES ('" + varSEQ + "','" + varFileName + "','" + varDestFile + "')";
                        OleDbCommand com1 = new OleDbCommand(sql1, conn);
                        com1.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Update completed");
                Showdata();
                ClearData();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            string RequestNo = txtRequestNoYear.Text + "-" + txtRequestNo.Text;
            if (txtSEQ.Text.Trim() == "")
            { MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }

            if (MessageBox.Show("Do you want to delete the data ? " + RequestNo, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Delete from MIS_RequestData where SEQ ='" + txtSEQ.Text + "' ";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Delete completed");
                Showdata();
                ClearData();
            }
        }

        private void ClearData()
        {
           
            txtRequestNoYear.Text = txtRequestNoYear.Text;
            txtRequestNo.Text = "";
            txtUserID.Text = "";
            txtDescription.Text = "";
            txtDate.Text = "";
            txtSEQ.Text = "";
            txtUsername.Text = "";

            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;

            dataGridView2.Rows.Clear();
        }

        private void GetLastSEQ()
        {
            string sql = "Select * from MIS_RequestData where Requestor = '" + txtUserID.Text + "' order by SEQ DESC ";
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                varSEQ = Convert.ToInt32(dr["SEQ"].ToString());
                break;
            }
        }

        private void bttUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Files (.PDF)|*.PDF|All Files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            string varFileName = openFileDialog1.FileName.ToString();
            string varPathFile = openFileDialog1.SafeFileName.ToString();
            if (varFileName != "")
            {
                dataGridView2.Rows.Add(varPathFile, varFileName);

                if (txtSEQ.Text != "")
                {
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         

            ClearData();
            try
            {
                txtRequestNo.Text = dataGridView1.Rows[e.RowIndex].Cells["RequestNo"].Value.ToString().Substring(8);
                txtRequestNoYear.Text = dataGridView1.Rows[e.RowIndex].Cells["RequestNo"].Value.ToString().Substring(0, 7);
                txtDate.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells["User"].Value.ToString();
                txtSEQ.Text = dataGridView1.Rows[e.RowIndex].Cells["SEQ"].Value.ToString();

                bttAdd.Enabled = false;
                bttDelete.Enabled = true;
                bttUpdate.Enabled = true;
            }
            catch { }
      
            string sql2 = "Select * from UserMaster where UserID = '" + txtUserID.Text +"'";
            OleDbCommand com2 = new OleDbCommand(sql2, conn);
            OleDbDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                txtUsername.Text = dr2["UserName"].ToString();
            }
            dr2.Close();

            string sql1 = "Select * from MIS_RequestAttachedFile where SEQ = '" + txtSEQ.Text + "'  ";
           OleDbCommand com1 = new OleDbCommand(sql1, conn);
           OleDbDataReader dr1 = com1.ExecuteReader();
           while (dr1.Read())
            {
                dataGridView2.Rows.Add(dr1["AttachedFile"].ToString(), dr1["Path"].ToString());          
            }
                    dr1.Close();
            
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string varPath = dataGridView2.Rows[e.RowIndex].Cells["Path"].Value.ToString();
            System.Diagnostics.Process.Start(@varPath);
        }

        private void bttClearFile_Click(object sender, EventArgs e)
        {
            varAttachedFile = "";
            varPath = "";

            for (int Ix = 0; Ix <= 99; Ix++)
            {
                try
                {
                    varAttachedFile = dataGridView2.Rows[Ix].Cells["Attached_File"].Value.ToString();
                    varPath = dataGridView2.Rows[Ix].Cells["Path"].Value.ToString();
                }
                catch
                {
                    break;
                }

                if (System.IO.File.Exists(@varPath))
                {
                    System.IO.File.Delete(@varPath);
                }
            }

            String sql = "Delete from MIS_RequestAttachedFile where SEQ ='" + txtSEQ.Text + "' ";
            OleDbCommand com = new OleDbCommand(sql, conn);
            com.ExecuteNonQuery();

            dataGridView2.Rows.Clear();
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePicker1.Value.Year.ToString("0000") + "/" + dateTimePicker1.Value.Month.ToString("00") + "/" + dateTimePicker1.Value.Day.ToString("00");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Showdata();
        }

        private void bttExportExcel_Click(object sender, EventArgs e)
        {
            Thread progressThread = new Thread(delegate ()
            {
                ProgressForm progress = new ProgressForm();
                progress.ShowDialog();
            });
            progressThread.Start();


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            try
            {
                Excel.Range formatRange;
                formatRange = xlWorkSheet.get_Range("H2", "H99999");
                formatRange.NumberFormat = "#,###,###";
            }
            catch { }

            int i = 0;
            int j = 0;
            int ix = 1;

            for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
            {
                xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1.Columns[j].Name;
            }

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[ix + 1, j + 1] = cell.Value;
                }
                ix = ix + 1;
            }
            xlWorkSheet.Columns.AutoFit();

            if (System.IO.File.Exists(@"c:\MIS_Request.xls"))
            {
                try
                {
                    System.IO.File.Delete(@"c:\MIS_Request.xls");
                }
                catch { }
            }
            if (System.IO.File.Exists(@"D:\MIS_Request.xls"))
            {
                try
                {
                    System.IO.File.Delete(@"D:\MIS_Request.xls");
                }
                catch { }

            }

            try
            {
                xlWorkBook.SaveAs(@"c:\MIS_Request.xls");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbooks books = excelApp.Workbooks;
                Excel.Workbook Sheet = books.Open(@"c:\MIS_Request.xls");
            }
            catch
            {
                xlWorkBook.SaveAs(@"D:\MIS_Request.xls");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbooks books = excelApp.Workbooks;
                Excel.Workbook Sheet = books.Open(@"D:\MIS_Request.xls");
            }
            
            progressThread.Abort();
            
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            SearchUser WinD3 = new SearchUser();
            WinD3.ShowDialog();
            txtUserID.Text = MyGlobal.GlobalUserID;
            txtUsername.Text = MyGlobal.GlobalUserName;
        }
    }
}
