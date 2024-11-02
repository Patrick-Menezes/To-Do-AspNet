namespace To_do_AspNet.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatAt { get; set; }

        public Activity() { }

        public Activity(int id, string title, string description, bool isCompleted, DateTime creatAt)
        {
            Id = id;
            Title = title;
            Description = description;       
            CreatAt = creatAt;
        }
    }
}
