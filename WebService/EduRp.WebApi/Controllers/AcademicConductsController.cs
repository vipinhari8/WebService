using EduRp.Data;
using EduRp.Service.IService;
using EduRp.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EduRp.WebApi.Controllers
{
    public class AcademicConductsController:ApiController
    {
        private IAcademicConductService academicConductService = new AcademicConductService();

        [HttpGet]
        public IHttpActionResult AcadConductLetterPermisGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return Ok(new
            {
                results = academicConductService.AcadConductLetterPermisGet(id, userid, token, batchid, programstudyid, courseid, studentid)
            });
        }
        [HttpGet]
        public IHttpActionResult AcadConductLostFoundGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return Ok(new
            {
                results = academicConductService.AcadConductLostFoundGet(id, userid, token, batchid, programstudyid, courseid, studentid)
            });
        }
        [HttpGet]
        public IHttpActionResult AcadConductMeritDemeritGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return Ok(new
            {
                results = academicConductService.AcadConductMeritDemeritGet(id, userid, token, batchid, programstudyid, courseid, studentid)
            });
        }
        [HttpGet]
        public IHttpActionResult AcadConductMYLGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return Ok(new
            {
                results = academicConductService.AcadConductMYLGet(id, userid, token, batchid, programstudyid, courseid, studentid)
            });
        }
        [HttpGet]
        public IHttpActionResult AcadConductStudentCharacterGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid)
        {
            return Ok(new
            {
                results = academicConductService.AcadConductStudentCharacterGet(id, userid, token, batchid, programstudyid, courseid)
            });
        }
        public IHttpActionResult AcadConductLetterPermisUpdate(AcadConductLetterPermi acadConductLetterPermi)
        {
            var isUpdate = academicConductService.AcadConductLetterPermisUpdate(acadConductLetterPermi.UniversityId, acadConductLetterPermi);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
        public IHttpActionResult AcadConductLostFoundUpdate(AcadConductLostFound acadConductLostFound)
        {
            var isUpdate = academicConductService.AcadConductLostFoundUpdate(acadConductLostFound.UniversityId, acadConductLostFound);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
        public IHttpActionResult AcadConductMeritDemeritUpdate(AcadConductMeritDemerit acadConductMeritDemerit)
        {
            var isUpdate = academicConductService.AcadConductMeritDemeritUpdate(acadConductMeritDemerit.UniversityId, acadConductMeritDemerit);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
        public IHttpActionResult AcadConductMYLUpdate(AcadConductMYL acadConductMYL)
        {
            var isUpdate = academicConductService.AcadConductMYLUpdate(acadConductMYL.UniversityId, acadConductMYL);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
        public IHttpActionResult AcadConductStudentCharacterUpdate(AcadConductStudentCharacter acadConductStudentCharacter)
        {
            var isUpdate = academicConductService.AcadConductStudentCharacterUpdate(acadConductStudentCharacter.UniversityId, acadConductStudentCharacter);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}