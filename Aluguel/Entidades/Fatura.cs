using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aluguel_de_Carros.Entidades
{
    class Fatura
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Fatura(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        public override string ToString()
        {
            return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
