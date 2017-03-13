using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReportReferenceNos
/// </summary>
public class XtraReportReferenceNos : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRControlStyle Title;
    private XRControlStyle FieldCaption;
    private XRControlStyle PageInfo;
    private XRControlStyle DataField;
    public DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel5;
    private XRLabel xrLabel12;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel xrLabel13;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;
    private XRLabel xrLabel14;
    private XRLabel xrLabel18;
    private XRLabel xrLabel22;
    private XRLabel xrLabel21;
    private XRLabel xrLabel20;
    private XRLabel xrLabel19;
    private XRLabel xrLabel25;
    private XRLabel xrLabel24;
    private XRLabel xrLabel23;
    private XRLabel xrLabel6;
    private XRPanel xrPanel2;
    private XRLine xrLine1;
    private XRLine xrLine2;
    private XRLine xrLine3;
    private XRLine xrLine4;
    private XRLabel xrLabel26;
    private XRLabel xrLabel27;
    private XRLabel xrLabel28;
    private XRLine xrLine6;
    private XRLine xrLine5;
    private XRLine xrLine7;
    private XRShape xrShape5;
    private XRLabel xrLabel33;
    private XRShape xrShape4;
    private XRLabel xrLabel32;
    private XRLabel xrLabel31;
    private XRShape xrShape3;
    private XRShape xrShape2;
    private XRLabel xrLabel30;
    private XRLabel xrLabel29;
    private XRShape xrShape1;
    private XRLabel xrLabel38;
    private XRLabel xrLabel37;
    private XRLabel xrLabel36;
    private XRLabel xrLabel35;
    private XRLabel xrLabel34;
    private XRLabel xrLabel42;
    private XRLine xrLine9;
    private XRLabel xrLabel39;
    private XRLabel xrLabel40;
    private XRLabel xrLabel41;
    private XRLine xrLine8;
    private XRLine xrLine10;
    private XRLabel xrLabel43;
    private XRLine xrLine11;
    private XRLabel xrLabel44;
    private XRLabel xrLabel45;
    private XRLine xrLine13;
    private XRLabel xrLabel46;
    private XRLabel xrLabel49;
    private XRLine xrLine12;
    private XRShape xrShape8;
    private XRLabel xrLabel51;
    private XRShape xrShape6;
    private XRLabel xrLabel47;
    private XRLabel xrLabel50;
    private XRShape xrShape7;
    private XRLabel xrLabel54;
    private XRLine xrLine14;
    private XRLabel xrLabel48;
    private XRLabel xrLabel52;
    private XRLabel xrLabel53;
    private XRLine xrLine17;
    private XRLine xrLine16;
    private XRLabel xrLabel55;
    private XRLine xrLine15;
    private XRLabel xrLabel56;
    private XRLabel xrLabel57;
    private XRLabel xrLabel58;
    private XRLabel xrLabel59;
    private XRLine xrLine18;
    private XRLabel xrLabel61;
    private XRLabel xrLabel60;
    private XRLine xrLine19;
    private XRLine xrLine20;
    private XRLabel xrLabel63;
    private XRLabel xrLabel62;
    private XRLabel xrLabel64;
    private XRLabel xrLabel65;
    private XRLabel xrLabel66;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel69;
    private XRLabel xrLabel68;
    private XRLabel xrLabel67;
    private XRLabel xrLabel70;
    private XRLabel xrLabel71;
    private XRShape xrShape9;
    private XRLabel xrLabel72;
    private XRShape xrShape10;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReportReferenceNos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportReferenceNos));
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle2 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle3 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle4 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle5 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle6 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle7 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle8 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle9 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle10 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine20 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine19 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine18 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine17 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine16 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine15 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine14 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape8 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape6 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape7 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape5 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape4 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape3 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape2 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape9 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape10 = new DevExpress.XtraReports.UI.XRShape();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel72,
            this.xrLabel71,
            this.xrLabel70,
            this.xrLabel69,
            this.xrLabel68,
            this.xrLabel67,
            this.xrPictureBox1,
            this.xrLabel66,
            this.xrLabel65,
            this.xrLabel64,
            this.xrLabel63,
            this.xrLabel62,
            this.xrLine20,
            this.xrLabel12,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrPanel2,
            this.xrShape9,
            this.xrShape10});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 1067.229F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel72
            // 
            this.xrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel72.Dpi = 100F;
            this.xrLabel72.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(526.8749F, 117.7708F);
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(193.7501F, 17.00001F);
            this.xrLabel72.StylePriority.UseBorders = false;
            this.xrLabel72.StylePriority.UseFont = false;
            this.xrLabel72.StylePriority.UseTextAlignment = false;
            this.xrLabel72.Text = "Payroll No./Pin Code";
            this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel71
            // 
            this.xrLabel71.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel71.Dpi = 100F;
            this.xrLabel71.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(13.29177F, 989.1458F);
            this.xrLabel71.Multiline = true;
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(737.6669F, 18.08319F);
            this.xrLabel71.StylePriority.UseBorders = false;
            this.xrLabel71.StylePriority.UseFont = false;
            this.xrLabel71.StylePriority.UseForeColor = false;
            this.xrLabel71.StylePriority.UseTextAlignment = false;
            this.xrLabel71.Text = "Important: Keep this slip safely and produce it for photo verification";
            this.xrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel70
            // 
            this.xrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel70.Dpi = 100F;
            this.xrLabel70.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(12.24998F, 938.7291F);
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(739.5834F, 20F);
            this.xrLabel70.StylePriority.UseBorders = false;
            this.xrLabel70.StylePriority.UseFont = false;
            this.xrLabel70.StylePriority.UseForeColor = false;
            this.xrLabel70.StylePriority.UseTextAlignment = false;
            this.xrLabel70.Text = "Place of Issue .................................................................." +
    "................................................................................" +
    ".....";
            this.xrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel69
            // 
            this.xrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel69.Dpi = 100F;
            this.xrLabel69.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(12.24998F, 911.7291F);
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(739.5834F, 20F);
            this.xrLabel69.StylePriority.UseBorders = false;
            this.xrLabel69.StylePriority.UseFont = false;
            this.xrLabel69.StylePriority.UseForeColor = false;
            this.xrLabel69.StylePriority.UseTextAlignment = false;
            this.xrLabel69.Text = "Name of NASSIT Official ........................................................." +
    "..............................................................................";
            this.xrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel68
            // 
            this.xrLabel68.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel68.Dpi = 100F;
            this.xrLabel68.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(11.20831F, 886.7708F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(739.5834F, 20F);
            this.xrLabel68.StylePriority.UseBorders = false;
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UseForeColor = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            this.xrLabel68.Text = "................................................................................." +
    "........................... has duly completed form SS 1A";
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel67
            // 
            this.xrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel67.Dpi = 100F;
            this.xrLabel67.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(11.20831F, 860.6874F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(739.5834F, 20F);
            this.xrLabel67.StylePriority.UseBorders = false;
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseForeColor = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            this.xrLabel67.Text = "This is to Certify that Mr/Mrs/Ms................................................" +
    "....................................................................... of";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 100F;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(19.625F, 21.875F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(106.25F, 53.125F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel66
            // 
            this.xrLabel66.Dpi = 100F;
            this.xrLabel66.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(175.375F, 33.20834F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(375.0001F, 21F);
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            this.xrLabel66.Text = "National Social Security and Insurance Trust";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel65
            // 
            this.xrLabel65.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel65.Dpi = 100F;
            this.xrLabel65.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(13.25011F, 967.0625F);
            this.xrLabel65.Multiline = true;
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(737.6669F, 22.08325F);
            this.xrLabel65.StylePriority.UseBorders = false;
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseForeColor = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            this.xrLabel65.Text = "Date ........................................................\t                   " +
    "                Signature .............................................";
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel64
            // 
            this.xrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel64.Dpi = 100F;
            this.xrLabel64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(413.2917F, 833.4375F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(123.75F, 23F);
            this.xrLabel64.StylePriority.UseBorders = false;
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseForeColor = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            this.xrLabel64.Text = "SERIAL NUMBER";
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel63
            // 
            this.xrLabel63.Dpi = 100F;
            this.xrLabel63.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(14.18745F, 823.5416F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(391.6667F, 22F);
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            this.xrLabel63.Text = "ACKNOWLEDGEMENT OF RECEIPT OF FORM SS 1A";
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel62
            // 
            this.xrLabel62.Dpi = 100F;
            this.xrLabel62.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(14.10412F, 800.3333F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(455.2084F, 23F);
            this.xrLabel62.StylePriority.UseFont = false;
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            this.xrLabel62.Text = "NATIONAL SOCIAL SECURITY AND INSURANCE TRUST";
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine20
            // 
            this.xrLine20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine20.Dpi = 100F;
            this.xrLine20.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.xrLine20.LineWidth = 2;
            this.xrLine20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 788.9686F);
            this.xrLine20.Name = "xrLine20";
            this.xrLine20.SizeF = new System.Drawing.SizeF(760.7084F, 4.458313F);
            this.xrLine20.StylePriority.UseBorders = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Dpi = 100F;
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(29.20842F, 170.0417F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(689.4584F, 18.99998F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Please note you are liable to prosecution in the event of any false declaration u" +
    "nder the NASSIT Act No. 5 of 2001";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 100F;
            this.xrLabel3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(624.7494F, 821.1459F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(108.3333F, 12.70837F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "**********";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReferenceNo")});
            this.xrLabel4.Dpi = 100F;
            this.xrLabel4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(561.7081F, 833.9792F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(194.2917F, 24.375F);
            this.xrLabel4.StyleName = "FieldCaption";
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.Text = "Reference ID";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 100F;
            this.xrLabel2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(155.8335F, 120.9583F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(135.4167F, 14.83334F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "********";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReferenceNo")});
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(139.6667F, 135.7917F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(239.0834F, 27.37498F);
            this.xrLabel1.StyleName = "FieldCaption";
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "Reference ID";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 100F;
            this.xrLabel8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(160.625F, 82.12501F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(409.3751F, 28F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Member\'s Registration Form";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 100F;
            this.xrLabel7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(156.625F, 54.20834F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(409.3751F, 22F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Act No.5 of 2001";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 100F;
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(234.75F, 11.20834F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(264.5834F, 22F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Republic of Sierra Leone";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 100F;
            this.xrLabel9.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(622.0832F, 10.00001F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(126.0417F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "FORM SS1A";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 100F;
            this.xrLabel10.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(733.0413F, 43.08333F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(22.25F, 60.83333F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "R\r\nT\r\nP";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Dpi = 100F;
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(9.666751F, 134.5417F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(124.0417F, 23F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Serial Number";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel61,
            this.xrLabel60,
            this.xrLine19,
            this.xrLabel59,
            this.xrLine18,
            this.xrLine17,
            this.xrLine16,
            this.xrLabel55,
            this.xrLine15,
            this.xrLabel56,
            this.xrLabel57,
            this.xrLabel58,
            this.xrLabel54,
            this.xrLine14,
            this.xrLabel48,
            this.xrLabel52,
            this.xrLabel53,
            this.xrShape8,
            this.xrLabel51,
            this.xrShape6,
            this.xrLabel47,
            this.xrLabel50,
            this.xrShape7,
            this.xrLine13,
            this.xrLabel46,
            this.xrLabel49,
            this.xrLine12,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLine11,
            this.xrLabel43,
            this.xrLine10,
            this.xrLabel42,
            this.xrLine9,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel41,
            this.xrLine8,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel34,
            this.xrShape5,
            this.xrLabel33,
            this.xrShape4,
            this.xrLabel32,
            this.xrLabel31,
            this.xrShape3,
            this.xrShape2,
            this.xrLabel30,
            this.xrLabel29,
            this.xrShape1,
            this.xrLine7,
            this.xrLine6,
            this.xrLine5,
            this.xrLine3,
            this.xrLine4,
            this.xrLabel26,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLine1,
            this.xrLine2,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel6});
            this.xrPanel2.Dpi = 100F;
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(11.33333F, 191.875F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(740.875F, 591.875F);
            this.xrPanel2.StylePriority.UseBorders = false;
            // 
            // xrLabel61
            // 
            this.xrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel61.Dpi = 100F;
            this.xrLabel61.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(173.375F, 570.6354F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(156.25F, 18.83331F);
            this.xrLabel61.StylePriority.UseBorders = false;
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.Text = "Telephone/fax/email";
            // 
            // xrLabel60
            // 
            this.xrLabel60.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel60.Dpi = 100F;
            this.xrLabel60.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(173.375F, 541.5104F);
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel60.StylePriority.UseBorders = false;
            this.xrLabel60.StylePriority.UseFont = false;
            this.xrLabel60.Text = "Address";
            // 
            // xrLine19
            // 
            this.xrLine19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine19.Dpi = 100F;
            this.xrLine19.LocationFloat = new DevExpress.Utils.PointFloat(172.5F, 561.8853F);
            this.xrLine19.Name = "xrLine19";
            this.xrLine19.SizeF = new System.Drawing.SizeF(566.7084F, 4.458313F);
            this.xrLine19.StylePriority.UseBorders = false;
            // 
            // xrLabel59
            // 
            this.xrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel59.Dpi = 100F;
            this.xrLabel59.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(474.7917F, 515.4688F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel59.StylePriority.UseBorders = false;
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.Text = "E.R. No";
            // 
            // xrLine18
            // 
            this.xrLine18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine18.Dpi = 100F;
            this.xrLine18.LocationFloat = new DevExpress.Utils.PointFloat(172.5F, 535.7603F);
            this.xrLine18.Name = "xrLine18";
            this.xrLine18.SizeF = new System.Drawing.SizeF(566.7084F, 4.458313F);
            this.xrLine18.StylePriority.UseBorders = false;
            // 
            // xrLine17
            // 
            this.xrLine17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine17.Dpi = 100F;
            this.xrLine17.LocationFloat = new DevExpress.Utils.PointFloat(2.895745F, 509.2499F);
            this.xrLine17.Name = "xrLine17";
            this.xrLine17.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine17.StylePriority.UseBorders = false;
            // 
            // xrLine16
            // 
            this.xrLine16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine16.Dpi = 100F;
            this.xrLine16.LocationFloat = new DevExpress.Utils.PointFloat(2.895745F, 456.1249F);
            this.xrLine16.Name = "xrLine16";
            this.xrLine16.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine16.StylePriority.UseBorders = false;
            // 
            // xrLabel55
            // 
            this.xrLabel55.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel55.Dpi = 100F;
            this.xrLabel55.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(474.7917F, 488.3854F);
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel55.StylePriority.UseBorders = false;
            this.xrLabel55.StylePriority.UseFont = false;
            this.xrLabel55.Text = "Maiden Name";
            // 
            // xrLine15
            // 
            this.xrLine15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine15.Dpi = 100F;
            this.xrLine15.LocationFloat = new DevExpress.Utils.PointFloat(170.5F, 483.677F);
            this.xrLine15.Name = "xrLine15";
            this.xrLine15.SizeF = new System.Drawing.SizeF(568.7084F, 4.458313F);
            this.xrLine15.StylePriority.UseBorders = false;
            // 
            // xrLabel56
            // 
            this.xrLabel56.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel56.Dpi = 100F;
            this.xrLabel56.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(171.6667F, 462.4272F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel56.StylePriority.UseBorders = false;
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.Text = "Surname";
            // 
            // xrLabel57
            // 
            this.xrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel57.Dpi = 100F;
            this.xrLabel57.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(170.8541F, 490.0729F);
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel57.StylePriority.UseBorders = false;
            this.xrLabel57.StylePriority.UseFont = false;
            this.xrLabel57.Text = "Middle Name";
            // 
            // xrLabel58
            // 
            this.xrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel58.Dpi = 100F;
            this.xrLabel58.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(474.7917F, 463.3854F);
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel58.StylePriority.UseBorders = false;
            this.xrLabel58.StylePriority.UseFont = false;
            this.xrLabel58.Text = "First Name";
            // 
            // xrLabel54
            // 
            this.xrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel54.Dpi = 100F;
            this.xrLabel54.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(473.75F, 434.1354F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel54.StylePriority.UseBorders = false;
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.Text = "Maiden Name";
            // 
            // xrLine14
            // 
            this.xrLine14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine14.Dpi = 100F;
            this.xrLine14.LocationFloat = new DevExpress.Utils.PointFloat(170.4583F, 429.4271F);
            this.xrLine14.Name = "xrLine14";
            this.xrLine14.SizeF = new System.Drawing.SizeF(568.7084F, 4.458313F);
            this.xrLine14.StylePriority.UseBorders = false;
            // 
            // xrLabel48
            // 
            this.xrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel48.Dpi = 100F;
            this.xrLabel48.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(171.625F, 408.1772F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel48.StylePriority.UseBorders = false;
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.Text = "Surname";
            // 
            // xrLabel52
            // 
            this.xrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel52.Dpi = 100F;
            this.xrLabel52.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(170.8125F, 435.8229F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel52.StylePriority.UseBorders = false;
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.Text = "Middle Name";
            // 
            // xrLabel53
            // 
            this.xrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel53.Dpi = 100F;
            this.xrLabel53.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(473.75F, 409.1354F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel53.StylePriority.UseBorders = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.Text = "First Name";
            // 
            // xrShape8
            // 
            this.xrShape8.BorderWidth = 0F;
            this.xrShape8.Dpi = 100F;
            this.xrShape8.LocationFloat = new DevExpress.Utils.PointFloat(410.4064F, 380.9167F);
            this.xrShape8.Name = "xrShape8";
            this.xrShape8.Shape = shapeRectangle1;
            this.xrShape8.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape8.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel51
            // 
            this.xrLabel51.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel51.BorderWidth = 0F;
            this.xrLabel51.Dpi = 100F;
            this.xrLabel51.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(360.8438F, 379.5833F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(48.95825F, 18.83328F);
            this.xrLabel51.StylePriority.UseBorders = false;
            this.xrLabel51.StylePriority.UseBorderWidth = false;
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.Text = "Other";
            // 
            // xrShape6
            // 
            this.xrShape6.BorderWidth = 0F;
            this.xrShape6.Dpi = 100F;
            this.xrShape6.LocationFloat = new DevExpress.Utils.PointFloat(320.9948F, 380.7708F);
            this.xrShape6.Name = "xrShape6";
            this.xrShape6.Shape = shapeRectangle2;
            this.xrShape6.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape6.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel47
            // 
            this.xrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel47.BorderWidth = 0F;
            this.xrLabel47.Dpi = 100F;
            this.xrLabel47.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(258.8907F, 379.4375F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(61.45831F, 18.83327F);
            this.xrLabel47.StylePriority.UseBorders = false;
            this.xrLabel47.StylePriority.UseBorderWidth = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.Text = "Monthly";
            // 
            // xrLabel50
            // 
            this.xrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel50.BorderWidth = 0F;
            this.xrLabel50.Dpi = 100F;
            this.xrLabel50.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(169.0469F, 379.8124F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(47.91666F, 18.83325F);
            this.xrLabel50.StylePriority.UseBorders = false;
            this.xrLabel50.StylePriority.UseBorderWidth = false;
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.Text = "Daily";
            // 
            // xrShape7
            // 
            this.xrShape7.BorderWidth = 0F;
            this.xrShape7.Dpi = 100F;
            this.xrShape7.LocationFloat = new DevExpress.Utils.PointFloat(219.6094F, 381.1458F);
            this.xrShape7.Name = "xrShape7";
            this.xrShape7.Shape = shapeRectangle3;
            this.xrShape7.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape7.StylePriority.UseBorderWidth = false;
            // 
            // xrLine13
            // 
            this.xrLine13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine13.Dpi = 100F;
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(168.3333F, 373.3854F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.SizeF = new System.Drawing.SizeF(568.7084F, 4.458313F);
            this.xrLine13.StylePriority.UseBorders = false;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel46.Dpi = 100F;
            this.xrLabel46.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(169.5F, 355.1354F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(64.91672F, 17.83331F);
            this.xrLabel46.StylePriority.UseBorders = false;
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.Text = "Income";
            // 
            // xrLabel49
            // 
            this.xrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel49.Dpi = 100F;
            this.xrLabel49.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(400.75F, 355.0938F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(157.6249F, 17.83319F);
            this.xrLabel49.StylePriority.UseBorders = false;
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.Text = "Occupation/Civil Status";
            // 
            // xrLine12
            // 
            this.xrLine12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine12.Dpi = 100F;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(2.895745F, 400.9166F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine12.StylePriority.UseBorders = false;
            // 
            // xrLabel44
            // 
            this.xrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel44.Dpi = 100F;
            this.xrLabel44.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(398.7083F, 321.9583F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(132.2916F, 22.99994F);
            this.xrLabel44.StylePriority.UseBorders = false;
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseForeColor = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "Date Employed";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel45.Dpi = 100F;
            this.xrLabel45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(576.8334F, 315.677F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(151.375F, 17.83334F);
            this.xrLabel45.StylePriority.UseBorders = false;
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.Text = "Day / Month / Year";
            // 
            // xrLine11
            // 
            this.xrLine11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine11.Dpi = 100F;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(2.895745F, 349.2916F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine11.StylePriority.UseBorders = false;
            // 
            // xrLabel43
            // 
            this.xrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel43.Dpi = 100F;
            this.xrLabel43.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(191.4167F, 315.5937F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(151.375F, 17.83334F);
            this.xrLabel43.StylePriority.UseBorders = false;
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.Text = "Day /  Month /  Year";
            // 
            // xrLine10
            // 
            this.xrLine10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine10.Dpi = 100F;
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(2.895745F, 307.7916F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine10.StylePriority.UseBorders = false;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel42.Dpi = 100F;
            this.xrLabel42.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(482.2292F, 288.1563F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(117.0001F, 17.83331F);
            this.xrLabel42.StylePriority.UseBorders = false;
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.Text = "Town";
            // 
            // xrLine9
            // 
            this.xrLine9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine9.Dpi = 100F;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(169.375F, 282.7605F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(568.7084F, 4.458313F);
            this.xrLine9.StylePriority.UseBorders = false;
            // 
            // xrLabel39
            // 
            this.xrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel39.Dpi = 100F;
            this.xrLabel39.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(170.5417F, 264.5104F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(124.2917F, 17.83331F);
            this.xrLabel39.StylePriority.UseBorders = false;
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.Text = "Province";
            // 
            // xrLabel40
            // 
            this.xrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel40.Dpi = 100F;
            this.xrLabel40.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(170.7291F, 288.1563F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(124.2917F, 17.83331F);
            this.xrLabel40.StylePriority.UseBorders = false;
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.Text = "Chiefdom";
            // 
            // xrLabel41
            // 
            this.xrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel41.Dpi = 100F;
            this.xrLabel41.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(480.9584F, 264.4688F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(118.0416F, 17.83331F);
            this.xrLabel41.StylePriority.UseBorders = false;
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.Text = "District";
            // 
            // xrLine8
            // 
            this.xrLine8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine8.Dpi = 100F;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(1.854092F, 255.5416F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine8.StylePriority.UseBorders = false;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel38.Dpi = 100F;
            this.xrLabel38.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(680.0626F, 228.1667F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(35.41663F, 22.99991F);
            this.xrLabel38.StylePriority.UseBorders = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseForeColor = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "F";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel37
            // 
            this.xrLabel37.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel37.Dpi = 100F;
            this.xrLabel37.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(641.2709F, 228.1667F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(35.41663F, 22.99991F);
            this.xrLabel37.StylePriority.UseBorders = false;
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseForeColor = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "M";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel36
            // 
            this.xrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel36.Dpi = 100F;
            this.xrLabel36.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(599.4792F, 228.1667F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(35.41663F, 22.99991F);
            this.xrLabel36.StylePriority.UseBorders = false;
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseForeColor = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "Sex";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel35.Dpi = 100F;
            this.xrLabel35.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(321.4792F, 228.0834F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(83.33328F, 22.99995F);
            this.xrLabel35.StylePriority.UseBorders = false;
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseForeColor = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "Telephone";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel34
            // 
            this.xrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel34.Dpi = 100F;
            this.xrLabel34.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(6.62501F, 227.0417F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(93.74994F, 22.99992F);
            this.xrLabel34.StylePriority.UseBorders = false;
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseForeColor = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "Nationality";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrShape5
            // 
            this.xrShape5.BorderWidth = 0F;
            this.xrShape5.Dpi = 100F;
            this.xrShape5.LocationFloat = new DevExpress.Utils.PointFloat(692.0521F, 194.4583F);
            this.xrShape5.Name = "xrShape5";
            this.xrShape5.Shape = shapeRectangle4;
            this.xrShape5.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape5.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel33.BorderWidth = 0F;
            this.xrLabel33.Dpi = 100F;
            this.xrLabel33.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(617.8646F, 194.125F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(70.83325F, 18.83327F);
            this.xrLabel33.StylePriority.UseBorders = false;
            this.xrLabel33.StylePriority.UseBorderWidth = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.Text = "Separated";
            // 
            // xrShape4
            // 
            this.xrShape4.BorderWidth = 0F;
            this.xrShape4.Dpi = 100F;
            this.xrShape4.LocationFloat = new DevExpress.Utils.PointFloat(564.4688F, 194.4583F);
            this.xrShape4.Name = "xrShape4";
            this.xrShape4.Shape = shapeRectangle5;
            this.xrShape4.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape4.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel32.BorderWidth = 0F;
            this.xrLabel32.Dpi = 100F;
            this.xrLabel32.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(493.9896F, 194.125F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(68.83325F, 18.83325F);
            this.xrLabel32.StylePriority.UseBorders = false;
            this.xrLabel32.StylePriority.UseBorderWidth = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.Text = "Widowed";
            // 
            // xrLabel31
            // 
            this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel31.BorderWidth = 0F;
            this.xrLabel31.Dpi = 100F;
            this.xrLabel31.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(370.5105F, 194.125F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(64.83325F, 18.83325F);
            this.xrLabel31.StylePriority.UseBorders = false;
            this.xrLabel31.StylePriority.UseBorderWidth = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.Text = "Divorced";
            // 
            // xrShape3
            // 
            this.xrShape3.BorderWidth = 0F;
            this.xrShape3.Dpi = 100F;
            this.xrShape3.LocationFloat = new DevExpress.Utils.PointFloat(437.9897F, 195.4583F);
            this.xrShape3.Name = "xrShape3";
            this.xrShape3.Shape = shapeRectangle6;
            this.xrShape3.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape3.StylePriority.UseBorderWidth = false;
            // 
            // xrShape2
            // 
            this.xrShape2.BorderWidth = 0F;
            this.xrShape2.Dpi = 100F;
            this.xrShape2.LocationFloat = new DevExpress.Utils.PointFloat(324.0938F, 194.4167F);
            this.xrShape2.Name = "xrShape2";
            this.xrShape2.Shape = shapeRectangle7;
            this.xrShape2.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel30.BorderWidth = 0F;
            this.xrLabel30.Dpi = 100F;
            this.xrLabel30.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(261.9896F, 193.0833F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(61.45831F, 18.83327F);
            this.xrLabel30.StylePriority.UseBorders = false;
            this.xrLabel30.StylePriority.UseBorderWidth = false;
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "Married";
            // 
            // xrLabel29
            // 
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.BorderWidth = 0F;
            this.xrLabel29.Dpi = 100F;
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(172.1458F, 193.4583F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(47.91666F, 18.83325F);
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseBorderWidth = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "Single";
            // 
            // xrShape1
            // 
            this.xrShape1.BorderWidth = 0F;
            this.xrShape1.Dpi = 100F;
            this.xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(222.7083F, 194.7917F);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.Shape = shapeRectangle8;
            this.xrShape1.SizeF = new System.Drawing.SizeF(25F, 18.75002F);
            this.xrShape1.StylePriority.UseBorderWidth = false;
            // 
            // xrLine7
            // 
            this.xrLine7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine7.Dpi = 100F;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(2.812441F, 218.0833F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine7.StylePriority.UseBorders = false;
            // 
            // xrLine6
            // 
            this.xrLine6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine6.Dpi = 100F;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(2.812448F, 184.75F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine6.StylePriority.UseBorders = false;
            // 
            // xrLine5
            // 
            this.xrLine5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine5.Dpi = 100F;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(2.770797F, 153.2916F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine5.StylePriority.UseBorders = false;
            // 
            // xrLine3
            // 
            this.xrLine3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine3.Dpi = 100F;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(170.1458F, 91.83337F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(568.7084F, 4.458313F);
            this.xrLine3.StylePriority.UseBorders = false;
            // 
            // xrLine4
            // 
            this.xrLine4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine4.Dpi = 100F;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(1.729137F, 121.8333F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine4.StylePriority.UseBorders = false;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.Dpi = 100F;
            this.xrLabel26.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(171.3125F, 70.58334F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "Surname";
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.Dpi = 100F;
            this.xrLabel27.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(171.4999F, 98.22916F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.Text = "Middle Name";
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.Dpi = 100F;
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(473.3958F, 72.58333F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.Text = "First Name";
            // 
            // xrLine1
            // 
            this.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine1.Dpi = 100F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(169.375F, 29.27081F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(568.7084F, 4.458313F);
            this.xrLine1.StylePriority.UseBorders = false;
            // 
            // xrLine2
            // 
            this.xrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine2.Dpi = 100F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(2F, 58.22915F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(736.7084F, 4.458313F);
            this.xrLine2.StylePriority.UseBorders = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Dpi = 100F;
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(6.25001F, 67.66666F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(132.2916F, 44.875F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.Text = "Previous or\r\nMaiden Name";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.Dpi = 100F;
            this.xrLabel13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(8.333344F, 17.4375F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(132.2917F, 23F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "Member\'s Name";
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.Dpi = 100F;
            this.xrLabel16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(6.3751F, 159.6666F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(132.2916F, 22.99997F);
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.Text = "Current Address";
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.Dpi = 100F;
            this.xrLabel15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(5.249995F, 129.3333F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(161.4583F, 23F);
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.Text = "Permanent Address";
            // 
            // xrLabel17
            // 
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.Dpi = 100F;
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(7.291677F, 191.8333F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(108.3333F, 22.99998F);
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Marital Status";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.Dpi = 100F;
            this.xrLabel18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(6.25001F, 272.2083F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(132.2916F, 22.99994F);
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Place of Birth";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.Dpi = 100F;
            this.xrLabel23.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(170.5417F, 8.020846F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "Surname";
            // 
            // xrLabel24
            // 
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.Dpi = 100F;
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(169.7291F, 35.66666F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.Text = "Middle Name";
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.Dpi = 100F;
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(472.6666F, 8.979157F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(132.2917F, 18.83331F);
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.Text = "First Name";
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.Dpi = 100F;
            this.xrLabel19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(7.291677F, 319.875F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(132.2916F, 22.99994F);
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Date of Birth";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.Dpi = 100F;
            this.xrLabel20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(8.333344F, 360.75F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(132.2916F, 22.99994F);
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Nature of Income";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.Dpi = 100F;
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(7.291669F, 421.7709F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(132.2916F, 23F);
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Name of Father";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.Dpi = 100F;
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(7.416759F, 474.6042F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(132.2916F, 23F);
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Name of Mother";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Dpi = 100F;
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(7.416767F, 522.3542F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(162.5F, 23F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Name of Establishment";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrShape9
            // 
            this.xrShape9.BorderWidth = 0F;
            this.xrShape9.Dpi = 100F;
            this.xrShape9.LocationFloat = new DevExpress.Utils.PointFloat(610.0415F, 33.66666F);
            this.xrShape9.Name = "xrShape9";
            this.xrShape9.Shape = shapeRectangle9;
            this.xrShape9.SizeF = new System.Drawing.SizeF(119.7917F, 76.0417F);
            this.xrShape9.StylePriority.UseBorderWidth = false;
            // 
            // xrShape10
            // 
            this.xrShape10.BorderWidth = 0F;
            this.xrShape10.Dpi = 100F;
            this.xrShape10.LocationFloat = new DevExpress.Utils.PointFloat(507.4167F, 135.5833F);
            this.xrShape10.Name = "xrShape10";
            this.xrShape10.Shape = shapeRectangle10;
            this.xrShape10.SizeF = new System.Drawing.SizeF(245.8333F, 22.75002F);
            this.xrShape10.StylePriority.UseBorderWidth = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 27F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 15.31258F;
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
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(NAPSOMIS_Webpoint.Models.ReferenceNoforPrint);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // XtraReportReferenceNos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Margins = new System.Drawing.Printing.Margins(21, 41, 27, 15);
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
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
