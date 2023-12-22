using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSDLNC_05.Models
{
    internal class DB_Drug
    {
        public static List<Drug> listDrugs(int pageNum)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("list_of_drugs");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@page_num", pageNum);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<Drug> drugs = new List<Drug>();

                while (res.Read())
                {
                    Drug drug = new Drug(
                        res.GetString(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetInt64(4)
                    );
                    drugs.Add(drug);
                }
                return drugs;
            }
            catch(Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
        public static List<Drug> searchDrugs(int pageNum, String kw)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("search_drugs");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@page_num", pageNum);
                sqlCmd.Parameters.AddWithValue("@keyword", kw);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<Drug> drugs = new List<Drug>();

                while (res.Read())
                {
                    Drug drug = new Drug(
                        res.GetString(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetInt64(4)
                    );
                    drugs.Add(drug);
                }
                return drugs;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }

        public static int updateDrug(
            String code, 
            String name, 
            String description, 
            String price_unit, 
            Double price_per_unit
        )
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("update_drug");
                SqlParameter numRowsUpdated = new SqlParameter("@rows_updated", SqlDbType.Int);

                numRowsUpdated.Direction = ParameterDirection.Output;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@code", code);
                sqlCmd.Parameters.AddWithValue("@name", name);
                sqlCmd.Parameters.AddWithValue("@description", description);
                sqlCmd.Parameters.AddWithValue("@price_unit", price_unit);
                sqlCmd.Parameters.AddWithValue("@price_per_unit", price_per_unit);
                sqlCmd.Parameters.Add(numRowsUpdated);
                sqlCmd.ExecuteNonQuery();

                return Convert.ToInt32(sqlCmd.Parameters["@rows_updated"].Value);
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }

        public static int insertDrug(
            String code,
            String name,
            String description,
            String price_unit,
            Double price_per_unit
        )
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("insert_new_drug");

                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@code", code);
                sqlCmd.Parameters.AddWithValue("@name", name);
                sqlCmd.Parameters.AddWithValue("@description", description);
                sqlCmd.Parameters.AddWithValue("@price_unit", price_unit);
                sqlCmd.Parameters.AddWithValue("@price_per_unit", price_per_unit);

                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }

        public static Drug getDrugInfo(String code)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_drug_info");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@code", code);
                SqlDataReader res = sqlCmd.ExecuteReader();


                if (res.Read())
                {
                    Drug drug = new Drug(
                        res.GetString(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetInt64(4)
                    );
                    return drug;
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }

        public static int deleteDrug(String code) 
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("delete_drug");

                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@code", code);

                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }
    }
}
