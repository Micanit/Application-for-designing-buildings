namespace ApplicationForDesigningBuildings
{
    partial class mainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.changeElementButton = new System.Windows.Forms.Button();
            this.addElementButton = new System.Windows.Forms.Button();
            this.layerBelowButton = new System.Windows.Forms.Button();
            this.layerHigherButton = new System.Windows.Forms.Button();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.drawPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonsTableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // drawPanel
            // 
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(3, 48);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(794, 399);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseClick);
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 5;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.Controls.Add(this.changeElementButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.addElementButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.layerBelowButton, 4, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.layerHigherButton, 3, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.deleteElementButton, 2, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(794, 39);
            this.buttonsTableLayoutPanel.TabIndex = 3;
            // 
            // changeElementButton
            // 
            this.changeElementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeElementButton.Location = new System.Drawing.Point(161, 3);
            this.changeElementButton.Name = "changeElementButton";
            this.changeElementButton.Size = new System.Drawing.Size(152, 33);
            this.changeElementButton.TabIndex = 5;
            this.changeElementButton.Text = "Изменить";
            this.changeElementButton.UseVisualStyleBackColor = true;
            this.changeElementButton.Click += new System.EventHandler(this.changeElementButton_Click);
            // 
            // addElementButton
            // 
            this.addElementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addElementButton.Location = new System.Drawing.Point(3, 3);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(152, 33);
            this.addElementButton.TabIndex = 1;
            this.addElementButton.Text = "Добавить";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // layerBelowButton
            // 
            this.layerBelowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerBelowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerBelowButton.Location = new System.Drawing.Point(635, 3);
            this.layerBelowButton.Name = "layerBelowButton";
            this.layerBelowButton.Size = new System.Drawing.Size(156, 33);
            this.layerBelowButton.TabIndex = 2;
            this.layerBelowButton.Text = "На слой ниже -";
            this.layerBelowButton.UseVisualStyleBackColor = true;
            this.layerBelowButton.Click += new System.EventHandler(this.layerBelowButton_Click);
            // 
            // layerHigherButton
            // 
            this.layerHigherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerHigherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerHigherButton.Location = new System.Drawing.Point(477, 3);
            this.layerHigherButton.Name = "layerHigherButton";
            this.layerHigherButton.Size = new System.Drawing.Size(152, 33);
            this.layerHigherButton.TabIndex = 4;
            this.layerHigherButton.Text = "На слой выше +";
            this.layerHigherButton.UseVisualStyleBackColor = true;
            this.layerHigherButton.Click += new System.EventHandler(this.layerHigherButton_Click);
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteElementButton.Location = new System.Drawing.Point(319, 3);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(152, 33);
            this.deleteElementButton.TabIndex = 3;
            this.deleteElementButton.Text = "Удалить";
            this.deleteElementButton.UseVisualStyleBackColor = true;
            this.deleteElementButton.Click += new System.EventHandler(this.deleteElementButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Приложение для конструирования жилых зданий";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.Timer mainFormTimer;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button layerBelowButton;
        private System.Windows.Forms.Button deleteElementButton;
        private System.Windows.Forms.Button layerHigherButton;
        private System.Windows.Forms.Button changeElementButton;
    }
}

