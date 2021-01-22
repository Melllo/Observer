using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Flat : IObserver
    {
        public string Address { get; }


        public Flat(string address, IObserverable zhek) {
            this.Address = address;
            zhek.AddObserver(this);
        }

        public void Update(String s)
        {
            Console.WriteLine("\nResident(s) of the apartment at " + Address + ".We notify you about tariff changes:\n" + s); ;
        }
    }
}
