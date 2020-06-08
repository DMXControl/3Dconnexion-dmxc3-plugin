using LumosControls;
using LumosControls.Controls;
using  LumosControls.Controls.ToolStrip;

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
            this.groupBox1 = new LumosControls.Controls.LumosGroupBox();
            this.checkBoxLED = new LumosControls.Controls.LumosCheckBox();
            this.labelError = new LumosControls.Controls.LumosLabel();
            this.pictureBoxDevice = new System.Windows.Forms.PictureBox();
            this.labelFirmware = new LumosControls.Controls.LumosLabel();
            this.labelDeviceName = new LumosControls.Controls.LumosLabel();
            this.groupBox2 = new LumosControls.Controls.LumosGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTx = new LumosControls.Controls.LumosLabel();
            this.labelTy = new LumosControls.Controls.LumosLabel();
            this.labelTz = new LumosControls.Controls.LumosLabel();
            this.labelRx = new LumosControls.Controls.LumosLabel();
            this.labelRy = new LumosControls.Controls.LumosLabel();
            this.labelRz = new LumosControls.Controls.LumosLabel();
            this.nudTx = new LumosControls.Controls.LumosNumericUpDown();
            this.nudTy = new LumosControls.Controls.LumosNumericUpDown();
            this.nudTz = new LumosControls.Controls.LumosNumericUpDown();
            this.nudRx = new LumosControls.Controls.LumosNumericUpDown();
            this.nudRy = new LumosControls.Controls.LumosNumericUpDown();
            this.nudRz = new LumosControls.Controls.LumosNumericUpDown();
            this.label7 = new LumosControls.Controls.LumosLabel();
            this.label8 = new LumosControls.Controls.LumosLabel();
            this.label9 = new LumosControls.Controls.LumosLabel();
            this.label10 = new LumosControls.Controls.LumosLabel();
            this.label11 = new LumosControls.Controls.LumosLabel();
            this.label12 = new LumosControls.Controls.LumosLabel();
            this.label13 = new LumosControls.Controls.LumosLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
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
            this.checkBoxLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBoxLED.Location = new System.Drawing.Point(10, 65);
            this.checkBoxLED.Name = "checkBoxLED";
            this.checkBoxLED.Size = new System.Drawing.Size(107, 20);
            this.checkBoxLED.TabIndex = 4;
            this.checkBoxLED.Text = "LED Enabled";
            this.checkBoxLED.UseVisualStyleBackColor = true;
            this.checkBoxLED.CheckedChanged += new System.EventHandler(this.checkBoxLED_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(7, 143);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(62, 16);
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
            this.labelFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelFirmware.Location = new System.Drawing.Point(7, 37);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(88, 16);
            this.labelFirmware.TabIndex = 1;
            this.labelFirmware.Text = "labelFirmware";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelDeviceName.Location = new System.Drawing.Point(7, 20);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(109, 16);
            this.labelDeviceName.TabIndex = 0;
            this.labelDeviceName.Text = "labelDeviceName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
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
            this.labelTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTx.Location = new System.Drawing.Point(3, 20);
            this.labelTx.Name = "labelTx";
            this.labelTx.Size = new System.Drawing.Size(85, 25);
            this.labelTx.TabIndex = 0;
            this.labelTx.Text = "TX:";
            this.labelTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTy
            // 
            this.labelTy.AutoSize = true;
            this.labelTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTy.Location = new System.Drawing.Point(3, 45);
            this.labelTy.Name = "labelTy";
            this.labelTy.Size = new System.Drawing.Size(85, 25);
            this.labelTy.TabIndex = 1;
            this.labelTy.Text = "TY:";
            this.labelTy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTz
            // 
            this.labelTz.AutoSize = true;
            this.labelTz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTz.Location = new System.Drawing.Point(3, 70);
            this.labelTz.Name = "labelTz";
            this.labelTz.Size = new System.Drawing.Size(85, 25);
            this.labelTz.TabIndex = 2;
            this.labelTz.Text = "TZ:";
            this.labelTz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRx
            // 
            this.labelRx.AutoSize = true;
            this.labelRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelRx.Location = new System.Drawing.Point(3, 95);
            this.labelRx.Name = "labelRx";
            this.labelRx.Size = new System.Drawing.Size(85, 25);
            this.labelRx.TabIndex = 3;
            this.labelRx.Text = "RX:";
            this.labelRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRy
            // 
            this.labelRy.AutoSize = true;
            this.labelRy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelRy.Location = new System.Drawing.Point(3, 120);
            this.labelRy.Name = "labelRy";
            this.labelRy.Size = new System.Drawing.Size(85, 25);
            this.labelRy.TabIndex = 4;
            this.labelRy.Text = "RY:";
            this.labelRy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRz
            // 
            this.labelRz.AutoSize = true;
            this.labelRz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelRz.Location = new System.Drawing.Point(3, 145);
            this.labelRz.Name = "labelRz";
            this.labelRz.Size = new System.Drawing.Size(85, 27);
            this.labelRz.TabIndex = 5;
            this.labelRz.Text = "RZ:";
            this.labelRz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTx
            // 
            this.nudTx.DecimalPlaces = 0;
            this.nudTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nudTx.Hexadecimal = false;
            this.nudTx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTx.Location = new System.Drawing.Point(179, 23);
            this.nudTx.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTx.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTx.Name = "nudTx";
            this.nudTx.Size = new System.Drawing.Size(84, 20);
            this.nudTx.TabIndex = 6;
            this.nudTx.Text = "0";
            this.nudTx.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudTy
            // 
            this.nudTy.DecimalPlaces = 0;
            this.nudTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nudTy.Hexadecimal = false;
            this.nudTy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTy.Location = new System.Drawing.Point(179, 48);
            this.nudTy.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTy.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTy.Name = "nudTy";
            this.nudTy.Size = new System.Drawing.Size(84, 20);
            this.nudTy.TabIndex = 7;
            this.nudTy.Text = "0";
            this.nudTy.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudTz
            // 
            this.nudTz.DecimalPlaces = 0;
            this.nudTz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nudTz.Hexadecimal = false;
            this.nudTz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTz.Location = new System.Drawing.Point(179, 73);
            this.nudTz.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTz.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTz.Name = "nudTz";
            this.nudTz.Size = new System.Drawing.Size(84, 20);
            this.nudTz.TabIndex = 8;
            this.nudTz.Text = "0";
            this.nudTz.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudRx
            // 
            this.nudRx.DecimalPlaces = 0;
            this.nudRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nudRx.Hexadecimal = false;
            this.nudRx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRx.Location = new System.Drawing.Point(179, 98);
            this.nudRx.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRx.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRx.Name = "nudRx";
            this.nudRx.Size = new System.Drawing.Size(84, 20);
            this.nudRx.TabIndex = 9;
            this.nudRx.Text = "0";
            this.nudRx.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudRy
            // 
            this.nudRy.DecimalPlaces = 0;
            this.nudRy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nudRy.Hexadecimal = false;
            this.nudRy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRy.Location = new System.Drawing.Point(179, 123);
            this.nudRy.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRy.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRy.Name = "nudRy";
            this.nudRy.Size = new System.Drawing.Size(84, 20);
            this.nudRy.TabIndex = 10;
            this.nudRy.Text = "0";
            this.nudRy.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudRz
            // 
            this.nudRz.DecimalPlaces = 0;
            this.nudRz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nudRz.Hexadecimal = false;
            this.nudRz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRz.Location = new System.Drawing.Point(179, 148);
            this.nudRz.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRz.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRz.Name = "nudRz";
            this.nudRz.Size = new System.Drawing.Size(84, 20);
            this.nudRz.TabIndex = 11;
            this.nudRz.Text = "0";
            this.nudRz.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "+/-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "+/-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "+/-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "+/-";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(91, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "+/-";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(91, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 27);
            this.label12.TabIndex = 17;
            this.label12.Text = "+/-";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(179, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Deadzone";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _3DxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudTx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LumosGroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxDevice;
        private LumosLabel labelFirmware;
        private LumosLabel labelDeviceName;
        private LumosLabel labelError;
        private LumosGroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LumosLabel labelTx;
        private LumosLabel labelTy;
        private LumosLabel labelTz;
        private LumosLabel labelRx;
        private LumosLabel labelRy;
        private LumosLabel labelRz;
        private LumosCheckBox checkBoxLED;
        private LumosNumericUpDown nudTx;
        private LumosNumericUpDown nudTy;
        private LumosNumericUpDown nudTz;
        private LumosNumericUpDown nudRx;
        private LumosNumericUpDown nudRy;
        private LumosNumericUpDown nudRz;
        private LumosLabel label7;
        private LumosLabel label8;
        private LumosLabel label9;
        private LumosLabel label10;
        private LumosLabel label11;
        private LumosLabel label12;
        private LumosLabel label13;
    }
}