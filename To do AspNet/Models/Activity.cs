namespace To_do_AspNet.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatAt { get; set; }
        public DateTime DateLimit { get; set; }
        public int Daysleft => (DateLimit-DateTime.Now).Days;

        public Activity() { }

        public Activity(int id, string title, string description, bool isCompleted, DateTime creatAt, DateTime dateLimit )
        {
            Id = id;
            Title = title;
            Description = description;
            CreatAt = creatAt;
            DateLimit = dateLimit;
         
        }

   
    }

  




}
