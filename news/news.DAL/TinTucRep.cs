using System;
using System.Collections.Generic;
using System.Text;
using news.Common.DAL;
using System.Linq;

namespace news.DAL
{
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    using news.DAL.Models;
    using System.Data;

    public class TinTucRep : GenericRep<NewsContext, TinTuc>
    {
        #region -- Overrides --

        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the object</returns>
        public override TinTuc Read(string id)
        {
            var res = new TinTuc();
            try
            {
                res = All.FirstOrDefault(p => string.Compare(p.Idtintuc, id) == 0);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;


        }


        public string Remove(string id)
        {
            var m = base.All.First(i => string.Compare(i.Idtintuc, id) == 0);
            Context.TinTuc.Remove(m);
            Context.SaveChanges();
            m = base.Delete(m); //TODO
            return m.Idtintuc;
        }

        #endregion

        #region -- Methods --

        // <summary>
        // Initialize
        // </summary>


        public object getMostViewedAtthistime(DateTime datef, DateTime datet)
        {
            List<object> res = new List<object>();
            var cnn = (SqlConnection)Context.Database.GetDbConnection();
            if (cnn.State == System.Data.ConnectionState.Closed)
                cnn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "getMostViewedAtthistime";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@datef", datef);
                cmd.Parameters.AddWithValue("@datet", datet);
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var x = new
                        {
                            tieude = row["tieude"],
                            solanxem = row["solanxem"],
                            ngaydang = row["ngaydang"]
                        };
                        res.Add(x);
                    }
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;

        }


    }

    #endregion
}
