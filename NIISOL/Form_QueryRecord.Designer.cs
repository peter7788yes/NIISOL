namespace NIISOSL
{
    partial class Form_QueryRecord
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
			rb_AllData = new System.Windows.Forms.RadioButton();
			rb_NoExport = new System.Windows.Forms.RadioButton();
			label1 = new System.Windows.Forms.Label();
			tb_ParentRocID = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			tb_RocID = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			tb_CaseName = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			btn_Clean = new System.Windows.Forms.Button();
			btn_Query = new System.Windows.Forms.Button();
			btn_Export = new System.Windows.Forms.Button();
			panel_result = new System.Windows.Forms.Panel();
			lb_DataCnt = new System.Windows.Forms.Label();
			dv_Data = new System.Windows.Forms.DataGridView();
			btn_Back = new System.Windows.Forms.Button();
			btn_Statistics = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			panel_result.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dv_Data).BeginInit();
			SuspendLayout();
			groupBox1.Controls.Add(rb_AllData);
			groupBox1.Controls.Add(rb_NoExport);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tb_ParentRocID);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(tb_RocID);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(tb_CaseName);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new System.Drawing.Font("新細明體", 10f);
			groupBox1.Location = new System.Drawing.Point(12, 31);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(1037, 87);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "預防接種明細";
			rb_AllData.AutoSize = true;
			rb_AllData.Location = new System.Drawing.Point(235, 17);
			rb_AllData.Name = "rb_AllData";
			rb_AllData.Size = new System.Drawing.Size(53, 18);
			rb_AllData.TabIndex = 19;
			rb_AllData.TabStop = true;
			rb_AllData.Text = "全部";
			rb_AllData.UseVisualStyleBackColor = true;
			rb_NoExport.AutoSize = true;
			rb_NoExport.Checked = true;
			rb_NoExport.Location = new System.Drawing.Point(111, 16);
			rb_NoExport.Name = "rb_NoExport";
			rb_NoExport.Size = new System.Drawing.Size(67, 18);
			rb_NoExport.TabIndex = 18;
			rb_NoExport.TabStop = true;
			rb_NoExport.Text = "未匯出";
			rb_NoExport.UseVisualStyleBackColor = true;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(18, 19);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(63, 14);
			label1.TabIndex = 17;
			label1.Text = "匯出狀態";
			tb_ParentRocID.Font = new System.Drawing.Font("新細明體", 10f);
			tb_ParentRocID.Location = new System.Drawing.Point(641, 47);
			tb_ParentRocID.Name = "tb_ParentRocID";
			tb_ParentRocID.Size = new System.Drawing.Size(156, 23);
			tb_ParentRocID.TabIndex = 16;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("新細明體", 10f);
			label4.Location = new System.Drawing.Point(521, 50);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(105, 14);
			label4.TabIndex = 15;
			label4.Text = "父或母身分證號";
			tb_RocID.Font = new System.Drawing.Font("新細明體", 10f);
			tb_RocID.Location = new System.Drawing.Point(346, 47);
			tb_RocID.Name = "tb_RocID";
			tb_RocID.Size = new System.Drawing.Size(156, 23);
			tb_RocID.TabIndex = 14;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("新細明體", 10f);
			label3.Location = new System.Drawing.Point(277, 50);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(63, 14);
			label3.TabIndex = 13;
			label3.Text = "身分證號";
			tb_CaseName.Font = new System.Drawing.Font("新細明體", 10f);
			tb_CaseName.Location = new System.Drawing.Point(87, 47);
			tb_CaseName.Name = "tb_CaseName";
			tb_CaseName.Size = new System.Drawing.Size(151, 23);
			tb_CaseName.TabIndex = 12;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("新細明體", 10f);
			label2.Location = new System.Drawing.Point(46, 50);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(35, 14);
			label2.TabIndex = 11;
			label2.Text = "姓名";
			btn_Clean.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Clean.Location = new System.Drawing.Point(296, 124);
			btn_Clean.Name = "btn_Clean";
			btn_Clean.Size = new System.Drawing.Size(139, 27);
			btn_Clean.TabIndex = 18;
			btn_Clean.Text = "清除";
			btn_Clean.UseVisualStyleBackColor = true;
			btn_Clean.Click += new System.EventHandler(btn_Clean_Click);
			btn_Query.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Query.Location = new System.Drawing.Point(450, 124);
			btn_Query.Name = "btn_Query";
			btn_Query.Size = new System.Drawing.Size(139, 27);
			btn_Query.TabIndex = 17;
			btn_Query.Text = "查詢";
			btn_Query.UseVisualStyleBackColor = true;
			btn_Query.Click += new System.EventHandler(btn_Query_Click);
			btn_Export.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Export.Location = new System.Drawing.Point(598, 124);
			btn_Export.Name = "btn_Export";
			btn_Export.Size = new System.Drawing.Size(139, 27);
			btn_Export.TabIndex = 4;
			btn_Export.Text = "匯出CSV";
			btn_Export.UseVisualStyleBackColor = true;
			btn_Export.Click += new System.EventHandler(btn_Export_Click);
			panel_result.Controls.Add(lb_DataCnt);
			panel_result.Controls.Add(dv_Data);
			panel_result.Location = new System.Drawing.Point(12, 156);
			panel_result.Name = "panel_result";
			panel_result.Size = new System.Drawing.Size(1037, 364);
			panel_result.TabIndex = 1;
			lb_DataCnt.AutoSize = true;
			lb_DataCnt.Font = new System.Drawing.Font("新細明體", 10f);
			lb_DataCnt.Location = new System.Drawing.Point(435, 12);
			lb_DataCnt.Name = "lb_DataCnt";
			lb_DataCnt.Size = new System.Drawing.Size(0, 14);
			lb_DataCnt.TabIndex = 5;
			dv_Data.AllowUserToAddRows = false;
			dv_Data.AllowUserToDeleteRows = false;
			dv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dv_Data.Location = new System.Drawing.Point(14, 41);
			dv_Data.Name = "dv_Data";
			dv_Data.ReadOnly = true;
			dv_Data.RowHeadersVisible = false;
			dv_Data.RowTemplate.Height = 24;
			dv_Data.Size = new System.Drawing.Size(1005, 292);
			dv_Data.TabIndex = 0;
			btn_Back.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Back.Location = new System.Drawing.Point(638, 10);
			btn_Back.Name = "btn_Back";
			btn_Back.Size = new System.Drawing.Size(99, 23);
			btn_Back.TabIndex = 2;
			btn_Back.Text = "回上一頁";
			btn_Back.UseVisualStyleBackColor = true;
			btn_Back.Click += new System.EventHandler(btn_Back_Click);
			btn_Statistics.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Statistics.Location = new System.Drawing.Point(754, 10);
			btn_Statistics.Name = "btn_Statistics";
			btn_Statistics.Size = new System.Drawing.Size(153, 23);
			btn_Statistics.TabIndex = 3;
			btn_Statistics.Text = "疫苗接種人次統計";
			btn_Statistics.UseVisualStyleBackColor = true;
			btn_Statistics.Visible = false;
			btn_Statistics.Click += new System.EventHandler(btn_Statistics_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1061, 526);
			base.Controls.Add(btn_Export);
			base.Controls.Add(btn_Query);
			base.Controls.Add(btn_Clean);
			base.Controls.Add(btn_Statistics);
			base.Controls.Add(btn_Back);
			base.Controls.Add(panel_result);
			base.Controls.Add(groupBox1);
			base.Name = "Form_QueryRecord";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "離線版預防接種登錄";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel_result.ResumeLayout(false);
			panel_result.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dv_Data).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel_result;
		private System.Windows.Forms.DataGridView dv_Data;
		private System.Windows.Forms.Button btn_Export;
		private System.Windows.Forms.Button btn_Back;
		private System.Windows.Forms.Button btn_Statistics;
		private System.Windows.Forms.Button btn_Query;
		private System.Windows.Forms.TextBox tb_ParentRocID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_RocID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_CaseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_DataCnt;
		private System.Windows.Forms.Button btn_Clean;
		private System.Windows.Forms.RadioButton rb_AllData;
		private System.Windows.Forms.RadioButton rb_NoExport;
		private System.Windows.Forms.Label label1;
	}
}
