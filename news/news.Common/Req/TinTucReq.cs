using System;
using System.Collections.Generic;
using System.Text;

namespace news.Common.Req
{
    public partial class TinTucReq
    {
        public string Idtintuc { get; set; }
        public string Tieude { get; set; }
        public string Tomtat { get; set; }
        public string Noidung { get; set; }
        public string UrlHinh { get; set; }
        public DateTime? Ngaydang { get; set; }
        public int? Solanxem { get; set; }
        public string Keyword { get; set; }

        public object Read(string id)
        {
            throw new NotImplementedException();
        }

        public byte? Tinnoibat { get; set; }
        public byte? Anhientin { get; set; }
        public string Idloaitin { get; set; }
        public int month { get; set; }
        public int year { get; }

        public object Read(int idtintuc)
        {
            throw new NotImplementedException();
        }
    }
}
