using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastest_Food
{
	interface IFood
	{
		int Calories { get; set; }
		bool IsExpired();
	}
}
