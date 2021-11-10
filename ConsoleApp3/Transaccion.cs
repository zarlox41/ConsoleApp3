using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class Transaccion
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public String Notes { get; }
                
        public Transaccion(decimal Amount, DateTime date, string note)
        {
            this.Amount = Amount;
            this.Date = date;
            this.Notes = note;
            
        }
    }
}
