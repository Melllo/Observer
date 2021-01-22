using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Zhek : IObserverable
    {

        List<IObserver> observers;


        List<String> prices = new List<String>();

        public string getPrices() {
            string s = "";
            foreach (string price in prices) {
                s += "\n" + price;
            }
            return s;
        }
        public Zhek() {
            prices.Add("gas = 2.33");
            prices.Add("water = 1.98");
            prices.Add("electicity = 1.64");
            observers = new List<IObserver>();
        }

        public void addPosition(string s) {
            prices.Add(s);
            NotifyObservers();
        } 
        public void removePosition(string s) {
            prices.Remove(s);
            NotifyObservers();
        }
        public void changePosition(string old, string _new) {
            prices.Remove(old);
            prices.Add(_new);
            NotifyObservers();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers) {
                o.Update(this.getPrices());
            }
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
