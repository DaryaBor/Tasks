using PracticeC.Exceptions;
namespace PracticeC.Exceptions
{ 
public class ValueWrongTypeException : Exception
{
    public ValueWrongTypeException() { }
    public ValueWrongTypeException(string message)
         : base(message) { }
}
    public class StudentNotFoundException : ArgumentException
    {
        public StudentNotFoundException(string studentName) : base($"Student with name {studentName} was not found") { }
    }

    public class UncorrectMarkException : ArgumentException
    {
        public UncorrectMarkException() : base("Invalid mark value") { }
    }
    public class NullMarkException : ArgumentException
    {
        public NullMarkException() : base("Received a null argument") { }
    }
}

}

