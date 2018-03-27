using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadStudentDairyService : IAcadStudentDairyService
    {
        private encomp_devEntities db = new encomp_devEntities();
        public List<AcadStudentDairyGet_Result> AcadStudentDairyGet(int? id, int? userid, string tokenid,int? BatchId, int? GradeId)
        {
            return db.AcadStudentDairyGet(id, userid, tokenid, GradeId, BatchId).ToList();
        }

        public bool AcadStudentDairyUpdate(int? id, AcadStudentDairy acadStudentDairyupdate)
        {
            try
            {
                var AcadStudentDairyupdatedisObj = JsonConvert.SerializeObject(acadStudentDairyupdate);

                var JsonObj = db.AcadStudentDairyUpdate(id, AcadStudentDairyupdatedisObj);

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