using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmExpanded.Model.Workers
{
	internal class Chef:Leader
	{
		protected private bool _canUseCompanyCar;

		public bool CanUseCompanyCar
		{
			get { return _canUseCompanyCar; }
			private set { _canUseCompanyCar = value; }
		}

		protected internal Chef(short id, byte rank, string lastName, string firstName, string mailAddrs, string role,
			double salary, bool isFired, string sectorLoc, bool canUseCompanyCar) : base(id, rank, lastName, 
				firstName, mailAddrs, role, salary, isFired, sectorLoc)
		{
			_role = role;
			_salary = 40000;
			_canUseCompanyCar = canUseCompanyCar;
		}
		public override string ToString()
		{
			return $"{base.ToString()}\nAccess To Company Car: {CanUseCompanyCar}";
		}
	}
}
