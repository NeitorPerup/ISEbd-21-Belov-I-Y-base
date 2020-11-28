using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShip
{
    public class ShipMoorException : Exception
    {
        public ShipMoorException() : base("Не удалось пришвартовать корабль, возможно док переполнен!") { }
    }
}
