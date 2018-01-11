namespace Lumos3DconnexionPlugin
{
    partial class _3DxForm
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
                DisposeStuff();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLED = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxDevice = new System.Windows.Forms.PictureBox();
            this.labelFirmware = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTx = new System.Windows.Forms.Label();
            this.labelTy = new System.Windows.Forms.Label();
            this.labelTz = new System.Windows.Forms.Label();
            this.labelRx = new System.Windows.Forms.Label();
            this.labelRy = new System.Windows.Forms.Label();
            this.labelRz = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTx = new System.Windows.Forms.ComboBox();
            this.cbTy = new System.Windows.Forms.ComboBox();
            this.cbTz = new System.Windows.Forms.ComboBox();
            this.cbRx = new System.Windows.Forms.ComboBox();
            this.cbRy = new System.Windows.Forms.ComboBox();
            this.cbRz = new System.Windows.Forms.ComboBox();
            this.nudTx = new System.Windows.Forms.NumericUpDown();
            this.nudTy = new System.Windows.Forms.NumericUpDown();
            this.nudTz = new System.Windows.Forms.NumericUpDown();
            this.nudRx = new System.Windows.Forms.NumericUpDown();
            this.nudRy = new System.Windows.Forms.NumericUpDown();
            this.nudRz = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLED);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.pictureBoxDevice);
            this.groupBox1.Controls.Add(this.labelFirmware);
            this.groupBox1.Controls.Add(this.labelDeviceName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // checkBoxLED
            // 
            this.checkBoxLED.AutoSize = true;
            this.checkBoxLED.Checked = true;
            this.checkBoxLED.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLED.Location = new System.Drawing.Point(10, 65);
            this.checkBoxLED.Name = "checkBoxLED";
            this.checkBoxLED.Size = new System.Drawing.Size(89, 17);
            this.checkBoxLED.TabIndex = 4;
            this.checkBoxLED.Text = "LED Enabled";
            this.checkBoxLED.UseVisualStyleBackColor = true;
            this.checkBoxLED.CheckedChanged += new System.EventHandler(this.checkBoxLED_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(7, 143);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(51, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "labelError";
            this.labelError.Visible = false;
            // 
            // pictureBoxDevice
            // 
            this.pictureBoxDevice.Location = new System.Drawing.Point(128, 12);
            this.pictureBoxDevice.Name = "pictureBoxDevice";
            this.pictureBoxDevice.Size = new System.Drawing.Size(144, 144);
            this.pictureBoxDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDevice.TabIndex = 2;
            this.pictureBoxDevice.TabStop = false;
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(7, 37);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(71, 13);
            this.labelFirmware.TabIndex = 1;
            this.labelFirmware.Text = "labelFirmware";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(7, 20);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(91, 13);
            this.labelDeviceName.TabIndex = 0;
            this.labelDeviceName.Text = "labelDeviceName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Values";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelTx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTz, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRy, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRz, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.nudTx, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudTy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudTz, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudRx, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudRy, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudRz, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTx
            // 
            this.labelTx.AutoSize = true;
            this.labelTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTx.Location = new System.Drawing.Point(3, 20);
            this.labelTx.Name = "labelTx";
            this.labelTx.Size = new System.Drawing.Size(82, 25);
            this.labelTx.TabIndex = 0;
            this.labelTx.Text = "TX:";
            this.labelTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTy
            // 
            this.labelTy.AutoSize = true;
            this.labelTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTy.Location = new System.Drawing.Point(3, 45);
            this.labelTy.Name = "labelTy";
            this.labelTy.Size = new System.Drawing.Size(82, 25);
            this.labelTy.TabIndex = 1;
            this.labelTy.Text = "TY:";
            this.labelTy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTz
            // 
            this.labelTz.AutoSize = true;
            this.labelTz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTz.Location = new System.Drawing.Point(3, 70);
            this.labelTz.Name = "labelTz";
            this.labelTz.Size = new System.Drawing.Size(82, 25);
            this.labelTz.TabIndex = 2;
            this.labelTz.Text = "TZ:";
            this.labelTz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRx
            // 
            this.labelRx.AutoSize = true;
            this.labelRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRx.Location = new System.Drawing.Point(3, 95);
            this.labelRx.Name = "labelRx";
            this.labelRx.Size = new System.Drawing.Size(82, 25);
            this.labelRx.TabIndex = 3;
            this.labelRx.Text = "RX:";
            this.labelRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRy
            // 
            this.labelRy.AutoSize = true;
            this.labelRy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRy.Location = new System.Drawing.Point(3, 120);
            this.labelRy.Name = "labelRy";
            this.labelRy.Size = new System.Drawing.Size(82, 25);
            this.labelRy.TabIndex = 4;
            this.labelRy.Text = "RY:";
            this.labelRy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRz
            // 
            this.labelRz.AutoSize = true;
            this.labelRz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRz.Location = new System.Drawing.Point(3, 145);
            this.labelRz.Name = "labelRz";
            this.labelRz.Size = new System.Drawing.Size(82, 27);
            this.labelRz.TabIndex = 5;
            this.labelRz.Text = "RZ:";
            this.labelRz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(306, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 371);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mapping";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbTx, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbTy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbTz, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbRx, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbRy, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbRz, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 167);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TX:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "TY:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "TZ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "RX:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "RY:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "RZ:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTx
            // 
            this.cbTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTx.FormattingEnabled = true;
            this.cbTx.Location = new System.Drawing.Point(92, 3);
            this.cbTx.Name = "cbTx";
            this.cbTx.Size = new System.Drawing.Size(207, 21);
            this.cbTx.TabIndex = 6;
            this.cbTx.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbTy
            // 
            this.cbTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTy.FormattingEnabled = true;
            this.cbTy.Location = new System.Drawing.Point(92, 30);
            this.cbTy.Name = "cbTy";
            this.cbTy.Size = new System.Drawing.Size(207, 21);
            this.cbTy.TabIndex = 7;
            this.cbTy.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbTz
            // 
            this.cbTz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTz.FormattingEnabled = true;
            this.cbTz.Location = new System.Drawing.Point(92, 57);
            this.cbTz.Name = "cbTz";
            this.cbTz.Size = new System.Drawing.Size(207, 21);
            this.cbTz.TabIndex = 8;
            this.cbTz.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbRx
            // 
            this.cbRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRx.FormattingEnabled = true;
            this.cbRx.Location = new System.Drawing.Point(92, 84);
            this.cbRx.Name = "cbRx";
            this.cbRx.Size = new System.Drawing.Size(207, 21);
            this.cbRx.TabIndex = 9;
            this.cbRx.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbRy
            // 
            this.cbRy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRy.FormattingEnabled = true;
            this.cbRy.Location = new System.Drawing.Point(92, 111);
            this.cbRy.Name = "cbRy";
            this.cbRy.Size = new System.Drawing.Size(207, 21);
            this.cbRy.TabIndex = 10;
            this.cbRy.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbRz
            // 
            this.cbRz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRz.FormattingEnabled = true;
            this.cbRz.Location = new System.Drawing.Point(92, 138);
            this.cbRz.Name = "cbRz";
            this.cbRz.Size = new System.Drawing.Size(207, 21);
            this.cbRz.TabIndex = 11;
            this.cbRz.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // nudTx
            // 
            this.nudTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTx.Location = new System.Drawing.Point(179, 23);
            this.nudTx.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTx.Name = "nudTx";
            this.nudTx.Size = new System.Drawing.Size(84, 20);
            this.nudTx.TabIndex = 6;
            // 
            // nudTy
            // 
            this.nudTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTy.Location = new System.Drawing.Point(179, 48);
            this.nudTy.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTy.Name = "nudTy";
            this.nudTy.Size = new System.Drawing.Size(84, 20);
            this.nudTy.TabIndex = 7;
            // 
            // nudTz
            // 
            this.nudTz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTz.Location = new System.Drawing.Point(179, 73);
            this.nudTz.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTz.Name = "nudTz";
            this.nudTz.Size = new System.Drawing.Size(84, 20);
            this.nudTz.TabIndex = 8;
            // 
            // nudRx
            // 
            this.nudRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRx.Location = new System.Drawing.Point(179, 98);
            this.nudRx.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRx.Name = "nudRx";
            this.nudRx.Size = new System.Drawing.Size(84, 20);
            this.nudRx.TabIndex = 9;
            // 
            // nudRy
            // 
            this.nudRy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRy.Location = new System.Drawing.Point(179, 123);
            this.nudRy.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRy.Name = "nudRy";
            this.nudRy.Size = new System.Drawing.Size(84, 20);
            this.nudRy.TabIndex = 10;
            // 
            // nudRz
            // 
            this.nudRz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRz.Location = new System.Drawing.Point(179, 148);
            this.nudRz.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRz.Name = "nudRz";
            this.nudRz.Size = new System.Drawing.Size(84, 20);
            this.nudRz.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(91, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "+/-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(91, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "+/-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(91, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "+/-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(91, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "+/-";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(91, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "+/-";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(91, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 27);
            this.label12.TabIndex = 17;
            this.label12.Text = "+/-";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(179, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Deadzone";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _3DxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 417);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenu = LumosLIB.GUI.Windows.MenuType.Settings;
            this.Name = "_3DxForm";
            this.TabText = "3Dconnexion";
            this.Text = "3Dconnexion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxDevice;
        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTx;
        private System.Windows.Forms.Label labelTy;
        private System.Windows.Forms.Label labelTz;
        private System.Windows.Forms.Label labelRx;
        private System.Windows.Forms.Label labelRy;
        private System.Windows.Forms.Label labelRz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxLED;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTx;
        private System.Windows.Forms.ComboBox cbTy;
        private System.Windows.Forms.ComboBox cbTz;
        private System.Windows.Forms.ComboBox cbRx;
        private System.Windows.Forms.ComboBox cbRy;
        private System.Windows.Forms.ComboBox cbRz;
        private System.Windows.Forms.NumericUpDown nudTx;
        private System.Windows.Forms.NumericUpDown nudTy;
        private System.Windows.Forms.NumericUpDown nudTz;
        private System.Windows.Forms.NumericUpDown nudRx;
        private System.Windows.Forms.NumericUpDown nudRy;
        private System.Windows.Forms.NumericUpDown nudRz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}