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
    public partial class FormShipConfig : Form
    {
        Vehicle ship = null;

        private event ShipDelegate eventAddShip;

        public event Action<Vehicle> eventActionAddShip;

        public FormShipConfig()
        {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 25, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawTransport(gr);
                pictureBoxShip.Image = bmp;
            }
        }

        public void AddEvent(ShipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new ShipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }

        private void LabelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelWarship_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarship.DoDragDrop(labelWarship.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void PanelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный":
                    ship = new Ship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Военный":
                    ship = new Warship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,
                        Color.White, Color.Black, checkBoxAntenna.Checked, checkBoxCannon.Checked, checkBoxDopBuilding.Checked);
                    break;
            }
            DrawShip();
        }

        private void PanelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            var shipColor = e.Data.GetData(DataFormats.Text).ToString();
            ship.SetMainColor(Color.FromName(shipColor));
            DrawShip();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Warship)
            {
                var shipColor = e.Data.GetData(DataFormats.Text).ToString();
                (ship as Warship).SetDopColor(Color.FromName(shipColor));
                DrawShip();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //eventAddShip?.Invoke(ship);
            eventActionAddShip.Invoke(ship);
            Close();
        }
    }
}
