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
    public class LoaiTinController : ControllerBase
    {
        public LoaiTinController()
        {
            _svc = new LoaiTinSvc();
        }

        [HttpPost("create-loaitin")]
        public IActionResult CreateLoaiTin(LoaiTinReq req)
        {
            var res = _svc.CreateLoaiTin(req);
            return Ok(res);
        }

        [HttpPost("update-loaitin")]
        public IActionResult UpdateLoaiTin(LoaiTinReq req)
        {
            var res = _svc.UpdateLoaiTin(req);
            return Ok(res);
        }

        [HttpPost("search-loaitin")]
        public IActionResult SearchLoaiTin(SearchReq req)
        {
            var res = _svc.SearchLoaiTin(req.keyWord, req.size, req.page);
            return Ok(res);
        }

        [HttpPost("delete-loaitin")]
        public IActionResult DeleteLoaiTin(DeleteReq req)
        {
            var res = _svc.DeleteLoaiTin(req.id);
            return Ok(res);
        }

        private readonly LoaiTinSvc _svc;

    }
}
