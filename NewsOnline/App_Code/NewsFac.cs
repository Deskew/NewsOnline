using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NewsOnline.App_Code
{
    /// <summary>
    /// Summary description for NewsFac
    /// </summary>
    public class NewsFac
    {

        // Properties

        public int _id { get; set; }                           //    fldID
        public string _title { get; set; }                //    fldTitle
        public string _preview { get; set; }                    //   fldPreview
        public string _text { get; set; }                     //    fldText
        public DateTime _datetime { get; set; }                    //    fldDateTime
        public string _image { get; set; }                     //    fldImage
        public int _typeid { get; set; }                        //    fldTypeID_fk

        DataAccess DA = new DataAccess();

        public DataTable GetAllNews()
        {
            string SQL = @"SELECT * FROM tblNews ORDER BY fldID DESC";
            SqlCommand CMD = new SqlCommand(SQL);
            return DA.GetData(CMD);
        }                  // 获取所有新闻

        public DataTable GetNewsByfldID()
        {
            string SQL = @"SELECT * 
                       FROM tblNews 
                       WHERE fldID = @id";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@id", _id);
            return DA.GetData(CMD);
        }                   // 根据ID获取新闻

        public DataTable GetNewestNewsForUser()
        {
            string SQL = @"SELECT TOP 3 *
                     FROM tblNews
                     ORDER BY fldID DESC";
            SqlCommand CMD = new SqlCommand(SQL);
            return DA.GetData(CMD);
        }                //获取三条最新消息

        public DataTable GetNewestNewsForAdmin()
        {
            string SQL = @"SELECT TOP 2 *
                     FROM tblNews
                     ORDER BY fldID DESC";
            SqlCommand CMD = new SqlCommand(SQL);
            return DA.GetData(CMD);
        }                // 获取两条最新消息


        public DataTable GetNewestNewsByTypeID(int ID)
        {
            string SQL = @"SELECT *
                       FROM tblNews
                       WHERE fldTypeID_fk = @ID
                       ORDER BY fldID DESC";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@ID", ID);
            return DA.GetData(CMD);
        }     //按类型获取最新消息(升序) (int "ID" <- IS A PARAMETER)

        public DataTable GetNewsByfldID(int ID)
        {
            string SQL = @"SELECT *
                       FROM tblNews
                       WHERE fldTypeID_fk = @ID";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@ID", ID);
            return DA.GetData(CMD);
        }           // 按类型获取最新消息(默认排序) (int "ID" <- IS A PARAMETER)

        public int CreateNews()
        {
            string SQL = @"INSERT INTO tblNews (fldTitle, fldPreview, fldText, fldDateTime, fldImage, fldTypeID_fk)
                       VALUES (@title, @preview, @text, @datetime, @img, @typeid)";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@title", _title);
            CMD.Parameters.AddWithValue("@preview", _preview);
            CMD.Parameters.AddWithValue("@text", _text);
            CMD.Parameters.AddWithValue("@datetime", _datetime);
            CMD.Parameters.AddWithValue("@img", _image);
            CMD.Parameters.AddWithValue("@typeid", _typeid);
            return DA.ModifyData(CMD);
        }                             // 新建

        public int DeleteNews()
        {
            string SQL = @"DELETE FROM tblNews WHERE fldID = @id";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@id", _id);
            return DA.ModifyData(CMD);
        }                              // 删除

        public int EditNews()
        {
            string SQL = @"UPDATE tblNews 
                       SET fldTitle = @title, fldPreview = @preview, fldText = @text, fldImage = @img, fldTypeID_fk = @typeid 
                       WHERE fldID = @id";
            SqlCommand CMD = new SqlCommand(SQL);
            CMD.Parameters.AddWithValue("@id", _id);
            CMD.Parameters.AddWithValue("@title", _title);
            CMD.Parameters.AddWithValue("@preview", _preview);
            CMD.Parameters.AddWithValue("@text", _text);
            CMD.Parameters.AddWithValue("@img", _image);
            CMD.Parameters.AddWithValue("@typeid", _typeid);
            return DA.ModifyData(CMD);
        }                               // 编辑


    }
}