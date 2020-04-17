namespace NIISOSL
{
    partial class Form_StatisticsPrint
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
			lb_Cnt = new System.Windows.Forms.Label();
			gv_Data = new System.Windows.Forms.DataGridView();
			lb_Date = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gv_Data).BeginInit();
			SuspendLayout();
			groupBox1.Controls.Add(lb_Date);
			groupBox1.Controls.Add(lb_Cnt);
			groupBox1.Controls.Add(gv_Data);
			groupBox1.Font = new System.Drawing.Font("新細明體", 10f);
			groupBox1.Location = new System.Drawing.Point(13, 13);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(895, 524);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "疫苗接種人次統計表";
			lb_Cnt.AutoSize = true;
			lb_Cnt.Location = new System.Drawing.Point(7, 23);
			lb_Cnt.Name = "lb_Cnt";
			lb_Cnt.Size = new System.Drawing.Size(0, 14);
			lb_Cnt.TabIndex = 1;
			gv_Data.AllowUserToAddRows = false;
			gv_Data.AllowUserToDeleteRows = false;
			gv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			gv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gv_Data.Location = new System.Drawing.Point(7, 45);
			gv_Data.Name = "gv_Data";
			gv_Data.ReadOnly = true;
			gv_Data.RowHeadersVisible = false;
			gv_Data.RowTemplate.Height = 24;
			gv_Data.Size = new System.Drawing.Size(882, 473);
			gv_Data.TabIndex = 0;
			lb_Date.AutoSize = true;
			lb_Date.Location = new System.Drawing.Point(690, 24);
			lb_Date.Name = "lb_Date";
			lb_Date.Size = new System.Drawing.Size(0, 14);
			lb_Date.TabIndex = 2;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(920, 549);
			base.Controls.Add(groupBox1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form_StatisticsPrint";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "離線版預防接種登錄";
			base.Load += new System.EventHandler(Form_StatisticsPrint_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gv_Data).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView gv_Data;
		private System.Windows.Forms.Label lb_Cnt;
		private System.Windows.Forms.Label lb_Date;
	}
}
