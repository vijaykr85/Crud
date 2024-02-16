using Crud.Models;
using Microsoft.AspNetCore.Mvc;


namespace Crud.Controllers
{
    public class CrudController : Controller
    {
        private readonly CrudDbContext _dbContext;

        public CrudController(CrudDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            var data= _dbContext.StudentDetails.ToList();

            return Json(data);
        }

        public IActionResult CreateData(Student stu)
        {

            _dbContext.StudentDetails.Add(stu);
            _dbContext.SaveChanges();

            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult DeleteData(Student stu)
        {
            _dbContext.StudentDetails.Remove(stu);
            _dbContext.SaveChanges();

            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult UpdateData(Student stud)
        {
            _dbContext.StudentDetails.Update(stud);
            _dbContext.SaveChanges();

            return Json(new { success = true });
        }

        // GET: CustumersController/Details/5


        //public ActionResult Details(int Roll)
        //{
        //    var data = _dbContext.Students.Find(Roll);
        //    return View(data);
        //}

        // GET: CustumersController/Create


        public ActionResult Create()
        {
            return View();
        }



    }
}
