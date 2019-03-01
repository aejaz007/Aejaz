﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits Utils.XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.tc_Main = New DevExpress.XtraTab.XtraTabControl()
        Me.tp_SalesEntries = New DevExpress.XtraTab.XtraTabPage()
        Me.btn_Sales_ExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.container_Sales_Entries = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gc_Sales_RandomEntries = New DevExpress.XtraGrid.GridControl()
        Me.gv_Sales_RandomEntries = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_Sales_Entries = New DevExpress.XtraGrid.GridControl()
        Me.gv_Sales_Entries = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btn_Sales_Generate = New DevExpress.XtraEditors.SimpleButton()
        Me.table_Sales_Options = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Sales_From = New DevExpress.XtraEditors.LabelControl()
        Me.cb_Sales_ContinuousInvoice = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_Sales_From = New DevExpress.XtraEditors.DateEdit()
        Me.txt_Sales_To = New DevExpress.XtraEditors.DateEdit()
        Me.lbl_Sales_To = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Sales_RateDifference = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Sales_Rate = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_Sales_RoundingLimit = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_Sales_RoundingLimit = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Sales_StartInvoiceNo = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Sales_BeginningInvoiceNumber = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_Sales_InvoiceNumberFormat = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Sales_InvoiceNumberFormat = New DevExpress.XtraEditors.ButtonEdit()
        Me.lbl_Sales_Days = New DevExpress.XtraEditors.LabelControl()
        Me.lst_Sales_Days = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.lbl_Sales_EntriesMin = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Sales_EntriesMax = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Sales_EntriesMin = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_Sales_EntriesMax = New DevExpress.XtraEditors.SpinEdit()
        Me.dlg_SaveExcel = New System.Windows.Forms.SaveFileDialog()
        CType(Me.tc_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Main.SuspendLayout()
        Me.tp_SalesEntries.SuspendLayout()
        CType(Me.container_Sales_Entries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.container_Sales_Entries.SuspendLayout()
        CType(Me.gc_Sales_RandomEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Sales_RandomEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Sales_Entries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Sales_Entries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_Sales_Options.SuspendLayout()
        CType(Me.cb_Sales_ContinuousInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_From.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_To.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_Rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_RoundingLimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_BeginningInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_InvoiceNumberFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lst_Sales_Days, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_EntriesMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sales_EntriesMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_Main
        '
        Me.tc_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Main.Location = New System.Drawing.Point(0, 0)
        Me.tc_Main.Name = "tc_Main"
        Me.tc_Main.PaintStyleName = "Skin"
        Me.tc_Main.SelectedTabPage = Me.tp_SalesEntries
        Me.tc_Main.Size = New System.Drawing.Size(800, 450)
        Me.tc_Main.TabIndex = 0
        Me.tc_Main.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp_SalesEntries})
        '
        'tp_SalesEntries
        '
        Me.tp_SalesEntries.Controls.Add(Me.btn_Sales_ExportExcel)
        Me.tp_SalesEntries.Controls.Add(Me.container_Sales_Entries)
        Me.tp_SalesEntries.Controls.Add(Me.btn_Sales_Generate)
        Me.tp_SalesEntries.Controls.Add(Me.table_Sales_Options)
        Me.tp_SalesEntries.Name = "tp_SalesEntries"
        Me.tp_SalesEntries.Size = New System.Drawing.Size(794, 422)
        Me.tp_SalesEntries.Text = "Sales Entries"
        '
        'btn_Sales_ExportExcel
        '
        Me.btn_Sales_ExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Sales_ExportExcel.Location = New System.Drawing.Point(709, 392)
        Me.btn_Sales_ExportExcel.Name = "btn_Sales_ExportExcel"
        Me.btn_Sales_ExportExcel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sales_ExportExcel.TabIndex = 6
        Me.btn_Sales_ExportExcel.Text = "Export Excel"
        '
        'container_Sales_Entries
        '
        Me.container_Sales_Entries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.container_Sales_Entries.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.container_Sales_Entries.Horizontal = False
        Me.container_Sales_Entries.Location = New System.Drawing.Point(11, 185)
        Me.container_Sales_Entries.Name = "container_Sales_Entries"
        Me.container_Sales_Entries.Panel1.Controls.Add(Me.gc_Sales_RandomEntries)
        Me.container_Sales_Entries.Panel1.Text = "Panel1"
        Me.container_Sales_Entries.Panel2.Controls.Add(Me.gc_Sales_Entries)
        Me.container_Sales_Entries.Panel2.Text = "Panel2"
        Me.container_Sales_Entries.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.container_Sales_Entries.Size = New System.Drawing.Size(773, 201)
        Me.container_Sales_Entries.SplitterPosition = 101
        Me.container_Sales_Entries.TabIndex = 5
        '
        'gc_Sales_RandomEntries
        '
        Me.gc_Sales_RandomEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Sales_RandomEntries.Location = New System.Drawing.Point(0, 0)
        Me.gc_Sales_RandomEntries.MainView = Me.gv_Sales_RandomEntries
        Me.gc_Sales_RandomEntries.Name = "gc_Sales_RandomEntries"
        Me.gc_Sales_RandomEntries.Size = New System.Drawing.Size(773, 201)
        Me.gc_Sales_RandomEntries.TabIndex = 2
        Me.gc_Sales_RandomEntries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Sales_RandomEntries})
        '
        'gv_Sales_RandomEntries
        '
        Me.gv_Sales_RandomEntries.GridControl = Me.gc_Sales_RandomEntries
        Me.gv_Sales_RandomEntries.Name = "gv_Sales_RandomEntries"
        Me.gv_Sales_RandomEntries.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Sales_RandomEntries.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Sales_RandomEntries.OptionsNavigation.AutoFocusNewRow = True
        Me.gv_Sales_RandomEntries.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'gc_Sales_Entries
        '
        Me.gc_Sales_Entries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Sales_Entries.Location = New System.Drawing.Point(0, 0)
        Me.gc_Sales_Entries.MainView = Me.gv_Sales_Entries
        Me.gc_Sales_Entries.Name = "gc_Sales_Entries"
        Me.gc_Sales_Entries.Size = New System.Drawing.Size(0, 0)
        Me.gc_Sales_Entries.TabIndex = 4
        Me.gc_Sales_Entries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Sales_Entries})
        '
        'gv_Sales_Entries
        '
        Me.gv_Sales_Entries.GridControl = Me.gc_Sales_Entries
        Me.gv_Sales_Entries.Name = "gv_Sales_Entries"
        Me.gv_Sales_Entries.OptionsBehavior.Editable = False
        Me.gv_Sales_Entries.OptionsBehavior.ReadOnly = True
        '
        'btn_Sales_Generate
        '
        Me.btn_Sales_Generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Sales_Generate.Location = New System.Drawing.Point(628, 392)
        Me.btn_Sales_Generate.Name = "btn_Sales_Generate"
        Me.btn_Sales_Generate.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sales_Generate.TabIndex = 3
        Me.btn_Sales_Generate.Text = "Generate"
        '
        'table_Sales_Options
        '
        Me.table_Sales_Options.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_Sales_Options.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.table_Sales_Options.ColumnCount = 4
        Me.table_Sales_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.table_Sales_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_Sales_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.table_Sales_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_From, 0, 0)
        Me.table_Sales_Options.Controls.Add(Me.cb_Sales_ContinuousInvoice, 1, 4)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_From, 1, 0)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_To, 3, 0)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_To, 2, 0)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_RateDifference, 0, 1)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_Rate, 1, 1)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_RoundingLimit, 3, 1)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_RoundingLimit, 2, 1)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_StartInvoiceNo, 0, 5)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_BeginningInvoiceNumber, 1, 5)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_InvoiceNumberFormat, 2, 5)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_InvoiceNumberFormat, 3, 5)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_Days, 0, 3)
        Me.table_Sales_Options.Controls.Add(Me.lst_Sales_Days, 1, 3)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_EntriesMin, 0, 2)
        Me.table_Sales_Options.Controls.Add(Me.lbl_Sales_EntriesMax, 2, 2)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_EntriesMin, 1, 2)
        Me.table_Sales_Options.Controls.Add(Me.txt_Sales_EntriesMax, 3, 2)
        Me.table_Sales_Options.Location = New System.Drawing.Point(11, 9)
        Me.table_Sales_Options.Name = "table_Sales_Options"
        Me.table_Sales_Options.RowCount = 6
        Me.table_Sales_Options.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Sales_Options.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Sales_Options.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Sales_Options.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Sales_Options.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.table_Sales_Options.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Sales_Options.Size = New System.Drawing.Size(776, 170)
        Me.table_Sales_Options.TabIndex = 1
        '
        'lbl_Sales_From
        '
        Me.lbl_Sales_From.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_From.Location = New System.Drawing.Point(77, 3)
        Me.lbl_Sales_From.Name = "lbl_Sales_From"
        Me.lbl_Sales_From.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Sales_From.TabIndex = 0
        Me.lbl_Sales_From.Text = "Date From :"
        '
        'cb_Sales_ContinuousInvoice
        '
        Me.cb_Sales_ContinuousInvoice.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cb_Sales_ContinuousInvoice.Location = New System.Drawing.Point(140, 122)
        Me.cb_Sales_ContinuousInvoice.Name = "cb_Sales_ContinuousInvoice"
        Me.cb_Sales_ContinuousInvoice.Properties.Caption = "Continuous Invoice Number for All Entries"
        Me.cb_Sales_ContinuousInvoice.Size = New System.Drawing.Size(246, 19)
        Me.cb_Sales_ContinuousInvoice.TabIndex = 2
        '
        'txt_Sales_From
        '
        Me.txt_Sales_From.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_From.EditValue = Nothing
        Me.txt_Sales_From.Location = New System.Drawing.Point(140, 3)
        Me.txt_Sales_From.Name = "txt_Sales_From"
        Me.txt_Sales_From.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_From.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_From.Size = New System.Drawing.Size(246, 20)
        Me.txt_Sales_From.TabIndex = 1
        '
        'txt_Sales_To
        '
        Me.txt_Sales_To.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_To.EditValue = Nothing
        Me.txt_Sales_To.Location = New System.Drawing.Point(526, 3)
        Me.txt_Sales_To.Name = "txt_Sales_To"
        Me.txt_Sales_To.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_To.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_To.Size = New System.Drawing.Size(247, 20)
        Me.txt_Sales_To.TabIndex = 2
        '
        'lbl_Sales_To
        '
        Me.lbl_Sales_To.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_To.Location = New System.Drawing.Point(475, 3)
        Me.lbl_Sales_To.Name = "lbl_Sales_To"
        Me.lbl_Sales_To.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Sales_To.TabIndex = 3
        Me.lbl_Sales_To.Text = "Date To :"
        '
        'lbl_Sales_RateDifference
        '
        Me.lbl_Sales_RateDifference.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_RateDifference.Location = New System.Drawing.Point(51, 29)
        Me.lbl_Sales_RateDifference.Name = "lbl_Sales_RateDifference"
        Me.lbl_Sales_RateDifference.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Sales_RateDifference.TabIndex = 4
        Me.lbl_Sales_RateDifference.Text = "Rate Difference :"
        '
        'txt_Sales_Rate
        '
        Me.txt_Sales_Rate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_Rate.EditValue = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_Sales_Rate.Location = New System.Drawing.Point(140, 29)
        Me.txt_Sales_Rate.Name = "txt_Sales_Rate"
        Me.txt_Sales_Rate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_Rate.Properties.DisplayFormat.FormatString = "0%"
        Me.txt_Sales_Rate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txt_Sales_Rate.Properties.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Sales_Rate.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txt_Sales_Rate.Size = New System.Drawing.Size(246, 20)
        Me.txt_Sales_Rate.TabIndex = 5
        '
        'txt_Sales_RoundingLimit
        '
        Me.txt_Sales_RoundingLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_RoundingLimit.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txt_Sales_RoundingLimit.Location = New System.Drawing.Point(526, 29)
        Me.txt_Sales_RoundingLimit.Name = "txt_Sales_RoundingLimit"
        Me.txt_Sales_RoundingLimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_RoundingLimit.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txt_Sales_RoundingLimit.Size = New System.Drawing.Size(247, 20)
        Me.txt_Sales_RoundingLimit.TabIndex = 6
        '
        'lbl_Sales_RoundingLimit
        '
        Me.lbl_Sales_RoundingLimit.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_RoundingLimit.Location = New System.Drawing.Point(444, 29)
        Me.lbl_Sales_RoundingLimit.Name = "lbl_Sales_RoundingLimit"
        Me.lbl_Sales_RoundingLimit.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Sales_RoundingLimit.TabIndex = 7
        Me.lbl_Sales_RoundingLimit.Text = "Rounding Limit :"
        '
        'lbl_Sales_StartInvoiceNo
        '
        Me.lbl_Sales_StartInvoiceNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_StartInvoiceNo.Location = New System.Drawing.Point(3, 147)
        Me.lbl_Sales_StartInvoiceNo.Name = "lbl_Sales_StartInvoiceNo"
        Me.lbl_Sales_StartInvoiceNo.Size = New System.Drawing.Size(131, 13)
        Me.lbl_Sales_StartInvoiceNo.TabIndex = 8
        Me.lbl_Sales_StartInvoiceNo.Text = "Beginning Invoice Number :"
        '
        'txt_Sales_BeginningInvoiceNumber
        '
        Me.txt_Sales_BeginningInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_BeginningInvoiceNumber.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Sales_BeginningInvoiceNumber.Location = New System.Drawing.Point(140, 147)
        Me.txt_Sales_BeginningInvoiceNumber.Name = "txt_Sales_BeginningInvoiceNumber"
        Me.txt_Sales_BeginningInvoiceNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_BeginningInvoiceNumber.Size = New System.Drawing.Size(246, 20)
        Me.txt_Sales_BeginningInvoiceNumber.TabIndex = 9
        '
        'lbl_Sales_InvoiceNumberFormat
        '
        Me.lbl_Sales_InvoiceNumberFormat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_InvoiceNumberFormat.Location = New System.Drawing.Point(401, 147)
        Me.lbl_Sales_InvoiceNumberFormat.Name = "lbl_Sales_InvoiceNumberFormat"
        Me.lbl_Sales_InvoiceNumberFormat.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Sales_InvoiceNumberFormat.TabIndex = 10
        Me.lbl_Sales_InvoiceNumberFormat.Text = "Invoice Number Format :"
        '
        'txt_Sales_InvoiceNumberFormat
        '
        Me.txt_Sales_InvoiceNumberFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_InvoiceNumberFormat.Location = New System.Drawing.Point(526, 147)
        Me.txt_Sales_InvoiceNumberFormat.Name = "txt_Sales_InvoiceNumberFormat"
        Me.txt_Sales_InvoiceNumberFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_Sales_InvoiceNumberFormat.Size = New System.Drawing.Size(247, 20)
        Me.txt_Sales_InvoiceNumberFormat.TabIndex = 11
        '
        'lbl_Sales_Days
        '
        Me.lbl_Sales_Days.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_Days.Location = New System.Drawing.Point(103, 81)
        Me.lbl_Sales_Days.Name = "lbl_Sales_Days"
        Me.lbl_Sales_Days.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Sales_Days.TabIndex = 12
        Me.lbl_Sales_Days.Text = "Days :"
        '
        'lst_Sales_Days
        '
        Me.table_Sales_Options.SetColumnSpan(Me.lst_Sales_Days, 3)
        Me.lst_Sales_Days.Dock = System.Windows.Forms.DockStyle.Top
        Me.lst_Sales_Days.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(0, "Sunday"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(1, "Monday"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "Tuesday"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(3, "Wednesday"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(4, "Thursday"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(5, "Friday"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(6, "Saturday")})
        Me.lst_Sales_Days.Location = New System.Drawing.Point(140, 81)
        Me.lst_Sales_Days.MultiColumn = True
        Me.lst_Sales_Days.Name = "lst_Sales_Days"
        Me.lst_Sales_Days.Size = New System.Drawing.Size(633, 20)
        Me.lst_Sales_Days.TabIndex = 13
        '
        'lbl_Sales_EntriesMin
        '
        Me.lbl_Sales_EntriesMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_EntriesMin.Location = New System.Drawing.Point(10, 55)
        Me.lbl_Sales_EntriesMin.Name = "lbl_Sales_EntriesMin"
        Me.lbl_Sales_EntriesMin.Size = New System.Drawing.Size(124, 13)
        Me.lbl_Sales_EntriesMin.TabIndex = 14
        Me.lbl_Sales_EntriesMin.Text = "Minimum Entries Per Day :"
        '
        'lbl_Sales_EntriesMax
        '
        Me.lbl_Sales_EntriesMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Sales_EntriesMax.Location = New System.Drawing.Point(392, 55)
        Me.lbl_Sales_EntriesMax.Name = "lbl_Sales_EntriesMax"
        Me.lbl_Sales_EntriesMax.Size = New System.Drawing.Size(128, 13)
        Me.lbl_Sales_EntriesMax.TabIndex = 15
        Me.lbl_Sales_EntriesMax.Text = "Maximum Entries Per Day :"
        '
        'txt_Sales_EntriesMin
        '
        Me.txt_Sales_EntriesMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_EntriesMin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Sales_EntriesMin.Location = New System.Drawing.Point(140, 55)
        Me.txt_Sales_EntriesMin.Name = "txt_Sales_EntriesMin"
        Me.txt_Sales_EntriesMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_EntriesMin.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Sales_EntriesMin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Sales_EntriesMin.Size = New System.Drawing.Size(246, 20)
        Me.txt_Sales_EntriesMin.TabIndex = 16
        '
        'txt_Sales_EntriesMax
        '
        Me.txt_Sales_EntriesMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Sales_EntriesMax.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Sales_EntriesMax.Location = New System.Drawing.Point(526, 55)
        Me.txt_Sales_EntriesMax.Name = "txt_Sales_EntriesMax"
        Me.txt_Sales_EntriesMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sales_EntriesMax.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Sales_EntriesMax.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Sales_EntriesMax.Size = New System.Drawing.Size(247, 20)
        Me.txt_Sales_EntriesMax.TabIndex = 17
        '
        'dlg_SaveExcel
        '
        Me.dlg_SaveExcel.DefaultExt = "xlsx"
        Me.dlg_SaveExcel.Filter = "Excel 2007 Workbooks (*.xlsx)|*.xlsx"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tc_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Text = "Random Entries Generator"
        CType(Me.tc_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Main.ResumeLayout(False)
        Me.tp_SalesEntries.ResumeLayout(False)
        CType(Me.container_Sales_Entries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.container_Sales_Entries.ResumeLayout(False)
        CType(Me.gc_Sales_RandomEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Sales_RandomEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Sales_Entries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Sales_Entries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_Sales_Options.ResumeLayout(False)
        Me.table_Sales_Options.PerformLayout()
        CType(Me.cb_Sales_ContinuousInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_From.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_To.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_Rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_RoundingLimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_BeginningInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_InvoiceNumberFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lst_Sales_Days, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_EntriesMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sales_EntriesMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc_Main As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp_SalesEntries As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents table_Sales_Options As TableLayoutPanel
    Friend WithEvents lbl_Sales_From As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Sales_From As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_Sales_To As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbl_Sales_To As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_Sales_ContinuousInvoice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_Sales_RateDifference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Sales_Rate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_Sales_RoundingLimit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_Sales_RoundingLimit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Sales_StartInvoiceNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Sales_BeginningInvoiceNumber As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btn_Sales_Generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc_Sales_RandomEntries As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Sales_RandomEntries As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_Sales_InvoiceNumberFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Sales_InvoiceNumberFormat As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbl_Sales_Days As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lst_Sales_Days As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents container_Sales_Entries As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gc_Sales_Entries As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Sales_Entries As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_Sales_EntriesMin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Sales_EntriesMax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Sales_EntriesMin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_Sales_EntriesMax As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btn_Sales_ExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dlg_SaveExcel As SaveFileDialog
End Class
