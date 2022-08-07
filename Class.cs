using PracticeC.Exceptions;
namespace PracticeC
{

    public class Class
    {

        public Class(string classId)
        {
            ClassId = classId;
            Students = new List<Student>();
        }

        public string ClassId { get; private set; }
        public List<Student> Students { get; private set; }

        public List<Student> GetStudentsOrderedByMarks()
        {
            return Students.OrderByDescending(item => item.GetAvgMark()).ToList();
        }

        public IEnumerable<Student> GetFailingStudents()
        {
            return Students.Where(item => item.GetAvgMark() <= 3);
        }

        public void AddStudent(string name)
        {
            Student student = new(name, new List<Mark>());
            Students.Add(student);
        }

        // Find first student by name
        public Student GetStudent(string name)
        {
            Student desired = Students.Find(s => s.Name == name);
            if (desired == null)
            {
                throw new StudentNotFoundException($"Student with name {name} was not found ");
            }
            return desired;
        }

        public void DeleteStudent(string name)
        {
            Student student = Students.FirstOrDefault(s => s.Name == name);

            if (student == null)
            {
                throw new StudentNotFoundException($"Student with name {name} was not found ");
            }
            Students.Remove(student);
        }
    }
}