using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFInheritance
{
	class LowerE : Airmen
	{
		public bool UpgradeTraining;

		public LowerE(string rank, string lastName, string firstName, string location, bool isEnlisted, bool upgradeTraining):
			base(rank, lastName, firstName, location, isEnlisted)
		{
			UpgradeTraining = upgradeTraining;
		}
		public LowerE() { }
	}
}
