namespace ZetaResourceEditor.UI.FileGroups
{
	partial class CreateNewFileForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.buttonSettings = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.buttonDefault = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.prefixTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.prefixCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.copyTextsCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.automaticallyTranslateCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.newLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.referenceLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.fileGroupTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.newFileNameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefixCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTextsCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticallyTranslateCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newLanguageComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLanguageComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFileNameTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.buttonSettings);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.buttonDefault);
            this.panelControl1.Controls.Add(this.prefixTextBox);
            this.panelControl1.Controls.Add(this.prefixCheckBox);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Controls.Add(this.copyTextsCheckBox);
            this.panelControl1.Controls.Add(this.buttonOK);
            this.panelControl1.Controls.Add(this.automaticallyTranslateCheckBox);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.newLanguageComboBox);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.referenceLanguageComboBox);
            this.panelControl1.Controls.Add(this.fileGroupTextBox);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.newFileNameTextBox);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(484, 285);
            this.panelControl1.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonSettings.Appearance.Options.UseFont = true;
            this.buttonSettings.Location = new System.Drawing.Point(12, 245);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 28);
            this.buttonSettings.TabIndex = 19;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.WantDrawFocusRectangle = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelControl3.Location = new System.Drawing.Point(93, 251);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 17);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "<>";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonDefault.Appearance.Options.UseFont = true;
            this.buttonDefault.Location = new System.Drawing.Point(301, 199);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(60, 26);
            this.buttonDefault.TabIndex = 17;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.WantDrawFocusRectangle = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Bold = false;
            this.prefixTextBox.CueText = null;
            this.prefixTextBox.Location = new System.Drawing.Point(195, 200);
            this.prefixTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.prefixTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prefixTextBox.Properties.Appearance.Options.UseFont = true;
            this.prefixTextBox.Properties.Mask.EditMask = null;
            this.prefixTextBox.Properties.NullValuePrompt = null;
            this.prefixTextBox.Size = new System.Drawing.Size(100, 24);
            this.prefixTextBox.TabIndex = 16;
            this.prefixTextBox.EditValueChanged += new System.EventHandler(this.prefixTextBox_EditValueChanged);
            // 
            // prefixCheckBox
            // 
            this.prefixCheckBox.Location = new System.Drawing.Point(12, 202);
            this.prefixCheckBox.Name = "prefixCheckBox";
            this.prefixCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prefixCheckBox.Properties.Appearance.Options.UseFont = true;
            this.prefixCheckBox.Properties.AutoWidth = true;
            this.prefixCheckBox.Properties.Caption = "Prefix translated texts with:";
            this.prefixCheckBox.Size = new System.Drawing.Size(177, 21);
            this.prefixCheckBox.TabIndex = 15;
            this.prefixCheckBox.CheckedChanged += new System.EventHandler(this.prefixCheckBox_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 245);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // copyTextsCheckBox
            // 
            this.copyTextsCheckBox.Location = new System.Drawing.Point(12, 145);
            this.copyTextsCheckBox.Name = "copyTextsCheckBox";
            this.copyTextsCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.copyTextsCheckBox.Properties.Appearance.Options.UseFont = true;
            this.copyTextsCheckBox.Properties.AutoWidth = true;
            this.copyTextsCheckBox.Properties.Caption = "&Copy texts from reference language";
            this.copyTextsCheckBox.Size = new System.Drawing.Size(232, 21);
            this.copyTextsCheckBox.TabIndex = 8;
            this.copyTextsCheckBox.CheckedChanged += new System.EventHandler(this.copyTextsCheckBox_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(316, 245);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // automaticallyTranslateCheckBox
            // 
            this.automaticallyTranslateCheckBox.Location = new System.Drawing.Point(12, 172);
            this.automaticallyTranslateCheckBox.Name = "automaticallyTranslateCheckBox";
            this.automaticallyTranslateCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.automaticallyTranslateCheckBox.Properties.Appearance.Options.UseFont = true;
            this.automaticallyTranslateCheckBox.Properties.AutoWidth = true;
            this.automaticallyTranslateCheckBox.Properties.Caption = "&Automatically translate from reference language";
            this.automaticallyTranslateCheckBox.Size = new System.Drawing.Size(302, 21);
            this.automaticallyTranslateCheckBox.TabIndex = 9;
            this.automaticallyTranslateCheckBox.CheckedChanged += new System.EventHandler(this.automaticallyTranslateCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File group:";
            // 
            // newLanguageComboBox
            // 
            this.newLanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newLanguageComboBox.CueText = null;
            this.newLanguageComboBox.Location = new System.Drawing.Point(139, 80);
            this.newLanguageComboBox.Name = "newLanguageComboBox";
            this.newLanguageComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newLanguageComboBox.Properties.Appearance.Options.UseFont = true;
            this.newLanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.newLanguageComboBox.Properties.DropDownRows = 20;
            this.newLanguageComboBox.Properties.NullValuePrompt = null;
            this.newLanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.newLanguageComboBox.Properties.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
            this.newLanguageComboBox.Size = new System.Drawing.Size(333, 24);
            this.newLanguageComboBox.TabIndex = 5;
            this.newLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.newLanguageComboBox_SelectedIndexChanged);
            this.newLanguageComboBox.TextChanged += new System.EventHandler(this.newLanguageComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Reference language:";
            // 
            // referenceLanguageComboBox
            // 
            this.referenceLanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceLanguageComboBox.CueText = null;
            this.referenceLanguageComboBox.Location = new System.Drawing.Point(139, 42);
            this.referenceLanguageComboBox.Name = "referenceLanguageComboBox";
            this.referenceLanguageComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.referenceLanguageComboBox.Properties.Appearance.Options.UseFont = true;
            this.referenceLanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.referenceLanguageComboBox.Properties.DropDownRows = 20;
            this.referenceLanguageComboBox.Properties.NullValuePrompt = null;
            this.referenceLanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.referenceLanguageComboBox.Properties.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
            this.referenceLanguageComboBox.Size = new System.Drawing.Size(333, 24);
            this.referenceLanguageComboBox.TabIndex = 3;
            this.referenceLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageComboBox_SelectedIndexChanged);
            // 
            // fileGroupTextBox
            // 
            this.fileGroupTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGroupTextBox.Bold = false;
            this.fileGroupTextBox.CueText = null;
            this.fileGroupTextBox.Location = new System.Drawing.Point(139, 12);
            this.fileGroupTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.fileGroupTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.fileGroupTextBox.Name = "fileGroupTextBox";
            this.fileGroupTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileGroupTextBox.Properties.Appearance.Options.UseFont = true;
            this.fileGroupTextBox.Properties.Mask.EditMask = null;
            this.fileGroupTextBox.Properties.NullValuePrompt = null;
            this.fileGroupTextBox.Properties.ReadOnly = true;
            this.fileGroupTextBox.Size = new System.Drawing.Size(333, 24);
            this.fileGroupTextBox.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl2.Location = new System.Drawing.Point(14, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 17);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "New file name:";
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newFileNameTextBox.Bold = false;
            this.newFileNameTextBox.CueText = null;
            this.newFileNameTextBox.Location = new System.Drawing.Point(139, 110);
            this.newFileNameTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.newFileNameTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newFileNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.newFileNameTextBox.Properties.Mask.EditMask = null;
            this.newFileNameTextBox.Properties.NullValuePrompt = null;
            this.newFileNameTextBox.Properties.ReadOnly = true;
            this.newFileNameTextBox.Size = new System.Drawing.Size(333, 24);
            this.newFileNameTextBox.TabIndex = 7;
            this.newFileNameTextBox.TextChanged += new System.EventHandler(this.newFileNameTextBox_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Location = new System.Drawing.Point(14, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "&New language:";
            // 
            // CreateNewFileForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 285);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 324);
            this.Name = "CreateNewFileForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new files for language";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewFileForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateNewFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefixCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTextsCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticallyTranslateCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newLanguageComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLanguageComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFileNameTextBox.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit referenceLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit fileGroupTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit newLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit newFileNameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit automaticallyTranslateCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit copyTextsCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDefault;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit prefixTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit prefixCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
	}
}