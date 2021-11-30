using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aluguel_de_Carros.Entidades;

namespace Aluguel_de_Carros.Servicos
{
    class ServicoLocacao
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private TaxaDeServico _taxService;
        public ServicoLocacao(double pricePerHour, double pricePerDay, TaxaDeServico taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        public void ProcessInvoice(AluguelCarro carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Fatura(basicPayment, tax);
        }
    }
}
