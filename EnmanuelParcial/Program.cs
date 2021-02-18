using System;

namespace EnmanuelParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cajero automatico banco FDP IVERMENTS//
            int monto, cantidadBilletesMil = 18, cantidadBilletesQuinientos = 19,
            cantidadBilletesDoscientos = 23, cantidadBilletesCien = 50;
            String banco;
            string numeroBanco;
            int limiteTotal = 20000;
            int limiteTransaccion = 10000;
            int cantidadRetirado = 0;
            string CantidadRetiro;

            int CantidaRetiroNumero;
            int contador = 1;
            int contadorinterno = 1;
            int contadorLimiteDiario = 1;
            int contadorLimiteTotal = 1;

            while (contador > 0)
            {


                Console.WriteLine("lista de bancos  1.FDP  2.Banreservas  3.Popular");
                numeroBanco = Console.ReadLine();
                while (contadorinterno > 0)
                {

                    switch (numeroBanco)
                    {
                        case "1":
                            Console.WriteLine("Usted a seleccionado al banco FDP");
                            contadorinterno = 0;
                            break;
                        case "2":
                            Console.WriteLine("Lamentablemente no tenedos disponibilidad en este banco");
                            contadorinterno = 0;
                            break;
                        case "3":
                            Console.WriteLine("Lamentablemente no tenedos disponibilidad en este banco");
                            contadorinterno = 0;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }

                }


                if (numeroBanco == "1")
                {
                    while (contadorLimiteDiario > 0)
                    {


                        Console.WriteLine("Cuanto dinero va a retirar ?");
                        CantidadRetiro = Console.ReadLine();

                        int.Parse(CantidadRetiro);
                        CantidaRetiroNumero = int.Parse(CantidadRetiro);

                        if (CantidaRetiroNumero > limiteTransaccion)
                        {
                            Console.WriteLine("No puede retirar mas de 10000 pesos por transaccion, ingresa otro monto.");
                        }
                        if (cantidadRetirado > 20000)
                        {
                            Console.WriteLine("No puede retirar mas de 20000 diario");
                        }
                        else
                        {
                            Console.WriteLine("Usted acaba de retirar :" + CantidadRetiro);
                            cantidadRetirado = cantidadRetirado + CantidadRetiro;


                            Console.WriteLine("El dia de hoy ha retirado un total de  :" + CantidadRetiro.ToString());

                            if (cantidadRetirado > 20000)
                            {
                                Console.WriteLine("Ya superaste el limite diario, cerraremos el cajero");
                                contador = 0;
                                contadorinterno = 0;
                                contadorLimiteDiario = 0;
                                contadorLimiteTotal = 0;
                            }
                            else
                            {
                                Console.WriteLine("Deseas hacer otra transaccion? 1.SI 2.NO  :");
                                var otraTran = Console.ReadLine();


                                if (otraTran == "1")
                                {
                                    Console.WriteLine("Ok volveremos al menu principal");
                                }
                                else
                                {
                                    Console.WriteLine("Cerraremos el cajero");
                                    contador = 0;
                                    contadorinterno = 0;
                                    contadorLimiteDiario = 0;
                                    contadorLimiteTotal = 0;
                                }
                            }

                        }




                    }


                }
            }






    }
}
