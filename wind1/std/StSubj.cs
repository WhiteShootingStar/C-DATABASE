using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wind1.std
{   [NotMapped]
    public class StSubj : Student
    {

        public virtual IList<Subject> Subject { get; set; }
    }
}
