using EduRp.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduRp.Data.ViewModel
{
    public class UpdateStudentApplicationFormDetail: Entity
    {
        public Nullable<int> ApplicationFormId { get; set; }
        public int AppFormGroupId { get; set; }
        public string AppFormGroupLabel { get; set; }
        public string AppFormGroupName { get; set; }
        public int AppFormFieldId { get; set; }
        public string FieldName { get; set; }
        public string Value { get; set; }
        public int? Status { get; set; }
    }
}