using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormShip
{
    public class Warship : Ship, IEquatable<Warship>
    {
        public Color DopColor { private set; get; }

        public bool Antenna { private set; get; }

        public bool Cannon { private set; get; }

        public bool DopBuilding { private set; get; }

        public new LinkedList<Object> objectProperties = new LinkedList<Object>();

        private int currentIndex = 0;

        public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool antenna, bool cannon, bool dopBuilding) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Antenna = antenna;
            Cannon = cannon;
            DopBuilding = dopBuilding;
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public Warship(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Antenna = Convert.ToBoolean(strs[4]);
                Cannon = Convert.ToBoolean(strs[5]);
                DopBuilding = Convert.ToBoolean(strs[6]);
            }
        }

        public override string ToString()
        {
            return
            $"{base.ToString()}{separator}{DopColor.Name}{separator}{Antenna}{separator}{Cannon}{separator}{DopBuilding}";
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(Color.Black);
            Brush brDopColor = new SolidBrush(DopColor);

            if (DopBuilding)
            {
                g.FillRectangle(brDopColor, _startPosX + 70, _startPosY, 15, 7);
            }

            if (Antenna)
            {               
                g.FillRectangle(brDopColor, _startPosX + 81, _startPosY - 15, 2, 20);
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
        public bool Equals(Warship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Antenna != other.Antenna)
            {
                return false;
            }
            if (Cannon != other.Cannon)
            {
                return false;
            }
            if (DopBuilding != other.DopBuilding)
            {
                return false;
            }
            return true;
            
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Warship shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }

        public new bool hasNext()
        {
            return (currentIndex++ < 7);
        }

        public new String next()
        {
            return objectProperties.Find(currentIndex).ToString();
        }

        public new void remove()
        {
            objectProperties.Remove(currentIndex);
        }

        public new IEnumerator<Object> iterator()
        {
            foreach (var i in objectProperties)
            {
                yield return i;
            }
        }
    }
}
