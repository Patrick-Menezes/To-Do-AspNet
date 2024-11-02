using Microsoft.AspNetCore.Mvc;
using To_do_AspNet.Models;
using To_do_AspNet.Data;
using To_do_AspNet.services;
using Microsoft.AspNetCore.Authentication;
namespace To_do_AspNet.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ActivityServices _activityServices;

     public ActivityController(ActivityServices tasksServices)
        {
            _activityServices = tasksServices;
        }

        public IActionResult Index()
        {

            var list = _activityServices.FindAll();
            return View(list);

        }

        public IActionResult newTask()
        {
            return View();

        }


        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult AddTask(Activity task)
        {
            _activityServices.AddActivity(task);
            return RedirectToAction(nameof(Index));

        }


        public IActionResult Edit(int id)
        { 
            if(id == null)
            {
                return NotFound();
            }

            var obj = _activityServices.GetActivity(id);
            if (obj == null) 
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _activityServices.GetActivity(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int id)
        {
            _activityServices.Remove(id);
            return RedirectToAction(nameof(Index));

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id,Activity activity)
        {

            if (id != activity.Id) { return BadRequest(); }


            _activityServices.Update(activity);
            return RedirectToAction(nameof(Index));


        }


    }
}
