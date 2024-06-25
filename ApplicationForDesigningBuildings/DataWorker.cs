using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForDesigningBuildings
{
    internal static class DataWorker
    {
        public static List<BuildingFrame> DataBuildingFrame = new List<BuildingFrame>();
        public static List<Door> DataDoor = new List<Door>();
        public static List<DoorHandle> DataDoorHandle = new List<DoorHandle>();
        public static List<Roof> DataRoof = new List<Roof>();
        public static List<Window> DataWindow = new List<Window>();
        public static List<WindowCasement> DataWindowCasement = new List<WindowCasement>();
        public static List<PictureBox> DataPictureBox = new List<PictureBox>();
        public static List<Panel> DataPanel = new List<Panel>();

        public static string NameLastChangingPanel = string.Empty;
        public static Panel LastChangingPanel = null;
    }
}
