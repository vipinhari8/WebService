using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadLessonPlanService : IAcadLessonPlanService
    {
        encomp_devEntities db = new encomp_devEntities();
        public List<AcadLessonPlanGet_Result> AcadLessonPlanGet(int? id, int? userid, string tokenid,int? batchid , int? SubjectId)
        {
            return db.AcadLessonPlanGet(id,userid,tokenid,batchid, SubjectId).ToList();
        }

        public bool AcadLessonPlanUpdate(int? id, AcadLessonPlan acadLessonPlanupdate)
        {
            try
            {
                var AcadLessonPlanupdatedisObj = JsonConvert.SerializeObject(acadLessonPlanupdate);

                var JsonObj = db.AcadLessonPlanUpdate(id, AcadLessonPlanupdatedisObj);

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