using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_House
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot) 
        {
            this.DoorDescription = doorDescription;
        }
        private string doorDescription;
        public string DoorDescription
        {
            get { return this.doorDescription; }
            set { this.doorDescription = value; }
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get { return doorLocation; }
            set { this.doorLocation = value; }
        } 
    }
    
}
