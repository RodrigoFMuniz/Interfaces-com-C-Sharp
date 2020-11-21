using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoUsandoInterfaces.Services
{
    class USATaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.06;
            }
            else
            {
                return amount * 0.12;
            }
        }
    }
}
