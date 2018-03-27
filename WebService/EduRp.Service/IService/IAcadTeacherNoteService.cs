using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
   public interface IAcadTeacherNoteService
    {
        List<AcadTeacherNote> AcadTeacherNoteGet(int? id, int? userid, string token, int? BatchId, int? GradeId, int? Section);
        bool AcadTeacherNoteUpdate(int? id, AcadTeacherNote acadTeacherNoteupdate);
    }
}
