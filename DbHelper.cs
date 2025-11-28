using System;
using System.Data;
using System.Data.SqlClient;

public static class DbHelper
{
    private static readonly string constring = @"Data Source=DESKTOP-IU534U3\SQLEXPRESS;Initial Catalog=SistemDataSiswa_sas;Intergrated Security=True;TrustServerCertificateTrue";
    public static SqlConnection GetConnection()
    {
        SqlConnection conn = new SqlConnection(constring);
        try
        {
            conn.Open();
            return conn;
        }
        catch (Exception ex)
        {
            throw new Exception("gagal koneksi ke database: " + ex.Message);
        }


    }
    public static DataTable ExecuteQuery(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
    public static int ExecuteNonQuery(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }

    public static object ExecuteScalar(string query)
    {
        using (SqlConnection conn = GetConnection())
        {

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                return cmd.ExecuteScalar();
            }


        }
    }
}