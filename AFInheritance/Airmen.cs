using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFInheritance
{
	abstract class Airmen
	{
		public string Rank { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Location { get; set; }
		public bool IsEnlisted{ get; set; }

		public Airmen (string rank, string lastName, string firstName, string location, bool isEnlisted)
		{
			Rank = rank;
			LastName = lastName;
			LastName = lastName;
			FirstName = firstName;
			Location = location;
			IsEnlisted = isEnlisted;
		}
		public Airmen() { }
	}
}
