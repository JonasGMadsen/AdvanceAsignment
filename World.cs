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

        public int XCord { get; set; }
        public int YCord { get; set; }
        private List<WorldObject> WorldObjects = new List<WorldObject>();

        public int Xworld; //private? Prop yes

        public int Yworld; //private? Prop yes

        private XmlDocument configFile = new XmlDocument();

        #region
        //Singleton Instance
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
            TracingAndLogging.Instance.TraceMethodEntry(nameof(World), "No parameters");

            try
            {
                configFile.Load("ConfigFile.xml");  
                XmlNode nameNode = configFile.DocumentElement.SelectSingleNode("Name");
                XmlNode xNode = configFile.DocumentElement.SelectSingleNode("Xworld");
                XmlNode yNode = configFile.DocumentElement.SelectSingleNode("Yworld");

                if (xNode != null && yNode != null)
                {
                    Xworld = int.Parse(xNode.InnerText);  
                    Yworld = int.Parse(yNode.InnerText);
                    //Handle the case where the XML is loaded succesfully
                    TracingAndLogging.Instance.WriteInfoToText("World configuration loaded successfully.");
                }
                else
                {
                    TracingAndLogging.Instance.WriteErrorToText("Critical configuration data missing in XML.");
                    // Handle the case where nodes are missing in the XML
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
