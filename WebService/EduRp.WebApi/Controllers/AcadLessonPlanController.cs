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
    public class AcadLessonPlanController : ApiController
    {
        private IAcadLessonPlanService acadLessonPlanService = new AcadLessonPlanService();

        [HttpGet]
        public IHttpActionResult AcadLessonPlanGet(int? id, int? userid, string token, int? batchid, int? SubjectId)
        {
            return Ok(new
            {
                results = acadLessonPlanService.AcadLessonPlanGet(id, userid, token, batchid, SubjectId)
            });
        }


      
        public IHttpActionResult AcadLessonPlanUpdate(AcadLessonPlan acadLessonPlanUpdate)
        {
            var isUpdate = acadLessonPlanService.AcadLessonPlanUpdate(acadLessonPlanUpdate.UniversityId, acadLessonPlanUpdate);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
    }
}
