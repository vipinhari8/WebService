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
    public class AcadStudentDairyController : ApiController
    {
        private IAcadStudentDairyService acadStudentDairyService = new AcadStudentDairyService();
        [HttpGet]
        public IHttpActionResult AcadStudentDairyGet(int? id, int? userid, string tokenid, int? BatchId, int? GradeId)
        {
            return Ok(new
            {
                results = acadStudentDairyService.AcadStudentDairyGet(id, userid, tokenid, BatchId, GradeId)
            });
        }
        public IHttpActionResult AcadStudentDairyUpdate(AcadStudentDairy acadStudentDairyUpdate)
        {
            var isUpdate = acadStudentDairyService.AcadStudentDairyUpdate(acadStudentDairyUpdate.UniversityId, acadStudentDairyUpdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
