namespace MyCalculator {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.BtnFold = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.TxtDisplay3 = new System.Windows.Forms.TextBox();
            this.BtnMRAnsMC = new System.Windows.Forms.Button();
            this.BtnMSave = new System.Windows.Forms.Button();
            this.BtnMMinus = new System.Windows.Forms.Button();
            this.BtnMPlus = new System.Windows.Forms.Button();
            this.BtnMRead = new System.Windows.Forms.Button();
            this.BtnMClear = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnClearEntry = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRoot = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnPlusMinus = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnOneDiv = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.PnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.BtnFold);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 40);
            this.PnlTitle.TabIndex = 0;
            // 
            // BtnFold
            // 
            this.BtnFold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnFold.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnFold.FlatAppearance.BorderSize = 0;
            this.BtnFold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(142)))));
            this.BtnFold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFold.Image = global::MyCalculator.Properties.Resources.Hide;
            this.BtnFold.Location = new System.Drawing.Point(250, 0);
            this.BtnFold.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFold.Name = "BtnFold";
            this.BtnFold.Size = new System.Drawing.Size(50, 40);
            this.BtnFold.TabIndex = 5;
            this.BtnFold.UseVisualStyleBackColor = false;
            this.BtnFold.Click += new System.EventHandler(this.BtnFold_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(142)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::MyCalculator.Properties.Resources.Cross;
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 3;
            // 
            // BtnHistory
            // 
            this.BtnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnHistory.FlatAppearance.BorderSize = 2;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = global::MyCalculator.Properties.Resources.Clock;
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 3;
            this.BtnHistory.UseVisualStyleBackColor = false;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(189)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Square721 Cn BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(16)))));
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.ReadOnly = true;
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 30);
            this.TxtDisplay2.TabIndex = 4;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(189)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Square721 Cn BT", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(16)))));
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 110);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.ReadOnly = true;
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay3
            // 
            this.TxtDisplay3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(189)))));
            this.TxtDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay3.Font = new System.Drawing.Font("Gadugi", 13.8F);
            this.TxtDisplay3.Location = new System.Drawing.Point(0, 160);
            this.TxtDisplay3.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay3.Multiline = true;
            this.TxtDisplay3.Name = "TxtDisplay3";
            this.TxtDisplay3.ReadOnly = true;
            this.TxtDisplay3.Size = new System.Drawing.Size(350, 10);
            this.TxtDisplay3.TabIndex = 6;
            this.TxtDisplay3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnMRAnsMC
            // 
            this.BtnMRAnsMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMRAnsMC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMRAnsMC.FlatAppearance.BorderSize = 2;
            this.BtnMRAnsMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMRAnsMC.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMRAnsMC.Location = new System.Drawing.Point(291, 182);
            this.BtnMRAnsMC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMRAnsMC.Name = "BtnMRAnsMC";
            this.BtnMRAnsMC.Size = new System.Drawing.Size(50, 30);
            this.BtnMRAnsMC.TabIndex = 7;
            this.BtnMRAnsMC.Text = "MRC";
            this.BtnMRAnsMC.UseVisualStyleBackColor = false;
            this.BtnMRAnsMC.Click += new System.EventHandler(this.MemOperations_Click);
            // 
            // BtnMSave
            // 
            this.BtnMSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMSave.FlatAppearance.BorderSize = 2;
            this.BtnMSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMSave.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMSave.Location = new System.Drawing.Point(235, 182);
            this.BtnMSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMSave.Name = "BtnMSave";
            this.BtnMSave.Size = new System.Drawing.Size(50, 30);
            this.BtnMSave.TabIndex = 9;
            this.BtnMSave.Text = "MS";
            this.BtnMSave.UseVisualStyleBackColor = false;
            this.BtnMSave.Click += new System.EventHandler(this.MemOperations_Click);
            // 
            // BtnMMinus
            // 
            this.BtnMMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMMinus.FlatAppearance.BorderSize = 2;
            this.BtnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMMinus.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMMinus.Location = new System.Drawing.Point(179, 182);
            this.BtnMMinus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMMinus.Name = "BtnMMinus";
            this.BtnMMinus.Size = new System.Drawing.Size(50, 30);
            this.BtnMMinus.TabIndex = 10;
            this.BtnMMinus.Text = "M-";
            this.BtnMMinus.UseVisualStyleBackColor = false;
            this.BtnMMinus.Click += new System.EventHandler(this.MemOperations_Click);
            // 
            // BtnMPlus
            // 
            this.BtnMPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMPlus.FlatAppearance.BorderSize = 2;
            this.BtnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMPlus.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMPlus.Location = new System.Drawing.Point(123, 182);
            this.BtnMPlus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMPlus.Name = "BtnMPlus";
            this.BtnMPlus.Size = new System.Drawing.Size(50, 30);
            this.BtnMPlus.TabIndex = 11;
            this.BtnMPlus.Text = "M+";
            this.BtnMPlus.UseVisualStyleBackColor = false;
            this.BtnMPlus.Click += new System.EventHandler(this.MemOperations_Click);
            // 
            // BtnMRead
            // 
            this.BtnMRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMRead.FlatAppearance.BorderSize = 2;
            this.BtnMRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMRead.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMRead.Location = new System.Drawing.Point(67, 182);
            this.BtnMRead.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMRead.Name = "BtnMRead";
            this.BtnMRead.Size = new System.Drawing.Size(50, 30);
            this.BtnMRead.TabIndex = 12;
            this.BtnMRead.Text = "MR";
            this.BtnMRead.UseVisualStyleBackColor = false;
            this.BtnMRead.Click += new System.EventHandler(this.MemOperations_Click);
            // 
            // BtnMClear
            // 
            this.BtnMClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMClear.FlatAppearance.BorderSize = 2;
            this.BtnMClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMClear.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMClear.Location = new System.Drawing.Point(11, 182);
            this.BtnMClear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMClear.Name = "BtnMClear";
            this.BtnMClear.Size = new System.Drawing.Size(50, 30);
            this.BtnMClear.TabIndex = 13;
            this.BtnMClear.Text = "MC";
            this.BtnMClear.UseVisualStyleBackColor = false;
            this.BtnMClear.Click += new System.EventHandler(this.MemOperations_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnPercent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnPercent.FlatAppearance.BorderSize = 2;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnPercent.Location = new System.Drawing.Point(9, 226);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(80, 50);
            this.BtnPercent.TabIndex = 14;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnClearEntry
            // 
            this.BtnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnClearEntry.FlatAppearance.BorderSize = 2;
            this.BtnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearEntry.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnClearEntry.Location = new System.Drawing.Point(94, 226);
            this.BtnClearEntry.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearEntry.Name = "BtnClearEntry";
            this.BtnClearEntry.Size = new System.Drawing.Size(80, 50);
            this.BtnClearEntry.TabIndex = 15;
            this.BtnClearEntry.Text = "CE";
            this.BtnClearEntry.UseVisualStyleBackColor = false;
            this.BtnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnClear.FlatAppearance.BorderSize = 2;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnClear.Location = new System.Drawing.Point(177, 226);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(80, 50);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRoot
            // 
            this.BtnRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnRoot.FlatAppearance.BorderSize = 2;
            this.BtnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoot.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnRoot.Location = new System.Drawing.Point(177, 283);
            this.BtnRoot.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRoot.Name = "BtnRoot";
            this.BtnRoot.Size = new System.Drawing.Size(80, 50);
            this.BtnRoot.TabIndex = 20;
            this.BtnRoot.Text = "√";
            this.BtnRoot.UseVisualStyleBackColor = false;
            this.BtnRoot.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnDiv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnDiv.FlatAppearance.BorderSize = 2;
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiv.Font = new System.Drawing.Font("Square721 Cn BT", 15F, System.Drawing.FontStyle.Bold);
            this.BtnDiv.Location = new System.Drawing.Point(260, 283);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(80, 50);
            this.BtnDiv.TabIndex = 17;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnMathOper_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnNine.FlatAppearance.BorderSize = 2;
            this.BtnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNine.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnNine.Location = new System.Drawing.Point(177, 340);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(80, 50);
            this.BtnNine.TabIndex = 24;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = false;
            this.BtnNine.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnEight.FlatAppearance.BorderSize = 2;
            this.BtnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEight.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnEight.Location = new System.Drawing.Point(94, 340);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(80, 50);
            this.BtnEight.TabIndex = 23;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = false;
            this.BtnEight.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnSeven.FlatAppearance.BorderSize = 2;
            this.BtnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeven.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSeven.Location = new System.Drawing.Point(11, 340);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(80, 50);
            this.BtnSeven.TabIndex = 22;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = false;
            this.BtnSeven.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnSix.FlatAppearance.BorderSize = 2;
            this.BtnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSix.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSix.Location = new System.Drawing.Point(177, 397);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(80, 50);
            this.BtnSix.TabIndex = 28;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = false;
            this.BtnSix.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnFive.FlatAppearance.BorderSize = 2;
            this.BtnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFive.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnFive.Location = new System.Drawing.Point(94, 397);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(80, 50);
            this.BtnFive.TabIndex = 27;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = false;
            this.BtnFive.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnFour.FlatAppearance.BorderSize = 2;
            this.BtnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFour.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnFour.Location = new System.Drawing.Point(11, 397);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(80, 50);
            this.BtnFour.TabIndex = 26;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = false;
            this.BtnFour.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMinus.FlatAppearance.BorderSize = 2;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Font = new System.Drawing.Font("Square721 Cn BT", 15F, System.Drawing.FontStyle.Bold);
            this.BtnMinus.Location = new System.Drawing.Point(260, 397);
            this.BtnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(80, 50);
            this.BtnMinus.TabIndex = 25;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMathOper_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnThree.FlatAppearance.BorderSize = 2;
            this.BtnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThree.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnThree.Location = new System.Drawing.Point(177, 454);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(0);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(80, 50);
            this.BtnThree.TabIndex = 32;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = false;
            this.BtnThree.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnTwo.FlatAppearance.BorderSize = 2;
            this.BtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwo.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnTwo.Location = new System.Drawing.Point(94, 454);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(80, 50);
            this.BtnTwo.TabIndex = 31;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnOne.FlatAppearance.BorderSize = 2;
            this.BtnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOne.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnOne.Location = new System.Drawing.Point(11, 454);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(80, 50);
            this.BtnOne.TabIndex = 30;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnPlus.FlatAppearance.BorderSize = 2;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("Square721 Cn BT", 15F, System.Drawing.FontStyle.Bold);
            this.BtnPlus.Location = new System.Drawing.Point(260, 454);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(80, 50);
            this.BtnPlus.TabIndex = 29;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnMathOper_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnDot.FlatAppearance.BorderSize = 2;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnDot.Location = new System.Drawing.Point(177, 511);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(80, 50);
            this.BtnDot.TabIndex = 36;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnZero.FlatAppearance.BorderSize = 2;
            this.BtnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZero.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnZero.Location = new System.Drawing.Point(94, 511);
            this.BtnZero.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(80, 50);
            this.BtnZero.TabIndex = 35;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = false;
            this.BtnZero.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnPlusMinus
            // 
            this.BtnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnPlusMinus.FlatAppearance.BorderSize = 2;
            this.BtnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlusMinus.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnPlusMinus.Location = new System.Drawing.Point(11, 511);
            this.BtnPlusMinus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPlusMinus.Name = "BtnPlusMinus";
            this.BtnPlusMinus.Size = new System.Drawing.Size(80, 50);
            this.BtnPlusMinus.TabIndex = 34;
            this.BtnPlusMinus.Text = "±";
            this.BtnPlusMinus.UseVisualStyleBackColor = false;
            this.BtnPlusMinus.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(142)))));
            this.BtnEquals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnEquals.FlatAppearance.BorderSize = 2;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEquals.Location = new System.Drawing.Point(260, 511);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(80, 50);
            this.BtnEquals.TabIndex = 33;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 565);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 5);
            this.PnlHistory.TabIndex = 37;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(252)))), ((int)(((byte)(210)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ReadOnly = true;
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 6;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnClearHistory.FlatAppearance.BorderSize = 2;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = global::MyCalculator.Properties.Resources.Vector__10_;
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -40);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 45);
            this.BtnClearHistory.TabIndex = 4;
            this.BtnClearHistory.UseVisualStyleBackColor = false;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMult.FlatAppearance.BorderSize = 2;
            this.BtnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMult.Font = new System.Drawing.Font("Square721 Cn BT", 1F, System.Drawing.FontStyle.Bold);
            this.BtnMult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnMult.Image = global::MyCalculator.Properties.Resources.Cross;
            this.BtnMult.Location = new System.Drawing.Point(260, 340);
            this.BtnMult.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(80, 50);
            this.BtnMult.TabIndex = 21;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = false;
            this.BtnMult.Click += new System.EventHandler(this.BtnMathOper_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnSqrt.FlatAppearance.BorderSize = 2;
            this.BtnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqrt.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSqrt.Location = new System.Drawing.Point(94, 283);
            this.BtnSqrt.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(80, 50);
            this.BtnSqrt.TabIndex = 19;
            this.BtnSqrt.Text = "x²";
            this.BtnSqrt.UseVisualStyleBackColor = false;
            this.BtnSqrt.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnOneDiv
            // 
            this.BtnOneDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnOneDiv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnOneDiv.FlatAppearance.BorderSize = 2;
            this.BtnOneDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOneDiv.Font = new System.Drawing.Font("Square721 Cn BT", 16F, System.Drawing.FontStyle.Bold);
            this.BtnOneDiv.Location = new System.Drawing.Point(11, 283);
            this.BtnOneDiv.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOneDiv.Name = "BtnOneDiv";
            this.BtnOneDiv.Size = new System.Drawing.Size(80, 50);
            this.BtnOneDiv.TabIndex = 18;
            this.BtnOneDiv.Text = "¹/x";
            this.BtnOneDiv.UseVisualStyleBackColor = false;
            this.BtnOneDiv.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.BtnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnBackspace.FlatAppearance.BorderSize = 2;
            this.BtnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackspace.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBackspace.Image = global::MyCalculator.Properties.Resources.Sharp_Arrow;
            this.BtnBackspace.Location = new System.Drawing.Point(260, 226);
            this.BtnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(80, 50);
            this.BtnBackspace.TabIndex = 8;
            this.BtnBackspace.UseVisualStyleBackColor = false;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(252)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnPlusMinus);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnRoot);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnOneDiv);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnClearEntry);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnMClear);
            this.Controls.Add(this.BtnMRead);
            this.Controls.Add(this.BtnMPlus);
            this.Controls.Add(this.BtnMMinus);
            this.Controls.Add(this.BtnMSave);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.BtnMRAnsMC);
            this.Controls.Add(this.TxtDisplay3);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(16)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Button BtnFold;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.TextBox TxtDisplay3;
        private System.Windows.Forms.Button BtnMRAnsMC;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnMSave;
        private System.Windows.Forms.Button BtnMMinus;
        private System.Windows.Forms.Button BtnMPlus;
        private System.Windows.Forms.Button BtnMRead;
        private System.Windows.Forms.Button BtnMClear;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnClearEntry;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRoot;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnOneDiv;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnPlusMinus;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
    }
}

