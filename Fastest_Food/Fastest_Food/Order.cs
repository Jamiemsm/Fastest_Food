using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastest_Food
{
	class Order
	{
		private Meal meal;

		public Meal Meal
		{
			get { return meal; }
			set { meal = value; }
		}

		public Order()
		{
			Meal meal = new Meal();
		}
	}
}
