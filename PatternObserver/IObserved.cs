using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
	public interface Observed
	{
		void RegisterSubscriber(Subscriber subscriber);
		void DeleteSubscriber(Subscriber subscriber);

		void ShareMessages();
	}
}
