using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
   public interface IAcadExExamSyllabusService
    {
        List<AcadExExamSyllabusGet_Result> AcadExExamSyllabusGet(int? id, int? userid, string tokenid, int? batchid,int? studentid);

        bool AcadExExamSyllabusUpdate(int? id, AcadExExamSyllabu AcadExExamSyllabusUpdateupdated);
    }

}
