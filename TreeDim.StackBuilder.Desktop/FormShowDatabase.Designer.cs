﻿namespace treeDiM.StackBuilder.Desktop
{
    partial class FormShowDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowDatabase));
            this.splitContainerForm = new System.Windows.Forms.SplitContainer();
            this.bnClose = new System.Windows.Forms.Button();
            this.bnImport = new System.Windows.Forms.Button();
            this.graphCtrl = new treeDiM.StackBuilder.Graphics.Graphics3DControl();
            this.tabCtrlDBItems = new System.Windows.Forms.TabControl();
            this.tabPagePallet = new System.Windows.Forms.TabPage();
            this.tabPagePalletCap = new System.Windows.Forms.TabPage();
            this.tabPageCase = new System.Windows.Forms.TabPage();
            this.tabPageBundle = new System.Windows.Forms.TabPage();
            this.tabPageCylinder = new System.Windows.Forms.TabPage();
            this.tabPageTruck = new System.Windows.Forms.TabPage();
            this.gridTrucks = new SourceGrid.Grid();
            this.gridPallets = new SourceGrid.Grid();
            this.tabPagePalletCorner = new System.Windows.Forms.TabPage();
            this.tabPagePalletFilm = new System.Windows.Forms.TabPage();
            this.tabPageInterlayer = new System.Windows.Forms.TabPage();
            this.gridInterlayers = new SourceGrid.Grid();
            this.gridCases = new SourceGrid.Grid();
            this.gridBundles = new SourceGrid.Grid();
            this.gridCylinders = new SourceGrid.Grid();
            this.gridPalletCorners = new SourceGrid.Grid();
            this.gridPalletCaps = new SourceGrid.Grid();
            this.gridPalletFilms = new SourceGrid.Grid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).BeginInit();
            this.splitContainerForm.Panel1.SuspendLayout();
            this.splitContainerForm.Panel2.SuspendLayout();
            this.splitContainerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).BeginInit();
            this.tabCtrlDBItems.SuspendLayout();
            this.tabPagePallet.SuspendLayout();
            this.tabPagePalletCap.SuspendLayout();
            this.tabPageCase.SuspendLayout();
            this.tabPageBundle.SuspendLayout();
            this.tabPageCylinder.SuspendLayout();
            this.tabPageTruck.SuspendLayout();
            this.tabPagePalletCorner.SuspendLayout();
            this.tabPagePalletFilm.SuspendLayout();
            this.tabPageInterlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerForm
            // 
            resources.ApplyResources(this.splitContainerForm, "splitContainerForm");
            this.splitContainerForm.Name = "splitContainerForm";
            // 
            // splitContainerForm.Panel1
            // 
            this.splitContainerForm.Panel1.Controls.Add(this.bnClose);
            this.splitContainerForm.Panel1.Controls.Add(this.bnImport);
            this.splitContainerForm.Panel1.Controls.Add(this.graphCtrl);
            // 
            // splitContainerForm.Panel2
            // 
            this.splitContainerForm.Panel2.Controls.Add(this.tabCtrlDBItems);
            // 
            // bnClose
            // 
            resources.ApplyResources(this.bnClose, "bnClose");
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Name = "bnClose";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // bnImport
            // 
            resources.ApplyResources(this.bnImport, "bnImport");
            this.bnImport.Name = "bnImport";
            this.bnImport.UseVisualStyleBackColor = true;
            this.bnImport.Click += new System.EventHandler(this.onImport);
            // 
            // graphCtrl
            // 
            resources.ApplyResources(this.graphCtrl, "graphCtrl");
            this.graphCtrl.Name = "graphCtrl";
            this.graphCtrl.Viewer = null;
            // 
            // tabCtrlDBItems
            // 
            this.tabCtrlDBItems.Controls.Add(this.tabPagePallet);
            this.tabCtrlDBItems.Controls.Add(this.tabPageInterlayer);
            this.tabCtrlDBItems.Controls.Add(this.tabPageCase);
            this.tabCtrlDBItems.Controls.Add(this.tabPageBundle);
            this.tabCtrlDBItems.Controls.Add(this.tabPageCylinder);
            this.tabCtrlDBItems.Controls.Add(this.tabPageTruck);
            this.tabCtrlDBItems.Controls.Add(this.tabPagePalletCorner);
            this.tabCtrlDBItems.Controls.Add(this.tabPagePalletCap);
            this.tabCtrlDBItems.Controls.Add(this.tabPagePalletFilm);
            resources.ApplyResources(this.tabCtrlDBItems, "tabCtrlDBItems");
            this.tabCtrlDBItems.Name = "tabCtrlDBItems";
            this.tabCtrlDBItems.SelectedIndex = 0;
            this.tabCtrlDBItems.SelectedIndexChanged += new System.EventHandler(this.onSelectedTabChanged);
            // 
            // tabPagePallet
            // 
            this.tabPagePallet.Controls.Add(this.gridPallets);
            resources.ApplyResources(this.tabPagePallet, "tabPagePallet");
            this.tabPagePallet.Name = "tabPagePallet";
            this.tabPagePallet.UseVisualStyleBackColor = true;
            // 
            // tabPagePalletCap
            // 
            this.tabPagePalletCap.Controls.Add(this.gridPalletCaps);
            resources.ApplyResources(this.tabPagePalletCap, "tabPagePalletCap");
            this.tabPagePalletCap.Name = "tabPagePalletCap";
            this.tabPagePalletCap.UseVisualStyleBackColor = true;
            // 
            // tabPageCase
            // 
            this.tabPageCase.Controls.Add(this.gridCases);
            resources.ApplyResources(this.tabPageCase, "tabPageCase");
            this.tabPageCase.Name = "tabPageCase";
            this.tabPageCase.UseVisualStyleBackColor = true;
            // 
            // tabPageBundle
            // 
            this.tabPageBundle.Controls.Add(this.gridBundles);
            resources.ApplyResources(this.tabPageBundle, "tabPageBundle");
            this.tabPageBundle.Name = "tabPageBundle";
            this.tabPageBundle.UseVisualStyleBackColor = true;
            // 
            // tabPageCylinder
            // 
            this.tabPageCylinder.Controls.Add(this.gridCylinders);
            resources.ApplyResources(this.tabPageCylinder, "tabPageCylinder");
            this.tabPageCylinder.Name = "tabPageCylinder";
            this.tabPageCylinder.UseVisualStyleBackColor = true;
            // 
            // tabPageTruck
            // 
            this.tabPageTruck.Controls.Add(this.gridTrucks);
            resources.ApplyResources(this.tabPageTruck, "tabPageTruck");
            this.tabPageTruck.Name = "tabPageTruck";
            this.tabPageTruck.UseVisualStyleBackColor = true;
            // 
            // gridTrucks
            // 
            this.gridTrucks.AcceptsInputChar = false;
            resources.ApplyResources(this.gridTrucks, "gridTrucks");
            this.gridTrucks.EnableSort = false;
            this.gridTrucks.Name = "gridTrucks";
            this.gridTrucks.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridTrucks.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridTrucks.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridTrucks.TabStop = true;
            this.gridTrucks.ToolTipText = "";
            // 
            // gridPallets
            // 
            this.gridPallets.AcceptsInputChar = false;
            resources.ApplyResources(this.gridPallets, "gridPallets");
            this.gridPallets.EnableSort = false;
            this.gridPallets.Name = "gridPallets";
            this.gridPallets.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridPallets.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridPallets.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridPallets.TabStop = true;
            this.gridPallets.ToolTipText = "";
            // 
            // tabPagePalletCorner
            // 
            this.tabPagePalletCorner.Controls.Add(this.gridPalletCorners);
            resources.ApplyResources(this.tabPagePalletCorner, "tabPagePalletCorner");
            this.tabPagePalletCorner.Name = "tabPagePalletCorner";
            this.tabPagePalletCorner.UseVisualStyleBackColor = true;
            // 
            // tabPagePalletFilm
            // 
            this.tabPagePalletFilm.Controls.Add(this.gridPalletFilms);
            resources.ApplyResources(this.tabPagePalletFilm, "tabPagePalletFilm");
            this.tabPagePalletFilm.Name = "tabPagePalletFilm";
            this.tabPagePalletFilm.UseVisualStyleBackColor = true;
            // 
            // tabPageInterlayer
            // 
            this.tabPageInterlayer.Controls.Add(this.gridInterlayers);
            resources.ApplyResources(this.tabPageInterlayer, "tabPageInterlayer");
            this.tabPageInterlayer.Name = "tabPageInterlayer";
            this.tabPageInterlayer.UseVisualStyleBackColor = true;
            // 
            // gridInterlayers
            // 
            this.gridInterlayers.AcceptsInputChar = false;
            resources.ApplyResources(this.gridInterlayers, "gridInterlayers");
            this.gridInterlayers.EnableSort = false;
            this.gridInterlayers.Name = "gridInterlayers";
            this.gridInterlayers.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridInterlayers.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridInterlayers.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridInterlayers.TabStop = true;
            this.gridInterlayers.ToolTipText = "";
            // 
            // gridCases
            // 
            this.gridCases.AcceptsInputChar = false;
            resources.ApplyResources(this.gridCases, "gridCases");
            this.gridCases.EnableSort = false;
            this.gridCases.Name = "gridCases";
            this.gridCases.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridCases.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridCases.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridCases.TabStop = true;
            this.gridCases.ToolTipText = "";
            // 
            // gridBundles
            // 
            this.gridBundles.AcceptsInputChar = false;
            resources.ApplyResources(this.gridBundles, "gridBundles");
            this.gridBundles.EnableSort = false;
            this.gridBundles.Name = "gridBundles";
            this.gridBundles.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridBundles.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridBundles.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridBundles.TabStop = true;
            this.gridBundles.ToolTipText = "";
            // 
            // gridCylinders
            // 
            this.gridCylinders.AcceptsInputChar = false;
            resources.ApplyResources(this.gridCylinders, "gridCylinders");
            this.gridCylinders.EnableSort = false;
            this.gridCylinders.Name = "gridCylinders";
            this.gridCylinders.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridCylinders.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridCylinders.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridCylinders.TabStop = true;
            this.gridCylinders.ToolTipText = "";
            // 
            // gridPalletCorners
            // 
            this.gridPalletCorners.AcceptsInputChar = false;
            resources.ApplyResources(this.gridPalletCorners, "gridPalletCorners");
            this.gridPalletCorners.EnableSort = false;
            this.gridPalletCorners.Name = "gridPalletCorners";
            this.gridPalletCorners.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridPalletCorners.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridPalletCorners.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridPalletCorners.TabStop = true;
            this.gridPalletCorners.ToolTipText = "";
            // 
            // gridPalletCaps
            // 
            this.gridPalletCaps.AcceptsInputChar = false;
            resources.ApplyResources(this.gridPalletCaps, "gridPalletCaps");
            this.gridPalletCaps.EnableSort = false;
            this.gridPalletCaps.Name = "gridPalletCaps";
            this.gridPalletCaps.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridPalletCaps.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridPalletCaps.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridPalletCaps.TabStop = true;
            this.gridPalletCaps.ToolTipText = "";
            // 
            // gridPalletFilms
            // 
            this.gridPalletFilms.AcceptsInputChar = false;
            resources.ApplyResources(this.gridPalletFilms, "gridPalletFilms");
            this.gridPalletFilms.EnableSort = false;
            this.gridPalletFilms.Name = "gridPalletFilms";
            this.gridPalletFilms.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridPalletFilms.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridPalletFilms.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridPalletFilms.TabStop = true;
            this.gridPalletFilms.ToolTipText = "";
            // 
            // FormShowDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.Controls.Add(this.splitContainerForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShowDatabase";
            this.ShowInTaskbar = false;
            this.splitContainerForm.Panel1.ResumeLayout(false);
            this.splitContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).EndInit();
            this.splitContainerForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).EndInit();
            this.tabCtrlDBItems.ResumeLayout(false);
            this.tabPagePallet.ResumeLayout(false);
            this.tabPagePalletCap.ResumeLayout(false);
            this.tabPageCase.ResumeLayout(false);
            this.tabPageBundle.ResumeLayout(false);
            this.tabPageCylinder.ResumeLayout(false);
            this.tabPageTruck.ResumeLayout(false);
            this.tabPagePalletCorner.ResumeLayout(false);
            this.tabPagePalletFilm.ResumeLayout(false);
            this.tabPageInterlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlDBItems;
        private System.Windows.Forms.TabPage tabPagePallet;
        private System.Windows.Forms.TabPage tabPagePalletCap;
        private System.Windows.Forms.TabPage tabPageCase;
        private System.Windows.Forms.TabPage tabPageBundle;
        private System.Windows.Forms.TabPage tabPageCylinder;
        private System.Windows.Forms.TabPage tabPageTruck;
        private SourceGrid.Grid gridTrucks;
        private Graphics.Graphics3DControl graphCtrl;
        private System.Windows.Forms.SplitContainer splitContainerForm;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button bnImport;
        private SourceGrid.Grid gridPallets;
        private System.Windows.Forms.TabPage tabPageInterlayer;
        private System.Windows.Forms.TabPage tabPagePalletCorner;
        private System.Windows.Forms.TabPage tabPagePalletFilm;
        private SourceGrid.Grid gridInterlayers;
        private SourceGrid.Grid gridCases;
        private SourceGrid.Grid gridBundles;
        private SourceGrid.Grid gridCylinders;
        private SourceGrid.Grid gridPalletCorners;
        private SourceGrid.Grid gridPalletCaps;
        private SourceGrid.Grid gridPalletFilms;
    }
}