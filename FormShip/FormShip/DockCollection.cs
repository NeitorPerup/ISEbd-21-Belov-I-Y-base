using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FormShip
{
    class DockCollection
    {
        readonly Dictionary<string, Dock<Vehicle>> dockStages;

        public List<string> Keys => dockStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

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
                if (dockStages.ContainsKey(ind))
                {
                    return dockStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"DockCollection");

                    foreach (var level in dockStages)
                    {
                        //Начинаем парковку
                        sw.WriteLine($"Dock{separator}{level.Key}");
                        ITransport ship = null;
                        for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                        {
                            if (ship != null)
                            {
                                //если место не пустое
                                //Записываем тип машины
                                if (ship.GetType().Name == "Ship")
                                {
                                    sw.Write($"Ship{separator}");

                                }
                                if (ship.GetType().Name == "Warship")
                                {
                                    sw.Write($"Warship{separator}");
                                }
                                //Записываемые параметры
                                sw.WriteLine(ship);

                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("DockCollection"))
                {
                    //очищаем записи
                    dockStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }

                line = sr.ReadLine();
                Vehicle ship = null;
                string key = string.Empty;
                while (line != null && line.Contains("Dock"))
                {
                    key = line.Split(separator)[1];
                    dockStages.Add(key, new Dock<Vehicle>(pictureWidth,
                    pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Ship") || line.Contains("Warship")))
                    {
                        if (line.Split(separator)[0] == "Ship")
                        {
                            ship = new Ship(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Warship")
                        {
                            ship = new Warship(line.Split(separator)[1]);
                        }
                        var result = dockStages[key] + ship;
                        if (!result)
                        {
                            return false;
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            return true; 
        }
    }
}
