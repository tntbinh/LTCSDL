using System;
using System.Collections.Generic;

namespace news.DAL.Models
{
    public partial class TheLoai
    {
        public string Idtheloai { get; set; }
        public string TenTl { get; set; }
        public int? ThutuTl { get; set; }
        public byte? AnhienTl { get; set; }

        internal void SetError(string stackTrace)
        {
            throw new NotImplementedException();
        }
    }
}
