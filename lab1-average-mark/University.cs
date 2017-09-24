using System.Collections.Generic;

namespace TestProject
{
    public class University: IAverage
    {
        public List<Faculty> Faculties {get; set;}
        public University()
        {
            Faculties = new List<Faculty>();
        }
        public double GetAverage()
        {
            double result = 0;
            foreach (var item in Faculties)
            {
                result += item.GetAverage();
            }
            return result / Faculties.Count;
        }
    }
}