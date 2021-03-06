﻿namespace treeDiM.StackBuilder.ABYATExcelLoader
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMITools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMISettings = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.fileSelectExcel = new treeDiM.UserControls.FileSelect();
            this.graphCtrlPallet = new treeDiM.StackBuilder.Graphics.Graphics3DControl();
            this.uCtrlPalletDimensions = new treeDiM.StackBuilder.Basics.UCtrlTriDouble();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lbCaseLoaded = new System.Windows.Forms.Label();
            this.cbPalletType = new System.Windows.Forms.ComboBox();
            this.lbPalletType = new System.Windows.Forms.Label();
            this.uCtrlTruckDimensions = new treeDiM.StackBuilder.Basics.UCtrlTriDouble();
            this.uCtrlPalletWeight = new treeDiM.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlMaximumPalletHeight = new treeDiM.StackBuilder.Basics.UCtrlDouble();
            this.rbContainer = new System.Windows.Forms.RadioButton();
            this.rbPallet = new System.Windows.Forms.RadioButton();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.chkbOpenFile = new System.Windows.Forms.CheckBox();
            this.bnGenerate = new System.Windows.Forms.Button();
            this.fileSelectOutput = new treeDiM.UserControls.FileSelect();
            this.lbOutputFilePath = new System.Windows.Forms.Label();
            this.gbLimits = new System.Windows.Forms.GroupBox();
            this.uCtrlLargestDimMin = new treeDiM.StackBuilder.Basics.UCtrlDouble();
            this.nudStackCountMax = new System.Windows.Forms.NumericUpDown();
            this.lbDrawing = new System.Windows.Forms.Label();
            this.chkbGenerateImage = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlPallet)).BeginInit();
            this.gbInput.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackCountMax)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMIFile,
            this.toolStripMITools});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMIFile
            // 
            this.toolStripMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMIFile.Name = "toolStripMIFile";
            this.toolStripMIFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMIFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.onExit);
            // 
            // toolStripMITools
            // 
            this.toolStripMITools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMISettings});
            this.toolStripMITools.Name = "toolStripMITools";
            this.toolStripMITools.Size = new System.Drawing.Size(47, 20);
            this.toolStripMITools.Text = "Tools";
            // 
            // toolStripMISettings
            // 
            this.toolStripMISettings.Name = "toolStripMISettings";
            this.toolStripMISettings.Size = new System.Drawing.Size(116, 22);
            this.toolStripMISettings.Text = "Settings";
            this.toolStripMISettings.Click += new System.EventHandler(this.onSettings);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 639);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(13, 19);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(73, 13);
            this.lbFilePath.TabIndex = 2;
            this.lbFilePath.Text = "Excel file path";
            // 
            // fileSelectExcel
            // 
            this.fileSelectExcel.Location = new System.Drawing.Point(102, 19);
            this.fileSelectExcel.Name = "fileSelectExcel";
            this.fileSelectExcel.Size = new System.Drawing.Size(557, 20);
            this.fileSelectExcel.TabIndex = 3;
            this.fileSelectExcel.FileNameChanged += new System.EventHandler(this.onInputFilePathChanged);
            // 
            // graphCtrlPallet
            // 
            this.graphCtrlPallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphCtrlPallet.Location = new System.Drawing.Point(213, 209);
            this.graphCtrlPallet.Name = "graphCtrlPallet";
            this.graphCtrlPallet.Size = new System.Drawing.Size(267, 224);
            this.graphCtrlPallet.TabIndex = 4;
            this.graphCtrlPallet.Viewer = null;
            // 
            // uCtrlPalletDimensions
            // 
            this.uCtrlPalletDimensions.Location = new System.Drawing.Point(102, 57);
            this.uCtrlPalletDimensions.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uCtrlPalletDimensions.Name = "uCtrlPalletDimensions";
            this.uCtrlPalletDimensions.Size = new System.Drawing.Size(378, 20);
            this.uCtrlPalletDimensions.TabIndex = 6;
            this.uCtrlPalletDimensions.Text = "Dimensions";
            this.uCtrlPalletDimensions.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlPalletDimensions.ValueX = 0D;
            this.uCtrlPalletDimensions.ValueY = 0D;
            this.uCtrlPalletDimensions.ValueZ = 0D;
            this.uCtrlPalletDimensions.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlTriDouble.onValueChanged(this.onDataChanged);
            // 
            // gbInput
            // 
            this.gbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInput.Controls.Add(this.lbCaseLoaded);
            this.gbInput.Controls.Add(this.cbPalletType);
            this.gbInput.Controls.Add(this.lbPalletType);
            this.gbInput.Controls.Add(this.uCtrlTruckDimensions);
            this.gbInput.Controls.Add(this.uCtrlPalletWeight);
            this.gbInput.Controls.Add(this.uCtrlMaximumPalletHeight);
            this.gbInput.Controls.Add(this.rbContainer);
            this.gbInput.Controls.Add(this.rbPallet);
            this.gbInput.Controls.Add(this.fileSelectExcel);
            this.gbInput.Controls.Add(this.lbFilePath);
            this.gbInput.Controls.Add(this.uCtrlPalletDimensions);
            this.gbInput.Controls.Add(this.graphCtrlPallet);
            this.gbInput.Location = new System.Drawing.Point(6, 27);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(671, 449);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // lbCaseLoaded
            // 
            this.lbCaseLoaded.AutoSize = true;
            this.lbCaseLoaded.Location = new System.Drawing.Point(105, 41);
            this.lbCaseLoaded.Name = "lbCaseLoaded";
            this.lbCaseLoaded.Size = new System.Drawing.Size(91, 13);
            this.lbCaseLoaded.TabIndex = 14;
            this.lbCaseLoaded.Text = "(No case loaded!)";
            // 
            // cbPalletType
            // 
            this.cbPalletType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalletType.FormattingEnabled = true;
            this.cbPalletType.Location = new System.Drawing.Point(258, 140);
            this.cbPalletType.Name = "cbPalletType";
            this.cbPalletType.Size = new System.Drawing.Size(186, 21);
            this.cbPalletType.TabIndex = 13;
            this.cbPalletType.SelectedIndexChanged += new System.EventHandler(this.onDataChanged);
            // 
            // lbPalletType
            // 
            this.lbPalletType.AutoSize = true;
            this.lbPalletType.Location = new System.Drawing.Point(102, 140);
            this.lbPalletType.Name = "lbPalletType";
            this.lbPalletType.Size = new System.Drawing.Size(56, 13);
            this.lbPalletType.TabIndex = 12;
            this.lbPalletType.Text = "Pallet type";
            // 
            // uCtrlTruckDimensions
            // 
            this.uCtrlTruckDimensions.Location = new System.Drawing.Point(102, 183);
            this.uCtrlTruckDimensions.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uCtrlTruckDimensions.Name = "uCtrlTruckDimensions";
            this.uCtrlTruckDimensions.Size = new System.Drawing.Size(378, 20);
            this.uCtrlTruckDimensions.TabIndex = 11;
            this.uCtrlTruckDimensions.Text = "Dimensions";
            this.uCtrlTruckDimensions.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlTruckDimensions.ValueX = 0D;
            this.uCtrlTruckDimensions.ValueY = 0D;
            this.uCtrlTruckDimensions.ValueZ = 0D;
            this.uCtrlTruckDimensions.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlTriDouble.onValueChanged(this.onDataChanged);
            // 
            // uCtrlPalletWeight
            // 
            this.uCtrlPalletWeight.Location = new System.Drawing.Point(102, 84);
            this.uCtrlPalletWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlPalletWeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlPalletWeight.Name = "uCtrlPalletWeight";
            this.uCtrlPalletWeight.Size = new System.Drawing.Size(254, 20);
            this.uCtrlPalletWeight.TabIndex = 10;
            this.uCtrlPalletWeight.Text = "Pallet weight";
            this.uCtrlPalletWeight.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlPalletWeight.Value = 0D;
            // 
            // uCtrlMaximumPalletHeight
            // 
            this.uCtrlMaximumPalletHeight.Location = new System.Drawing.Point(102, 112);
            this.uCtrlMaximumPalletHeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlMaximumPalletHeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlMaximumPalletHeight.Name = "uCtrlMaximumPalletHeight";
            this.uCtrlMaximumPalletHeight.Size = new System.Drawing.Size(254, 20);
            this.uCtrlMaximumPalletHeight.TabIndex = 9;
            this.uCtrlMaximumPalletHeight.Text = "Maximum loaded pallet height";
            this.uCtrlMaximumPalletHeight.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlMaximumPalletHeight.Value = 0D;
            // 
            // rbContainer
            // 
            this.rbContainer.AutoSize = true;
            this.rbContainer.Location = new System.Drawing.Point(7, 183);
            this.rbContainer.Name = "rbContainer";
            this.rbContainer.Size = new System.Drawing.Size(70, 17);
            this.rbContainer.TabIndex = 8;
            this.rbContainer.TabStop = true;
            this.rbContainer.Text = "Container";
            this.rbContainer.UseVisualStyleBackColor = true;
            this.rbContainer.CheckedChanged += new System.EventHandler(this.onModeChanged);
            // 
            // rbPallet
            // 
            this.rbPallet.AutoSize = true;
            this.rbPallet.Location = new System.Drawing.Point(7, 57);
            this.rbPallet.Name = "rbPallet";
            this.rbPallet.Size = new System.Drawing.Size(51, 17);
            this.rbPallet.TabIndex = 7;
            this.rbPallet.TabStop = true;
            this.rbPallet.Text = "Pallet";
            this.rbPallet.UseVisualStyleBackColor = true;
            this.rbPallet.CheckedChanged += new System.EventHandler(this.onModeChanged);
            // 
            // gbOutput
            // 
            this.gbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOutput.Controls.Add(this.chkbOpenFile);
            this.gbOutput.Controls.Add(this.bnGenerate);
            this.gbOutput.Controls.Add(this.fileSelectOutput);
            this.gbOutput.Controls.Add(this.lbOutputFilePath);
            this.gbOutput.Location = new System.Drawing.Point(6, 566);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(671, 67);
            this.gbOutput.TabIndex = 8;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // chkbOpenFile
            // 
            this.chkbOpenFile.AutoSize = true;
            this.chkbOpenFile.Location = new System.Drawing.Point(10, 43);
            this.chkbOpenFile.Name = "chkbOpenFile";
            this.chkbOpenFile.Size = new System.Drawing.Size(119, 17);
            this.chkbOpenFile.TabIndex = 3;
            this.chkbOpenFile.Text = "Open generated file";
            this.chkbOpenFile.UseVisualStyleBackColor = true;
            // 
            // bnGenerate
            // 
            this.bnGenerate.Location = new System.Drawing.Point(566, 38);
            this.bnGenerate.Name = "bnGenerate";
            this.bnGenerate.Size = new System.Drawing.Size(92, 23);
            this.bnGenerate.TabIndex = 2;
            this.bnGenerate.Text = "Generate";
            this.bnGenerate.UseVisualStyleBackColor = true;
            this.bnGenerate.Click += new System.EventHandler(this.onGenerate);
            // 
            // fileSelectOutput
            // 
            this.fileSelectOutput.Location = new System.Drawing.Point(102, 15);
            this.fileSelectOutput.Name = "fileSelectOutput";
            this.fileSelectOutput.Size = new System.Drawing.Size(557, 20);
            this.fileSelectOutput.TabIndex = 1;
            // 
            // lbOutputFilePath
            // 
            this.lbOutputFilePath.AutoSize = true;
            this.lbOutputFilePath.Location = new System.Drawing.Point(7, 15);
            this.lbOutputFilePath.Name = "lbOutputFilePath";
            this.lbOutputFilePath.Size = new System.Drawing.Size(79, 13);
            this.lbOutputFilePath.TabIndex = 0;
            this.lbOutputFilePath.Text = "Output file path";
            // 
            // gbLimits
            // 
            this.gbLimits.Controls.Add(this.chkbGenerateImage);
            this.gbLimits.Controls.Add(this.uCtrlLargestDimMin);
            this.gbLimits.Controls.Add(this.nudStackCountMax);
            this.gbLimits.Controls.Add(this.lbDrawing);
            this.gbLimits.Location = new System.Drawing.Point(6, 482);
            this.gbLimits.Name = "gbLimits";
            this.gbLimits.Size = new System.Drawing.Size(671, 78);
            this.gbLimits.TabIndex = 9;
            this.gbLimits.TabStop = false;
            this.gbLimits.Text = "Limitations";
            // 
            // uCtrlLargestDimMin
            // 
            this.uCtrlLargestDimMin.Location = new System.Drawing.Point(16, 47);
            this.uCtrlLargestDimMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uCtrlLargestDimMin.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlLargestDimMin.Name = "uCtrlLargestDimMin";
            this.uCtrlLargestDimMin.Size = new System.Drawing.Size(340, 20);
            this.uCtrlLargestDimMin.TabIndex = 2;
            this.uCtrlLargestDimMin.Text = "Skip computation if largest dimension below ";
            this.uCtrlLargestDimMin.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlLargestDimMin.Value = 10D;
            // 
            // nudStackCountMax
            // 
            this.nudStackCountMax.Location = new System.Drawing.Point(258, 20);
            this.nudStackCountMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStackCountMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStackCountMax.Name = "nudStackCountMax";
            this.nudStackCountMax.Size = new System.Drawing.Size(98, 20);
            this.nudStackCountMax.TabIndex = 1;
            this.nudStackCountMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDrawing
            // 
            this.lbDrawing.AutoSize = true;
            this.lbDrawing.Location = new System.Drawing.Point(16, 20);
            this.lbDrawing.Name = "lbDrawing";
            this.lbDrawing.Size = new System.Drawing.Size(203, 13);
            this.lbDrawing.TabIndex = 0;
            this.lbDrawing.Text = "Skip drawing if number of cases exceeds:";
            // 
            // chkbGenerateImage
            // 
            this.chkbGenerateImage.AutoSize = true;
            this.chkbGenerateImage.Location = new System.Drawing.Point(390, 21);
            this.chkbGenerateImage.Name = "chkbGenerateImage";
            this.chkbGenerateImage.Size = new System.Drawing.Size(101, 17);
            this.chkbGenerateImage.TabIndex = 3;
            this.chkbGenerateImage.Text = "Generate image";
            this.chkbGenerateImage.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.gbLimits);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "FormMain";
            this.Text = "ABYAT fast stacking estimation";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlPallet)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbLimits.ResumeLayout(false);
            this.gbLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackCountMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMITools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMISettings;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMIFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private UserControls.FileSelect fileSelectExcel;
        private Graphics.Graphics3DControl graphCtrlPallet;
        private Basics.UCtrlTriDouble uCtrlPalletDimensions;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.ComboBox cbPalletType;
        private System.Windows.Forms.Label lbPalletType;
        private Basics.UCtrlTriDouble uCtrlTruckDimensions;
        private Basics.UCtrlDouble uCtrlPalletWeight;
        private Basics.UCtrlDouble uCtrlMaximumPalletHeight;
        private System.Windows.Forms.RadioButton rbContainer;
        private System.Windows.Forms.RadioButton rbPallet;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.CheckBox chkbOpenFile;
        private System.Windows.Forms.Button bnGenerate;
        private UserControls.FileSelect fileSelectOutput;
        private System.Windows.Forms.Label lbOutputFilePath;
        private System.Windows.Forms.Label lbCaseLoaded;
        private System.Windows.Forms.GroupBox gbLimits;
        private System.Windows.Forms.NumericUpDown nudStackCountMax;
        private System.Windows.Forms.Label lbDrawing;
        private Basics.UCtrlDouble uCtrlLargestDimMin;
        private System.Windows.Forms.CheckBox chkbGenerateImage;
    }
}

