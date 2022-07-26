using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PassportMvcCoreCRUD.Areas.Identity.Data;
using PassportMvcCoreCRUD.Models;
using System.Diagnostics;

namespace PassportMvcCoreCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PassportMvcCoreCRUDContext _pass;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, PassportMvcCoreCRUDContext pass, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _pass = pass;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        //===================== Select ==================================
        public IActionResult Select()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Account", "Identity");
            }
        }

        [HttpPost]
        public IActionResult Select(IFormCollection col)
        {
            string opt = col["opt"];
            if (opt == "1")
            {
                return RedirectToAction("Create");
            }
            else if (opt == "2")
            {
                //string file_num = col["file_num"];
                var file_num = HttpContext.Session.GetString("file_num");
                file_num = col["file_num"];
                return RedirectToAction("Edit", "Home", new { file_num = file_num });
            }
            else if (opt == "3")
            {
                string file_num = col["file_num"];
                //HttpContext.Session.GetString("file_num") = col["file_num"];
                return RedirectToAction("Details", "Home", new { file_num = file_num });
            }
            else
            {
                ViewBag.error = "Select the radio button";
            }
            return View();
        }


        //===================== Create ==================================
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult Create(CustomList customList)
        {        
            string uniqueFileName = null;
            if (customList.Pass1.photoDeatils != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + customList.Pass1.photoDeatils.FileName;
                string filepath = Path.Combine(uploadFolder, uniqueFileName);
                customList.Pass1.photoDeatils.CopyTo(new FileStream(filepath, FileMode.Create));
            }

            string uniqueFileName1 = null;
            if (customList.Pass1.SignDeatils != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName1 = Guid.NewGuid().ToString() + "_" + customList.Pass1.SignDeatils.FileName;
                string filepath = Path.Combine(uploadFolder, uniqueFileName1);
                customList.Pass1.SignDeatils.CopyTo(new FileStream(filepath, FileMode.Create));
            }
            string uniqueFileName2 = null;
            if (customList.Pass9.sd_signDeatils != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName2 = Guid.NewGuid().ToString() + "_" + customList.Pass9.sd_signDeatils.FileName;
                string filepath = Path.Combine(uploadFolder, uniqueFileName2);
                customList.Pass9.sd_signDeatils.CopyTo(new FileStream(filepath, FileMode.Create));
            }
            customList.Pass1.photo = uniqueFileName;
            customList.Pass1.Sign = uniqueFileName1;
            customList.Pass9.sd_sign = uniqueFileName2;

            customList.Pass2.file_num = customList.Pass1.file_num;
            customList.Pass3.file_num = customList.Pass1.file_num;
            customList.Pass4.file_num = customList.Pass1.file_num;
            customList.Pass5.file_num = customList.Pass1.file_num;
            customList.Pass6.file_num = customList.Pass1.file_num;
            customList.Pass7.file_num = customList.Pass1.file_num;
            customList.Pass8.file_num = customList.Pass1.file_num;
            customList.Pass9.file_num = customList.Pass1.file_num;

                _pass.Add(customList.Pass1);          
                _pass.Add(customList.Pass2);
                _pass.Add(customList.Pass3);
                _pass.Add(customList.Pass4);
                _pass.Add(customList.Pass5);
                _pass.Add(customList.Pass6);
                _pass.Add(customList.Pass7);
                _pass.Add(customList.Pass7);
                _pass.Add(customList.Pass8);
                _pass.Add(customList.Pass9);
                _pass.SaveChanges();
            
            return View();

        }
        //===================== Edit ==================================
        public IActionResult Edit(string file_num)
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                CustomList model = new CustomList();
                //dynamic model = new ExpandoObject();
                model.Pass1 = _pass.s1.Find(file_num);
                model.Pass2 = _pass.s2.Find(file_num);
                model.Pass3 = _pass.s3.Find(file_num);
                model.Pass4 = _pass.s4.Find(file_num);
                model.Pass5 = _pass.s5.Find(file_num);
                model.Pass6 = _pass.s6.Find(file_num);
                model.Pass7 = _pass.s7.Find(file_num);
                model.Pass8 = _pass.s8.Find(file_num);
                model.Pass9 = _pass.s9.Find(file_num);
                return View(model);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult Edit(CustomList model)
        {
            string uniqueFileName = null;
            if (model.Pass1.photoDeatils != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Pass1.photoDeatils.FileName;
                string filepath = Path.Combine(uploadFolder, uniqueFileName);
                model.Pass1.photoDeatils.CopyTo(new FileStream(filepath, FileMode.Create));
            }

            string uniqueFileName1 = null;
            if (model.Pass1.SignDeatils != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName1 = Guid.NewGuid().ToString() + "_" + model.Pass1.SignDeatils.FileName;
                string filepath = Path.Combine(uploadFolder, uniqueFileName1);
                model.Pass1.SignDeatils.CopyTo(new FileStream(filepath, FileMode.Create));
            }
            string uniqueFileName2 = null;
            if (model.Pass9.sd_signDeatils != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName2 = Guid.NewGuid().ToString() + "_" + model.Pass9.sd_signDeatils.FileName;
                string filepath = Path.Combine(uploadFolder, uniqueFileName2);
                model.Pass9.sd_signDeatils.CopyTo(new FileStream(filepath, FileMode.Create));
            }

            model.Pass1.photo = uniqueFileName;
            model.Pass1.Sign = uniqueFileName1;
            model.Pass9.sd_sign = uniqueFileName2;
            model.Pass2.file_num = model.Pass1.file_num;
            model.Pass3.file_num = model.Pass1.file_num;
            model.Pass4.file_num = model.Pass1.file_num;
            model.Pass5.file_num = model.Pass1.file_num;
            model.Pass6.file_num = model.Pass1.file_num;
            model.Pass7.file_num = model.Pass1.file_num;
            model.Pass8.file_num = model.Pass1.file_num;
            model.Pass9.file_num = model.Pass1.file_num;

            _pass.s1.Update(model.Pass1);
            //HttpContext.Session.SetString("file_num", model.Pass1.file_num);
            _pass.s2.Update(model.Pass2);
            _pass.s3.Update(model.Pass3);
            _pass.s4.Update(model.Pass4);
            _pass.s5.Update(model.Pass5);
            _pass.s6.Update(model.Pass6);
            _pass.s7.Update(model.Pass7);
            _pass.s8.Update(model.Pass8);
            _pass.s9.Update(model.Pass9);
            _pass.SaveChanges();

            return View();
        }

        [Authorize(Roles = "Admin")]
        //===================== Details ==================================
        public IActionResult Details(string file_num)
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                CustomList model = new CustomList();
                //dynamic model = new ExpandoObject();
                model.Pass1 = _pass.s1.Find(file_num);
                model.Pass2 = _pass.s2.Find(file_num);
                model.Pass3 = _pass.s3.Find(file_num);
                model.Pass4 = _pass.s4.Find(file_num);
                model.Pass5 = _pass.s5.Find(file_num);
                model.Pass6 = _pass.s6.Find(file_num);
                model.Pass7 = _pass.s7.Find(file_num);
                model.Pass8 = _pass.s8.Find(file_num);
                model.Pass9 = _pass.s9.Find(file_num);
                return View(model);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        //===================== Select ==================================

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}