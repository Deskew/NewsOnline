using System.Data;
using System.Data.SqlClient;

namespace NewsOnline.App_Code
{
    /// <summary>
    /// Summary description for NewsTypeFac
    /// </summary> dragostea
    public class NewsTypeFac
    {
        public int _id { get; set; }            //    fldTypeID
        public string _type { get; set; }   //    fldType
        public string _image { get; set; }      //    fldTypeImage

        DataAccess DA = new DataAccess();

        public DataTable GetAll_NewsType()
        {
            string SQL = @"SELECT * FROM tblNewsType";
            SqlCommand CMD = new SqlCommand(SQL);
            return DA.GetData(CMD);
        }

        public DataTable GetSelected_NewsType()
        {
            string SQL = @"SELECT * 
                       FROM tblNews 
                       INNER JOIN tblNewsType 
                       ON fldTypeID = fldTypeID_fk";
            SqlCommand CMD = new SqlCommand(SQL);
            return DA.GetData(CMD);
        }
    }
}