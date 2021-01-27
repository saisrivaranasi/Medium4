﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int input;
                Employee emp = new Employee();
                List<Employee> empList = new List<Employee>();

                void PrintEmployee()
                {
                    Console.WriteLine("Please enter the employee Name\n");
                    string employeeName = Console.ReadLine();

                    List<Employee> newEmpList = empList.ToList();

                    var result = from i in empList
                                 from c in newEmpList
                                 where i.Name == employeeName
                                 where c.Age > i.Age
                                 select c;

                    foreach (Employee empobj in result)
                    {
                        Console.WriteLine(empobj);
                    }
                }
                do
                {
                    emp.TakeEmployeeDetailsFromUser();
                    empList.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input != 0);


                PrintEmployee();
                Console.ReadLine();
            }

        }
    }




