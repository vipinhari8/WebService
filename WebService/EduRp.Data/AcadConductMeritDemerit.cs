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
    
    public partial class AcadConductMeritDemerit
    {
        public int AcadConductMeritDemeritId { get; set; }
        public int StudentId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string GoodConduct { get; set; }
        public string MisConduct { get; set; }
        public string ActionTeacher { get; set; }
        public string Venue { get; set; }
        public string Witness { get; set; }
        public Nullable<int> UniversityId { get; set; }
        public Nullable<byte> active { get; set; }
        public Nullable<System.DateTime> lastupdateddt { get; set; }
        public Nullable<int> lastupdatedby { get; set; }
    }
}
