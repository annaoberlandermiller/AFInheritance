using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFInheritance
{
	class NCO : LowerE
	{
		public bool SelectFP { get; set; }

		public NCO(string rank, string lastName, string firstName, string location, bool isEnlisted, bool upgradeTraining, bool selectFP):
			base(rank, lastName, firstName, location, isEnlisted, upgradeTraining)
		{
			SelectFP = SelectFP;
		}

		public NCO() { }
	}
}
