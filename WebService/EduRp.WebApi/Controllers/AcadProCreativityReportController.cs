using EduRp.Data;
using EduRp.Service.IService;
using EduRp.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EduRp.WebApi.Controllers
{
    public class AcadProCreativityReportController : ApiController
    {
        private IAcadProCreativityReportService acadProCreativityReportService = new AcadProCreativityReportService();
        [HttpGet]
        public IHttpActionResult AcadProCreativityReportGet(int? id, int? userid, string token, int? batchid, int? GradeId, int? SectionId)
        {
            return Ok(new
            {
                results = acadProCreativityReportService.AcadProCreativityReportGet(id, userid, token, batchid, GradeId, SectionId)
            });
        }

        public IHttpActionResult AcadProCreativityReportUpdate(AcadProCreativityReport acadProCreativityReport)
        {
            var isUpdate = acadProCreativityReportService.AcadProCreativityReportUpdate(acadProCreativityReport.UniversityId, acadProCreativityReport);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
