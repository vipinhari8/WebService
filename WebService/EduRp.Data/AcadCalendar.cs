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
    using System;
    using System.Collections.Generic;
    
    public partial class AcadCalendar
    {
        public int AcadCalendarId { get; set; }
        public Nullable<int> BatchId { get; set; }
        public Nullable<int> GradeId { get; set; }
        public string EventName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<System.DateTime> StartDatetime { get; set; }
        public Nullable<System.DateTime> EndDatetime { get; set; }
        public Nullable<byte> HolidayFlag { get; set; }
        public Nullable<int> UniversityId { get; set; }
        public Nullable<byte> active { get; set; }
        public Nullable<System.DateTime> lastupdateddt { get; set; }
        public Nullable<int> lastupdatedby { get; set; }
    }
}
