using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmExpanded.Model.Workers
{
	internal class CFO : Chef
	{
		protected private bool _accessExecLounge;
		protected private double _salaryExecBonus;

		public bool AccessExecLounge
		{
			get { return _accessExecLounge; }
			private set { _accessExecLounge = value; }
		}
		public double SalaryExecBonus
		{
			get { return _salaryExecBonus; }
			private set { _salaryExecBonus = value; }
		}

		protected internal CFO(short id, byte rank, string lastName, string firstName, string mailAddrs, string role,
			double salary, bool isFired, string sectorLoc, bool canUseCompanyCar, bool accessExecLounge, double salaryExecBonus) : base(id, rank, lastName,
				firstName, mailAddrs, role, salary, isFired, sectorLoc, canUseCompanyCar)
		{
			_role = "CFO";
			_salary = 90000D;
			_accessExecLounge = accessExecLounge;
			_salaryExecBonus = salaryExecBonus;
		}

		public override string ToString()
		{
			return $"{base.ToString()}\nAccess To The Executive Lounge: {AccessExecLounge}\nSalary Bonus: ${SalaryExecBonus}";
		}
	}
}
