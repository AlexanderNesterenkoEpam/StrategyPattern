using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			JavaDeveloper Alex = new JavaDeveloper();
			Alex.activity = new Coding();
			Alex.DoActivity();

			Alex.activity = new Sleeping();
			Alex.DoActivity();

		}
	}
}
