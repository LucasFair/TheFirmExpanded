
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmExpanded.Model;

namespace TheFirmExpanded
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintAttributeAndType printAll = new PrintAttributeAndType();
			printAll.PrintAll();
		}
	}
}
