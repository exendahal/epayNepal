using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace epayNepal
{
    public interface MakePaymentImepay
    {
        void getDataImePay(string amt, string productName, string uniqueId);
    }
}