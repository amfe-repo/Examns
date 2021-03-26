using System.Collections.Generic;
using static System.Console;

namespace External.Exam02.Exercise02 {

    public struct FunctionsUtil {
        
        public static List<Employee> Charge() {

            List<Employee> list_employee = new List<Employee>();

            for (int i = 0; i < 5; i++) {

                list_employee.Add(new Employee("P"+i, 36 * i));
                
            }

            return list_employee;

        }

        public static void ViewEmployees(List<Employee> list_employee) {

            WriteLine("Los empleados son: \n");

            foreach (var item in list_employee) {

                WriteLine($"{item.name} -- {item.salary}");
                
            }
        }

        public static void HigherEmployees(List<Employee> list_employee) {

            int high = 0;
            string index_name = "";

            WriteLine("\nEl de mayor salario es: \n");

            foreach (var item in list_employee) {
                if (high < item.salary) {

                    high = item.salary;
                    index_name = item.name;

                }
            }

            WriteLine($"{index_name} con un salario de {high}");
        }
        
    }
}