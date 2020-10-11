using System;
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
        private readonly Dock<Warship> dock;

        public FormDock()
        {
            InitializeComponent();
            dock = new Dock<Warship>(pictureBoxDock.Width,
                pictureBoxDock.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dock.Draw(gr);
            pictureBoxDock.Image = bmp;
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var warship = new Warship(100, 1000, dialog.Color);
                if (dock + warship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не пришвартовано =)");
                }
            }
        }

        private void buttonSetSportWarship_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var linkor = new Linkor(100, 1000, dialog.Color, dialogDop.Color,
                    true, true, true);
                    if (dock + linkor)
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

        private void buttonUndock_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = dock - Convert.ToInt32(maskedTextBox.Text);
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
}
