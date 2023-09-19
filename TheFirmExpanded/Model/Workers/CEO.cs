using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmExpanded.Model.Workers
{
	internal class CEO : CFO
	{
		protected private bool _ceoPrivilege;

		protected bool CeoPrivilege
		{
			get { return _ceoPrivilege; }
			private set { _ceoPrivilege = value; }
		}
		
		internal protected CEO(short id, byte rank, string lastName, string firstName, string mailAddrs, string role,
			double salary, bool isFired, string sectorLoc, bool canUseCompanyCar, bool accessExecLounge, double salaryExecBonus, bool ceoPrivilege) : base(id, rank, lastName,
				firstName, mailAddrs, role, salary, isFired, sectorLoc, canUseCompanyCar, accessExecLounge, salaryExecBonus)
		{
			_rank = 10;
			_lastName = lastName;
			_firstName = firstName;
			_mailAddrs = mailAddrs;
			_role = "CEO";
			_salary = 1.25D;
			_ceoPrivilege = true;
			_isFired = false;
			_sectorLoc = sectorLoc;
			_canUseCompanyCar = true;
			_accessExecLounge = true;
			_salaryExecBonus = 32000000D;
		}
		public override string ToString()
		{
			return $"{base.ToString()}\nHas CEO Privilege: {CeoPrivilege}";
		}
	}
}