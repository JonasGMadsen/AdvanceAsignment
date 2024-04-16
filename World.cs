using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AdvanceAsignment.Monsters;
using AdvanceAsignment.TraceAndLog;


namespace AdvanceAsignment
{

    public class World
    {
        //World name
        public string Name { get; set; }
        // X axis
        public int XCord { get; set; }
        // Y axis
        public int YCord { get; set; }

        //List of all objects in world
        private List<WorldObject> WorldObjects = new List<WorldObject>();

        // Used for the X axis in config
        public int Xworld;

        // Used for the Y axis in config
        public int Yworld; 

        //For loading the config file
        private XmlDocument configFile = new XmlDocument();

        #region
        //Singleton instance
        private static World _instance;

        //Getting the instance
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
        #endregion

        /// <summary>
        /// Checks if a postion is inside the world
        /// </summary>
        /// <param name="position">Position in the world</param>
        /// <returns>True if the position is in the world. Otherwise false</returns>
        public bool IsInsideWorld(Position position)
        {
            if (position.X > XCord || position.Y > YCord)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds an object to the world
        /// </summary>
        /// <param name="worldObject">The object that is to be added to the world</param>
        public void AddObjectToWorld(WorldObject worldObject)
        {
            WorldObjects.Add(worldObject);
        }

        /// <summary>
        ///  Removes an object from the world
        /// </summary>
        /// <param name="worldObject">The object that is removed from the world</param>
        public void RemoveObjectFromWorld(WorldObject worldObject)
        {
            WorldObjects.Remove(worldObject);
        }

        /// <summary>
        /// Gets a list of creatures in the world
        /// </summary>
        /// <returns>Copy of the list of creatures in the world</returns>
        public List<Monster> GetCreaturesInWorld()
        {
            return new List<Monster>(WorldObjects.OfType<Monster>().ToList());
        }

        /// <summary>
        /// Loads the world from the "ConfigFile.xml" file 
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown exception if data is missing in the "ConfigFile.xml" file or it fails to load </exception>
        private World()
        {
            TracingAndLogging.Instance.TraceMethodEntry(nameof(World), "No parameters");

            try
            {
                configFile.Load("ConfigFile.xml");  
                XmlNode nameNode = configFile.DocumentElement.SelectSingleNode("Name");
                XmlNode xNode = configFile.DocumentElement.SelectSingleNode("Xworld");
                XmlNode yNode = configFile.DocumentElement.SelectSingleNode("Yworld");

                if (xNode != null && yNode != null)
                {
                    Name = nameNode.InnerText;
                    Xworld = int.Parse(xNode.InnerText);  
                    Yworld = int.Parse(yNode.InnerText);
                    //Handle the case where the XML is loaded succesfully.
                    TracingAndLogging.Instance.WriteInfoToText("World configuration loaded successfully.");
                }
                else
                {
                    TracingAndLogging.Instance.WriteErrorToText("Critical configuration data missing in XML.");
                    // Handle the case where nodes are missing in the XML.
                    throw new InvalidOperationException("Critical configuration data missing in XML.");
                }
            }
            catch (Exception ex)
            {
                TracingAndLogging.Instance.WriteErrorToText($"Failed to load world configuration: {ex.Message}");
                // Handle other exceptions and possibly log them
                throw new InvalidOperationException("Failed to load world configuration.", ex);
            }
            finally
            {
                TracingAndLogging.Instance.TraceMethodExit(nameof(World), "void");
            }

        }       

    }
}
