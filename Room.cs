using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_House
{
    class Room:Location
    {
        public Room(string name, string decoration) : base(name)
        {
            this.Decoration = decoration;
        }
        public string Decoration;
        public override string Description
        {
            get
            {
                string newString = $"You see {this.Decoration} here";
                return newString;
            }
        }
    }
}
