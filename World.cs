using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AdvanceAsignment.Monsters;


namespace AdvanceAsignment
{

    public class World
    {

        public int XCord { get; set; }
        public int YCord { get; set; }
        private List<WorldObject> WorldObjects = new List<WorldObject>();

        public int Xworld; //private? Prop yes

        public int Yworld; //private? Prop yes

        private XmlDocument configFile = new XmlDocument();


        private static World _instance;

        public static World Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new World();
                }
                return _instance;
            }
        }        

        public bool IsInsideWorld(Position position)
        {
            if (position.X > XCord || position.Y > YCord)
            {
                return false;
            }
            return true;
        }

        public void AddObjectToWorld(WorldObject worldObject)
        {
            WorldObjects.Add(worldObject);
        }

        public void RemoveObjectFromWorld(WorldObject worldObject)
        {
            WorldObjects.Remove(worldObject);
        }

        public List<Monster> GetCreaturesInWorld()
        {
            return new List<Monster>(WorldObjects.OfType<Monster>().ToList());
        }

        private World()
        {
            configFile.Load("ConfigFile");
            XmlNode nameNode = configFile.DocumentElement.SelectSingleNode("Name");
            XmlNode xNode = configFile.DocumentElement.SelectSingleNode("Xworld");
            XmlNode yNode = configFile.DocumentElement.SelectSingleNode("Yworld");

        }

    }
}
