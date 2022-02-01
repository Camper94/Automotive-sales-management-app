using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Dapper;

namespace Automotive_sales_management_app
{
    public class DataAccess
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=AUTODZ;Trusted_Connection=True;";

        public bool AddClient(string id, string nom, string prenom, string ctbank, string adress, string password, string idsalesmen)
        {
            
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

        public bool AddAuto(string id, string Model,string Prix,string Annee,string Kilo,string Accident,string IDsalesmen)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    List<AUTO> newAuto = new List<AUTO>();
                    newAuto.Add(new AUTO { ID = Convert.ToInt32(id), MODEL = Model, PRIX = Convert.ToInt32(Prix), ANNEE = Annee, ACCIDENT = Accident, KILO = Convert.ToInt32(Kilo), IDSALESMEN = Convert.ToInt32(IDsalesmen)});
                    connection.Execute("INSERT INTO AUTO(ID,MODEL,PRIX,ANNEE,ACCIDENT,KILO,IDSALESMEN)  VALUES (@ID, @MODEL, @PRIX, @ANNEE, @ACCIDENT, @KILO, @IDSALESMEN)", newAuto);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddParts(string id, string nom, string modelauto, string idsalesmen)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    List<PARTS> newParts = new List<PARTS>();
                    newParts.Add(new PARTS { ID = Convert.ToInt32(id), NOM = nom,MODELAUTO = modelauto,IDSALESMEN = Convert.ToInt32(idsalesmen) });
                    connection.Execute("INSERT INTO PARTS(ID,NOM,MODELAUTO,IDSALESMEN)  VALUES (@ID, @NOM,@MODELAUTO, @IDSALESMEN)", newParts);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddAccessory(string id, string nom,string idsalesmen)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    List<ACCESSORY> newAccess = new List<ACCESSORY>();
                    newAccess.Add(new ACCESSORY { ID = Convert.ToInt32(id), NOM = nom,IDSALESMEN = Convert.ToInt32(idsalesmen) });
                    connection.Execute("INSERT INTO ACCESSORY(ID,NOM,IDSALESMEN)  VALUES (@ID, @NOM, @IDSALESMEN)", newAccess);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddInssurance(string id, string nom, string idsalesmen)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    List<INSSURANCE> newInss = new List<INSSURANCE>();
                    newInss.Add(new INSSURANCE { ID = Convert.ToInt32(id), NAME = nom, IDSALESMEN = Convert.ToInt32(idsalesmen) });
                    connection.Execute("INSERT INTO INSSURANCE(ID,NAME,IDSALESMEN)  VALUES (@ID, @NAME, @IDSALESMEN)", newInss);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<OWNER> GetOwnerInfo()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<OWNER>($"select USERNAME,PASS from OWNER").ToList();
            }
        }

        public List<CLIENT> GetClientInfo()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<CLIENT>($"select NOM,PRENOM,PASSWORD from CLIENT").ToList();
            }
        }

        public List<SALESMEN> GetSalesmenInfo()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<SALESMEN>($"SELECT NOM,PRENOM,PASSWORD FROM SALESMEN").ToList();
            }
        }

        public List<AUTO> GetAuto()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<AUTO>($"select * from AUTO").ToList();
            }
        }

        public List<PARTS> GetPartsInfo()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<PARTS>($"select * from PARTS").ToList();
            }
        }

        public List<INSSURANCE> GetInssuranceInfo()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<INSSURANCE>($"select * from INSSURANCE").ToList();
            }
        }

        public List<ACCESSORY> GetAccessoryInfo()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<ACCESSORY>($"select * from ACCESSORY").ToList();
            }
        }

        public bool DeleteProduct(string id, string product)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    connection.Execute($"DELETE FROM {product} WHERE ID = {id}");
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
