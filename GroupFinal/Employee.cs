using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class Employee
    {
        //variable declarations
        private string employeeID;
        private string employeeFirst;
        private string employeeLast;
        private string employeePhone;
        private string employeeRole;
        private DateTime employeeHireDate;
        private string employeeStatus;
        private int employeeOrders;
        //empty constructor
        public Employee()
        {

        }
        //constructor with all the variables
        public Employee(string employeeID, string employeeFirst, string employeeLast, string employeePhone, string employeeRole, DateTime employeeHireDate, string employeeStatus, string employeeOrders)
        {
            this.employeeID = employeeID;
            this.employeeFirst = employeeFirst;
            this.employeeLast = employeeLast;
            this.employeePhone = employeePhone;
            this.employeeRole = employeeRole;
            this.employeeHireDate = employeeHireDate;
            this.employeeStatus = employeeStatus;
            this.employeeOrders = employeeOrders;
        }
        //get and sets for all employee variables
        public string employeeID { get; set; }

        public string employeeFirst { get; set; }

        public string employeeLast { get; set; }

        public string employeePhone { get; set; }

        public string employeeRole { get; set; }

        public DateTime employeeHireDate { get; set; }

        public string employeeStatus { get; set; }

        public int employeeOrders { get; set; }
    }
}