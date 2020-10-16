using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShip
{
    class DockCollection
    {
        readonly Dictionary<string, Dock<Vehicle>> dockStages;

        public List<string> Keys => dockStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public DockCollection(int pictureWidth, int pictureHeight)
        {
            dockStages = new Dictionary<string, Dock<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddDock(string name)
        {
            if (dockStages.ContainsKey(name))
            {
                return;
            }
            dockStages.Add(name, new Dock<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelDock(string name)
        {
            if (dockStages.ContainsKey(name))
            {
                dockStages.Remove(name);
            }
        }

        public Dock<Vehicle> this[string ind]
        {
            get
            {
                return dockStages[ind];
            }
        }
    }
}
