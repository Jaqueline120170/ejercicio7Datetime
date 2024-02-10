

namespace CajeroMenu.Controladores
{

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Introduzca fecha en formato dd/mm/yyyy");    
            string fecha= Console.ReadLine();
            DateTime fechaInicial = Convert.ToDateTime(fecha);
            Console.WriteLine("Introduzca un número de días");
            int numDias= Convert.ToInt32(Console.ReadLine());

            DateTime difFechas = fechaInicial.AddDays(-numDias);
            DateTime sumFechas = fechaInicial.AddDays(numDias);
            Console.WriteLine("El resultado de sumar " + numDias + " dias a la fecha " + fechaInicial + " es: " + sumFechas);
            Console.WriteLine("El resultado de restar " + numDias + " dias a la fecha " + fechaInicial + " es: " + difFechas);

        }
    }
}
