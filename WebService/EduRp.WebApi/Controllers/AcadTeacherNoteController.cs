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
    public class AcadTeacherNoteController : ApiController
    {
        private IAcadTeacherNoteService acadTeacherNoteService = new AcadTeacherNoteService();
        public IHttpActionResult AcadTeacherNoteUpdate(AcadTeacherNote acadTeacherNoteUpade)
        {
            var isUpdate = acadTeacherNoteService.AcadTeacherNoteUpdate(acadTeacherNoteUpade.UniversityId, acadTeacherNoteUpade);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
