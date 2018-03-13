using EduRp.Data;
using EduRp.Data.ViewModel;
using EduRp.Service.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduRp.Service.Service
{
    public class ExaminationScheduleService : IExaminationScheduleService
    {
        private encomp_devEntities db = new encomp_devEntities();

        public List<GetExaminationDetail_Result> GetExaminationDetail(int? id,int? userid,string tokenid,int? examinationtypeid)
        {
            return db.GetExaminationDetail(id,userid,tokenid, examinationtypeid).ToList();
        }

        public List<GetExaminationSchedule_Result> GetExaminationSchedule(int? id, int? userid, string tokenid,int? batchid,int? psid,int? courseid,int? examinationtypeid)
        {
            return db.GetExaminationSchedule(id, userid, tokenid, batchid, psid, courseid, examinationtypeid).ToList();
        }
        public List<GetStudentExamScheduleByAdminNo_Result> GetStudentExamScheduleByAdminNo(int? id, int? userid, string tokenid, string admissionnumber)
        {
            return db.GetStudentExamScheduleByAdminNo(id, userid, tokenid, admissionnumber).ToList();
        }

        public bool UpdateExaminationSchedule(int? id , ScheduleExamModel scheduleExam)
        {
            try
            {
                var obj = JsonConvert.SerializeObject
                 (new ScheduleExamModel
                 {
                     BatchId = scheduleExam.BatchId,
                     CourseId = scheduleExam.CourseId,
                     ProgramStudyId = scheduleExam.ProgramStudyId,
                     GenerateHallTicketDate = scheduleExam.GenerateHallTicketDate,
                     ExaminationTypeId = scheduleExam.ExaminationTypeId,
                     ExaminationScheduleId = scheduleExam.ExaminationScheduleId,
                     ExaminationDate = scheduleExam.ExaminationDate,
                     StartTime = scheduleExam.StartTime,
                     EndTime = scheduleExam.EndTime,
                     UniversityId = scheduleExam.UniversityId,
                     UserId = scheduleExam.UserId,
                     TokenId = scheduleExam.TokenId,

                 });


                var ExamSchObj = obj.ToString();

                var JsonObj = db.UpdateExaminationSchedule(scheduleExam.UniversityId, ExamSchObj);

                return true;
                //db.ClassRoomMasters.Add(getExaminationSchedule);
                //db.SaveChanges();
                //return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }

        }

        public bool UpdateExaminationScheduleDetail(int? id, ClassRoomStaffAssociationModel classroomstaffAssociation)
        {
            try
            {
                var obj = JsonConvert.SerializeObject
                 (new ClassRoomStaffAssociationModel
                 {
                     ExaminationScheduleDetailId = classroomstaffAssociation.ExaminationScheduleDetailId,
                     ExaminationScheduleId = classroomstaffAssociation.ExaminationScheduleId,
                     RoomId = classroomstaffAssociation.RoomId,
                     Staff1Id = classroomstaffAssociation.Staff1Id,
                     Staff2Id = classroomstaffAssociation.Staff2Id,
                     UniversityId = classroomstaffAssociation.UniversityId,
                     UserId = classroomstaffAssociation.UserId,
                     TokenId = classroomstaffAssociation.TokenId

                 });


                var ExamSchObj = obj.ToString();

                var JsonObj = db.UpdateExaminationSchedule(id, ExamSchObj);

                return true;
                //db.ClassRoomMasters.Add(getExaminationSchedule);
                //db.SaveChanges();
                //return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }

        //public bool UpdateExaminationScheduleDetail(int? id, GetExaminationDetail getExaminationDetail)
        //{

        //}

        public bool UpdateExaminationStudent()
        {
            throw new NotImplementedException();
        }
        //public List<GetExamScheduleClassRoom_Result> GetExamScheduleClassRoom(int? id, int? userid, string tokenid)
        //{
        //    return db.GetExamScheduleClassRoom(id, userid, tokenid, batchid, psid, courseid, examinationtypeid).ToList();
        //}

        //public List<GetExamScheduleStaff_Result> GetExamScheduleStaff(int? id, int? userid, string tokenid)
        //{
        //    return db.GetExamScheduleStaff(id, userid, tokenid, batchid, psid, courseid, examinationtypeid).ToList();
        //}
    }
}