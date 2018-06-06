using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			LowerE ABSnuffy = new LowerE("AB", "Snuffy", "Snoopy", "Columbus AFB", true, true);
			LowerE SrAMafia = new LowerE("SrA", "Mafia", "Skating", "JB Lackland", true, false);
			NCO SSgtNewbie = new NCO("SSgt", "Newbie", "Sarge", "JB Lackland", true, true, false); 
			NCO TSgtSup = new NCO("TSgt", "Sup", "Visor", "Columbus AFB", true, false, true);
			SCNO MSgtCrusty = new SCNO("MSgt", "Crusty", "Crab", "JB Lackland", true, false, true, true);

		}
	}
}
