using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{
    class SupplierAccount : Account
    {
        public static bool accessLevel(int accountID)
        {
            if (accountID == 3)
            {
                return true;
            }
            return false;
        }
    }
}
