using System;

namespace Planner {
    public class Building {
        //private members
        private string _designer = "Kelly Coles";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "5253 Sallee Drive";
        private string _owner = "Kelly Coles";
        //public members
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {
            get {
                return Width * Depth * (3 * Stories);
            }
        }
        //constructor
        public Building (string address) {
            _address = address;
        }

        //methods
        public void Construct () {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase (string newOwner) 
        {
            _owner = newOwner;
        }

        public string GetDesigner () {
            return _designer;
        }
        public string GetAddress () {
            return _address;
        }
        public DateTime GetDate () {
            return _dateConstructed;
        }
        public string GetOwner () {
            return _owner;
        }


    }
}