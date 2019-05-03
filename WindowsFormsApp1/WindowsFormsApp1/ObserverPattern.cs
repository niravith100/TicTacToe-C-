using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
        public interface IObservable
        {
            void Update(object Model);
        }
        public class Observable
        {
            List<IObservable> observers = new List<IObservable>();
            bool changed = false;
            protected void SetChanged()
            {
                changed = true;
            }
            protected void NotifyObservers()
            {
                if (changed)
                {
                    foreach (IObservable observer in observers)
                        observer.Update(this);
                }
                changed = false;
            }
            public void AddObserver(IObservable observer)
            {
                observers.Add(observer);
            }
        }
    }



