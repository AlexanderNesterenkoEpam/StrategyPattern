﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class Sleeping : IActivity
	{
		public void JustDoIt()
		{
			Console.WriteLine("Sleeping..");
		}
	}
}
