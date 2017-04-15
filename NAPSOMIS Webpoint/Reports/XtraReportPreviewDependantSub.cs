using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReportPreviewMember
/// </summary>
public class XtraReportPreviewDependantSub : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRControlStyle Title;
    private XRControlStyle FieldCaption;
    private XRControlStyle PageInfo;
    private XRControlStyle DataField;
    private XRLabel xrLabel90;
    private XRLabel xrLabel91;
    private XRLabel xrLabel92;
    private XRLabel xrLabel93;
    private XRLabel xrLabel94;
    private XRLabel xrLabel95;
    private XRLabel xrLabel96;
    private XRLabel xrLabel97;
    private XRLabel xrLabel98;
    private XRLabel xrLabel99;
    private XRLabel xrLabel100;
    private XRLabel xrLabel101;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel103;
    private XRLabel xrLabel102;
    public DevExpress.DataAccess.ObjectBinding.ObjectDataSource DependantDataSource;
    private PageHeaderBand PageHeader;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReportPreviewDependantSub()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportPreviewDependantSub));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel103 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel90 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
            this.DependantDataSource = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel99 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel100 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.DependantDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel95,
            this.xrLabel100,
            this.xrLabel99,
            this.xrLabel98,
            this.xrLabel97,
            this.xrLabel96,
            this.xrLabel101});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 42.22895F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 8.249998F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 15.79196F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel103
            // 
            this.xrLabel103.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel103.Dpi = 100F;
            this.xrLabel103.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel103.LocationFloat = new DevExpress.Utils.PointFloat(558.1248F, 8.145936F);
            this.xrLabel103.Name = "xrLabel103";
            this.xrLabel103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel103.SizeF = new System.Drawing.SizeF(123.75F, 18F);
            this.xrLabel103.StylePriority.UseBorders = false;
            this.xrLabel103.StylePriority.UseFont = false;
            this.xrLabel103.StylePriority.UseForeColor = false;
            this.xrLabel103.StylePriority.UseTextAlignment = false;
            this.xrLabel103.Text = "SERIAL NUMBER";
            this.xrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel102
            // 
            this.xrLabel102.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fref_no")});
            this.xrLabel102.Dpi = 100F;
            this.xrLabel102.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel102.ForeColor = System.Drawing.Color.Black;
            this.xrLabel102.LocationFloat = new DevExpress.Utils.PointFloat(554.4161F, 27.4793F);
            this.xrLabel102.Name = "xrLabel102";
            this.xrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel102.SizeF = new System.Drawing.SizeF(195.2917F, 20.375F);
            this.xrLabel102.StyleName = "FieldCaption";
            this.xrLabel102.StylePriority.UseFont = false;
            this.xrLabel102.StylePriority.UseForeColor = false;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Dpi = 100F;
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(12.70831F, 7.291667F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(79.16666F, 38.54167F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel91
            // 
            this.xrLabel91.Dpi = 100F;
            this.xrLabel91.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel91.LocationFloat = new DevExpress.Utils.PointFloat(514.229F, 52.52075F);
            this.xrLabel91.Name = "xrLabel91";
            this.xrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel91.SizeF = new System.Drawing.SizeF(235.4167F, 23F);
            this.xrLabel91.StylePriority.UseFont = false;
            this.xrLabel91.StylePriority.UseTextAlignment = false;
            this.xrLabel91.Text = "Permanent/Residential Address";
            this.xrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel92
            // 
            this.xrLabel92.Dpi = 100F;
            this.xrLabel92.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(11.45837F, 52.52075F);
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(86.45834F, 23F);
            this.xrLabel92.StylePriority.UseFont = false;
            this.xrLabel92.StylePriority.UseTextAlignment = false;
            this.xrLabel92.Text = "Sex";
            this.xrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel93
            // 
            this.xrLabel93.Dpi = 100F;
            this.xrLabel93.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(103.2871F, 52.52075F);
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(178.6505F, 23F);
            this.xrLabel93.StylePriority.UseFont = false;
            this.xrLabel93.StylePriority.UseTextAlignment = false;
            this.xrLabel93.Text = "SS Number/ Birth Date";
            this.xrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel94
            // 
            this.xrLabel94.Dpi = 100F;
            this.xrLabel94.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(315.9375F, 52.52075F);
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(123.9583F, 23F);
            this.xrLabel94.StylePriority.UseFont = false;
            this.xrLabel94.StylePriority.UseTextAlignment = false;
            this.xrLabel94.Text = "Name/Relation";
            this.xrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel90
            // 
            this.xrLabel90.Dpi = 100F;
            this.xrLabel90.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel90.LocationFloat = new DevExpress.Utils.PointFloat(245.2498F, 18.25002F);
            this.xrLabel90.Name = "xrLabel90";
            this.xrLabel90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel90.SizeF = new System.Drawing.SizeF(239.0836F, 23.8333F);
            this.xrLabel90.StylePriority.UseFont = false;
            this.xrLabel90.StylePriority.UseTextAlignment = false;
            this.xrLabel90.Text = "DEPENDANTS";
            this.xrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel95
            // 
            this.xrLabel95.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "frelation")});
            this.xrLabel95.Dpi = 100F;
            this.xrLabel95.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(242.3542F, 20.29165F);
            this.xrLabel95.Name = "xrLabel95";
            this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel95.SizeF = new System.Drawing.SizeF(203.125F, 18F);
            this.xrLabel95.StylePriority.UseFont = false;
            this.xrLabel95.StylePriority.UseTextAlignment = false;
            this.xrLabel95.Text = "xrLabel12";
            this.xrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DependantDataSource
            // 
            this.DependantDataSource.DataSource = typeof(NAPSOMIS_Webpoint.Models.nom_tr);
            this.DependantDataSource.Name = "DependantDataSource";
            // 
            // xrLabel96
            // 
            this.xrLabel96.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fres_addr")});
            this.xrLabel96.Dpi = 100F;
            this.xrLabel96.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(516.3124F, 20.29165F);
            this.xrLabel96.Name = "xrLabel96";
            this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel96.SizeF = new System.Drawing.SizeF(245.8332F, 18F);
            this.xrLabel96.StylePriority.UseFont = false;
            this.xrLabel96.StylePriority.UseTextAlignment = false;
            this.xrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel97
            // 
            this.xrLabel97.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fper_addr")});
            this.xrLabel97.Dpi = 100F;
            this.xrLabel97.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel97.LocationFloat = new DevExpress.Utils.PointFloat(516.3124F, 1.291656F);
            this.xrLabel97.Name = "xrLabel97";
            this.xrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel97.SizeF = new System.Drawing.SizeF(245.8332F, 18F);
            this.xrLabel97.StylePriority.UseFont = false;
            this.xrLabel97.StylePriority.UseTextAlignment = false;
            this.xrLabel97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel98
            // 
            this.xrLabel98.Dpi = 100F;
            this.xrLabel98.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(242.3542F, 1.291656F);
            this.xrLabel98.Name = "xrLabel98";
            this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel98.SizeF = new System.Drawing.SizeF(271.8751F, 18F);
            this.xrLabel98.StylePriority.UseFont = false;
            this.xrLabel98.StylePriority.UseTextAlignment = false;
            this.xrLabel98.Text = "[fnsurname], [fnfirstname] [fnothname]";
            this.xrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel99
            // 
            this.xrLabel99.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fbirth_date")});
            this.xrLabel99.Dpi = 100F;
            this.xrLabel99.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel99.LocationFloat = new DevExpress.Utils.PointFloat(99.12036F, 21.33331F);
            this.xrLabel99.Name = "xrLabel99";
            this.xrLabel99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel99.SizeF = new System.Drawing.SizeF(136.4583F, 18F);
            this.xrLabel99.StylePriority.UseFont = false;
            this.xrLabel99.StylePriority.UseTextAlignment = false;
            this.xrLabel99.Text = "xrLabel7";
            this.xrLabel99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel100
            // 
            this.xrLabel100.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fnomsex")});
            this.xrLabel100.Dpi = 100F;
            this.xrLabel100.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel100.LocationFloat = new DevExpress.Utils.PointFloat(11.45833F, 2.87501F);
            this.xrLabel100.Name = "xrLabel100";
            this.xrLabel100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel100.SizeF = new System.Drawing.SizeF(86.45833F, 18F);
            this.xrLabel100.StylePriority.UseFont = false;
            this.xrLabel100.StylePriority.UseTextAlignment = false;
            this.xrLabel100.Text = "xrLabel6";
            this.xrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel101
            // 
            this.xrLabel101.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fnom_ssno")});
            this.xrLabel101.Dpi = 100F;
            this.xrLabel101.Font = new System.Drawing.Font("Courier New", 8F);
            this.xrLabel101.LocationFloat = new DevExpress.Utils.PointFloat(99.12036F, 2.333323F);
            this.xrLabel101.Name = "xrLabel101";
            this.xrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel101.SizeF = new System.Drawing.SizeF(136.4583F, 18F);
            this.xrLabel101.StylePriority.UseFont = false;
            this.xrLabel101.StylePriority.UseTextAlignment = false;
            this.xrLabel101.Text = "xrLabel1";
            this.xrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel90,
            this.xrLabel94,
            this.xrLabel93,
            this.xrLabel92,
            this.xrLabel91,
            this.xrPictureBox2,
            this.xrLabel102,
            this.xrLabel103});
            this.PageHeader.Dpi = 100F;
            this.PageHeader.HeightF = 78.125F;
            this.PageHeader.Name = "PageHeader";
            // 
            // XtraReportPreviewDependantSub
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DependantDataSource});
            this.DataSource = this.DependantDataSource;
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Margins = new System.Drawing.Printing.Margins(21, 41, 8, 16);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid;
            this.SnapToGrid = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this.DependantDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
