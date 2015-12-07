using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaperAdminTools
{
    class Helper
    {
        private static bool IgnoreCase( string originalString, string enteredString )
        {
            var caseCheck = originalString.IndexOf( enteredString, StringComparison.OrdinalIgnoreCase ) >= 0;

            return caseCheck;
        }
    }
}
