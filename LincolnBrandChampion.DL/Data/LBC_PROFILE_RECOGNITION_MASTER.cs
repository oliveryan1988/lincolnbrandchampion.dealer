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
    
    public partial class LBC_PROFILE_RECOGNITION_MASTER
    {
        public LBC_PROFILE_RECOGNITION_MASTER()
        {
            this.LBC_PROFILE_RECOGNITION = new HashSet<LBC_PROFILE_RECOGNITION>();
        }
    
        public decimal RECOGNITION_ID { get; set; }
        public string RECOGNITION_DESC { get; set; }
        public string RECOGNITION_TITLE { get; set; }
        public string CATEGORY { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
    
        public virtual ICollection<LBC_PROFILE_RECOGNITION> LBC_PROFILE_RECOGNITION { get; set; }
    }
}