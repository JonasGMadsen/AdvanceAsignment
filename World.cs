using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment.Factory;
using AdvanceAsignment.Monsters;


namespace AdvanceAsignment
{

    public class World
    {

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


        public List<Monster> MonstersList;
        public List<WorldObject> ObjectList;


        public int XCord { get; set; }
        public int YCord { get; set; }


        public World(int xCordinates, int yCordinate)
        {
            MonstersList = new List<Monster>();
            ObjectList = new List<WorldObject>();
            XCord = xCordinates;
            YCord = yCordinate;
        }


        public void AddMonster(string type, string name, int hitPoints, int x, int y)
        {
            Monster monster = MonsterFactory.CreateMonster(type, name, hitPoints, x, y);
            MonstersList.Add(monster);
        }

        public string GetSquareContent(int x, int y)
        {
            foreach (var monster in MonstersList)
            {
                if (monster.X == x && monster.Y == y)
                {
                    return "[M]"; // Generic representation for a Monster
                }
            }
            return "[ ]";
        }

        public void PrintGameMap()
        {
            Console.Clear();

            for (int y = 0; y < YCord; y++)
            {
                for (int x = 0; x < XCord; x++)
                {
                    string squareContent = GetSquareContent(x, y);
                    Console.Write(squareContent);
                }
                Console.WriteLine();
            }
        }
    }
}
