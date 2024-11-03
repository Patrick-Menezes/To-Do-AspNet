using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using To_do_AspNet.Data;
using To_do_AspNet.Models;
namespace To_do_AspNet.services
{
    public class ActivityServices
    {
        private readonly To_do_AspNetContext _context;


        public ActivityServices (To_do_AspNetContext context)
        {
            _context = context;
        }

        public List<Activity> FindAll()
        {



           var list= _context.Activity.ToList();
         
            return list;


        }

 
   




        public void AddActivity(Activity task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public Activity GetActivity(int id) 
        {
            return _context.Activity.FirstOrDefault(x=>x.Id ==id);
        }


    




        public void Remove(int id)
        {
            var obj = _context.Activity.Find(id);
            _context.Activity.Remove(obj);
            _context.SaveChanges();
        }


        public void Update(Activity activity) 
        {
         
            _context.Update(activity);
         _context.SaveChanges();
        
        }




    }
}
