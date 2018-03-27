using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadExamResultQuizService : IAcadExamResultQuizService
    {
        encomp_devEntities db = new encomp_devEntities();

        public List<AcadExamResultQuizGet_Result> AcadExamResultQuizGet(int? id, int? userid, string tokenid, int? batchid, int? GradeId, int? Sectionid)
        {
            return db.AcadExamResultQuizGet(id, userid, tokenid, batchid, GradeId, Sectionid).ToList();
        }

        public bool AcadExamResultQuizUpdate(int? id, AcadExamResultQuiz acadExamResultQuizupdate)
        {
            try
            {
                var acadExamResultQuizupdatedisObj = JsonConvert.SerializeObject(acadExamResultQuizupdate);

                var JsonObj = db.AcadExamResultQuizUpdate(id, acadExamResultQuizupdatedisObj);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }
    }
}