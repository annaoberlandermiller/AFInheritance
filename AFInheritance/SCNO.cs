using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFInheritance
{
	class SCNO : NCO
	{
		public bool RtmEligible { get; set; } = true;

		public SCNO(string rank, string lastName, string firstName, string location, bool isEnlisted, bool upgradeTraining, bool selectFP, bool rtmEligible):
			base(rank, lastName, firstName, location, isEnlisted, upgradeTraining, selectFP)
		{
			RtmEligible = rtmEligible;
		}

		public SCNO() { }
	}
}
