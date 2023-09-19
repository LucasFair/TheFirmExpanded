using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmExpanded.Model.Workers
{
	internal class Employee
	{
		protected private short _id;
		protected private byte _rank;
		protected private string _lastName;
		protected private string _firstName;
		protected private string _mailAddrs;
		protected private string _role;
		protected private double _salary;
		protected private bool _isFired;

		public short Id
		{
			get { return _id; }
			private set { _id = value; }
		}
		public byte Rank
		{
			get { return _rank; }
			private set { _rank = value; }
		}
		public string LastName
		{
			get { return _lastName; }
			private set { _lastName = value; }
		}
		public string FirstName
		{
			get { return _firstName; }
			private set { _firstName = value; }
		}
		public string MailAddrs
		{
			get { return _mailAddrs; }
			private set { _mailAddrs = value; }
		}
		public string Role
		{
			get { return _role; }
			private set { _role = value; }
		}
		public double Salary
		{
			get { return _salary; }
			private set { _salary = value; }
		}
		public bool IsFired
		{
			get { return _isFired; }
			private set { _isFired = value; }
		}

		protected internal Employee(short id, byte rank, string lastName, string firstName, string mailAddrs, string role, double salary, bool isFired)
		{
			_id = id;
			_rank = rank;
			_lastName = lastName;
			_firstName = firstName;
			_mailAddrs = mailAddrs;
			_role = role;
			_salary = salary;
			_isFired = isFired;
		}
		public override string ToString()  // The method is overridden in order to return the values of the object
		{
			return $"ID: {Id}\nRank: {Rank}\nLast Name: {LastName}\nFirst Name: {FirstName}" +
				$"\nMail Address: {MailAddrs}\nRole: {Role}\nSalary: ${Salary}\nTo Be Fired: {IsFired}";
		}
	}
}
