using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using T00SharedLibraryDotNet20;

namespace NIISOSL
{
    public partial class Form_Main : Form
    {

		private struct SCARD_IO_REQUEST
		{
			public int dwProtocol;

			public int cbPciLength;
		}

		public string AgencyCode = "";

		public string UserName = "";

		public DataTable dt = new DataTable();

		public DataTable dt_VaccineData = new DataTable();

		public int tmpID = 0;

		public string EditTmpID = "";

		public List<string> DelIDs;


		[DllImport("WinScard.dll")]
		private static extern uint SCardEstablishContext(uint dwScope, int nNotUsed1, int nNotUsed2, ref int phContext);

		[DllImport("WinScard.dll")]
		private static extern uint SCardReleaseContext(int phContext);

		[DllImport("WinScard.dll")]
		private static extern uint SCardConnect(int hContext, string cReaderName, uint dwShareMode, uint dwPrefProtocol, ref int phCard, ref int ActiveProtocol);

		[DllImport("WinScard.dll")]
		private static extern uint SCardDisconnect(int hCard, int Disposition);

		[DllImport("WinScard.dll")]
		private static extern uint SCardListReaders(int hContext, byte[] mszGroups, byte[] mszReaders, ref int pcchReaders);

		[DllImport("WinScard.dll")]
		private static extern uint SCardTransmit(int hCard, ref SCARD_IO_REQUEST pioSendPci, byte[] pbSendBuffer, int cbSendLength, ref SCARD_IO_REQUEST pioRecvPci, ref byte pbRecvBuffer, ref int pcbRecvLength);

		public Form_Main()
		{
			InitializeComponent();
			InitForm();
			InitDataTable();
			InitVaccineData();
			base.FormClosing += Form_Main_FormClosing;
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			string sql = "select VaccineCode,VaccineNo,VaccBatchNo,VaccineCode || ' ('||ChName|| ')' ChName from VaccineData";
			DataTable dataTable = (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, sql, null, CommandOperationType.ExecuteReaderReturnDataTable);
			if (dataTable.Rows.Count == 0)
			{
				MessageBox.Show("尚未匯入疫苗批次資料，請先進行檔案匯入！", "系統提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Form_ImportBatchNo form_ImportBatchNo = new Form_ImportBatchNo();
				form_ImportBatchNo.FormClosed += ChildFormClosed;
				form_ImportBatchNo.AgencyCode = AgencyCode;
				form_ImportBatchNo.Show(this);
				Hide();
			}
		}

		private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (dt.Select("Modified = 1").Length != 0 && MessageBox.Show("個案施打紀錄尚未儲存，確定要離開嗎？", "紀錄尚未儲存", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		public void InitDataTable()
		{
			dt = new DataTable();
			dt.Columns.Add("Id", typeof(string));
			dt.Columns.Add("CaseName", typeof(string));
			dt.Columns.Add("RocID", typeof(string));
			dt.Columns.Add("Birthday", typeof(string));
			dt.Columns.Add("ParentRocID", typeof(string));
			dt.Columns.Add("BirthSeq", typeof(int));
			dt.Columns.Add("Tel", typeof(string));
			dt.Columns.Add("Address", typeof(string));
			dt.Columns.Add("VaccineCode", typeof(string));
			dt.Columns.Add("InoculationDate", typeof(string));
			dt.Columns.Add("VaccineNo", typeof(string));
			dt.Columns.Add("VaccBatchNo", typeof(string));
			dt.Columns.Add("IsFlu", typeof(int));
			dt.Columns.Add("AgencyCode", typeof(string));
			dt.Columns.Add("Sex", typeof(string));
			dt.Columns.Add("ExportedDate", typeof(string));
			dt.Columns.Add("Saved", typeof(int));
			dt.Columns.Add("Modified", typeof(int));
			BindGV(dt);
		}

		public void InitForm()
		{
			tb_CaseName.Text = "";
			tb_RocID.Text = "";
			tb_ParentRocID.Text = "";
			tb_Birthday.Text = DateTime.Now.ToString("yyyy/MM/dd");
			tb_Birthday2.Text = DateTime.Now.ToString("yyyy/MM/dd");
			tb_Address.Text = "";
			tb_Tel.Text = "";
			cb_BirthSeq.Text = "1";
			cb_Sex.SelectedIndex = 0;
			tb_InoculationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
			EditTmpID = "";
			DelIDs = new List<string>();
			btn_Edit.Visible = false;
			btn_Cancel.Visible = false;
			btn_Del.Visible = false;
			btn_Submit.Visible = true;
		}

		public void InitVaccineData()
		{
			dt_VaccineData.Clear();
			string sql = "select VaccineCode,VaccineNo,VaccBatchNo,VaccineCode || ' ('||ChName|| ')' ChName from VaccineData";
			dt_VaccineData = (DataTable)DataBaseUtilities.DBOperation(Program.ConnectionString, sql, null, CommandOperationType.ExecuteReaderReturnDataTable);
			Init_cb_VaccineCode();
			Init_cb_VaccineNo();
			Init_cb_BatchNo();
		}

		private void btn_LoadRecord_Click(object sender, EventArgs e)
		{
			DelIDs = new List<string>();
			DataRow[] array = dt.Select("Saved = 1");
			DataRow[] array2 = array;
			foreach (DataRow row in array2)
			{
				dt.Rows.Remove(row);
			}
			string text = "SELECT [Id], [CaseName], [RocID], [Birthday], [ParentRocID], [BirthSeq], [Tel], [Address], [VaccineCode], [InoculationDate], [VaccineNo], [VaccBatchNo], [IsFlu], [AgencyCode], [Sex], [ExportedDate], '1' [Saved], '0' [Modified] FROM Record WHERE LogicDel=0 AND ";
			dt = (DataTable)DataBaseUtilities.DBOperation(sql: (tb_RocID.Text.Trim() != "") ? (text + "RocID = '" + tb_RocID.Text + "' AND Birthday = '" + Utility.ToRocDateString(Convert.ToDateTime(tb_Birthday.Text)) + "'") : ((!(tb_ParentRocID.Text.Trim() != "")) ? (text + "InoculationDate = '" + Utility.ToRocDateString(Convert.ToDateTime(tb_InoculationDate.Text)) + "'") : (text + "ParentRocID = '" + tb_ParentRocID.Text + "' AND BirthSeq='" + cb_BirthSeq.Text + "' AND Birthday = '" + Utility.ToRocDateString(Convert.ToDateTime(tb_Birthday2.Text)) + "'")), ConnectionString: Program.ConnectionString, strParameterArray: null, cmdType: CommandOperationType.ExecuteReaderReturnDataTable);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("查無個案未刪除的接種資料", "接種資料查詢", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			BindGV(dt);
		}

		private void btn_Submit_Click(object sender, EventArgs e)
		{
			try
			{
				if (tb_RocID.Text.Trim() == "" && tb_ParentRocID.Text.Trim() == "")
				{
					MessageBox.Show("個案資料填寫不完整!", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (tb_RocID.Text != "" && !Utility.IsIdNo(tb_RocID.Text) && !Utility.IsResNo(tb_RocID.Text))
				{
					MessageBox.Show("證號輸入錯誤!", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					tb_RocID.Focus();
				}
				else if (tb_ParentRocID.Text != "" && !Utility.IsIdNo(tb_ParentRocID.Text) && !Utility.IsResNo(tb_ParentRocID.Text))
				{
					MessageBox.Show("父或母證號輸入錯誤!", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					tb_ParentRocID.Focus();
				}
				else if (cb_VaccineCode.SelectedValue.ToString() == "" || cb_VaccineNo.SelectedValue.ToString() == "" || cb_BatchNo.SelectedValue.ToString() == "")
				{
					MessageBox.Show("預防接種資料填寫不完整!", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (CheckRepeat_fuzzy() <= 0 || MessageBox.Show("本個案已有相同疫苗之接種紀錄，是否仍要建立此筆資料？", "重複施打警示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.No)
				{
					DataRow dataRow = dt.NewRow();
					if (tb_CaseName.Text.Trim() != "")
					{
						dataRow["CaseName"] = tb_CaseName.Text.Trim();
					}
					if (tb_RocID.Text.Trim() != "")
					{
						dataRow["RocID"] = tb_RocID.Text.Trim();
					}
					if (tb_Birthday.Text.Trim() != "" && tb_RocID.Text.Trim() != "")
					{
						dataRow["Birthday"] = Utility.ToRocDateString(Convert.ToDateTime(tb_Birthday.Text));
					}
					if (tb_ParentRocID.Text.Trim() != "")
					{
						dataRow["ParentRocID"] = tb_ParentRocID.Text.Trim();
					}
					if (tb_Birthday2.Text.Trim() != "" && tb_ParentRocID.Text.Trim() != "")
					{
						dataRow["Birthday"] = Utility.ToRocDateString(Convert.ToDateTime(tb_Birthday2.Text));
					}
					dataRow["BirthSeq"] = cb_BirthSeq.Text;
					if (tb_Tel.Text.Trim() != "")
					{
						dataRow["Tel"] = tb_Tel.Text.Trim();
					}
					if (tb_Address.Text.Trim() != "")
					{
						dataRow["Address"] = tb_Address.Text.Trim();
					}
					if (cb_VaccineCode.SelectedValue.ToString() != "")
					{
						dataRow["VaccineCode"] = cb_VaccineCode.SelectedValue.ToString();
					}
					if (cb_VaccineNo.SelectedValue.ToString() != "")
					{
						dataRow["VaccineNo"] = cb_VaccineNo.SelectedValue.ToString();
					}
					if (cb_BatchNo.SelectedValue.ToString() != "")
					{
						dataRow["VaccBatchNo"] = cb_BatchNo.SelectedValue.ToString();
					}
					if (tb_InoculationDate.Text.Trim() != "")
					{
						dataRow["InoculationDate"] = Utility.ToRocDateString(Convert.ToDateTime(tb_InoculationDate.Text));
					}
					if (cb_VaccineCode.SelectedValue.ToString().ToLower().IndexOf("flu") == -1)
					{
						dataRow["IsFlu"] = 0;
					}
					else
					{
						dataRow["IsFlu"] = 1;
					}
					if (tb_RocID.Text.Trim() != "")
					{
						dataRow["Sex"] = (tb_RocID.Text.Substring(1, 1).Equals("1") ? "M" : "F");
					}
					else
					{
						dataRow["Sex"] = (cb_Sex.SelectedItem.ToString().Equals("男") ? "M" : "F");
					}
					dataRow["AgencyCode"] = AgencyCode;
					dataRow["Id"] = tmpID.ToString();
					dataRow["Saved"] = "0";
					dataRow["Modified"] = "1";
					tmpID++;
					dt.Rows.Add(dataRow);
					BindGV(dt);
					gv_Record.CurrentCell = gv_Record.Rows[dt.Rows.Count - 1].Cells[0];
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("發生錯誤：" + ex.Message, "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				string str = "C:\\NIISOL\\";
				Utility.WriteToFile(str + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\tForm_Main.cs: " + ex.Message, 'A', "");
			}
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			DataRow[] array = dt.Select("Id = '" + EditTmpID + "'");
			array[0]["InoculationDate"] = Utility.ToRocDateString(Convert.ToDateTime(tb_InoculationDate.Text));
			array[0]["VaccineCode"] = cb_VaccineCode.SelectedValue.ToString();
			array[0]["VaccineNo"] = cb_VaccineNo.SelectedValue.ToString();
			array[0]["VaccBatchNo"] = cb_BatchNo.SelectedValue.ToString();
			array[0]["Modified"] = "1";
			BindGV(dt);
			EditTmpID = "";
			btn_Edit.Visible = false;
			btn_Cancel.Visible = false;
			btn_Del.Visible = false;
			btn_Submit.Visible = true;
			cb_VaccineCode.SelectedIndex = 0;
			cb_VaccineNo.SelectedIndex = 0;
			cb_BatchNo.SelectedIndex = 0;
			tb_InoculationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			EditTmpID = "";
			btn_Edit.Visible = false;
			btn_Cancel.Visible = false;
			btn_Del.Visible = false;
			btn_Submit.Visible = true;
			cb_VaccineCode.SelectedIndex = 0;
			cb_VaccineNo.SelectedIndex = 0;
			cb_BatchNo.SelectedIndex = 0;
			tb_InoculationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
		}

		private void btn_Del_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("確定要刪除資料嗎？", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				if (EditTmpID.IndexOf("tmp") == -1)
				{
					DelIDs.Add(EditTmpID);
				}
				DataRow[] array = dt.Select("Id = '" + EditTmpID + "'");
				dt.Rows.Remove(array[0]);
				BindGV(dt);
				EditTmpID = "";
				btn_Edit.Visible = false;
				btn_Cancel.Visible = false;
				btn_Del.Visible = false;
				btn_Submit.Visible = true;
				cb_VaccineCode.SelectedIndex = 0;
				cb_VaccineNo.SelectedIndex = 0;
				cb_BatchNo.SelectedIndex = 0;
				tb_InoculationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
			}
		}

		private void cb_VaccineCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			Init_cb_VaccineNo();
			Init_cb_BatchNo();
		}

		private void cb_VaccineNo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Init_cb_BatchNo();
		}

		private void Init_cb_VaccineCode()
		{
			if (dt_VaccineData.Rows.Count > 0)
			{
				DataTable dataSource = dt_VaccineData.DefaultView.ToTable(true, "VaccineCode", "ChName");
				cb_VaccineCode.DisplayMember = "ChName";
				cb_VaccineCode.ValueMember = "VaccineCode";
				cb_VaccineCode.DataSource = dataSource;
			}
		}

		private void Init_cb_VaccineNo()
		{
			if (dt_VaccineData.Rows.Count > 0)
			{
				DataRow[] array = dt_VaccineData.Select("VaccineCode='" + cb_VaccineCode.SelectedValue.ToString() + "'");
				DataTable dataTable = dt_VaccineData.Clone();
				for (int i = 0; i < array.Length; i++)
				{
					dataTable.ImportRow(array[i]);
				}
				cb_VaccineNo.DisplayMember = "VaccineNo";
				cb_VaccineNo.ValueMember = "VaccineNo";
				cb_VaccineNo.DataSource = dataTable.DefaultView.ToTable(true, "VaccineNo");
			}
		}

		private void Init_cb_BatchNo()
		{
			if (dt_VaccineData.Rows.Count > 0)
			{
				DataRow[] array = dt_VaccineData.Select("VaccineCode='" + cb_VaccineCode.SelectedValue.ToString() + "' and VaccineNo='" + cb_VaccineNo.SelectedValue.ToString() + "'");
				DataTable dataTable = dt_VaccineData.Clone();
				for (int i = 0; i < array.Length; i++)
				{
					dataTable.ImportRow(array[i]);
				}
				cb_BatchNo.DisplayMember = "VaccBatchNo";
				cb_BatchNo.ValueMember = "VaccBatchNo";
				cb_BatchNo.DataSource = dataTable.DefaultView.ToTable(true, "VaccBatchNo");
			}
		}

		private void btn_ReadCard_Click(object sender, EventArgs e)
		{
			int phContext = 0;
			int phCard = 0;
			int ActiveProtocol = 0;
			string empty = string.Empty;
			byte[] array = new byte[21]
			{
			0,
			164,
			4,
			0,
			16,
			209,
			88,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			17,
			0
			};
			byte[] array2 = new byte[7]
			{
			0,
			202,
			17,
			0,
			2,
			0,
			0
			};
			byte[] array3 = new byte[2];
			int pcbRecvLength = 2;
			byte[] array4 = new byte[59];
			int pcbRecvLength2 = 59;
			uint num = 0u;
			num = SCardEstablishContext(0u, 0, 0, ref phContext);
			if (num != 0)
			{
				MessageBox.Show(ErrCode.errMsg(num), "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			int num2 = 0;
			byte[] array5 = new byte[num2];
			List<string> list = new List<string>();
			int pcchReaders = 0;
			num = SCardListReaders(phContext, null, null, ref pcchReaders);
			if (num == 0)
			{
				byte[] array6 = new byte[pcchReaders];
				num = SCardListReaders(phContext, null, array6, ref pcchReaders);
				if (num == 0)
				{
					ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
					string text = aSCIIEncoding.GetString(array6);
					int num3 = 0;
					char c = '\0';
					int num4 = pcchReaders;
					while (text[0] != c)
					{
						num3 = text.IndexOf(c);
						string text2 = text.Substring(0, num3);
						list.Add(text2);
						num4 -= text2.Length + 1;
						text = text.Substring(num3 + 1, num4);
					}
				}
			}
			if (num != 0)
			{
				MessageBox.Show("請確認卡片類別，並重新插卡", "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (list.Count == 0)
			{
				MessageBox.Show("請接上讀卡機裝置", "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				uint num5 = 0u;
				foreach (string item in list)
				{
					num = SCardConnect(phContext, item, 1u, 2u, ref phCard, ref ActiveProtocol);
					if (num != 0)
					{
						num5 = num;
					}
					else
					{
						SCARD_IO_REQUEST pioSendPci = default(SCARD_IO_REQUEST);
						SCARD_IO_REQUEST pioRecvPci = default(SCARD_IO_REQUEST);
						pioSendPci.dwProtocol = (pioRecvPci.dwProtocol = ActiveProtocol);
						pioSendPci.cbPciLength = (pioRecvPci.cbPciLength = 8);
						num = SCardTransmit(phCard, ref pioSendPci, array, array.Length, ref pioRecvPci, ref array3[0], ref pcbRecvLength);
						if (num == 0)
						{
							num = SCardTransmit(phCard, ref pioSendPci, array2, array2.Length, ref pioRecvPci, ref array4[0], ref pcbRecvLength2);
							if (num != 0)
							{
								MessageBox.Show(ErrCode.errMsg(num), "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
							else
							{
								try
								{
									if (dt.Select("Modified = 1").Length != 0)
									{
										if (MessageBox.Show("本個案接種資料未完成儲存，是否放棄儲存繼續讀取下一位個案？", "紀錄尚未儲存", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
										{
											return;
										}
										InitDataTable();
									}
									string text3 = Encoding.Default.GetString(array4, 0, 12).Replace("\0", "");
									double result = 0.0;
									double.TryParse(text3, out result);
									if (text3.Length != 12 || result == 0.0)
									{
										throw new Exception();
									}
									tb_CaseName.Text = Encoding.Default.GetString(array4, 12, 20).Replace("\0", "");
									tb_RocID.Text = Encoding.Default.GetString(array4, 32, 10);
									tb_Birthday.Text = Convert.ToInt32(Encoding.Default.GetString(array4, 42, 3)) + 1911 + "/" + Encoding.Default.GetString(array4, 45, 2) + "/" + Encoding.Default.GetString(array4, 47, 2);
									tb_Birthday2.Text = tb_Birthday.Text;
									cb_Sex.SelectedIndex = ((!tb_RocID.Text.Substring(1, 1).Equals("1")) ? 1 : 0);
								}
								catch (Exception ex)
								{
									MessageBox.Show("請確認卡片類別，並重新插卡", "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									string str = "C:\\NIISOL\\";
									Utility.WriteToFile(str + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t請確認卡片類別，並重新插卡,讀卡失敗" + ex.Message, 'A', "");
								}
							}
							SCardDisconnect(phCard, 0);
							break;
						}
						MessageBox.Show(ErrCode.errMsg(num), "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				if (num5 != 0)
				{
					MessageBox.Show(ErrCode.errMsg(num), "讀卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			SCardReleaseContext(phContext);
		}

		

		public void BindGV(DataTable dt)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Seq", typeof(int));
			dataTable.Columns.Add("Id", typeof(string));
			dataTable.Columns.Add("CaseName", typeof(string));
			dataTable.Columns.Add("RocID", typeof(string));
			dataTable.Columns.Add("ParentRocID", typeof(string));
			dataTable.Columns.Add("InoculationDate", typeof(string));
			dataTable.Columns.Add("VaccineCode", typeof(string));
			dataTable.Columns.Add("VaccineNo", typeof(string));
			dataTable.Columns.Add("VaccBatchNo", typeof(string));
			dataTable.Columns.Add("ExportedDate", typeof(string));
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["Seq"] = i + 1;
				dataRow["Id"] = dt.Rows[i]["Id"].ToString();
				dataRow["CaseName"] = dt.Rows[i]["CaseName"].ToString();
				dataRow["RocID"] = dt.Rows[i]["RocID"].ToString();
				dataRow["ParentRocID"] = dt.Rows[i]["ParentRocID"].ToString();
				dataRow["InoculationDate"] = dt.Rows[i]["InoculationDate"].ToString();
				dataRow["VaccineCode"] = dt.Rows[i]["VaccineCode"].ToString();
				dataRow["VaccineNo"] = dt.Rows[i]["VaccineNo"].ToString();
				dataRow["VaccBatchNo"] = dt.Rows[i]["VaccBatchNo"].ToString();
				dataRow["ExportedDate"] = dt.Rows[i]["ExportedDate"].ToString();
				dataTable.Rows.Add(dataRow);
			}
			gv_Record.DataSource = dataTable;
		}

		private void gv_Record_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			if (gv_Record.CurrentRow.Cells["gvtb_ExportedDate"].Value.ToString() != "")
			{
				MessageBox.Show("已匯出的接種紀錄無法編修", "編修資料", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (MessageBox.Show("確定要刪除資料嗎？", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				string text = gv_Record.CurrentRow.Cells["gvtb_TmpID"].Value.ToString();
				if (EditTmpID.IndexOf("tmp") == -1)
				{
					DelIDs.Add(text);
				}
				DataRow[] array = dt.Select("Id = '" + text + "'");
				dt.Rows.Remove(array[0]);
			}
		}

		private void gv_Record_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			BindGV(dt);
		}

		private void gv_Record_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (gv_Record.CurrentRow.Cells["gvtb_ExportedDate"].Value.ToString() != "")
			{
				MessageBox.Show("已匯出的接種紀錄無法編修", "編修資料", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text = EditTmpID = gv_Record.CurrentRow.Cells["gvtb_TmpID"].Value.ToString();
			tb_InoculationDate.Text = Utility.ToDateString(gv_Record.CurrentRow.Cells["gvtb_InoculationDate"].Value.ToString());
			cb_VaccineCode.SelectedValue = gv_Record.CurrentRow.Cells["gvtb_VaccineCode"].Value.ToString();
			cb_VaccineNo.SelectedValue = gv_Record.CurrentRow.Cells["gvtb_VaccineNo"].Value.ToString();
			cb_BatchNo.SelectedValue = gv_Record.CurrentRow.Cells["gvtb_BatchNo"].Value.ToString();
			btn_Submit.Visible = false;
			btn_Edit.Visible = true;
			btn_Cancel.Visible = true;
			btn_Del.Visible = true;
		}

		private void gv_Record_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (dt.Rows[i]["Modified"].ToString().Equals("1"))
				{
					gv_Record.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
				}
			}
		}

		private void btn_ImportBatchNo_Click(object sender, EventArgs e)
		{
			if (dt.Select("Modified = 1").Length == 0 || MessageBox.Show("個案施打紀錄尚未儲存，確定要離開嗎？", "紀錄尚未儲存", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				Form_ImportBatchNo form_ImportBatchNo = new Form_ImportBatchNo();
				form_ImportBatchNo.FormClosed += ChildFormClosed;
				form_ImportBatchNo.AgencyCode = AgencyCode;
				form_ImportBatchNo.Show(this);
				Hide();
			}
		}

		private void btn_QueryRecord_Click(object sender, EventArgs e)
		{
			if (dt.Select("Modified = 1").Length == 0 || MessageBox.Show("個案施打紀錄尚未儲存，確定要離開嗎？", "紀錄尚未儲存", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				Form_QueryRecord form_QueryRecord = new Form_QueryRecord();
				form_QueryRecord.FormClosed += ChildFormClosed;
				form_QueryRecord.Show(this);
				Hide();
			}
		}

		private void btn_Statistics_Click(object sender, EventArgs e)
		{
			if (dt.Select("Modified = 1").Length == 0 || MessageBox.Show("個案施打紀錄尚未儲存，確定要離開嗎？", "紀錄尚未儲存", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				Form_Statistics form_Statistics = new Form_Statistics();
				form_Statistics.FormClosed += ChildFormClosed;
				form_Statistics.Show(this);
				Hide();
			}
		}

		private void ChildFormClosed(object sender, FormClosedEventArgs e)
		{
			Show();
			InitForm();
			InitDataTable();
			InitVaccineData();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string text = string.Join(",", DelIDs.ToArray());
			bool flag = false;
			DataRow[] array = dt.Select("ExportedDate is not null");
			DataRow[] array2 = array;
			foreach (DataRow row in array2)
			{
				dt.Rows.Remove(row);
			}
			if (text != "")
			{
				string sql = "DELETE FROM RECORD WHERE ID IN (" + text + ")";
				DataBaseUtilities.DBOperation(Program.ConnectionString, sql, new string[0], CommandOperationType.ExecuteNonQuery);
			}
			for (int j = 0; j < dt.Rows.Count; j++)
			{
				DataRow dataRow = dt.Rows[j];
				string text2 = "";
				string text3 = dataRow["VaccineCode"].ToString();
				string text4 = dataRow["VaccineNo"].ToString();
				string text5 = dataRow["VaccBatchNo"].ToString();
				string text6 = dataRow["InoculationDate"].ToString();
				text2 = ((!dataRow["Saved"].ToString().Equals("1")) ? ("INSERT INTO Record (CaseName,RocID,Birthday,ParentRocID,BirthSeq,Tel,Address,VaccineCode,InoculationDate,VaccineNo,VaccBatchNo,AgencyCode,Sex,IsFlu) VALUES ('" + dataRow["CaseName"].ToString() + "','" + dataRow["RocID"].ToString() + "','" + dataRow["Birthday"].ToString() + "','" + dataRow["ParentRocID"].ToString() + "','" + dataRow["BirthSeq"].ToString() + "','" + dataRow["Tel"].ToString() + "','" + dataRow["Address"].ToString() + "','" + dataRow["VaccineCode"].ToString() + "','" + dataRow["InoculationDate"].ToString() + "','" + dataRow["VaccineNo"].ToString() + "','" + dataRow["VaccBatchNo"].ToString() + "','" + dataRow["AgencyCode"].ToString() + "','" + dataRow["Sex"].ToString() + "','" + dataRow["IsFlu"].ToString() + "')") : ("UPDATE Record SET VaccineCode='" + text3 + "',VaccineNo='" + text4 + "',VaccBatchNo='" + text5 + "',InoculationDate='" + text6 + "' WHERE Id='" + dataRow["Id"].ToString() + "'"));
				try
				{
					DataBaseUtilities.DBOperation(Program.ConnectionString, text2, new string[0], CommandOperationType.ExecuteNonQuery);
				}
				catch (Exception ex)
				{
					flag = true;
					MessageBox.Show("錯誤原因：" + ex.Message, "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					string str = "C:\\NIISOL\\";
					Utility.WriteToFile(str + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t新增個案儲存失敗: " + ex.Message, 'A', "");
				}
			}
			InitDataTable();
			InitForm();
			if (!flag)
			{
				MessageBox.Show("儲存成功!", "儲存接種資料", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void tb_RocID_TextChanged(object sender, EventArgs e)
		{
			if (tb_RocID.Text.Length > 2)
			{
				cb_Sex.SelectedIndex = ((!tb_RocID.Text.Substring(1, 1).Equals("1")) ? 1 : 0);
			}
		}

		private int CheckRepeat_fuzzy()
		{
			int num = 0;
			DataTable dataTable = new DataTable();
			string text = "SELECT * FROM Record WHERE LogicDel=0 AND VaccineCode = '" + cb_VaccineCode.SelectedValue.ToString() + "' AND ";
			dataTable = (DataTable)DataBaseUtilities.DBOperation(sql: (!(tb_RocID.Text.Trim() != "")) ? (text + "ParentRocID = '" + tb_ParentRocID.Text + "' AND BirthSeq='" + cb_BirthSeq.Text + "' AND Birthday = '" + Utility.ToRocDateString(Convert.ToDateTime(tb_Birthday2.Text)) + "' and (ExportedDate is null or ExportedDate='" + Utility.ToRocDateString(DateTime.Now) + "')") : (text + "RocID = '" + tb_RocID.Text + "' AND Birthday = '" + Utility.ToRocDateString(Convert.ToDateTime(tb_Birthday.Text)) + "' and (ExportedDate is null or ExportedDate='" + Utility.ToRocDateString(DateTime.Now) + "')"), ConnectionString: Program.ConnectionString, strParameterArray: null, cmdType: CommandOperationType.ExecuteReaderReturnDataTable);
			if (tb_RocID.Text.Trim() != "")
			{
				DataRow[] array = dt.Select("VaccineCode='" + cb_VaccineCode.SelectedValue.ToString() + "' and RocID = '" + tb_RocID.Text + "'");
				return dataTable.Rows.Count + array.Length;
			}
			DataRow[] array2 = dt.Select("VaccineCode='" + cb_VaccineCode.SelectedValue.ToString() + "' and ParentRocID = '" + tb_ParentRocID.Text + "'");
			return dataTable.Rows.Count + array2.Length;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			InitDataTable();
			InitForm();
		}
	}
}
