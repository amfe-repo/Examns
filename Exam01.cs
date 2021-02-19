using static System.Console;
using System;


class Exam01{

    public void MainProgram(){

        string bank_name = "", option = "";
        bool loop_control = true;

        while(loop_control){

            Clear();
            
            WriteLine("Bienvenido al cajero automatico CODEX-09!!\n");
            WriteLine("Por favor seleccione la opcion de banco que utilizara: \n");
            WriteLine("1. FDP INVERSMENT");
            WriteLine("2. Otro");
            WriteLine("3. Salir");
            Write("\nSelecione aqui: ");

            option = ReadLine();

            switch(option){

                case "1":

                    bank_name = "FDP INVERSMENT";
                    Retirement(bank_name);
                    break;

                case "2":

                    Write("Digite el nombre del banco aqui: ");
                    bank_name = ReadLine();
                    Retirement(bank_name);
                    break;

                case "3":

                    WriteLine("**Gracias por utilizar**");
                    loop_control = false;
                    break;

                default:
                    WriteLine("**Ha digitado un valor incorrecto**");
                    WriteLine($"**Presione cualquier tecla para volver al menu**");
                    break;

            }

            ReadKey();

        }
        
    }

    public void Retirement(string bank_name){

        short amount = 0, limit_amount = 0;

        limit_amount = LimitAmount(bank_name);

    	Clear();

        WriteLine($"Esta en el banco: {bank_name} su limite es de {limit_amount}\n");
        Write("Dame el monto a retirar: ");
        amount = short.Parse(ReadLine());


        if (amount > 100 && amount < limit_amount){

            CalculateBills(amount);

        }else{
            Write("**El monto no entra en los parametros, intente de nuevo**");
        }

    }

    public short LimitAmount(string bank_name){

        if (bank_name == "FDP INVERSMENT") return 20000;
        else return 10000;

    }

    public void CalculateBills(short amount){

        double total = 0.0, new_amount = 0.0;
        string str = "";

        Bills[] safe_box = new Bills[4];

        safe_box[0] = new Bills(1000, 18);
        safe_box[1] = new Bills(500, 19);
        safe_box[2] = new Bills(200, 23);
        safe_box[3] = new Bills(100, 50);

        new_amount = amount;


        foreach(var item in safe_box){

           if(item.money_stock > 0){

               total = Math.Floor((double)(new_amount / item.money_value));

               item.amount_this_bills = (int)total;

               new_amount = new_amount - (total * item.money_value);
           }

        }


        str = $"\nHa obtenido: {safe_box[0].amount_this_bills} billetes de 1000\n";
        str += $"Ha obtenido: {safe_box[1].amount_this_bills} billetes de 500\n";
        str += $"Ha obtenido: {safe_box[2].amount_this_bills} billetes de 200\n";
        str += $"Ha obtenido: {safe_box[3].amount_this_bills} billetes de 100\n\n";
        str += $"**Presione cualquier tecla para volver al menu**";

        WriteLine(str);
    }

}