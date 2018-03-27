using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{

    public class AcadTeacherNoteService : IAcadTeacherNoteService
    {
        encomp_devEntities db = new encomp_devEntities();

        public List<AcadTeacherNote> AcadTeacherNoteGet(int? id, int? userid, string token, int? BatchId, int? GradeId, int? Section)
        {
            throw new NotImplementedException();
           
        }

       

        public bool AcadTeacherNoteUpdate(int? id, AcadTeacherNote acadTeacherNoteupdate)
        {
            try
            {
                var acadTeacherNoteisObj = JsonConvert.SerializeObject(acadTeacherNoteupdate);

                var JsonObj = db.AcadTeacherNoteUpdate(id, acadTeacherNoteisObj);

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