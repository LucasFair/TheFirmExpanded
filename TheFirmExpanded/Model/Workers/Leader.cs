using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmExpanded.Model.Workers
{
	internal class Leader:Employee
	{
		protected private string _sectorLoc;

		public string SectorLoc
		{
			get { return _sectorLoc; }
			private set { _sectorLoc = value; }
		}

		protected internal Leader(short id, byte rank, string lastName, string firstName, string mailAddrs, string role,
			double salary, bool isFired, string sectorLoc) : base(id, rank, lastName, firstName, mailAddrs, role, salary, isFired)
		{
			_salary = 14000D;
			_sectorLoc = sectorLoc;
		}

		public override string ToString()
		{
			return $"{base.ToString()}\nSector Location: {SectorLoc}";
		}
	}
}
