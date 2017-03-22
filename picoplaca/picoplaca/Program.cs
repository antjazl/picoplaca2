using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Picoplaca
    {

        public string Placa { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        // Constructor
        public Picoplaca()
        {
            Placa = "";
            Fecha = "";
            Hora = "";
        }
        //Constructor with arguments.
        public Picoplaca(string placa, string fecha, string hora)
        {
            Placa = placa;
            Fecha = fecha;
            Hora = hora;
        }
        //setters
        public void SetPlaca(string newPlaca)
        {
            Placa = newPlaca;
        }
        public void SetFecha(string newFecha)
        {
            Fecha = newFecha;
        }
        public void SetHora(string newHora)
        { 
            Hora = newHora;
        }
        // Method that checks if a datetime is between pico y placa hours
        public bool IsBetween(DateTime time, DateTime startmTime, DateTime endmTime, DateTime starttTime, DateTime endtTime)
        {
            if ((time.TimeOfDay >= startmTime.TimeOfDay && time.TimeOfDay <= endmTime.TimeOfDay) || (time.TimeOfDay >= starttTime.TimeOfDay && time.TimeOfDay <= endtTime.TimeOfDay))
                return true;
            return false;
        }
        //final method that tells you if you can or cant drive
        public bool Check(Picoplaca p)
        {

           // string placa2 = placa;
            string ulti;
            int ulti1;
            ulti = (p.Placa[p.Placa.Length - 1]).ToString();
            ulti1 = Int32.Parse(ulti);
            DateTime date = Convert.ToDateTime(p.Fecha);
            TimeSpan ts = TimeSpan.Parse(p.Hora);
            date = date.Date + ts;
            DateTime iniciom = new DateTime(date.Year, date.Month, date.Day, 7, 0, 0);
            DateTime finm = new DateTime(date.Year, date.Month, date.Day, 9, 30, 0);
            DateTime iniciot = new DateTime(date.Year, date.Month, date.Day, 16, 0, 0);
            DateTime fint = new DateTime(date.Year, date.Month, date.Day, 19, 30, 0);

            if ((IsBetween(date, iniciom, finm, iniciot, fint)) && (date.DayOfWeek == DayOfWeek.Monday) && ((ulti1 == 1) || (ulti1 == 2)))
                return true;
            if ((IsBetween(date, iniciom, finm, iniciot, fint)) && (date.DayOfWeek == DayOfWeek.Tuesday) && ((ulti1 == 3) || (ulti1 == 4)))
                return true;
            if ((IsBetween(date, iniciom, finm, iniciot, fint)) && (date.DayOfWeek == DayOfWeek.Wednesday) && ((ulti1 == 5) || (ulti1 == 6)))
                return true;
            if ((IsBetween(date, iniciom, finm, iniciot, fint)) && (date.DayOfWeek == DayOfWeek.Thursday) && ((ulti1 == 7) || (ulti1 == 8)))
                return true;
            if ((IsBetween(date, iniciom, finm, iniciot, fint)) && (date.DayOfWeek == DayOfWeek.Friday) && ((ulti1 == 9) || (ulti1 == 0)))
                return true;
            return false;
        }
    }











    //public static class TimeExtensions
    //{

    //}


    class Program
    {


        static void Main(string[] args)
        {

            while (true)
            {
                //
                //Console.Clear();
                Console.WriteLine("desea relizar una consulta ? 1 si 2 no");
                int decision;
                //string p, f, t;

                decision = Int32.Parse(Console.ReadLine());
                if (decision == 2)
                    break;

                Picoplaca pp = new Picoplaca();
                Console.WriteLine("Ingrese la placa: ");
                pp.SetPlaca(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha:DD-MM-YYYY");
                pp.SetFecha(Console.ReadLine());
                Console.WriteLine("Ingrese la hora HH:MM");
                pp.SetHora(Console.ReadLine());
                if (pp.Check(pp))
                Console.WriteLine("usted no puede conducir");
                else
                Console.WriteLine("usted puede conducir");



            }
        }




    }
}


