namespace ApplicationForDesigningBuildings
{
    partial class SettingElementsForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.elementInteriorColorButton = new System.Windows.Forms.Button();
            this.elementTypeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.elementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.elementSizeLabel = new System.Windows.Forms.Label();
            this.strokeThicknessLabel = new System.Windows.Forms.Label();
            this.strokeThicknessTextBox = new System.Windows.Forms.TextBox();
            this.elementInteriorColorLabel = new System.Windows.Forms.Label();
            this.elementColorLabel = new System.Windows.Forms.Label();
            this.elementColorButton = new System.Windows.Forms.Button();
            this.interElementSizeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.elementSizeHeightTextBox = new System.Windows.Forms.TextBox();
            this.elementSizeWidthTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.interElementSizeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.elementInteriorColorButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.elementTypeLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.cancelButton, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.elementTypeComboBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.elementSizeLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.strokeThicknessLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.strokeThicknessTextBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.elementInteriorColorLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.elementColorLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.elementColorButton, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.interElementSizeTableLayoutPanel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(462, 433);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // elementInteriorColorButton
            // 
            this.elementInteriorColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementInteriorColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementInteriorColorButton.Location = new System.Drawing.Point(241, 304);
            this.elementInteriorColorButton.Name = "elementInteriorColorButton";
            this.elementInteriorColorButton.Size = new System.Drawing.Size(211, 40);
            this.elementInteriorColorButton.TabIndex = 14;
            this.elementInteriorColorButton.Text = "Выбрать цвет";
            this.elementInteriorColorButton.UseVisualStyleBackColor = true;
            this.elementInteriorColorButton.Click += new System.EventHandler(this.elementInteriorColorButton_Click);
            // 
            // elementTypeLabel
            // 
            this.elementTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementTypeLabel.AutoSize = true;
            this.elementTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementTypeLabel.Location = new System.Drawing.Point(42, 23);
            this.elementTypeLabel.Name = "elementTypeLabel";
            this.elementTypeLabel.Size = new System.Drawing.Size(146, 25);
            this.elementTypeLabel.TabIndex = 0;
            this.elementTypeLabel.Text = "Тип элемента";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(44, 374);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 45);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(275, 374);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(143, 45);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // elementTypeComboBox
            // 
            this.elementTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementTypeComboBox.Items.AddRange(new object[] {
            "Каркас дома",
            "Дверь",
            "Ручка двери",
            "Крыша",
            "Окно",
            "Створка окна"});
            this.elementTypeComboBox.Location = new System.Drawing.Point(240, 19);
            this.elementTypeComboBox.Name = "elementTypeComboBox";
            this.elementTypeComboBox.Size = new System.Drawing.Size(212, 33);
            this.elementTypeComboBox.TabIndex = 12;
            this.elementTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.elementTypeComboBox_SelectedIndexChanged);
            // 
            // elementSizeLabel
            // 
            this.elementSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementSizeLabel.AutoSize = true;
            this.elementSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementSizeLabel.Location = new System.Drawing.Point(23, 95);
            this.elementSizeLabel.Name = "elementSizeLabel";
            this.elementSizeLabel.Size = new System.Drawing.Size(184, 25);
            this.elementSizeLabel.TabIndex = 10;
            this.elementSizeLabel.Text = "Размер элемента";
            // 
            // strokeThicknessLabel
            // 
            this.strokeThicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.strokeThicknessLabel.AutoSize = true;
            this.strokeThicknessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strokeThicknessLabel.Location = new System.Drawing.Point(27, 167);
            this.strokeThicknessLabel.Name = "strokeThicknessLabel";
            this.strokeThicknessLabel.Size = new System.Drawing.Size(177, 25);
            this.strokeThicknessLabel.TabIndex = 6;
            this.strokeThicknessLabel.Text = "Толщина обводки";
            // 
            // strokeThicknessTextBox
            // 
            this.strokeThicknessTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.strokeThicknessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strokeThicknessTextBox.Location = new System.Drawing.Point(276, 161);
            this.strokeThicknessTextBox.Name = "strokeThicknessTextBox";
            this.strokeThicknessTextBox.Size = new System.Drawing.Size(141, 38);
            this.strokeThicknessTextBox.TabIndex = 7;
            this.strokeThicknessTextBox.Text = "0";
            this.strokeThicknessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // elementInteriorColorLabel
            // 
            this.elementInteriorColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementInteriorColorLabel.AutoSize = true;
            this.elementInteriorColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementInteriorColorLabel.Location = new System.Drawing.Point(49, 299);
            this.elementInteriorColorLabel.Name = "elementInteriorColorLabel";
            this.elementInteriorColorLabel.Size = new System.Drawing.Size(133, 50);
            this.elementInteriorColorLabel.TabIndex = 3;
            this.elementInteriorColorLabel.Text = "Цвет внутри элемента";
            // 
            // elementColorLabel
            // 
            this.elementColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementColorLabel.AutoSize = true;
            this.elementColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementColorLabel.Location = new System.Drawing.Point(45, 239);
            this.elementColorLabel.Name = "elementColorLabel";
            this.elementColorLabel.Size = new System.Drawing.Size(140, 25);
            this.elementColorLabel.TabIndex = 2;
            this.elementColorLabel.Text = "Цвет обводки";
            // 
            // elementColorButton
            // 
            this.elementColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elementColorButton.Location = new System.Drawing.Point(241, 232);
            this.elementColorButton.Name = "elementColorButton";
            this.elementColorButton.Size = new System.Drawing.Size(211, 40);
            this.elementColorButton.TabIndex = 13;
            this.elementColorButton.Text = "Выбрать цвет";
            this.elementColorButton.UseVisualStyleBackColor = true;
            this.elementColorButton.Click += new System.EventHandler(this.elementColorButton_Click);
            // 
            // interElementSizeTableLayoutPanel
            // 
            this.interElementSizeTableLayoutPanel.ColumnCount = 3;
            this.interElementSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.interElementSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.interElementSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.interElementSizeTableLayoutPanel.Controls.Add(this.xLabel, 1, 0);
            this.interElementSizeTableLayoutPanel.Controls.Add(this.elementSizeWidthTextBox, 0, 0);
            this.interElementSizeTableLayoutPanel.Controls.Add(this.elementSizeHeightTextBox, 2, 0);
            this.interElementSizeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interElementSizeTableLayoutPanel.Location = new System.Drawing.Point(234, 75);
            this.interElementSizeTableLayoutPanel.Name = "interElementSizeTableLayoutPanel";
            this.interElementSizeTableLayoutPanel.RowCount = 1;
            this.interElementSizeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.interElementSizeTableLayoutPanel.Size = new System.Drawing.Size(225, 66);
            this.interElementSizeTableLayoutPanel.TabIndex = 15;
            // 
            // elementSizeHeightTextBox
            // 
            this.elementSizeHeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementSizeHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementSizeHeightTextBox.Location = new System.Drawing.Point(138, 18);
            this.elementSizeHeightTextBox.Name = "elementSizeHeightTextBox";
            this.elementSizeHeightTextBox.Size = new System.Drawing.Size(84, 30);
            this.elementSizeHeightTextBox.TabIndex = 11;
            // 
            // elementSizeWidthTextBox
            // 
            this.elementSizeWidthTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementSizeWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementSizeWidthTextBox.Location = new System.Drawing.Point(3, 18);
            this.elementSizeWidthTextBox.Name = "elementSizeWidthTextBox";
            this.elementSizeWidthTextBox.Size = new System.Drawing.Size(84, 30);
            this.elementSizeWidthTextBox.TabIndex = 12;
            // 
            // xLabel
            // 
            this.xLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(94, 15);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(37, 36);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "X";
            // 
            // SettingElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 433);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "SettingElementsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка элемента";
            this.Load += new System.EventHandler(this.SettingElementsForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.interElementSizeTableLayoutPanel.ResumeLayout(false);
            this.interElementSizeTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label elementTypeLabel;
        private System.Windows.Forms.Label elementColorLabel;
        private System.Windows.Forms.Label elementInteriorColorLabel;
        private System.Windows.Forms.TextBox strokeThicknessTextBox;
        private System.Windows.Forms.Label strokeThicknessLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label elementSizeLabel;
        private System.Windows.Forms.TextBox elementSizeHeightTextBox;
        private System.Windows.Forms.ComboBox elementTypeComboBox;
        private System.Windows.Forms.Button elementColorButton;
        private System.Windows.Forms.Button elementInteriorColorButton;
        private System.Windows.Forms.TableLayoutPanel interElementSizeTableLayoutPanel;
        private System.Windows.Forms.TextBox elementSizeWidthTextBox;
        private System.Windows.Forms.Label xLabel;
    }
}