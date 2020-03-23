namespace MIS_RequestHistory
{
    partial class MIS_RequestHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MIS_RequestHistory));
            this.txtRequestNo = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSEQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bttUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bttClear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttExportExcel = new System.Windows.Forms.Button();
            this.txtRequestNoYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttSearch = new System.Windows.Forms.Button();
            this.bttClearFile = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bttPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRequestNo
            // 
            this.txtRequestNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRequestNo.Location = new System.Drawing.Point(147, 12);
            this.txtRequestNo.Name = "txtRequestNo";
            this.txtRequestNo.Size = new System.Drawing.Size(48, 20);
            this.txtRequestNo.TabIndex = 2;
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserID.Location = new System.Drawing.Point(280, 12);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(72, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(590, 12);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(199, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtSEQ
            // 
            this.txtSEQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSEQ.Location = new System.Drawing.Point(988, 424);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.ReadOnly = true;
            this.txtSEQ.Size = new System.Drawing.Size(49, 20);
            this.txtSEQ.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RequestNo :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserID/Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(912, 406);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDate.Location = new System.Drawing.Point(833, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(71, 20);
            this.txtDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date :";
            // 
            // bttAdd
            // 
            this.bttAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttAdd.Location = new System.Drawing.Point(930, 131);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(107, 23);
            this.bttAdd.TabIndex = 11;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttUpdate.Location = new System.Drawing.Point(931, 198);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(106, 23);
            this.bttUpdate.TabIndex = 12;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttDelete.Location = new System.Drawing.Point(931, 227);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(106, 23);
            this.bttDelete.TabIndex = 13;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(930, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(107, 74);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // bttUpload
            // 
            this.bttUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttUpload.BackColor = System.Drawing.SystemColors.Control;
            this.bttUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttUpload.Location = new System.Drawing.Point(930, 11);
            this.bttUpload.Name = "bttUpload";
            this.bttUpload.Size = new System.Drawing.Size(78, 23);
            this.bttUpload.TabIndex = 37;
            this.bttUpload.Text = "แนบเอกสาร";
            this.bttUpload.UseVisualStyleBackColor = false;
            this.bttUpload.Click += new System.EventHandler(this.bttUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bttClear
            // 
            this.bttClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttClear.Location = new System.Drawing.Point(930, 160);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(107, 23);
            this.bttClear.TabIndex = 39;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(905, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(16, 20);
            this.dateTimePicker1.TabIndex = 65;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.Location = new System.Drawing.Point(930, 376);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(106, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(934, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "ค้นหา";
            // 
            // bttExportExcel
            // 
            this.bttExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttExportExcel.Location = new System.Drawing.Point(929, 276);
            this.bttExportExcel.Name = "bttExportExcel";
            this.bttExportExcel.Size = new System.Drawing.Size(107, 23);
            this.bttExportExcel.TabIndex = 68;
            this.bttExportExcel.Text = "Export To Excel";
            this.bttExportExcel.UseVisualStyleBackColor = true;
            this.bttExportExcel.Click += new System.EventHandler(this.bttExportExcel_Click);
            // 
            // txtRequestNoYear
            // 
            this.txtRequestNoYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRequestNoYear.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRequestNoYear.Location = new System.Drawing.Point(83, 12);
            this.txtRequestNoYear.Name = "txtRequestNoYear";
            this.txtRequestNoYear.Size = new System.Drawing.Size(51, 20);
            this.txtRequestNoYear.TabIndex = 69;
            this.txtRequestNoYear.Text = "MIS2020";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "-";
            // 
            // bttSearch
            // 
            this.bttSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttSearch.Image = global::MIS_RequestHistory.Properties.Resources._1;
            this.bttSearch.Location = new System.Drawing.Point(488, 11);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(23, 23);
            this.bttSearch.TabIndex = 71;
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // bttClearFile
            // 
            this.bttClearFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttClearFile.BackColor = System.Drawing.SystemColors.Control;
            this.bttClearFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttClearFile.Image = ((System.Drawing.Image)(resources.GetObject("bttClearFile.Image")));
            this.bttClearFile.Location = new System.Drawing.Point(1009, 10);
            this.bttClearFile.Name = "bttClearFile";
            this.bttClearFile.Size = new System.Drawing.Size(24, 24);
            this.bttClearFile.TabIndex = 38;
            this.bttClearFile.UseVisualStyleBackColor = false;
            this.bttClearFile.Click += new System.EventHandler(this.bttClearFile_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsername.Location = new System.Drawing.Point(358, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(127, 20);
            this.txtUsername.TabIndex = 72;
            // 
            // bttPrint
            // 
            this.bttPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttPrint.Location = new System.Drawing.Point(930, 320);
            this.bttPrint.Name = "bttPrint";
            this.bttPrint.Size = new System.Drawing.Size(107, 23);
            this.bttPrint.TabIndex = 73;
            this.bttPrint.Text = "Print Report";
            this.bttPrint.UseVisualStyleBackColor = true;
            // 
            // MIS_RequestHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1044, 455);
            this.Controls.Add(this.bttPrint);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRequestNoYear);
            this.Controls.Add(this.bttExportExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.bttClearFile);
            this.Controls.Add(this.bttUpload);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSEQ);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtRequestNo);
            this.Name = "MIS_RequestHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIS_RequestHistory";
            this.Load += new System.EventHandler(this.MIS_RequestHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequestNo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSEQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bttClearFile;
        private System.Windows.Forms.Button bttUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttExportExcel;
        private System.Windows.Forms.TextBox txtRequestNoYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button bttPrint;
    }
}