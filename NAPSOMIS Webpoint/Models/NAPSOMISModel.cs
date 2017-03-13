namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NAPSOMISModel : DbContext
    {
        public NAPSOMISModel()
            : base("name=NAPSOMISModel")
        {
        }

        public virtual DbSet<AUDIT_LOG_DATA> AUDIT_LOG_DATA { get; set; }
        public virtual DbSet<AUDIT_LOG_TRANSACTIONS> AUDIT_LOG_TRANSACTIONS { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<BadgeAvailableField> BadgeAvailableFields { get; set; }
        public virtual DbSet<BalanceCheck> BalanceChecks { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BatchStem> BatchStems { get; set; }
        public virtual DbSet<BatchTransation> BatchTransations { get; set; }
        public virtual DbSet<BeneficiaryApplicationTransaction> BeneficiaryApplicationTransactions { get; set; }
        public virtual DbSet<BeneficiaryApplicationTransactionTemp> BeneficiaryApplicationTransactionTemps { get; set; }
        public virtual DbSet<BeneficiaryArragement> BeneficiaryArragements { get; set; }
        public virtual DbSet<BeneficiaryBatch> BeneficiaryBatches { get; set; }
        public virtual DbSet<BeneficiaryGroupValidityTransaction> BeneficiaryGroupValidityTransactions { get; set; }
        public virtual DbSet<BeneficiaryIndex> BeneficiaryIndexes { get; set; }
        public virtual DbSet<BeneficiaryPay> BeneficiaryPays { get; set; }
        public virtual DbSet<BeneficiaryStopped> BeneficiaryStoppeds { get; set; }
        public virtual DbSet<BeneficiarySum> BeneficiarySums { get; set; }
        public virtual DbSet<BeneficiaryTransactionLog> BeneficiaryTransactionLogs { get; set; }
        public virtual DbSet<BeneficiaryTransactionLogDetail> BeneficiaryTransactionLogDetails { get; set; }
        public virtual DbSet<BeneficiaryType> BeneficiaryTypes { get; set; }
        public virtual DbSet<BestFiveYear> BestFiveYears { get; set; }
        public virtual DbSet<BirthStem> BirthStems { get; set; }
        public virtual DbSet<bnBeneficiaryApplicationRejectedTransaction> bnBeneficiaryApplicationRejectedTransactions { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<CaptureDeath> CaptureDeaths { get; set; }
        public virtual DbSet<CashDenomination> CashDenominations { get; set; }
        public virtual DbSet<CBApplicationTransaction> CBApplicationTransactions { get; set; }
        public virtual DbSet<CBBatch> CBBatches { get; set; }
        public virtual DbSet<CBBBatch> CBBBatches { get; set; }
        public virtual DbSet<CDEPApplicationTransaction> CDEPApplicationTransactions { get; set; }
        public virtual DbSet<cemp_dname> cemp_dname { get; set; }
        public virtual DbSet<cemp_name> cemp_name { get; set; }
        public virtual DbSet<cemp_trn> cemp_trn { get; set; }
        public virtual DbSet<ChequeMaster> ChequeMasters { get; set; }
        public virtual DbSet<ChequeStem> ChequeStems { get; set; }
        public virtual DbSet<Chiefdom> Chiefdoms { get; set; }
        public virtual DbSet<cmem_dstmt> cmem_dstmt { get; set; }
        public virtual DbSet<cmem_q> cmem_q { get; set; }
        public virtual DbSet<cmem_q1> cmem_q1 { get; set; }
        public virtual DbSet<cmem_stmt> cmem_stmt { get; set; }
        public virtual DbSet<cmemsip_tr> cmemsip_tr { get; set; }
        public virtual DbSet<cnom_tr> cnom_tr { get; set; }
        public virtual DbSet<CompanySetting> CompanySettings { get; set; }
        public virtual DbSet<CPayTransaction> CPayTransactions { get; set; }
        public virtual DbSet<cpdrpttr> cpdrpttrs { get; set; }
        public virtual DbSet<CPensionPerson> CPensionPersons { get; set; }
        public virtual DbSet<CPensionSchoolTransaction> CPensionSchoolTransactions { get; set; }
        public virtual DbSet<CRETransaction> CRETransactions { get; set; }
        public virtual DbSet<CReturn> CReturns { get; set; }
        public virtual DbSet<cstmt_pg3_tab> cstmt_pg3_tab { get; set; }
        public virtual DbSet<CTransaction> CTransactions { get; set; }
        public virtual DbSet<CTransactionControl> CTransactionControls { get; set; }
        public virtual DbSet<CunClaimTransaction> CunClaimTransactions { get; set; }
        public virtual DbSet<DBeneficiaryIndex> DBeneficiaryIndexes { get; set; }
        public virtual DbSet<DBeneficiaryIndexTransaction> DBeneficiaryIndexTransactions { get; set; }
        public virtual DbSet<DBeneficiaryPayment> DBeneficiaryPayments { get; set; }
        public virtual DbSet<DeathMaster> DeathMasters { get; set; }
        public virtual DbSet<DeathReact> DeathReacts { get; set; }
        public virtual DbSet<DependantMaster> DependantMasters { get; set; }
        public virtual DbSet<DependantRelative> DependantRelatives { get; set; }
        public virtual DbSet<DigitalArchieve> DigitalArchieves { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<DistrictLocation> DistrictLocations { get; set; }
        public virtual DbSet<DuplicateMember> DuplicateMembers { get; set; }
        public virtual DbSet<econ_act> econ_act { get; set; }
        public virtual DbSet<EmployMastersheet> EmployMastersheets { get; set; }
        public virtual DbSet<ExportDataLog> ExportDataLogs { get; set; }
        public virtual DbSet<GeneralBankBranch> GeneralBankBranches { get; set; }
        public virtual DbSet<GeneralBank> GeneralBanks { get; set; }
        public virtual DbSet<GeneralBeneficiaryArrangement> GeneralBeneficiaryArrangements { get; set; }
        public virtual DbSet<GeneralBeneficiaryIndex> GeneralBeneficiaryIndexes { get; set; }
        public virtual DbSet<GeneralBeneficiaryIndexTransaction> GeneralBeneficiaryIndexTransactions { get; set; }
        public virtual DbSet<GeneralBeneficiaryPayment> GeneralBeneficiaryPayments { get; set; }
        public virtual DbSet<GeneralBeneficiaryStopped> GeneralBeneficiaryStoppeds { get; set; }
        public virtual DbSet<GeneralCPayTransaction> GeneralCPayTransactions { get; set; }
        public virtual DbSet<GeneralDeathReaction> GeneralDeathReactions { get; set; }
        public virtual DbSet<GeneralDistrictLocation> GeneralDistrictLocations { get; set; }
        public virtual DbSet<GeneralMemoReference> GeneralMemoReferences { get; set; }
        public virtual DbSet<GeneralMinimumWage> GeneralMinimumWages { get; set; }
        public virtual DbSet<GovernmentCategory> GovernmentCategories { get; set; }
        public virtual DbSet<GovernmentCode> GovernmentCodes { get; set; }
        public virtual DbSet<GovernmentDependent> GovernmentDependents { get; set; }
        public virtual DbSet<GovernmentHistoryMaster> GovernmentHistoryMasters { get; set; }
        public virtual DbSet<GovernmentMapSSNO> GovernmentMapSSNOes { get; set; }
        public virtual DbSet<GovernmentPensionMaster> GovernmentPensionMasters { get; set; }
        public virtual DbSet<GovernmentPensionSSN> GovernmentPensionSSNs { get; set; }
        public virtual DbSet<GRETransaction> GRETransactions { get; set; }
        public virtual DbSet<GTransactionControl> GTransactionControls { get; set; }
        public virtual DbSet<GTransactionStem> GTransactionStems { get; set; }
        public virtual DbSet<InspectionCordinator> InspectionCordinators { get; set; }
        public virtual DbSet<InspectionMaster> InspectionMasters { get; set; }
        public virtual DbSet<LifeCertificate> LifeCertificates { get; set; }
        public virtual DbSet<MainLogin> MainLogins { get; set; }
        public virtual DbSet<mem_tm3> mem_tm3 { get; set; }
        public virtual DbSet<MemberCRMerge> MemberCRMerges { get; set; }
        public virtual DbSet<MemberGeneral> MemberGenerals { get; set; }
        public virtual DbSet<MemberNoSex> MemberNoSexes { get; set; }
        public virtual DbSet<MemberOnlineLog> MemberOnlineLogs { get; set; }
        public virtual DbSet<MemberQTransaction> MemberQTransactions { get; set; }
        public virtual DbSet<MemberSIPMaster> MemberSIPMasters { get; set; }
        public virtual DbSet<MemberSip> MemberSips { get; set; }
        public virtual DbSet<MemberSIPTransaction> MemberSIPTransactions { get; set; }
        public virtual DbSet<MemberStatement> MemberStatements { get; set; }
        public virtual DbSet<MemberStatementTransaction> MemberStatementTransactions { get; set; }
        public virtual DbSet<MemberTransaction> MemberTransactions { get; set; }
        public virtual DbSet<MemberValid> MemberValids { get; set; }
        public virtual DbSet<MemoReference> MemoReferences { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Migrate_data_err> Migrate_data_err { get; set; }
        public virtual DbSet<MinimumWage> MinimumWages { get; set; }
        public virtual DbSet<MoneyDependantMaster> MoneyDependantMasters { get; set; }
        public virtual DbSet<MoneyDependantRejected> MoneyDependantRejecteds { get; set; }
        public virtual DbSet<MoneyDependantTransaction> MoneyDependantTransactions { get; set; }
        public virtual DbSet<MPerson> MPersons { get; set; }
        public virtual DbSet<MPersonMaster> MPersonMasters { get; set; }
        public virtual DbSet<MRecTransaction> MRecTransactions { get; set; }
        public virtual DbSet<NomMaster> NomMasters { get; set; }
        public virtual DbSet<NomTemp> NomTemps { get; set; }
        public virtual DbSet<NomTransaction> NomTransactions { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<OperationEnvironment> OperationEnvironments { get; set; }
        public virtual DbSet<Parental> Parentals { get; set; }
        public virtual DbSet<ParentalTemp> ParentalTemps { get; set; }
        public virtual DbSet<ParentMaster> ParentMasters { get; set; }
        public virtual DbSet<PaymentPoint> PaymentPoints { get; set; }
        public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public virtual DbSet<pdrjt_tr> pdrjt_tr { get; set; }
        public virtual DbSet<pdrpt_mst> pdrpt_mst { get; set; }
        public virtual DbSet<pdrpt_tr> pdrpt_tr { get; set; }
        public virtual DbSet<pdrpt_tr_tmp> pdrpt_tr_tmp { get; set; }
        public virtual DbSet<PensionCheque> PensionCheques { get; set; }
        public virtual DbSet<PensionDate> PensionDates { get; set; }
        public virtual DbSet<PensionFrequency> PensionFrequencies { get; set; }
        public virtual DbSet<PensionLog> PensionLogs { get; set; }
        public virtual DbSet<PensionMaster> PensionMasters { get; set; }
        public virtual DbSet<Pension> Pensions { get; set; }
        public virtual DbSet<PensionSchoolTransaction> PensionSchoolTransactions { get; set; }
        public virtual DbSet<PensioPerson> PensioPersons { get; set; }
        public virtual DbSet<PrevenMaster> PrevenMasters { get; set; }
        public virtual DbSet<PreviousName> PreviousNames { get; set; }
        public virtual DbSet<ProgramUpdate> ProgramUpdates { get; set; }
        public virtual DbSet<ProgramVersion> ProgramVersions { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<RecTransaction> RecTransactions { get; set; }
        public virtual DbSet<RelativesTypesMaster> RelativesTypesMasters { get; set; }
        public virtual DbSet<SchoolRate> SchoolRates { get; set; }
        public virtual DbSet<SchoolTransaction> SchoolTransactions { get; set; }
        public virtual DbSet<SSNNoLog> SSNNoLogs { get; set; }
        public virtual DbSet<StopDependantPension> StopDependantPensions { get; set; }
        public virtual DbSet<SumClaimLocProc> SumClaimLocProcs { get; set; }
        public virtual DbSet<SurviverType> SurviverTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblUserLog> tblUserLogs { get; set; }
        public virtual DbSet<TNomTransaction> TNomTransactions { get; set; }
        public virtual DbSet<TParent> TParents { get; set; }
        public virtual DbSet<TPreviousName> TPreviousNames { get; set; }
        public virtual DbSet<TransactionControl> TransactionControls { get; set; }
        public virtual DbSet<TransactionStem> TransactionStems { get; set; }
        public virtual DbSet<UpdateCapTransaction> UpdateCapTransactions { get; set; }
        public virtual DbSet<UpdateNomTransaction> UpdateNomTransactions { get; set; }
        public virtual DbSet<UpdatePensionTransaction> UpdatePensionTransactions { get; set; }
        public virtual DbSet<UpdateRecTransaction> UpdateRecTransactions { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<ZoneCode> ZoneCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AUDIT_LOG_DATA>()
                .Property(e => e.NEW_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOG_DATA>()
                .Property(e => e.OLD_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOG_DATA>()
                .Property(e => e.DATA_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOG_TRANSACTIONS>()
                .Property(e => e.HOST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOG_TRANSACTIONS>()
                .Property(e => e.APP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOG_TRANSACTIONS>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceCheck>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceCheck>()
                .Property(e => e.fbalperd)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceCheck>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceCheck>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.fbank)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BatchStem>()
                .Property(e => e.fno)
                .HasPrecision(19, 1);

            modelBuilder.Entity<BatchStem>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BatchStem>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BatchTransation>()
                .Property(e => e.fbatch)
                .IsUnicode(false);

            modelBuilder.Entity<BatchTransation>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<BatchTransation>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BatchTransation>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fbank)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fpay_mode)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fpassport_)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fben_type)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.flast_3mth)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fnationali)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fappr_by)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fpben_bper)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fpben_eper)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fp_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fp_dist)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fp_erno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.femp_type)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fmst_statu)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.src_contr)
                .IsFixedLength();

            modelBuilder.Entity<BeneficiaryApplicationTransaction>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fold_batch_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fold_claim_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fbank)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fpay_mode)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fpassport_)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fben_type)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.flast_3mth)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fnationali)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fappr_by)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fpben_bper)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fpben_eper)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fp_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fp_dist)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fp_erno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.femp_type)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fmst_statu)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.src_contr)
                .IsFixedLength();

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.freason)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryApplicationTransactionTemp>()
                .Property(e => e.fremark)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.fb_perd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.fe_perd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.fpaid_perd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryArragement>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.fben_type)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.fno_rec)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.fno_reject)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryBatch>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryGroupValidityTransaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryGroupValidityTransaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.findx_rate)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.findx_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.fbonus_rate)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.fbonus_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.fbonus_sperd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.fbonus_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryIndex>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fpay_period)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.farr_bperd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.farr_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fmode)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.ftimes_run)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fuser_paid)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.frec_stat)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryPay>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryStopped>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryStopped>()
                .Property(e => e.freason)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryStopped>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryStopped>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.fregion)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.fpay_period)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.froll)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiarySum>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.fperiod)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.fclaim_recno)
                .HasPrecision(6, 0);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.fapp_status)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLog>()
                .Property(e => e.Modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.fperiod)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.fpayperiod)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.frecno)
                .HasPrecision(6, 0);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.fgratuityrecno)
                .HasPrecision(6, 0);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.fgrantrecno)
                .HasPrecision(6, 0);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.fmode)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryTransactionLogDetail>()
                .Property(e => e.Modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryType>()
                .Property(e => e.fben_type)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryType>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BeneficiaryType>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BestFiveYear>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<BestFiveYear>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BestFiveYear>()
                .Property(e => e.fno_mths)
                .HasPrecision(19, 15);

            modelBuilder.Entity<BestFiveYear>()
                .Property(e => e.favg_amt)
                .HasPrecision(19, 15);

            modelBuilder.Entity<BestFiveYear>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BestFiveYear>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BirthStem>()
                .Property(e => e.fbirth_stem)
                .IsUnicode(false);

            modelBuilder.Entity<BirthStem>()
                .Property(e => e.flast_no)
                .HasPrecision(19, 9);

            modelBuilder.Entity<BirthStem>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BirthStem>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fbank)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fpay_mode)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fpassport_)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fben_type)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fmfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fnationali)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fappr_by)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fpben_bper)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fpben_eper)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fp_amt)
                .HasPrecision(19, 15);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fp_dist)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fp_erno)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fmst_statu)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<bnBeneficiaryApplicationRejectedTransaction>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.fbnk_code)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.fbrnch_code)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.fbrnch_name)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.facct_cde)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.fdth_cause)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.fdth_place)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.fdeath_reporter)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.freporter_tel)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.ftimes_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.ftotal_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureDeath>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.ftype)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.famttype)
                .IsUnicode(false);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.fvalue)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashDenomination>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FSURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FOTHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FMRESD_ADD)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FFSURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FFIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FFOTHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FMSURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FMFIRSTNAM)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FMOTHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FNATIONALI)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FMHOME_TOW)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.FP_AMT)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CBApplicationTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CBBatch>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<CBBatch>()
                .Property(e => e.fdateupd)
                .IsUnicode(false);

            modelBuilder.Entity<CBBatch>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<CBBatch>()
                .Property(e => e.Modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<CBBBatch>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<CBBBatch>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CBBBatch>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.fshare)
                .HasPrecision(6, 2);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.frej_reaso)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<CDEPApplicationTransaction>()
                .Property(e => e.frel_mst)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_dname>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_dname>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_name>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_name>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_name>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_name>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_name>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_name>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.faddress1)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.faddress2)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.ftelno)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fcontact)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fsite)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fiecon_act)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fecon_act)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fowner)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fcert_no)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fcomm_cno)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fbusn_type)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fest_type)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fprint)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fnature)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fsalpatt)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fzone)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.fschme)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cemp_trn>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.ftimes_run)
                .HasPrecision(19, 2);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fpay_perio)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fbrnch)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.facct_no)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl3)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fdamt)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fssno1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fclaim_no1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fname1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.famount1)
                .HasPrecision(19, 2);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fcheq_no1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fbrnch1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl11)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl21)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl31)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fdamt1)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fssno2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fclaim_no2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fname2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.famount2)
                .HasPrecision(19, 2);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fcheq_no2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fbrnch2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl12)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl22)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fwordl32)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.fdamt2)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeStem>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeStem>()
                .Property(e => e.fmth)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeStem>()
                .Property(e => e.fserial)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ChequeStem>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ChequeStem>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Chiefdom>()
                .Property(e => e.fp_code)
                .IsUnicode(false);

            modelBuilder.Entity<Chiefdom>()
                .Property(e => e.fd_code)
                .IsUnicode(false);

            modelBuilder.Entity<Chiefdom>()
                .Property(e => e.fc_code)
                .IsUnicode(false);

            modelBuilder.Entity<Chiefdom>()
                .Property(e => e.fdescr)
                .IsUnicode(false);

            modelBuilder.Entity<Chiefdom>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Chiefdom>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fmth)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fperiod)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fnomths)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.ftot_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fbak_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.ftot_sal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_dstmt>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q>()
                .Property(e => e.fbatch)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q>()
                .Property(e => e.fq_type)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q1>()
                .Property(e => e.fbatch)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q1>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q1>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q1>()
                .Property(e => e.fq_type)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q1>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_q1>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_stmt>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_stmt>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cmem_stmt>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fage)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fannsal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fnoyr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.factors)
                .HasPrecision(19, 6);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fcost)
                .HasPrecision(19, 3);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fappr_cde)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fappr_by)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fprnt)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fappr_name)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.floc_name)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cmemsip_tr>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fnfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.frel_desc)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<cnom_tr>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<CompanySetting>()
                .Property(e => e.CompanyID)
                .IsUnicode(false);

            modelBuilder.Entity<CompanySetting>()
                .Property(e => e.NameofCompany)
                .IsUnicode(false);

            modelBuilder.Entity<CompanySetting>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<CompanySetting>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<CompanySetting>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CPayTransaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CPayTransaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<cpdrpttr>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cpdrpttr>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CPensionPerson>()
                .Property(e => e.fdue_age)
                .HasPrecision(2, 0);

            modelBuilder.Entity<CPensionPerson>()
                .Property(e => e.flast_3mth)
                .HasPrecision(7, 0);

            modelBuilder.Entity<CPensionPerson>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CPensionPerson>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CPensionSchoolTransaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CPensionSchoolTransaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRETransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<CRETransaction>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<CRETransaction>()
                .Property(e => e.frec_no)
                .HasPrecision(19, 7);

            modelBuilder.Entity<CRETransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<CRETransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CRETransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CReturn>()
                .Property(e => e.ffile)
                .IsUnicode(false);

            modelBuilder.Entity<CReturn>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<CReturn>()
                .Property(e => e.frec_no)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CReturn>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<CReturn>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CReturn>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fage)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fnmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fcr_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fnmths_pur)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fpur_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fl36_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.ffpen_q)
                .IsUnicode(false);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.frpen_q)
                .IsUnicode(false);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fipen_q)
                .IsUnicode(false);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.fgovt_val)
                .HasPrecision(19, 2);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cstmt_pg3_tab>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CTransaction>()
                .Property(e => e.ffile)
                .IsUnicode(false);

            modelBuilder.Entity<CTransaction>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<CTransaction>()
                .Property(e => e.frec_no)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<CTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CTransactionControl>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<CTransactionControl>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<CTransactionControl>()
                .Property(e => e.frec_no)
                .HasPrecision(19, 7);

            modelBuilder.Entity<CTransactionControl>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CTransactionControl>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fbnk_name)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.flast_desig)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.faddress)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fpay_period)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.farr_bperd)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.farr_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fmode)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.ftimes_run)
                .HasPrecision(19, 1);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.ftype_rcpt)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fpay_point)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.fuser_paid)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.frec_stat)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.amt_in_words)
                .IsUnicode(false);

            modelBuilder.Entity<CunClaimTransaction>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.findx_rate)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.findx_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.fbonus_rate)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.fbonus_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.fbonus_sperd)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.fbonus_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndex>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndexTransaction>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndexTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndexTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryIndexTransaction>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fpay_period)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.farr_bperd)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.farr_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fmode)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.ftimes_run)
                .HasPrecision(19, 1);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fuser_paid)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.frec_stat)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DBeneficiaryPayment>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fnation)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fb_country)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fincome)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fnat_incom)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.foccupatio)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.femp_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fcr_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 7);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.flast_3mths)
                .HasPrecision(19, 6);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fpen_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fbest_1amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fbest_1mth)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fb5_sal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fb5_avg)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fcredit_p)
                .HasPrecision(19, 7);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fvalid)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.fpen_amt_old)
                .HasPrecision(19, 2);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DeathMaster>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<DeathReact>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<DeathReact>()
                .Property(e => e.fuser)
                .IsUnicode(false);

            modelBuilder.Entity<DeathReact>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DeathReact>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DependantMaster>()
                .Property(e => e.fshare)
                .HasPrecision(6, 2);

            modelBuilder.Entity<DependantMaster>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<DependantMaster>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fnfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.frel_desc)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fd_share)
                .HasPrecision(19, 6);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.fd_status)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DependantRelative>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.ArchieveID)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.TypeOfAttachment)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.DetailsOfDocument)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.SearchKeyword)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.TheFileName)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.SharedAccessLevel)
                .IsUnicode(false);

            modelBuilder.Entity<DigitalArchieve>()
                .Property(e => e.InputtedBy)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.p_code)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.d_code)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.d_desc)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.floc_name)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.fdist_alias)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.fdist_adr)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.fdist_tel)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.fdist_fax)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.fdist_mgr)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.fbnk_code)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DistrictLocation>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fnation)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fb_country)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fnat_income)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.foccupation)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.femp_addr)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fgov_code)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.refno_mst)
                .IsUnicode(false);

            modelBuilder.Entity<DuplicateMember>()
                .Property(e => e.fssno_mst)
                .IsUnicode(false);

            modelBuilder.Entity<econ_act>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<econ_act>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<econ_act>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<econ_act>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.faddress1)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.faddress2)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.ftelno)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fcontact)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fsite)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fiecon_act)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fecon_act)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fowner)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fcert_no)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fcomm_cno)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fbusn_type)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fest_type)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fprint)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fnature)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fsalpatt)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fzone)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.fschme)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<EmployMastersheet>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ExportDataLog>()
                .Property(e => e.ftablename)
                .IsUnicode(false);

            modelBuilder.Entity<ExportDataLog>()
                .Property(e => e.fuserName)
                .IsUnicode(false);

            modelBuilder.Entity<ExportDataLog>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBankBranch>()
                .Property(e => e.fbnk_code)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBankBranch>()
                .Property(e => e.fbrnch_code)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBankBranch>()
                .Property(e => e.fbrnch_name)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBankBranch>()
                .Property(e => e.facct_cde)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBankBranch>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBankBranch>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBank>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBank>()
                .Property(e => e.fbank)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBank>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBank>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.famount)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.fb_perd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.fe_perd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.fpaid_perd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryArrangement>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryIndex>()
                .Property(e => e.fbonus_sperd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryIndex>()
                .Property(e => e.fbonus_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryIndex>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryIndex>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryIndexTransaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryIndexTransaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fbnk_name)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.flast_desig)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.faddress)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fpay_period)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.farr_bperd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.farr_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fmode)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.ftimes_run)
                .HasPrecision(19, 1);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.ftype_rcpt)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fpay_point)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.fuser_paid)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.frec_stat)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.amt_in_words)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryPayment>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryStopped>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralBeneficiaryStopped>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fbnk_name)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.flast_desig)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.faddress)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fpay_period)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.farr_bperd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.farr_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.famount)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fmode)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.ftimes_run)
                .HasPrecision(19, 1);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.ftype_rcpt)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fpay_point)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.fuser_paid)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.frec_stat)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.amt_in_words)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralCPayTransaction>()
                .Property(e => e.ftran_log)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralDeathReaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralDeathReaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralDistrictLocation>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralDistrictLocation>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralMemoReference>()
                .Property(e => e.fref_last)
                .HasPrecision(5, 2);

            modelBuilder.Entity<GeneralMemoReference>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralMemoReference>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralMinimumWage>()
                .Property(e => e.famt)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GeneralMinimumWage>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralMinimumWage>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCategory>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCategory>()
                .Property(e => e.fcat)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCategory>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCategory>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCode>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentCode>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fterm_sal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fnotimes_p)
                .HasPrecision(3, 0);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fgrant)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fpen_right)
                .HasPrecision(6, 3);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.ftimes_pai)
                .HasPrecision(7, 0);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.ftotal_pai)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fmonth_sal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fage)
                .HasPrecision(2, 0);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.farrears)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.fpen_amt)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.funclaimed)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentDependent>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fcat)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fpcentre)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fothername)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.frstcr_perd)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fcur_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.flast_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fcurcr_perd)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fremark)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fprocess)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fid)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.fcatbperd)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentHistoryMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentMapSSNO>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentMapSSNO>()
                .Property(e => e.fGovtPenSSNo)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentMapSSNO>()
                .Property(e => e.fDepSSNo)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentMapSSNO>()
                .Property(e => e.fDep_Type)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentMapSSNO>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentMapSSNO>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fterm_sal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fnotimes_paid)
                .HasPrecision(3, 0);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fgrant)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fpen_right)
                .HasPrecision(6, 3);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.ftimes_paid)
                .HasPrecision(7, 0);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.ftotal_paid)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fmonth_sal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fage)
                .HasPrecision(2, 0);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.farrears)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fpen_amt)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.funclaimed)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentPensionMaster>()
                .Property(e => e.fpen_amt_old)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GovernmentPensionSSN>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GovernmentPensionSSN>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GRETransaction>()
                .Property(e => e.frec_no)
                .HasPrecision(15, 2);

            modelBuilder.Entity<GRETransaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GRETransaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GTransactionControl>()
                .Property(e => e.frec_no)
                .HasPrecision(7, 2);

            modelBuilder.Entity<GTransactionControl>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GTransactionControl>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GTransactionStem>()
                .Property(e => e.flast_no)
                .HasPrecision(5, 2);

            modelBuilder.Entity<GTransactionStem>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GTransactionStem>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCordinator>()
                .Property(e => e.finsp_code)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCordinator>()
                .Property(e => e.finsp_name)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCordinator>()
                .Property(e => e.fzone)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCordinator>()
                .Property(e => e.fgroup)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCordinator>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCordinator>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fzone)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.flb_perd)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fle_perd)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fpay_cat)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fcr_cat)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fppay_cat)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fpcr_cat)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fnb_perd)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fne_perd)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.finsp_pl)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.finsp_code)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.fprocessed)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.floc1)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fage)
                .HasPrecision(19, 2);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fage_mth)
                .HasPrecision(19, 1);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fssno1)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fclaim_no1)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fname1)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fage1)
                .HasPrecision(19, 2);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.fage_mth1)
                .HasPrecision(19, 1);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<LifeCertificate>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.AccountStatus)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.AccessibleIndices)
                .IsUnicode(false);

            modelBuilder.Entity<MainLogin>()
                .Property(e => e.SecurityQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fnation)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fb_country)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fincome)
                .HasPrecision(19, 2);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fnat_incom)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.foccupatio)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.femp_addr)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mem_tm3>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.brsssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCRMerge>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<MemberGeneral>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<MemberGeneral>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberGeneral>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberNoSex>()
                .Property(e => e.fperiod)
                .IsUnicode(false);

            modelBuilder.Entity<MemberNoSex>()
                .Property(e => e.fmale)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberNoSex>()
                .Property(e => e.female)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberNoSex>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberNoSex>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOnlineLog>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOnlineLog>()
                .Property(e => e.fref_stem)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOnlineLog>()
                .Property(e => e.fref_last)
                .HasPrecision(19, 1);

            modelBuilder.Entity<MemberOnlineLog>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOnlineLog>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberQTransaction>()
                .Property(e => e.fbatch)
                .IsUnicode(false);

            modelBuilder.Entity<MemberQTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<MemberQTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberQTransaction>()
                .Property(e => e.fq_type)
                .IsUnicode(false);

            modelBuilder.Entity<MemberQTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberQTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.frecptno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.fnomths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.famt_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.fcashier)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSip>()
                .Property(e => e.fage)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSip>()
                .Property(e => e.fmale)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MemberSip>()
                .Property(e => e.female)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MemberSip>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSip>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fage)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fannsal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fnoyr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.factors)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fcost)
                .HasPrecision(19, 3);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fappr_cde)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fappr_by)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.fprnt)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.ftotmths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberSIPTransaction>()
                .Property(e => e.ftotamt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fcat)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fjancr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.ffebcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fmarcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.faprcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fmaycr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fjuncr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fjulcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.faugcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fsepcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.foctcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fnovcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fdeccr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatement>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fcat)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fjancr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.ffebcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fmarcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.faprcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fmaycr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fjuncr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fjulcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.faugcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fsepcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.foctcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fnovcr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fdeccr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberStatementTransaction>()
                .Property(e => e.fref_stem)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fbatch)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fnation)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fb_country)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fincome)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fnat_income)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.foccupation)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.femp_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fcr_mths)
                .HasPrecision(19, 3);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTransaction>()
                .Property(e => e.fgov_code)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fbatch)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fnation)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fb_country)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fincome)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fnat_income)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.foccupation)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.femp_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fcr_mths)
                .HasPrecision(19, 3);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemberValid>()
                .Property(e => e.fgov_code)
                .IsUnicode(false);

            modelBuilder.Entity<MemoReference>()
                .Property(e => e.fmemo_type)
                .IsUnicode(false);

            modelBuilder.Entity<MemoReference>()
                .Property(e => e.fref_stem)
                .IsUnicode(false);

            modelBuilder.Entity<MemoReference>()
                .Property(e => e.fref_last)
                .HasPrecision(19, 1);

            modelBuilder.Entity<MemoReference>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MemoReference>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.SenderID)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.ReceipientID)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageBody)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Urgency)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageSubject)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.SenderName)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.ReceipientName)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.AttachmentName)
                .IsUnicode(false);

            modelBuilder.Entity<Migrate_data_err>()
                .Property(e => e.table_name)
                .IsUnicode(false);

            modelBuilder.Entity<Migrate_data_err>()
                .Property(e => e.err_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Migrate_data_err>()
                .Property(e => e.err_string)
                .IsUnicode(false);

            modelBuilder.Entity<Migrate_data_err>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<Migrate_data_err>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MinimumWage>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<MinimumWage>()
                .Property(e => e.famt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MinimumWage>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MinimumWage>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fn_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fdclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fn_sex)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fsch_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fdep_type)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fphy_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.finvest)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fshare)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fpaymode)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fmember)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fjob_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fvalid)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fpen_type)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fgrant_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.ftotal_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.flpay_perd)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.ftimes_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fshare_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.fshare_amt_old)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fn_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fdclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fn_sex)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fsch_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fdep_type)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fphy_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.finvest)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fpay_mode)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fmember)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fjob_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.fvalid)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.frej_reason)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantRejected>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fn_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fdclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fn_sex)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fsch_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fdep_type)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fphy_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.finvest)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fpay_mode)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fbnk)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fcheq_no)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fmember)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fjob_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fvalid)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.frej_reason)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.fpen_type)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MoneyDependantTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.MotherNm)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.FatherNm)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.Provience)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.District)
                .IsUnicode(false);

            modelBuilder.Entity<MPerson>()
                .Property(e => e.ChiefDom)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fnation)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fb_country)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fincome)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fnat_incom)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.foccupatio)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.femp_name)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.femp_addr)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fcr_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fstaffno)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MPersonMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.frefno)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.fuser_rec)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MRecTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fnfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NomMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fnfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NomTemp>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fnfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NomTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Occupation>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<Occupation>()
                .Property(e => e.fdescr)
                .IsUnicode(false);

            modelBuilder.Entity<Occupation>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Occupation>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_code)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_loc)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_mgr)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_alise)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_addr)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_telno)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_fax)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_email)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_dmd)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_lc)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fdist_title)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.createdby)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.modifiedby)
                .IsUnicode(false);

            modelBuilder.Entity<OperationEnvironment>()
                .Property(e => e.fBRSDBName)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.fmfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Parental>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.fmfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ParentalTemp>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.fmfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ParentMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPoint>()
                .Property(e => e.fp_code)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPoint>()
                .Property(e => e.fp_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPoint>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPoint>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTransaction>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTransaction>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTransaction>()
                .Property(e => e.fpen_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PaymentTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fmst_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.frname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fraddress)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.frtelno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fdth_cause)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fdth_place)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fburial_pl)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fdth_evid)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fdth_statu)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.freason)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 7);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.flast_3mths)
                .HasPrecision(19, 7);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 7);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fcredit_p)
                .HasPrecision(19, 5);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.fterm_date)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.newfld)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrjt_tr>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fmst_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.frname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fraddress)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.frtelno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fdth_cause)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fdth_place)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fburial_pl)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fdth_evid)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fdth_status)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.freason)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 7);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.flast_3mths)
                .HasPrecision(19, 7);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 7);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fcredit_p)
                .HasPrecision(19, 5);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fdep_rel)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.fjob_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_mst>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fmst_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.frname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fraddress)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.frtelno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fdth_cause)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fdth_place)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fburial_pl)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fdth_evid)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fdth_statu)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.freason)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.flast_3mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fcredit_p)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.fjob_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.foldbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fmst_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.frname)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fraddress)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.frtelno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fdth_cause)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fdth_place)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fburial_pl)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fdth_evid)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fdth_statu)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.freason)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fpen_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.flast_3mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fcredit_p)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.fjob_stat)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pdrpt_tr_tmp>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionCheque>()
                .Property(e => e.famount)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PensionCheque>()
                .Property(e => e.famount1)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PensionCheque>()
                .Property(e => e.famount2)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PensionCheque>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PensionCheque>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PensionDate>()
                .Property(e => e.ftype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PensionDate>()
                .Property(e => e.fpay_period)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PensionDate>()
                .Property(e => e.ftimes_run)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PensionDate>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionDate>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFrequency>()
                .Property(e => e.freq)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFrequency>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFrequency>()
                .Property(e => e.fmths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionFrequency>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFrequency>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionLog>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<PensionLog>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensionLog>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionLog>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionLog>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensionLog>()
                .Property(e => e.fyear)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fpaypoint)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fterm_sal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fbtype_opt)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fpaymode)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.frequency)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fbest_1yr)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fbest_1amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fbest_1mth)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fb5_sal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fb5_avg)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fgrant)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.flast_3mth)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fpen_right)
                .HasPrecision(19, 6);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.ftimes_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.ftotal_paid)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fmonth_sal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fage)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fmths_cr)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fadd_mths)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.farrears)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fdeduction)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fpen_amt)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fnet_pay)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.flpay_perd)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fprev_eperd)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.findex_perd)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fentry)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.farr_deduct)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fpay_pnt)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensionMaster>()
                .Property(e => e.fpen_amt_old)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Pension>()
                .Property(e => e.C____period)
                .HasPrecision(16, 0);

            modelBuilder.Entity<Pension>()
                .Property(e => e.C____fin_ye)
                .HasPrecision(17, 0);

            modelBuilder.Entity<Pension>()
                .Property(e => e.C____bank_i)
                .HasPrecision(17, 0);

            modelBuilder.Entity<Pension>()
                .Property(e => e.C____arrear)
                .HasPrecision(22, 0);

            modelBuilder.Entity<Pension>()
                .Property(e => e.C____net_am)
                .HasPrecision(26, 0);

            modelBuilder.Entity<Pension>()
                .Property(e => e.C____pay_th)
                .HasPrecision(27, 0);

            modelBuilder.Entity<Pension>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<Pension>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSchoolTransaction>()
                .Property(e => e.fn_surname)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSchoolTransaction>()
                .Property(e => e.fn_frstnam)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSchoolTransaction>()
                .Property(e => e.fn_othname)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSchoolTransaction>()
                .Property(e => e.fsch_name)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSchoolTransaction>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSchoolTransaction>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fclaim_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fdue_age)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.freject_co)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.flast_erno)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fbank)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.facctno)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fpay_mode)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.flast_3mth)
                .HasPrecision(19, 7);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fmresd_add)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fpassport_)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fbt_award)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fben_type)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fmfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fnationali)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.flocation)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.ftel_no)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fmhome_tow)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.finvestiga)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fappr_code)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fappr_by)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fmst_statu)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PensioPerson>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.fpsurname)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.fpfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.fpothname)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PrevenMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.fpsurname)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.fpfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.fpothname)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PreviousName>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramUpdate>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramUpdate>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramUpdate>()
                .Property(e => e.UpdatePriority)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramUpdate>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramUpdate>()
                .Property(e => e.InputtedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramVersion>()
                .Property(e => e.ProgramVersion1)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramVersion>()
                .Property(e => e.ProgramStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.fno)
                .HasPrecision(19, 1);

            modelBuilder.Entity<Province>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RecTransaction>()
                .Property(e => e.ffile)
                .IsUnicode(false);

            modelBuilder.Entity<RecTransaction>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<RecTransaction>()
                .Property(e => e.frec_no)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RecTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<RecTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RecTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RelativesTypesMaster>()
                .Property(e => e.frel_code)
                .IsUnicode(false);

            modelBuilder.Entity<RelativesTypesMaster>()
                .Property(e => e.frel_desc)
                .IsUnicode(false);

            modelBuilder.Entity<RelativesTypesMaster>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<RelativesTypesMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RelativesTypesMaster>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolRate>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolRate>()
                .Property(e => e.frate)
                .HasPrecision(19, 3);

            modelBuilder.Entity<SchoolRate>()
                .Property(e => e.fstart)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolRate>()
                .Property(e => e.fend)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolRate>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolRate>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolTransaction>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolTransaction>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolTransaction>()
                .Property(e => e.fstart)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolTransaction>()
                .Property(e => e.fend)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.foldssno)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fnewssno)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fprovince)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fdist)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fchief)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.ftown)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.ferno)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SSNNoLog>()
                .Property(e => e.fbatch_no)
                .IsUnicode(false);

            modelBuilder.Entity<StopDependantPension>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<StopDependantPension>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SumClaimLocProc>()
                .Property(e => e.keydesc)
                .IsUnicode(false);

            modelBuilder.Entity<SumClaimLocProc>()
                .Property(e => e.keycount)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SumClaimLocProc>()
                .Property(e => e.keyvalue)
                .HasPrecision(19, 2);

            modelBuilder.Entity<SumClaimLocProc>()
                .Property(e => e.keyloc)
                .IsUnicode(false);

            modelBuilder.Entity<SumClaimLocProc>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SumClaimLocProc>()
                .Property(e => e.MODIFIEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SurviverType>()
                .Property(e => e.fcode)
                .IsUnicode(false);

            modelBuilder.Entity<SurviverType>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<SurviverType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SurviverType>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserLog>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserLog>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserLog>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserLog>()
                .Property(e => e.ActivityTime)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fnfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TNomTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.ffsurname)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.ffothname)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.fmsurname)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.fmfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.fmothname)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TParent>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.fpsurname)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.fpfirstnam)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.fpothname)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TPreviousName>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionControl>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionControl>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionControl>()
                .Property(e => e.frec_no)
                .HasPrecision(19, 7);

            modelBuilder.Entity<TransactionControl>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionControl>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionStem>()
                .Property(e => e.ffile)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionStem>()
                .Property(e => e.fdesc)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionStem>()
                .Property(e => e.flast_no)
                .HasPrecision(19, 1);

            modelBuilder.Entity<TransactionStem>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionStem>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fcur_addr)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fm_stat)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.floc)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fquery)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateCapTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fnom_ssno)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fnsurname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fnfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fnothname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fnomsex)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.frelation)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fper_addr)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.fres_addr)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateNomTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.fref_no)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.fpsurname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.fpfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.fpothname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.fuser_code)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdatePensionTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fssno)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fupd_type)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fsurname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fothname)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fstatus)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fuser_rec)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fuser_cap)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.fsex)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UpdateRecTransaction>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.fuser)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ZoneCode>()
                .Property(e => e.fzone)
                .IsUnicode(false);

            modelBuilder.Entity<ZoneCode>()
                .Property(e => e.fzone_name)
                .IsUnicode(false);

            modelBuilder.Entity<ZoneCode>()
                .Property(e => e.finsp_code)
                .IsUnicode(false);

            modelBuilder.Entity<ZoneCode>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ZoneCode>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<NAPSOMIS_Webpoint.Models.ReferenceNo> ReferenceNoes { get; set; }
    }
}
