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
    
    public partial class @event
    {
        public int event_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> event_start { get; set; }
        public Nullable<System.DateTime> event_end { get; set; }
        public Nullable<bool> all_day { get; set; }
    }
}
