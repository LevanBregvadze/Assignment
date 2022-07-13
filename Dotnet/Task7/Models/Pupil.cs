namespace Task7.Models
{
    public class Pupil
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string sex { get; set; }
        public string className { get; set; }

        public List<Teacher_Pupil> Teacher_Pupils { get; set; }
    }
}
