using System;
using System.Collections.Generic;
using System.Text;
using news.Common.DAL;
using System.Linq;

namespace news.DAL
{

    using news.DAL.Models;
    public class DemIdRep : GenericRep<NewsContext, DemId>
    {
        public override DemId Read(string id)
        {
            var res = new DemId();
            try
            {
                res = All.FirstOrDefault(p => string.Compare(p.CountId, id) == 0);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;


        }

        public string Remove(string id)
        {
            var m = base.All.First(i => string.Compare(i.CountId, id) == 0);
            Context.DemId.Remove(m);
            Context.SaveChanges();
            m = base.Delete(m); //TODO
            return m.CountId;
        }

    }
}
