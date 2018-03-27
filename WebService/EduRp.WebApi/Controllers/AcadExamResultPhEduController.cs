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
    public class AcadExamResultPhEduController : ApiController
    {
        private IAcadExamResultPhEduService acadExamResultPhEduService = new AcadExamResultPhEduService();

        [HttpGet]
        public IHttpActionResult AcadExamResultPhEduGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId)
        {
            return Ok(new
            {
                results = acadExamResultPhEduService.AcadExamResultPhEduGet(id, userid, tokenid, batchid, Sectionid, GradeId)
            });
        }
        public IHttpActionResult AcadExamResultPhEduUpdate(AcadExamResultPhEdu aAcadExamResultPhEduupdate)
        {
            var isUpdate = acadExamResultPhEduService.AcadExamResultPhEduUpdate(aAcadExamResultPhEduupdate.UniversityId, aAcadExamResultPhEduupdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
