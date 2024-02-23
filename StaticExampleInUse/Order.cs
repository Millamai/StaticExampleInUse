using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExampleInUse
{
    internal class Order
    {
        int _id;
        DateTime _date;
        private static int idCounter = 0;

        public int Id { get => _id; private set => _id = value; }
        public DateTime Date { get => _date; private set => _date = value; }

     
        public Order()
        {
            Id = idCounter;
            Date = DateTime.Now;
            idCounter++;
        }


        public override string ToString()
        {
            return "Ordre-id: "+Id +": Dato: "+Date.ToString("dd-MM-yy : kl: HH:mm:ss:fff");
        }

    }
}
