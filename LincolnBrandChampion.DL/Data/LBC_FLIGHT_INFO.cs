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
    
    public partial class LBC_FLIGHT_INFO
    {
        public decimal REGD_SEQ_NUM { get; set; }
        public string STARS_ID { get; set; }
        public Nullable<decimal> EVENT_ID { get; set; }
        public Nullable<System.DateTime> ARR_DATE { get; set; }
        public string ARR_TIME { get; set; }
        public string ARR_AIRLINE { get; set; }
        public string ARR_FLIGHT_NUM { get; set; }
        public string ARR_CITY { get; set; }
        public Nullable<System.DateTime> DEP_DATE { get; set; }
        public string DEP_TIME { get; set; }
        public string DEP_AIRLINE { get; set; }
        public string DEP_FLIGHT_NUM { get; set; }
        public string DEP_CITY { get; set; }
        public string DEP_DEST_CITY { get; set; }
        public string MULTI_FLAG { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string ARR_DEP_CITY { get; set; }
        public string ARR_TERMINAL { get; set; }
        public string CONNECTING_FLIGHT_NOTES { get; set; }
    
        public virtual LBC_EVENT LBC_EVENT { get; set; }
    }
}