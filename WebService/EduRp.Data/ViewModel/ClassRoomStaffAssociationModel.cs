using EduRp.Data.Core;
using EduRp.Data.Core.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduRp.Data.ViewModel
{
    public class ClassRoomStaffAssociationModel: Core.Entity
    {
        public int? ExaminationScheduleDetailId { get; set; }
        public int? ExaminationScheduleId { get; set; }
        public int RoomId { get; set; }
        public int Staff1Id { get; set; }
        public int Staff2Id { get; set; }
    }
}