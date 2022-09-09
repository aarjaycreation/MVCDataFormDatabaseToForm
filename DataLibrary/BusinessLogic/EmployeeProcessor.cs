using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName,
            string lastname, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastname,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Employee ( EmployeeId, FirstName, LastName, EmailAddress )
                           values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";
            return sqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployee()
        {
            string sql = @"select Id,EmployeeId, FirstName, LastName, EmailAddress
                           from dbo.Employee ;";
            return sqlDataAccess.LoadData<EmployeeModel>(sql);
        }

    }
}
