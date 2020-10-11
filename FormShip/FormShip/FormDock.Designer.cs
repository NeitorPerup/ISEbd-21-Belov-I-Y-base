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
            this.buttonDockShip = new System.Windows.Forms.Button();
            this.buttonDockWarship = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonUndock = new System.Windows.Forms.Button();
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
            // buttonDockShip
            // 
            this.buttonDockShip.Location = new System.Drawing.Point(760, 32);
            this.buttonDockShip.Name = "buttonDockShip";
            this.buttonDockShip.Size = new System.Drawing.Size(95, 49);
            this.buttonDockShip.TabIndex = 1;
            this.buttonDockShip.Text = "Пришвартовать корабль";
            this.buttonDockShip.UseVisualStyleBackColor = true;
            this.buttonDockShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // buttonDockWarship
            // 
            this.buttonDockWarship.Location = new System.Drawing.Point(760, 103);
            this.buttonDockWarship.Name = "buttonDockWarship";
            this.buttonDockWarship.Size = new System.Drawing.Size(95, 54);
            this.buttonDockWarship.TabIndex = 2;
            this.buttonDockWarship.Text = "Пришвартовать военный корабль";
            this.buttonDockWarship.UseVisualStyleBackColor = true;
            this.buttonDockWarship.Click += new System.EventHandler(this.buttonSetSportWarship_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonUndock);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(751, 195);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(118, 124);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Отшвартовать корабль";
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
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(59, 38);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox.TabIndex = 1;
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
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonDockWarship);
            this.Controls.Add(this.buttonDockShip);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "Док";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button buttonDockShip;
        private System.Windows.Forms.Button buttonDockWarship;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonUndock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
    }
}