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
    public class TinTucController : ControllerBase
    {
        public TinTucController()
        {
            _svc = new TinTucSvc();
        }

        [HttpPost("create-tintuc")]
        public IActionResult CreateTinTuc(TinTucReq req)
        {
            var res = _svc.CreateTinTuc(req);
            return Ok(res);
        }

        [HttpPost("update-tintuc")]
        public IActionResult UpdateTinTuc(TinTucReq req)
        {
            var res = _svc.UpdateTinTuc(req);
            return Ok(res);
        }

        [HttpPost("search-tintuc")]
        public IActionResult SearchTinTuc(SearchReq req)
        {
            var res = _svc.SearchTinTuc(req.keyWord, req.size, req.page);
            return Ok(res);
        }

        [HttpPost("delete-tintuc")]
        public IActionResult DeleteTinTuc(DeleteReq req)
        {
            var res = _svc.DeleteTinTuc(req.id);
            return Ok(res);
        }


        [HttpPost("getMostViewedAtthistime")]
        public IActionResult getMostViewedAtthistime([FromBody]MostViewedReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.getMostViewedAtthistime(req.datef, req.datet);
            return Ok(res);
        }
        private readonly TinTucSvc _svc;
    }
}
