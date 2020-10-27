namespace FormShip
{
    partial class FormShipConfig
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
            this.GroupBoxShipType = new System.Windows.Forms.GroupBox();
            this.labelWarship = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxCannon = new System.Windows.Forms.CheckBox();
            this.checkBoxAntenna = new System.Windows.Forms.CheckBox();
            this.checkBoxDopBuilding = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.panelShip = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.GroupBoxShipType.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.panelShip.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.panelYellow.SuspendLayout();
            this.panelFuchsia.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxShipType
            // 
            this.GroupBoxShipType.Controls.Add(this.labelWarship);
            this.GroupBoxShipType.Controls.Add(this.labelShip);
            this.GroupBoxShipType.Location = new System.Drawing.Point(84, 31);
            this.GroupBoxShipType.Name = "GroupBoxShipType";
            this.GroupBoxShipType.Size = new System.Drawing.Size(114, 105);
            this.GroupBoxShipType.TabIndex = 0;
            this.GroupBoxShipType.TabStop = false;
            this.GroupBoxShipType.Text = "Тип корабля";
            // 
            // labelWarship
            // 
            this.labelWarship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarship.Location = new System.Drawing.Point(13, 67);
            this.labelWarship.Name = "labelWarship";
            this.labelWarship.Size = new System.Drawing.Size(71, 20);
            this.labelWarship.TabIndex = 4;
            this.labelWarship.Text = "Военный";
            this.labelWarship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelWarship_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(13, 30);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(71, 24);
            this.labelShip.TabIndex = 3;
            this.labelShip.Text = "Обычный";
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelShip_MouseDown);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxCannon);
            this.groupBoxParams.Controls.Add(this.checkBoxAntenna);
            this.groupBoxParams.Controls.Add(this.checkBoxDopBuilding);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(84, 192);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(387, 124);
            this.groupBoxParams.TabIndex = 1;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxCannon
            // 
            this.checkBoxCannon.AutoSize = true;
            this.checkBoxCannon.Checked = true;
            this.checkBoxCannon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCannon.Location = new System.Drawing.Point(166, 75);
            this.checkBoxCannon.Name = "checkBoxCannon";
            this.checkBoxCannon.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCannon.TabIndex = 8;
            this.checkBoxCannon.Text = "Пушки";
            this.checkBoxCannon.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntenna
            // 
            this.checkBoxAntenna.AutoSize = true;
            this.checkBoxAntenna.Checked = true;
            this.checkBoxAntenna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAntenna.Location = new System.Drawing.Point(166, 52);
            this.checkBoxAntenna.Name = "checkBoxAntenna";
            this.checkBoxAntenna.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAntenna.TabIndex = 7;
            this.checkBoxAntenna.Text = "Антенна";
            this.checkBoxAntenna.UseVisualStyleBackColor = true;
            // 
            // checkBoxDopBuilding
            // 
            this.checkBoxDopBuilding.AutoSize = true;
            this.checkBoxDopBuilding.Checked = true;
            this.checkBoxDopBuilding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDopBuilding.Location = new System.Drawing.Point(166, 29);
            this.checkBoxDopBuilding.Name = "checkBoxDopBuilding";
            this.checkBoxDopBuilding.Size = new System.Drawing.Size(106, 17);
            this.checkBoxDopBuilding.TabIndex = 6;
            this.checkBoxDopBuilding.Text = "Доп. постройка";
            this.checkBoxDopBuilding.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(7, 98);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 5;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(13, 29);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(13, 74);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(71, 13);
            this.labelWeight.TabIndex = 3;
            this.labelWeight.Text = "Вес корабля";
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(7, 45);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 4;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShip.Location = new System.Drawing.Point(17, 3);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pictureBoxShip.Size = new System.Drawing.Size(226, 133);
            this.pictureBoxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxShip.TabIndex = 2;
            this.pictureBoxShip.TabStop = false;
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(250, 31);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(265, 139);
            this.panelShip.TabIndex = 3;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelShip_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panel1);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelFuchsia);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(546, 31);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(215, 188);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(168, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 37);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(168, 121);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(41, 37);
            this.panelWhite.TabIndex = 5;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Controls.Add(this.panel12);
            this.panelYellow.Location = new System.Drawing.Point(64, 121);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(41, 37);
            this.panelYellow.TabIndex = 7;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(171, 39);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 8;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Controls.Add(this.panel11);
            this.panelFuchsia.Controls.Add(this.panel9);
            this.panelFuchsia.Controls.Add(this.panel10);
            this.panelFuchsia.Location = new System.Drawing.Point(6, 121);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(41, 37);
            this.panelFuchsia.TabIndex = 8;
            this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(-31, 86);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 100);
            this.panel11.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(174, 29);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Location = new System.Drawing.Point(-78, -45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(41, 37);
            this.panel10.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(109, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 37);
            this.panel5.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(168, 68);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(41, 37);
            this.panelBlack.TabIndex = 5;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(115, 121);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(41, 37);
            this.panelGreen.TabIndex = 6;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(115, 68);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(41, 37);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(64, 68);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(41, 37);
            this.panelOrange.TabIndex = 3;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 68);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(41, 37);
            this.panelRed.TabIndex = 2;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(115, 32);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(76, 23);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 31);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(90, 23);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(680, 256);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 35);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(680, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 39);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.GroupBoxShipType);
            this.Name = "FormShipConfig";
            this.Text = "FormShipConfig";
            this.GroupBoxShipType.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.panelShip.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.panelYellow.ResumeLayout(false);
            this.panelFuchsia.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxShipType;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxCannon;
        private System.Windows.Forms.CheckBox checkBoxAntenna;
        private System.Windows.Forms.CheckBox checkBoxDopBuilding;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Label labelWarship;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}