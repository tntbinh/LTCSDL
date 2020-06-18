using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace news.web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;


    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaiController : ControllerBase
    {
        public TheLoaiController()
        {
            _svc = new TheLoaiSvc();
        }

        [HttpPost("create-theloai")]
        public IActionResult CreateTheLoai(TheLoaiReq req)
        {
            var res = _svc.CreateTheLoai(req);
            return Ok(res);
        }

        [HttpPost("update-theloai")]
        public IActionResult UpdateTheLoai(TheLoaiReq req)
        {
            var res = _svc.UpdateTheLoai(req);
            return Ok(res);
        }

        [HttpPost("search-theloai")]
        public IActionResult SearchTheLoai(SearchReq req)
        {
            var res = _svc.SearchTheLoai(req.keyWord, req.size, req.page);
            return Ok(res);
        }

        [HttpPost("delete-theloai")]
        public IActionResult DeleteTheLoai(DeleteReq req)
        {
            var res = _svc.DeleteTheLoai(req.id);
            return Ok(res);
        }

        private readonly TheLoaiSvc _svc;
    }
}
