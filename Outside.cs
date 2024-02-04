using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_House
{
    class Outside:Location
    {
        public Outside(string name, bool hot): base(name)
        {
            this.Hot = hot;
        }
        public bool Hot;

        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (this.Hot)
                {
                    newDescription = $"It's very hot here";
                }
                return newDescription;
            }
        }
            
        
    }
}
