using System;
using System.Collections.Generic;
using System.Text;

namespace Q17Final
{
    class DefaultAccount : IAccount
    {
        // тип учетной записи
        public string Type { get; set; }
        // баланс учетной записи
        public double Balance { get; set; }
        // процентная ставка
        public double Interest { get; set; }
        void IAccount.CalculatorInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
