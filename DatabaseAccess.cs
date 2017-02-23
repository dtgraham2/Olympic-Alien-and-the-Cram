using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DatabaseAccess
{

    public string[,] SelectAll(String DBConnectString,string[] rows,string table)
    {
        string TableInfo = "Select * from " + table;
        string[,] tableData=new string[1001,7];
        int i, j;
        i = 0;
        j = 0;
        SqlConnection dbConnection = new SqlConnection(DBConnectString);
        try
        {
            dbConnection.Open();
            dbConnection.ChangeDatabase("OlympicAlienAndTheCram");
        }
        catch
        {
            return null;
        }
        SqlCommand studentSchedule = new SqlCommand(TableInfo, dbConnection);
        SqlDataReader scheduleRecords = studentSchedule.ExecuteReader();
        if (scheduleRecords.Read())
        {
            do
            {
                tableData[i, j] += "<tr>";
                
                for (int k=0;k<(rows.Length);++k)
                {
                    j++;
                    tableData[i, j] += "<td>" + scheduleRecords[rows[k]] + "</ td >";
                }
                j++;
                tableData[i,j] += "</tr>";
                j = 0;
                i++;
            } while (scheduleRecords.Read()) ;
        }
        return tableData;
    }
    public string[,] SearchAll(String DBConnectString, string[] rows, string table,string rowcompair,string keyword)
    {
        string TableInfo = "Select * from " + table+" Where "+rowcompair+" = "+keyword;
        string[,] tableData = new string[1001, 7];
        int i, j;
        i = 0;
        j = 0;
        SqlConnection dbConnection = new SqlConnection(DBConnectString);
        try
        {
            dbConnection.Open();
            dbConnection.ChangeDatabase("OlympicAlienAndTheCram");
        }
        catch
        {
            return null;
        }
        SqlCommand studentSchedule = new SqlCommand(TableInfo, dbConnection);
        SqlDataReader scheduleRecords = studentSchedule.ExecuteReader();
        if (scheduleRecords.Read())
        {
            do
            {
                tableData[i, j] += "<tr>";

                for (int k = 0; k < (rows.Length); ++k)
                {
                    j++;
                    tableData[i, j] += "<td>" + scheduleRecords[rows[k]] + "</ td >";
                }
                j++;
                tableData[i, j] += "</tr>";
                j = 0;
                i++;
            } while (scheduleRecords.Read());
        }
        return tableData;

    }
    }