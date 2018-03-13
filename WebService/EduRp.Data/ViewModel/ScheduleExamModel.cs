using EduRp.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduRp.Data.ViewModel
{
    public class ScheduleExamModel:Entity
    {
        public int? ExaminationScheduleId { get; set; }
        public int? ExaminationTypeId { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? GenerateHallTicketDate { get; set; }
        public int? BatchId { get; set; }
        public int? ProgramStudyId { get; set; }
        public int? CourseId { get; set; }
 
    }
}