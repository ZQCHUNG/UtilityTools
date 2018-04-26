namespace HFunctionLibrary.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<BurnTable> BurnTable { get; set; }
        public virtual DbSet<CaseHistorTable1> CaseHistorTable1 { get; set; }
        public virtual DbSet<CaseHistorTable2> CaseHistorTable2 { get; set; }
        public virtual DbSet<CaseHistorTable4> CaseHistorTable4 { get; set; }
        public virtual DbSet<CaseHistorTable5> CaseHistorTable5 { get; set; }
        public virtual DbSet<CaseHistorView> CaseHistorView { get; set; }
        public virtual DbSet<CaseHistorViewRn> CaseHistorViewRn { get; set; }
        public virtual DbSet<CaseTable> CaseTable { get; set; }
        public virtual DbSet<CaseTypeTable> CaseTypeTable { get; set; }
        public virtual DbSet<CheckedUserTable> CheckedUserTable { get; set; }
        public virtual DbSet<ClassTable> ClassTable { get; set; }
        public virtual DbSet<ClientInfo> ClientInfo { get; set; }
        public virtual DbSet<CopyFieldType> CopyFieldType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<FieldType1> FieldType1 { get; set; }
        public virtual DbSet<FieldType2> FieldType2 { get; set; }
        public virtual DbSet<FieldType3> FieldType3 { get; set; }
        public virtual DbSet<FieldTypeName> FieldTypeName { get; set; }
        public virtual DbSet<FileTable> FileTable { get; set; }
        public virtual DbSet<GroupCaseTypeTable> GroupCaseTypeTable { get; set; }
        public virtual DbSet<GroupClassTable> GroupClassTable { get; set; }
        public virtual DbSet<GroupPrivilegeTable> GroupPrivilegeTable { get; set; }
        public virtual DbSet<GroupTable> GroupTable { get; set; }
        public virtual DbSet<HISPatDataChg> HISPatDataChg { get; set; }
        public virtual DbSet<HISViewCtrl> HISViewCtrl { get; set; }
        public virtual DbSet<IDTable> IDTable { get; set; }
        public virtual DbSet<ImageNoteTable> ImageNoteTable { get; set; }
        public virtual DbSet<ItemTable> ItemTable { get; set; }
        public virtual DbSet<LogTable> LogTable { get; set; }
        public virtual DbSet<MessageGroupTable> MessageGroupTable { get; set; }
        public virtual DbSet<MessageTable> MessageTable { get; set; }
        public virtual DbSet<NewsTable> NewsTable { get; set; }
        public virtual DbSet<PageTable> PageTable { get; set; }
        public virtual DbSet<Privilege> Privilege { get; set; }
        public virtual DbSet<StorePathTable> StorePathTable { get; set; }
        public virtual DbSet<SystemTable> SystemTable { get; set; }
        public virtual DbSet<UserGroupTable> UserGroupTable { get; set; }
        public virtual DbSet<UserRegQryDTable> UserRegQryDTable { get; set; }
        public virtual DbSet<UserRegQryMTable> UserRegQryMTable { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }
        public virtual DbSet<ZRedSch> ZRedSch { get; set; }
        public virtual DbSet<CaseHistorField> CaseHistorField { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaseHistorTable1>()
                .Property(e => e.HSRange)
                .IsUnicode(false);

            modelBuilder.Entity<CaseHistorTable2>()
                .Property(e => e.CHIDs)
                .IsUnicode(false);

            modelBuilder.Entity<CaseHistorTable2>()
                .Property(e => e.CHTypeIDs)
                .IsUnicode(false);

            modelBuilder.Entity<CaseHistorTable4>()
                .Property(e => e.CHFormHISID)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.LoginType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CaseHistorField>()
                .Property(e => e.CHIDs)
                .IsUnicode(false);

            modelBuilder.Entity<CaseHistorField>()
                .Property(e => e.CHTypeIDs)
                .IsUnicode(false);
        }
    }
}
