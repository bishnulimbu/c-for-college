using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactApp
{
    public static class DataLayer
    {
        public const string constring = "Data Source=SUBASHAY\\SQLEXPRESS;Initial Catalog=ContactDb1; Integrated Security=SSPI";
        private static SqlConnection conn = new SqlConnection(constring);
        private static SqlCommand cmd = new SqlCommand("", conn);
        public static List<AddressList> GetAddressLists()
        {
            List<AddressList> list = new List<AddressList>();
            SqlDataReader reader = null;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM AddressList";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AddressList addressList = new AddressList
                    {
                        AddressId = Convert.ToInt16(reader["AddressId"]),
                        AddressName = Convert.ToString(reader["AddressName"]),
                        PostalCode = Convert.ToString(reader["PostalCode"])
                    };
                    list.Add(addressList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

            return list;
        }
    }
}
