using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace StudentRegistration_Ermitano_Jeano
{
    public partial class Welcome : System.Web.UI.Page
    {
        XElement xFile;
        protected void Page_Load(object sender, EventArgs e)
        {
            XElement xFile = XElement.Load(Server.MapPath("~/student.xml"));
            lblWelcome.Text = "Hello " + xFile.Element("firstName");
        }
    }
}
