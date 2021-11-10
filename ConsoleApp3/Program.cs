/*[6:50 p. m., 25/10/2021] Johan: Implementar aplicación de registro de montos en el banco.
Esta debe permitir ingresar datos para 3 clientes (Cedula, Nombres, apellidos, tipo de cuenta (Ahorros, Corriente), monto total).
La aplicación debe permitir consultar los datos de cualquiera de los tres clientes.
Debe permitir ingresar nuevos montos para cualquiera de los tres clientes y consolidarlos
Debe permitir consultar el monto total ingresado, sin embargo, para las cuentas de ahorros, al momento de consultar el monto total debe restar 1000 pesos y 
actualizar el monto total con la resta
[6:50 p. m., 25/10/2021] Johan: Para almacenar datos solo usemos variables
[6:51 p. m., 25/10/2021] Johan: todo se almacena en tiempo de ejecución, aqui no hay base de datos, ni colecciones
[6:51 p. m., 25/10/2021] Johan: luego vamos a mejorar el ejercicio, almacenando esto en colecciones y luego en una base de datos
[6:52 p. m., 25/10/2021] Johan: Recuerden que cada acción en el sistema se va preguntando por consola al usuario, usen variables para almacenar cada cosa 
y piensen en metodos de unica responsabilidad que permitan resolver cada uno de los puntos.
*/

using System;
using System.Collections.Generic;

namespace MySuperBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            string cuentaId;
            int opcion;
            var account = null;
            do
            {
                //
                Console.WriteLine("*****Bienvenido al Super Banco*****");
                Console.WriteLine("**Menu de Opciones, que desea hacer, Digite el numero de la opcion a relaizar:");
                Console.WriteLine("**1. Crear una nueva cuenta");
                Console.WriteLine("**2. Hacer un retiro de dinero");
                Console.WriteLine("**3. Hacer un deposito a su cuenta");
                Console.WriteLine("**4. Ver el estado de su cuenta");
                Console.WriteLine("**5. Salir");
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        
                            Console.WriteLine("Ingrese el nombre de usuario:");
                            string name = Console.ReadLine();

                            Console.WriteLine("Ingrese la cedula del usuario:");
                            string id = Console.ReadLine();

                            Console.WriteLine("Ingrese el tipo de Cuenta, digite A, para ahorros o B para Corriente:");
                            string accountType = Console.ReadLine();
                            
                            account = new BankAccount(name, id, accountType, 1);
                            Console.WriteLine($"\nAccount {account.Number} was created for {account.name} with {account.Balance}.");
                       
                            break;
                        
                    case 2:
                        
                            Console.WriteLine("Digite el numero de su cuenta");
                            cuentaId = Console.ReadLine();

                            if (cuentaId == account.Number) 
                            {
                                Console.WriteLine("Ingrese la cantidad a retirar:");
                                int retiro = int.Parse(Console.ReadLine());
                                account.MakeWithdrawal(retiro, DateTime.Now, "0001");
                            }
                            break;
                    case 3:

                            Console.WriteLine("Digite el numero de su cuenta");
                            cuentaId = Console.ReadLine();

                        break;
                }
            } while (opcion <= 4) ;
                /*account.MakeWithdrawal(120, DateTime.Now, "Hammock");
                Console.WriteLine(account.Balance);

                account.MakeDeposit(50, DateTime.Now, "Xbox Game");

                Console.WriteLine(account.GetAccountHistory());*/
        }
        
    }

}
