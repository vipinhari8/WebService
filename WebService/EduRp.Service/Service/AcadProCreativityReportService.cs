using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadProCreativityReportService : IAcadProCreativityReportService
    {
        encomp_devEntities db = new encomp_devEntities();
        public List<AcadProCreativityReportGet_Result> AcadProCreativityReportGet(int? id, int? userid, string tokenid, int? BatchId, int? GradeId, int? SectionId)
        {
            return db.AcadProCreativityReportGet(id, userid, tokenid, BatchId, GradeId, SectionId).ToList();
        }

        public bool AcadProCreativityReportUpdate(int? id, AcadProCreativityReport acadProCreativityReport)
        {
            try
            {
                var AcadProCreativityReportupdatedisObj = JsonConvert.SerializeObject(acadProCreativityReport);

                var JsonObj = db.AcadProCreativityReportUpdate(id, AcadProCreativityReportupdatedisObj);

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