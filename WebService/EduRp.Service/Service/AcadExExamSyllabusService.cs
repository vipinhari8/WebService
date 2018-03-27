using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadExExamSyllabusService : IAcadExExamSyllabusService
    {
        private encomp_devEntities db = new encomp_devEntities();
        public List<AcadExExamSyllabusGet_Result> AcadExExamSyllabusGet(int? id, int? userid, string tokenid, int? batchid, int? studentid)
        {
            return db.AcadExExamSyllabusGet(id, userid, tokenid, batchid, studentid).ToList();
        }

        public bool AcadExExamSyllabusUpdate(int? id, AcadExExamSyllabu AcadExExamSyllabusupdated)
        {
            try
            {
                var AcadExExamSyllabusupdatedisObj = JsonConvert.SerializeObject(AcadExExamSyllabusupdated);

                var JsonObj = db.AcadExExamSyllabusUpdate(id, AcadExExamSyllabusupdatedisObj);

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