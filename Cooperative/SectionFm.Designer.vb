<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sectionFm
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.sectionGb = New System.Windows.Forms.GroupBox()
        Me.searchBt = New System.Windows.Forms.Button()
        Me.downloadGb = New System.Windows.Forms.GroupBox()
        Me.deletedbBt = New System.Windows.Forms.Button()
        Me.clearBt = New System.Windows.Forms.Button()
        Me.sheetLb = New System.Windows.Forms.Label()
        Me.importBt = New System.Windows.Forms.Button()
        Me.sheetCb = New System.Windows.Forms.ComboBox()
        Me.filenameLb = New System.Windows.Forms.Label()
        Me.filenameTb = New System.Windows.Forms.TextBox()
        Me.downloaddataBt = New System.Windows.Forms.Button()
        Me.sectionnameTb = New System.Windows.Forms.TextBox()
        Me.sectionnoTb = New System.Windows.Forms.TextBox()
        Me.sectionnameLb = New System.Windows.Forms.Label()
        Me.sectionnoLb = New System.Windows.Forms.Label()
        Me.showdataGb = New System.Windows.Forms.GroupBox()
        Me.refreshBt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cancelBt = New System.Windows.Forms.Button()
        Me.deleteBt = New System.Windows.Forms.Button()
        Me.updateBt = New System.Windows.Forms.Button()
        Me.addBt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SectionNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Search_TB = New System.Windows.Forms.TextBox()
        Me.sectionGb.SuspendLayout()
        Me.downloadGb.SuspendLayout()
        Me.showdataGb.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SectionClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sectionGb
        '
        Me.sectionGb.Controls.Add(Me.searchBt)
        Me.sectionGb.Controls.Add(Me.downloadGb)
        Me.sectionGb.Controls.Add(Me.sectionnameTb)
        Me.sectionGb.Controls.Add(Me.sectionnoTb)
        Me.sectionGb.Controls.Add(Me.sectionnameLb)
        Me.sectionGb.Controls.Add(Me.sectionnoLb)
        Me.sectionGb.Location = New System.Drawing.Point(16, 5)
        Me.sectionGb.Name = "sectionGb"
        Me.sectionGb.Size = New System.Drawing.Size(748, 209)
        Me.sectionGb.TabIndex = 2
        Me.sectionGb.TabStop = False
        Me.sectionGb.Text = "Section\ Department"
        '
        'searchBt
        '
        Me.searchBt.Location = New System.Drawing.Point(279, 39)
        Me.searchBt.Name = "searchBt"
        Me.searchBt.Size = New System.Drawing.Size(63, 20)
        Me.searchBt.TabIndex = 17
        Me.searchBt.Text = "Search"
        Me.searchBt.UseVisualStyleBackColor = True
        '
        'downloadGb
        '
        Me.downloadGb.Controls.Add(Me.deletedbBt)
        Me.downloadGb.Controls.Add(Me.clearBt)
        Me.downloadGb.Controls.Add(Me.sheetLb)
        Me.downloadGb.Controls.Add(Me.importBt)
        Me.downloadGb.Controls.Add(Me.sheetCb)
        Me.downloadGb.Controls.Add(Me.filenameLb)
        Me.downloadGb.Controls.Add(Me.filenameTb)
        Me.downloadGb.Controls.Add(Me.downloaddataBt)
        Me.downloadGb.Location = New System.Drawing.Point(419, 10)
        Me.downloadGb.Name = "downloadGb"
        Me.downloadGb.Size = New System.Drawing.Size(315, 183)
        Me.downloadGb.TabIndex = 12
        Me.downloadGb.TabStop = False
        Me.downloadGb.Text = "Download (ดึงข้อมูล)"
        '
        'deletedbBt
        '
        Me.deletedbBt.BackColor = System.Drawing.Color.DarkRed
        Me.deletedbBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deletedbBt.Location = New System.Drawing.Point(212, 28)
        Me.deletedbBt.Name = "deletedbBt"
        Me.deletedbBt.Size = New System.Drawing.Size(94, 36)
        Me.deletedbBt.TabIndex = 21
        Me.deletedbBt.Text = "Delete all data in Database"
        Me.deletedbBt.UseVisualStyleBackColor = False
        '
        'clearBt
        '
        Me.clearBt.Location = New System.Drawing.Point(112, 28)
        Me.clearBt.Name = "clearBt"
        Me.clearBt.Size = New System.Drawing.Size(94, 36)
        Me.clearBt.TabIndex = 20
        Me.clearBt.Text = "Clear Data"
        Me.clearBt.UseVisualStyleBackColor = True
        '
        'sheetLb
        '
        Me.sheetLb.AutoSize = True
        Me.sheetLb.Location = New System.Drawing.Point(6, 134)
        Me.sheetLb.Name = "sheetLb"
        Me.sheetLb.Size = New System.Drawing.Size(119, 13)
        Me.sheetLb.TabIndex = 18
        Me.sheetLb.Text = "Select sheet (เลือกชีท) :"
        '
        'importBt
        '
        Me.importBt.Location = New System.Drawing.Point(183, 150)
        Me.importBt.Name = "importBt"
        Me.importBt.Size = New System.Drawing.Size(63, 21)
        Me.importBt.TabIndex = 19
        Me.importBt.Text = "Import"
        Me.importBt.UseVisualStyleBackColor = True
        '
        'sheetCb
        '
        Me.sheetCb.FormattingEnabled = True
        Me.sheetCb.Location = New System.Drawing.Point(9, 150)
        Me.sheetCb.Name = "sheetCb"
        Me.sheetCb.Size = New System.Drawing.Size(168, 21)
        Me.sheetCb.TabIndex = 18
        '
        'filenameLb
        '
        Me.filenameLb.AutoSize = True
        Me.filenameLb.Location = New System.Drawing.Point(6, 92)
        Me.filenameLb.Name = "filenameLb"
        Me.filenameLb.Size = New System.Drawing.Size(97, 13)
        Me.filenameLb.TabIndex = 17
        Me.filenameLb.Text = "Filename (ชื่อไฟล์) :"
        '
        'filenameTb
        '
        Me.filenameTb.Enabled = False
        Me.filenameTb.Location = New System.Drawing.Point(9, 108)
        Me.filenameTb.Name = "filenameTb"
        Me.filenameTb.Size = New System.Drawing.Size(300, 20)
        Me.filenameTb.TabIndex = 17
        '
        'downloaddataBt
        '
        Me.downloaddataBt.Location = New System.Drawing.Point(12, 28)
        Me.downloaddataBt.Name = "downloaddataBt"
        Me.downloaddataBt.Size = New System.Drawing.Size(94, 36)
        Me.downloaddataBt.TabIndex = 0
        Me.downloaddataBt.Text = "Download Data"
        Me.downloaddataBt.UseVisualStyleBackColor = True
        '
        'sectionnameTb
        '
        Me.sectionnameTb.Location = New System.Drawing.Point(147, 89)
        Me.sectionnameTb.Name = "sectionnameTb"
        Me.sectionnameTb.Size = New System.Drawing.Size(195, 20)
        Me.sectionnameTb.TabIndex = 11
        '
        'sectionnoTb
        '
        Me.sectionnoTb.Location = New System.Drawing.Point(147, 40)
        Me.sectionnoTb.Name = "sectionnoTb"
        Me.sectionnoTb.Size = New System.Drawing.Size(110, 20)
        Me.sectionnoTb.TabIndex = 10
        '
        'sectionnameLb
        '
        Me.sectionnameLb.AutoSize = True
        Me.sectionnameLb.Location = New System.Drawing.Point(6, 96)
        Me.sectionnameLb.Name = "sectionnameLb"
        Me.sectionnameLb.Size = New System.Drawing.Size(132, 13)
        Me.sectionnameLb.TabIndex = 4
        Me.sectionnameLb.Text = "Section Name (ชื่อแผนก) :"
        '
        'sectionnoLb
        '
        Me.sectionnoLb.AutoSize = True
        Me.sectionnoLb.Location = New System.Drawing.Point(6, 47)
        Me.sectionnoLb.Name = "sectionnoLb"
        Me.sectionnoLb.Size = New System.Drawing.Size(127, 13)
        Me.sectionnoLb.TabIndex = 3
        Me.sectionnoLb.Text = "Section No. (รหัสแผนก) :"
        '
        'showdataGb
        '
        Me.showdataGb.Controls.Add(Me.Label8)
        Me.showdataGb.Controls.Add(Me.refreshBt)
        Me.showdataGb.Controls.Add(Me.Search_TB)
        Me.showdataGb.Controls.Add(Me.DataGridView1)
        Me.showdataGb.Location = New System.Drawing.Point(441, 220)
        Me.showdataGb.Name = "showdataGb"
        Me.showdataGb.Size = New System.Drawing.Size(323, 275)
        Me.showdataGb.TabIndex = 4
        Me.showdataGb.TabStop = False
        Me.showdataGb.Text = "Show Data (แสดงข้อมูล)"
        '
        'refreshBt
        '
        Me.refreshBt.Location = New System.Drawing.Point(236, 20)
        Me.refreshBt.Name = "refreshBt"
        Me.refreshBt.Size = New System.Drawing.Size(81, 24)
        Me.refreshBt.TabIndex = 19
        Me.refreshBt.Text = "Refresh"
        Me.refreshBt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SectionNoDataGridViewTextBoxColumn, Me.SectionNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SectionClassBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(311, 213)
        Me.DataGridView1.TabIndex = 3
        '
        'cancelBt
        '
        Me.cancelBt.Location = New System.Drawing.Point(296, 19)
        Me.cancelBt.Name = "cancelBt"
        Me.cancelBt.Size = New System.Drawing.Size(79, 30)
        Me.cancelBt.TabIndex = 12
        Me.cancelBt.Text = "Cancel"
        Me.cancelBt.UseVisualStyleBackColor = True
        '
        'deleteBt
        '
        Me.deleteBt.Location = New System.Drawing.Point(211, 19)
        Me.deleteBt.Name = "deleteBt"
        Me.deleteBt.Size = New System.Drawing.Size(79, 30)
        Me.deleteBt.TabIndex = 11
        Me.deleteBt.Text = "Delete"
        Me.deleteBt.UseVisualStyleBackColor = True
        '
        'updateBt
        '
        Me.updateBt.Location = New System.Drawing.Point(126, 19)
        Me.updateBt.Name = "updateBt"
        Me.updateBt.Size = New System.Drawing.Size(79, 30)
        Me.updateBt.TabIndex = 10
        Me.updateBt.Text = "Update"
        Me.updateBt.UseVisualStyleBackColor = True
        '
        'addBt
        '
        Me.addBt.Location = New System.Drawing.Point(41, 19)
        Me.addBt.Name = "addBt"
        Me.addBt.Size = New System.Drawing.Size(79, 30)
        Me.addBt.TabIndex = 9
        Me.addBt.Text = "Add"
        Me.addBt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cancelBt)
        Me.GroupBox1.Controls.Add(Me.deleteBt)
        Me.GroupBox1.Controls.Add(Me.updateBt)
        Me.GroupBox1.Controls.Add(Me.addBt)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 64)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'SectionNoDataGridViewTextBoxColumn
        '
        Me.SectionNoDataGridViewTextBoxColumn.DataPropertyName = "Section_No"
        Me.SectionNoDataGridViewTextBoxColumn.HeaderText = "Section_No"
        Me.SectionNoDataGridViewTextBoxColumn.Name = "SectionNoDataGridViewTextBoxColumn"
        Me.SectionNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionNameDataGridViewTextBoxColumn
        '
        Me.SectionNameDataGridViewTextBoxColumn.DataPropertyName = "Section_Name"
        Me.SectionNameDataGridViewTextBoxColumn.HeaderText = "Section_Name"
        Me.SectionNameDataGridViewTextBoxColumn.Name = "SectionNameDataGridViewTextBoxColumn"
        Me.SectionNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionClassBindingSource
        '
        Me.SectionClassBindingSource.DataSource = GetType(Cooperative.SectionClass)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(10, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Search :"
        '
        'Search_TB
        '
        Me.Search_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Search_TB.Location = New System.Drawing.Point(60, 22)
        Me.Search_TB.Name = "Search_TB"
        Me.Search_TB.Size = New System.Drawing.Size(170, 22)
        Me.Search_TB.TabIndex = 37
        '
        'sectionFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 505)
        Me.Controls.Add(Me.sectionGb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.showdataGb)
        Me.Name = "sectionFm"
        Me.Text = "Section \ Department"
        Me.sectionGb.ResumeLayout(False)
        Me.sectionGb.PerformLayout()
        Me.downloadGb.ResumeLayout(False)
        Me.downloadGb.PerformLayout()
        Me.showdataGb.ResumeLayout(False)
        Me.showdataGb.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SectionClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sectionGb As System.Windows.Forms.GroupBox
    Friend WithEvents sectionnameLb As System.Windows.Forms.Label
    Friend WithEvents sectionnoLb As System.Windows.Forms.Label
    Friend WithEvents sectionnameTb As System.Windows.Forms.TextBox
    Friend WithEvents sectionnoTb As System.Windows.Forms.TextBox
    Friend WithEvents downloadGb As GroupBox
    Friend WithEvents clearBt As Button
    Friend WithEvents sheetLb As Label
    Friend WithEvents importBt As Button
    Friend WithEvents sheetCb As ComboBox
    Friend WithEvents filenameLb As Label
    Friend WithEvents filenameTb As TextBox
    Friend WithEvents downloaddataBt As Button
    Friend WithEvents showdataGb As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchBt As Button
    Friend WithEvents SectionNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionClassBindingSource As BindingSource
    Friend WithEvents cancelBt As Button
    Friend WithEvents deleteBt As Button
    Friend WithEvents updateBt As Button
    Friend WithEvents addBt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents refreshBt As Button
    Friend WithEvents deletedbBt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Search_TB As TextBox
End Class
