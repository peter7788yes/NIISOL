

namespace NIISOSL
{
	partial class Form_Export
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
			btn_Cancel = new System.Windows.Forms.Button();
			btn_Export = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			groupBox1.Controls.Add(btn_Cancel);
			groupBox1.Controls.Add(btn_Export);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new System.Drawing.Font("新細明體", 10f);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(388, 185);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "匯出檔案";
			btn_Cancel.Location = new System.Drawing.Point(65, 135);
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new System.Drawing.Size(118, 29);
			btn_Cancel.TabIndex = 2;
			btn_Cancel.Text = "取消";
			btn_Cancel.UseVisualStyleBackColor = true;
			btn_Cancel.Click += new System.EventHandler(btn_Cancel_Click);
			btn_Export.Location = new System.Drawing.Point(201, 135);
			btn_Export.Name = "btn_Export";
			btn_Export.Size = new System.Drawing.Size(118, 29);
			btn_Export.TabIndex = 1;
			btn_Export.Text = "確定";
			btn_Export.UseVisualStyleBackColor = true;
			btn_Export.Click += new System.EventHandler(btn_Export_Click);
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(7, 23);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(367, 70);
			label1.TabIndex = 0;
			label1.Text = "1.匯出後請儘速確認檔案資料正確性\r\n2.匯出之紀錄若有問題請於電子檔直接修改再行匯入\r\n3.已匯出之接種紀錄將於隔日重新登入應用程式時全部清除\r\n\r\n直接匯出檔案請按“確定”";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(408, 204);
			base.Controls.Add(groupBox1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form_Export";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "離線版預防接種登錄";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Export;
		private System.Windows.Forms.Label label1;
	}
}
