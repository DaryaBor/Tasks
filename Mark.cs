using PracticeC.Exceptions;
namespace PracticeC
{
    public class Mark
    {
        public Mark(int value, string className, DateTime date)
        {
            if (date.ToString() == null || value == 0)
            {
                throw new ArgumentNullException("received a null argument");
            }
            if (value < 0 || value > 5)
            {
                throw new ArgumentOutOfRangeException("invalid mark value");
            }

            if (value is int != true)
            {
                throw new ValueWrongTypeException("A type mismatch occurred");
            }
            Value = value;
            ClassName = className;
            Date = date;
        }


        public int Value { get; private set; }
        public string ClassName { get; private set; }
        public DateTime Date { get; private set; }


    }
}