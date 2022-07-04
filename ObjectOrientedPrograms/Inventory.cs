using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class Inventory
    {
        public List<Details> TypesOfRice { get; set; }
        public List<Details> TypesOfGrains { get; set; }
        public List<Details> TypesOfWheats { get; set; }
    }


    public class Details
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }

}
