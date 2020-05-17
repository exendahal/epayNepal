using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace epayNepal
{
    public interface MakePaymentKhalti
    {
        void getDataKhalti(string amt, string productName, string uniqueId);
    }
}