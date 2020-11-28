using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShip
{
    public class DockOccupiedPlaceException : Exception
    {
        public DockOccupiedPlaceException() : base("Не удалось загрузить док") { }
    }
}
