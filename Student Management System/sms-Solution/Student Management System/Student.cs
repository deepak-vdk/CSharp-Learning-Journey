namespace Student_Management_System
{
    class Student
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public  int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public enum Grade
        {
            F,
            C,
            B,
            A
        }
        private Grade studGrade;

        //private char Grade;
        public Grade StudGrade
        {
            get { return studGrade; }
            set { studGrade = value; }
        }
        public override string ToString()
        {
            return $"Student Name: {Name}, Age:{Age}, Id: {Id}, Grade: {StudGrade}";
        }
    }

}
