using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1._0
{
	enum RushOrder
	{
		
	}
	class DeskQuote
	{
		public DateTime Date;
		public string Name;
		public Desk Desk;
		public float Price;
		public RushOrder Rush;

		public DeskQuote(string _name, Desk _desk, float _price, RushOrder _rush)
		{

		}

		public float CalculateCost(Desk desk)
		{
			return 0;
		}
	}
}
