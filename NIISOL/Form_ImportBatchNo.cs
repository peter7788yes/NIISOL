using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using T00SharedLibraryDotNet20;

namespace NIISOSL
{
    public partial class Form_ImportBatchNo : Form
    {

		public string AgencyCode = "";

		public Form_ImportBatchNo()
		{
			InitializeComponent();
			panel_result.Visible = false;
		}

		private void btn_SelectFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			tb_FilePath.Text = openFileDialog.FileName;
		}

		private void Form_ImportBatchNo_Load(object sender, EventArgs e)
		{
			tb_AgencyCode.Text = AgencyCode;
		}

		private void btn_Import_Click(object sender, EventArgs e)
		{
			if (!File.Exists(tb_FilePath.Text))
			{
				MessageBox.Show("選擇要匯入的檔案!", "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("VaccineCode", typeof(string));
			dataTable.Columns.Add("VaccineNo", typeof(string));
			dataTable.Columns.Add("VaccBatchNo", typeof(string));
			dataTable.Columns.Add("ChName", typeof(string));
			dataTable.Columns.Add("BatchType", typeof(int));
			try
			{
				DataBaseUtilities.DBOperation(Program.ConnectionString, "DELETE FROM VaccineData WHERE Id !=''", new string[0], CommandOperationType.ExecuteNonQuery);
				string[] array = File.ReadAllLines(tb_FilePath.Text, Encoding.GetEncoding("big5"));
				for (int i = 1; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(',');
					DataRow dataRow = dataTable.NewRow();
					dataRow["VaccineCode"] = array2[0];
					dataRow["ChName"] = array2[1];
					dataRow["VaccineNo"] = array2[2];
					dataRow["VaccBatchNo"] = array2[3];
					dataRow["BatchType"] = ((!array2[4].Equals("3")) ? 1 : 0);
					int num = (!array2[4].Equals("3")) ? 1 : 0;
					dataTable.Rows.Add(dataRow);
					string[,] strFieldArray = new string[5, 2]
					{
					{
						"VaccineCode",
						array2[0].ToString()
					},
					{
						"ChName",
						array2[1].ToString()
					},
					{
						"VaccineNo",
						array2[2].ToString()
					},
					{
						"VaccBatchNo",
						array2[3].ToString()
					},
					{
						"BatchType",
						num.ToString()
					}
					};
					DataBaseUtilities.DBOperation(Program.ConnectionString, TableOperation.Insert, "", "VaccineData", "", "", strFieldArray, null, CommandOperationType.ExecuteNonQuery);
				}
				MessageBox.Show("匯入成功！", "匯入成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show("匯入錯誤，請確認檔案是否正確！" + ex.Message, "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				string str = "C:\\NIISOL\\";
				Utility.WriteToFile(str + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t匯入錯誤，請確認檔案是否正確！: " + ex.ToString(), 'A', "");
				return;
			}
			ReloadListView(dataTable);
		}

		private void ReloadListView(DataTable dt)
		{
			lv_Imported.Items.Clear();
			int num = 0;
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				num++;
				ListViewItem listViewItem = new ListViewItem(num.ToString());
				listViewItem.SubItems.Add(dt.Rows[i]["VaccineCode"].ToString());
				listViewItem.SubItems.Add(dt.Rows[i]["VaccineNo"].ToString());
				listViewItem.SubItems.Add(dt.Rows[i]["VaccBatchNo"].ToString());
				lv_Imported.Items.Add(listViewItem);
			}
			panel_result.Visible = true;
		}

		private void btn_Back_Click(object sender, EventArgs e)
		{
			base.Owner.Show();
			Close();
		}

		
	}
}
