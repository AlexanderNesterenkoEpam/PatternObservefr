using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
	public class ITCompany : IObserved
	{
		List<IObserver> subscribers { get; set; } = new List<IObserver>();

		List<string> vacances { get; set; } = new List<string>();

		public void AddVacancy(string vacancy)
		{
			vacances.Add(vacancy);
			ShareMessages();
		}

		public void RemoveVacancy(string vacancy)
		{
			vacances.Remove(vacancy);
			ShareMessages();
		}

		public void DeleteSubscriber(Subscriber subscriber)
		{
			subscribers.Remove(subscriber);
		}

		public void RegisterSubscriber(Subscriber subscriber)
		{
			subscribers.Add(subscriber);	
		}

		public void ShareMessages()
		{
			foreach (Subscriber sub in subscribers)
			{
				sub.HandleEvent(this.vacances);
			}
		}
	}
}
