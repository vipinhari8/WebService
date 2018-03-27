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
    public class AcadHcareNurseNoteController : ApiController
    {
        private IAcadHcareNurseNoteGetService AcadHcareNurseNoteservice = new AcadHcareNurseNoteService();

        [HttpGet]
        public IHttpActionResult AcadHcareNurseNoteGet(int? id, int? userid, string tokenid, int? batchid, int? GradeId, int? SectionId, int? studentid)
        {
            return Ok(new
            {
                results = AcadHcareNurseNoteservice.AcadHcareNurseNoteGet(id, userid, tokenid, batchid, GradeId, SectionId, studentid)
            });
        }
        public IHttpActionResult AcadHcareNurseNoteUpdate(AcadExExamSyllabu AcadHcareNurseNoteupdate)
        {
            var isUpdate = AcadHcareNurseNoteservice.AcadHcareNurseNoteUpdate(AcadHcareNurseNoteupdate.UniversityId, AcadHcareNurseNoteupdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
