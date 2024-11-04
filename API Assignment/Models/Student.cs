namespace API_Assignment.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }   

        public Student() { }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}
