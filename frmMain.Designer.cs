namespace Samjee
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mns_TopMenu = new System.Windows.Forms.MenuStrip();
            this.btn_File = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_BackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Program = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_About = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Line = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.sts_BottomMenu = new System.Windows.Forms.StatusStrip();
            this.tbc_MainTab = new System.Windows.Forms.TabControl();
            this.tab_Dashboard = new System.Windows.Forms.TabPage();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.ctx_LastCalculateLevel = new System.Windows.Forms.Label();
            this.ctx_LastLearningLevel = new System.Windows.Forms.Label();
            this.ctx_LastCalculate = new System.Windows.Forms.Label();
            this.lbl_LastCalculateLevel = new System.Windows.Forms.Label();
            this.lbl_LastLearningLevel = new System.Windows.Forms.Label();
            this.lbl_LastCalculate = new System.Windows.Forms.Label();
            this.ctx_LastLearning = new System.Windows.Forms.Label();
            this.ctx_TotalExpenses = new System.Windows.Forms.Label();
            this.ctx_TotalIncomes = new System.Windows.Forms.Label();
            this.lbl_LastLearning = new System.Windows.Forms.Label();
            this.lbl_TotalExpenses = new System.Windows.Forms.Label();
            this.lbl_TotlaIncomes = new System.Windows.Forms.Label();
            this.tab_AICalc = new System.Windows.Forms.TabPage();
            this.cmb_CalcIncomeList = new System.Windows.Forms.ComboBox();
            this.lbl_CalcIncomeList = new System.Windows.Forms.Label();
            this.cmb_CalcExpenseList = new System.Windows.Forms.ComboBox();
            this.lbl_CalcExpenseList = new System.Windows.Forms.Label();
            this.lbl_CalcExpenseValue = new System.Windows.Forms.Label();
            this.lbl_CalcIncomeValue = new System.Windows.Forms.Label();
            this.lbl_CalcExpenses = new System.Windows.Forms.Label();
            this.lbl_CalcTransactionsList = new System.Windows.Forms.Label();
            this.lbl_CalcIncomes = new System.Windows.Forms.Label();
            this.lbl_CalcListName = new System.Windows.Forms.Label();
            this.lbl_CalcExpenseTitle = new System.Windows.Forms.Label();
            this.lbl_CalcIncomeTitle = new System.Windows.Forms.Label();
            this.btn_CalcSaveList = new System.Windows.Forms.Button();
            this.btn_CalcSaveExpense = new System.Windows.Forms.Button();
            this.btn_CalcSaveIncome = new System.Windows.Forms.Button();
            this.txt_CalcExpenseValue = new System.Windows.Forms.TextBox();
            this.txt_CalcIncomeValue = new System.Windows.Forms.TextBox();
            this.txt_CalcListName = new System.Windows.Forms.TextBox();
            this.txt_CalcExpenseTitle = new System.Windows.Forms.TextBox();
            this.txt_CalcIncomeTitle = new System.Windows.Forms.TextBox();
            this.dgv_CalcTransactions = new System.Windows.Forms.DataGridView();
            this.cms_CalcTransactionsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_CalculateList = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ShowListInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_CalcIncomes = new System.Windows.Forms.DataGridView();
            this.dgv_CalcExpenses = new System.Windows.Forms.DataGridView();
            this.tab_MachineLearning = new System.Windows.Forms.TabPage();
            this.cmb_MLIncomeList = new System.Windows.Forms.ComboBox();
            this.lbl_MLIncomeList = new System.Windows.Forms.Label();
            this.cmb_MLExpenseList = new System.Windows.Forms.ComboBox();
            this.lbl_MLExpenseList = new System.Windows.Forms.Label();
            this.lbl_MLExpenseValue = new System.Windows.Forms.Label();
            this.lbl_MLIncomeValue = new System.Windows.Forms.Label();
            this.lbl_MLExpneses = new System.Windows.Forms.Label();
            this.lbl_MLTransactionsList = new System.Windows.Forms.Label();
            this.lbl_MLIncomes = new System.Windows.Forms.Label();
            this.lbl_MLListLevel = new System.Windows.Forms.Label();
            this.lbl_MLListName = new System.Windows.Forms.Label();
            this.lbl_MLExpenseTitle = new System.Windows.Forms.Label();
            this.lbl_MLIncomeTitle = new System.Windows.Forms.Label();
            this.btn_MLSaveList = new System.Windows.Forms.Button();
            this.btn_MLSaveExpense = new System.Windows.Forms.Button();
            this.btn_MLSaveIncome = new System.Windows.Forms.Button();
            this.txt_MLExpenseValue = new System.Windows.Forms.TextBox();
            this.txt_MLIncomeValue = new System.Windows.Forms.TextBox();
            this.txt_MLListLevel = new System.Windows.Forms.TextBox();
            this.txt_MLListName = new System.Windows.Forms.TextBox();
            this.txt_MLExpenseTitle = new System.Windows.Forms.TextBox();
            this.txt_MLIncomeTitle = new System.Windows.Forms.TextBox();
            this.dgv_MLTransactionsList = new System.Windows.Forms.DataGridView();
            this.col_MLListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLListCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLListLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLListIncomesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLListExpenseNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MLIncomes = new System.Windows.Forms.DataGridView();
            this.col_MLIncomeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLIncomeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLIncomeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLIncomeCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLIncomeList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MLExpenses = new System.Windows.Forms.DataGridView();
            this.col_MLExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLExpenseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLExpenseCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MLExpenseList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLListCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLListLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLListIncomeNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLListExpenseNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLIncomeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLIncomeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLIncomeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLIncomeCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLIncomeList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLExpenseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLExpenseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLExpenseCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CLExpenseList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mns_TopMenu.SuspendLayout();
            this.tbc_MainTab.SuspendLayout();
            this.tab_Dashboard.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.tab_AICalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CalcTransactions)).BeginInit();
            this.cms_CalcTransactionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CalcIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CalcExpenses)).BeginInit();
            this.tab_MachineLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MLTransactionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MLIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MLExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_TopMenu
            // 
            this.mns_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_File,
            this.btn_Program});
            this.mns_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.mns_TopMenu.Name = "mns_TopMenu";
            this.mns_TopMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mns_TopMenu.Size = new System.Drawing.Size(886, 24);
            this.mns_TopMenu.TabIndex = 0;
            this.mns_TopMenu.Text = "menuStrip1";
            // 
            // btn_File
            // 
            this.btn_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_BackUp});
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(40, 20);
            this.btn_File.Text = "فایل";
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Size = new System.Drawing.Size(106, 22);
            this.btn_BackUp.Text = "بک آپ";
            // 
            // btn_Program
            // 
            this.btn_Program.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_About,
            this.lbl_Line,
            this.btn_Exit});
            this.btn_Program.Name = "btn_Program";
            this.btn_Program.Size = new System.Drawing.Size(47, 20);
            this.btn_Program.Text = "برنامه";
            // 
            // btn_About
            // 
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(115, 22);
            this.btn_About.Text = "درباره ما";
            // 
            // lbl_Line
            // 
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(112, 6);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(115, 22);
            this.btn_Exit.Text = "خروج";
            // 
            // sts_BottomMenu
            // 
            this.sts_BottomMenu.Location = new System.Drawing.Point(0, 612);
            this.sts_BottomMenu.Name = "sts_BottomMenu";
            this.sts_BottomMenu.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sts_BottomMenu.Size = new System.Drawing.Size(886, 22);
            this.sts_BottomMenu.TabIndex = 1;
            this.sts_BottomMenu.Text = "statusStrip1";
            // 
            // tbc_MainTab
            // 
            this.tbc_MainTab.Controls.Add(this.tab_Dashboard);
            this.tbc_MainTab.Controls.Add(this.tab_AICalc);
            this.tbc_MainTab.Controls.Add(this.tab_MachineLearning);
            this.tbc_MainTab.Location = new System.Drawing.Point(13, 28);
            this.tbc_MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_MainTab.Name = "tbc_MainTab";
            this.tbc_MainTab.SelectedIndex = 0;
            this.tbc_MainTab.Size = new System.Drawing.Size(860, 580);
            this.tbc_MainTab.TabIndex = 2;
            // 
            // tab_Dashboard
            // 
            this.tab_Dashboard.Controls.Add(this.pnl_Info);
            this.tab_Dashboard.Location = new System.Drawing.Point(4, 25);
            this.tab_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Dashboard.Name = "tab_Dashboard";
            this.tab_Dashboard.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Dashboard.Size = new System.Drawing.Size(852, 551);
            this.tab_Dashboard.TabIndex = 0;
            this.tab_Dashboard.Text = "داشبورد";
            this.tab_Dashboard.UseVisualStyleBackColor = true;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.ctx_LastCalculateLevel);
            this.pnl_Info.Controls.Add(this.ctx_LastLearningLevel);
            this.pnl_Info.Controls.Add(this.ctx_LastCalculate);
            this.pnl_Info.Controls.Add(this.lbl_LastCalculateLevel);
            this.pnl_Info.Controls.Add(this.lbl_LastLearningLevel);
            this.pnl_Info.Controls.Add(this.lbl_LastCalculate);
            this.pnl_Info.Controls.Add(this.ctx_LastLearning);
            this.pnl_Info.Controls.Add(this.ctx_TotalExpenses);
            this.pnl_Info.Controls.Add(this.ctx_TotalIncomes);
            this.pnl_Info.Controls.Add(this.lbl_LastLearning);
            this.pnl_Info.Controls.Add(this.lbl_TotalExpenses);
            this.pnl_Info.Controls.Add(this.lbl_TotlaIncomes);
            this.pnl_Info.Location = new System.Drawing.Point(550, 19);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(284, 392);
            this.pnl_Info.TabIndex = 0;
            // 
            // ctx_LastCalculateLevel
            // 
            this.ctx_LastCalculateLevel.AutoSize = true;
            this.ctx_LastCalculateLevel.Location = new System.Drawing.Point(19, 152);
            this.ctx_LastCalculateLevel.Name = "ctx_LastCalculateLevel";
            this.ctx_LastCalculateLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctx_LastCalculateLevel.Size = new System.Drawing.Size(14, 16);
            this.ctx_LastCalculateLevel.TabIndex = 1;
            this.ctx_LastCalculateLevel.Text = "0";
            // 
            // ctx_LastLearningLevel
            // 
            this.ctx_LastLearningLevel.AutoSize = true;
            this.ctx_LastLearningLevel.Location = new System.Drawing.Point(19, 125);
            this.ctx_LastLearningLevel.Name = "ctx_LastLearningLevel";
            this.ctx_LastLearningLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctx_LastLearningLevel.Size = new System.Drawing.Size(14, 16);
            this.ctx_LastLearningLevel.TabIndex = 1;
            this.ctx_LastLearningLevel.Text = "0";
            // 
            // ctx_LastCalculate
            // 
            this.ctx_LastCalculate.AutoSize = true;
            this.ctx_LastCalculate.Location = new System.Drawing.Point(19, 97);
            this.ctx_LastCalculate.Name = "ctx_LastCalculate";
            this.ctx_LastCalculate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctx_LastCalculate.Size = new System.Drawing.Size(71, 16);
            this.ctx_LastCalculate.TabIndex = 1;
            this.ctx_LastCalculate.Text = "0001/01/01";
            // 
            // lbl_LastCalculateLevel
            // 
            this.lbl_LastCalculateLevel.AutoSize = true;
            this.lbl_LastCalculateLevel.Location = new System.Drawing.Point(166, 152);
            this.lbl_LastCalculateLevel.Name = "lbl_LastCalculateLevel";
            this.lbl_LastCalculateLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_LastCalculateLevel.Size = new System.Drawing.Size(108, 16);
            this.lbl_LastCalculateLevel.TabIndex = 2;
            this.lbl_LastCalculateLevel.Text = "سطح آخرین محاسبه:";
            // 
            // lbl_LastLearningLevel
            // 
            this.lbl_LastLearningLevel.AutoSize = true;
            this.lbl_LastLearningLevel.Location = new System.Drawing.Point(166, 125);
            this.lbl_LastLearningLevel.Name = "lbl_LastLearningLevel";
            this.lbl_LastLearningLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_LastLearningLevel.Size = new System.Drawing.Size(113, 16);
            this.lbl_LastLearningLevel.TabIndex = 2;
            this.lbl_LastLearningLevel.Text = "سطح آخرین یادگیری:";
            // 
            // lbl_LastCalculate
            // 
            this.lbl_LastCalculate.AutoSize = true;
            this.lbl_LastCalculate.Location = new System.Drawing.Point(166, 97);
            this.lbl_LastCalculate.Name = "lbl_LastCalculate";
            this.lbl_LastCalculate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_LastCalculate.Size = new System.Drawing.Size(80, 16);
            this.lbl_LastCalculate.TabIndex = 2;
            this.lbl_LastCalculate.Text = "آخرین محاسبه:";
            // 
            // ctx_LastLearning
            // 
            this.ctx_LastLearning.AutoSize = true;
            this.ctx_LastLearning.Location = new System.Drawing.Point(19, 71);
            this.ctx_LastLearning.Name = "ctx_LastLearning";
            this.ctx_LastLearning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctx_LastLearning.Size = new System.Drawing.Size(71, 16);
            this.ctx_LastLearning.TabIndex = 0;
            this.ctx_LastLearning.Text = "0001/01/01";
            // 
            // ctx_TotalExpenses
            // 
            this.ctx_TotalExpenses.AutoSize = true;
            this.ctx_TotalExpenses.Location = new System.Drawing.Point(19, 43);
            this.ctx_TotalExpenses.Name = "ctx_TotalExpenses";
            this.ctx_TotalExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctx_TotalExpenses.Size = new System.Drawing.Size(14, 16);
            this.ctx_TotalExpenses.TabIndex = 0;
            this.ctx_TotalExpenses.Text = "0";
            // 
            // ctx_TotalIncomes
            // 
            this.ctx_TotalIncomes.AutoSize = true;
            this.ctx_TotalIncomes.Location = new System.Drawing.Point(19, 17);
            this.ctx_TotalIncomes.Name = "ctx_TotalIncomes";
            this.ctx_TotalIncomes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctx_TotalIncomes.Size = new System.Drawing.Size(14, 16);
            this.ctx_TotalIncomes.TabIndex = 0;
            this.ctx_TotalIncomes.Text = "0";
            // 
            // lbl_LastLearning
            // 
            this.lbl_LastLearning.AutoSize = true;
            this.lbl_LastLearning.Location = new System.Drawing.Point(166, 71);
            this.lbl_LastLearning.Name = "lbl_LastLearning";
            this.lbl_LastLearning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_LastLearning.Size = new System.Drawing.Size(85, 16);
            this.lbl_LastLearning.TabIndex = 0;
            this.lbl_LastLearning.Text = "آخرین یادگیری:";
            // 
            // lbl_TotalExpenses
            // 
            this.lbl_TotalExpenses.AutoSize = true;
            this.lbl_TotalExpenses.Location = new System.Drawing.Point(166, 43);
            this.lbl_TotalExpenses.Name = "lbl_TotalExpenses";
            this.lbl_TotalExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_TotalExpenses.Size = new System.Drawing.Size(105, 16);
            this.lbl_TotalExpenses.TabIndex = 0;
            this.lbl_TotalExpenses.Text = "تعداد کل خروجی‌ها:";
            // 
            // lbl_TotlaIncomes
            // 
            this.lbl_TotlaIncomes.AutoSize = true;
            this.lbl_TotlaIncomes.Location = new System.Drawing.Point(166, 17);
            this.lbl_TotlaIncomes.Name = "lbl_TotlaIncomes";
            this.lbl_TotlaIncomes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_TotlaIncomes.Size = new System.Drawing.Size(100, 16);
            this.lbl_TotlaIncomes.TabIndex = 0;
            this.lbl_TotlaIncomes.Text = "تعداد کل ورودی‌ها:";
            // 
            // tab_AICalc
            // 
            this.tab_AICalc.Controls.Add(this.cmb_CalcIncomeList);
            this.tab_AICalc.Controls.Add(this.lbl_CalcIncomeList);
            this.tab_AICalc.Controls.Add(this.cmb_CalcExpenseList);
            this.tab_AICalc.Controls.Add(this.lbl_CalcExpenseList);
            this.tab_AICalc.Controls.Add(this.lbl_CalcExpenseValue);
            this.tab_AICalc.Controls.Add(this.lbl_CalcIncomeValue);
            this.tab_AICalc.Controls.Add(this.lbl_CalcExpenses);
            this.tab_AICalc.Controls.Add(this.lbl_CalcTransactionsList);
            this.tab_AICalc.Controls.Add(this.lbl_CalcIncomes);
            this.tab_AICalc.Controls.Add(this.lbl_CalcListName);
            this.tab_AICalc.Controls.Add(this.lbl_CalcExpenseTitle);
            this.tab_AICalc.Controls.Add(this.lbl_CalcIncomeTitle);
            this.tab_AICalc.Controls.Add(this.btn_CalcSaveList);
            this.tab_AICalc.Controls.Add(this.btn_CalcSaveExpense);
            this.tab_AICalc.Controls.Add(this.btn_CalcSaveIncome);
            this.tab_AICalc.Controls.Add(this.txt_CalcExpenseValue);
            this.tab_AICalc.Controls.Add(this.txt_CalcIncomeValue);
            this.tab_AICalc.Controls.Add(this.txt_CalcListName);
            this.tab_AICalc.Controls.Add(this.txt_CalcExpenseTitle);
            this.tab_AICalc.Controls.Add(this.txt_CalcIncomeTitle);
            this.tab_AICalc.Controls.Add(this.dgv_CalcTransactions);
            this.tab_AICalc.Controls.Add(this.dgv_CalcIncomes);
            this.tab_AICalc.Controls.Add(this.dgv_CalcExpenses);
            this.tab_AICalc.Location = new System.Drawing.Point(4, 25);
            this.tab_AICalc.Margin = new System.Windows.Forms.Padding(4);
            this.tab_AICalc.Name = "tab_AICalc";
            this.tab_AICalc.Padding = new System.Windows.Forms.Padding(4);
            this.tab_AICalc.Size = new System.Drawing.Size(852, 551);
            this.tab_AICalc.TabIndex = 1;
            this.tab_AICalc.Text = "محاسبه هوشمند";
            this.tab_AICalc.UseVisualStyleBackColor = true;
            this.tab_AICalc.Enter += new System.EventHandler(this.tab_AICalc_Enter);
            // 
            // cmb_CalcIncomeList
            // 
            this.cmb_CalcIncomeList.FormattingEnabled = true;
            this.cmb_CalcIncomeList.Location = new System.Drawing.Point(243, 442);
            this.cmb_CalcIncomeList.Name = "cmb_CalcIncomeList";
            this.cmb_CalcIncomeList.Size = new System.Drawing.Size(194, 24);
            this.cmb_CalcIncomeList.TabIndex = 5;
            // 
            // lbl_CalcIncomeList
            // 
            this.lbl_CalcIncomeList.AutoSize = true;
            this.lbl_CalcIncomeList.Location = new System.Drawing.Point(443, 445);
            this.lbl_CalcIncomeList.Name = "lbl_CalcIncomeList";
            this.lbl_CalcIncomeList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcIncomeList.Size = new System.Drawing.Size(35, 16);
            this.lbl_CalcIncomeList.TabIndex = 29;
            this.lbl_CalcIncomeList.Text = "لیست:";
            // 
            // cmb_CalcExpenseList
            // 
            this.cmb_CalcExpenseList.FormattingEnabled = true;
            this.cmb_CalcExpenseList.Location = new System.Drawing.Point(3, 442);
            this.cmb_CalcExpenseList.Name = "cmb_CalcExpenseList";
            this.cmb_CalcExpenseList.Size = new System.Drawing.Size(194, 24);
            this.cmb_CalcExpenseList.TabIndex = 9;
            // 
            // lbl_CalcExpenseList
            // 
            this.lbl_CalcExpenseList.AutoSize = true;
            this.lbl_CalcExpenseList.Location = new System.Drawing.Point(203, 445);
            this.lbl_CalcExpenseList.Name = "lbl_CalcExpenseList";
            this.lbl_CalcExpenseList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcExpenseList.Size = new System.Drawing.Size(35, 16);
            this.lbl_CalcExpenseList.TabIndex = 28;
            this.lbl_CalcExpenseList.Text = "لیست:";
            // 
            // lbl_CalcExpenseValue
            // 
            this.lbl_CalcExpenseValue.AutoSize = true;
            this.lbl_CalcExpenseValue.Location = new System.Drawing.Point(203, 417);
            this.lbl_CalcExpenseValue.Name = "lbl_CalcExpenseValue";
            this.lbl_CalcExpenseValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcExpenseValue.Size = new System.Drawing.Size(35, 16);
            this.lbl_CalcExpenseValue.TabIndex = 27;
            this.lbl_CalcExpenseValue.Text = "مقدار:";
            // 
            // lbl_CalcIncomeValue
            // 
            this.lbl_CalcIncomeValue.AutoSize = true;
            this.lbl_CalcIncomeValue.Location = new System.Drawing.Point(443, 417);
            this.lbl_CalcIncomeValue.Name = "lbl_CalcIncomeValue";
            this.lbl_CalcIncomeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcIncomeValue.Size = new System.Drawing.Size(35, 16);
            this.lbl_CalcIncomeValue.TabIndex = 26;
            this.lbl_CalcIncomeValue.Text = "مقدار:";
            // 
            // lbl_CalcExpenses
            // 
            this.lbl_CalcExpenses.AutoSize = true;
            this.lbl_CalcExpenses.Location = new System.Drawing.Point(187, 4);
            this.lbl_CalcExpenses.Name = "lbl_CalcExpenses";
            this.lbl_CalcExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcExpenses.Size = new System.Drawing.Size(58, 16);
            this.lbl_CalcExpenses.TabIndex = 24;
            this.lbl_CalcExpenses.Text = "خروجی‌ها";
            // 
            // lbl_CalcTransactionsList
            // 
            this.lbl_CalcTransactionsList.AutoSize = true;
            this.lbl_CalcTransactionsList.Location = new System.Drawing.Point(804, 4);
            this.lbl_CalcTransactionsList.Name = "lbl_CalcTransactionsList";
            this.lbl_CalcTransactionsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcTransactionsList.Size = new System.Drawing.Size(45, 16);
            this.lbl_CalcTransactionsList.TabIndex = 23;
            this.lbl_CalcTransactionsList.Text = "لیست‌ها";
            // 
            // lbl_CalcIncomes
            // 
            this.lbl_CalcIncomes.AutoSize = true;
            this.lbl_CalcIncomes.Location = new System.Drawing.Point(425, 4);
            this.lbl_CalcIncomes.Name = "lbl_CalcIncomes";
            this.lbl_CalcIncomes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcIncomes.Size = new System.Drawing.Size(53, 16);
            this.lbl_CalcIncomes.TabIndex = 22;
            this.lbl_CalcIncomes.Text = "ورودی‌ها";
            // 
            // lbl_CalcListName
            // 
            this.lbl_CalcListName.AutoSize = true;
            this.lbl_CalcListName.Location = new System.Drawing.Point(764, 392);
            this.lbl_CalcListName.Name = "lbl_CalcListName";
            this.lbl_CalcListName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcListName.Size = new System.Drawing.Size(24, 16);
            this.lbl_CalcListName.TabIndex = 20;
            this.lbl_CalcListName.Text = "نام:";
            // 
            // lbl_CalcExpenseTitle
            // 
            this.lbl_CalcExpenseTitle.AutoSize = true;
            this.lbl_CalcExpenseTitle.Location = new System.Drawing.Point(203, 389);
            this.lbl_CalcExpenseTitle.Name = "lbl_CalcExpenseTitle";
            this.lbl_CalcExpenseTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcExpenseTitle.Size = new System.Drawing.Size(37, 16);
            this.lbl_CalcExpenseTitle.TabIndex = 25;
            this.lbl_CalcExpenseTitle.Text = "عنوان:";
            // 
            // lbl_CalcIncomeTitle
            // 
            this.lbl_CalcIncomeTitle.AutoSize = true;
            this.lbl_CalcIncomeTitle.Location = new System.Drawing.Point(443, 389);
            this.lbl_CalcIncomeTitle.Name = "lbl_CalcIncomeTitle";
            this.lbl_CalcIncomeTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CalcIncomeTitle.Size = new System.Drawing.Size(37, 16);
            this.lbl_CalcIncomeTitle.TabIndex = 19;
            this.lbl_CalcIncomeTitle.Text = "عنوان:";
            // 
            // btn_CalcSaveList
            // 
            this.btn_CalcSaveList.Location = new System.Drawing.Point(564, 417);
            this.btn_CalcSaveList.Name = "btn_CalcSaveList";
            this.btn_CalcSaveList.Size = new System.Drawing.Size(194, 23);
            this.btn_CalcSaveList.TabIndex = 2;
            this.btn_CalcSaveList.Text = "ذخیره";
            this.btn_CalcSaveList.UseVisualStyleBackColor = true;
            this.btn_CalcSaveList.Click += new System.EventHandler(this.btn_CalcSaveList_Click);
            // 
            // btn_CalcSaveExpense
            // 
            this.btn_CalcSaveExpense.Location = new System.Drawing.Point(3, 472);
            this.btn_CalcSaveExpense.Name = "btn_CalcSaveExpense";
            this.btn_CalcSaveExpense.Size = new System.Drawing.Size(194, 23);
            this.btn_CalcSaveExpense.TabIndex = 10;
            this.btn_CalcSaveExpense.Text = "ثبت";
            this.btn_CalcSaveExpense.UseVisualStyleBackColor = true;
            this.btn_CalcSaveExpense.Click += new System.EventHandler(this.btn_CalcSaveExpense_Click);
            // 
            // btn_CalcSaveIncome
            // 
            this.btn_CalcSaveIncome.Location = new System.Drawing.Point(243, 472);
            this.btn_CalcSaveIncome.Name = "btn_CalcSaveIncome";
            this.btn_CalcSaveIncome.Size = new System.Drawing.Size(194, 23);
            this.btn_CalcSaveIncome.TabIndex = 6;
            this.btn_CalcSaveIncome.Text = "ثبت";
            this.btn_CalcSaveIncome.UseVisualStyleBackColor = true;
            this.btn_CalcSaveIncome.Click += new System.EventHandler(this.btn_CalcSaveIncome_Click);
            // 
            // txt_CalcExpenseValue
            // 
            this.txt_CalcExpenseValue.Location = new System.Drawing.Point(3, 414);
            this.txt_CalcExpenseValue.Name = "txt_CalcExpenseValue";
            this.txt_CalcExpenseValue.Size = new System.Drawing.Size(194, 22);
            this.txt_CalcExpenseValue.TabIndex = 8;
            this.txt_CalcExpenseValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CalcExpenseValue_KeyPress);
            // 
            // txt_CalcIncomeValue
            // 
            this.txt_CalcIncomeValue.Location = new System.Drawing.Point(243, 414);
            this.txt_CalcIncomeValue.Name = "txt_CalcIncomeValue";
            this.txt_CalcIncomeValue.Size = new System.Drawing.Size(194, 22);
            this.txt_CalcIncomeValue.TabIndex = 4;
            this.txt_CalcIncomeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CalcIncomeValue_KeyPress);
            // 
            // txt_CalcListName
            // 
            this.txt_CalcListName.Location = new System.Drawing.Point(564, 389);
            this.txt_CalcListName.Name = "txt_CalcListName";
            this.txt_CalcListName.Size = new System.Drawing.Size(194, 22);
            this.txt_CalcListName.TabIndex = 1;
            // 
            // txt_CalcExpenseTitle
            // 
            this.txt_CalcExpenseTitle.Location = new System.Drawing.Point(3, 386);
            this.txt_CalcExpenseTitle.Name = "txt_CalcExpenseTitle";
            this.txt_CalcExpenseTitle.Size = new System.Drawing.Size(194, 22);
            this.txt_CalcExpenseTitle.TabIndex = 7;
            // 
            // txt_CalcIncomeTitle
            // 
            this.txt_CalcIncomeTitle.Location = new System.Drawing.Point(243, 386);
            this.txt_CalcIncomeTitle.Name = "txt_CalcIncomeTitle";
            this.txt_CalcIncomeTitle.Size = new System.Drawing.Size(194, 22);
            this.txt_CalcIncomeTitle.TabIndex = 3;
            // 
            // dgv_CalcTransactions
            // 
            this.dgv_CalcTransactions.AllowUserToAddRows = false;
            this.dgv_CalcTransactions.AllowUserToDeleteRows = false;
            this.dgv_CalcTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CalcTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CLListID,
            this.col_CLListName,
            this.col_CLListCreateDate,
            this.col_CLListLevel,
            this.col_CLListIncomeNumbers,
            this.col_CLListExpenseNumbers});
            this.dgv_CalcTransactions.ContextMenuStrip = this.cms_CalcTransactionsList;
            this.dgv_CalcTransactions.Location = new System.Drawing.Point(510, 23);
            this.dgv_CalcTransactions.Name = "dgv_CalcTransactions";
            this.dgv_CalcTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_CalcTransactions.Size = new System.Drawing.Size(339, 357);
            this.dgv_CalcTransactions.TabIndex = 9;
            // 
            // cms_CalcTransactionsList
            // 
            this.cms_CalcTransactionsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_CalculateList,
            this.btn_ShowListInfo});
            this.cms_CalcTransactionsList.Name = "cms_CalcTransactionsList";
            this.cms_CalcTransactionsList.Size = new System.Drawing.Size(148, 48);
            // 
            // btn_CalculateList
            // 
            this.btn_CalculateList.Name = "btn_CalculateList";
            this.btn_CalculateList.Size = new System.Drawing.Size(147, 22);
            this.btn_CalculateList.Text = "محاسبه";
            // 
            // btn_ShowListInfo
            // 
            this.btn_ShowListInfo.Name = "btn_ShowListInfo";
            this.btn_ShowListInfo.Size = new System.Drawing.Size(147, 22);
            this.btn_ShowListInfo.Text = "اطلاعات لیست";
            // 
            // dgv_CalcIncomes
            // 
            this.dgv_CalcIncomes.AllowUserToAddRows = false;
            this.dgv_CalcIncomes.AllowUserToDeleteRows = false;
            this.dgv_CalcIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CalcIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CLIncomeID,
            this.col_CLIncomeTitle,
            this.col_CLIncomeValue,
            this.col_CLIncomeCreateDate,
            this.col_CLIncomeList});
            this.dgv_CalcIncomes.Location = new System.Drawing.Point(243, 23);
            this.dgv_CalcIncomes.Name = "dgv_CalcIncomes";
            this.dgv_CalcIncomes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_CalcIncomes.Size = new System.Drawing.Size(234, 357);
            this.dgv_CalcIncomes.TabIndex = 8;
            // 
            // dgv_CalcExpenses
            // 
            this.dgv_CalcExpenses.AllowUserToAddRows = false;
            this.dgv_CalcExpenses.AllowUserToDeleteRows = false;
            this.dgv_CalcExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CalcExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CLExpenseID,
            this.col_CLExpenseTitle,
            this.col_CLExpenseValue,
            this.col_CLExpenseCreateDate,
            this.col_CLExpenseList});
            this.dgv_CalcExpenses.Location = new System.Drawing.Point(3, 23);
            this.dgv_CalcExpenses.Name = "dgv_CalcExpenses";
            this.dgv_CalcExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_CalcExpenses.Size = new System.Drawing.Size(234, 357);
            this.dgv_CalcExpenses.TabIndex = 7;
            // 
            // tab_MachineLearning
            // 
            this.tab_MachineLearning.Controls.Add(this.cmb_MLIncomeList);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLIncomeList);
            this.tab_MachineLearning.Controls.Add(this.cmb_MLExpenseList);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLExpenseList);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLExpenseValue);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLIncomeValue);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLExpneses);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLTransactionsList);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLIncomes);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLListLevel);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLListName);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLExpenseTitle);
            this.tab_MachineLearning.Controls.Add(this.lbl_MLIncomeTitle);
            this.tab_MachineLearning.Controls.Add(this.btn_MLSaveList);
            this.tab_MachineLearning.Controls.Add(this.btn_MLSaveExpense);
            this.tab_MachineLearning.Controls.Add(this.btn_MLSaveIncome);
            this.tab_MachineLearning.Controls.Add(this.txt_MLExpenseValue);
            this.tab_MachineLearning.Controls.Add(this.txt_MLIncomeValue);
            this.tab_MachineLearning.Controls.Add(this.txt_MLListLevel);
            this.tab_MachineLearning.Controls.Add(this.txt_MLListName);
            this.tab_MachineLearning.Controls.Add(this.txt_MLExpenseTitle);
            this.tab_MachineLearning.Controls.Add(this.txt_MLIncomeTitle);
            this.tab_MachineLearning.Controls.Add(this.dgv_MLTransactionsList);
            this.tab_MachineLearning.Controls.Add(this.dgv_MLIncomes);
            this.tab_MachineLearning.Controls.Add(this.dgv_MLExpenses);
            this.tab_MachineLearning.Location = new System.Drawing.Point(4, 25);
            this.tab_MachineLearning.Name = "tab_MachineLearning";
            this.tab_MachineLearning.Size = new System.Drawing.Size(852, 551);
            this.tab_MachineLearning.TabIndex = 2;
            this.tab_MachineLearning.Text = "یادگیری";
            this.tab_MachineLearning.UseVisualStyleBackColor = true;
            this.tab_MachineLearning.Enter += new System.EventHandler(this.tab_MachineLearning_Enter);
            // 
            // cmb_MLIncomeList
            // 
            this.cmb_MLIncomeList.FormattingEnabled = true;
            this.cmb_MLIncomeList.Location = new System.Drawing.Point(243, 441);
            this.cmb_MLIncomeList.Name = "cmb_MLIncomeList";
            this.cmb_MLIncomeList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_MLIncomeList.Size = new System.Drawing.Size(194, 24);
            this.cmb_MLIncomeList.TabIndex = 10;
            // 
            // lbl_MLIncomeList
            // 
            this.lbl_MLIncomeList.AutoSize = true;
            this.lbl_MLIncomeList.Location = new System.Drawing.Point(443, 444);
            this.lbl_MLIncomeList.Name = "lbl_MLIncomeList";
            this.lbl_MLIncomeList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLIncomeList.Size = new System.Drawing.Size(35, 16);
            this.lbl_MLIncomeList.TabIndex = 5;
            this.lbl_MLIncomeList.Text = "لیست:";
            // 
            // cmb_MLExpenseList
            // 
            this.cmb_MLExpenseList.FormattingEnabled = true;
            this.cmb_MLExpenseList.Location = new System.Drawing.Point(3, 441);
            this.cmb_MLExpenseList.Name = "cmb_MLExpenseList";
            this.cmb_MLExpenseList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_MLExpenseList.Size = new System.Drawing.Size(194, 24);
            this.cmb_MLExpenseList.TabIndex = 6;
            // 
            // lbl_MLExpenseList
            // 
            this.lbl_MLExpenseList.AutoSize = true;
            this.lbl_MLExpenseList.Location = new System.Drawing.Point(203, 444);
            this.lbl_MLExpenseList.Name = "lbl_MLExpenseList";
            this.lbl_MLExpenseList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLExpenseList.Size = new System.Drawing.Size(35, 16);
            this.lbl_MLExpenseList.TabIndex = 5;
            this.lbl_MLExpenseList.Text = "لیست:";
            // 
            // lbl_MLExpenseValue
            // 
            this.lbl_MLExpenseValue.AutoSize = true;
            this.lbl_MLExpenseValue.Location = new System.Drawing.Point(203, 416);
            this.lbl_MLExpenseValue.Name = "lbl_MLExpenseValue";
            this.lbl_MLExpenseValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLExpenseValue.Size = new System.Drawing.Size(35, 16);
            this.lbl_MLExpenseValue.TabIndex = 5;
            this.lbl_MLExpenseValue.Text = "مقدار:";
            // 
            // lbl_MLIncomeValue
            // 
            this.lbl_MLIncomeValue.AutoSize = true;
            this.lbl_MLIncomeValue.Location = new System.Drawing.Point(443, 416);
            this.lbl_MLIncomeValue.Name = "lbl_MLIncomeValue";
            this.lbl_MLIncomeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLIncomeValue.Size = new System.Drawing.Size(35, 16);
            this.lbl_MLIncomeValue.TabIndex = 5;
            this.lbl_MLIncomeValue.Text = "مقدار:";
            // 
            // lbl_MLExpneses
            // 
            this.lbl_MLExpneses.AutoSize = true;
            this.lbl_MLExpneses.Location = new System.Drawing.Point(187, 3);
            this.lbl_MLExpneses.Name = "lbl_MLExpneses";
            this.lbl_MLExpneses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLExpneses.Size = new System.Drawing.Size(58, 16);
            this.lbl_MLExpneses.TabIndex = 4;
            this.lbl_MLExpneses.Text = "خروجی‌ها";
            // 
            // lbl_MLTransactionsList
            // 
            this.lbl_MLTransactionsList.AutoSize = true;
            this.lbl_MLTransactionsList.Location = new System.Drawing.Point(804, 3);
            this.lbl_MLTransactionsList.Name = "lbl_MLTransactionsList";
            this.lbl_MLTransactionsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLTransactionsList.Size = new System.Drawing.Size(45, 16);
            this.lbl_MLTransactionsList.TabIndex = 4;
            this.lbl_MLTransactionsList.Text = "لیست‌ها";
            // 
            // lbl_MLIncomes
            // 
            this.lbl_MLIncomes.AutoSize = true;
            this.lbl_MLIncomes.Location = new System.Drawing.Point(425, 3);
            this.lbl_MLIncomes.Name = "lbl_MLIncomes";
            this.lbl_MLIncomes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLIncomes.Size = new System.Drawing.Size(53, 16);
            this.lbl_MLIncomes.TabIndex = 4;
            this.lbl_MLIncomes.Text = "ورودی‌ها";
            // 
            // lbl_MLListLevel
            // 
            this.lbl_MLListLevel.AutoSize = true;
            this.lbl_MLListLevel.Location = new System.Drawing.Point(764, 419);
            this.lbl_MLListLevel.Name = "lbl_MLListLevel";
            this.lbl_MLListLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLListLevel.Size = new System.Drawing.Size(35, 16);
            this.lbl_MLListLevel.TabIndex = 4;
            this.lbl_MLListLevel.Text = "سطح:";
            // 
            // lbl_MLListName
            // 
            this.lbl_MLListName.AutoSize = true;
            this.lbl_MLListName.Location = new System.Drawing.Point(764, 391);
            this.lbl_MLListName.Name = "lbl_MLListName";
            this.lbl_MLListName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLListName.Size = new System.Drawing.Size(24, 16);
            this.lbl_MLListName.TabIndex = 4;
            this.lbl_MLListName.Text = "نام:";
            // 
            // lbl_MLExpenseTitle
            // 
            this.lbl_MLExpenseTitle.AutoSize = true;
            this.lbl_MLExpenseTitle.Location = new System.Drawing.Point(203, 388);
            this.lbl_MLExpenseTitle.Name = "lbl_MLExpenseTitle";
            this.lbl_MLExpenseTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLExpenseTitle.Size = new System.Drawing.Size(37, 16);
            this.lbl_MLExpenseTitle.TabIndex = 4;
            this.lbl_MLExpenseTitle.Text = "عنوان:";
            // 
            // lbl_MLIncomeTitle
            // 
            this.lbl_MLIncomeTitle.AutoSize = true;
            this.lbl_MLIncomeTitle.Location = new System.Drawing.Point(443, 388);
            this.lbl_MLIncomeTitle.Name = "lbl_MLIncomeTitle";
            this.lbl_MLIncomeTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MLIncomeTitle.Size = new System.Drawing.Size(37, 16);
            this.lbl_MLIncomeTitle.TabIndex = 4;
            this.lbl_MLIncomeTitle.Text = "عنوان:";
            // 
            // btn_MLSaveList
            // 
            this.btn_MLSaveList.Location = new System.Drawing.Point(564, 444);
            this.btn_MLSaveList.Name = "btn_MLSaveList";
            this.btn_MLSaveList.Size = new System.Drawing.Size(194, 23);
            this.btn_MLSaveList.TabIndex = 3;
            this.btn_MLSaveList.Text = "ذخیره";
            this.btn_MLSaveList.UseVisualStyleBackColor = true;
            this.btn_MLSaveList.Click += new System.EventHandler(this.btn_MLSaveList_Click);
            // 
            // btn_MLSaveExpense
            // 
            this.btn_MLSaveExpense.Location = new System.Drawing.Point(3, 471);
            this.btn_MLSaveExpense.Name = "btn_MLSaveExpense";
            this.btn_MLSaveExpense.Size = new System.Drawing.Size(194, 23);
            this.btn_MLSaveExpense.TabIndex = 7;
            this.btn_MLSaveExpense.Text = "ثبت";
            this.btn_MLSaveExpense.UseVisualStyleBackColor = true;
            this.btn_MLSaveExpense.Click += new System.EventHandler(this.btn_MLSaveExpense_Click);
            // 
            // btn_MLSaveIncome
            // 
            this.btn_MLSaveIncome.Location = new System.Drawing.Point(243, 471);
            this.btn_MLSaveIncome.Name = "btn_MLSaveIncome";
            this.btn_MLSaveIncome.Size = new System.Drawing.Size(194, 23);
            this.btn_MLSaveIncome.TabIndex = 11;
            this.btn_MLSaveIncome.Text = "ثبت";
            this.btn_MLSaveIncome.UseVisualStyleBackColor = true;
            this.btn_MLSaveIncome.Click += new System.EventHandler(this.btn_MLSaveIncome_Click);
            // 
            // txt_MLExpenseValue
            // 
            this.txt_MLExpenseValue.Location = new System.Drawing.Point(3, 413);
            this.txt_MLExpenseValue.Name = "txt_MLExpenseValue";
            this.txt_MLExpenseValue.Size = new System.Drawing.Size(194, 22);
            this.txt_MLExpenseValue.TabIndex = 5;
            this.txt_MLExpenseValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MLExpenseValue_KeyPress);
            // 
            // txt_MLIncomeValue
            // 
            this.txt_MLIncomeValue.Location = new System.Drawing.Point(243, 413);
            this.txt_MLIncomeValue.Name = "txt_MLIncomeValue";
            this.txt_MLIncomeValue.Size = new System.Drawing.Size(194, 22);
            this.txt_MLIncomeValue.TabIndex = 9;
            this.txt_MLIncomeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MLIncomeValue_KeyPress);
            // 
            // txt_MLListLevel
            // 
            this.txt_MLListLevel.Location = new System.Drawing.Point(564, 416);
            this.txt_MLListLevel.Name = "txt_MLListLevel";
            this.txt_MLListLevel.Size = new System.Drawing.Size(194, 22);
            this.txt_MLListLevel.TabIndex = 2;
            this.txt_MLListLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MLListLevel_KeyPress);
            // 
            // txt_MLListName
            // 
            this.txt_MLListName.Location = new System.Drawing.Point(564, 388);
            this.txt_MLListName.Name = "txt_MLListName";
            this.txt_MLListName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_MLListName.Size = new System.Drawing.Size(194, 22);
            this.txt_MLListName.TabIndex = 1;
            // 
            // txt_MLExpenseTitle
            // 
            this.txt_MLExpenseTitle.Location = new System.Drawing.Point(3, 385);
            this.txt_MLExpenseTitle.Name = "txt_MLExpenseTitle";
            this.txt_MLExpenseTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_MLExpenseTitle.Size = new System.Drawing.Size(194, 22);
            this.txt_MLExpenseTitle.TabIndex = 4;
            // 
            // txt_MLIncomeTitle
            // 
            this.txt_MLIncomeTitle.Location = new System.Drawing.Point(243, 385);
            this.txt_MLIncomeTitle.Name = "txt_MLIncomeTitle";
            this.txt_MLIncomeTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_MLIncomeTitle.Size = new System.Drawing.Size(194, 22);
            this.txt_MLIncomeTitle.TabIndex = 8;
            // 
            // dgv_MLTransactionsList
            // 
            this.dgv_MLTransactionsList.AllowUserToAddRows = false;
            this.dgv_MLTransactionsList.AllowUserToDeleteRows = false;
            this.dgv_MLTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MLTransactionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MLListID,
            this.col_MLListName,
            this.col_MLListCreateDate,
            this.col_MLListLevel,
            this.col_MLListIncomesNumber,
            this.col_MLListExpenseNumbers});
            this.dgv_MLTransactionsList.Location = new System.Drawing.Point(510, 22);
            this.dgv_MLTransactionsList.Name = "dgv_MLTransactionsList";
            this.dgv_MLTransactionsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_MLTransactionsList.Size = new System.Drawing.Size(339, 357);
            this.dgv_MLTransactionsList.TabIndex = 1;
            // 
            // col_MLListID
            // 
            this.col_MLListID.HeaderText = "MLListID";
            this.col_MLListID.Name = "col_MLListID";
            this.col_MLListID.Visible = false;
            // 
            // col_MLListName
            // 
            this.col_MLListName.HeaderText = "نام";
            this.col_MLListName.Name = "col_MLListName";
            // 
            // col_MLListCreateDate
            // 
            this.col_MLListCreateDate.HeaderText = "تاریخ ایجاد";
            this.col_MLListCreateDate.Name = "col_MLListCreateDate";
            // 
            // col_MLListLevel
            // 
            this.col_MLListLevel.HeaderText = "سطح";
            this.col_MLListLevel.Name = "col_MLListLevel";
            // 
            // col_MLListIncomesNumber
            // 
            this.col_MLListIncomesNumber.HeaderText = "تعداد ورودی‌ها";
            this.col_MLListIncomesNumber.Name = "col_MLListIncomesNumber";
            // 
            // col_MLListExpenseNumbers
            // 
            this.col_MLListExpenseNumbers.HeaderText = "تعداد خروجی‌ها";
            this.col_MLListExpenseNumbers.Name = "col_MLListExpenseNumbers";
            // 
            // dgv_MLIncomes
            // 
            this.dgv_MLIncomes.AllowUserToAddRows = false;
            this.dgv_MLIncomes.AllowUserToDeleteRows = false;
            this.dgv_MLIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MLIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MLIncomeID,
            this.col_MLIncomeName,
            this.col_MLIncomeValue,
            this.col_MLIncomeCreateDate,
            this.col_MLIncomeList});
            this.dgv_MLIncomes.Location = new System.Drawing.Point(243, 22);
            this.dgv_MLIncomes.Name = "dgv_MLIncomes";
            this.dgv_MLIncomes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_MLIncomes.Size = new System.Drawing.Size(234, 357);
            this.dgv_MLIncomes.TabIndex = 0;
            // 
            // col_MLIncomeID
            // 
            this.col_MLIncomeID.HeaderText = "MLIncomeID";
            this.col_MLIncomeID.Name = "col_MLIncomeID";
            this.col_MLIncomeID.Visible = false;
            // 
            // col_MLIncomeName
            // 
            this.col_MLIncomeName.HeaderText = "عنوان";
            this.col_MLIncomeName.Name = "col_MLIncomeName";
            // 
            // col_MLIncomeValue
            // 
            this.col_MLIncomeValue.HeaderText = "مقدار";
            this.col_MLIncomeValue.Name = "col_MLIncomeValue";
            // 
            // col_MLIncomeCreateDate
            // 
            this.col_MLIncomeCreateDate.HeaderText = "تاریخ ایجاد";
            this.col_MLIncomeCreateDate.Name = "col_MLIncomeCreateDate";
            // 
            // col_MLIncomeList
            // 
            this.col_MLIncomeList.HeaderText = "لیست";
            this.col_MLIncomeList.Name = "col_MLIncomeList";
            // 
            // dgv_MLExpenses
            // 
            this.dgv_MLExpenses.AllowUserToAddRows = false;
            this.dgv_MLExpenses.AllowUserToDeleteRows = false;
            this.dgv_MLExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MLExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MLExpenseID,
            this.col_MLExpenseName,
            this.col_MLExpenseValue,
            this.col_MLExpenseCreateDate,
            this.col_MLExpenseList});
            this.dgv_MLExpenses.Location = new System.Drawing.Point(3, 22);
            this.dgv_MLExpenses.Name = "dgv_MLExpenses";
            this.dgv_MLExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_MLExpenses.Size = new System.Drawing.Size(234, 357);
            this.dgv_MLExpenses.TabIndex = 0;
            // 
            // col_MLExpenseID
            // 
            this.col_MLExpenseID.HeaderText = "MLExpenseID";
            this.col_MLExpenseID.Name = "col_MLExpenseID";
            this.col_MLExpenseID.Visible = false;
            // 
            // col_MLExpenseName
            // 
            this.col_MLExpenseName.HeaderText = "عنوان";
            this.col_MLExpenseName.Name = "col_MLExpenseName";
            // 
            // col_MLExpenseValue
            // 
            this.col_MLExpenseValue.HeaderText = "مقدار";
            this.col_MLExpenseValue.Name = "col_MLExpenseValue";
            // 
            // col_MLExpenseCreateDate
            // 
            this.col_MLExpenseCreateDate.HeaderText = "تاریخ ایجاد";
            this.col_MLExpenseCreateDate.Name = "col_MLExpenseCreateDate";
            // 
            // col_MLExpenseList
            // 
            this.col_MLExpenseList.HeaderText = "لیست";
            this.col_MLExpenseList.Name = "col_MLExpenseList";
            // 
            // col_CLListID
            // 
            this.col_CLListID.HeaderText = "ID";
            this.col_CLListID.Name = "col_CLListID";
            this.col_CLListID.Visible = false;
            // 
            // col_CLListName
            // 
            this.col_CLListName.HeaderText = "نام";
            this.col_CLListName.Name = "col_CLListName";
            // 
            // col_CLListCreateDate
            // 
            this.col_CLListCreateDate.HeaderText = "تاریخ ایجاد";
            this.col_CLListCreateDate.Name = "col_CLListCreateDate";
            // 
            // col_CLListLevel
            // 
            this.col_CLListLevel.HeaderText = "سطح";
            this.col_CLListLevel.Name = "col_CLListLevel";
            // 
            // col_CLListIncomeNumbers
            // 
            this.col_CLListIncomeNumbers.HeaderText = "تعداد ورودی‌ها";
            this.col_CLListIncomeNumbers.Name = "col_CLListIncomeNumbers";
            // 
            // col_CLListExpenseNumbers
            // 
            this.col_CLListExpenseNumbers.HeaderText = "تعداد خروجی‌ها";
            this.col_CLListExpenseNumbers.Name = "col_CLListExpenseNumbers";
            // 
            // col_CLIncomeID
            // 
            this.col_CLIncomeID.HeaderText = "IncomeID";
            this.col_CLIncomeID.Name = "col_CLIncomeID";
            this.col_CLIncomeID.Visible = false;
            // 
            // col_CLIncomeTitle
            // 
            this.col_CLIncomeTitle.HeaderText = "عنوان";
            this.col_CLIncomeTitle.Name = "col_CLIncomeTitle";
            // 
            // col_CLIncomeValue
            // 
            this.col_CLIncomeValue.HeaderText = "مقدار";
            this.col_CLIncomeValue.Name = "col_CLIncomeValue";
            // 
            // col_CLIncomeCreateDate
            // 
            this.col_CLIncomeCreateDate.HeaderText = "تاریخ ایجاد";
            this.col_CLIncomeCreateDate.Name = "col_CLIncomeCreateDate";
            // 
            // col_CLIncomeList
            // 
            this.col_CLIncomeList.HeaderText = "لیست";
            this.col_CLIncomeList.Name = "col_CLIncomeList";
            this.col_CLIncomeList.Visible = false;
            // 
            // col_CLExpenseID
            // 
            this.col_CLExpenseID.HeaderText = "ExpenseID";
            this.col_CLExpenseID.Name = "col_CLExpenseID";
            this.col_CLExpenseID.Visible = false;
            // 
            // col_CLExpenseTitle
            // 
            this.col_CLExpenseTitle.HeaderText = "عنوان";
            this.col_CLExpenseTitle.Name = "col_CLExpenseTitle";
            // 
            // col_CLExpenseValue
            // 
            this.col_CLExpenseValue.HeaderText = "مقدار";
            this.col_CLExpenseValue.Name = "col_CLExpenseValue";
            // 
            // col_CLExpenseCreateDate
            // 
            this.col_CLExpenseCreateDate.HeaderText = "تاریخ ایجاد";
            this.col_CLExpenseCreateDate.Name = "col_CLExpenseCreateDate";
            // 
            // col_CLExpenseList
            // 
            this.col_CLExpenseList.HeaderText = "لیست";
            this.col_CLExpenseList.Name = "col_CLExpenseList";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 634);
            this.Controls.Add(this.tbc_MainTab);
            this.Controls.Add(this.sts_BottomMenu);
            this.Controls.Add(this.mns_TopMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns_TopMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامجه | محاسبه‌گر هوشمند";
            this.mns_TopMenu.ResumeLayout(false);
            this.mns_TopMenu.PerformLayout();
            this.tbc_MainTab.ResumeLayout(false);
            this.tab_Dashboard.ResumeLayout(false);
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.tab_AICalc.ResumeLayout(false);
            this.tab_AICalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CalcTransactions)).EndInit();
            this.cms_CalcTransactionsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CalcIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CalcExpenses)).EndInit();
            this.tab_MachineLearning.ResumeLayout(false);
            this.tab_MachineLearning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MLTransactionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MLIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MLExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_TopMenu;
        private System.Windows.Forms.StatusStrip sts_BottomMenu;
        private System.Windows.Forms.ToolStripMenuItem btn_File;
        private System.Windows.Forms.ToolStripMenuItem btn_BackUp;
        private System.Windows.Forms.ToolStripMenuItem btn_Program;
        private System.Windows.Forms.ToolStripMenuItem btn_About;
        private System.Windows.Forms.ToolStripSeparator lbl_Line;
        private System.Windows.Forms.ToolStripMenuItem btn_Exit;
        private System.Windows.Forms.TabControl tbc_MainTab;
        private System.Windows.Forms.TabPage tab_Dashboard;
        private System.Windows.Forms.TabPage tab_AICalc;
        private System.Windows.Forms.TabPage tab_MachineLearning;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Label lbl_TotlaIncomes;
        private System.Windows.Forms.Label ctx_TotalIncomes;
        private System.Windows.Forms.Label ctx_LastLearning;
        private System.Windows.Forms.Label ctx_TotalExpenses;
        private System.Windows.Forms.Label lbl_LastLearning;
        private System.Windows.Forms.Label lbl_TotalExpenses;
        private System.Windows.Forms.Label ctx_LastCalculate;
        private System.Windows.Forms.Label lbl_LastCalculate;
        private System.Windows.Forms.Label ctx_LastCalculateLevel;
        private System.Windows.Forms.Label ctx_LastLearningLevel;
        private System.Windows.Forms.Label lbl_LastCalculateLevel;
        private System.Windows.Forms.Label lbl_LastLearningLevel;
        private System.Windows.Forms.DataGridView dgv_MLExpenses;
        private System.Windows.Forms.DataGridView dgv_MLIncomes;
        private System.Windows.Forms.DataGridView dgv_MLTransactionsList;
        private System.Windows.Forms.Button btn_MLSaveIncome;
        private System.Windows.Forms.TextBox txt_MLIncomeValue;
        private System.Windows.Forms.TextBox txt_MLIncomeTitle;
        private System.Windows.Forms.Label lbl_MLIncomeTitle;
        private System.Windows.Forms.Label lbl_MLIncomeValue;
        private System.Windows.Forms.Label lbl_MLExpenseValue;
        private System.Windows.Forms.Label lbl_MLExpenseTitle;
        private System.Windows.Forms.Button btn_MLSaveExpense;
        private System.Windows.Forms.TextBox txt_MLExpenseValue;
        private System.Windows.Forms.TextBox txt_MLExpenseTitle;
        private System.Windows.Forms.Label lbl_MLExpneses;
        private System.Windows.Forms.Label lbl_MLIncomes;
        private System.Windows.Forms.ComboBox cmb_MLExpenseList;
        private System.Windows.Forms.ComboBox cmb_MLIncomeList;
        private System.Windows.Forms.Label lbl_MLIncomeList;
        private System.Windows.Forms.Label lbl_MLExpenseList;
        private System.Windows.Forms.Label lbl_MLTransactionsList;
        private System.Windows.Forms.Label lbl_MLListName;
        private System.Windows.Forms.TextBox txt_MLListName;
        private System.Windows.Forms.Button btn_MLSaveList;
        private System.Windows.Forms.Label lbl_MLListLevel;
        private System.Windows.Forms.TextBox txt_MLListLevel;
        private System.Windows.Forms.ComboBox cmb_CalcIncomeList;
        private System.Windows.Forms.Label lbl_CalcIncomeList;
        private System.Windows.Forms.ComboBox cmb_CalcExpenseList;
        private System.Windows.Forms.Label lbl_CalcExpenseList;
        private System.Windows.Forms.Label lbl_CalcExpenseValue;
        private System.Windows.Forms.Label lbl_CalcIncomeValue;
        private System.Windows.Forms.Label lbl_CalcExpenses;
        private System.Windows.Forms.Label lbl_CalcTransactionsList;
        private System.Windows.Forms.Label lbl_CalcIncomes;
        private System.Windows.Forms.Label lbl_CalcListName;
        private System.Windows.Forms.Label lbl_CalcExpenseTitle;
        private System.Windows.Forms.Label lbl_CalcIncomeTitle;
        private System.Windows.Forms.Button btn_CalcSaveList;
        private System.Windows.Forms.Button btn_CalcSaveExpense;
        private System.Windows.Forms.Button btn_CalcSaveIncome;
        private System.Windows.Forms.TextBox txt_CalcExpenseValue;
        private System.Windows.Forms.TextBox txt_CalcIncomeValue;
        private System.Windows.Forms.TextBox txt_CalcListName;
        private System.Windows.Forms.TextBox txt_CalcExpenseTitle;
        private System.Windows.Forms.TextBox txt_CalcIncomeTitle;
        private System.Windows.Forms.DataGridView dgv_CalcTransactions;
        private System.Windows.Forms.DataGridView dgv_CalcIncomes;
        private System.Windows.Forms.DataGridView dgv_CalcExpenses;
        private System.Windows.Forms.ContextMenuStrip cms_CalcTransactionsList;
        private System.Windows.Forms.ToolStripMenuItem btn_CalculateList;
        private System.Windows.Forms.ToolStripMenuItem btn_ShowListInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLListID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLListCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLListLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLListIncomesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLListExpenseNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLIncomeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLIncomeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLIncomeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLIncomeCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLIncomeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLExpenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLExpenseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLExpenseCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MLExpenseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLListID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLListCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLListLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLListIncomeNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLListExpenseNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLIncomeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLIncomeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLIncomeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLIncomeCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLIncomeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLExpenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLExpenseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLExpenseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLExpenseCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CLExpenseList;
    }
}

