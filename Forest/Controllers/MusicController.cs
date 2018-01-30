using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forest.Controllers
{
    public class MusicController : Controller
    {
        private Forest.Services.IService.IMusicService _MusicService;


        public MusicController() { 

            _MusicService = new Forest.Services.Service.MusicService(); }





        // GET: Music
        public ActionResult Categories()
        {
            return View(_MusicService.GetMusicCategories());
        }


        public ActionResult GetMusicRecordings(string genre)
        {

            return View(_MusicService.GetMusicRecordings(genre));


        }

        public ActionResult GetMusicRecording ( int Id)
        {

            return View(_MusicService.GetMusicRecording(Id));


        }



        // GET: Music/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Music/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
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

        // GET: Music/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Music/Edit/5
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

        // GET: Music/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Music/Delete/5
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
    }
}
