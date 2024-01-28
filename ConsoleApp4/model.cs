using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{    
        public class Model
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Description { get; set; }

            public Model(string name, int age, string description)
            {
                Name = name;
                Age = age;
                Description = description;
            }
        }    
}
