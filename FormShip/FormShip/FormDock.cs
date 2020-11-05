﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormShip
{
    public partial class FormDock : Form
    {
        private readonly DockCollection dockCollection;

        public FormDock()
        {
            InitializeComponent();
            dockCollection = new DockCollection(pictureBoxDock.Width, pictureBoxDock.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxDock.SelectedIndex;
            listBoxDock.Items.Clear();
            for (int i = 0; i < dockCollection.Keys.Count; i++)
            {
                listBoxDock.Items.Add(dockCollection.Keys[i]);
            }
            if (listBoxDock.Items.Count > 0 && (index == -1 || index >=
            listBoxDock.Items.Count))
            {
                listBoxDock.SelectedIndex = 0;
            }
            else if (listBoxDock.Items.Count > 0 && index > -1 && index <
            listBoxDock.Items.Count)
            {
                listBoxDock.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxDock.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dockCollection[listBoxDock.SelectedItem.ToString()].Draw(gr);
                pictureBoxDock.Image = bmp;
            }
        }

        private void buttonAddDock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название дока", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dockCollection.AddDock(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }

        private void buttonDelDock_Click(object sender, EventArgs e)
        {
            if (listBoxDock.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxDock.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dockCollection.DelDock(listBoxDock.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                if (dockCollection[listBoxDock.SelectedItem.ToString()] + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не пришвартовано =)");
                }
            }
        }

        private void buttonSetWarship_Click(object sender, EventArgs e)
        {
            if (listBoxDock.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var linkor = new Warship(100, 1000, dialog.Color, dialogDop.Color,
                        true, true, true);
                        if (dockCollection[listBoxDock.SelectedItem.ToString()] + linkor)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Не пришвартовано =)");
                        }
                    }
                }
            }
        }

        private void buttonUndock_Click(object sender, EventArgs e)
        {
            if (listBoxDock.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                if (maskedTextBox.Text != "")
                {
                    var ship = dockCollection[listBoxDock.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (ship != null)
                    {
                        FormShip form = new FormShip();
                        form.SetShip(ship);
                        form.ShowDialog();
                    }
                    Draw();
                }
            }
        }

        private void listBoxDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void ButtonAddShip_Click(object sender, EventArgs e)
        {
            var formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(AddShip);
            formShipConfig.Show();
        }

        private void AddShip(Vehicle ship)
        {
            if (ship != null && listBoxDock.SelectedIndex > -1)
            {
                if ((dockCollection[listBoxDock.SelectedItem.ToString()]) + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось поставить");
                }
            }
        }
    }
}
