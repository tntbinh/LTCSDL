using System;
using System.Collections.Generic;

namespace news.DAL.Models
{
    public partial class Users
    {
        public string Iduser { get; set; }
        public string Hoten { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public byte? Gioitinh { get; set; }
        public byte? Idgroup { get; set; }
        public DateTime? Ngaydangky { get; set; }
    }
}
