using System;

namespace WebFormApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GetWelcomeMessage()
        {
            var name = "John Smith";
            return Greeter.GetGreeting(name);
        }
    }
}