using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment.Monsters;


namespace AdvanceAsignment
{

    public class World
    {

        public int XCord { get; set; }
        public int YCord { get; set; }
        private List<WorldObject> WorldObjects = new List<WorldObject>();


        private static World _instance;

        public static World Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new World(50, 50);
                }
                return _instance;
            }
        }

        public World(int xCordinates, int yCordinates)
        {
            XCord = xCordinates;
            YCord = yCordinates;
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

    }
}
