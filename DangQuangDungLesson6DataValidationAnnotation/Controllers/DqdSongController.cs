using DangQuangDungLesson6DataValidationAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DangQuangDungLesson6DataValidationAnnotation.Controllers
{
    public class DqdSongController : Controller
    {
        private static List<DqdSong> dqdSongs = new List<DqdSong>()
        {
            new DqdSong{Id=100, Title="DangQuangDung", Author="K22Cntt1", Artist="Nguoi yeu Phuong", YearRelease=2004},
            new DqdSong{Id=101, Title="NguyenKhanhPhuong", Author="K72Ctxh", Artist="Nguoi yeu Dung", YearRelease=2004}

        };
        // GET: DqdSong
        public ActionResult Index()
        {
            return View(dqdSongs);
        }

        public ActionResult DqdCreate()
        {
            var dqdSong = new DqdSong();
            return View();
        }
        [HttpPost ]
        public ActionResult DqdCreate(DqdSong dqdSong )
        {
            if (!ModelState.IsValid)
            {
                return View(dqdSong);
            }
            dqdSongs.Add(dqdSong);
            return RedirectToAction("Index");
        }
    }
}