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
    
    public partial class BatchApplicationFormAssociation
    {
        public int BatchApplicationFormId { get; set; }
        public int BatchId { get; set; }
        public int ApplicationFormId { get; set; }
        public Nullable<int> UniversityId { get; set; }
    }
}