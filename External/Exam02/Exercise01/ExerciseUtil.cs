using System;
using static System.Console;
using System.Collections.Generic;

namespace External.Exam02.Exercise01 {

    public struct ExerciseUtil {
        
        private static bool LoopForValidations(Func<int, int, bool>[] collection, int verify_var, int verify_var2) {

            foreach (var item in collection) {

                if (item(verify_var ,verify_var2) == false) return item(verify_var, verify_var2);

            }

            return true;
        }

        public static int AskSeleccion(int id){

            WriteLine($"{id}.Salir");

            Write("\n>> ");

            return int.Parse(ReadLine());

        }

        public static bool VerifyConstraints(int money) { 

            bool result = false;

            if (money == 5 || money == 10 || money == 25 || money == 50 || money == 100 || money == 200) {

               result = true;   

            }

            return result;
        }

        public static void GeneratePaper(Dictionary<int, Products> db){
            
            Clear();

            WriteLine("Productos restantes: ");

            foreach (KeyValuePair<int, Products> item in db) {
               
                WriteLine($"{item.Key}.{item.Value.name} -- Quedan{item.Value.stock}");
            
            }

            WriteLine("\n");
            WriteLine("Productos vendidos: ");

            foreach (KeyValuePair<int, Products> item in db) {
                
                if(item.Value.stock < 10) {

                    WriteLine($"{item.Value.name} -- Vendidos: {10 - item.Value.stock}");

                }
                
            
            }

        }
        


    }
}