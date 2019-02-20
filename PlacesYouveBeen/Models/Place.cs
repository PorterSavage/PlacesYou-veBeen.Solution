using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Models
{
    public class Place
    {
        private string _cityName;
        private string _timeStayed;
        private string _journal;
        private static List<Place> travelDiary = new List<Place>() {};
        public Place(string cityName, string timeStayed, string journal)
        {
            _cityName = cityName;
            _timeStayed = timeStayed;
            _journal = journal;
            travelDiary.Add(this);
        }

        public string GetCityName()
        {
            return _cityName;
        }

        public void SetCityName(string newCityName)
        {
            _cityName = newCityName;
        }

        public string GetTimeStayed()
        {
            return _timeStayed;
        }

        public void SetTimeStayed(string newTimeStayed)
        {
            _timeStayed = newTimeStayed;
        }

        public string GetJournal()
        {
            return _journal;
        }

        public void SetJournal(string newJournal)
        {
            _journal = newJournal;
        }

        public static List<Place> GetTravelDiary()
        {
            return travelDiary;
        }
    }
}