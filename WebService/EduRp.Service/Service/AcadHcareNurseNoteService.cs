using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadHcareNurseNoteService : IAcadHcareNurseNoteGetService
    {
        private encomp_devEntities db = new encomp_devEntities();
        public List<AcadHcareNurseNoteGet_Result> AcadHcareNurseNoteGet(int? id, int? userid, string tokenid, int? batchid, int? GradeId, int? SectionId, int? studentid)
        {
            return db.AcadHcareNurseNoteGet(id, userid, tokenid, batchid, GradeId, SectionId, studentid).ToList();
        }

        public bool AcadHcareNurseNoteUpdate(int? id, AcadExExamSyllabu AcadHcareNurseNoteupdated)
        {
            try
            {
                var AcadHcareNurseNoteupdateisObj = JsonConvert.SerializeObject(AcadHcareNurseNoteupdated);

                var JsonObj = db.AcadHcareNurseNoteUpdate(id, AcadHcareNurseNoteupdateisObj);

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