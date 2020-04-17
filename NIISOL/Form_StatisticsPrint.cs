using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using T00SharedLibraryDotNet20;

namespace NIISOSL
{
    public partial class Form_StatisticsPrint : Form
    {
        public string constr = ConfigurationManager.ConnectionStrings["NIISOL.Properties.Settings.DataConnectionString"].ToString();

		public string startdate = "";

		public string enddate = "";

		public string vaccinecode = "";

		public string batchno = "";


		public Form_StatisticsPrint()
		{
			InitializeComponent();
		}

		private void Form_StatisticsPrint_Load(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			string str = "select VaccineCode 疫苗名稱,VaccineNo '劑別/型',VaccBatchNo 疫苗批號,AgencyCode 十碼章,count(*) 數量 from Record where LogicDel=0 AND InoculationDate>='" + startdate + "' and InoculationDate<='" + enddate + "' ";
			if (vaccinecode != "")
			{
				str = str + "and VaccineCode='" + vaccinecode + "' ";
			}
			if (batchno != "")
			{
				str = str + "and VaccBatchNo='" + batchno + "' ";
			}
			str += "group by VaccineCode,VaccineNo,VaccBatchNo,AgencyCode";
			dataTable = (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, str, null, CommandOperationType.ExecuteReaderReturnDataTable);
			gv_Data.DataSource = dataTable;
			lb_Cnt.Text = "資料總筆數︰" + dataTable.Rows.Count;
			lb_Date.Text = "製表日期︰" + Utility.ToRocDateString(DateTime.Now);
		}
	}
}
