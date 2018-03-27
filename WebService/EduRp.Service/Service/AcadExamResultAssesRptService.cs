using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadExamResultAssesRptService : IAcadExamResultAssesRptService
    {

        encomp_devEntities db = new encomp_devEntities();

        public List<AcadExamResultAssesRptGet_Result> AcadExamResultAssesRptGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId,int? studentId)
        {
            return db.AcadExamResultAssesRptGet(id, userid, tokenid, batchid, Sectionid, GradeId,studentId).ToList();
        }

     

        public List<AcadExamResultAssesRptStudentsGet_Result> AcadExamResultAssesRptStudentGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId)
        {
            return db.AcadExamResultAssesRptStudentsGet(id, userid, tokenid, batchid, Sectionid, GradeId).ToList();
        }

        public bool AcadExamResultAssesRptUpdate(int? id, AcadExamResultAssesRpt acadExamResultAssesRpt)
        {
            try
            {
                var acadExamResultAssesRptObj = JsonConvert.SerializeObject(acadExamResultAssesRpt);

                var JsonObj = db.AcadConductLetterPermisUpdate(id, acadExamResultAssesRptObj);

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