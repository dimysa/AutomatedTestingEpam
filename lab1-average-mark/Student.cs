using System.Collections.Generic;

namespace TestProject
{
    public class Student: IAverage
    {
        public List<Subject> Subjects {get; set;}

        public Student()
        {
            Subjects = new List<Subject>();
        }

        public double GetAverage()
        {
            double result = 0;
            foreach (var item in Subjects)
            {
                result += item.Mark;
            }

            return result / Subjects.Count;
        }
    }
}