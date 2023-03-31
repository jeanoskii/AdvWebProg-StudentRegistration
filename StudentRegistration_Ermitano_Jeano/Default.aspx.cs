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
using System.Diagnostics;

namespace StudentRegistration_Ermitano_Jeano
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int studentID, year, age;
            string lastName, firstName, middleName, address, section;

            studentID = int.Parse(txtStudentID.Text);
            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;
            middleName = txtMiddleName.Text;
            age = int.Parse(txtAge.Text);
            address = txtAddress.Text;
            year = int.Parse(txtYear.Text);
            section = txtSection.Text;

            Debug.WriteLine(studentID);
            //Debug.WriteLine(lastName);
            //Debug.WriteLine(firstName);
            //Debug.WriteLine(middleName);
            //Debug.WriteLine(age);
            //Debug.WriteLine(address);
            //Debug.WriteLine(year);
            //Debug.WriteLine(section);

            XDocument xmlContent = new XDocument(
                new XDeclaration("1.0","UTF-8","yes"),
                new XElement("Student",
                    new XElement("studentID", studentID),
                    new XElement("lastName", lastName),
                    new XElement("firstName", firstName),
                    new XElement("middleName", middleName),
                    new XElement("age", age),
                    new XElement("address", address),
                    new XElement("year", year),
                    new XElement("section", section) 
                )
            );
            string xmlFile = Server.MapPath("~/student.xml");
            xmlContent.Save(xmlFile);

            Response.Redirect("Welcome.aspx");
        }
    }
}
