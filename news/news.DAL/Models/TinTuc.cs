using System;
using System.Collections.Generic;

namespace news.DAL.Models
{
    public partial class TinTuc
    {
        public string Idtintuc { get; set; }
        public string Tieude { get; set; }
        public string Tomtat { get; set; }
        public string Noidung { get; set; }
        public string UrlHinh { get; set; }
        public DateTime? Ngaydang { get; set; }
        public int? Solanxem { get; set; }
        public string Keyword { get; set; }
        public byte? Tinnoibat { get; set; }

        internal void SetError(string stackTrace)
        {
            throw new NotImplementedException();
        }

        public byte? Anhientin { get; set; }
        public string Idloaitin { get; set; }
    }
}
