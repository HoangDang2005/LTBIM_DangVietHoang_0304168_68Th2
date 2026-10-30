using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTBIM
{
    public class person
    {
        public string name;
        public int height;
        public int weight;
        public bool isMale;

        public person(string name, int height, int weight, bool isMale )
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.isMale = isMale;
        }

    }
}
