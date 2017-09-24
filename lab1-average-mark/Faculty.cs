using System.Collections.Generic;

namespace TestProject
{
    public class Faculty: IAverage
    {
        public List<Group> Groups {get; set;}
        public Faculty()
        {
            Groups = new List<Group>();
        }
        public double GetAverage()
        {
            double result = 0;
            foreach (var item in Groups)
            {
                result += item.GetAverage();
            }
            return result / Groups.Count;
        }
    }
}