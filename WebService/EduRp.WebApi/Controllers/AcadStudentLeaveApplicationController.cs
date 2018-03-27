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
    public class AcadStudentLeaveApplicationController : ApiController
    {
        private IAcadStudentLeaveApplicationService acadStudentLeaveApplicationservice = new AcadStudentLeaveApplicationService();

        [HttpGet]
        public IHttpActionResult AcadStudentLeaveApplicationGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId, int? studentid)
        {
            return Ok(new
            {
                results = acadStudentLeaveApplicationservice.AcadStudentLeaveApplicationGet(id, userid, tokenid, batchid, Sectionid, GradeId, studentid).ToList()
        
        });
        }

        public IHttpActionResult AcadStudentLeaveApplicationUpdate(AcadStudentLeaveApplication acadStudentLeaveApplicationUpdate)
        {
            var isUpdate = acadStudentLeaveApplicationservice.AcadStudentLeaveApplicationUpdate(acadStudentLeaveApplicationUpdate.UniversityId, acadStudentLeaveApplicationUpdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
    
}
