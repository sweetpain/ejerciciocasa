using System;

namespace ejercicioBBWA
{
    class Program
    {
        static void Main(string[] args)
        {




            var mes1 = new DateTime(2019, 02, 01);

            var mes2 = new DateTime(2019, 03, 01);

            var mes3 = new DateTime(2019, 04, 01);

            var mes4 = new DateTime(2019, 05, 01);

            var mes5 = new DateTime(2019, 06, 01);

            var mes6 = new DateTime(2019, 07, 01);

            var mes7 = new DateTime(2019, 08, 01);

            var mes8 = new DateTime(2019, 09, 01);

            var mes9 = new DateTime(2019, 10, 01);

            var mes10 = new DateTime(2019, 11, 01);

            var mes11 = new DateTime(2019, 12, 01);

            var mes12 = new DateTime(2020, 01, 01);

            var deuda = 17000000 / 12;
            var interes = 0.02;
            var operacion = deuda * interes;
            var total = deuda + operacion;
            //stuar229 contraseña git


            Console.WriteLine($"Digite la fecha de consignacion");
            var fecha = Convert.ToDateTime(Console.ReadLine());
            var fechainicio = new DateTime(2019, 01, 01);
            Console.WriteLine($"La fecha en la que ustd diligencio el prestamo es: {fechainicio}");
            Console.ReadLine();

            if (fecha >= fechainicio)
            {

                if (fecha == mes1 || fecha == mes2 || fecha == mes3 || fecha == mes4 || fecha == mes5 || fecha == mes6 || fecha == mes7 || fecha == mes8 || fecha == mes9 || fecha == mes10 || fecha == mes11 || fecha == mes12)
                {
                    Console.WriteLine($"el total a pagar este mes es : {total}");

                }





                else if (fecha != mes1 || fecha != mes2 || fecha != mes3 || fecha != mes4 || fecha != mes5 || fecha != mes6 || fecha != mes7 || fecha != mes8 || fecha != mes9 || fecha != mes10 || fecha != mes11 || fecha != mes12)
                {
                    Console.WriteLine($"Cuantos dias se retrazo al pagar la cuota");
                    var dias = int.Parse(Console.ReadLine());
                    var operacion2 = dias * operacion;
                    var totalcondias = total + operacion2;
                    Console.WriteLine($"el valor a pagar mas los dias de retazo es: {totalcondias}");

                }

            }
        }
    }
}

