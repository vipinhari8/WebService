using EduRp.Data;
using EduRp.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
    public interface IExaminationScheduleService
    {
        List<GetExaminationDetail_Result> GetExaminationDetail(int? id, int? userid, string tokenid,int? examinationtypeid);
        List<GetExaminationSchedule_Result> GetExaminationSchedule(int? id, int? userid, string tokenid, int? batchid, int? psid, int? courseid, int? examinationtypeid);
        List<GetStudentExamScheduleByAdminNo_Result> GetStudentExamScheduleByAdminNo(int? id, int? userid, string tokenid, string admissionnumber);
        //List<GetExamScheduleClassRoom_Result> GetExamScheduleClassRoom(int? id, int? userid, string tokenid);
        //List<GetExamScheduleStaff_Result> GetExamScheduleStaff(int? id, int? userid, string tokenid);

        bool UpdateExaminationSchedule(int? id, ScheduleExamModel scheduleExam);
        //bool UpdateExaminationScheduleDetail();
        bool UpdateExaminationScheduleDetail(int? id, ClassRoomStaffAssociationModel classroomstaffAssociation);

    }
}
