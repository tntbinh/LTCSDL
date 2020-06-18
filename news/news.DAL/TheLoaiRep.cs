using System;
using System.Collections.Generic;
using System.Text;
using news.Common.DAL;
using System.Linq;

namespace news.DAL
{

    using news.DAL.Models;
    public class TheLoaiRep : GenericRep<NewsContext, TheLoai>
    {
        public override TheLoai Read(string id)
        {
            var res = new TheLoai();
            try
            {
                res = All.FirstOrDefault(p => string.Compare(p.Idtheloai, id) == 0);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;


        }

        public string Remove(string id)
        {
            var m = base.All.First(i => string.Compare(i.Idtheloai, id) == 0);
            Context.TheLoai.Remove(m);
            Context.SaveChanges();
            m = base.Delete(m); //TODO
            return m.Idtheloai;
        }
    }
}
