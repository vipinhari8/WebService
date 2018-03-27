using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadExamResultPhEduService : IAcadExamResultPhEduService
    {
        encomp_devEntities db = new encomp_devEntities();

        public List<AcadExamResultPhEduGet_Result> AcadExamResultPhEduGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId)
        {
            return db.AcadExamResultPhEduGet(id, userid, tokenid, batchid, Sectionid, GradeId).ToList();
        }

        public bool AcadExamResultPhEduUpdate(int? id, AcadExamResultPhEdu acadExamResultPhEdu)
        {
            try
            {
                var acadExamResultPhEduObj = JsonConvert.SerializeObject(acadExamResultPhEdu);

                var JsonObj = db.AcadExamResultPhEduUpdate(id, acadExamResultPhEduObj);

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