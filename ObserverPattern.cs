using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
        public interface IObserver
        {
            void Update(object Model);
        }
        public class Observable
        {
            List<IObserver> observers = new List<IObserver>();
            bool changed = false;
            protected void SetChanged()
            {
                changed = true;
            }
            protected void NotifyObservers()
            {
                if (changed)
                {
                    foreach (IObserver observer in observers)
                        observer.Update(this);
                }
                changed = false;
            }
            public void AddObserver(IObserver observer)
            {
                observers.Add(observer);
            }
        }
    }



