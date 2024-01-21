﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudioDevices.Tracks;
using SoundSharpMVC.Models;

namespace SoundSharpMVC.Controllers
{
    public class TrackController : Controller
    {
        private static TrackList trackList;

        public TrackController()
        {
            if (trackList == null)
            {
                //link the data provider
                trackList = DataProvider.GenerateDefaultTracks();
            }
        }

        // GET: Track
        public ActionResult Index()
        {
            //show the track list
            ViewBag.TotalTime = trackList.TotalTime;
            return View(trackList.Shuffle());
        }

        // GET: Track/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Track/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Track/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //create a new Track
                int hours = int.Parse(collection["Hours"]);
                int minutes = int.Parse(collection["Minutes"]);
                int seconds = int.Parse(collection["Seconds"]);
                Track track = new Track();
                track.Name = collection["name"];
                track.Artist = collection["Artist"];
                track.AlbumSource = collection["AlbumSource"];
                track.Length = new Time(hours, minutes, seconds);
                track.Style = (Category)Enum.Parse(typeof(Category), collection["Style"]);
                trackList.Add(track);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Track/Edit/5
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

        // GET: Track/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Track/Delete/5
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