using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormShip
{
    public class Linkor : Warship
    {
        public Color DopColor { private set; get; }

        public bool Antenna { private set; get; }

        public bool Cannon { private set; get; }

        public bool Tube { private set; get; }

        public Linkor(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool antenna, bool cannon, bool tube) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Antenna = antenna;
            Cannon = cannon;
            Tube = tube;
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(Color.Black);
            Brush brDopColor = new SolidBrush(DopColor);
            if (Tube)
            {
                PointF[] tubePoints = {new PointF(_startPosX + 115, _startPosY + 5), new PointF(_startPosX + 108, _startPosY - 12),
                             new PointF(_startPosX + 126, _startPosY - 18), new PointF(_startPosX + 133, _startPosY + 5) };
                g.FillPolygon(brDopColor, tubePoints);
            }

            if (Antenna)
            {
                g.FillRectangle(brDopColor, _startPosX + 70, _startPosY, 15, 7);
                g.FillRectangle(brDopColor, _startPosX + 81, _startPosY - 15, 2, 15);
            }

            if (Cannon)
            {
                PointF[] cannon1Points = { new PointF(_startPosX + 165, _startPosY + 5), new PointF(_startPosX + 170, _startPosY - 7),
                                           new PointF(_startPosX + 185, _startPosY - 7), new PointF(_startPosX + 190, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon1Points);
                g.FillRectangle(brDopColor, _startPosX + 180, _startPosY - 4, 20, 4);

                PointF[] cannon2Points = { new PointF(_startPosX + 60, _startPosY + 5), new PointF(_startPosX + 55, _startPosY - 7),
                                           new PointF(_startPosX + 45, _startPosY - 7), new PointF(_startPosX + 40, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon2Points);
                g.FillRectangle(brDopColor, _startPosX + 24, _startPosY - 4, 20, 4);
            }
        }
    }
}
