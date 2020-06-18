using System;
using System.Collections.Generic;

namespace news.DAL.Models
{
    public partial class LoaiTin
    {
        public string Idloaitin { get; set; }
        public string TenLt { get; set; }
        public int? ThutuLt { get; set; }
        public byte? AnhienLt { get; set; }
        public string Idtheloai { get; set; }

        internal void SetError(string stackTrace)
        {
            throw new NotImplementedException();
        }
    }
}
