using System;
using System.Collections.Generic;

namespace Planner {
    public class City {
        private string _nameOfCity { get; set; }
        private int _yearEstablished { get; set; }
        public string Mayor { get; set; }
        public City (string nameOfCity, int yearEstablished) {
            _nameOfCity = nameOfCity;
            _yearEstablished = yearEstablished;
        }
        public List<Building> buildings = new List<Building> ();

        public string GetNameOfCity() {
            return _nameOfCity;
        }
        public int GetYear () {
           return  _yearEstablished;
        }
    };
}