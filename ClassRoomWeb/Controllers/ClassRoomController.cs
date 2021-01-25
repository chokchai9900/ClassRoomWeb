using ClassRoomWeb.Interface;
using ClassRoomWeb.Models;
using ClassRoomWeb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZXing;
using ZXing.QrCode;

namespace ClassRoomWeb.Controllers
{
    public class ClassRoomController : Controller
    {
        static readonly IClassRoomRepository<ClassRoomModel> _ClassRoomservice = new ClassRoomService();
        internal static IClassRoomRepository<ClassRoomModel> ClassRoomservice => _ClassRoomservice;

        // GET: ClassRoomController
        public ActionResult Index()
        {
            return View(ClassRoomservice.GetClassRoom());
        }

        // GET: ClassRoomController/Details/5
        public ActionResult Details(string id)
        {
            var qrcodeText = $"localhost:44325{Request.Path.Value}" ;
            if (id == null)
            {
                return NotFound();
            }

            var data = ClassRoomservice.GetDataByClassRoomId(id);
            if (data == null)
            {
                return NotFound();
            }

            var options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

            using (MemoryStream memory = new MemoryStream())
            {
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(qrcodeText));
                using (Bitmap bitMap = result)
                {
                    bitMap.Save(memory, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(memory.ToArray());
                }
            }

            return View(data);
        }


        // GET ClassRoomController/checkIn
        public ActionResult checkIn()
        {
            return View();
        }

        // POST: ClassRoomController/checkIn
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult checkIn(string id, StudentModel std)
        {
            var data = ClassRoomservice.GetDataByClassRoomId(id);
            if (data == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (std != null)
                {
                    ClassRoomservice.AddStudentInClassByClassRoomIdAsync(id, std);
                }
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View(std);
            }
        }

        // GET: ClassRoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassRoomModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClassRoomservice.CreateClassRoom(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassRoomController/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = ClassRoomservice.GetDataByClassRoomId(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        // POST: ClassRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, ClassRoomModel collection, string idTeacher, string idStudent,string nameStudent)
        {
            var createStd = new StudentModel()
            {
                studentId = idStudent,
                studentName = nameStudent,
                checkInAt = DateTime.Now
            };
            var data = ClassRoomservice.GetDataByClassRoomId(id);
            if (data == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (idTeacher != null)
                {
                    ClassRoomservice.AddTeacherInClassByClassRoomId(id, idTeacher);
                }
                if (idStudent != null && nameStudent != null)
                {
                    ClassRoomservice.AddStudentInClassByClassRoomIdAsync(id, createStd);
                }
                var validCondition = (collection.classRoomName != null || collection.classRoomSubject != null || collection.classRoomDiscription != null);
                if (validCondition)
                {
                    ClassRoomservice.Edit(id, collection);
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(collection);
            }
        }

        // GET: ClassRoomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassRoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            ClassRoomservice.RemoveClassRoom(id);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
