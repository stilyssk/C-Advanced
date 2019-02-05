using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            List<Employee> listEmployees = new List<Employee>();
            for (int i = 0; i < repeat; i++)
            {
                List<string> listOfInputCommand = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string name = listOfInputCommand[0];
                double salary = double.Parse(listOfInputCommand[1]);
                string position = listOfInputCommand[2];
                string department = listOfInputCommand[3];
                if (listOfInputCommand.Count==5)
                {
                    int age = -1;
                    string email = "n/a";

                    bool flagAge = int.TryParse(listOfInputCommand[4], out age);
                    if (flagAge)
                    {
                        Employee newEmployee = new Employee(name, salary, position, department,  age);
                        listEmployees.Add(newEmployee);

                    }
                    else
                    {
                        email = listOfInputCommand[4];
                        Employee newEmployee = new Employee(name, salary, position, department, email);
                        listEmployees.Add(newEmployee);

                    }
                }
                else if (listOfInputCommand.Count == 4)
                {
                    Employee newEmployee = new Employee(name, salary, position, department);
                    listEmployees.Add(newEmployee);
                }
                else if (listOfInputCommand.Count == 6)
                {
                    string email = listOfInputCommand[4];
                    int age = int.Parse(listOfInputCommand[5]);
                    Employee newEmployee = new Employee(name, salary, position, department, email, age);
                    listEmployees.Add(newEmployee);
                }
            }
            HashSet<string> hashSetDepartment = new HashSet<string>();

            foreach (var curerntEmployee in listEmployees)
            {
                hashSetDepartment.Add(curerntEmployee.MyDepartment);
            }
            var dictionaryDepartment = hashSetDepartment.ToDictionary(x=>x,x=>0.0);
            var dictionaryDepartmentCount = hashSetDepartment.ToDictionary(x => x, x => 0);
            foreach (var currentEmployee in listEmployees)
            {
                dictionaryDepartment[currentEmployee.MyDepartment] += currentEmployee.MySalary;
                dictionaryDepartmentCount[currentEmployee.MyDepartment]++; ;

            }

            double maxAverage = 0;
            string maxDepartment = "";
            foreach (var item in dictionaryDepartment)
            {
                double currentAverage= item.Value / dictionaryDepartmentCount[item.Key];
                if (currentAverage>= maxAverage)
                {
                    maxAverage = currentAverage;
                    maxDepartment = item.Key;
                }               
            };

            listEmployees = listEmployees.Where(x => x.MyDepartment == maxDepartment).OrderByDescending(x=>x.MySalary).ToList();
            Console.WriteLine($"Highest Average Salary: {maxDepartment}");
            foreach (var employee in listEmployees)
            {
                Console.WriteLine($"{employee.MyName } {employee.MySalary:F2} {employee.MyEmail} {employee.MyAge}");
            }

        }
    }
}
