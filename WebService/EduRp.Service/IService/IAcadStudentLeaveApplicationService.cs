using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
  public interface IAcadStudentLeaveApplicationService
    {
        List<AcadStudentLeaveApplicationGet_Result> AcadStudentLeaveApplicationGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId, int? studen);
        bool AcadStudentLeaveApplicationUpdate(int? id, AcadStudentLeaveApplication acadStudentLeaveApplicationupdate);
    }
}
