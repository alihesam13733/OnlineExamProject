using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using OnlineExam.Models.Accounting;
using OnlineExam.ServiceLayer.Interfaces;
using OnlineExam.Utilities;
using OnlineExam.Utilities.PersianCaptcha;
using OnlineExam.ViewModels.Accounting;

namespace OnlineExam.Client.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IUserSevice _userSevice;
        //private readonly IRoleService _roleService;
        //private readonly IGenderService _genderService;
        //private readonly IDegreeService _degreeService;
        //private readonly IFieldStudyService _fieldStudyService;

        //public AccountController(IUserSevice userSevice, IRoleService roleService, IGenderService genderService, IDegreeService degreeService, IFieldStudyService fieldStudyService)
        //{
        //    _userSevice = userSevice;
        //    _roleService = roleService;
        //    _degreeService = degreeService;
        //    _fieldStudyService = fieldStudyService;
        //    _genderService = genderService;

        //}

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Registration()
        {
            try
            {
                UserViewModel userViewModel = new UserViewModel();
                // ViewBag.Degrees = _degreeService.GetAllDegrees();
                // ViewBag.Genders = _genderService.GetAllGenders();
                //ViewBag.FieldStudies = _fieldStudyService.GetAllFieldStudies();
                return View();

            }
            catch (Exception ex)
            {

                return View(MVC.Shared.Views.Error);
            }

        }

        [HttpPost]
        public ActionResult Registration(Registration registration)
        {
            try
            {
                UserViewModel userViewModel = new UserViewModel();
                // ViewBag.Degrees = _degreeService.GetAllDegrees();
                // ViewBag.Genders = _genderService.GetAllGenders();
                //ViewBag.FieldStudies = _fieldStudyService.GetAllFieldStudies();
                return View();

            }
            catch (Exception ex)
            {

                return View(MVC.Shared.Views.Error);
            }

        }

        [NoBrowserCache]
        public ActionResult Login()
        {
            try
            {
                UserViewModel userViewModel = new UserViewModel();
                // ViewBag.Degrees = _degreeService.GetAllDegrees();
                // ViewBag.Genders = _genderService.GetAllGenders();
                //ViewBag.FieldStudies = _fieldStudyService.GetAllFieldStudies();
                return View();

            }
            catch (Exception ex)
            {

                return View(MVC.Shared.Views.Error);
            }

        }

        [HttpPost, ValidateCaptchaAttribute, ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            try
            {
                if (!ModelState.IsValid) return View();
              
                UserViewModel userViewModel = new UserViewModel();
                // ViewBag.Degrees = _degreeService.GetAllDegrees();
                // ViewBag.Genders = _genderService.GetAllGenders();
                //ViewBag.FieldStudies = _fieldStudyService.GetAllFieldStudies();
                return View();

            }
            catch (Exception ex)
            {

                return View(MVC.Shared.Views.Error);
            }

        }

        
    }
}
