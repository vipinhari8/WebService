using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
   public interface IAcadExamResultAssesRptService
    {
        List<AcadExamResultAssesRptGet_Result> AcadExamResultAssesRptGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId,int? StudentId);
        List<AcadExamResultAssesRptStudentsGet_Result> AcadExamResultAssesRptStudentGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId);
        bool AcadExamResultAssesRptUpdate(int? id, AcadExamResultAssesRpt acadExamResultAssesRpt);
    }
}
