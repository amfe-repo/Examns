using static System.Console;

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
            Write("Selecione aqui: ");

            option = ReadLine();

            switch(option){

                case "1":

                    bank_name = "FDP INVERSMENT";
                    break;

                case "2":

                    Write("Digite el nombre del banco aqui: ");
                    bank_name = ReadLine();
                    break;

                case "3":

                    WriteLine("**Gracias por utilizar**");
                    loop_control = false;
                    break;

                default:
                    WriteLine("**Ha digitado un valor incorrecto**");
                    break;

            }

        }
        
    }

    public void Retirement(string bank_name){

        short amount = 0, limit_amount = 0;

        limit_amount = LimitAmount(bank_name);

        WriteLine($"Esta en el banco: {bank_name} su limite es de {limit_amount}\n");
        
        Write("Dame el monto a retirar: ");
        amount = short.Parse(ReadLine());

    }

    public short LimitAmount(string bank_name){

        if (bank_name == "FDP INVERSMENT") return 20000;
        else return 10000;

    }

    public void CalculateBills(){
        
    }


}