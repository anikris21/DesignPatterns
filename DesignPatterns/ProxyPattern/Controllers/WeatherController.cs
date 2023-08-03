﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProxyPattern;
using WeatherforecastLibrary;

namespace ProxyPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        IWeatherProvider _weatherProviderProxy;
        public WeatherController(IWeatherProvider weatherProviderProxy) {
            _weatherProviderProxy = weatherProviderProxy;
        }


        // Http Get should do
        [HttpPost]
        public IEnumerable<Weatherforecast> Post(int count)
        {
            return _weatherProviderProxy.Get(count);
        }



        // GET: WeatherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeatherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeatherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: WeatherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeatherController/Edit/5
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

        // GET: WeatherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeatherController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}