using System;

namespace Planner
{
    /*
    
    Stories typed as an integer.
    Width typed as a double.
    Depth typed as a double.
    Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.

    */
    public class Building
    {
        public Building(string address)
        {
            _address = address;
            _designer = "My Name";
        }

        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }

        public string BuildingInfo()
        {
            return @$"
{_address}
---------------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic secrets of space
";
        }

        public override string ToString()
        {
            string info = BuildingInfo();
            return info;
        }
    }
}