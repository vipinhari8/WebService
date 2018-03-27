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
    public class AcadExExamSyllabusController : ApiController
    {
        private IAcadExExamSyllabusService AcadExExamSyllabusService = new AcadExExamSyllabusService();

        [HttpGet]
        public IHttpActionResult AcadExExamSyllabusGet(int? id, int? userid, string tokenid, int? batchid, int? studentid)
        {
            return Ok(new
            {
                results = AcadExExamSyllabusService.AcadExExamSyllabusGet(id, userid, tokenid, batchid,studentid)
            });
        }

        public IHttpActionResult AcadExExamSyllabusUpdate(AcadExExamSyllabu AcadExExamSyllabusupd)
        {
            var isUpdate = AcadExExamSyllabusService.AcadExExamSyllabusUpdate(AcadExExamSyllabusupd.UniversityId, AcadExExamSyllabusupd);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
