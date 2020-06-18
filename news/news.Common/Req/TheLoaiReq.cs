using System;
using System.Collections.Generic;

namespace news.Common.Req
{
    public partial class TheLoaiReq
    {
        public string Idtheloai { get; set; }
        public string TenTl { get; set; }
        public int? ThutuTl { get; set; }
        public byte? AnhienTl { get; set; }
    }
}
