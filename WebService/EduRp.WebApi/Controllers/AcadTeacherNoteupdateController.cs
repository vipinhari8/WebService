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
    public class AcadTeacherNoteupdateController : ApiController
    {
        private IAcadTeacherNoteService acadTeacherNoteService = new AcadTeacherNoteService();

        [HttpGet]
        public IHttpActionResult AcadTeacherNoteGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId)
        {
            return Ok(new
            {
                results = acadTeacherNoteService.AcadTeacherNoteGet(id, userid, tokenid, batchid, Sectionid, GradeId)
            });
        }
        public IHttpActionResult AcadTeacherNoteUpdate(AcadTeacherNote acadTeacherNoteupdate)
        {
            var isUpdate = acadTeacherNoteService.AcadTeacherNoteUpdate(acadTeacherNoteupdate.UniversityId, acadTeacherNoteupdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
