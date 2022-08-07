namespace PracticeC
{
    public class Student
    {
        public Student(string name, List<Mark> marks)
        {
            Name = name;
            Marks = marks;

        }

        public string Name { get; private set; }
        public List<Mark> Marks { get; private set; }

        public double GetAvgMark()
        {
            if (Marks != null)
            {
                return Marks.Average(x => x.Value);
            }
            else
            {
                return 0;
            }
        }

        public void AddMark(Mark mark)
        {
            Marks.Add(mark);
        }

    }
}