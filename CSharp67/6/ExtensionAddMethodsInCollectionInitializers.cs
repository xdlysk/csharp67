using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._6
{
    class ExtensionAddMethodsInCollectionInitializers
    {
        Enrollment classList = new Enrollment()
            {
                new Student("Lessie", "Crosby"),
                new Student("Vicki", "Petty"),
                new Student("Ofelia", "Hobbs")
            };
    }

    public class Enrollment : IEnumerable<Student>
    {
        private List<Student> allStudents = new List<Student>();

        public void Enroll(Student s)
        {
            allStudents.Add(s);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return ((IEnumerable<Student>)allStudents).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Student>)allStudents).GetEnumerator();
        }
    }

    public class Student
    {
        private string v1;
        private string v2;

        public Student(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    public static class StudentExtensions
    {
        public static void Add(this Enrollment e, Student s) => e.Enroll(s);
    }
}
