using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    class studentinfodal
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    

        #region Insert Data to Database

        public bool Insert(StudentInfo stdinfo)
        {
            bool isSuccess = false;
            //insert data to the database
            //1st craete a connection between database and our application
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO studentinfo (id, namesurname, thesis, startdate, languages, framework) VALUES (@id, @namesurname, @thesis, @startdate, @languages, @framework)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", stdinfo.id);
                cmd.Parameters.AddWithValue("@namesurname", stdinfo.namesurname);
                cmd.Parameters.AddWithValue("@thesis", stdinfo.thesis);
                cmd.Parameters.AddWithValue("@startdate", stdinfo.startdate);
                cmd.Parameters.AddWithValue("@languages", stdinfo.languages);
                cmd.Parameters.AddWithValue("@framework", stdinfo.framework);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    
        #endregion

        #region Update Data in Database
        public bool Update(StudentInfo stdinfo)
        {
            bool isSuccess = false;
            SqlConnection conn1 = new SqlConnection(myconnstring);

            try
            {

                string sql = " UPDATE studentinfo SET namesurname=@namesurname, thesis=@thesis, startdate=@startdate, languages=@languages, framework=@framework WHERE id=@id ";
                SqlCommand cmd = new SqlCommand(sql, conn1);

                cmd.Parameters.AddWithValue("@id", stdinfo.id);
                cmd.Parameters.AddWithValue("@namesurname", stdinfo.namesurname);
                cmd.Parameters.AddWithValue("@thesis", stdinfo.thesis);
                cmd.Parameters.AddWithValue("@startdate", stdinfo.startdate);
                cmd.Parameters.AddWithValue("@languages", stdinfo.languages);
                cmd.Parameters.AddWithValue("@framework", stdinfo.framework);

                conn1.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Successfull
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }

            return isSuccess;
        }
            #endregion
    }
}
