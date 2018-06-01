using System.Data;
using System.Data.SqlClient;

namespace NewsOnline.App_Code
{
    /// <summary>
    /// Summary description for UserFac
    /// </summary>
    public class UserFac
    {
        public int _id { get; set; }            //    fldID
        public string _user { get; set; }       //    fldBrugernavn
        public string _password { get; set; }   //    fldPassword
        public string _email { get; set; }      //    fldEmail

        DataAccess DA = new DataAccess();

        public DataTable UserLogin()
        {
            string SQL = "SELECT fldUserName FROM tblUser WHERE fldUserName = @user AND fldPassword = @password";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@user", _user);
            CMD.Parameters.AddWithValue("@password", _password);
            return DA.GetData(CMD);
        }

    }
}