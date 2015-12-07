using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaperAdminTools
{
    class SuperAdminControls
    {
        public string addAnAdminUsername { get; set; } // Send to Log "Admin name has Added admin, Admin name"
        public string modifyAUserUsername { get; set; } // Send to Log "Admin name has Modified admin, Admin Name"
        public string removeAUserUsername { get; set; } // Send to Log "Admin name has Removed admin, Admin Name"
        public string setAnnouncment { get; set; } // Send to Log "Admin name has Modified announcment to: Announcment"

    }
}
