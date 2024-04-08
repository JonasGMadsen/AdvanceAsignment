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
 

        public List<Monster> MonstersList;
        public List<WorldObject> ObjectList;


        public int XCord { get; set; }
        public int YCord { get; set; }

        public Wolf Wolf { get; set; }

        public World(int xCordinates, int yCordinate)
        {
            MonstersList = new List<Monster>();
            ObjectList = new List<WorldObject>();
            XCord = xCordinates;
            YCord = yCordinate;
        }


        public string GetSquareContent(int x, int y)
        {     

            // Check if there is a wolf at this position
            if (Wolf.X == x && Wolf.Y == y)
            {
                return "[R]";
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
