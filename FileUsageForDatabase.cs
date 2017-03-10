using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;
/// <summary>
/// Summary description for FileAcess
/// </summary>
public class FileUsageForDatabase
{

    public void fillDatabase(string fileLocation,string table,String DBConnectString,int numberOfValues)
    {
        string text = System.IO.File.ReadAllText(fileLocation);
        string[] values = text.Split(',');
        string[] rows = new string[numberOfValues];
        bool helpful = true;
        int numberofIterations = 1;
        int lastValue = 0;
        
        int k = 0;
        InsertIntoDatabase insertintodatabase = new InsertIntoDatabase();
        try
        {
            while (helpful == true)
            {
                int j = 0;
                for (int i = k ; i < (numberOfValues*numberofIterations); i++)
                {
                    rows[j] = values[i];
                    j++;
                    k++;
                    
                }

                insertintodatabase.InsertInto(DBConnectString, rows, table);

                numberofIterations++;
                if (lastValue != 0)
                    lastValue = numberOfValues * numberofIterations;
                else
                    lastValue = numberOfValues;
            }
        }
        catch
        {
            
            return;
        }
    }
}