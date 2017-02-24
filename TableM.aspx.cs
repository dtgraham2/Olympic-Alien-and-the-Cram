using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TableM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string dbConnection = "Data Source=stusql; Integrated Security=True;";
        string[,] Tables = new String[1001, 30];
        DatabaseAccess Data = new DatabaseAccess();
        string keyword = "studentID";
        string filter = "11";
        string[] rows = { "studentID", "firstName", "LastName", "SSN", "Birthday", "CurrentQuarter", "GPA" };
        string tablename = "currentStudents";
        Tables = Data.SelectAll(dbConnection, rows, tablename);
        Response.Write("<center>");
        Response.Write("<table border='1' width ='55%'>");
        Response.Write("<tr>");
        Response.Write("<th>Student ID</th>");
        Response.Write("<th>First Name</th>");
        Response.Write("<th>Last Name</th>");
        Response.Write("<th>SSN</th>");
        Response.Write("<th>Birthday</th>");
        Response.Write("<th>Current Quarter</th>");
        Response.Write("<th>GPA</th>");
        Response.Write("</tr>");
        for (int k = 0; k < (999); ++k)
        {
            for (int i = 0; i < (rows.Length + 1); ++i)
            {
                Response.Write(Tables[k, i]);
            }
        }
        Response.Write("</table>");
    }
}