﻿
namespace CoreXYSerialCOM
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMag = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn27 = new System.Windows.Forms.Button();
            this.btn37 = new System.Windows.Forms.Button();
            this.btn47 = new System.Windows.Forms.Button();
            this.btn57 = new System.Windows.Forms.Button();
            this.btn67 = new System.Windows.Forms.Button();
            this.btn77 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn26 = new System.Windows.Forms.Button();
            this.btn36 = new System.Windows.Forms.Button();
            this.btn46 = new System.Windows.Forms.Button();
            this.btn56 = new System.Windows.Forms.Button();
            this.btn66 = new System.Windows.Forms.Button();
            this.btn76 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn55 = new System.Windows.Forms.Button();
            this.btn65 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn24 = new System.Windows.Forms.Button();
            this.btn34 = new System.Windows.Forms.Button();
            this.btn44 = new System.Windows.Forms.Button();
            this.btn54 = new System.Windows.Forms.Button();
            this.btn64 = new System.Windows.Forms.Button();
            this.btn74 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn43 = new System.Windows.Forms.Button();
            this.btn53 = new System.Windows.Forms.Button();
            this.btn63 = new System.Windows.Forms.Button();
            this.btn73 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn42 = new System.Windows.Forms.Button();
            this.btn52 = new System.Windows.Forms.Button();
            this.btn62 = new System.Windows.Forms.Button();
            this.btn72 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn41 = new System.Windows.Forms.Button();
            this.btn51 = new System.Windows.Forms.Button();
            this.btn61 = new System.Windows.Forms.Button();
            this.btn71 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn70 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "btnMain";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(467, 515);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(25, 71);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(88, 42);
            this.btnStep.TabIndex = 2;
            this.btnStep.Text = "Disable Steppers";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 163);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Positions";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(25, 467);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(88, 42);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(61, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnMag);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnStep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(952, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 529);
            this.panel1.TabIndex = 7;
            // 
            // btnMag
            // 
            this.btnMag.Location = new System.Drawing.Point(25, 419);
            this.btnMag.Name = "btnMag";
            this.btnMag.Size = new System.Drawing.Size(88, 42);
            this.btnMag.TabIndex = 1;
            this.btnMag.Text = "Turn Magnet On";
            this.btnMag.UseVisualStyleBackColor = true;
            this.btnMag.Click += new System.EventHandler(this.btnMag_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 515);
            this.panel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 529);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.btn07, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn17, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn27, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn37, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn47, 4, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn57, 5, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn67, 6, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn77, 7, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn06, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn16, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn26, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn36, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn46, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn56, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn66, 6, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn76, 7, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn05, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn15, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn25, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn35, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn45, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn55, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn65, 6, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn75, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn04, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn14, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn24, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn34, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn44, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn54, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn64, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn74, 7, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn03, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn13, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn23, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn33, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn43, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn53, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn63, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn73, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn02, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn12, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn22, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn32, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn42, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn52, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn62, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn72, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn01, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn11, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn21, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn31, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn41, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn51, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn61, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn71, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn20, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn30, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn40, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn50, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn60, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn70, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(476, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 521);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btn07
            // 
            this.btn07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn07.Location = new System.Drawing.Point(0, 455);
            this.btn07.Margin = new System.Windows.Forms.Padding(0);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(59, 65);
            this.btn07.TabIndex = 49;
            this.btn07.UseVisualStyleBackColor = true;
            // 
            // btn17
            // 
            this.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn17.Location = new System.Drawing.Point(59, 455);
            this.btn17.Margin = new System.Windows.Forms.Padding(0);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(59, 65);
            this.btn17.TabIndex = 50;
            this.btn17.UseVisualStyleBackColor = true;
            // 
            // btn27
            // 
            this.btn27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn27.Location = new System.Drawing.Point(118, 455);
            this.btn27.Margin = new System.Windows.Forms.Padding(0);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(59, 65);
            this.btn27.TabIndex = 51;
            this.btn27.UseVisualStyleBackColor = true;
            // 
            // btn37
            // 
            this.btn37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn37.Location = new System.Drawing.Point(177, 455);
            this.btn37.Margin = new System.Windows.Forms.Padding(0);
            this.btn37.Name = "btn37";
            this.btn37.Size = new System.Drawing.Size(59, 65);
            this.btn37.TabIndex = 52;
            this.btn37.UseVisualStyleBackColor = true;
            // 
            // btn47
            // 
            this.btn47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn47.Location = new System.Drawing.Point(236, 455);
            this.btn47.Margin = new System.Windows.Forms.Padding(0);
            this.btn47.Name = "btn47";
            this.btn47.Size = new System.Drawing.Size(59, 65);
            this.btn47.TabIndex = 53;
            this.btn47.UseVisualStyleBackColor = true;
            // 
            // btn57
            // 
            this.btn57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn57.Location = new System.Drawing.Point(295, 455);
            this.btn57.Margin = new System.Windows.Forms.Padding(0);
            this.btn57.Name = "btn57";
            this.btn57.Size = new System.Drawing.Size(59, 65);
            this.btn57.TabIndex = 54;
            this.btn57.UseVisualStyleBackColor = true;
            // 
            // btn67
            // 
            this.btn67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn67.Location = new System.Drawing.Point(354, 455);
            this.btn67.Margin = new System.Windows.Forms.Padding(0);
            this.btn67.Name = "btn67";
            this.btn67.Size = new System.Drawing.Size(59, 65);
            this.btn67.TabIndex = 55;
            this.btn67.UseVisualStyleBackColor = true;
            // 
            // btn77
            // 
            this.btn77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn77.Location = new System.Drawing.Point(413, 455);
            this.btn77.Margin = new System.Windows.Forms.Padding(0);
            this.btn77.Name = "btn77";
            this.btn77.Size = new System.Drawing.Size(59, 65);
            this.btn77.TabIndex = 56;
            this.btn77.UseVisualStyleBackColor = true;
            // 
            // btn06
            // 
            this.btn06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn06.Location = new System.Drawing.Point(0, 390);
            this.btn06.Margin = new System.Windows.Forms.Padding(0);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(59, 65);
            this.btn06.TabIndex = 41;
            this.btn06.UseVisualStyleBackColor = true;
            // 
            // btn16
            // 
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Location = new System.Drawing.Point(59, 390);
            this.btn16.Margin = new System.Windows.Forms.Padding(0);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(59, 65);
            this.btn16.TabIndex = 42;
            this.btn16.UseVisualStyleBackColor = true;
            // 
            // btn26
            // 
            this.btn26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn26.Location = new System.Drawing.Point(118, 390);
            this.btn26.Margin = new System.Windows.Forms.Padding(0);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(59, 65);
            this.btn26.TabIndex = 43;
            this.btn26.UseVisualStyleBackColor = true;
            // 
            // btn36
            // 
            this.btn36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn36.Location = new System.Drawing.Point(177, 390);
            this.btn36.Margin = new System.Windows.Forms.Padding(0);
            this.btn36.Name = "btn36";
            this.btn36.Size = new System.Drawing.Size(59, 65);
            this.btn36.TabIndex = 44;
            this.btn36.UseVisualStyleBackColor = true;
            // 
            // btn46
            // 
            this.btn46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn46.Location = new System.Drawing.Point(236, 390);
            this.btn46.Margin = new System.Windows.Forms.Padding(0);
            this.btn46.Name = "btn46";
            this.btn46.Size = new System.Drawing.Size(59, 65);
            this.btn46.TabIndex = 45;
            this.btn46.UseVisualStyleBackColor = true;
            // 
            // btn56
            // 
            this.btn56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn56.Location = new System.Drawing.Point(295, 390);
            this.btn56.Margin = new System.Windows.Forms.Padding(0);
            this.btn56.Name = "btn56";
            this.btn56.Size = new System.Drawing.Size(59, 65);
            this.btn56.TabIndex = 46;
            this.btn56.UseVisualStyleBackColor = true;
            // 
            // btn66
            // 
            this.btn66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn66.Location = new System.Drawing.Point(354, 390);
            this.btn66.Margin = new System.Windows.Forms.Padding(0);
            this.btn66.Name = "btn66";
            this.btn66.Size = new System.Drawing.Size(59, 65);
            this.btn66.TabIndex = 47;
            this.btn66.UseVisualStyleBackColor = true;
            // 
            // btn76
            // 
            this.btn76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn76.Location = new System.Drawing.Point(413, 390);
            this.btn76.Margin = new System.Windows.Forms.Padding(0);
            this.btn76.Name = "btn76";
            this.btn76.Size = new System.Drawing.Size(59, 65);
            this.btn76.TabIndex = 48;
            this.btn76.UseVisualStyleBackColor = true;
            // 
            // btn05
            // 
            this.btn05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn05.Location = new System.Drawing.Point(0, 325);
            this.btn05.Margin = new System.Windows.Forms.Padding(0);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(59, 65);
            this.btn05.TabIndex = 33;
            this.btn05.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Location = new System.Drawing.Point(59, 325);
            this.btn15.Margin = new System.Windows.Forms.Padding(0);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(59, 65);
            this.btn15.TabIndex = 34;
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // btn25
            // 
            this.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn25.Location = new System.Drawing.Point(118, 325);
            this.btn25.Margin = new System.Windows.Forms.Padding(0);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(59, 65);
            this.btn25.TabIndex = 35;
            this.btn25.UseVisualStyleBackColor = true;
            // 
            // btn35
            // 
            this.btn35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn35.Location = new System.Drawing.Point(177, 325);
            this.btn35.Margin = new System.Windows.Forms.Padding(0);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(59, 65);
            this.btn35.TabIndex = 36;
            this.btn35.UseVisualStyleBackColor = true;
            // 
            // btn45
            // 
            this.btn45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn45.Location = new System.Drawing.Point(236, 325);
            this.btn45.Margin = new System.Windows.Forms.Padding(0);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(59, 65);
            this.btn45.TabIndex = 37;
            this.btn45.UseVisualStyleBackColor = true;
            // 
            // btn55
            // 
            this.btn55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn55.Location = new System.Drawing.Point(295, 325);
            this.btn55.Margin = new System.Windows.Forms.Padding(0);
            this.btn55.Name = "btn55";
            this.btn55.Size = new System.Drawing.Size(59, 65);
            this.btn55.TabIndex = 38;
            this.btn55.UseVisualStyleBackColor = true;
            // 
            // btn65
            // 
            this.btn65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn65.Location = new System.Drawing.Point(354, 325);
            this.btn65.Margin = new System.Windows.Forms.Padding(0);
            this.btn65.Name = "btn65";
            this.btn65.Size = new System.Drawing.Size(59, 65);
            this.btn65.TabIndex = 39;
            this.btn65.UseVisualStyleBackColor = true;
            // 
            // btn75
            // 
            this.btn75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn75.Location = new System.Drawing.Point(413, 325);
            this.btn75.Margin = new System.Windows.Forms.Padding(0);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(59, 65);
            this.btn75.TabIndex = 40;
            this.btn75.UseVisualStyleBackColor = true;
            // 
            // btn04
            // 
            this.btn04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn04.Location = new System.Drawing.Point(0, 260);
            this.btn04.Margin = new System.Windows.Forms.Padding(0);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(59, 65);
            this.btn04.TabIndex = 25;
            this.btn04.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Location = new System.Drawing.Point(59, 260);
            this.btn14.Margin = new System.Windows.Forms.Padding(0);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(59, 65);
            this.btn14.TabIndex = 26;
            this.btn14.UseVisualStyleBackColor = true;
            // 
            // btn24
            // 
            this.btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn24.Location = new System.Drawing.Point(118, 260);
            this.btn24.Margin = new System.Windows.Forms.Padding(0);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(59, 65);
            this.btn24.TabIndex = 27;
            this.btn24.UseVisualStyleBackColor = true;
            // 
            // btn34
            // 
            this.btn34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn34.Location = new System.Drawing.Point(177, 260);
            this.btn34.Margin = new System.Windows.Forms.Padding(0);
            this.btn34.Name = "btn34";
            this.btn34.Size = new System.Drawing.Size(59, 65);
            this.btn34.TabIndex = 28;
            this.btn34.UseVisualStyleBackColor = true;
            // 
            // btn44
            // 
            this.btn44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn44.Location = new System.Drawing.Point(236, 260);
            this.btn44.Margin = new System.Windows.Forms.Padding(0);
            this.btn44.Name = "btn44";
            this.btn44.Size = new System.Drawing.Size(59, 65);
            this.btn44.TabIndex = 29;
            this.btn44.UseVisualStyleBackColor = true;
            // 
            // btn54
            // 
            this.btn54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn54.Location = new System.Drawing.Point(295, 260);
            this.btn54.Margin = new System.Windows.Forms.Padding(0);
            this.btn54.Name = "btn54";
            this.btn54.Size = new System.Drawing.Size(59, 65);
            this.btn54.TabIndex = 30;
            this.btn54.UseVisualStyleBackColor = true;
            // 
            // btn64
            // 
            this.btn64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn64.Location = new System.Drawing.Point(354, 260);
            this.btn64.Margin = new System.Windows.Forms.Padding(0);
            this.btn64.Name = "btn64";
            this.btn64.Size = new System.Drawing.Size(59, 65);
            this.btn64.TabIndex = 31;
            this.btn64.UseVisualStyleBackColor = true;
            // 
            // btn74
            // 
            this.btn74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn74.Location = new System.Drawing.Point(413, 260);
            this.btn74.Margin = new System.Windows.Forms.Padding(0);
            this.btn74.Name = "btn74";
            this.btn74.Size = new System.Drawing.Size(59, 65);
            this.btn74.TabIndex = 32;
            this.btn74.UseVisualStyleBackColor = true;
            // 
            // btn03
            // 
            this.btn03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn03.Location = new System.Drawing.Point(0, 195);
            this.btn03.Margin = new System.Windows.Forms.Padding(0);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(59, 65);
            this.btn03.TabIndex = 17;
            this.btn03.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Location = new System.Drawing.Point(59, 195);
            this.btn13.Margin = new System.Windows.Forms.Padding(0);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(59, 65);
            this.btn13.TabIndex = 18;
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn23
            // 
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Location = new System.Drawing.Point(118, 195);
            this.btn23.Margin = new System.Windows.Forms.Padding(0);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(59, 65);
            this.btn23.TabIndex = 19;
            this.btn23.UseVisualStyleBackColor = true;
            // 
            // btn33
            // 
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Location = new System.Drawing.Point(177, 195);
            this.btn33.Margin = new System.Windows.Forms.Padding(0);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(59, 65);
            this.btn33.TabIndex = 20;
            this.btn33.UseVisualStyleBackColor = true;
            // 
            // btn43
            // 
            this.btn43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn43.Location = new System.Drawing.Point(236, 195);
            this.btn43.Margin = new System.Windows.Forms.Padding(0);
            this.btn43.Name = "btn43";
            this.btn43.Size = new System.Drawing.Size(59, 65);
            this.btn43.TabIndex = 21;
            this.btn43.UseVisualStyleBackColor = true;
            // 
            // btn53
            // 
            this.btn53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn53.Location = new System.Drawing.Point(295, 195);
            this.btn53.Margin = new System.Windows.Forms.Padding(0);
            this.btn53.Name = "btn53";
            this.btn53.Size = new System.Drawing.Size(59, 65);
            this.btn53.TabIndex = 22;
            this.btn53.UseVisualStyleBackColor = true;
            // 
            // btn63
            // 
            this.btn63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn63.Location = new System.Drawing.Point(354, 195);
            this.btn63.Margin = new System.Windows.Forms.Padding(0);
            this.btn63.Name = "btn63";
            this.btn63.Size = new System.Drawing.Size(59, 65);
            this.btn63.TabIndex = 23;
            this.btn63.UseVisualStyleBackColor = true;
            // 
            // btn73
            // 
            this.btn73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn73.Location = new System.Drawing.Point(413, 195);
            this.btn73.Margin = new System.Windows.Forms.Padding(0);
            this.btn73.Name = "btn73";
            this.btn73.Size = new System.Drawing.Size(59, 65);
            this.btn73.TabIndex = 24;
            this.btn73.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Location = new System.Drawing.Point(0, 130);
            this.btn02.Margin = new System.Windows.Forms.Padding(0);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(59, 65);
            this.btn02.TabIndex = 9;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Location = new System.Drawing.Point(59, 130);
            this.btn12.Margin = new System.Windows.Forms.Padding(0);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(59, 65);
            this.btn12.TabIndex = 10;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Location = new System.Drawing.Point(118, 130);
            this.btn22.Margin = new System.Windows.Forms.Padding(0);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(59, 65);
            this.btn22.TabIndex = 11;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn32
            // 
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Location = new System.Drawing.Point(177, 130);
            this.btn32.Margin = new System.Windows.Forms.Padding(0);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(59, 65);
            this.btn32.TabIndex = 12;
            this.btn32.UseVisualStyleBackColor = true;
            // 
            // btn42
            // 
            this.btn42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn42.Location = new System.Drawing.Point(236, 130);
            this.btn42.Margin = new System.Windows.Forms.Padding(0);
            this.btn42.Name = "btn42";
            this.btn42.Size = new System.Drawing.Size(59, 65);
            this.btn42.TabIndex = 13;
            this.btn42.UseVisualStyleBackColor = true;
            // 
            // btn52
            // 
            this.btn52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn52.Location = new System.Drawing.Point(295, 130);
            this.btn52.Margin = new System.Windows.Forms.Padding(0);
            this.btn52.Name = "btn52";
            this.btn52.Size = new System.Drawing.Size(59, 65);
            this.btn52.TabIndex = 14;
            this.btn52.UseVisualStyleBackColor = true;
            // 
            // btn62
            // 
            this.btn62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn62.Location = new System.Drawing.Point(354, 130);
            this.btn62.Margin = new System.Windows.Forms.Padding(0);
            this.btn62.Name = "btn62";
            this.btn62.Size = new System.Drawing.Size(59, 65);
            this.btn62.TabIndex = 15;
            this.btn62.UseVisualStyleBackColor = true;
            // 
            // btn72
            // 
            this.btn72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn72.Location = new System.Drawing.Point(413, 130);
            this.btn72.Margin = new System.Windows.Forms.Padding(0);
            this.btn72.Name = "btn72";
            this.btn72.Size = new System.Drawing.Size(59, 65);
            this.btn72.TabIndex = 16;
            this.btn72.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Location = new System.Drawing.Point(0, 65);
            this.btn01.Margin = new System.Windows.Forms.Padding(0);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(59, 65);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Location = new System.Drawing.Point(59, 65);
            this.btn11.Margin = new System.Windows.Forms.Padding(0);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(59, 65);
            this.btn11.TabIndex = 2;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Location = new System.Drawing.Point(118, 65);
            this.btn21.Margin = new System.Windows.Forms.Padding(0);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(59, 65);
            this.btn21.TabIndex = 3;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn31
            // 
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Location = new System.Drawing.Point(177, 65);
            this.btn31.Margin = new System.Windows.Forms.Padding(0);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(59, 65);
            this.btn31.TabIndex = 4;
            this.btn31.UseVisualStyleBackColor = true;
            // 
            // btn41
            // 
            this.btn41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn41.Location = new System.Drawing.Point(236, 65);
            this.btn41.Margin = new System.Windows.Forms.Padding(0);
            this.btn41.Name = "btn41";
            this.btn41.Size = new System.Drawing.Size(59, 65);
            this.btn41.TabIndex = 5;
            this.btn41.UseVisualStyleBackColor = true;
            // 
            // btn51
            // 
            this.btn51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn51.Location = new System.Drawing.Point(295, 65);
            this.btn51.Margin = new System.Windows.Forms.Padding(0);
            this.btn51.Name = "btn51";
            this.btn51.Size = new System.Drawing.Size(59, 65);
            this.btn51.TabIndex = 6;
            this.btn51.UseVisualStyleBackColor = true;
            // 
            // btn61
            // 
            this.btn61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn61.Location = new System.Drawing.Point(354, 65);
            this.btn61.Margin = new System.Windows.Forms.Padding(0);
            this.btn61.Name = "btn61";
            this.btn61.Size = new System.Drawing.Size(59, 65);
            this.btn61.TabIndex = 7;
            this.btn61.UseVisualStyleBackColor = true;
            // 
            // btn71
            // 
            this.btn71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn71.Location = new System.Drawing.Point(413, 65);
            this.btn71.Margin = new System.Windows.Forms.Padding(0);
            this.btn71.Name = "btn71";
            this.btn71.Size = new System.Drawing.Size(59, 65);
            this.btn71.TabIndex = 8;
            this.btn71.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Location = new System.Drawing.Point(0, 0);
            this.btn00.Margin = new System.Windows.Forms.Padding(0);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(59, 65);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Location = new System.Drawing.Point(59, 0);
            this.btn10.Margin = new System.Windows.Forms.Padding(0);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(59, 65);
            this.btn10.TabIndex = 0;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Location = new System.Drawing.Point(118, 0);
            this.btn20.Margin = new System.Windows.Forms.Padding(0);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(59, 65);
            this.btn20.TabIndex = 0;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30.Location = new System.Drawing.Point(177, 0);
            this.btn30.Margin = new System.Windows.Forms.Padding(0);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(59, 65);
            this.btn30.TabIndex = 0;
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // btn40
            // 
            this.btn40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn40.Location = new System.Drawing.Point(236, 0);
            this.btn40.Margin = new System.Windows.Forms.Padding(0);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(59, 65);
            this.btn40.TabIndex = 0;
            this.btn40.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Location = new System.Drawing.Point(295, 0);
            this.btn50.Margin = new System.Windows.Forms.Padding(0);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(59, 65);
            this.btn50.TabIndex = 0;
            this.btn50.UseVisualStyleBackColor = true;
            // 
            // btn60
            // 
            this.btn60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn60.Location = new System.Drawing.Point(354, 0);
            this.btn60.Margin = new System.Windows.Forms.Padding(0);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(59, 65);
            this.btn60.TabIndex = 0;
            this.btn60.UseVisualStyleBackColor = true;
            // 
            // btn70
            // 
            this.btn70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn70.Location = new System.Drawing.Point(413, 0);
            this.btn70.Margin = new System.Windows.Forms.Padding(0);
            this.btn70.Name = "btn70";
            this.btn70.Size = new System.Drawing.Size(59, 65);
            this.btn70.TabIndex = 0;
            this.btn70.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn37;
        private System.Windows.Forms.Button btn47;
        private System.Windows.Forms.Button btn57;
        private System.Windows.Forms.Button btn67;
        private System.Windows.Forms.Button btn77;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn36;
        private System.Windows.Forms.Button btn46;
        private System.Windows.Forms.Button btn56;
        private System.Windows.Forms.Button btn66;
        private System.Windows.Forms.Button btn76;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn55;
        private System.Windows.Forms.Button btn65;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn34;
        private System.Windows.Forms.Button btn44;
        private System.Windows.Forms.Button btn54;
        private System.Windows.Forms.Button btn64;
        private System.Windows.Forms.Button btn74;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn43;
        private System.Windows.Forms.Button btn53;
        private System.Windows.Forms.Button btn63;
        private System.Windows.Forms.Button btn73;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn42;
        private System.Windows.Forms.Button btn52;
        private System.Windows.Forms.Button btn62;
        private System.Windows.Forms.Button btn72;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn41;
        private System.Windows.Forms.Button btn51;
        private System.Windows.Forms.Button btn61;
        private System.Windows.Forms.Button btn71;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn70;
    }
}

