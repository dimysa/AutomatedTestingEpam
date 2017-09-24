using System.Collections.Generic;

namespace TestProject
{
    public class Group: IAverage
    {
        public List<Student> Students {get; set;}
        public Group()
        {
            Students = new List<Student>();
        }
        public double GetAverage()
        {
            double result = 0;
            foreach (var item in Students)
            {
                result += item.GetAverage();
            }
            return result / Students.Count;
        }
    }
}