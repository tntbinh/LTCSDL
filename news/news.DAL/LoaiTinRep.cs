using System;
using System.Collections.Generic;
using System.Text;
using news.Common.DAL;
using System.Linq;

namespace news.DAL
{
    
    using news.DAL.Models;
    public class LoaiTinRep: GenericRep<NewsContext, LoaiTin>
    {
        public override LoaiTin Read(string id)
        {
            var res = new LoaiTin();
            try
            {
                res = All.FirstOrDefault(p => string.Compare(p.Idloaitin, id) == 0);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;


        }


        public string Remove(string id)
        {
            var m = base.All.First(i => string.Compare(i.Idloaitin, id) == 0);
            Context.LoaiTin.Remove(m);
            Context.SaveChanges();
            m = base.Delete(m); //TODO
            return m.Idloaitin;
        }
    }
}
