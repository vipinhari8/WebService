//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduRp.Data
{
    using EduRp.Data.Core.Foundation;
    using System;
    using System.Collections.Generic;
    
    public partial class ClassRoomMaster:BaseEntity
    {
        public int ClassRoomId { get; set; }
        public string BuildingCode { get; set; }
        public string BuildingName { get; set; }
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public Nullable<int> CapacityOfRoom { get; set; }
        public string Facility { get; set; }
        public string Location { get; set; }
        public Nullable<int> UniversityId { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<System.DateTime> lastupdateddt { get; set; }
        public Nullable<int> lastupdatedby { get; set; }
    }
}
