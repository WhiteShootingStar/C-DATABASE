using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wind1.Std
{
   public class Student
    {
        

        public int ID { get; set; }
        public string LastName{ get; set; }
        public string FirstName { get; set; }
        public string Index{ get; set; }
        public string Address { get; set; }
        public string Studies { get; set; }
        public IEnumerable<string> Subjects { get; set; }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   ID == student.ID &&
                   LastName == student.LastName &&
                   FirstName == student.FirstName &&
                   Index == student.Index &&
                   Address == student.Address &&
                   Studies == student.Studies &&
                   EqualityComparer<IEnumerable<string>>.Default.Equals(Subjects, student.Subjects);
        }

        public override int GetHashCode()
        {
            var hashCode = -1857087028;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Index);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Studies);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<string>>.Default.GetHashCode(Subjects);
            return hashCode;
        }

        public override string ToString()
        {
            return FirstName + " " + FirstName + " " +Studies;
        }
    }
}
