﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LBCData : DbContext
    {
        public LBCData()
            : base("name=LBCData")
        {
        }
        public LBCData(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<LBC_DIETARY_RESTRICTIONS> LBC_DIETARY_RESTRICTIONS { get; set; }
        public DbSet<LBC_LOGIN_TRACKING> LBC_LOGIN_TRACKING { get; set; }
        public DbSet<LBC_PROFILE_HISTORY> LBC_PROFILE_HISTORY { get; set; }
        public DbSet<LBC_PROFILE_RECOGNITION> LBC_PROFILE_RECOGNITION { get; set; }
        public DbSet<LBC_PROFILE_RECOGNITION_MASTER> LBC_PROFILE_RECOGNITION_MASTER { get; set; }
        public DbSet<LBC_SHIRT_SIZE> LBC_SHIRT_SIZE { get; set; }
        public DbSet<LBC_USER_ROLE> LBC_USER_ROLE { get; set; }
        public DbSet<LBC_USERS> LBC_USERS { get; set; }
        public DbSet<LBC_EVENT> LBC_EVENT { get; set; }
        public DbSet<LBC_FLIGHT_INFO_DETAILS> LBC_FLIGHT_INFO_DETAILS { get; set; }
        public DbSet<LBC_IMMERSION_COURSE> LBC_IMMERSION_COURSE { get; set; }
        public DbSet<LBC_HOTEL_CAR_INFO> LBC_HOTEL_CAR_INFO { get; set; }
        public DbSet<LBC_REGISTRATION> LBC_REGISTRATION { get; set; }
        public DbSet<LBC_FLIGHT_INFO> LBC_FLIGHT_INFO { get; set; }
        public DbSet<AIRLINES_INFO> AIRLINES_INFO { get; set; }
        public DbSet<LBC_EVENT_SESSION_LOOKUP> LBC_EVENT_SESSION_LOOKUP { get; set; }
        public DbSet<LBC_GUEST_REGD_SESSION> LBC_GUEST_REGD_SESSION { get; set; }
        public DbSet<LBC_GUEST_REGISTRATION> LBC_GUEST_REGISTRATION { get; set; }
        public DbSet<LBC_INSTITUTION_ENROLL_REPORT> LBC_INSTITUTION_ENROLL_REPORT { get; set; }
        public DbSet<LBC_SURVEY_MASTER> LBC_SURVEY_MASTER { get; set; }
        public DbSet<LBC_SURVEY_QUESTIONS> LBC_SURVEY_QUESTIONS { get; set; }
        public DbSet<LBC_SURVEY_QUESTION_ANSWER> LBC_SURVEY_QUESTION_ANSWER { get; set; }
        public DbSet<LBC_SURVERY_COMPLETED> LBC_SURVERY_COMPLETED { get; set; }
        public DbSet<LBC_SURVEY_TAKEN> LBC_SURVEY_TAKEN { get; set; }
        public DbSet<LBC_SURVEY_REPORT_VW> LBC_SURVEY_REPORT_VW { get; set; }
        public DbSet<LBC_SURVEY_COMPLETED_VIEW> LBC_SURVEY_COMPLETED_VIEW { get; set; }
        public DbSet<LBC_CHECKPOINT> LBC_CHECKPOINT { get; set; }
        public DbSet<LBC_CHECKPOINT_COMPLETED> LBC_CHECKPOINT_COMPLETED { get; set; }
        public DbSet<LBC_CHECKPOINT_TRACKING> LBC_CHECKPOINT_TRACKING { get; set; }
        public DbSet<LBC_RESOURCE_TRACKING> LBC_RESOURCE_TRACKING { get; set; }
        public DbSet<LBC_STORY> LBC_STORY { get; set; }
        public DbSet<LBC_STORY_CATEGORY> LBC_STORY_CATEGORY { get; set; }
        public DbSet<LBC_STORY_RATING> LBC_STORY_RATING { get; set; }
        public DbSet<LBC_STORY_REJECT_REASON> LBC_STORY_REJECT_REASON { get; set; }
        public DbSet<LBC_STORY_SUBCATEGORY> LBC_STORY_SUBCATEGORY { get; set; }
        public DbSet<LBC_TRANSPORTATION_NEED> LBC_TRANSPORTATION_NEED { get; set; }
        public DbSet<LBC_CHECKPOINT_VW> LBC_CHECKPOINT_VW { get; set; }
        public DbSet<LBC_PROFILE> LBC_PROFILE { get; set; }
    }
}