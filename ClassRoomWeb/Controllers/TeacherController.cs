using ClassRoomWeb.Interface;
using ClassRoomWeb.Models;
using ClassRoomWeb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Controllers
{
    public class TeacherController : Controller
    {
        static readonly IPersionManage<TeacherModel> _TeacherService = new TeacherService();
        internal static IPersionManage<TeacherModel> TeacherService => _TeacherService;
        // GET: TeacherController
        public ActionResult Index()
        {
            return View(TeacherService.Get());
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeacherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeacherModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TeacherService.Create(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: TeacherController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, TeacherModel collection)
        {
            try
            {
                TeacherService.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
