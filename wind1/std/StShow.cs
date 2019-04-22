using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wind1
{
  public  class StShow
    {
        public int id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string IndexNumber { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int IDStudies { get; set; }

        public override string ToString()
        {
            return id + " " + LastName + " " + FirstName + " " + IndexNumber + " " + Address + " " + Name + " " + IDStudies;
        }
    }

   
}
