using System;

namespace TestProject
{
    public class Subject
    {
        public string Name {get;set;}
        public int Mark {get;set;}

        public Subject(string name, int mark)
        {
            this.Name = name;
            this.Mark = mark;
        }

        public Subject()
        {
            Name = "Test";
            Mark = new Random().Next(1, 10);
        }
    }
}