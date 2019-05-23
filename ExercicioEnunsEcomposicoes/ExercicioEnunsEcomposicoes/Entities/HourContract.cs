using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnunsEcomposicoes.Entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int hour { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            this.hour = hour;
        }

        public double TotalValue()
        {
            return hour * ValuePerHour;
        }
    }
}
