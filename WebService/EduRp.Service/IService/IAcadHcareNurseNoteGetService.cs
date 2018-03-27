using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
  public  interface IAcadHcareNurseNoteGetService
    {

        List<AcadHcareNurseNoteGet_Result> AcadHcareNurseNoteGet(int? id, int? userid, string tokenid, int? batchid, int? GradeId,int? SectionId,int? studentid);
        bool AcadHcareNurseNoteUpdate (int? id, AcadExExamSyllabu AcadHcareNurseNoteupdated);


    }
}
