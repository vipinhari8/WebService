using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
   public interface IAcadExamResultPhEduService
    {
        List<AcadExamResultPhEduGet_Result> AcadExamResultPhEduGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId);
        bool AcadExamResultPhEduUpdate(int? id, AcadExamResultPhEdu acadExamResultPhEdu);
    }
}
