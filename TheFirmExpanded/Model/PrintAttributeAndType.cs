using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TheFirmExpanded.Model.Workers;

namespace TheFirmExpanded.Model
{

	internal class PrintAttributeAndType
	{
		short id;
		byte rank;
		string role;
		short salary;
		bool isFired;
		bool canUseCompanyCar;
		bool accessExecLounge;
		bool ceoPrivilege;

		public void PrintAll()
		{
			Employee ceo = new CEO(id++, rank, "Max", "Rich", "imrich@rich.biz", role, salary, isFired, "Top Floor", canUseCompanyCar, accessExecLounge, 9000000D, ceoPrivilege);
			Employee coo = new COO(id++, 7, "Richie", "Lotta", "ihavemoney@rich.biz", role, salary, false, "Seventh Floor", true, true, 25000D);
            Employee cfo = new CFO(id++, 7, "Phat", "Kath", "kittypower@rich.biz", role, salary, false, "Sixth Floor", true, true, 20000D);
			Employee chefA = new Chef(id++, 6, "McMahon", "Mandy", "imawoman@rich.biz", "Chef of Sector A", 41500D, false, "Fifth Floor", true);
			Employee chefB = new Chef(id++, 5, "Amanda", "Ashley", "imaman@rich.biz", "Chef of Sector B", salary, true, "Fifth Floor", false);
			Employee chefC = new Chef(id++, 5, "Noun", "Outta Puns", "dontcare@rich.biz", "Chef of Sector C", salary, false, "Fifth Floor", false);
			Employee leaderA = new Leader(id++, 4, "Wayfinder", "Navi", "moralcompass@rich.biz", "Leader of Bills", salary, false, "Fourth Floor");
			Employee leaderB = new Leader(id++, 4, "Chen", "Chan", "shishishishi@rich.biz", "Leader of Coins", salary, false, "Third Floor");
			Employee employeeA = new Employee(id++, 3, "Kénhon", "Fëddar", "kenfed@rich.biz", "Cannon Fodder", salary, true);
			Employee employeeB = new Employee(id++, 3, "Smalworth", "Gerund", "smallgrunt@rich.biz", "Front Line", salary, false);
			Employee employeeC = new Employee(id++, 2, "McFly", "Tainé", "tinyfly@rich.biz", "Front Line", salary, true);
			Employee employeeD = new Employee(id++, 2, "Woolsey", "Würm", "dontcallmeworm@rich.biz", "Janitor", salary, false);
			Employee employeeE = new Employee(id++, 2, "Leif", "May", "desperate@rich.biz", "Diversity Hire", salary, true);
			Employee employeeF = new Employee(id++, 1, "Rei", "Fuu", "free@rich.biz", "Intern", 0D, false);
			Employee employeeG = new Employee(id++, 1, "Moné", "Nö", "poor@rich.biz", "Intern", 0D, false);
			Employee employeeH = new Employee(id++, 1, "Debb", "Balu", "cripplingballoondebt@rich.biz", "Intern", 0D, false);
			Employee employeeI = new Employee(id++, 1, "Payne", "Tommy", "mystomachhurts@rich.biz", "Intern", 0D, false);
			Employee admin = new Administrator(id++, 9, "Vulf", "Lone", "nomoreplease@rich.biz", role, salary, false, "Administration Desk", true, false, 0, ceoPrivilege);
			Employee hr = new HR(id++, 8, "Brown", "Charlie", "goodgrief@rich.biz", role, salary, false, "Human Resources Department", true, false, 0, ceoPrivilege);

			Console.WriteLine(admin.ToString());
			Console.WriteLine();
			Console.WriteLine(hr.ToString());
			Console.WriteLine();
            Console.WriteLine(ceo.ToString());
            Console.WriteLine();
            Console.WriteLine(coo.ToString());
			Console.WriteLine();
            Console.WriteLine(cfo.ToString());
            Console.WriteLine();
            Console.WriteLine(chefA.ToString());
            Console.WriteLine();
            Console.WriteLine(chefB.ToString());
			Console.WriteLine();
			Console.WriteLine(chefC.ToString());
			Console.WriteLine();
            Console.WriteLine(leaderA.ToString());
			Console.WriteLine();
			Console.WriteLine(leaderB.ToString());
			Console.WriteLine();
            Console.WriteLine(employeeA.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeB.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeC.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeD.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeE.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeF.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeG.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeH.ToString());
			Console.WriteLine();
			Console.WriteLine(employeeI.ToString());
			
        }
	}
}
