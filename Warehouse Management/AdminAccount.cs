using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Warehouse_Management
{
    class AdminAccount : Account
    {
        public static bool accessLevel(int accountID)
        {
            if(accountID == 4)
            {
                return true;
            }
            return false;
        }
    }
}
