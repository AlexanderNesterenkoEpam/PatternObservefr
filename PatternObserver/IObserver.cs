using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
	public interface Observer
	{
		void HandleEvent(List<string> vacancies);
	}
}
