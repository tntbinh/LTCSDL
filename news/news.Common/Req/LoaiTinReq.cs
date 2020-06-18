using System;
using System.Collections.Generic;
using System.Text;

namespace news.Common.Req
{
    public class LoaiTinReq
    {
        public string Idloaitin { get; set; }
        public string TenLt { get; set; }
        public int? ThutuLt { get; set; }
        public byte? AnhienLt { get; set; }
        public string Idtheloai { get; set; }
    }
}
