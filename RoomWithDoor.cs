using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_House
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            this.DoorDescription = doorDescription;
        }
        private string doorDescription;
        public string DoorDescription { 
            get {return this.doorDescription; }
            set { this.doorDescription = value; }
        }

        private Location doorLocation;
        public Location DoorLocation {
            get { return this.doorLocation; }
            set { this.doorLocation = value; }
        }
    }
}
