using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NLog;

namespace FormShip
{
    class DockCollection
    {
        readonly Dictionary<string, Dock<Vehicle>> dockStages;

        private readonly Logger logger;

        public List<string> Keys => dockStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public DockCollection(int pictureWidth, int pictureHeight)
        {
            dockStages = new Dictionary<string, Dock<Vehicle>>();
            logger = LogManager.GetCurrentClassLogger();
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
                        sw.WriteLine($"Dock{separator}{level.Key}");
                        ITransport ship = null;
                        for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                        {
                            if (ship != null)
                            {
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
                logger.Warn("Выбран неверный файл для загрузки!");
                throw new FileNotFoundException();
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
                    logger.Warn("Выбран неверный формат файла!");
                    throw new FormatException("Неверный формат файла");
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
                            logger.Warn("При загрузке файла вызвано исключение DockOccupiedPlaceException");
                            throw new DockOccupiedPlaceException();
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            return true; 
        }
    }
}
