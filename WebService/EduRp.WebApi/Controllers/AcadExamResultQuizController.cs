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
    public class AcadExamResultQuizController : ApiController
    {
        private IAcadExamResultQuizService acadExamResultQuizService = new AcadExamResultQuizService();
        [HttpGet]
        public IHttpActionResult AcadExamResultQuizisGet(int? id, int? userid, string token, int? batchid,int? GradeId, int? SectionId)
        {
            return Ok(new
            {
                results = acadExamResultQuizService.AcadExamResultQuizGet(id, userid, token, batchid, GradeId, SectionId)
            });
        }

        public IHttpActionResult AcadExamResultQuizUpdate(AcadExamResultQuiz acadExamResultQuiz)
        {
            var isUpdate = acadExamResultQuizService.AcadExamResultQuizUpdate(acadExamResultQuiz.UniversityId, acadExamResultQuiz);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }

    }
}
