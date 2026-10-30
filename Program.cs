using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTBIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person[] people = new person[5];
            people[0] = new person("Nam", 176, 85, true);
            people[1] = new person("Tan", 154, 60, true);
            people[2] = new person("Nien", 181, 75, true);
            people[3] = new person("Linh", 167, 60, false);
            people[4] = new person("Hoang", 170, 70, true);
            for (int i = 0; i <= 4; i++)
                    {
                       Console.WriteLine(people[i].name + "\t" + people[i].height + "\t" + people[i].weight + "\t" + people[i].isMale);
                    }
            Character Ryan= new Character("Ryan",200 );
            Console.WriteLine(Ryan.Health.ToString() + Ryan.Name);

        }
    }
}