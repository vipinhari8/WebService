using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
  public interface IAcadLessonPlanService
    {

        List<AcadLessonPlanGet_Result> AcadLessonPlanGet(int? id, int? userid, string tokenid,int? batchid, int? SubjectId);
        bool AcadLessonPlanUpdate(int? id, AcadLessonPlan acadLessonPlanupdate);
    }
}
