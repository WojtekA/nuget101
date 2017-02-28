using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                //EventLog.CreateEventSource("Application", "Application");
                eventLog.Source = "Application";
                eventLog.WriteEntry("Log message example", EventLogEntryType.Information);
            }
        }
    }
}