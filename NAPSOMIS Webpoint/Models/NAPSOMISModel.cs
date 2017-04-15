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

        public virtual DbSet<acct_chart> acct_chart { get; set; }
        public virtual DbSet<adm_stem> adm_stem { get; set; }
        public virtual DbSet<APPLICATION_CTRL> APPLICATION_CTRL { get; set; }
        public virtual DbSet<AUDIT_LOG_DATA> AUDIT_LOG_DATA { get; set; }
        public virtual DbSet<AUDIT_LOG_TRANSACTIONS> AUDIT_LOG_TRANSACTIONS { get; set; }
        public virtual DbSet<b_brnch> b_brnch { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<BadgeAvailableField> BadgeAvailableFields { get; set; }
        public virtual DbSet<bal_chk> bal_chk { get; set; }
        public virtual DbSet<BAMtemp_tr> BAMtemp_tr { get; set; }
        public virtual DbSet<bank> banks { get; set; }
        public virtual DbSet<bapp_rct> bapp_rct { get; set; }
        public virtual DbSet<batch_stem> batch_stem { get; set; }
        public virtual DbSet<batch_tr> batch_tr { get; set; }
        public virtual DbSet<bdep_rec> bdep_rec { get; set; }
        public virtual DbSet<bdep_tr> bdep_tr { get; set; }
        public virtual DbSet<bdrep_tr> bdrep_tr { get; set; }
        public virtual DbSet<ben_batch> ben_batch { get; set; }
        public virtual DbSet<ben_pay> ben_pay { get; set; }
        public virtual DbSet<ben_type> ben_type { get; set; }
        public virtual DbSet<bentype_mem> bentype_mem { get; set; }
        public virtual DbSet<bgval_tr> bgval_tr { get; set; }
        public virtual DbSet<birth_stem> birth_stem { get; set; }
        public virtual DbSet<bk_log> bk_log { get; set; }
        public virtual DbSet<bmem_tr> bmem_tr { get; set; }
        public virtual DbSet<bnapp_tr> bnapp_tr { get; set; }
        public virtual DbSet<bnaprj_tr> bnaprj_tr { get; set; }
        public virtual DbSet<brs_ex> brs_ex { get; set; }
        public virtual DbSet<BRSTran_Log> BRSTran_Log { get; set; }
        public virtual DbSet<bsch_tr> bsch_tr { get; set; }
        public virtual DbSet<bus_type> bus_type { get; set; }
        public virtual DbSet<c_benp> c_benp { get; set; }
        public virtual DbSet<c_cash> c_cash { get; set; }
        public virtual DbSet<c_cashpt> c_cashpt { get; set; }
        public virtual DbSet<c_cat> c_cat { get; set; }
        public virtual DbSet<c_cpdata> c_cpdata { get; set; }
        public virtual DbSet<c_crsdata> c_crsdata { get; set; }
        public virtual DbSet<c_crsreg> c_crsreg { get; set; }
        public virtual DbSet<c_emp> c_emp { get; set; }
        public virtual DbSet<c_invalt> c_invalt { get; set; }
        public virtual DbSet<c_memreg> c_memreg { get; set; }
        public virtual DbSet<c_penbnks> c_penbnks { get; set; }
        public virtual DbSet<c_retrn> c_retrn { get; set; }
        public virtual DbSet<c_stmt_tmp> c_stmt_tmp { get; set; }
        public virtual DbSet<c_trn1> c_trn1 { get; set; }
        public virtual DbSet<cash_deno> cash_deno { get; set; }
        public virtual DbSet<cash_pnt> cash_pnt { get; set; }
        public virtual DbSet<cashctrl_tr> cashctrl_tr { get; set; }
        public virtual DbSet<cat_date> cat_date { get; set; }
        public virtual DbSet<cat_days> cat_days { get; set; }
        public virtual DbSet<cbapptr> cbapptrs { get; set; }
        public virtual DbSet<cbenp> cbenps { get; set; }
        public virtual DbSet<cbgval_tr> cbgval_tr { get; set; }
        public virtual DbSet<cblow> cblows { get; set; }
        public virtual DbSet<cblow1> cblow1 { get; set; }
        public virtual DbSet<ccr_ctrl> ccr_ctrl { get; set; }
        public virtual DbSet<ccr_trn> ccr_trn { get; set; }
        public virtual DbSet<ccr_trn_old> ccr_trn_old { get; set; }
        public virtual DbSet<ccr_trn1> ccr_trn1 { get; set; }
        public virtual DbSet<cctrl_rep> cctrl_rep { get; set; }
        public virtual DbSet<cctrl1> cctrl1 { get; set; }
        public virtual DbSet<cctrl2> cctrl2 { get; set; }
        public virtual DbSet<cctrl3> cctrl3 { get; set; }
        public virtual DbSet<cdem_let> cdem_let { get; set; }
        public virtual DbSet<cdep_rel> cdep_rel { get; set; }
        public virtual DbSet<cdpenper> cdpenpers { get; set; }
        public virtual DbSet<ceclmst_prnt> ceclmst_prnt { get; set; }
        public virtual DbSet<cemp_dname> cemp_dname { get; set; }
        public virtual DbSet<cemp_mbal> cemp_mbal { get; set; }
        public virtual DbSet<cemp_name> cemp_name { get; set; }
        public virtual DbSet<cemp_trn> cemp_trn { get; set; }
        public virtual DbSet<cempinval> cempinvals { get; set; }
        public virtual DbSet<cempmst> cempmsts { get; set; }
        public virtual DbSet<cempmst_tmp> cempmst_tmp { get; set; }
        public virtual DbSet<cempmsttt> cempmsttts { get; set; }
        public virtual DbSet<cest_covdate> cest_covdate { get; set; }
        public virtual DbSet<cest_reg> cest_reg { get; set; }
        public virtual DbSet<cest_trn> cest_trn { get; set; }
        public virtual DbSet<cgben_p> cgben_p { get; set; }
        public virtual DbSet<cgben_pay> cgben_pay { get; set; }
        public virtual DbSet<cheq_tr> cheq_tr { get; set; }
        public virtual DbSet<chiefdom> chiefdoms { get; set; }
        public virtual DbSet<chist_tp> chist_tp { get; set; }
        public virtual DbSet<chist_tr> chist_tr { get; set; }
        public virtual DbSet<chq_tmp> chq_tmp { get; set; }
        public virtual DbSet<cinsp_all> cinsp_all { get; set; }
        public virtual DbSet<cinsp_by> cinsp_by { get; set; }
        public virtual DbSet<cinsp_byall> cinsp_byall { get; set; }
        public virtual DbSet<cinspby_insp> cinspby_insp { get; set; }
        public virtual DbSet<cinv_tmp> cinv_tmp { get; set; }
        public virtual DbSet<cm_recd> cm_recd { get; set; }
        public virtual DbSet<cmaxmin> cmaxmins { get; set; }
        public virtual DbSet<cmem_dstmt> cmem_dstmt { get; set; }
        public virtual DbSet<cmem_stmt> cmem_stmt { get; set; }
        public virtual DbSet<cmrecs_cap> cmrecs_cap { get; set; }
        public virtual DbSet<cnomchk> cnomchks { get; set; }
        public virtual DbSet<cnotfound> cnotfounds { get; set; }
        public virtual DbSet<cp_data> cp_data { get; set; }
        public virtual DbSet<cp_pymt> cp_pymt { get; set; }
        public virtual DbSet<Cpay_re> Cpay_re { get; set; }
        public virtual DbSet<cpay_rep> cpay_rep { get; set; }
        public virtual DbSet<cpay_tmp> cpay_tmp { get; set; }
        public virtual DbSet<cpay_tr> cpay_tr { get; set; }
        public virtual DbSet<cpay_trn> cpay_trn { get; set; }
        public virtual DbSet<cpayre_tmp> cpayre_tmp { get; set; }
        public virtual DbSet<cpen_amt> cpen_amt { get; set; }
        public virtual DbSet<cpen_cr> cpen_cr { get; set; }
        public virtual DbSet<cpen_pay> cpen_pay { get; set; }
        public virtual DbSet<cpen_tmp> cpen_tmp { get; set; }
        public virtual DbSet<cpenalty> cpenalties { get; set; }
        public virtual DbSet<cpenpay> cpenpays { get; set; }
        public virtual DbSet<cpenper> cpenpers { get; set; }
        public virtual DbSet<cpenwaive> cpenwaives { get; set; }
        public virtual DbSet<cpsch_tr> cpsch_tr { get; set; }
        public virtual DbSet<cr_ctrl> cr_ctrl { get; set; }
        public virtual DbSet<cr_post> cr_post { get; set; }
        public virtual DbSet<CR_SUBM_RPT> CR_SUBM_RPT { get; set; }
        public virtual DbSet<cretran> cretrans { get; set; }
        public virtual DbSet<crs_reg> crs_reg { get; set; }
        public virtual DbSet<crsreg> crsregs { get; set; }
        public virtual DbSet<crsubm> crsubms { get; set; }
        public virtual DbSet<crsubm_xx> crsubm_xx { get; set; }
        public virtual DbSet<cs_pymt> cs_pymt { get; set; }
        public virtual DbSet<cstmt_above> cstmt_above { get; set; }
        public virtual DbSet<cstmt_above1> cstmt_above1 { get; set; }
        public virtual DbSet<cstmt_below> cstmt_below { get; set; }
        public virtual DbSet<cstmt_below1> cstmt_below1 { get; set; }
        public virtual DbSet<cstmt_blow> cstmt_blow { get; set; }
        public virtual DbSet<cstmt_pg3_tab> cstmt_pg3_tab { get; set; }
        public virtual DbSet<ctrn_ctr> ctrn_ctr { get; set; }
        public virtual DbSet<ctype> ctypes { get; set; }
        public virtual DbSet<db_mst> db_mst { get; set; }
        public virtual DbSet<dben_pay> dben_pay { get; set; }
        public virtual DbSet<DBVersion> DBVersions { get; set; }
        public virtual DbSet<DEP> DEPs { get; set; }
        public virtual DbSet<dir_mst> dir_mst { get; set; }
        public virtual DbSet<dir_tr> dir_tr { get; set; }
        public virtual DbSet<dist_loc> dist_loc { get; set; }
        public virtual DbSet<dist_t> dist_t { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<dpen_per> dpen_per { get; set; }
        public virtual DbSet<dpen_rel> dpen_rel { get; set; }
        public virtual DbSet<dt> dts { get; set; }
        public virtual DbSet<dth_tm3> dth_tm3 { get; set; }
        public virtual DbSet<dth_tm3_b> dth_tm3_b { get; set; }
        public virtual DbSet<dthevid_tab> dthevid_tab { get; set; }
        public virtual DbSet<dup_mem> dup_mem { get; set; }
        public virtual DbSet<duprec_tr> duprec_tr { get; set; }
        public virtual DbSet<eclc_mst> eclc_mst { get; set; }
        public virtual DbSet<eclc_tr> eclc_tr { get; set; }
        public virtual DbSet<econ_act> econ_act { get; set; }
        public virtual DbSet<EditedMember> EditedMembers { get; set; }
        public virtual DbSet<emp_cmst> emp_cmst { get; set; }
        public virtual DbSet<emp_cov_date> emp_cov_date { get; set; }
        public virtual DbSet<emp_ledg> emp_ledg { get; set; }
        public virtual DbSet<emp_mbal> emp_mbal { get; set; }
        public virtual DbSet<emp_mst> emp_mst { get; set; }
        public virtual DbSet<emp_mstt> emp_mstt { get; set; }
        public virtual DbSet<emp_stem> emp_stem { get; set; }
        public virtual DbSet<empay> empays { get; set; }
        public virtual DbSet<empay_1> empay_1 { get; set; }
        public virtual DbSet<empay_tmp> empay_tmp { get; set; }
        public virtual DbSet<empay_tr> empay_tr { get; set; }
        public virtual DbSet<empcr> empcrs { get; set; }
        public virtual DbSet<empcr_tmp> empcr_tmp { get; set; }
        public virtual DbSet<empcr_tr> empcr_tr { get; set; }
        public virtual DbSet<empcr1> empcr1 { get; set; }
        public virtual DbSet<empcr2> empcr2 { get; set; }
        public virtual DbSet<empctr> empctrs { get; set; }
        public virtual DbSet<emprg_s> emprg_s { get; set; }
        public virtual DbSet<emprg_tr> emprg_tr { get; set; }
        public virtual DbSet<eneg_mst> eneg_mst { get; set; }
        public virtual DbSet<ereg_wcon> ereg_wcon { get; set; }
        public virtual DbSet<est_cat> est_cat { get; set; }
        public virtual DbSet<est_covdate> est_covdate { get; set; }
        public virtual DbSet<Est_CrPayChk> Est_CrPayChk { get; set; }
        public virtual DbSet<est_deac> est_deac { get; set; }
        public virtual DbSet<Existing_GovPenmem_chk> Existing_GovPenmem_chk { get; set; }
        public virtual DbSet<Existing_mem_chk> Existing_mem_chk { get; set; }
        public virtual DbSet<gb_brnch> gb_brnch { get; set; }
        public virtual DbSet<gbank> gbanks { get; set; }
        public virtual DbSet<gben_arr> gben_arr { get; set; }
        public virtual DbSet<gben_indx> gben_indx { get; set; }
        public virtual DbSet<gben_stopr> gben_stopr { get; set; }
        public virtual DbSet<gbenpay_h> gbenpay_h { get; set; }
        public virtual DbSet<gbindx_tr> gbindx_tr { get; set; }
        public virtual DbSet<gcpay_tr> gcpay_tr { get; set; }
        public virtual DbSet<gdeath_react> gdeath_react { get; set; }
        public virtual DbSet<gdist_loc> gdist_loc { get; set; }
        public virtual DbSet<gmem_tm3> gmem_tm3 { get; set; }
        public virtual DbSet<gmemo_ref> gmemo_ref { get; set; }
        public virtual DbSet<gmin_wage> gmin_wage { get; set; }
        public virtual DbSet<gmonth_tr> gmonth_tr { get; set; }
        public virtual DbSet<gnom_tr> gnom_tr { get; set; }
        public virtual DbSet<gov_cat> gov_cat { get; set; }
        public virtual DbSet<gov_code> gov_code { get; set; }
        public virtual DbSet<gov_dpen> gov_dpen { get; set; }
        public virtual DbSet<govpen_ssno> govpen_ssno { get; set; }
        public virtual DbSet<GovtMapSSNO> GovtMapSSNOes { get; set; }
        public virtual DbSet<gpamt_tr> gpamt_tr { get; set; }
        public virtual DbSet<gparental> gparentals { get; set; }
        public virtual DbSet<gpay_point> gpay_point { get; set; }
        public virtual DbSet<gpen_blst> gpen_blst { get; set; }
        public virtual DbSet<gpen_date> gpen_date { get; set; }
        public virtual DbSet<gpen_mst> gpen_mst { get; set; }
        public virtual DbSet<gprevname> gprevnames { get; set; }
        public virtual DbSet<gre_tran> gre_tran { get; set; }
        public virtual DbSet<gstop_tr> gstop_tr { get; set; }
        public virtual DbSet<gtrn_ctrl> gtrn_ctrl { get; set; }
        public virtual DbSet<gtrn_stem> gtrn_stem { get; set; }
        public virtual DbSet<hist> hists { get; set; }
        public virtual DbSet<hist_mst> hist_mst { get; set; }
        public virtual DbSet<hist_pr> hist_pr { get; set; }
        public virtual DbSet<hist_tmp> hist_tmp { get; set; }
        public virtual DbSet<hist_tr> hist_tr { get; set; }
        public virtual DbSet<insp_cod> insp_cod { get; set; }
        public virtual DbSet<insp_mst> insp_mst { get; set; }
        public virtual DbSet<insp_mst2> insp_mst2 { get; set; }
        public virtual DbSet<insp_tr> insp_tr { get; set; }
        public virtual DbSet<InsptIndebtednessSummary> InsptIndebtednessSummaries { get; set; }
        public virtual DbSet<InsptIntCalculation> InsptIntCalculations { get; set; }
        public virtual DbSet<InsptIntProcess> InsptIntProcesses { get; set; }
        public virtual DbSet<IntCalculation> IntCalculations { get; set; }
        public virtual DbSet<IntDetail> IntDetails { get; set; }
        public virtual DbSet<inv_code> inv_code { get; set; }
        public virtual DbSet<inv_corr> inv_corr { get; set; }
        public virtual DbSet<inval_cr> inval_cr { get; set; }
        public virtual DbSet<inval_t> inval_t { get; set; }
        public virtual DbSet<inval_tab> inval_tab { get; set; }
        public virtual DbSet<inval_tp> inval_tp { get; set; }
        public virtual DbSet<jdebt_tr> jdebt_tr { get; set; }
        public virtual DbSet<Lang_Captions> Lang_Captions { get; set; }
        public virtual DbSet<m_stmt> m_stmt { get; set; }
        public virtual DbSet<main_cat> main_cat { get; set; }
        public virtual DbSet<MainLogin> MainLogins { get; set; }
        public virtual DbSet<mbchk_lst> mbchk_lst { get; set; }
        public virtual DbSet<mben_ack> mben_ack { get; set; }
        public virtual DbSet<mben_mst> mben_mst { get; set; }
        public virtual DbSet<mben_stem> mben_stem { get; set; }
        public virtual DbSet<mben_t> mben_t { get; set; }
        public virtual DbSet<mcempay> mcempays { get; set; }
        public virtual DbSet<mchk_list> mchk_list { get; set; }
        public virtual DbSet<mdep_mst> mdep_mst { get; set; }
        public virtual DbSet<mdepchk> mdepchks { get; set; }
        public virtual DbSet<mdthchk_lst> mdthchk_lst { get; set; }
        public virtual DbSet<mem_ctmp> mem_ctmp { get; set; }
        public virtual DbSet<mem_q> mem_q { get; set; }
        public virtual DbSet<mem_sips> mem_sips { get; set; }
        public virtual DbSet<mem_stmt> mem_stmt { get; set; }
        public virtual DbSet<mem_tm3> mem_tm3 { get; set; }
        public virtual DbSet<mem_tm3_b> mem_tm3_b { get; set; }
        public virtual DbSet<mem_tm3_b1> mem_tm3_b1 { get; set; }
        public virtual DbSet<mem_tr> mem_tr { get; set; }
        public virtual DbSet<mem_val> mem_val { get; set; }
        public virtual DbSet<memcr_h> memcr_h { get; set; }
        public virtual DbSet<memcr_t> memcr_t { get; set; }
        public virtual DbSet<memcr_tr> memcr_tr { get; set; }
        public virtual DbSet<memcrtr_backup> memcrtr_backup { get; set; }
        public virtual DbSet<memno_sex> memno_sex { get; set; }
        public virtual DbSet<memo_ref> memo_ref { get; set; }
        public virtual DbSet<memq_tr> memq_tr { get; set; }
        public virtual DbSet<memsip_tr> memsip_tr { get; set; }
        public virtual DbSet<memsip_tran> memsip_tran { get; set; }
        public virtual DbSet<memsipcr_tr> memsipcr_tr { get; set; }
        public virtual DbSet<mer_stmt> mer_stmt { get; set; }
        public virtual DbSet<Migrate_data_err> Migrate_data_err { get; set; }
        public virtual DbSet<migrate_log> migrate_log { get; set; }
        public virtual DbSet<minmax_age> minmax_age { get; set; }
        public virtual DbSet<minmax_cp> minmax_cp { get; set; }
        public virtual DbSet<minmax_est> minmax_est { get; set; }
        public virtual DbSet<minmax_s> minmax_s { get; set; }
        public virtual DbSet<minmax_t1> minmax_t1 { get; set; }
        public virtual DbSet<minmax_t2> minmax_t2 { get; set; }
        public virtual DbSet<minmax_t3> minmax_t3 { get; set; }
        public virtual DbSet<minmax_t4> minmax_t4 { get; set; }
        public virtual DbSet<minmax_t5> minmax_t5 { get; set; }
        public virtual DbSet<month_tr> month_tr { get; set; }
        public virtual DbSet<mper> mpers { get; set; }
        public virtual DbSet<mper_mst> mper_mst { get; set; }
        public virtual DbSet<mpermst> mpermsts { get; set; }
        public virtual DbSet<mrec_tr> mrec_tr { get; set; }
        public virtual DbSet<nat_dist> nat_dist { get; set; }
        public virtual DbSet<nom_mst> nom_mst { get; set; }
        public virtual DbSet<nom_tr> nom_tr { get; set; }
        public virtual DbSet<occupate> occupates { get; set; }
        public virtual DbSet<onlinemper_mst> onlinemper_mst { get; set; }
        public virtual DbSet<onlinenom_mst> onlinenom_mst { get; set; }
        public virtual DbSet<onlineparen_mst> onlineparen_mst { get; set; }
        public virtual DbSet<onlineprevn_mst> onlineprevn_mst { get; set; }
        public virtual DbSet<op_env> op_env { get; set; }
        public virtual DbSet<own_type> own_type { get; set; }
        public virtual DbSet<p_point> p_point { get; set; }
        public virtual DbSet<p_pymt> p_pymt { get; set; }
        public virtual DbSet<paren_mst> paren_mst { get; set; }
        public virtual DbSet<parental> parentals { get; set; }
        public virtual DbSet<pass_du> pass_du { get; set; }
        public virtual DbSet<pay_re> pay_re { get; set; }
        public virtual DbSet<pay_stem> pay_stem { get; set; }
        public virtual DbSet<paymt_h> paymt_h { get; set; }
        public virtual DbSet<paymt_tr> paymt_tr { get; set; }
        public virtual DbSet<payprint> payprints { get; set; }
        public virtual DbSet<pdrpt_tr> pdrpt_tr { get; set; }
        public virtual DbSet<pen_bperd> pen_bperd { get; set; }
        public virtual DbSet<pen_cr> pen_cr { get; set; }
        public virtual DbSet<pen_freq> pen_freq { get; set; }
        public virtual DbSet<pen_mst> pen_mst { get; set; }
        public virtual DbSet<pen_pay> pen_pay { get; set; }
        public virtual DbSet<pen_per> pen_per { get; set; }
        public virtual DbSet<pen_waive> pen_waive { get; set; }
        public virtual DbSet<pension> pensions { get; set; }
        public virtual DbSet<prevn_mst> prevn_mst { get; set; }
        public virtual DbSet<prevname> prevnames { get; set; }
        public virtual DbSet<pros_tr> pros_tr { get; set; }
        public virtual DbSet<prosperd> prosperds { get; set; }
        public virtual DbSet<province> provinces { get; set; }
        public virtual DbSet<psch_tr> psch_tr { get; set; }
        public virtual DbSet<quater> quaters { get; set; }
        public virtual DbSet<re_tran> re_tran { get; set; }
        public virtual DbSet<rec_stem> rec_stem { get; set; }
        public virtual DbSet<recomp_tr> recomp_tr { get; set; }
        public virtual DbSet<ref_no> ref_nos { get; set; }
        public virtual DbSet<refno_tr> refno_tr { get; set; }
        public virtual DbSet<rej_tab> rej_tab { get; set; }
        public virtual DbSet<rel_mst> rel_mst { get; set; }
        public virtual DbSet<sch_level> sch_level { get; set; }
        public virtual DbSet<sch_me> sch_me { get; set; }
        public virtual DbSet<sch_tr> sch_tr { get; set; }
        public virtual DbSet<Softcopy_CtrlTr> Softcopy_CtrlTr { get; set; }
        public virtual DbSet<Softcopy_Tr> Softcopy_Tr { get; set; }
        public virtual DbSet<ssno_log> ssno_log { get; set; }
        public virtual DbSet<staf_cat> staf_cat { get; set; }
        public virtual DbSet<stafcat> stafcats { get; set; }
        public virtual DbSet<stud> studs { get; set; }
        public virtual DbSet<sur_type> sur_type { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_file> tb_file { get; set; }
        public virtual DbSet<tb_file1> tb_file1 { get; set; }
        public virtual DbSet<tbl1> tbl1 { get; set; }
        public virtual DbSet<temp> temps { get; set; }
        public virtual DbSet<temp_tr> temp_tr { get; set; }
        public virtual DbSet<temp2> temp2 { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<tnom_t1> tnom_t1 { get; set; }
        public virtual DbSet<tnom_tr> tnom_tr { get; set; }
        public virtual DbSet<tparen> tparens { get; set; }
        public virtual DbSet<tparen_t1> tparen_t1 { get; set; }
        public virtual DbSet<tprev_n> tprev_n { get; set; }
        public virtual DbSet<tprev_t1> tprev_t1 { get; set; }
        public virtual DbSet<tran_mper_mst> tran_mper_mst { get; set; }
        public virtual DbSet<tran_nom_mst> tran_nom_mst { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<user_grp> user_grp { get; set; }
        public virtual DbSet<user_level> user_level { get; set; }
        public virtual DbSet<user_log> user_log { get; set; }
        public virtual DbSet<user_test> user_test { get; set; }
        public virtual DbSet<user1> users1 { get; set; }
        public virtual DbSet<vpay_tr> vpay_tr { get; set; }
        public virtual DbSet<zone_cod> zone_cod { get; set; }
        public virtual DbSet<c_cheq> c_cheq { get; set; }
        public virtual DbSet<c_date> c_date { get; set; }
        public virtual DbSet<c_paymt> c_paymt { get; set; }
        public virtual DbSet<cdep_mst> cdep_mst { get; set; }
        public virtual DbSet<gben_pay> gben_pay { get; set; }
        public virtual DbSet<mem_stmt_Duplicate> mem_stmt_Duplicate { get; set; }
        public virtual DbSet<PrintCard> PrintCards { get; set; }
        public virtual DbSet<tran_nom_tr> tran_nom_tr { get; set; }
        public virtual DbSet<tran_parental> tran_parental { get; set; }
        public virtual DbSet<tran_prevname> tran_prevname { get; set; }

         public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<NASSITPercentage> NASSITPercentages { get; set; }
        public virtual DbSet<ReferenceNo> ReferenceNos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            modelBuilder.Entity<acct_chart>()
                .Property(e => e.fbus_type)
                .IsUnicode(false);

            modelBuilder.Entity<acct_chart>()
                .Property(e => e.fpay_type)
                .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_0)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_3)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_4)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_5)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_6)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_7)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_8)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ftcde_9)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<acct_chart>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<adm_stem>()
            //        .Property(e => e.fstem)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<adm_stem>()
            //        .Property(e => e.fserial_no)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<adm_stem>()
            //        .Property(e => e.fstem_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<adm_stem>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<adm_stem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<adm_stem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<APPLICATION_CTRL>()
            //        .Property(e => e.V_CLIENTNAME)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<APPLICATION_CTRL>()
            //        .Property(e => e.V_CAPTION)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<APPLICATION_CTRL>()
            //        .Property(e => e.V_FONTNAME)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<APPLICATION_CTRL>()
            //        .Property(e => e.N_FONTSIZE)
            //        .HasPrecision(2, 0);

            //    modelBuilder.Entity<AUDIT_LOG_DATA>()
            //        .Property(e => e.NEW_VALUE)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<AUDIT_LOG_DATA>()
            //        .Property(e => e.OLD_VALUE)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<AUDIT_LOG_DATA>()
            //        .Property(e => e.DATA_TYPE)
            //        .IsFixedLength()
            //        .IsUnicode(false);

            //    modelBuilder.Entity<AUDIT_LOG_TRANSACTIONS>()
            //        .Property(e => e.HOST_NAME)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<AUDIT_LOG_TRANSACTIONS>()
            //        .Property(e => e.APP_NAME)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<AUDIT_LOG_TRANSACTIONS>()
            //        .Property(e => e.MODIFIED_BY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<b_brnch>()
            //        .Property(e => e.fbnk_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<b_brnch>()
            //        .Property(e => e.fbrnch_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<b_brnch>()
            //        .Property(e => e.fbrnch_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<b_brnch>()
            //        .Property(e => e.facct_cde)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<b_brnch>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<b_brnch>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bal_chk>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bal_chk>()
            //        .Property(e => e.fbalperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bal_chk>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bal_chk>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fname1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fname2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fbak_begin)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fbak_end)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fbaktype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.fmisc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BAMtemp_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bank>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bank>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bank>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bank>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.ftype_app)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fmst_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fapp_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bapp_rct>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<batch_stem>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<batch_stem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<batch_stem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<batch_tr>()
            //        .Property(e => e.fbatch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<batch_tr>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<batch_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<batch_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_rec>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.frej_reaso)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.frel_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdep_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fmst_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.frname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fraddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.frtelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fdth_cause)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fdth_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fburial_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fdth_evid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fmresd_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fmhome_town)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.fdth_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.finvestigator)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bdrep_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_batch>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_batch>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_pay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_type>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_type>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_type>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ben_type>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bentype_mem>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bentype_mem>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bentype_mem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bentype_mem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bgval_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bgval_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<birth_stem>()
            //        .Property(e => e.flast_no)
            //        .HasPrecision(9, 0);

            //    modelBuilder.Entity<birth_stem>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<birth_stem>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<birth_stem>()
            //        .Property(e => e.ModifiedOn)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.fcash)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.fcheq)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.fadvice)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.fjournal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bk_log>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.freject_co)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fmresd_add)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fpassport_)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fnationali)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fmhome_tow)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.finvestiga)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fpben_bper)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fpben_eper)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.femp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fe_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fe_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fp_amt)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fp_dist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fp_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fmst_statu)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bmem_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.freject_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fmresd_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fpassport_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fmfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fnationality)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fmhome_town)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.finvestigator)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fmst_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnapp_tr>()
            //        .Property(e => e.ftran_log)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fmresd_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fpassport_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fmfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fnationality)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.freject_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fmhome_town)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.finvestigator)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fp_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fmst_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bnaprj_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<brs_ex>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<brs_ex>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<brs_ex>()
            //        .Property(e => e.flag)
            //        .IsFixedLength()
            //        .IsUnicode(false);

            //    modelBuilder.Entity<brs_ex>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<brs_ex>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fmachine)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fIPAddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fformName)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fusercode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.fusername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<BRSTran_Log>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bsch_tr>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bsch_tr>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bsch_tr>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bsch_tr>()
            //        .Property(e => e.fsch_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bsch_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bsch_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bus_type>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bus_type>()
            //        .Property(e => e.fdesc_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bus_type>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<bus_type>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fpay_perio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.farr_deduc)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_benp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cash>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cash>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cash>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cash>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cash>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cash>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cashpt>()
            //        .Property(e => e.fno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cashpt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cashpt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cat>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cat>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cat>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fnowkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fwkr_rec)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fdata_user)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fbaktype)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cpdata>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fnowkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fwkr_rec)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fdata_user)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsdata>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.fbaktype)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.fnowkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_crsreg>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_emp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_emp>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_emp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_emp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_invalt>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_invalt>()
            //        .Property(e => e.fno_inv)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<c_invalt>()
            //        .Property(e => e.fno_invt)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<c_invalt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_invalt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_memreg>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_memreg>()
            //        .Property(e => e.fmale)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<c_memreg>()
            //        .Property(e => e.female)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<c_memreg>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_memreg>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_penbnks>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_penbnks>()
            //        .Property(e => e.floc_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_penbnks>()
            //        .Property(e => e.ftot_amt)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_penbnks>()
            //        .Property(e => e.ftot_amt1)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<c_penbnks>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_penbnks>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_retrn>()
            //        .Property(e => e.ffile)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_retrn>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_retrn>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<c_retrn>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_retrn>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_retrn>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_stmt_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_trn1>()
            //        .Property(e => e.ffile)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_trn1>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_trn1>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<c_trn1>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_trn1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_trn1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.ftype)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.famttype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.fvalue)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_deno>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_pnt>()
            //        .Property(e => e.flast)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cash_pnt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cash_pnt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cashctrl_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cat_date>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cat_date>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cat_days>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cat_days>()
            //        .Property(e => e.fnomths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cat_days>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cat_days>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbapptr>()
            //        .Property(e => e.FP_AMT)
            //        .HasPrecision(17, 2);

            //    modelBuilder.Entity<cbapptr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbapptr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.flast_desig)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.faddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.ftype_rcpt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbenp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbgval_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cbgval_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.fsalary)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.fsalary)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cblow1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.ftotcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_ctrl>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn_old>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ccr_trn1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.ftype)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.frank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.famt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl_rep>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl1>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl1>()
            //        .Property(e => e.ftype)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cctrl1>()
            //        .Property(e => e.fvalue)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cctrl1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl2>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl2>()
            //        .Property(e => e.ftype)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cctrl2>()
            //        .Property(e => e.fvalue)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cctrl2>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl2>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cctrl3>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fb_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fe_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fcrbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fint_bal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fpen_bal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fcr_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fint_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fpen_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fp_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fp_int)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fp_pen)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.fp_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdem_let>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_rel>()
            //        .Property(e => e.modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fcnt)
            //        .HasPrecision(9, 0);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.fpen_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdpenper>()
            //        .Property(e => e.createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.fpurpose)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.fapprove)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.fduration)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.fbalance)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ceclmst_prnt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_dname>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_dname>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fcrbal)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fint_bal)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fpen_bal)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fcr_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fint_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.fpen_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.ftot_pay)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_mbal>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_name>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_name>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_name>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_name>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_name>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_name>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cemp_trn>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempinval>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempinval>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempinval>()
            //        .Property(e => e.ftrans)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cempinval>()
            //        .Property(e => e.finv)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cempinval>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempinval>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fpay_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fcr_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fest_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fpay_lf)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.fcr_lf)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmst_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fpay_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fcr_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fest_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fpay_lf)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.fcr_lf)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cempmsttt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_covdate>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_covdate>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_covdate>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_covdate>()
            //        .Property(e => e.fuser_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_covdate>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_covdate>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_reg>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_reg>()
            //        .Property(e => e.fdescr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_reg>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<cest_reg>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_reg>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.finsp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cest_trn>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.flast_desi)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.faddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fpay_perio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.farr_deduc)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.ftype_rcpt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.fuser_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_p>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.flast_desig)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.faddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.ftype_rcpt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cgben_pay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.fcheqno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.fbank_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cheq_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chiefdom>()
            //        .Property(e => e.fp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chiefdom>()
            //        .Property(e => e.fd_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chiefdom>()
            //        .Property(e => e.fc_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chiefdom>()
            //        .Property(e => e.fdescr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chiefdom>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chiefdom>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.ftotcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fwkrs)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fcont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fno1)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tp>()
            //        .Property(e => e.fflagtran)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fupd_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fcur_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.flast_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fcurcr_per)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fbak_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fbak_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fcorr_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chist_tr>()
            //        .Property(e => e.fflagtran)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.fcheqno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.fbank_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<chq_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fno_nests)
            //        .HasPrecision(19, 8);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fno_sests)
            //        .HasPrecision(19, 8);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.flf_n)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.flf_s)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fno_compn)
            //        .HasPrecision(19, 8);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fno_comps)
            //        .HasPrecision(19, 8);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fno_ncmpn)
            //        .HasPrecision(19, 8);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.fno_ncmps)
            //        .HasPrecision(19, 8);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_all>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 0);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.insp_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.insp_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.insp_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.insp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_by>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.insp_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.insp_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.insp_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.insp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinsp_byall>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.insp_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.insp_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.insp_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.insp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinspby_insp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinv_tmp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinv_tmp>()
            //        .Property(e => e.fno_inv)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cinv_tmp>()
            //        .Property(e => e.fno_invt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cinv_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cinv_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.frefno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.fuser_rec)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.fu_rec)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.fu_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cm_recd>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.fsalary)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmaxmin>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fmth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fnomths)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fbak_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.ftot_sal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_dstmt>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_stmt>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_stmt>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmem_stmt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.frefno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.fuser_rec)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cmrecs_cap>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fnfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.rel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnomchk>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnotfound>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnotfound>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cnotfound>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.flast_desi)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.faddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fpay_perio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.farr_deduc)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.ftype_rcpt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_data>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.fint_paid)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.fpen_paid)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.fpayno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.ftotpays)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cp_pymt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Cpay_re>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_rep>()
            //        .Property(e => e.fdescr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_rep>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_rep>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_rep>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.fint_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.fpen_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.fpayno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.ftotpays)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.flast_desi)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_tr>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_trn>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpay_trn>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpayre_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.fint_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.fpen_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.fpayno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.ftotpays)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_amt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_cr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fpencr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fpen_pay)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fno_days)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.frate)
            //        .HasPrecision(19, 3);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fintpen)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_pay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.fint_paid)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.fpen_paid)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.fpayno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.ftotpays)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpen_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenalty>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenalty>()
            //        .Property(e => e.fcr_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpenalty>()
            //        .Property(e => e.fnowkr)
            //        .HasPrecision(19, 0);

            //    modelBuilder.Entity<cpenalty>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenalty>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenalty>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.fint_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.fpen_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.fpayno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.ftotpays)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenpay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenper>()
            //        .Property(e => e.fdue_age)
            //        .HasPrecision(2, 0);

            //    modelBuilder.Entity<cpenper>()
            //        .Property(e => e.flast_3mth)
            //        .HasPrecision(7, 0);

            //    modelBuilder.Entity<cpenper>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenper>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.fpen_amoun)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.fuser_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpenwaive>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpsch_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cpsch_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.ftotcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_ctrl>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.fcr_file)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cr_post>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<CR_SUBM_RPT>()
            //        .Property(e => e.FPERIOD)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<CR_SUBM_RPT>()
            //        .Property(e => e.STATUS)
            //        .IsFixedLength()
            //        .IsUnicode(false);

            //    modelBuilder.Entity<CR_SUBM_RPT>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<CR_SUBM_RPT>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cretran>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cretran>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cretran>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<cretran>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cretran>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cretran>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fnowkr)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fwkr_rec)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fdata_user)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fbaktype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crs_reg>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fwkr_rec)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.ftot_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fdata_user)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fbaktype)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsreg>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fjan)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.ffeb)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fmar)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fapr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fmay)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fjun)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fjul)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.faug)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fsep)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.foct)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fnov)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.fdec)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fjan)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.ffeb)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fmar)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fapr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fmay)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fjun)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fjul)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.faug)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fsep)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.foct)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fnov)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.fdec)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<crsubm_xx>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.fnarration)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cs_pymt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_above1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_below1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_blow>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_blow>()
            //        .Property(e => e.fsalary)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_blow>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_blow>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_blow>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_blow>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fage)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fnmths_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fcr_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fnmths_pur)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fpur_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fl36_mths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.ffpen_q)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.frpen_q)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fipen_q)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.fgovt_val)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cstmt_pg3_tab>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctrn_ctr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctrn_ctr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctrn_ctr>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<ctrn_ctr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctrn_ctr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.descr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.dr_acct)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.cr_acct)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.jtype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.t)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ctype>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<db_mst>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<db_mst>()
            //        .Property(e => e.flag)
            //        .IsFixedLength()
            //        .IsUnicode(false);

            //    modelBuilder.Entity<db_mst>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<db_mst>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fdssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dben_pay>()
            //        .Property(e => e.ftran_log)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<DBVersion>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<DBVersion>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<DBVersion>()
            //        .Property(e => e.fupdateApp)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<DEP>()
            //        .Property(e => e.NAME)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<DEP>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<DEP>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_mst>()
            //        .Property(e => e.fdir_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_mst>()
            //        .Property(e => e.fdir_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_tr>()
            //        .Property(e => e.fold_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_tr>()
            //        .Property(e => e.fdir_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_tr>()
            //        .Property(e => e.fdir_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dir_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.floc_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.fdist_alias)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.fdist_adr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.fdist_tel)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.fdist_fax)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.fdist_mgr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.fbnk_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_loc>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_t>()
            //        .Property(e => e.p_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_t>()
            //        .Property(e => e.d_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_t>()
            //        .Property(e => e.d_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_t>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dist_t>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<district>()
            //        .Property(e => e.p_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<district>()
            //        .Property(e => e.d_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<district>()
            //        .Property(e => e.d_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<district>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<district>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fcnt)
            //        .HasPrecision(9, 0);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.frel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fdtype_des)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fvalid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.fpen_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_per>()
            //        .Property(e => e.createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.frel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fd_share)
            //        .HasPrecision(19, 6);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.fd_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dpen_rel>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.frej_reaso)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.frel_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.frel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fdtyp_des)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fevidence)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fmarital)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fdth_evid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fmst_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.frname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fraddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.frtelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fdth_cause)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fdth_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fburial_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fdth_evid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fmresd_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fmhome_town)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fdth_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.finvestigator)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fevidence)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dth_tm3_b>()
            //        .Property(e => e.fmarital)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dthevid_tab>()
            //        .Property(e => e.fevid_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dthevid_tab>()
            //        .Property(e => e.fevid_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dthevid_tab>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dthevid_tab>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fgov_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.refno_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<dup_mem>()
            //        .Property(e => e.fssno_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<duprec_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<duprec_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<duprec_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<duprec_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.fpurpose)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.fapprove)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.fduration)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_tr>()
            //        .Property(e => e.fpurpose)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_tr>()
            //        .Property(e => e.fapprove)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_tr>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eclc_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<econ_act>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<econ_act>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<econ_act>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<econ_act>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<EditedMember>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<EditedMember>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<EditedMember>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.fno_wkrs)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.ftot_con)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cmst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cov_date>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cov_date>()
            //        .Property(e => e.createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_cov_date>()
            //        .Property(e => e.modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fcrbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fpenbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fint_bal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fcont_pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.ftot_pen)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.ftot_int)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fpen_pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fint_pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.flpen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fneg)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.fnet_bal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_ledg>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fcrbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fint_bal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fpen_bal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fcr_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fint_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.fpen_cbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mbal>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fiecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_mstt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_stem>()
            //        .Property(e => e.fer_stem)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_stem>()
            //        .Property(e => e.fserial_no)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emp_stem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emp_stem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fe_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fused)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fuser_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fkount)
            //        .HasPrecision(19, 9);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fe_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fused)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fuser_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fkount)
            //        .HasPrecision(19, 9);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fe_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fused)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fe_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fused)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empay_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.fapen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.frpen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.fapen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.frpen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.fapen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.frpen_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fe_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fused)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr2>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr2>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr2>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empcr2>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.fpay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<empctr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.fprivate)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.fself_fin)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.fsub_full)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.facg_est)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_s>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.faddress1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.faddress2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.ftelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fcontact)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fsite)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fecon_act)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fcert_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fcomm_cno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fbusn_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fest_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fprint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fsalpatt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fnature)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.finsp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<emprg_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fcb_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fce_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fneg_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fcrbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.farr_date)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fpenbal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.ftinterest)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.ftnegpay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fest_rep)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fwitness)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<eneg_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ereg_wcon>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ereg_wcon>()
            //        .Property(e => e.fexp_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<ereg_wcon>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ereg_wcon>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_cat>()
            //        .Property(e => e.fcat_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_cat>()
            //        .Property(e => e.fcat_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_cat>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_cat>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_covdate>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_covdate>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_covdate>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.fbeginperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.fendperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.fcrlastperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.fcompute)
            //        .IsFixedLength()
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Est_CrPayChk>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.flast_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.flast_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.flast_lf)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.freact_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<est_deac>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Existing_GovPenmem_chk>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Existing_GovPenmem_chk>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Existing_mem_chk>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Existing_mem_chk>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gb_brnch>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gb_brnch>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gbank>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gbank>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_arr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gben_arr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_arr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.findx_rate)
            //        .HasPrecision(4, 2);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.findx_amt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.fbonus_rate)
            //        .HasPrecision(4, 2);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.fbonus_amt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.fbonus_sperd)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.fbonus_eperd)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_indx>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_stopr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_stopr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.famount)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(1, 0);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gbenpay_h>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gbindx_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gbindx_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.flast_desig)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.faddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.ftype_rcpt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gcpay_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gdeath_react>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gdeath_react>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gdist_loc>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gdist_loc>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fbatch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fgov_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.father)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.Mother)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.prev_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.prov_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.dist_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.chief_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmem_tm3>()
            //        .Property(e => e.occup_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmemo_ref>()
            //        .Property(e => e.fref_last)
            //        .HasPrecision(1, 0);

            //    modelBuilder.Entity<gmemo_ref>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmemo_ref>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmin_wage>()
            //        .Property(e => e.famt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gmin_wage>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmin_wage>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmonth_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gmonth_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fnfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gnom_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_cat>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_cat>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_cat>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_cat>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_cat>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_code>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_code>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fterm_sal)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fnotimes_p)
            //        .HasPrecision(3, 0);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fpen_right)
            //        .HasPrecision(6, 3);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.ftimes_pai)
            //        .HasPrecision(7, 0);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.ftotal_pai)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fmonth_sal)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fage)
            //        .HasPrecision(2, 0);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.fpen_amt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.funclaimed)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gov_dpen>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<govpen_ssno>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<govpen_ssno>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<GovtMapSSNO>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<GovtMapSSNO>()
            //        .Property(e => e.fGovtPenSSNo)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<GovtMapSSNO>()
            //        .Property(e => e.fDepSSNo)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<GovtMapSSNO>()
            //        .Property(e => e.fDep_Type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<GovtMapSSNO>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<GovtMapSSNO>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpamt_tr>()
            //        .Property(e => e.fpen_amt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpamt_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpamt_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.fmfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gparental>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpay_point>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpay_point>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_blst>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gpen_blst>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_blst>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_date>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(1, 0);

            //    modelBuilder.Entity<gpen_date>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_date>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fterm_sal)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fnotimes_paid)
            //        .HasPrecision(3, 0);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fpen_right)
            //        .HasPrecision(6, 3);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.ftimes_paid)
            //        .HasPrecision(7, 0);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.ftotal_paid)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fmonth_sal)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fage)
            //        .HasPrecision(2, 0);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fpen_amt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.funclaimed)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gpen_mst>()
            //        .Property(e => e.fpen_amt_old)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.fpfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gprevname>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gre_tran>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(5, 0);

            //    modelBuilder.Entity<gre_tran>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gre_tran>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fterm_sal)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fnotimes_p)
            //        .HasPrecision(3, 0);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fpen_right)
            //        .HasPrecision(6, 3);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.ftimes_pai)
            //        .HasPrecision(7, 0);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.ftotal_pai)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fmonth_sal)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fage)
            //        .HasPrecision(2, 0);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.fpen_amt)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.funclaimed)
            //        .HasPrecision(15, 2);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gstop_tr>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gtrn_ctrl>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(7, 0);

            //    modelBuilder.Entity<gtrn_ctrl>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gtrn_ctrl>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gtrn_stem>()
            //        .Property(e => e.flast_no)
            //        .HasPrecision(2, 0);

            //    modelBuilder.Entity<gtrn_stem>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gtrn_stem>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.frstcr_per)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fcur_cr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.flast_cr)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fcurcr_per)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.frstcr_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fcur_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.flast_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fcurcr_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fprocess)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.fcatbperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.frstcr_per)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fcur_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.flast_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fcurcr_per)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fprocess)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.fcatbperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_pr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.ftotcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.fcont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.fno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.fno1)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fupd_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fcur_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.flast_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fcurcr_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.fcorr_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<hist_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_cod>()
            //        .Property(e => e.finsp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_cod>()
            //        .Property(e => e.finsp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_cod>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_cod>()
            //        .Property(e => e.fgroup)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_cod>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_cod>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fpbperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fpeperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.flb_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fle_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fpay_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fcr_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fest_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fppay_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fpcr_cat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fnb_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fne_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.finsp_pl)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.finsp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.fprocessed)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst2>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_mst2>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.insp_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.insp_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.insp_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.insp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<insp_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.flastcr_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ftotalcr_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ftotalpay_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ftotalint_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ftotalint_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ftotalintpen_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.ftotalintpen_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIndebtednessSummary>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fprev_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fTBRate)
            //        .HasPrecision(3, 0);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fIntRate)
            //        .HasPrecision(10, 8);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fPIntRate)
            //        .HasPrecision(10, 8);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fCrAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fprev_CrAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fIntDays)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fIntAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fOutStandAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fDelayOutstand)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fIntonOutStand)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fPayAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fpenBalAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fPenDays)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fPenIntAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fcur_cramt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fCrForward)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fsubtotal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.fbalance)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.Cur_Pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.Cur_Contr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntCalculation>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fprev_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fTBRate)
            //        .HasPrecision(3, 0);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fIntRate)
            //        .HasPrecision(10, 8);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fPIntRate)
            //        .HasPrecision(10, 8);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fCrAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fprev_CrAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fIntDays)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fIntAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fOutStandAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fDelayOutstand)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fIntonOutStand)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fPayAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fpenBalAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fPenDays)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fPenIntAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fcur_cramt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fCrForward)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fsubtotal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.fbalance)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.Cur_Pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.Cur_Contr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<InsptIntProcess>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fPayAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fCrAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fIntAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fPenAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fIntDays)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.fPenDays)
            //        .HasPrecision(6, 0);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.Cur_Pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<IntCalculation>()
            //        .Property(e => e.Cur_Contr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.Period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.Description)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.Contribution)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.Interest)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.Payment)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.Balance)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<IntDetail>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_code>()
            //        .Property(e => e.finsp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_code>()
            //        .Property(e => e.finsp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_code>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_code>()
            //        .Property(e => e.fgroup)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_code>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_code>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.fwssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inv_corr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_cr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_t>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tab>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tab>()
            //        .Property(e => e.fno_inv)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<inval_tab>()
            //        .Property(e => e.fno_invt)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<inval_tab>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tab>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<inval_tp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.fbperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.fpaid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<jdebt_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Lang_Captions>()
            //        .Property(e => e.N_SRNUM)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Lang_Captions>()
            //        .Property(e => e.V_ENGLISH)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Lang_Captions>()
            //        .Property(e => e.V_OTHERS)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Lang_Captions>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Lang_Captions>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.fbakpay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<m_stmt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<main_cat>()
            //        .Property(e => e.cat_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<main_cat>()
            //        .Property(e => e.description)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<main_cat>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<main_cat>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.AccountID)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.FirstName)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.MiddleName)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.LastName)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.Gender)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.UserName)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.AccountStatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.Branch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.Department)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.AccessibleIndices)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<MainLogin>()
            //        .Property(e => e.SecurityQuestion)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fcnt)
            //        .HasPrecision(19, 3);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.freject_co)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fbank_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fben_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fapro_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fmresd_add)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fpassport_)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fnationali)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fmhome_tow)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.finvestiga)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fmst_statu)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.freq_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fp_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fpay_pnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.freq)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mbchk_lst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_ack>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_stem>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_stem>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_stem>()
            //        .Property(e => e.fserial_no)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<mben_stem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_stem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.frej_reaso)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.frel_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mben_t>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.fnomths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.famt_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.fcashier)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.fannsal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.fnoyr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.factors)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.fcost)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mcempay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fcnt)
            //        .HasPrecision(19, 0);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.father)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.mother)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.prev_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.prov_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.dist_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.chief_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.occup_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mchk_list>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.frej_reason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.frel_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdep_mst>()
            //        .Property(e => e.ftran_log)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fcnt)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.frej_reaso)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fdtype_des)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.frel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fappro_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fbank_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fdtyp_des)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fphy_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.floc_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fpay_pnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.freq)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fsch_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fsch_level)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdepchk>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fcnt)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fmst_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fmarital)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.frname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fraddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.frtelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fevidence)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fdth_cause)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fdth_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fburial_pl)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fdth_evid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fmresd_add)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fmhome_tow)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.fdth_statu)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.finvestiga)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.freject_co)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mdthchk_lst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fgov_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.father)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.Mother)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.prev_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.prov_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.dist_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.chief_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_ctmp>()
            //        .Property(e => e.occup_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_q>()
            //        .Property(e => e.fbatch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_q>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_q>()
            //        .Property(e => e.fq_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_q>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_q>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_sips>()
            //        .Property(e => e.fage)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_sips>()
            //        .Property(e => e.fmale)
            //        .HasPrecision(19, 6);

            //    modelBuilder.Entity<mem_sips>()
            //        .Property(e => e.female)
            //        .HasPrecision(19, 6);

            //    modelBuilder.Entity<mem_sips>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_sips>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fbatch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fgov_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.father)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.Mother)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.prev_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.prov_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.dist_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.chief_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3>()
            //        .Property(e => e.occup_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.freject_co)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fmresd_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fpassport_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fmfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fnationality)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fmhome_town)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.finvestiga)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fmst_statu)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fapro_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fbank_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fben_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.fpay_pnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.freq)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.frej_reason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.frel_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.finvest_g)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.Fapro_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fbank_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.frel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fdtyp_des)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fphy_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.floc_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fpay_pnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fsch_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.fsch_level)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tm3_b1>()
            //        .Property(e => e.freq)
            //        .IsFixedLength();

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fgov_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fbatch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fnat_income)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.foccupation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fgov_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_val>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_h>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_t>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcr_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.ftype_cr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fpcentre)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fothername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memcrtr_backup>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memno_sex>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memno_sex>()
            //        .Property(e => e.fmale)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memno_sex>()
            //        .Property(e => e.female)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memno_sex>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memno_sex>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memo_ref>()
            //        .Property(e => e.fmemo_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memo_ref>()
            //        .Property(e => e.fref_stem)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memo_ref>()
            //        .Property(e => e.fref_last)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<memo_ref>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memo_ref>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memq_tr>()
            //        .Property(e => e.fbatch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memq_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memq_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memq_tr>()
            //        .Property(e => e.fq_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memq_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memq_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fage)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fannsal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fnoyr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.factors)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fcost)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fappr_cde)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.fprnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.ftotmths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.ftotamt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tran>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tran>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tran>()
            //        .Property(e => e.famt_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsip_tran>()
            //        .Property(e => e.fcashier)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tran>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsip_tran>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.fnomths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.famt_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.fcashier)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<memsipcr_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbfebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbaprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbaugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fboctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fbdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mer_stmt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Migrate_data_err>()
            //        .Property(e => e.table_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Migrate_data_err>()
            //        .Property(e => e.err_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Migrate_data_err>()
            //        .Property(e => e.err_string)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Migrate_data_err>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Migrate_data_err>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<migrate_log>()
            //        .Property(e => e.table_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<migrate_log>()
            //        .Property(e => e.foxrec_cnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<migrate_log>()
            //        .Property(e => e.sqlrec_cnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<migrate_log>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<migrate_log>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_age>()
            //        .Property(e => e.min_age)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<minmax_age>()
            //        .Property(e => e.max_age)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<minmax_age>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_age>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.favgcont)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 9);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_cp>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.favgcont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_est>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.fmincont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.fmaxcont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_s>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t1>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t1>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t1>()
            //        .Property(e => e.fmincont)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<minmax_t1>()
            //        .Property(e => e.fmaxcont)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<minmax_t1>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t1>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.favgcont)
            //        .HasPrecision(38, 6);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t2>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.favgcont)
            //        .HasPrecision(38, 6);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t3>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t4>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t4>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t4>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t4>()
            //        .Property(e => e.favgcont)
            //        .HasPrecision(38, 6);

            //    modelBuilder.Entity<minmax_t4>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t4>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.fmonth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.favgcont)
            //        .HasPrecision(38, 6);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<minmax_t5>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<month_tr>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<month_tr>()
            //        .Property(e => e.fmth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<month_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<month_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fnat_incom)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.foccupatio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fmother)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.ffather)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fprov)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fdistrict)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.fchiefdom)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fnat_incom)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.foccupatio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mper_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 15);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fnat_incom)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.foccupatio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mpermst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.frefno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.fuser_rec)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mrec_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nat_dist>()
            //        .Property(e => e.fp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nat_dist>()
            //        .Property(e => e.fd_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nat_dist>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nat_dist>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nat_dist>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fnfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<nom_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<occupate>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<occupate>()
            //        .Property(e => e.fdescr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<occupate>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<occupate>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fnat_incom)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.foccupatio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinemper_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlinenom_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineparen_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.fpfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<onlineprevn_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_mgr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_alise)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_telno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_fax)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_email)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_dmd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_lc)
            //        .HasPrecision(10, 2);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fdist_title)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<op_env>()
            //        .Property(e => e.fBRSDBName)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<own_type>()
            //        .Property(e => e.fowner)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<own_type>()
            //        .Property(e => e.fdesc_own)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<own_type>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<own_type>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_point>()
            //        .Property(e => e.fp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_point>()
            //        .Property(e => e.fp_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_point>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_point>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.fcr_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.fint_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.fpen_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.fpayno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.ftotpays)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<p_pymt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paren_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.fmfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<parental>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pass_du>()
            //        .Property(e => e.code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pass_du>()
            //        .Property(e => e.duration)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pass_du>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pass_du>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pass_du>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_re>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_stem>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_stem>()
            //        .Property(e => e.fserial)
            //        .HasPrecision(19, 3);

            //    modelBuilder.Entity<pay_stem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pay_stem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.fnarration)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_h>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.fnarration)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<paymt_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fwordl1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fwordl2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fwordl3)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fdamt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fnarration)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fnaration)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fnaration1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fcheq1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.ftotal)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fboth)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fcont)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fstation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<payprint>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fmst_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.frname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fraddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.frtelno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fdth_cause)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fdth_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fburial_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fdth_evid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fmresd_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fmhome_town)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fdth_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.finvestigator)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pdrpt_tr>()
            //        .Property(e => e.fsclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_bperd>()
            //        .Property(e => e.fbegin)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_bperd>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_bperd>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.fno_wkr)
            //        .HasPrecision(19, 0);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.ftot_cont)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_cr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_freq>()
            //        .Property(e => e.freq)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_freq>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_freq>()
            //        .Property(e => e.fmths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_freq>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_freq>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fterm_sal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fbtype_opt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fpaymode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fbest_1yr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fbest_1amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fbest_1mth)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fb5_sal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fb5_avg)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.flast_3mth)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fpen_right)
            //        .HasPrecision(19, 6);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.ftimes_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.ftotal_paid)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fmonth_sal)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fage)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fmths_cr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fadd_mths)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fpen_amt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fnet_pay)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.flpay_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fprev_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.findex_perd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fentry)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fpay_pnt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_mst>()
            //        .Property(e => e.fpen_amt_old)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fpencr)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fpen_amt)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fno_days)
            //        .HasPrecision(19, 0);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.frate)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fintpen)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fpen_pay)
            //        .HasPrecision(19, 4);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_pay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fdue_age)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.freject_co)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.flast_erno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fbank)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.flast_3mth)
            //        .HasPrecision(19, 7);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fmresd_add)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fpassport_)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fben_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fnationali)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fmhome_tow)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.finvestiga)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fappr_by)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fmst_statu)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_per>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_waive>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_waive>()
            //        .Property(e => e.fpen_amount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pen_waive>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_waive>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pen_waive>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.C____period)
            //        .HasPrecision(16, 0);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.C____fin_ye)
            //        .HasPrecision(17, 0);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.C____bank_i)
            //        .HasPrecision(17, 0);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.C____arrear)
            //        .HasPrecision(22, 0);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.C____net_am)
            //        .HasPrecision(26, 0);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.C____pay_th)
            //        .HasPrecision(27, 0);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pension>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.fpfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevn_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.fpfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prevname>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fcourt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fjudge1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fproscutor)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.freason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fbperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fverdict)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fjudge2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.fcost)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<pros_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prosperd>()
            //        .Property(e => e.fbperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prosperd>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prosperd>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<prosperd>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<province>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<province>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<province>()
            //        .Property(e => e.fno)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<province>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<province>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<psch_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<psch_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.fmth1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.fmth2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.fmth3)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<quater>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<re_tran>()
            //        .Property(e => e.ffile)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<re_tran>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<re_tran>()
            //        .Property(e => e.frec_no)
            //        .HasPrecision(19, 5);

            //    modelBuilder.Entity<re_tran>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<re_tran>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<re_tran>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rec_stem>()
            //        .Property(e => e.fstem)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rec_stem>()
            //        .Property(e => e.fser_no)
            //        .HasPrecision(19, 0);

            //    modelBuilder.Entity<rec_stem>()
            //        .Property(e => e.fcash_p)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rec_stem>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rec_stem>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<recomp_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<recomp_tr>()
            //        .Property(e => e.fbperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<recomp_tr>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<recomp_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<recomp_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ref_no>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    //modelBuilder.Entity<ref_no>()
            //    //    .Property(e => e.fserial)
            //    //    .HasPrecision(19, 0);

            //    //modelBuilder.Entity<ref_no>()
            //    //    .Property(e => e.fl_qty)
            //    //    .HasPrecision(19, 0);

            //    modelBuilder.Entity<ref_no>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ref_no>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ref_no>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<refno_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<refno_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<refno_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rej_tab>()
            //        .Property(e => e.frj_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rej_tab>()
            //        .Property(e => e.frj_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rej_tab>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rej_tab>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rel_mst>()
            //        .Property(e => e.frel_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rel_mst>()
            //        .Property(e => e.frel_desc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rel_mst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rel_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<rel_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_level>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_level>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_level>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_level>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_me>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_me>()
            //        .Property(e => e.descript)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_me>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_me>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_tr>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_tr>()
            //        .Property(e => e.fstart)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_tr>()
            //        .Property(e => e.fend)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sch_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.ftotalAmt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.ftotalrec)
            //        .HasPrecision(10, 2);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.fbperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.ftran_log)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_CtrlTr>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fname1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fname2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fbperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.feperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fbaktype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fmisc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.fflag)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.ftran_log)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<Softcopy_Tr>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.foldssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fnewssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<ssno_log>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<staf_cat>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<staf_cat>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<staf_cat>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<staf_cat>()
            //        .Property(e => e.fmedia)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<staf_cat>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<staf_cat>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<stafcat>()
            //        .Property(e => e.cat_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<stafcat>()
            //        .Property(e => e.descript)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<stafcat>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<stafcat>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<stud>()
            //        .Property(e => e.id)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<stud>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<stud>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sur_type>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sur_type>()
            //        .Property(e => e.fdesc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sur_type>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<sur_type>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tb_file>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tb_file>()
            //        .Property(e => e.frate)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<tb_file>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tb_file>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tbl1>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tbl1>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.insp_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.insp_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.insp_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.insp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp>()
            //        .Property(e => e.noofw)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fcode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fname1)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fname2)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fcontr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fbak_begin)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fbak_end)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fbaktype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.fmisc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.insp_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.insp_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.insp_place)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.insp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.fremark)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.insp_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<temp2>()
            //        .Property(e => e.noofw)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<test>()
            //        .Property(e => e.id)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<test>()
            //        .Property(e => e.name)
            //        .IsFixedLength();

            //    modelBuilder.Entity<test>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<test>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_t1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fnfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tnom_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.fmfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tparen_t1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.fpfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_n>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.fpfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tprev_t1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.foldssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fcur_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fm_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fnation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fb_country)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fprovince)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fdist)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fchief)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.ftown)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fincome)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fnat_incom)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.foccupatio)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.femp_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.femp_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.ftel_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fquery)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_mper_mst>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fnfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_mst>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_grp>()
            //        .Property(e => e.code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_grp>()
            //        .Property(e => e.description)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_grp>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_grp>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_grp>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_level>()
            //        .Property(e => e.code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_level>()
            //        .Property(e => e.description)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_level>()
            //        .Property(e => e.fuser)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_level>()
            //        .Property(e => e.FuserDescription)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_level>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_level>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.user_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.login_status)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.IP_Address)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.machine_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_log>()
            //        .Property(e => e.fupdateApp)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_test>()
            //        .Property(e => e.CREATEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user_test>()
            //        .Property(e => e.MODIFIEDBY)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.user_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.user_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.passw)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.user_grp)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.user_level)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.duration_pass)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.passw_prev)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<user1>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fpaytype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fperiod)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fe_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fused)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.flf)
            //        .HasPrecision(19, 3);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<vpay_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<zone_cod>()
            //        .Property(e => e.fzone)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<zone_cod>()
            //        .Property(e => e.fzone_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<zone_cod>()
            //        .Property(e => e.finsp_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<zone_cod>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<zone_cod>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.id)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.cheqno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.famt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.fbrnch)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.fr_loc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.frecptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.fchequeno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_cheq>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_date>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.id)
            //        .HasPrecision(18, 0);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.t)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.from)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.to)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.famt)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.fschme)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<c_paymt>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fn_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fdclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fn_surname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fn_frstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fn_othname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fn_homeadd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fn_sex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fsch_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fdep_type)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fphy_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fpen_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.finvest)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fappr_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.frej_reason)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.frel_mst)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fpay_mode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fpaypoint)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fmember)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.fjob_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<cdep_mst>()
            //        .Property(e => e.ftran_log)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fclaim_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.firstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fbnk)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fbnk_name)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.facctno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.flast_desig)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.faddress)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.flocation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fcheq_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.floc)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fpay_period)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fbt_award)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fdeduction)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.farr_deduct)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.farrears)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.farr_bperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.farr_eperd)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.famount)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fgrant)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fmode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.ftimes_run)
            //        .HasPrecision(19, 1);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fstatus)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.ftype_rcpt)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fpay_point)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.frequency)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.fuser_paid)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.frec_stat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<gben_pay>()
            //        .Property(e => e.UnclaimRefNo)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fssnoold)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fssnonew)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.ferno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fcat)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.ftype)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fyear)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fjancr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.ffebcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fmarcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.faprcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fmaycr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fjuncr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fjulcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.faugcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fsepcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.foctcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fnovcr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fdeccr)
            //        .HasPrecision(19, 2);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fstaffno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<mem_stmt_Duplicate>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<PrintCard>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<PrintCard>()
            //        .Property(e => e.fusercode)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<PrintCard>()
            //        .Property(e => e.fusername)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<PrintCard>()
            //        .Property(e => e.freceiptno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<PrintCard>()
            //        .Property(e => e.Createdby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<PrintCard>()
            //        .Property(e => e.Modifiedby)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fnom_ssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fnsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fnfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fnothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fnomsex)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.frelation)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fper_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fres_addr)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fuser_cap)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_nom_tr>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.ffsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.ffirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.ffothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.fmsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.fmothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_parental>()
            //        .Property(e => e.fmfirstnam)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fref_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fssno)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fpsurname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fpfirstname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fpothname)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fuser_code)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.CreatedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.ModifiedBy)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fbatch_no)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<tran_prevname>()
            //        .Property(e => e.fpfirstnam)
            //        .IsUnicode(false);
               }
            }
    }
