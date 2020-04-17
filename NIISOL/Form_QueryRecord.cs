using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using T00SharedLibraryDotNet20;

namespace NIISOSL
{
    public partial class Form_QueryRecord : Form
    {
		public Form_QueryRecord()
		{
			InitializeComponent();
		}

		private DataTable getData()
		{
			DataTable dataTable = new DataTable();
			string sql = "SELECT * FROM VaccineData";
			return (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, sql, null, CommandOperationType.ExecuteReaderReturnDataTable);
		}

		private void btn_Export_Click(object sender, EventArgs e)
		{
			int a = 0;
			if (rb_NoExport.Checked)
			{
				a = 0;
			}
			else if (rb_AllData.Checked)
			{
				a = 1;
			}
			Form_Export form_Export = new Form_Export(a);
			form_Export.ShowDialog();
			dv_Data.DataSource = new DataTable();
			lb_DataCnt.Text = "";
		}

		private void btn_Back_Click(object sender, EventArgs e)
		{
			base.Owner.Show();
			Close();
		}

		private void btn_Statistics_Click(object sender, EventArgs e)
		{
			Form_Statistics form_Statistics = new Form_Statistics();
			form_Statistics.FormClosed += Fs_FormClosed;
			form_Statistics.Show(this);
			Hide();
		}

		private void btn_Query_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			string str = "SELECT (select count(*) from Record b  where a.id >= b.id and LogicDel=0) as '序號', CaseName as '姓名', RocID as '身分證號', Birthday as '出生日期',InoculationDate as '接種日期',VaccineCode as '疫苗名稱',VaccineNo as '劑別/型', VaccBatchNo as '疫苗批號', ParentRocID as '父或母身分證號',BirthSeq as '同胎次序',Tel as '電話', Address as '通訊地址', ExportedDate as '匯出日期' from Record as a where LogicDel=0 ";
			if (tb_CaseName.Text.Trim() != "")
			{
				str = str + "and CaseName='" + tb_CaseName.Text.Trim() + "' ";
			}
			if (tb_RocID.Text.Trim() != "")
			{
				str = str + "and RocID='" + tb_RocID.Text.Trim() + "' ";
			}
			if (tb_ParentRocID.Text.Trim() != "")
			{
				str = str + "and ParentRocID='" + tb_ParentRocID.Text.Trim() + "' ";
			}
			if (rb_AllData.Checked)
			{
				str = str + "and (ExportedDate is null or ExportedDate='" + Utility.ToRocDateString(DateTime.Now) + "')";
			}
			else if (rb_NoExport.Checked)
			{
				str += "and ExportedDate is null ";
			}
			str += "ORDER BY 序號 ASC;";
			dataTable = (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, str, null, CommandOperationType.ExecuteReaderReturnDataTable);
			dv_Data.DataSource = dataTable;
			lb_DataCnt.Text = "查詢結果：共 " + dataTable.Rows.Count + " 筆資料";
		}

		private void Fs_FormClosed(object sender, FormClosedEventArgs e)
		{
			Show();
		}

		private void btn_Clean_Click(object sender, EventArgs e)
		{
			tb_CaseName.Clear();
			tb_RocID.Clear();
			tb_ParentRocID.Clear();
			dv_Data.DataSource = new DataTable();
		}
	}
}
