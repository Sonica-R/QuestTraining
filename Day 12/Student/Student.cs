namespace Student
{
    class Student
    {
        public string StudentName;
        public string StudentId;
        public string Class;
        public string Subject;
        public int Mark;
        public string TotalMarks;
        public override string ToString()
        {
            return $"Student Name: {StudentName}, Student ID: {StudentId}, Class: {Class}";
        }
    }
}
