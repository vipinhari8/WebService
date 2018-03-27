using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduRp.Data;
using Newtonsoft.Json;

namespace EduRp.Service.Service
{
    public class AcadStudentLeaveApplicationService : IAcadStudentLeaveApplicationService
    {
        encomp_devEntities db = new encomp_devEntities();
        public List<AcadStudentLeaveApplicationGet_Result> AcadStudentLeaveApplicationGet(int? id, int? userid, string tokenid, int? batchid, int? Sectionid, int? GradeId, int? studentid)
        {
            return db.AcadStudentLeaveApplicationGet(id, userid, tokenid, batchid, Sectionid, GradeId, studentid).ToList();
        }

        public bool AcadStudentLeaveApplicationUpdate(int? id, AcadStudentLeaveApplication acadStudentLeaveApplicationupdate)
        {
            try
            {
                var AcadStudentLeaveApplicationupdatedisObj = JsonConvert.SerializeObject(acadStudentLeaveApplicationupdate);

                var JsonObj = db.AcadStudentLeaveApplicationUpdate(id, AcadStudentLeaveApplicationupdatedisObj);

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