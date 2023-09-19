﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmExpanded.Model.Workers
{
	internal class Administrator : CEO
	{
	
		internal protected Administrator(short id, byte rank, string lastName, string firstName, string mailAddrs, string role,
			double salary, bool isFired, string sectorLoc, bool canUseCompanyCar, bool accessExecLounge, double salaryExecBonus, bool ceoPrivilege) : base(id, rank, lastName,
				firstName, mailAddrs, role, salary, isFired, sectorLoc, canUseCompanyCar, accessExecLounge, salaryExecBonus, ceoPrivilege)
		{
			_rank = 9;
			_lastName = lastName;
			_firstName = firstName;
			_mailAddrs = mailAddrs;
			_role = "Admin";
			_salary = 67300D;
			_ceoPrivilege = false;
			_isFired = false;
			_canUseCompanyCar = true;
			_accessExecLounge = false;
			_salaryExecBonus = 0D;
		}
		public override string ToString()
		{
			return $"{base.ToString()}";
		}
	}
}
