using System;

namespace CapgeminiDDD.Common.Model
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public int Id { get; set; }
        public String Name { get; set; }

        public String Surname { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here

            Student student = obj as Student;
            throw new NotImplementedException();
            return this.Name == student.Name && this.Surname == student.Surname;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}