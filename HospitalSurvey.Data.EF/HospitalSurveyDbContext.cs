using HospitalSurvey.Data.Configurations;
using HospitalSurvey.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HospitalSurvey.Data.EF
{
    public class HospitalSurveyDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public HospitalSurveyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configure using Fluent API
            builder.ApplyConfiguration(new FeedbackConfiguration());

            builder.ApplyConfiguration(new AnnouncementConfiguration());
            builder.ApplyConfiguration(new AnnouncementUserConfiguration());


            builder.ApplyConfiguration(new AppConfigConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());


            builder.ApplyConfiguration(new FunctionConfiguration());
            builder.ApplyConfiguration(new HospitalDepartmentConfiguration());
            builder.ApplyConfiguration(new PatientConfiguration());
            builder.ApplyConfiguration(new PermissionConfiguration());
            builder.ApplyConfiguration(new PermissionDetailConfiguration());
            builder.ApplyConfiguration(new SatisfactionLevelConiguration());
            builder.ApplyConfiguration(new StaffConfiguration());
            builder.ApplyConfiguration(new SurveyFormConfiguration());
            builder.ApplyConfiguration(new SurveyFormDetailConfiguration());
            builder.ApplyConfiguration(new SurveyQuestionConfiguration());


            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);


            // base.OnModelCreating(builder);
        }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }



        public DbSet<Function> Functions { get; set; }
        public DbSet<HospitalDepartment> HospitalDepartments { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionDetail> PermissionDetails { get; set; }
        public DbSet<SatisfactionLevel> SatisfactionLevels { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<SurveyForm> SurveyForms { get; set; }
        public DbSet<SurveyFormDetail> SurveyFormDetails { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }


    }
}
