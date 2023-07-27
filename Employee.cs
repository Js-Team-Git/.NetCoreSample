namespace AzureDummy
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
    public static class Employee
    {
        public static List<EmployeeModel> Employees()
        {
           List<EmployeeModel> employees = new()
            {
                new EmployeeModel { EmployeeId = 1,EmployeeName ="A"},
                new EmployeeModel { EmployeeId = 2,EmployeeName ="B"},
                new EmployeeModel { EmployeeId = 3,EmployeeName ="C"},
                new EmployeeModel { EmployeeId = 4,EmployeeName ="D"},
                new EmployeeModel { EmployeeId = 5,EmployeeName ="E"},
                new EmployeeModel { EmployeeId = 6,EmployeeName ="F"},
                new EmployeeModel { EmployeeId = 7,EmployeeName ="G"},
                new EmployeeModel { EmployeeId = 8,EmployeeName ="H"},
                new EmployeeModel { EmployeeId = 9,EmployeeName ="I"},
                new EmployeeModel { EmployeeId = 10,EmployeeName ="J"},
                new EmployeeModel { EmployeeId = 11,EmployeeName ="K"},
                new EmployeeModel { EmployeeId = 12,EmployeeName ="L"},
                new EmployeeModel { EmployeeId = 13,EmployeeName ="M"},
                new EmployeeModel { EmployeeId = 14,EmployeeName ="N"},
                new EmployeeModel { EmployeeId = 15,EmployeeName ="O"},
                new EmployeeModel { EmployeeId = 16,EmployeeName ="P"},
                new EmployeeModel { EmployeeId = 17,EmployeeName ="Q"},
                new EmployeeModel { EmployeeId = 18,EmployeeName ="R"},
                new EmployeeModel { EmployeeId = 19,EmployeeName ="S"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="T"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="U"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="V"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="W"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="X"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="Y"},
                new EmployeeModel { EmployeeId = 20,EmployeeName ="Z"}
            };
            return employees;
        }      
    }
}
