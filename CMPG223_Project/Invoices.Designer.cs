﻿
namespace CMPG223_Project
{
    partial class frmInvoices
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCompTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCompVAT = new System.Windows.Forms.TextBox();
            this.txtCompExcVAT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDisk = new System.Windows.Forms.CheckBox();
            this.cbxCompMotherboard = new System.Windows.Forms.CheckBox();
            this.cbxCompVirus = new System.Windows.Forms.CheckBox();
            this.cbxCompBattery = new System.Windows.Forms.CheckBox();
            this.cbxCompScreen = new System.Windows.Forms.CheckBox();
            this.cbxKeyboard = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCellTotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCellVAT = new System.Windows.Forms.TextBox();
            this.txtCellExcVAT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxCharge = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxCellMotherboard = new System.Windows.Forms.CheckBox();
            this.cbxCellVirus = new System.Windows.Forms.CheckBox();
            this.cbxCellBattery = new System.Windows.Forms.CheckBox();
            this.cbxCellScreen = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.listBoxInvoice = new System.Windows.Forms.ListBox();
            this.btnCompViewInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnCellViewInvoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Inspection Fee:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompTotal);
            this.groupBox1.Controls.Add(this.btnCompViewInvoice);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtCompVAT);
            this.groupBox1.Controls.Add(this.txtCompExcVAT);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbxDisk);
            this.groupBox1.Controls.Add(this.cbxCompMotherboard);
            this.groupBox1.Controls.Add(this.cbxCompVirus);
            this.groupBox1.Controls.Add(this.cbxCompBattery);
            this.groupBox1.Controls.Add(this.cbxCompScreen);
            this.groupBox1.Controls.Add(this.cbxKeyboard);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Amount Computer";
            // 
            // txtCompTotal
            // 
            this.txtCompTotal.Location = new System.Drawing.Point(137, 284);
            this.txtCompTotal.Name = "txtCompTotal";
            this.txtCompTotal.ReadOnly = true;
            this.txtCompTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCompTotal.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 282);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Overall Total:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "VAT Amount:";
            // 
            // txtCompVAT
            // 
            this.txtCompVAT.Location = new System.Drawing.Point(137, 257);
            this.txtCompVAT.Name = "txtCompVAT";
            this.txtCompVAT.ReadOnly = true;
            this.txtCompVAT.Size = new System.Drawing.Size(100, 20);
            this.txtCompVAT.TabIndex = 11;
            // 
            // txtCompExcVAT
            // 
            this.txtCompExcVAT.Location = new System.Drawing.Point(137, 230);
            this.txtCompExcVAT.Name = "txtCompExcVAT";
            this.txtCompExcVAT.ReadOnly = true;
            this.txtCompExcVAT.Size = new System.Drawing.Size(100, 20);
            this.txtCompExcVAT.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Total Excluding VAT:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(169, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(60, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "R 500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "R 1200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "R 800";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "R 200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "R 1500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "R 600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "R 250";
            // 
            // cbxDisk
            // 
            this.cbxDisk.AutoSize = true;
            this.cbxDisk.Location = new System.Drawing.Point(18, 200);
            this.cbxDisk.Name = "cbxDisk";
            this.cbxDisk.Size = new System.Drawing.Size(108, 17);
            this.cbxDisk.TabIndex = 7;
            this.cbxDisk.Text = "HardDrive Failure";
            this.cbxDisk.UseVisualStyleBackColor = true;
            this.cbxDisk.CheckedChanged += new System.EventHandler(this.cbxDisk_CheckedChanged);
            // 
            // cbxCompMotherboard
            // 
            this.cbxCompMotherboard.AutoSize = true;
            this.cbxCompMotherboard.Location = new System.Drawing.Point(18, 177);
            this.cbxCompMotherboard.Name = "cbxCompMotherboard";
            this.cbxCompMotherboard.Size = new System.Drawing.Size(120, 17);
            this.cbxCompMotherboard.TabIndex = 6;
            this.cbxCompMotherboard.Text = "Motherboard Failure";
            this.cbxCompMotherboard.UseVisualStyleBackColor = true;
            this.cbxCompMotherboard.CheckedChanged += new System.EventHandler(this.cbxMotherboard_CheckedChanged);
            // 
            // cbxCompVirus
            // 
            this.cbxCompVirus.AutoSize = true;
            this.cbxCompVirus.Location = new System.Drawing.Point(18, 154);
            this.cbxCompVirus.Name = "cbxCompVirus";
            this.cbxCompVirus.Size = new System.Drawing.Size(93, 17);
            this.cbxCompVirus.TabIndex = 5;
            this.cbxCompVirus.Text = "Virus Infection";
            this.cbxCompVirus.UseVisualStyleBackColor = true;
            this.cbxCompVirus.CheckedChanged += new System.EventHandler(this.cbxVirus_CheckedChanged);
            // 
            // cbxCompBattery
            // 
            this.cbxCompBattery.AutoSize = true;
            this.cbxCompBattery.Location = new System.Drawing.Point(18, 131);
            this.cbxCompBattery.Name = "cbxCompBattery";
            this.cbxCompBattery.Size = new System.Drawing.Size(96, 17);
            this.cbxCompBattery.TabIndex = 4;
            this.cbxCompBattery.Text = "Broken Battery";
            this.cbxCompBattery.UseVisualStyleBackColor = true;
            this.cbxCompBattery.CheckedChanged += new System.EventHandler(this.cbxBattery_CheckedChanged);
            // 
            // cbxCompScreen
            // 
            this.cbxCompScreen.AutoSize = true;
            this.cbxCompScreen.Location = new System.Drawing.Point(18, 108);
            this.cbxCompScreen.Name = "cbxCompScreen";
            this.cbxCompScreen.Size = new System.Drawing.Size(97, 17);
            this.cbxCompScreen.TabIndex = 3;
            this.cbxCompScreen.Text = "Broken Screen";
            this.cbxCompScreen.UseVisualStyleBackColor = true;
            this.cbxCompScreen.CheckedChanged += new System.EventHandler(this.cbxScreen_CheckedChanged);
            // 
            // cbxKeyboard
            // 
            this.cbxKeyboard.AutoSize = true;
            this.cbxKeyboard.Location = new System.Drawing.Point(18, 85);
            this.cbxKeyboard.Name = "cbxKeyboard";
            this.cbxKeyboard.Size = new System.Drawing.Size(108, 17);
            this.cbxKeyboard.TabIndex = 2;
            this.cbxKeyboard.Text = "Broken Keyboard";
            this.cbxKeyboard.UseVisualStyleBackColor = true;
            this.cbxKeyboard.CheckedChanged += new System.EventHandler(this.cbxKeyboard_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broken Parts:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCellViewInvoice);
            this.groupBox3.Controls.Add(this.txtCellTotal);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtCellVAT);
            this.groupBox3.Controls.Add(this.txtCellExcVAT);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.cbxCharge);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cbxCellMotherboard);
            this.groupBox3.Controls.Add(this.cbxCellVirus);
            this.groupBox3.Controls.Add(this.cbxCellBattery);
            this.groupBox3.Controls.Add(this.cbxCellScreen);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(270, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 343);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculate Amount Smartphone";
            // 
            // txtCellTotal
            // 
            this.txtCellTotal.Location = new System.Drawing.Point(133, 284);
            this.txtCellTotal.Name = "txtCellTotal";
            this.txtCellTotal.ReadOnly = true;
            this.txtCellTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCellTotal.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Overall Total:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 260);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "VAT Amount:";
            // 
            // txtCellVAT
            // 
            this.txtCellVAT.Location = new System.Drawing.Point(133, 257);
            this.txtCellVAT.Name = "txtCellVAT";
            this.txtCellVAT.ReadOnly = true;
            this.txtCellVAT.Size = new System.Drawing.Size(100, 20);
            this.txtCellVAT.TabIndex = 17;
            // 
            // txtCellExcVAT
            // 
            this.txtCellExcVAT.Location = new System.Drawing.Point(133, 230);
            this.txtCellExcVAT.Name = "txtCellExcVAT";
            this.txtCellExcVAT.ReadOnly = true;
            this.txtCellExcVAT.Size = new System.Drawing.Size(100, 20);
            this.txtCellExcVAT.TabIndex = 16;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 233);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Total Excluding VAT:";
            // 
            // cbxCharge
            // 
            this.cbxCharge.AutoSize = true;
            this.cbxCharge.Location = new System.Drawing.Point(14, 174);
            this.cbxCharge.Name = "cbxCharge";
            this.cbxCharge.Size = new System.Drawing.Size(139, 17);
            this.cbxCharge.TabIndex = 9;
            this.cbxCharge.Text = "Damaged Charging Port";
            this.cbxCharge.UseVisualStyleBackColor = true;
            this.cbxCharge.CheckedChanged += new System.EventHandler(this.cbxCharge_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(169, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(60, 181);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "R 900";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "R 600";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "R 200";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "R 1200";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "R 350";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "R 250";
            // 
            // cbxCellMotherboard
            // 
            this.cbxCellMotherboard.AutoSize = true;
            this.cbxCellMotherboard.Location = new System.Drawing.Point(14, 151);
            this.cbxCellMotherboard.Name = "cbxCellMotherboard";
            this.cbxCellMotherboard.Size = new System.Drawing.Size(120, 17);
            this.cbxCellMotherboard.TabIndex = 6;
            this.cbxCellMotherboard.Text = "Motherboard Failure";
            this.cbxCellMotherboard.UseVisualStyleBackColor = true;
            this.cbxCellMotherboard.CheckedChanged += new System.EventHandler(this.cbxCellMotherboard_CheckedChanged);
            // 
            // cbxCellVirus
            // 
            this.cbxCellVirus.AutoSize = true;
            this.cbxCellVirus.Location = new System.Drawing.Point(14, 128);
            this.cbxCellVirus.Name = "cbxCellVirus";
            this.cbxCellVirus.Size = new System.Drawing.Size(93, 17);
            this.cbxCellVirus.TabIndex = 5;
            this.cbxCellVirus.Text = "Virus Infection";
            this.cbxCellVirus.UseVisualStyleBackColor = true;
            this.cbxCellVirus.CheckedChanged += new System.EventHandler(this.cbxCellVirus_CheckedChanged);
            // 
            // cbxCellBattery
            // 
            this.cbxCellBattery.AutoSize = true;
            this.cbxCellBattery.Location = new System.Drawing.Point(14, 108);
            this.cbxCellBattery.Name = "cbxCellBattery";
            this.cbxCellBattery.Size = new System.Drawing.Size(96, 17);
            this.cbxCellBattery.TabIndex = 4;
            this.cbxCellBattery.Text = "Broken Battery";
            this.cbxCellBattery.UseVisualStyleBackColor = true;
            this.cbxCellBattery.CheckedChanged += new System.EventHandler(this.cbxCellBattery_CheckedChanged);
            // 
            // cbxCellScreen
            // 
            this.cbxCellScreen.AutoSize = true;
            this.cbxCellScreen.Location = new System.Drawing.Point(14, 85);
            this.cbxCellScreen.Name = "cbxCellScreen";
            this.cbxCellScreen.Size = new System.Drawing.Size(97, 17);
            this.cbxCellScreen.TabIndex = 3;
            this.cbxCellScreen.Text = "Broken Screen";
            this.cbxCellScreen.UseVisualStyleBackColor = true;
            this.cbxCellScreen.CheckedChanged += new System.EventHandler(this.cbxCellScreen_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Broken Parts:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Base Inspection Fee:";
            // 
            // listBoxInvoice
            // 
            this.listBoxInvoice.FormattingEnabled = true;
            this.listBoxInvoice.Location = new System.Drawing.Point(519, 19);
            this.listBoxInvoice.Name = "listBoxInvoice";
            this.listBoxInvoice.Size = new System.Drawing.Size(261, 290);
            this.listBoxInvoice.TabIndex = 3;
            // 
            // btnCompViewInvoice
            // 
            this.btnCompViewInvoice.Location = new System.Drawing.Point(134, 310);
            this.btnCompViewInvoice.Name = "btnCompViewInvoice";
            this.btnCompViewInvoice.Size = new System.Drawing.Size(103, 27);
            this.btnCompViewInvoice.TabIndex = 4;
            this.btnCompViewInvoice.Text = "View Invoice";
            this.btnCompViewInvoice.UseVisualStyleBackColor = true;
            this.btnCompViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(519, 322);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(261, 29);
            this.btnPrintInvoice.TabIndex = 5;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // btnCellViewInvoice
            // 
            this.btnCellViewInvoice.Location = new System.Drawing.Point(133, 310);
            this.btnCellViewInvoice.Name = "btnCellViewInvoice";
            this.btnCellViewInvoice.Size = new System.Drawing.Size(99, 26);
            this.btnCellViewInvoice.TabIndex = 21;
            this.btnCellViewInvoice.Text = "View Invoice";
            this.btnCellViewInvoice.UseVisualStyleBackColor = true;
            this.btnCellViewInvoice.Click += new System.EventHandler(this.btnCellViewInvoice_Click);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 367);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.listBoxInvoice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInvoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxDisk;
        private System.Windows.Forms.CheckBox cbxCompMotherboard;
        private System.Windows.Forms.CheckBox cbxCompVirus;
        private System.Windows.Forms.CheckBox cbxCompBattery;
        private System.Windows.Forms.CheckBox cbxCompScreen;
        private System.Windows.Forms.CheckBox cbxKeyboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbxCellMotherboard;
        private System.Windows.Forms.CheckBox cbxCellVirus;
        private System.Windows.Forms.CheckBox cbxCellBattery;
        private System.Windows.Forms.CheckBox cbxCellScreen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCompTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCompVAT;
        private System.Windows.Forms.TextBox txtCompExcVAT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCellTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCellVAT;
        private System.Windows.Forms.TextBox txtCellExcVAT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox cbxCharge;
        private System.Windows.Forms.ListBox listBoxInvoice;
        private System.Windows.Forms.Button btnCompViewInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnCellViewInvoice;
    }
}