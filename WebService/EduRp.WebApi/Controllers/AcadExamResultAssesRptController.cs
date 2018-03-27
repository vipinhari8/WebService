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
    public class AcadExamResultAssesRptController : ApiController
    {
        private IAcadExamResultAssesRptService acadExamResultAssesRptService = new AcadExamResultAssesRptService();

        [HttpGet]
        public IHttpActionResult AcadExamResultAssesRptGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId,int? StudentId)
        {
            return Ok(new
            {
                results = acadExamResultAssesRptService.AcadExamResultAssesRptGet(id, userid, tokenid, batchid, Sectionid, GradeId, StudentId)
            });
        }
        [HttpGet]
        public IHttpActionResult AcadExamResultAssesStudentRptGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId)
        {
            return Ok(new
            {
                results = acadExamResultAssesRptService.AcadExamResultAssesRptStudentGet(id, userid, tokenid, batchid, Sectionid, GradeId)
            });
        }
        public IHttpActionResult AcadExamResultAssesStudentRptUpdate(AcadExamResultAssesRpt acadExamResultAssesRptupdate)
        {
            var isUpdate = acadExamResultAssesRptService.AcadExamResultAssesRptUpdate(acadExamResultAssesRptupdate.UniversityId, acadExamResultAssesRptupdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
