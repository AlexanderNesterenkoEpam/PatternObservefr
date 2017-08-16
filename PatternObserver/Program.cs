using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ITCompany company = new ITCompany();

			company.AddVacancy("Java dev");

			Subscriber alex = new Subscriber("Alex");
			Subscriber daud = new Subscriber("Daud");

			company.RegisterSubscriber(alex);
			company.RegisterSubscriber(daud);


			company.AddVacancy("PHP dev");

		}
	}
}
