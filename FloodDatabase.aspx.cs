using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FloodDatabase : System.Web.UI.Page
{
    string fileLocation, table, dbconnectionString;
    int numberOfValues;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnectionString = "Data Source=stusql;Integrated Security=true";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUsageForDatabase fileuse = new FileUsageForDatabase();
        if (ChoiceBox.SelectedItem.Text == "Classroom")
        {
            table = "Classroom";
            numberOfValues = 4;
            fileLocation = "F:\\QUARTER 6\\Database Access\\App_Code\\Classroom.txt";
            fileuse.fillDatabase(fileLocation, table, dbconnectionString, numberOfValues);
        }
        else if (ChoiceBox.SelectedItem.Text == "Instructor")
        {
            table = "Instructor";
            numberOfValues = 2;
            fileLocation = "F:\\QUARTER 6\\Database Access\\App_Code\\Instructor.txt";
            fileuse.fillDatabase(fileLocation, table, dbconnectionString, numberOfValues);
        }
    }

    protected void ChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}