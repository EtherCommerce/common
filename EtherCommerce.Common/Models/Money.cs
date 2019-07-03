using System;

namespace EtherCommerce.Common.Models
{
    public class Money
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public int DecimalDigits { get; set; }
        public decimal RoundedAmount => decimal.Round(Amount, DecimalDigits, MidpointRounding.AwayFromZero);
    }
}
