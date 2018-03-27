using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
   public interface IAcadExamResultQuizService
    {
        List<AcadExamResultQuizGet_Result> AcadExamResultQuizGet(int? id, int? userid, string tokenid, int? batchid, int? GradeId, int? Sectionid );

        bool AcadExamResultQuizUpdate(int? id, AcadExamResultQuiz acadExamResultQuiz);
    }
}
