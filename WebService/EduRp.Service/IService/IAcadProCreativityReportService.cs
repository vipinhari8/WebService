using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
  public  interface IAcadProCreativityReportService
    {
        List<AcadProCreativityReportGet_Result> AcadProCreativityReportGet(int? id, int? userid, string tokenid, int? BatchId, int? GradeId,int? SectionId);
        bool AcadProCreativityReportUpdate(int? id, AcadProCreativityReport acadProCreativityReport);
    }
}
