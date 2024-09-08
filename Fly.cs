using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights
{
    public class Fly
    {
        private int _number;
        private string _destinationPoint;
        private string _departureTime;
        private string _arrivalTime;
        private int _seats;
        public Fly(string csvLine)
        {
            string[] values = csvLine.Split(';');
            _number = int.Parse(values[0]);
            _destinationPoint = values[1];
            _departureTime = values[2];
            _arrivalTime = values[3];
            _seats = int.Parse(values[4]);
        }

        public string[] GetNumberAndSeats()
        {
            return new string[] { _number.ToString(), _seats.ToString() };
        }

        public int GetNumber()
        {
            return _number;
        }

        public string GetDepartureTime()
        {
            return _departureTime;
        }

        public void SetSeats(int seats)
        {
            _seats = seats;
        }

        public int GetFreeSeats()
        {
            return _seats;
        }

        public string GetArrivalTime()
        {
            return _arrivalTime;
        }

        public string GetDestinationPoint()
        {
            return _destinationPoint;
        }

        public string[] GetArray()
        {
            return new string[] { _number.ToString(), _destinationPoint, _departureTime, _arrivalTime, _seats.ToString() };
        }

        
    }
}
