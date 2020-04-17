namespace NIISOSL
{
    partial class Form_ImportBatchNo
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
			groupBox1 = new System.Windows.Forms.GroupBox();
			btn_Import = new System.Windows.Forms.Button();
			label3 = new System.Windows.Forms.Label();
			tb_FilePath = new System.Windows.Forms.TextBox();
			btn_SelectFile = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			tb_AgencyCode = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			panel_result = new System.Windows.Forms.Panel();
			lv_Imported = new System.Windows.Forms.ListView();
			Seq = new System.Windows.Forms.ColumnHeader();
			VaccineCode = new System.Windows.Forms.ColumnHeader();
			VaccineNo = new System.Windows.Forms.ColumnHeader();
			VaccBatchNo = new System.Windows.Forms.ColumnHeader();
			label4 = new System.Windows.Forms.Label();
			btn_Back = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			panel_result.SuspendLayout();
			SuspendLayout();
			groupBox1.Controls.Add(btn_Import);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(tb_FilePath);
			groupBox1.Controls.Add(btn_SelectFile);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(tb_AgencyCode);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new System.Drawing.Font("新細明體", 10f);
			groupBox1.Location = new System.Drawing.Point(12, 45);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(705, 136);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "疫苗批號匯入";
			btn_Import.Location = new System.Drawing.Point(286, 102);
			btn_Import.Name = "btn_Import";
			btn_Import.Size = new System.Drawing.Size(102, 24);
			btn_Import.TabIndex = 6;
			btn_Import.Text = "匯入CSV";
			btn_Import.UseVisualStyleBackColor = true;
			btn_Import.Click += new System.EventHandler(btn_Import_Click);
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("新細明體", 10f);
			label3.Location = new System.Drawing.Point(23, 85);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(263, 14);
			label3.TabIndex = 5;
			label3.Text = "說明︰疫苗批號匯入清單請至NIIS(Ⅱ)匯出";
			tb_FilePath.Location = new System.Drawing.Point(334, 50);
			tb_FilePath.Name = "tb_FilePath";
			tb_FilePath.Size = new System.Drawing.Size(365, 23);
			tb_FilePath.TabIndex = 4;
			btn_SelectFile.Location = new System.Drawing.Point(246, 50);
			btn_SelectFile.Name = "btn_SelectFile";
			btn_SelectFile.Size = new System.Drawing.Size(82, 23);
			btn_SelectFile.TabIndex = 3;
			btn_SelectFile.Text = "選擇檔案";
			btn_SelectFile.UseVisualStyleBackColor = true;
			btn_SelectFile.Click += new System.EventHandler(btn_SelectFile_Click);
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(135, 53);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(91, 14);
			label2.TabIndex = 2;
			label2.Text = "疫苗批號檔案";
			tb_AgencyCode.Location = new System.Drawing.Point(246, 16);
			tb_AgencyCode.Name = "tb_AgencyCode";
			tb_AgencyCode.Size = new System.Drawing.Size(167, 23);
			tb_AgencyCode.TabIndex = 1;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(23, 23);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(189, 14);
			label1.TabIndex = 0;
			label1.Text = "接種單位十碼章醫事機構代碼";
			openFileDialog1.FileName = "openFileDialog1";
			panel_result.Controls.Add(lv_Imported);
			panel_result.Controls.Add(label4);
			panel_result.Font = new System.Drawing.Font("新細明體", 10f);
			panel_result.Location = new System.Drawing.Point(12, 187);
			panel_result.Name = "panel_result";
			panel_result.Size = new System.Drawing.Size(705, 287);
			panel_result.TabIndex = 1;
			panel_result.Visible = false;
			lv_Imported.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4]
			{
			Seq,
			VaccineCode,
			VaccineNo,
			VaccBatchNo
			});
			lv_Imported.GridLines = true;
			lv_Imported.Location = new System.Drawing.Point(15, 29);
			lv_Imported.Name = "lv_Imported";
			lv_Imported.Size = new System.Drawing.Size(684, 247);
			lv_Imported.TabIndex = 1;
			lv_Imported.UseCompatibleStateImageBehavior = false;
			lv_Imported.View = System.Windows.Forms.View.Details;
			Seq.Text = "序號";
			VaccineCode.Text = "疫苗名稱";
			VaccineCode.Width = 150;
			VaccineNo.Text = "劑別/型";
			VaccineNo.Width = 80;
			VaccBatchNo.Text = "疫苗批號";
			VaccBatchNo.Width = 306;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("新細明體", 10f);
			label4.Location = new System.Drawing.Point(283, 10);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(91, 14);
			label4.TabIndex = 0;
			label4.Text = "匯入批號明細";
			btn_Back.Font = new System.Drawing.Font("新細明體", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_Back.Location = new System.Drawing.Point(595, 15);
			btn_Back.Name = "btn_Back";
			btn_Back.Size = new System.Drawing.Size(106, 24);
			btn_Back.TabIndex = 2;
			btn_Back.Text = "回上一頁";
			btn_Back.UseVisualStyleBackColor = true;
			btn_Back.Click += new System.EventHandler(btn_Back_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(728, 486);
			base.Controls.Add(btn_Back);
			base.Controls.Add(panel_result);
			base.Controls.Add(groupBox1);
			base.Name = "Form_ImportBatchNo";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "離線版預防接種登錄";
			base.Load += new System.EventHandler(Form_ImportBatchNo_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel_result.ResumeLayout(false);
			panel_result.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tb_FilePath;
		private System.Windows.Forms.Button btn_SelectFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_AgencyCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btn_Import;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel_result;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lv_Imported;
		private System.Windows.Forms.ColumnHeader Seq;
		private System.Windows.Forms.ColumnHeader VaccineCode;
		private System.Windows.Forms.ColumnHeader VaccineNo;
		private System.Windows.Forms.ColumnHeader VaccBatchNo;
		private System.Windows.Forms.Button btn_Back;
	}
}
