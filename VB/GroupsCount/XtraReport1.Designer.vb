Imports Microsoft.VisualBasic
Imports System
Namespace GroupsCount
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.nwindDataSet1 = New GroupsCount.nwindDataSet()
			Me.ordersTableAdapter = New GroupsCount.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Height = 25
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ShipCountry", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.Height = 25
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4})
			Me.ReportFooter.Height = 42
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(17, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Freight", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(133, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCountry", "")})
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 16F)
			Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.xrLabel3.Location = New System.Drawing.Point(17, 0)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel3.Size = New System.Drawing.Size(525, 25)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseForeColor = False
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(236))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCountry", "")})
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.xrLabel4.Location = New System.Drawing.Point(17, 0)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel4.Size = New System.Drawing.Size(525, 25)
			Me.xrLabel4.StylePriority.UseBackColor = False
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.StylePriority.UseForeColor = False
			Me.xrLabel4.StylePriority.UseTextAlignment = False
			xrSummary1.FormatString = "Groups in Report: {0}"
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.DCount
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrLabel4.Summary = xrSummary1
			Me.xrLabel4.Text = "xrLabel4"
			Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupHeader1, Me.ReportFooter})
			Me.DataAdapter = Me.ordersTableAdapter
			Me.DataMember = "Orders"
			Me.DataSource = Me.nwindDataSet1
			Me.DrawGrid = False
			Me.Version = "8.3"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private nwindDataSet1 As nwindDataSet
		Private ordersTableAdapter As GroupsCount.nwindDataSetTableAdapters.OrdersTableAdapter
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
