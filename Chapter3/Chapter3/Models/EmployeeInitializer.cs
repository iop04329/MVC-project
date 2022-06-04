using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Chapter3.Data;

namespace Chapter3.Models
{
    public class EmployeeInitializer:DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            //Step1:以List泛型集合建立員工資料
            List<Employee> Employees = new List<Employee>
            {
                new Employee{Id=1,Name="David",Mobile="0933152667",Email="david@gmail.com",Department = "總經理室",Title = "CEO" },
                new Employee{Id=2,Name="Mary",Mobile="0938456889",Email="mary@gmail.com",Department = "人事部",Title = "管理師" },
                new Employee{Id=3,Name="Joe",Mobile="0925331225",Email="joe@gmail.com",Department = "財務部",Title = "經理" },
                new Employee{Id=4,Name="Mark",Mobile="0935863991",Email="mark@gmail.com",Department = "業務部",Title = "業務員" },
                new Employee{Id=5,Name="Rose",Mobile="0987335668",Email="rose@gmail.com",Department = "資訊部",Title = "工程師" },
                new Employee{Id=6,Name="May",Mobile="0955259885",Email="may@gmail.com",Department = "資訊部",Title = "工程師" },
                new Employee{Id=7,Name="John",Mobile="0921123456",Email="john@gmail.com",Department = "業務部",Title = "業務員" }
            };
            //Step2:將List的每筆資料逐一加入Entity Framework的Employees之中
            Employees.ForEach(x => context.Employees.Add(x));
            //Step3:儲存異動
            context.SaveChanges();
        }
    }
}