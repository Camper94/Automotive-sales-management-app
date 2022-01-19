using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace Automotive_sales_management_app
{
    public class DataAccess
    {
        public bool AddClient(string id, string nom, string prenom, string ctbank, string adress, string password, string idsalesmen)
        {
            var connectionString = @"Server=.\SQLEXPRESS;Database=AUTODZ;Trusted_Connection=True;";
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    List<CLIENT> newClient = new List<CLIENT>();
                    newClient.Add(new CLIENT { ID = Convert.ToInt32(id), NOM = nom, PRENOM = prenom, CTBANK = Convert.ToInt32(ctbank), ADRESS = adress, PASSWORD = password, IDSALESMEN = Convert.ToInt32(idsalesmen) });
                    connection.Execute("INSERT INTO CLIENT(ID,NOM,PRENOM,CTBANK,ADRESS,PASSWORD,IDSALESMEN)  VALUES (@ID, @NOM, @PRENOM, @CTBANK, @ADRESS, @PASSWORD, @IDSALESMEN)", newClient);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
           
        }
    }
}
