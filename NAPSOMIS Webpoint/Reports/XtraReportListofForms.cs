using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReportListofForms
/// </summary>
public class XtraReportListofForms : DevExpress.XtraReports.UI.XtraReport
    {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    public DevExpress.DataAccess.ObjectBinding.ObjectDataSource MemberListDataSource;
    public DevExpress.DataAccess.ObjectBinding.ObjectDataSource SearchDataSource;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRPageInfo xrPageInfo1;
    private XRLabel xrLabel6;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLine xrLine1;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel19;
    private XRLabel xrLabel18;
    private XRLabel xrLabel66;
    private XRLabel xrLabel20;
    private PageFooterBand PageFooter;
    private XRPageInfo xrPageInfo2;
    private XRPictureBox xrPictureBox1;
    private XRLine xrLine2;
    private XRLabel xrLabel21;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReportListofForms()
        {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
        }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
        {
        if (disposing && (components != null))
            {
            components.Dispose();
            }
        base.Dispose(disposing);
        }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportListofForms));
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.SearchDataSource = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.MemberListDataSource = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberListDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 38.54167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ModifiedBy")});
            this.xrLabel12.Dpi = 100F;
            this.xrLabel12.Font = new System.Drawing.Font("Courier New", 9F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(729.9584F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(255.2084F, 19F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel12";
            // 
            // xrLabel11
            // 
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CreatedBy")});
            this.xrLabel11.Dpi = 100F;
            this.xrLabel11.Font = new System.Drawing.Font("Courier New", 9F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(533.3335F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(196.6249F, 19F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ModifiedOn", "{0:dd/MM/yyyy}")});
            this.xrLabel10.Dpi = 100F;
            this.xrLabel10.Font = new System.Drawing.Font("Courier New", 9F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(410.4169F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 19F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CreatedOn", "{0:dd/MM/yyyy}")});
            this.xrLabel9.Dpi = 100F;
            this.xrLabel9.Font = new System.Drawing.Font("Courier New", 9F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(290.375F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(104.1666F, 19F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "xrLabel9";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 100F;
            this.xrLabel8.Font = new System.Drawing.Font("Courier New", 9F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(74.58339F, 18.99999F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(268.75F, 19F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "[fsurname], [firstname] [fothname]";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fref_no")});
            this.xrLabel7.Dpi = 100F;
            this.xrLabel7.Font = new System.Drawing.Font("Courier New", 9F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(74.58339F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(170.8333F, 19F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "xrLabel7";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel66,
            this.xrLabel20,
            this.xrLine1,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel6,
            this.xrPageInfo1,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 139.9583F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 100F;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(32.04166F, 22.33335F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(106.25F, 53.125F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel66
            // 
            this.xrLabel66.Dpi = 100F;
            this.xrLabel66.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(335.4167F, 28.45834F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(352.875F, 20F);
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            this.xrLabel66.Text = "National Social Security and Insurance Trust";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Dpi = 100F;
            this.xrLabel20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(375.0001F, 8.000007F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(264.5834F, 19F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Republic of Sierra Leone";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.Dpi = 100F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(74.5832F, 133.7083F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(953.3336F, 3.666733F);
            // 
            // xrLabel17
            // 
            this.xrLabel17.Dpi = 100F;
            this.xrLabel17.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(729.9584F, 110.7083F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(116.6666F, 22.99999F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "CAPTURED BY";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Dpi = 100F;
            this.xrLabel16.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(533.3334F, 109.7083F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(116.6666F, 22.99999F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "RECEIVED BY";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Dpi = 100F;
            this.xrLabel15.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(410.4167F, 109.7083F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(116.6666F, 22.99999F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "DATE CAPTURED";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Dpi = 100F;
            this.xrLabel14.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(290.3749F, 109.7083F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(116.6666F, 22.99999F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "DATE RECEIVED";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Dpi = 100F;
            this.xrLabel13.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(74.5832F, 109.7083F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(125F, 22.99999F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "REF. NUMBER";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 100F;
            this.xrLabel6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(816.6667F, 67.45834F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(85.41669F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Office:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 100F;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(816.6667F, 44.45834F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(179.1666F, 23F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.SearchDataSource, "EndDate", "{0:dd/MM/yyyy}")});
            this.xrLabel5.Dpi = 100F;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(575.9585F, 75.45834F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(92.70831F, 23F);
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 100F;
            this.xrLabel4.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(536.4586F, 75.45834F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(37.5F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "and";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.SearchDataSource, "StartDate", "{0:dd/MM/yyyy}")});
            this.xrLabel3.Dpi = 100F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(454.1668F, 75.45834F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(82.29166F, 23F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 100F;
            this.xrLabel2.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(368.7501F, 75.45834F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(85.41669F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Between";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(368.7501F, 56.45834F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(293.75F, 19.00001F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "LIST OF SS1 FORMS RECEIVED";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 11.45833F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel19,
            this.xrLabel18});
            this.ReportFooter.Dpi = 100F;
            this.ReportFooter.HeightF = 32.50001F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLine2
            // 
            this.xrLine2.Dpi = 100F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(33.12499F, 29.20833F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(177.0833F, 2.083334F);
            // 
            // xrLabel19
            // 
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ftel_no")});
            this.xrLabel19.Dpi = 100F;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(98.41664F, 4.000007F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(110.3334F, 23F);
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:#,#}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel19.Summary = xrSummary2;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Dpi = 100F;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(32.04166F, 4.000007F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(61.375F, 23F);
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Total No:";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
            this.PageFooter.Dpi = 100F;
            this.PageFooter.HeightF = 31.25F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Dpi = 100F;
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(934.1669F, 6.666675F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(93.74994F, 23F);
            // 
            // xrLabel21
            // 
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ftel_no")});
            this.xrLabel21.Dpi = 100F;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(32.04166F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(38.83341F, 23F);
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,#}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Page;
            this.xrLabel21.Summary = xrSummary1;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SearchDataSource
            // 
            this.SearchDataSource.DataSource = typeof(NAPSOMIS_Webpoint.ViewModels.PrintCheckListTemplate);
            this.SearchDataSource.Name = "SearchDataSource";
            // 
            // MemberListDataSource
            // 
            this.MemberListDataSource.DataSource = typeof(NAPSOMIS_Webpoint.Models.MemberTransaction);
            this.MemberListDataSource.Name = "MemberListDataSource";
            // 
            // XtraReportListofForms
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.MemberListDataSource,
            this.SearchDataSource});
            this.DataSource = this.MemberListDataSource;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(19, 35, 140, 11);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.SnapToGrid = false;
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberListDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

    #endregion
    }
