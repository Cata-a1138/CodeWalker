﻿using CodeWalker.WinForms;

namespace CodeWalker.World
{
    partial class WorldInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldInfoForm));
            this.SelectionTabControl = new System.Windows.Forms.TabControl();
            this.SelectionEntityTabPage = new System.Windows.Forms.TabPage();
            this.SelEntityPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.SelectionArchetypeTabPage = new System.Windows.Forms.TabPage();
            this.SelArchetypePropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.SelectionDrawableTabPage = new System.Windows.Forms.TabPage();
            this.SelDrawablePropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.SelectionExtensionTabPage = new System.Windows.Forms.TabPage();
            this.SelExtensionPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.SelectionModelsTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SelDrawableModelsTreeView = new CodeWalker.WinForms.TreeViewFix();
            this.SelDrawableModelPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.SelectionTexturesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SaveAllTexturesButton = new System.Windows.Forms.Button();
            this.SaveTextureButton = new System.Windows.Forms.Button();
            this.SelDrawableTexturesTreeView = new CodeWalker.WinForms.TreeViewFix();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SelTextureDimensionsLabel = new System.Windows.Forms.Label();
            this.SelTextureMipTrackBar = new System.Windows.Forms.TrackBar();
            this.SelTextureMipLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelTextureDictionaryTextBox = new System.Windows.Forms.TextBox();
            this.SelTextureNameTextBox = new System.Windows.Forms.TextBox();
            this.SelDrawableTexturePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SelDrawableTexturePropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.SelectionHierarchyTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.HierarchyTreeView = new System.Windows.Forms.TreeView();
            this.HierarchyPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.MouseSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectionNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SelectionModeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectionTabControl.SuspendLayout();
            this.SelectionEntityTabPage.SuspendLayout();
            this.SelectionArchetypeTabPage.SuspendLayout();
            this.SelectionDrawableTabPage.SuspendLayout();
            this.SelectionExtensionTabPage.SuspendLayout();
            this.SelectionModelsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SelectionTexturesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelTextureMipTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelDrawableTexturePictureBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SelectionHierarchyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectionTabControl
            // 
            this.SelectionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionTabControl.Controls.Add(this.SelectionEntityTabPage);
            this.SelectionTabControl.Controls.Add(this.SelectionArchetypeTabPage);
            this.SelectionTabControl.Controls.Add(this.SelectionDrawableTabPage);
            this.SelectionTabControl.Controls.Add(this.SelectionExtensionTabPage);
            this.SelectionTabControl.Controls.Add(this.SelectionModelsTabPage);
            this.SelectionTabControl.Controls.Add(this.SelectionTexturesTabPage);
            this.SelectionTabControl.Controls.Add(this.SelectionHierarchyTabPage);
            this.SelectionTabControl.Location = new System.Drawing.Point(13, 49);
            this.SelectionTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionTabControl.Name = "SelectionTabControl";
            this.SelectionTabControl.SelectedIndex = 0;
            this.SelectionTabControl.Size = new System.Drawing.Size(889, 483);
            this.SelectionTabControl.TabIndex = 28;
            // 
            // SelectionEntityTabPage
            // 
            this.SelectionEntityTabPage.Controls.Add(this.SelEntityPropertyGrid);
            this.SelectionEntityTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionEntityTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionEntityTabPage.Name = "SelectionEntityTabPage";
            this.SelectionEntityTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionEntityTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionEntityTabPage.TabIndex = 0;
            this.SelectionEntityTabPage.Text = "实体";
            this.SelectionEntityTabPage.UseVisualStyleBackColor = true;
            // 
            // SelEntityPropertyGrid
            // 
            this.SelEntityPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelEntityPropertyGrid.HelpVisible = false;
            this.SelEntityPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.SelEntityPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelEntityPropertyGrid.Name = "SelEntityPropertyGrid";
            this.SelEntityPropertyGrid.Size = new System.Drawing.Size(879, 445);
            this.SelEntityPropertyGrid.TabIndex = 25;
            this.SelEntityPropertyGrid.ToolbarVisible = false;
            // 
            // SelectionArchetypeTabPage
            // 
            this.SelectionArchetypeTabPage.Controls.Add(this.SelArchetypePropertyGrid);
            this.SelectionArchetypeTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionArchetypeTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionArchetypeTabPage.Name = "SelectionArchetypeTabPage";
            this.SelectionArchetypeTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionArchetypeTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionArchetypeTabPage.TabIndex = 1;
            this.SelectionArchetypeTabPage.Text = "定义";
            this.SelectionArchetypeTabPage.UseVisualStyleBackColor = true;
            // 
            // SelArchetypePropertyGrid
            // 
            this.SelArchetypePropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelArchetypePropertyGrid.HelpVisible = false;
            this.SelArchetypePropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.SelArchetypePropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelArchetypePropertyGrid.Name = "SelArchetypePropertyGrid";
            this.SelArchetypePropertyGrid.Size = new System.Drawing.Size(879, 445);
            this.SelArchetypePropertyGrid.TabIndex = 26;
            this.SelArchetypePropertyGrid.ToolbarVisible = false;
            // 
            // SelectionDrawableTabPage
            // 
            this.SelectionDrawableTabPage.Controls.Add(this.SelDrawablePropertyGrid);
            this.SelectionDrawableTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionDrawableTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionDrawableTabPage.Name = "SelectionDrawableTabPage";
            this.SelectionDrawableTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionDrawableTabPage.TabIndex = 2;
            this.SelectionDrawableTabPage.Text = "可绘制";
            this.SelectionDrawableTabPage.UseVisualStyleBackColor = true;
            // 
            // SelDrawablePropertyGrid
            // 
            this.SelDrawablePropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelDrawablePropertyGrid.HelpVisible = false;
            this.SelDrawablePropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.SelDrawablePropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelDrawablePropertyGrid.Name = "SelDrawablePropertyGrid";
            this.SelDrawablePropertyGrid.Size = new System.Drawing.Size(879, 445);
            this.SelDrawablePropertyGrid.TabIndex = 28;
            this.SelDrawablePropertyGrid.ToolbarVisible = false;
            // 
            // SelectionExtensionTabPage
            // 
            this.SelectionExtensionTabPage.Controls.Add(this.SelExtensionPropertyGrid);
            this.SelectionExtensionTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionExtensionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionExtensionTabPage.Name = "SelectionExtensionTabPage";
            this.SelectionExtensionTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionExtensionTabPage.TabIndex = 5;
            this.SelectionExtensionTabPage.Text = "扩展";
            this.SelectionExtensionTabPage.UseVisualStyleBackColor = true;
            // 
            // SelExtensionPropertyGrid
            // 
            this.SelExtensionPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelExtensionPropertyGrid.HelpVisible = false;
            this.SelExtensionPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.SelExtensionPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelExtensionPropertyGrid.Name = "SelExtensionPropertyGrid";
            this.SelExtensionPropertyGrid.Size = new System.Drawing.Size(879, 445);
            this.SelExtensionPropertyGrid.TabIndex = 29;
            this.SelExtensionPropertyGrid.ToolbarVisible = false;
            // 
            // SelectionModelsTabPage
            // 
            this.SelectionModelsTabPage.Controls.Add(this.splitContainer1);
            this.SelectionModelsTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionModelsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionModelsTabPage.Name = "SelectionModelsTabPage";
            this.SelectionModelsTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionModelsTabPage.TabIndex = 3;
            this.SelectionModelsTabPage.Text = "模型";
            this.SelectionModelsTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SelDrawableModelsTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SelDrawableModelPropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(879, 445);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // SelDrawableModelsTreeView
            // 
            this.SelDrawableModelsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelDrawableModelsTreeView.CheckBoxes = true;
            this.SelDrawableModelsTreeView.Location = new System.Drawing.Point(0, 0);
            this.SelDrawableModelsTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelDrawableModelsTreeView.Name = "SelDrawableModelsTreeView";
            this.SelDrawableModelsTreeView.Size = new System.Drawing.Size(361, 443);
            this.SelDrawableModelsTreeView.TabIndex = 0;
            this.SelDrawableModelsTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.SelDrawableModelsTreeView_AfterCheck);
            this.SelDrawableModelsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelDrawableModelsTreeView_AfterSelect);
            // 
            // SelDrawableModelPropertyGrid
            // 
            this.SelDrawableModelPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelDrawableModelPropertyGrid.HelpVisible = false;
            this.SelDrawableModelPropertyGrid.Location = new System.Drawing.Point(4, 0);
            this.SelDrawableModelPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelDrawableModelPropertyGrid.Name = "SelDrawableModelPropertyGrid";
            this.SelDrawableModelPropertyGrid.Size = new System.Drawing.Size(501, 445);
            this.SelDrawableModelPropertyGrid.TabIndex = 27;
            this.SelDrawableModelPropertyGrid.ToolbarVisible = false;
            // 
            // SelectionTexturesTabPage
            // 
            this.SelectionTexturesTabPage.Controls.Add(this.splitContainer2);
            this.SelectionTexturesTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionTexturesTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionTexturesTabPage.Name = "SelectionTexturesTabPage";
            this.SelectionTexturesTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionTexturesTabPage.TabIndex = 4;
            this.SelectionTexturesTabPage.Text = "纹理";
            this.SelectionTexturesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SaveAllTexturesButton);
            this.splitContainer2.Panel1.Controls.Add(this.SaveTextureButton);
            this.splitContainer2.Panel1.Controls.Add(this.SelDrawableTexturesTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(879, 445);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // SaveAllTexturesButton
            // 
            this.SaveAllTexturesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveAllTexturesButton.Location = new System.Drawing.Point(4, 411);
            this.SaveAllTexturesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveAllTexturesButton.Name = "SaveAllTexturesButton";
            this.SaveAllTexturesButton.Size = new System.Drawing.Size(151, 30);
            this.SaveAllTexturesButton.TabIndex = 3;
            this.SaveAllTexturesButton.Text = "保存全部...";
            this.SaveAllTexturesButton.UseVisualStyleBackColor = true;
            this.SaveAllTexturesButton.Click += new System.EventHandler(this.SaveAllTexturesButton_Click);
            // 
            // SaveTextureButton
            // 
            this.SaveTextureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveTextureButton.Enabled = false;
            this.SaveTextureButton.Location = new System.Drawing.Point(166, 411);
            this.SaveTextureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveTextureButton.Name = "SaveTextureButton";
            this.SaveTextureButton.Size = new System.Drawing.Size(151, 30);
            this.SaveTextureButton.TabIndex = 4;
            this.SaveTextureButton.Text = "保存所选...";
            this.SaveTextureButton.UseVisualStyleBackColor = true;
            this.SaveTextureButton.Click += new System.EventHandler(this.SaveTextureButton_Click);
            // 
            // SelDrawableTexturesTreeView
            // 
            this.SelDrawableTexturesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelDrawableTexturesTreeView.HideSelection = false;
            this.SelDrawableTexturesTreeView.Location = new System.Drawing.Point(4, 4);
            this.SelDrawableTexturesTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelDrawableTexturesTreeView.Name = "SelDrawableTexturesTreeView";
            this.SelDrawableTexturesTreeView.Size = new System.Drawing.Size(313, 399);
            this.SelDrawableTexturesTreeView.TabIndex = 2;
            this.SelDrawableTexturesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelDrawableTexturesTreeView_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 437);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SelTextureDimensionsLabel);
            this.tabPage3.Controls.Add(this.SelTextureMipTrackBar);
            this.tabPage3.Controls.Add(this.SelTextureMipLabel);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.SelTextureDictionaryTextBox);
            this.tabPage3.Controls.Add(this.SelTextureNameTextBox);
            this.tabPage3.Controls.Add(this.SelDrawableTexturePictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(543, 407);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "纹理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SelTextureDimensionsLabel
            // 
            this.SelTextureDimensionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelTextureDimensionsLabel.AutoSize = true;
            this.SelTextureDimensionsLabel.Location = new System.Drawing.Point(306, 383);
            this.SelTextureDimensionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelTextureDimensionsLabel.Name = "SelTextureDimensionsLabel";
            this.SelTextureDimensionsLabel.Size = new System.Drawing.Size(13, 17);
            this.SelTextureDimensionsLabel.TabIndex = 37;
            this.SelTextureDimensionsLabel.Text = "-";
            // 
            // SelTextureMipTrackBar
            // 
            this.SelTextureMipTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelTextureMipTrackBar.AutoSize = false;
            this.SelTextureMipTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelTextureMipTrackBar.LargeChange = 1;
            this.SelTextureMipTrackBar.Location = new System.Drawing.Point(69, 376);
            this.SelTextureMipTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTextureMipTrackBar.Maximum = 0;
            this.SelTextureMipTrackBar.Name = "SelTextureMipTrackBar";
            this.SelTextureMipTrackBar.Size = new System.Drawing.Size(218, 41);
            this.SelTextureMipTrackBar.TabIndex = 36;
            this.SelTextureMipTrackBar.Scroll += new System.EventHandler(this.SelTextureMipTrackBar_Scroll);
            // 
            // SelTextureMipLabel
            // 
            this.SelTextureMipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelTextureMipLabel.AutoSize = true;
            this.SelTextureMipLabel.Location = new System.Drawing.Point(47, 383);
            this.SelTextureMipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelTextureMipLabel.Name = "SelTextureMipLabel";
            this.SelTextureMipLabel.Size = new System.Drawing.Size(15, 17);
            this.SelTextureMipLabel.TabIndex = 35;
            this.SelTextureMipLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "字典：";
            // 
            // SelTextureDictionaryTextBox
            // 
            this.SelTextureDictionaryTextBox.Location = new System.Drawing.Point(315, 8);
            this.SelTextureDictionaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTextureDictionaryTextBox.Name = "SelTextureDictionaryTextBox";
            this.SelTextureDictionaryTextBox.Size = new System.Drawing.Size(151, 23);
            this.SelTextureDictionaryTextBox.TabIndex = 32;
            // 
            // SelTextureNameTextBox
            // 
            this.SelTextureNameTextBox.Location = new System.Drawing.Point(7, 8);
            this.SelTextureNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTextureNameTextBox.Name = "SelTextureNameTextBox";
            this.SelTextureNameTextBox.Size = new System.Drawing.Size(223, 23);
            this.SelTextureNameTextBox.TabIndex = 31;
            // 
            // SelDrawableTexturePictureBox
            // 
            this.SelDrawableTexturePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelDrawableTexturePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.SelDrawableTexturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelDrawableTexturePictureBox.Location = new System.Drawing.Point(0, 47);
            this.SelDrawableTexturePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelDrawableTexturePictureBox.Name = "SelDrawableTexturePictureBox";
            this.SelDrawableTexturePictureBox.Size = new System.Drawing.Size(551, 318);
            this.SelDrawableTexturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelDrawableTexturePictureBox.TabIndex = 29;
            this.SelDrawableTexturePictureBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SelDrawableTexturePropertyGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(543, 407);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SelDrawableTexturePropertyGrid
            // 
            this.SelDrawableTexturePropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelDrawableTexturePropertyGrid.HelpVisible = false;
            this.SelDrawableTexturePropertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.SelDrawableTexturePropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.SelDrawableTexturePropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelDrawableTexturePropertyGrid.Name = "SelDrawableTexturePropertyGrid";
            this.SelDrawableTexturePropertyGrid.Size = new System.Drawing.Size(562, 645);
            this.SelDrawableTexturePropertyGrid.TabIndex = 28;
            this.SelDrawableTexturePropertyGrid.ToolbarVisible = false;
            // 
            // SelectionHierarchyTabPage
            // 
            this.SelectionHierarchyTabPage.Controls.Add(this.splitContainer3);
            this.SelectionHierarchyTabPage.Location = new System.Drawing.Point(4, 26);
            this.SelectionHierarchyTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionHierarchyTabPage.Name = "SelectionHierarchyTabPage";
            this.SelectionHierarchyTabPage.Size = new System.Drawing.Size(881, 453);
            this.SelectionHierarchyTabPage.TabIndex = 6;
            this.SelectionHierarchyTabPage.Text = "层级";
            this.SelectionHierarchyTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.HierarchyTreeView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.HierarchyPropertyGrid);
            this.splitContainer3.Size = new System.Drawing.Size(881, 453);
            this.splitContainer3.SplitterDistance = 352;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // HierarchyTreeView
            // 
            this.HierarchyTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HierarchyTreeView.FullRowSelect = true;
            this.HierarchyTreeView.HideSelection = false;
            this.HierarchyTreeView.Location = new System.Drawing.Point(4, 4);
            this.HierarchyTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HierarchyTreeView.Name = "HierarchyTreeView";
            this.HierarchyTreeView.Size = new System.Drawing.Size(344, 444);
            this.HierarchyTreeView.TabIndex = 0;
            this.HierarchyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.HierarchyTreeView_AfterSelect);
            // 
            // HierarchyPropertyGrid
            // 
            this.HierarchyPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HierarchyPropertyGrid.HelpVisible = false;
            this.HierarchyPropertyGrid.Location = new System.Drawing.Point(4, 4);
            this.HierarchyPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HierarchyPropertyGrid.Name = "HierarchyPropertyGrid";
            this.HierarchyPropertyGrid.Size = new System.Drawing.Size(517, 446);
            this.HierarchyPropertyGrid.TabIndex = 26;
            this.HierarchyPropertyGrid.ToolbarVisible = false;
            // 
            // MouseSelectCheckBox
            // 
            this.MouseSelectCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MouseSelectCheckBox.AutoSize = true;
            this.MouseSelectCheckBox.Location = new System.Drawing.Point(749, 13);
            this.MouseSelectCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MouseSelectCheckBox.Name = "MouseSelectCheckBox";
            this.MouseSelectCheckBox.Size = new System.Drawing.Size(147, 21);
            this.MouseSelectCheckBox.TabIndex = 26;
            this.MouseSelectCheckBox.Text = "鼠标选择（右键点击）";
            this.MouseSelectCheckBox.UseVisualStyleBackColor = true;
            this.MouseSelectCheckBox.CheckedChanged += new System.EventHandler(this.MouseSelectCheckBox_CheckedChanged);
            // 
            // SelectionNameTextBox
            // 
            this.SelectionNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionNameTextBox.Location = new System.Drawing.Point(66, 11);
            this.SelectionNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionNameTextBox.Name = "SelectionNameTextBox";
            this.SelectionNameTextBox.Size = new System.Drawing.Size(400, 23);
            this.SelectionNameTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "名称：";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(508, 15);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 17);
            this.label25.TabIndex = 32;
            this.label25.Text = "模式：";
            // 
            // SelectionModeComboBox
            // 
            this.SelectionModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionModeComboBox.FormattingEnabled = true;
            this.SelectionModeComboBox.Items.AddRange(new object[] {
            "实体",
            "实体扩展",
            "定义扩展",
            "Time Cycle 修改器",
            "车辆生成器",
            "实例草",
            "块状水",
            "碰撞体",
            "寻路网格",
            "路线",
            "火车轨道",
            "远景灯光",
            "室内实例",
            "场景",
            "音频",
            "遮挡"});
            this.SelectionModeComboBox.Location = new System.Drawing.Point(560, 11);
            this.SelectionModeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionModeComboBox.Name = "SelectionModeComboBox";
            this.SelectionModeComboBox.Size = new System.Drawing.Size(140, 25);
            this.SelectionModeComboBox.TabIndex = 31;
            this.SelectionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionModeComboBox_SelectedIndexChanged);
            // 
            // WorldInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 538);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.SelectionModeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectionNameTextBox);
            this.Controls.Add(this.SelectionTabControl);
            this.Controls.Add(this.MouseSelectCheckBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorldInfoForm";
            this.Text = "信息 - CodeWalker by dexyfex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldInfoForm_FormClosed);
            this.Load += new System.EventHandler(this.WorldInfoForm_Load);
            this.SelectionTabControl.ResumeLayout(false);
            this.SelectionEntityTabPage.ResumeLayout(false);
            this.SelectionArchetypeTabPage.ResumeLayout(false);
            this.SelectionDrawableTabPage.ResumeLayout(false);
            this.SelectionExtensionTabPage.ResumeLayout(false);
            this.SelectionModelsTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SelectionTexturesTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelTextureMipTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelDrawableTexturePictureBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.SelectionHierarchyTabPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SelectionTabControl;
        private System.Windows.Forms.TabPage SelectionEntityTabPage;
        private CodeWalker.WinForms.PropertyGridFix SelEntityPropertyGrid;
        private System.Windows.Forms.TabPage SelectionArchetypeTabPage;
        private CodeWalker.WinForms.PropertyGridFix SelArchetypePropertyGrid;
        private System.Windows.Forms.TabPage SelectionDrawableTabPage;
        private System.Windows.Forms.CheckBox MouseSelectCheckBox;
        private System.Windows.Forms.TextBox SelectionNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage SelectionModelsTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TreeViewFix SelDrawableModelsTreeView;
        private CodeWalker.WinForms.PropertyGridFix SelDrawableModelPropertyGrid;
        private System.Windows.Forms.TabPage SelectionTexturesTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private TreeViewFix SelDrawableTexturesTreeView;
        private System.Windows.Forms.PictureBox SelDrawableTexturePictureBox;
        private CodeWalker.WinForms.PropertyGridFix SelDrawableTexturePropertyGrid;
        private CodeWalker.WinForms.PropertyGridFix SelDrawablePropertyGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TrackBar SelTextureMipTrackBar;
        private System.Windows.Forms.Label SelTextureMipLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SelTextureDictionaryTextBox;
        private System.Windows.Forms.TextBox SelTextureNameTextBox;
        private System.Windows.Forms.Label SelTextureDimensionsLabel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox SelectionModeComboBox;
        private System.Windows.Forms.TabPage SelectionExtensionTabPage;
        private CodeWalker.WinForms.PropertyGridFix SelExtensionPropertyGrid;
        private System.Windows.Forms.TabPage SelectionHierarchyTabPage;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView HierarchyTreeView;
        private PropertyGridFix HierarchyPropertyGrid;
        private System.Windows.Forms.Button SaveTextureButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button SaveAllTexturesButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}