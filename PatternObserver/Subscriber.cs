using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
	public class Subscriber : Observer
	{
		private string name;

		public Subscriber(string name)
		{
			this.name = name;
		}

		public void HandleEvent(List<string> vacancies)
		{
			Console.WriteLine(name + ", Available vacancies for you:");

			foreach (var vac in vacancies)
			{
				Console.Write(vac + ", ");
			}

			Console.WriteLine("\n");
		}
	}
}
