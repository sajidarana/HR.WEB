    using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HR.DATA.Models;

#nullable disable

namespace HR.DATA.Data
{
    public partial class test1Context : DbContext
    {
        public test1Context()
        {
        }

        public test1Context(DbContextOptions<test1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspnetrole> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetroleclaim> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetuser> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetuserclaim> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogin> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserrole> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusertoken> Aspnetusertokens { get; set; }
        public virtual DbSet<CertificationUpdated> CertificationUpdateds { get; set; }
        public virtual DbSet<ChildClassLevel> ChildClassLevels { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<EducationUpdated> EducationUpdateds { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<EntityName> EntityNames { get; set; }
        public virtual DbSet<Etfmigrationshistory> Etfmigrationshistories { get; set; }
        public virtual DbSet<ExperienceBlock> ExperienceBlocks { get; set; }
        public virtual DbSet<ExperienceUpdated> ExperienceUpdateds { get; set; }
        public virtual DbSet<FileMaster> FileMasters { get; set; }
        public virtual DbSet<Migration> Migrations { get; set; }
        public virtual DbSet<ParentClassLevel> ParentClassLevels { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<PhrasesOnExperienceBlock> PhrasesOnExperienceBlocks { get; set; }
        public virtual DbSet<ProfileUpdated> ProfileUpdateds { get; set; }
        public virtual DbSet<Requisitioncompareresume> Requisitioncompareresumes { get; set; }
        public virtual DbSet<Requisitioncontactresume> Requisitioncontactresumes { get; set; }
        public virtual DbSet<Requisitionshortlistresume> Requisitionshortlistresumes { get; set; }
        public virtual DbSet<ResumeHeader> ResumeHeaders { get; set; }
        public virtual DbSet<ResumeJob> ResumeJobs { get; set; }
        public virtual DbSet<ResumeScore> ResumeScores { get; set; }
        public virtual DbSet<ResumeSectionInfo> ResumeSectionInfos { get; set; }
        public virtual DbSet<ResumeTermPercentage> ResumeTermPercentages { get; set; }
        public virtual DbSet<ResumeWordCount> ResumeWordCounts { get; set; }
        public virtual DbSet<Talent> Talents { get; set; }
        public virtual DbSet<Tblbenefit> Tblbenefits { get; set; }
        public virtual DbSet<Tblbenefitcategory> Tblbenefitcategories { get; set; }
        public virtual DbSet<Tblbenefitdemand> Tblbenefitdemands { get; set; }
        public virtual DbSet<Tblbenefitextraearning> Tblbenefitextraearnings { get; set; }
        public virtual DbSet<Tblbenefithealth> Tblbenefithealths { get; set; }
        public virtual DbSet<Tblbenefitseniority> Tblbenefitseniorities { get; set; }
        public virtual DbSet<Tblbenefitvacation> Tblbenefitvacations { get; set; }
        public virtual DbSet<Tblcampaign> Tblcampaigns { get; set; }
        public virtual DbSet<Tblcandidatereply> Tblcandidatereplies { get; set; }
        public virtual DbSet<Tblcorporateexposure> Tblcorporateexposures { get; set; }
        public virtual DbSet<Tbldiscipline> Tbldisciplines { get; set; }
        public virtual DbSet<Tbleducationlevel> Tbleducationlevels { get; set; }
        public virtual DbSet<Tblexperiencelevel> Tblexperiencelevels { get; set; }
        public virtual DbSet<Tblexperiencetrack> Tblexperiencetracks { get; set; }
        public virtual DbSet<Tblindustry> Tblindustries { get; set; }
        public virtual DbSet<Tbllocation> Tbllocations { get; set; }
        public virtual DbSet<Tbloccupation> Tbloccupations { get; set; }
        public virtual DbSet<Tblquestionsforcandidate> Tblquestionsforcandidates { get; set; }
        public virtual DbSet<Tblrequisition> Tblrequisitions { get; set; }
        public virtual DbSet<Tblskill> Tblskills { get; set; }
        public virtual DbSet<Tblspeciality> Tblspecialities { get; set; }
        public virtual DbSet<Tblsubspeciality> Tblsubspecialities { get; set; }
        public virtual DbSet<Tbltalentbenefitextraearning> Tbltalentbenefitextraearnings { get; set; }
        public virtual DbSet<Tbltalentbenefithealth> Tbltalentbenefithealths { get; set; }
        public virtual DbSet<Tbltalentcorporateexposure> Tbltalentcorporateexposures { get; set; }
        public virtual DbSet<Tbltalentskill> Tbltalentskills { get; set; }
        public virtual DbSet<Tbltalenttool> Tbltalenttools { get; set; }
        public virtual DbSet<Tbltermsmaster> Tbltermsmasters { get; set; }
        public virtual DbSet<Tbltool> Tbltools { get; set; }
        public virtual DbSet<TermMaster> TermMasters { get; set; }
        public virtual DbSet<TermOnExperienceBlock> TermOnExperienceBlocks { get; set; }
        public virtual DbSet<TermOnResume> TermOnResumes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Viewgetcandidatequestion> Viewgetcandidatequestions { get; set; }
        public virtual DbSet<Vmcandidatebenefit> Vmcandidatebenefits { get; set; }
        public virtual DbSet<Vmcorporateexposure> Vmcorporateexposures { get; set; }
        public virtual DbSet<Vmresumeheader> Vmresumeheaders { get; set; }
        public virtual DbSet<Vmresumeheaderlevel> Vmresumeheaderlevels { get; set; }
        public virtual DbSet<Vmtalentskill> Vmtalentskills { get; set; }
        public virtual DbSet<Vmtalenttool> Vmtalenttools { get; set; }
        public virtual DbSet<Vwlevel1> Vwlevel1s { get; set; }
        public virtual DbSet<Vwlevel2> Vwlevel2s { get; set; }
        public virtual DbSet<Vwlevel3> Vwlevel3s { get; set; }
        public virtual DbSet<Vwlevel4> Vwlevel4s { get; set; }
        public virtual DbSet<Vwlevel5> Vwlevel5s { get; set; }
        public virtual DbSet<Vwtool> Vwtools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=52.188.113.84;port=3306;database=test1;uid=root;pwd=CreditChex123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetroleclaim>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetuserclaim>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserrole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusertoken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<CertificationUpdated>(entity =>
            {
                entity.Property(e => e.IsEnabled).HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<ChildClassLevel>(entity =>
            {
                entity.HasKey(e => e.ChildLevelId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.CertificateOrShortCourseYn).IsFixedLength(true);
            });

            modelBuilder.Entity<EducationUpdated>(entity =>
            {
                entity.Property(e => e.CertificateOrShortCourseYn).IsFixedLength(true);
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Etfmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<ExperienceBlock>(entity =>
            {
                entity.HasKey(e => new { e.ResumeId, e.ExperienceId })
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<ParentClassLevel>(entity =>
            {
                entity.HasKey(e => e.ParentLevelId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<ResumeHeader>(entity =>
            {
                entity.HasKey(e => e.ResumeId)
                    .HasName("PRIMARY");

                entity.Property(e => e.IndustryId).HasDefaultValueSql("'11'");

                entity.Property(e => e.IsAtivelyLooking).HasDefaultValueSql("'1'");

                entity.Property(e => e.IsAvailable).HasDefaultValueSql("'1'");

                entity.Property(e => e.SeniorityId).HasDefaultValueSql("'3'");

                entity.Property(e => e.VacationId).HasDefaultValueSql("'4'");
            });

            modelBuilder.Entity<ResumeScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<ResumeTermPercentage>(entity =>
            {
                entity.HasKey(e => e.ResumeTermId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblbenefit>(entity =>
            {
                entity.HasOne(d => d.BcategoryNavigation)
                    .WithMany(p => p.Tblbenefits)
                    .HasForeignKey(d => d.Bcategory)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Fk_Bcategory_1");
            });

            modelBuilder.Entity<Tblbenefitdemand>(entity =>
            {
                entity.HasOne(d => d.Benefit)
                    .WithMany(p => p.Tblbenefitdemands)
                    .HasForeignKey(d => d.BenefitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_BeenfitId");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Tblbenefitdemands)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("fk_ResumeID1");
            });

            modelBuilder.Entity<Tblbenefitextraearning>(entity =>
            {
                entity.HasKey(e => e.EarningId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblbenefithealth>(entity =>
            {
                entity.HasKey(e => e.HealthId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblbenefitseniority>(entity =>
            {
                entity.HasKey(e => e.SeniorityId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblbenefitvacation>(entity =>
            {
                entity.HasKey(e => e.VacationId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblcandidatereply>(entity =>
            {
                entity.HasKey(e => e.IdtblCandidateReply)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Tblcandidatereplies)
                    .HasForeignKey(d => d.Questionid)
                    .HasConstraintName("qid");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Tblcandidatereplies)
                    .HasForeignKey(d => d.ResumeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("res_id");
            });

            modelBuilder.Entity<Tblcorporateexposure>(entity =>
            {
                entity.HasKey(e => e.ExposureId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tbldiscipline>(entity =>
            {
                entity.HasKey(e => e.DisciplineId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tbleducationlevel>(entity =>
            {
                entity.HasKey(e => e.EducationLevelId)
                    .HasName("PRIMARY");

                entity.Property(e => e.EducationLevelId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Tblexperiencelevel>(entity =>
            {
                entity.HasKey(e => e.ExperienceLevelId)
                    .HasName("PRIMARY");

                entity.Property(e => e.ExperienceLevelId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Tblexperiencetrack>(entity =>
            {
                entity.HasKey(e => e.ExperienceTrackId)
                    .HasName("PRIMARY");

                entity.Property(e => e.ExperienceTrackId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Tblindustry>(entity =>
            {
                entity.HasKey(e => e.IndustryId)
                    .HasName("PRIMARY");

                entity.Property(e => e.IndustryCode).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Tbloccupation>(entity =>
            {
                entity.HasKey(e => e.OccupationId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblquestionsforcandidate>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblrequisition>(entity =>
            {
                entity.Property(e => e.StatusId).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Tblskill>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PRIMARY");

                entity.Property(e => e.DisciplineId).HasDefaultValueSql("'1'");

                entity.Property(e => e.IndustryCodE).HasDefaultValueSql("'15-1199'");
            });

            modelBuilder.Entity<Tblspeciality>(entity =>
            {
                entity.HasKey(e => e.SpecialityId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tblsubspeciality>(entity =>
            {
                entity.HasKey(e => e.SubspecialityId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tbltalentbenefitextraearning>(entity =>
            {
                entity.HasKey(e => e.TalentEarningId)
                    .HasName("PRIMARY");

                entity.Property(e => e.EarningId).HasDefaultValueSql("'2'");
            });

            modelBuilder.Entity<Tbltalentbenefithealth>(entity =>
            {
                entity.HasKey(e => e.TalentHealthId)
                    .HasName("PRIMARY");

                entity.Property(e => e.HealthId).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Tbltalentcorporateexposure>(entity =>
            {
                entity.HasKey(e => e.TalentExposureId)
                    .HasName("PRIMARY");

                entity.Property(e => e.ExposureId).HasDefaultValueSql("'3'");
            });

            modelBuilder.Entity<Tbltalentskill>(entity =>
            {
                entity.HasKey(e => e.TalentSkillId)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Tbltalentskills)
                    .HasForeignKey(d => d.Resumeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SkillResumeId");
            });

            modelBuilder.Entity<Tbltalenttool>(entity =>
            {
                entity.HasKey(e => e.TalentToolId)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Tbltalenttools)
                    .HasForeignKey(d => d.Resumeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToolResumeID");
            });

            modelBuilder.Entity<Tbltermsmaster>(entity =>
            {
                entity.HasKey(e => e.TermId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Tbltool>(entity =>
            {
                entity.HasKey(e => e.ToolId)
                    .HasName("PRIMARY");

                entity.Property(e => e.IndustryCodE).HasDefaultValueSql("'15-1199'");
            });

            modelBuilder.Entity<TermMaster>(entity =>
            {
                entity.Property(e => e.TypeId).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Viewgetcandidatequestion>(entity =>
            {
                entity.ToView("viewgetcandidatequestions");

                entity.Property(e => e.IdtblCandidateReply).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Vmcandidatebenefit>(entity =>
            {
                entity.ToView("vmcandidatebenefits");
            });

            modelBuilder.Entity<Vmcorporateexposure>(entity =>
            {
                entity.ToView("vmcorporateexposure");

                entity.Property(e => e.ExposureId).HasDefaultValueSql("'3'");
            });

            modelBuilder.Entity<Vmresumeheader>(entity =>
            {
                entity.ToView("vmresumeheader");

                entity.Property(e => e.IndustryId).HasDefaultValueSql("'11'");

                entity.Property(e => e.IsAtivelyLooking).HasDefaultValueSql("'1'");

                entity.Property(e => e.IsAvailable).HasDefaultValueSql("'1'");

                entity.Property(e => e.SeniorityId).HasDefaultValueSql("'3'");

                entity.Property(e => e.VacationId).HasDefaultValueSql("'4'");
            });

            modelBuilder.Entity<Vmresumeheaderlevel>(entity =>
            {
                entity.ToView("vmresumeheaderlevel");

                entity.Property(e => e.IndustryId).HasDefaultValueSql("'11'");

                entity.Property(e => e.IsAtivelyLooking).HasDefaultValueSql("'1'");

                entity.Property(e => e.IsAvailable).HasDefaultValueSql("'1'");

                entity.Property(e => e.SeniorityId).HasDefaultValueSql("'3'");

                entity.Property(e => e.VacationId).HasDefaultValueSql("'4'");
            });

            modelBuilder.Entity<Vmtalentskill>(entity =>
            {
                entity.ToView("vmtalentskills");

                entity.Property(e => e.SkillId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Vmtalenttool>(entity =>
            {
                entity.ToView("vmtalenttools");

                entity.Property(e => e.ToolId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Vwlevel1>(entity =>
            {
                entity.ToView("vwlevel1");
            });

            modelBuilder.Entity<Vwlevel2>(entity =>
            {
                entity.ToView("vwlevel2");
            });

            modelBuilder.Entity<Vwlevel3>(entity =>
            {
                entity.ToView("vwlevel3");
            });

            modelBuilder.Entity<Vwlevel4>(entity =>
            {
                entity.ToView("vwlevel4");
            });

            modelBuilder.Entity<Vwlevel5>(entity =>
            {
                entity.ToView("vwlevel5");
            });

            modelBuilder.Entity<Vwtool>(entity =>
            {
                entity.ToView("vwtools");

                entity.Property(e => e.ResumeId).HasDefaultValueSql("'0'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
