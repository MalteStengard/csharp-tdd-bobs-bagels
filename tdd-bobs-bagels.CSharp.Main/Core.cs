using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{

    public class Core
    {
        public Dictionary<string, int> wares = new Dictionary<string, int> {
            { "plain bagel", 5 },
            { "cheese bagel", 10 },
            { "cheese and ham bagel", 15 },
            { "steak bagel", 20 }
        };

        private int _bagelBasketCapacity = 3;

        private Dictionary<string, int> _basket = new Dictionary<string, int>();

        public bool add(string name)
        {
            if (wares.ContainsKey(name) && _bagelBasketCapacity > _basket.Count && !_basket.ContainsKey(name))
            {
                _basket.Add(name, wares.GetValueOrDefault(name));
                return true;
            }
            else if (_bagelBasketCapacity < _basket.Count) { 
                triggerOverflowCheck(name);
            }
            return false;
        }

        public bool remove(string name)
        {
            if (_basket.ContainsKey(name))
            {
                _basket.Remove(name);
                return true;
            } else
            {
                triggerSanityCheck(name);
                return false;
            }
        }

        public void changeBasketCapacity(int size)
        {
            _bagelBasketCapacity = size;
        }

        public int getBasketCapacity()
        {
            return _bagelBasketCapacity;
        }

        public void triggerSanityCheck(string name) {
            Console.WriteLine($"Hey! You are trying to remove {name} from your basket, only thing is there is no {name} in your basket!");
        }

        public void triggerOverflowCheck(string name)
        {
            Console.WriteLine($"Hey! You are trying to add a {name} to your basket, only thing is there is no room for a {name} in your basket!");
        }

        public int getCurrentBasketContent() { return _basket.Count; }
    }
}
