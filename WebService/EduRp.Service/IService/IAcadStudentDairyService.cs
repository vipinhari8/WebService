using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
  public  interface IAcadStudentDairyService
    {
        List<AcadStudentDairyGet_Result> AcadStudentDairyGet(int? id, int? userid, string tokenid,int? BatchId, int? GradeId);
        bool AcadStudentDairyUpdate(int? id, AcadStudentDairy acadStudentDairyupdate);
    }
}
