using System;
using static System.Console;
using External.Exam02.Exercise01;
using External.Exam02.Exercise02;
using System.Collections.Generic;

class Exam02 {

    public void MainExercise01Exam02() {

        int counter_exit = 0, seleccion = 0, money = 0;
        ProductsDB o_product_db = new ProductsDB();

        Clear();

        while(true) {

            WriteLine("Bienvenido a la maquina expendedora del ITLA\n");
            WriteLine("Formato de dinero que puede usar:");
            WriteLine("Monedas [5, 10, 25]");
            WriteLine("Billetes [50, 100, 200]\n");
            WriteLine("Seleccione el producto que desea comprar:\n");
            
            counter_exit = 0;

            foreach (KeyValuePair<int, Products> item in o_product_db.product_db) {
               
                WriteLine($"{item.Key}.{item.Value.name} -- {item.Value.price}$RD -- Quedan{item.Value.stock}");
                counter_exit++; 

            }

            counter_exit++;

            seleccion = ExerciseUtil.AskSeleccion(counter_exit);
            
            if (seleccion == counter_exit || seleccion > counter_exit || seleccion  < 1) {

               Clear();
               WriteLine("Seleccion de salida!! Gracias por usar");
               break;  

            }

            WriteLine("Dame la cantidad que deseas pagar: ");
            Write(">> ");
            money = int.Parse(ReadLine());

            if (ExerciseUtil.VerifyConstraints(money) == false) {

                WriteLine("No ha usado una cantidad de dinero valida");
                break;

            }

            if (money >= o_product_db.product_db[seleccion].price) {

                WriteLine($"Le sobra {o_product_db.CalculateBack(seleccion, money)}");
                o_product_db.UpdateStock(seleccion);
                
            }else {

                WriteLine("El dinero no es suficiente");

            }

            WriteLine("Desea obtener un informe [Y/n]:\n");

            if(ReadKey().Key == ConsoleKey.Y) {

                ExerciseUtil.GeneratePaper(o_product_db.product_db);
                break;
                
            }

            Clear();
        }   


    }

    public void MainExercise02Exam02() {

       FunctionsUtil.ViewEmployees(FunctionsUtil.Charge());
       FunctionsUtil.HigherEmployees(FunctionsUtil.Charge());

    }

}