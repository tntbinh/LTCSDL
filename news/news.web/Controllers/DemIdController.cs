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
    public class DemIdController : ControllerBase
    {
        public DemIdController()
        {
            _svc = new DemIdSvc();
        }

        [HttpPost("create-demID")]
        public IActionResult CreateDemId(DemIdReq req)
        {
            var res = _svc.CreateDemId(req);
            return Ok(res);
        }

        [HttpPost("update-demID")]
        public IActionResult UpdateDemId(DemIdReq req)
        {
            var res = _svc.UpdateDemId(req);
            return Ok(res);
        }

        [HttpPost("search-demID")]
        public IActionResult SearchDemId(SearchReq req)
        {
            var res = _svc.SearchDemId(req.keyWord, req.size, req.page);
            return Ok(res);
        }

        [HttpPost("delete-demID")]
        public IActionResult DeleteDemId(DeleteReq req)
        {
            var res = _svc.DeleteDemId(req.id);
            return Ok(res);
        }

        private readonly DemIdSvc _svc;
    }
}
