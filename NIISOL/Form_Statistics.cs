using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using T00SharedLibraryDotNet20;

namespace NIISOSL
{
    public partial class Form_Statistics : Form
    {

        public DataTable dt_VaccineData = new DataTable();

		public Form_Statistics()
		{
			InitializeComponent();
			InitVaccineData();
		}

		public void InitVaccineData()
		{
			dt_VaccineData.Clear();
			string sql = "select VaccineCode,VaccineCode||' ('||chName||')' VaccineName,VaccBatchNo  from VaccineData";
			dt_VaccineData = (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, sql, null, CommandOperationType.ExecuteReaderReturnDataTable);
			Init_cb_VaccineCode();
			Init_cb_BatchNo();
		}

		private void cb_VaccineCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			Init_cb_BatchNo();
		}

		private void Init_cb_VaccineCode()
		{
			DataTable dataTable = dt_VaccineData.DefaultView.ToTable(true, "VaccineCode", "VaccineName");
			cb_VaccineCode.DisplayMember = "VaccineName";
			cb_VaccineCode.ValueMember = "VaccineCode";
			DataRow dataRow = dataTable.NewRow();
			dataRow["VaccineName"] = "全部";
			dataRow["VaccineCode"] = "%";
			dataTable.Rows.InsertAt(dataRow, 0);
			cb_VaccineCode.DataSource = dataTable;
			cb_VaccineCode.SelectedIndex = 0;
		}

		private void Init_cb_BatchNo()
		{
			DataRow[] array = dt_VaccineData.Select("VaccineCode like '" + cb_VaccineCode.SelectedValue.ToString() + "'");
			DataTable dataTable = dt_VaccineData.Clone();
			for (int i = 0; i < array.Length; i++)
			{
				dataTable.ImportRow(array[i]);
			}
			DataRow dataRow = dataTable.NewRow();
			dataRow["VaccineName"] = "";
			dataRow["VaccineCode"] = "";
			dataRow["VaccBatchNo"] = "全部";
			dataTable.Rows.InsertAt(dataRow, 0);
			cb_BatchNo.DisplayMember = "VaccBatchNo";
			cb_BatchNo.ValueMember = "VaccBatchNo";
			cb_BatchNo.DataSource = dataTable.DefaultView.ToTable(true, "VaccBatchNo");
			cb_BatchNo.SelectedIndex = 0;
		}

		private void btn_Back_Click(object sender, EventArgs e)
		{
			base.Owner.Show();
			Close();
		}

		private void btn_Query_Click(object sender, EventArgs e)
		{
			Form_StatisticsPrint form_StatisticsPrint = new Form_StatisticsPrint();
			string text = cb_VaccineCode.SelectedValue.ToString();
			if (text == "%")
			{
				text = "";
			}
			string text2 = cb_BatchNo.SelectedValue.ToString();
			if (text2 == "全部")
			{
				text2 = "";
			}
			form_StatisticsPrint.startdate = Utility.ToRocDateString(Convert.ToDateTime(tb_StartDate.Text));
			form_StatisticsPrint.enddate = Utility.ToRocDateString(Convert.ToDateTime(tb_EndDate.Text));
			form_StatisticsPrint.vaccinecode = text;
			form_StatisticsPrint.batchno = text2;
			form_StatisticsPrint.FormClosed += Fsp_FormClosed;
			form_StatisticsPrint.Show();
			Hide();
		}

		private void Fsp_FormClosed(object sender, FormClosedEventArgs e)
		{
			Show();
		}

		private void btn_Export_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Utility.ToRocDateString(Convert.ToDateTime(tb_StartDate.Text));
				string text2 = Utility.ToRocDateString(Convert.ToDateTime(tb_EndDate.Text));
				string text3 = cb_VaccineCode.SelectedValue.ToString();
				if (text3 == "%")
				{
					text3 = "";
				}
				string text4 = cb_BatchNo.SelectedValue.ToString();
				if (text4 == "全部")
				{
					text4 = "";
				}
				DataTable dataTable = new DataTable();
				string str = "select VaccineCode 疫苗名稱,VaccineNo '劑別/型',VaccBatchNo 疫苗批號,AgencyCode 十碼章,count(*) 數量 from Record where LogicDel=0 AND InoculationDate>='" + text + "' and InoculationDate<='" + text2 + "' ";
				if (text3 != "")
				{
					str = str + "and VaccineCode='" + text3 + "' ";
				}
				if (text4 != "")
				{
					str = str + "and VaccBatchNo='" + text4 + "' ";
				}
				str += "group by VaccineCode,VaccineNo,VaccBatchNo,AgencyCode";
				dataTable = (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, str, null, CommandOperationType.ExecuteReaderReturnDataTable);
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				folderBrowserDialog.Description = "請選擇匯出檔案要儲存的資料夾";
				folderBrowserDialog.ShowDialog();
				if (folderBrowserDialog.SelectedPath == "")
				{
					MessageBox.Show("請選擇匯出檔案要儲存的資料夾");
				}
				else
				{
					string str2 = folderBrowserDialog.SelectedPath + "\\";
					string text5 = "疫苗接種人次統計表" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
					MemoryStream memoryStream = Utility.RenderDataTableToExcel(dataTable) as MemoryStream;
					FileStream fileStream = new FileStream(str2 + text5, FileMode.Create, FileAccess.Write);
					byte[] array = memoryStream.ToArray();
					fileStream.Write(array, 0, array.Length);
					fileStream.Flush();
					fileStream.Close();
					array = null;
					memoryStream = null;
					fileStream = null;
					MessageBox.Show(text5 + " 匯出成功", "匯出成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("匯出失敗，原因：" + ex.Message, "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				string str3 = "C:\\NIISOL\\";
				Utility.WriteToFile(str3 + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t匯出失敗，原因： " + ex.ToString(), 'A', "");
			}
		}

	}
}
