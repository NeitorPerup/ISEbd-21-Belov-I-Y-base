namespace FormShip
{
    partial class FormDock
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
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonUndock = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.listBoxDock = new System.Windows.Forms.ListBox();
            this.buttonAddDock = new System.Windows.Forms.Button();
            this.buttonDelDock = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(730, 448);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonUndock);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(760, 324);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(118, 124);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Отшвартовать корабль";
            // 
            // buttonUndock
            // 
            this.buttonUndock.Location = new System.Drawing.Point(9, 76);
            this.buttonUndock.Name = "buttonUndock";
            this.buttonUndock.Size = new System.Drawing.Size(89, 29);
            this.buttonUndock.TabIndex = 2;
            this.buttonUndock.Text = "Отшвартовать";
            this.buttonUndock.UseVisualStyleBackColor = true;
            this.buttonUndock.Click += new System.EventHandler(this.buttonUndock_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(59, 38);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Место";
            // 
            // listBoxDock
            // 
            this.listBoxDock.FormattingEnabled = true;
            this.listBoxDock.Location = new System.Drawing.Point(755, 80);
            this.listBoxDock.Name = "listBoxDock";
            this.listBoxDock.Size = new System.Drawing.Size(120, 95);
            this.listBoxDock.TabIndex = 4;
            this.listBoxDock.Click += new System.EventHandler(this.listBoxDock_SelectedIndexChanged);
            // 
            // buttonAddDock
            // 
            this.buttonAddDock.Location = new System.Drawing.Point(755, 51);
            this.buttonAddDock.Name = "buttonAddDock";
            this.buttonAddDock.Size = new System.Drawing.Size(120, 23);
            this.buttonAddDock.TabIndex = 5;
            this.buttonAddDock.Text = "Добавить док";
            this.buttonAddDock.UseVisualStyleBackColor = true;
            this.buttonAddDock.Click += new System.EventHandler(this.buttonAddDock_Click);
            // 
            // buttonDelDock
            // 
            this.buttonDelDock.Location = new System.Drawing.Point(755, 181);
            this.buttonDelDock.Name = "buttonDelDock";
            this.buttonDelDock.Size = new System.Drawing.Size(120, 23);
            this.buttonDelDock.TabIndex = 6;
            this.buttonDelDock.Text = "Удалить док";
            this.buttonDelDock.UseVisualStyleBackColor = true;
            this.buttonDelDock.Click += new System.EventHandler(this.buttonDelDock_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(755, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(120, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Доки";
            // 
            // buttonAddShip
            // 
            this.buttonAddShip.Location = new System.Drawing.Point(769, 253);
            this.buttonAddShip.Name = "buttonAddShip";
            this.buttonAddShip.Size = new System.Drawing.Size(106, 41);
            this.buttonAddShip.TabIndex = 9;
            this.buttonAddShip.Text = "Добавить корабль";
            this.buttonAddShip.UseVisualStyleBackColor = true;
            this.buttonAddShip.Click += new System.EventHandler(this.ButtonAddShip_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.buttonAddShip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonDelDock);
            this.Controls.Add(this.buttonAddDock);
            this.Controls.Add(this.listBoxDock);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "Док";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonUndock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBoxDock;
        private System.Windows.Forms.Button buttonAddDock;
        private System.Windows.Forms.Button buttonDelDock;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddShip;
    }
}