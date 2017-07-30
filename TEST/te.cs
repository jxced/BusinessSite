using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
     public class te
    {
        private string name;
        private int id;
        public te()
        {
            this.id = 10;
            this.name = "tom";
        }
        public void SayHello()
        {
            Console.WriteLine("My name is {0},studentID:{1}",name,id);
        }
    }
}
