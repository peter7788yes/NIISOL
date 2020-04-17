using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using T00SharedLibraryDotNet20;

namespace NIISOSL
{
    public partial class Form_Login : Form
    {
        private string iniPath = Application.StartupPath + "\\Setting.ini";

		public Form_Login()
		{
			InitializeComponent();
			DelExportedData();
			label4.Text = "版號:V2.1";
			if (File.Exists(iniPath))
			{
				tb_AgencyCode.Text = File.ReadAllText(iniPath);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tb_AgencyCode.Text.Trim() == "")
			{
				MessageBox.Show("請填入醫事機構代碼");
				tb_AgencyCode.Focus();
				return;
			}
			if (tb_UserName.Text.Trim() == "" || !Utility.IsIdNo(tb_UserName.Text.Trim()))
			{
				MessageBox.Show("使用者證號錯誤");
				tb_UserName.Focus();
				return;
			}
			Form_Main form_Main = new Form_Main();
			form_Main.FormClosed += F2_FormClosed;
			form_Main.AgencyCode = tb_AgencyCode.Text;
			form_Main.UserName = tb_UserName.Text;
			if (!File.Exists(iniPath))
			{
				using (File.Create(iniPath))
				{
				}
			}
			using (StreamWriter streamWriter = new StreamWriter(iniPath))
			{
				streamWriter.Write(tb_AgencyCode.Text);
				streamWriter.Close();
			}
			form_Main.Show();
			Hide();
		}

		private void F2_FormClosed(object sender, FormClosedEventArgs e)
		{
			Close();
		}

		private void DelExportedData()
		{
			string sql = "UPDATE Record SET LogicDel=1 WHERE ExportedDate < '" + Utility.ToRocDateString(DateTime.Now) + "'";
			DataBaseUtilities.DBOperation(Program.ConnectionString, sql, new string[0], CommandOperationType.ExecuteNonQuery);
		}
	}
}
