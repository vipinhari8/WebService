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
    using EduRp.Data.Core;
    using System;
    
    public partial class GetApplicationFormDetail_Result:Entity
    {
        public Nullable<int> ApplicationFormId { get; set; }
        public int AppFormGroupId { get; set; }
        public string AppFormGroupLabel { get; set; }
        public int AppFormFieldId { get; set; }
        public string FieldName { get; set; }
        public string Value { get; set; }
    }
}