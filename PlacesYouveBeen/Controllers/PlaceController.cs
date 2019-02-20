using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
    public class PlaceController : Controller
    {
        [HttpPost("/traveldetails")]
        public ActionResult TravelDiary(string cityName, string timeStayed, string journal)
        {
            Place newPlace = new Place(cityName, timeStayed, journal);
            return RedirectToAction("TravelDetails");
        }

        [HttpGet("/traveldetails")]
        public ActionResult TravelDetails()
        {
            List<Place> travelDiary = Place.GetTravelDiary();
            return View(travelDiary);
        }
    }
}