using System.Data;
using System.Data.SqlClient;

namespace NewsOnline.App_Code
{
    /// <summary>
    /// Summary description for KontaktFac
    /// </summary>
    public class ContactFac
    {
        public string _firmname { get; set; }      //    fldFirmName
        public string _address { get; set; }        //    fldAddress
        public string _postnummer { get; set; }     //    fldPostNummer
        public string _by { get; set; }             //    fldBy
        public string _telephone { get; set; }        //    fldTelePhone
        public string _email { get; set; }          //    fldEmail

        DataAccess DA = new DataAccess();

        public DataTable Get_Contact_Information()
        {
            string SQL = @"SELECT * FROM tblContact";
            SqlCommand CMD = new SqlCommand(SQL);
            return DA.GetData(CMD);
        }          // 获取联系人信息

        public int Edit_Contact()
        {
            string SQL = @"UPDATE tblContact
                       SET fldFirmName = @firmname, fldAddress = @address, fldPostNummer = @postnummer, fldBy = @by, fldTelePhone = @telephone, fldEmail = @email";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@firmname", _firmname);
            CMD.Parameters.AddWithValue("@address", _address);
            CMD.Parameters.AddWithValue("@postnummer", _postnummer);
            CMD.Parameters.AddWithValue("@by", _by);
            CMD.Parameters.AddWithValue("@telephone", _telephone);
            CMD.Parameters.AddWithValue("@email", _email);
            return DA.ModifyData(CMD);
        }                               // 编辑联系人信息


    }
}