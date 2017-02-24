using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for InsertIntoDatabase
/// </summary>
public class InsertIntoDatabase
{
    public void InsertInto(String DBConnectString, string[] values, string table)
    {
        string insertValuesString = null; 
        
        for (int i = 0; i < values.Length; i++)
        {
            if(i!=values.Length-1)
            insertValuesString += values[i] + ", ";
            else
                insertValuesString += values[i];
        }
        string TableInfo = "INSERT Into " + table + " VALUES("+insertValuesString+");";
        SqlConnection dbConnection = new SqlConnection(DBConnectString);
        try
        {
            dbConnection.Open();
            dbConnection.ChangeDatabase("OlympicAlienAndTheCram");
        }
        catch
        {
            return;
        }
        SqlCommand studentSchedule = new SqlCommand(TableInfo, dbConnection);
        studentSchedule.ExecuteNonQuery();
    }
}