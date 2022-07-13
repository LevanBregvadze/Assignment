namespace Task7.Models
{
    public class Teacher_Pupil
    {
        public int Id { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
        public int PupilId { get; set; }

        public Pupil Pupil { get; set; }



        
    }
}
