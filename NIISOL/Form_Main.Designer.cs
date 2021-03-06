namespace NIISOSL
{
    partial class Form_Main
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			label1 = new System.Windows.Forms.Label();
			btn_ImportBatchNo = new System.Windows.Forms.Button();
			btn_QueryRecord = new System.Windows.Forms.Button();
			btn_Statistics = new System.Windows.Forms.Button();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label16 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			btn_ReadCard = new System.Windows.Forms.Button();
			tb_Birthday = new System.Windows.Forms.DateTimePicker();
			tb_RocID = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			tb_CaseName = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			cb_Sex = new System.Windows.Forms.ComboBox();
			label14 = new System.Windows.Forms.Label();
			cb_BirthSeq = new System.Windows.Forms.ComboBox();
			label6 = new System.Windows.Forms.Label();
			tb_Birthday2 = new System.Windows.Forms.DateTimePicker();
			label5 = new System.Windows.Forms.Label();
			tb_ParentRocID = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			groupBox3 = new System.Windows.Forms.GroupBox();
			tb_Address = new System.Windows.Forms.TextBox();
			label8 = new System.Windows.Forms.Label();
			tb_Tel = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			groupBox4 = new System.Windows.Forms.GroupBox();
			btn_LoadRecord = new System.Windows.Forms.Button();
			btn_Del = new System.Windows.Forms.Button();
			btn_Cancel = new System.Windows.Forms.Button();
			btn_Edit = new System.Windows.Forms.Button();
			btn_Submit = new System.Windows.Forms.Button();
			tb_InoculationDate = new System.Windows.Forms.DateTimePicker();
			label13 = new System.Windows.Forms.Label();
			cb_BatchNo = new System.Windows.Forms.ComboBox();
			label11 = new System.Windows.Forms.Label();
			cb_VaccineNo = new System.Windows.Forms.ComboBox();
			label10 = new System.Windows.Forms.Label();
			cb_VaccineCode = new System.Windows.Forms.ComboBox();
			label9 = new System.Windows.Forms.Label();
			btn_Save = new System.Windows.Forms.Button();
			gv_Record = new System.Windows.Forms.DataGridView();
			Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_TmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_CaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_RocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_ParentRocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_InoculationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_VaccineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_VaccineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvtb_ExportedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			label15 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gv_Record).BeginInit();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			label1.Location = new System.Drawing.Point(12, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(104, 16);
			label1.TabIndex = 0;
			label1.Text = "預防接種登錄";
			btn_ImportBatchNo.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_ImportBatchNo.Location = new System.Drawing.Point(490, 9);
			btn_ImportBatchNo.Name = "btn_ImportBatchNo";
			btn_ImportBatchNo.Size = new System.Drawing.Size(115, 26);
			btn_ImportBatchNo.TabIndex = 1;
			btn_ImportBatchNo.Text = "疫苗批號匯入";
			btn_ImportBatchNo.UseVisualStyleBackColor = true;
			btn_ImportBatchNo.Click += new System.EventHandler(btn_ImportBatchNo_Click);
			btn_QueryRecord.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_QueryRecord.Location = new System.Drawing.Point(611, 9);
			btn_QueryRecord.Name = "btn_QueryRecord";
			btn_QueryRecord.Size = new System.Drawing.Size(115, 26);
			btn_QueryRecord.TabIndex = 2;
			btn_QueryRecord.Text = "接種紀錄明細";
			btn_QueryRecord.UseVisualStyleBackColor = true;
			btn_QueryRecord.Click += new System.EventHandler(btn_QueryRecord_Click);
			btn_Statistics.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_Statistics.Location = new System.Drawing.Point(732, 9);
			btn_Statistics.Name = "btn_Statistics";
			btn_Statistics.Size = new System.Drawing.Size(144, 26);
			btn_Statistics.TabIndex = 3;
			btn_Statistics.Text = "疫苗接種人次統計";
			btn_Statistics.UseVisualStyleBackColor = true;
			btn_Statistics.Click += new System.EventHandler(btn_Statistics_Click);
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(btn_ReadCard);
			groupBox1.Controls.Add(tb_Birthday);
			groupBox1.Controls.Add(tb_RocID);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(tb_CaseName);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			groupBox1.Location = new System.Drawing.Point(15, 52);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(874, 98);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "一、請插入健保IC卡讀取個案資料";
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(40, 29);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(152, 16);
			label16.TabIndex = 33;
			label16.Text = "或自行輸入個案資料";
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			label12.Location = new System.Drawing.Point(488, 61);
			label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(72, 16);
			label12.TabIndex = 32;
			label12.Text = "出生日期";
			btn_ReadCard.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_ReadCard.Location = new System.Drawing.Point(253, -1);
			btn_ReadCard.Name = "btn_ReadCard";
			btn_ReadCard.Size = new System.Drawing.Size(100, 28);
			btn_ReadCard.TabIndex = 27;
			btn_ReadCard.Text = "讀取";
			btn_ReadCard.UseVisualStyleBackColor = true;
			btn_ReadCard.Click += new System.EventHandler(btn_ReadCard_Click);
			tb_Birthday.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			tb_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			tb_Birthday.Location = new System.Drawing.Point(568, 58);
			tb_Birthday.Name = "tb_Birthday";
			tb_Birthday.Size = new System.Drawing.Size(114, 27);
			tb_Birthday.TabIndex = 26;
			tb_RocID.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			tb_RocID.Location = new System.Drawing.Point(310, 58);
			tb_RocID.Name = "tb_RocID";
			tb_RocID.Size = new System.Drawing.Size(156, 27);
			tb_RocID.TabIndex = 3;
			tb_RocID.TextChanged += new System.EventHandler(tb_RocID_TextChanged);
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(235, 61);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(72, 16);
			label3.TabIndex = 2;
			label3.Text = "身分證號";
			tb_CaseName.Location = new System.Drawing.Point(71, 58);
			tb_CaseName.Name = "tb_CaseName";
			tb_CaseName.Size = new System.Drawing.Size(151, 27);
			tb_CaseName.TabIndex = 1;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(25, 61);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(40, 16);
			label2.TabIndex = 0;
			label2.Text = "姓名";
			groupBox2.Controls.Add(cb_Sex);
			groupBox2.Controls.Add(label14);
			groupBox2.Controls.Add(cb_BirthSeq);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(tb_Birthday2);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(tb_ParentRocID);
			groupBox2.Controls.Add(label4);
			groupBox2.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			groupBox2.Location = new System.Drawing.Point(15, 156);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(874, 63);
			groupBox2.TabIndex = 5;
			groupBox2.TabStop = false;
			groupBox2.Text = "二、若個案沒有身分證號，請自行輸入以下欄位";
			cb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_Sex.FormattingEnabled = true;
			cb_Sex.Items.AddRange(new object[2]
			{
			"男",
			"女"
			});
			cb_Sex.Location = new System.Drawing.Point(618, 24);
			cb_Sex.Name = "cb_Sex";
			cb_Sex.Size = new System.Drawing.Size(64, 24);
			cb_Sex.TabIndex = 30;
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(524, 29);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(88, 16);
			label14.TabIndex = 29;
			label14.Text = "嬰幼兒性別";
			cb_BirthSeq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_BirthSeq.FormattingEnabled = true;
			cb_BirthSeq.Items.AddRange(new object[5]
			{
			"1",
			"2",
			"3",
			"4",
			"5"
			});
			cb_BirthSeq.Location = new System.Drawing.Point(779, 25);
			cb_BirthSeq.Name = "cb_BirthSeq";
			cb_BirthSeq.Size = new System.Drawing.Size(62, 24);
			cb_BirthSeq.TabIndex = 28;
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(701, 29);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(72, 16);
			label6.TabIndex = 6;
			label6.Text = "同胎次序";
			tb_Birthday2.CalendarFont = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			tb_Birthday2.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			tb_Birthday2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			tb_Birthday2.Location = new System.Drawing.Point(394, 24);
			tb_Birthday2.Name = "tb_Birthday2";
			tb_Birthday2.Size = new System.Drawing.Size(114, 27);
			tb_Birthday2.TabIndex = 27;
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(264, 29);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(120, 16);
			label5.TabIndex = 5;
			label5.Text = "嬰幼兒出生日期";
			tb_ParentRocID.Location = new System.Drawing.Point(147, 26);
			tb_ParentRocID.Name = "tb_ParentRocID";
			tb_ParentRocID.Size = new System.Drawing.Size(111, 27);
			tb_ParentRocID.TabIndex = 4;
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(23, 29);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(120, 16);
			label4.TabIndex = 1;
			label4.Text = "父或母身分證號";
			groupBox3.Controls.Add(tb_Address);
			groupBox3.Controls.Add(label8);
			groupBox3.Controls.Add(tb_Tel);
			groupBox3.Controls.Add(label7);
			groupBox3.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			groupBox3.Location = new System.Drawing.Point(15, 225);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new System.Drawing.Size(874, 63);
			groupBox3.TabIndex = 6;
			groupBox3.TabStop = false;
			groupBox3.Text = "三、聯絡資訊更新（非必填)";
			tb_Address.Location = new System.Drawing.Point(342, 26);
			tb_Address.Name = "tb_Address";
			tb_Address.Size = new System.Drawing.Size(519, 27);
			tb_Address.TabIndex = 7;
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(263, 32);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(72, 16);
			label8.TabIndex = 6;
			label8.Text = "通訊地址";
			tb_Tel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			tb_Tel.Location = new System.Drawing.Point(71, 26);
			tb_Tel.Name = "tb_Tel";
			tb_Tel.Size = new System.Drawing.Size(156, 27);
			tb_Tel.TabIndex = 5;
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(25, 32);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(40, 16);
			label7.TabIndex = 3;
			label7.Text = "電話";
			groupBox4.Controls.Add(btn_LoadRecord);
			groupBox4.Controls.Add(btn_Del);
			groupBox4.Controls.Add(btn_Cancel);
			groupBox4.Controls.Add(btn_Edit);
			groupBox4.Controls.Add(btn_Submit);
			groupBox4.Controls.Add(tb_InoculationDate);
			groupBox4.Controls.Add(label13);
			groupBox4.Controls.Add(cb_BatchNo);
			groupBox4.Controls.Add(label11);
			groupBox4.Controls.Add(cb_VaccineNo);
			groupBox4.Controls.Add(label10);
			groupBox4.Controls.Add(cb_VaccineCode);
			groupBox4.Controls.Add(label9);
			groupBox4.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			groupBox4.Location = new System.Drawing.Point(15, 294);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new System.Drawing.Size(874, 110);
			groupBox4.TabIndex = 7;
			groupBox4.TabStop = false;
			groupBox4.Text = "四、預防接種登錄";
			btn_LoadRecord.Location = new System.Drawing.Point(142, -1);
			btn_LoadRecord.Name = "btn_LoadRecord";
			btn_LoadRecord.Size = new System.Drawing.Size(193, 28);
			btn_LoadRecord.TabIndex = 32;
			btn_LoadRecord.Text = "檢視離線版接種資料";
			btn_LoadRecord.UseVisualStyleBackColor = true;
			btn_LoadRecord.Click += new System.EventHandler(btn_LoadRecord_Click);
			btn_Del.Location = new System.Drawing.Point(796, 69);
			btn_Del.Name = "btn_Del";
			btn_Del.Size = new System.Drawing.Size(62, 33);
			btn_Del.TabIndex = 31;
			btn_Del.Text = "刪除";
			btn_Del.UseVisualStyleBackColor = true;
			btn_Del.Visible = false;
			btn_Del.Click += new System.EventHandler(btn_Del_Click);
			btn_Cancel.Location = new System.Drawing.Point(728, 69);
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new System.Drawing.Size(62, 33);
			btn_Cancel.TabIndex = 30;
			btn_Cancel.Text = "取消";
			btn_Cancel.UseVisualStyleBackColor = true;
			btn_Cancel.Visible = false;
			btn_Cancel.Click += new System.EventHandler(btn_Cancel_Click);
			btn_Edit.Location = new System.Drawing.Point(660, 69);
			btn_Edit.Name = "btn_Edit";
			btn_Edit.Size = new System.Drawing.Size(62, 33);
			btn_Edit.TabIndex = 29;
			btn_Edit.Text = "修改";
			btn_Edit.UseVisualStyleBackColor = true;
			btn_Edit.Visible = false;
			btn_Edit.Click += new System.EventHandler(btn_Edit_Click);
			btn_Submit.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_Submit.Location = new System.Drawing.Point(376, 73);
			btn_Submit.Name = "btn_Submit";
			btn_Submit.Size = new System.Drawing.Size(116, 33);
			btn_Submit.TabIndex = 28;
			btn_Submit.Text = "建立接種資料";
			btn_Submit.UseVisualStyleBackColor = true;
			btn_Submit.Click += new System.EventHandler(btn_Submit_Click);
			tb_InoculationDate.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			tb_InoculationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			tb_InoculationDate.Location = new System.Drawing.Point(749, 33);
			tb_InoculationDate.Name = "tb_InoculationDate";
			tb_InoculationDate.Size = new System.Drawing.Size(114, 27);
			tb_InoculationDate.TabIndex = 27;
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(666, 37);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(80, 16);
			label13.TabIndex = 10;
			label13.Text = "*接種日期";
			cb_BatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_BatchNo.DropDownWidth = 160;
			cb_BatchNo.FormattingEnabled = true;
			cb_BatchNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			cb_BatchNo.Location = new System.Drawing.Point(485, 33);
			cb_BatchNo.Name = "cb_BatchNo";
			cb_BatchNo.Size = new System.Drawing.Size(167, 24);
			cb_BatchNo.TabIndex = 9;
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(402, 37);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(80, 16);
			label11.TabIndex = 8;
			label11.Text = "*疫苗批號";
			cb_VaccineNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_VaccineNo.FormattingEnabled = true;
			cb_VaccineNo.Location = new System.Drawing.Point(299, 33);
			cb_VaccineNo.Name = "cb_VaccineNo";
			cb_VaccineNo.Size = new System.Drawing.Size(90, 24);
			cb_VaccineNo.TabIndex = 7;
			cb_VaccineNo.SelectedIndexChanged += new System.EventHandler(cb_VaccineNo_SelectedIndexChanged);
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(229, 37);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(68, 16);
			label10.TabIndex = 6;
			label10.Text = "*劑別/型";
			cb_VaccineCode.DisplayMember = "VaccineCode";
			cb_VaccineCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_VaccineCode.DropDownWidth = 500;
			cb_VaccineCode.FormattingEnabled = true;
			cb_VaccineCode.Location = new System.Drawing.Point(91, 33);
			cb_VaccineCode.Name = "cb_VaccineCode";
			cb_VaccineCode.Size = new System.Drawing.Size(136, 24);
			cb_VaccineCode.TabIndex = 5;
			cb_VaccineCode.ValueMember = "VaccineCode";
			cb_VaccineCode.SelectedIndexChanged += new System.EventHandler(cb_VaccineCode_SelectedIndexChanged);
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(6, 37);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(80, 16);
			label9.TabIndex = 4;
			label9.Text = "*疫苗名稱";
			btn_Save.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			btn_Save.Location = new System.Drawing.Point(325, 596);
			btn_Save.Name = "btn_Save";
			btn_Save.Size = new System.Drawing.Size(250, 37);
			btn_Save.TabIndex = 29;
			btn_Save.Text = "儲存，並建立下一個案接種資料";
			btn_Save.UseVisualStyleBackColor = true;
			btn_Save.Click += new System.EventHandler(btn_Save_Click);
			gv_Record.AllowUserToAddRows = false;
			gv_Record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new System.Drawing.Font("新細明體", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			gv_Record.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			gv_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gv_Record.Columns.AddRange(Seq, gvtb_TmpID, gvtb_CaseName, gvtb_RocID, gvtb_ParentRocID, gvtb_InoculationDate, gvtb_VaccineCode, gvtb_VaccineNo, gvtb_BatchNo, gvtb_ExportedDate);
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			gv_Record.DefaultCellStyle = dataGridViewCellStyle2;
			gv_Record.Location = new System.Drawing.Point(15, 411);
			gv_Record.MultiSelect = false;
			gv_Record.Name = "gv_Record";
			gv_Record.ReadOnly = true;
			gv_Record.RowTemplate.Height = 24;
			gv_Record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			gv_Record.Size = new System.Drawing.Size(874, 177);
			gv_Record.TabIndex = 30;
			gv_Record.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(gv_Record_DataBindingComplete);
			gv_Record.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(gv_Record_RowHeaderMouseDoubleClick);
			gv_Record.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(gv_Record_UserDeletedRow);
			gv_Record.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(gv_Record_UserDeletingRow);
			Seq.DataPropertyName = "Seq";
			dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			Seq.DefaultCellStyle = dataGridViewCellStyle3;
			Seq.FillWeight = 23.86793f;
			Seq.HeaderText = "序號";
			Seq.MinimumWidth = 50;
			Seq.Name = "Seq";
			Seq.ReadOnly = true;
			Seq.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			gvtb_TmpID.DataPropertyName = "ID";
			gvtb_TmpID.HeaderText = "TmpID";
			gvtb_TmpID.Name = "gvtb_TmpID";
			gvtb_TmpID.ReadOnly = true;
			gvtb_TmpID.Visible = false;
			gvtb_CaseName.DataPropertyName = "CaseName";
			dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_CaseName.DefaultCellStyle = dataGridViewCellStyle4;
			gvtb_CaseName.HeaderText = "姓名";
			gvtb_CaseName.Name = "gvtb_CaseName";
			gvtb_CaseName.ReadOnly = true;
			gvtb_RocID.DataPropertyName = "RocID";
			dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_RocID.DefaultCellStyle = dataGridViewCellStyle5;
			gvtb_RocID.FillWeight = 107.8054f;
			gvtb_RocID.HeaderText = "身分證號";
			gvtb_RocID.Name = "gvtb_RocID";
			gvtb_RocID.ReadOnly = true;
			gvtb_ParentRocID.DataPropertyName = "ParentRocID";
			dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_ParentRocID.DefaultCellStyle = dataGridViewCellStyle6;
			gvtb_ParentRocID.FillWeight = 107.8054f;
			gvtb_ParentRocID.HeaderText = "父或母身分證號";
			gvtb_ParentRocID.Name = "gvtb_ParentRocID";
			gvtb_ParentRocID.ReadOnly = true;
			gvtb_InoculationDate.DataPropertyName = "InoculationDate";
			dataGridViewCellStyle7.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_InoculationDate.DefaultCellStyle = dataGridViewCellStyle7;
			gvtb_InoculationDate.FillWeight = 107.8054f;
			gvtb_InoculationDate.HeaderText = "接種日期";
			gvtb_InoculationDate.Name = "gvtb_InoculationDate";
			gvtb_InoculationDate.ReadOnly = true;
			gvtb_VaccineCode.DataPropertyName = "VaccineCode";
			dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_VaccineCode.DefaultCellStyle = dataGridViewCellStyle8;
			gvtb_VaccineCode.FillWeight = 107.8054f;
			gvtb_VaccineCode.HeaderText = "疫苗名稱";
			gvtb_VaccineCode.Name = "gvtb_VaccineCode";
			gvtb_VaccineCode.ReadOnly = true;
			gvtb_VaccineNo.DataPropertyName = "VaccineNo";
			dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_VaccineNo.DefaultCellStyle = dataGridViewCellStyle9;
			gvtb_VaccineNo.FillWeight = 77.8054f;
			gvtb_VaccineNo.HeaderText = "劑別/型";
			gvtb_VaccineNo.Name = "gvtb_VaccineNo";
			gvtb_VaccineNo.ReadOnly = true;
			gvtb_BatchNo.DataPropertyName = "VaccBatchNo";
			dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_BatchNo.DefaultCellStyle = dataGridViewCellStyle10;
			gvtb_BatchNo.FillWeight = 137.8054f;
			gvtb_BatchNo.HeaderText = "疫苗批號";
			gvtb_BatchNo.Name = "gvtb_BatchNo";
			gvtb_BatchNo.ReadOnly = true;
			gvtb_ExportedDate.DataPropertyName = "ExportedDate";
			dataGridViewCellStyle11.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			gvtb_ExportedDate.DefaultCellStyle = dataGridViewCellStyle11;
			gvtb_ExportedDate.FillWeight = 107.8054f;
			gvtb_ExportedDate.HeaderText = "匯出日期";
			gvtb_ExportedDate.Name = "gvtb_ExportedDate";
			gvtb_ExportedDate.ReadOnly = true;
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(21, 421);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(29, 12);
			label15.TabIndex = 31;
			label15.Text = "編輯";
			button1.Font = new System.Drawing.Font("新細明體", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			button1.Location = new System.Drawing.Point(369, 9);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(115, 26);
			button1.TabIndex = 33;
			button1.Text = "清除";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(901, 644);
			base.Controls.Add(button1);
			base.Controls.Add(label15);
			base.Controls.Add(gv_Record);
			base.Controls.Add(btn_Save);
			base.Controls.Add(groupBox4);
			base.Controls.Add(groupBox3);
			base.Controls.Add(groupBox2);
			base.Controls.Add(groupBox1);
			base.Controls.Add(btn_Statistics);
			base.Controls.Add(btn_QueryRecord);
			base.Controls.Add(btn_ImportBatchNo);
			base.Controls.Add(label1);
			Font = new System.Drawing.Font("新細明體", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 136);
			base.Name = "Form_Main";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "離線版預防接種登錄";
			base.Load += new System.EventHandler(Form_Main_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gv_Record).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_ImportBatchNo;
		private System.Windows.Forms.Button btn_QueryRecord;
		private System.Windows.Forms.Button btn_Statistics;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_ReadCard;
		private System.Windows.Forms.DateTimePicker tb_Birthday;
		private System.Windows.Forms.TextBox tb_RocID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_CaseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cb_BirthSeq;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker tb_Birthday2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_ParentRocID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tb_Address;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_Tel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn_Submit;
		private System.Windows.Forms.DateTimePicker tb_InoculationDate;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cb_BatchNo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cb_VaccineNo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cb_VaccineCode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView gv_Record;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Del;
		private System.Windows.Forms.ComboBox cb_Sex;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btn_LoadRecord;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridViewTextBoxColumn Seq;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_TmpID;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_CaseName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_RocID;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_ParentRocID;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_InoculationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_VaccineCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_VaccineNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_BatchNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn gvtb_ExportedDate;

	}
}
