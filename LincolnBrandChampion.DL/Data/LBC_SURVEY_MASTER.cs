//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LincolnBrandChampion.DL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class LBC_SURVEY_MASTER
    {
        public LBC_SURVEY_MASTER()
        {
            this.LBC_SURVEY_QUESTIONS = new HashSet<LBC_SURVEY_QUESTIONS>();
        }
    
        public decimal SURVEY_ID { get; set; }
        public string SURVEY_DESC { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
    
        public virtual ICollection<LBC_SURVEY_QUESTIONS> LBC_SURVEY_QUESTIONS { get; set; }
    }
}
