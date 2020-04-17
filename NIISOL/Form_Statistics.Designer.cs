namespace NIISOSL
{
    partial class Form_Statistics
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
			btn_Back = new System.Windows.Forms.Button();
			groupBox1 = new System.Windows.Forms.GroupBox();
			cb_BatchNo = new System.Windows.Forms.ComboBox();
			cb_VaccineCode = new System.Windows.Forms.ComboBox();
			tb_EndDate = new System.Windows.Forms.DateTimePicker();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			tb_StartDate = new System.Windows.Forms.DateTimePicker();
			label1 = new System.Windows.Forms.Label();
			btn_Query = new System.Windows.Forms.Button();
			btn_Export = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			btn_Back.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Back.Location = new System.Drawing.Point(545, 6);
			btn_Back.Name = "btn_Back";
			btn_Back.Size = new System.Drawing.Size(100, 28);
			btn_Back.TabIndex = 0;
			btn_Back.Text = "回上一頁";
			btn_Back.UseVisualStyleBackColor = true;
			btn_Back.Click += new System.EventHandler(btn_Back_Click);
			groupBox1.Controls.Add(cb_BatchNo);
			groupBox1.Controls.Add(cb_VaccineCode);
			groupBox1.Controls.Add(tb_EndDate);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(tb_StartDate);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new System.Drawing.Font("新細明體", 10f);
			groupBox1.Location = new System.Drawing.Point(13, 40);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(632, 155);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "疫苗接種人次統計";
			cb_BatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_BatchNo.FormattingEnabled = true;
			cb_BatchNo.Location = new System.Drawing.Point(96, 109);
			cb_BatchNo.Name = "cb_BatchNo";
			cb_BatchNo.Size = new System.Drawing.Size(530, 21);
			cb_BatchNo.TabIndex = 7;
			cb_VaccineCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_VaccineCode.FormattingEnabled = true;
			cb_VaccineCode.Location = new System.Drawing.Point(96, 71);
			cb_VaccineCode.Name = "cb_VaccineCode";
			cb_VaccineCode.Size = new System.Drawing.Size(530, 21);
			cb_VaccineCode.TabIndex = 6;
			cb_VaccineCode.SelectedIndexChanged += new System.EventHandler(cb_VaccineCode_SelectedIndexChanged);
			tb_EndDate.Location = new System.Drawing.Point(240, 26);
			tb_EndDate.Name = "tb_EndDate";
			tb_EndDate.Size = new System.Drawing.Size(125, 23);
			tb_EndDate.TabIndex = 5;
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(20, 116);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(70, 14);
			label4.TabIndex = 4;
			label4.Text = "*疫苗批號";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(20, 74);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(70, 14);
			label3.TabIndex = 3;
			label3.Text = "*疫苗名稱";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(220, 33);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(14, 14);
			label2.TabIndex = 2;
			label2.Text = "~";
			tb_StartDate.Location = new System.Drawing.Point(89, 26);
			tb_StartDate.Name = "tb_StartDate";
			tb_StartDate.Size = new System.Drawing.Size(125, 23);
			tb_StartDate.TabIndex = 1;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(20, 33);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(63, 14);
			label1.TabIndex = 0;
			label1.Text = "接種日期";
			btn_Query.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Query.Location = new System.Drawing.Point(180, 201);
			btn_Query.Name = "btn_Query";
			btn_Query.Size = new System.Drawing.Size(125, 30);
			btn_Query.TabIndex = 2;
			btn_Query.Text = "預覽";
			btn_Query.UseVisualStyleBackColor = true;
			btn_Query.Click += new System.EventHandler(btn_Query_Click);
			btn_Export.Font = new System.Drawing.Font("新細明體", 10f);
			btn_Export.Location = new System.Drawing.Point(344, 201);
			btn_Export.Name = "btn_Export";
			btn_Export.Size = new System.Drawing.Size(125, 30);
			btn_Export.TabIndex = 3;
			btn_Export.Text = "匯出Excel";
			btn_Export.UseVisualStyleBackColor = true;
			btn_Export.Click += new System.EventHandler(btn_Export_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(657, 246);
			base.Controls.Add(btn_Export);
			base.Controls.Add(btn_Query);
			base.Controls.Add(groupBox1);
			base.Controls.Add(btn_Back);
			base.Name = "Form_Statistics";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "離線版預防接種登錄";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button btn_Back;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cb_BatchNo;
		private System.Windows.Forms.ComboBox cb_VaccineCode;
		private System.Windows.Forms.DateTimePicker tb_EndDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker tb_StartDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Query;
		private System.Windows.Forms.Button btn_Export;
	}
}
