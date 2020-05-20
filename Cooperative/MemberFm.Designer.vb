<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class member_regisFm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.memberGb = New System.Windows.Forms.GroupBox()
        Me.showsectionBt = New System.Windows.Forms.Button()
        Me.searchBt = New System.Windows.Forms.Button()
        Me.commentTb = New System.Windows.Forms.TextBox()
        Me.statusCb = New System.Windows.Forms.ComboBox()
        Me.sectionCb = New System.Windows.Forms.ComboBox()
        Me.sexCb = New System.Windows.Forms.ComboBox()
        Me.surnameTb = New System.Windows.Forms.TextBox()
        Me.nameTb = New System.Windows.Forms.TextBox()
        Me.employeeTb = New System.Windows.Forms.TextBox()
        Me.commentLb = New System.Windows.Forms.Label()
        Me.statusLb = New System.Windows.Forms.Label()
        Me.secctionLb = New System.Windows.Forms.Label()
        Me.sexLb = New System.Windows.Forms.Label()
        Me.surnameLb = New System.Windows.Forms.Label()
        Me.nameLb = New System.Windows.Forms.Label()
        Me.employeeLb = New System.Windows.Forms.Label()
        Me.downloadGb = New System.Windows.Forms.GroupBox()
        Me.deletedbBt = New System.Windows.Forms.Button()
        Me.clearBt = New System.Windows.Forms.Button()
        Me.sheetLb = New System.Windows.Forms.Label()
        Me.importBt = New System.Windows.Forms.Button()
        Me.sheetCb = New System.Windows.Forms.ComboBox()
        Me.filenameLb = New System.Windows.Forms.Label()
        Me.filenameTb = New System.Windows.Forms.TextBox()
        Me.downloaddataBt = New System.Windows.Forms.Button()
        Me.buttonGb = New System.Windows.Forms.GroupBox()
        Me.cancelBt = New System.Windows.Forms.Button()
        Me.deleteBt = New System.Windows.Forms.Button()
        Me.updateBt = New System.Windows.Forms.Button()
        Me.addBt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.showdataGb = New System.Windows.Forms.GroupBox()
        Me.refreshBt = New System.Windows.Forms.Button()
        Me.MemberClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Search_TB = New System.Windows.Forms.TextBox()
        Me.memberGb.SuspendLayout()
        Me.downloadGb.SuspendLayout()
        Me.buttonGb.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.showdataGb.SuspendLayout()
        CType(Me.MemberClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'memberGb
        '
        Me.memberGb.Controls.Add(Me.showsectionBt)
        Me.memberGb.Controls.Add(Me.searchBt)
        Me.memberGb.Controls.Add(Me.commentTb)
        Me.memberGb.Controls.Add(Me.statusCb)
        Me.memberGb.Controls.Add(Me.sectionCb)
        Me.memberGb.Controls.Add(Me.sexCb)
        Me.memberGb.Controls.Add(Me.surnameTb)
        Me.memberGb.Controls.Add(Me.nameTb)
        Me.memberGb.Controls.Add(Me.employeeTb)
        Me.memberGb.Controls.Add(Me.commentLb)
        Me.memberGb.Controls.Add(Me.statusLb)
        Me.memberGb.Controls.Add(Me.secctionLb)
        Me.memberGb.Controls.Add(Me.sexLb)
        Me.memberGb.Controls.Add(Me.surnameLb)
        Me.memberGb.Controls.Add(Me.nameLb)
        Me.memberGb.Controls.Add(Me.employeeLb)
        Me.memberGb.Controls.Add(Me.downloadGb)
        Me.memberGb.Location = New System.Drawing.Point(20, 12)
        Me.memberGb.Name = "memberGb"
        Me.memberGb.Size = New System.Drawing.Size(750, 368)
        Me.memberGb.TabIndex = 0
        Me.memberGb.TabStop = False
        Me.memberGb.Text = "Member (สมาชิก)"
        '
        'showsectionBt
        '
        Me.showsectionBt.Location = New System.Drawing.Point(357, 208)
        Me.showsectionBt.Name = "showsectionBt"
        Me.showsectionBt.Size = New System.Drawing.Size(81, 24)
        Me.showsectionBt.TabIndex = 17
        Me.showsectionBt.Text = "Show Section "
        Me.showsectionBt.UseVisualStyleBackColor = True
        '
        'searchBt
        '
        Me.searchBt.Location = New System.Drawing.Point(313, 59)
        Me.searchBt.Name = "searchBt"
        Me.searchBt.Size = New System.Drawing.Size(63, 20)
        Me.searchBt.TabIndex = 16
        Me.searchBt.Text = "Search"
        Me.searchBt.UseVisualStyleBackColor = True
        '
        'commentTb
        '
        Me.commentTb.Location = New System.Drawing.Point(197, 300)
        Me.commentTb.Name = "commentTb"
        Me.commentTb.Size = New System.Drawing.Size(433, 20)
        Me.commentTb.TabIndex = 15
        '
        'statusCb
        '
        Me.statusCb.FormattingEnabled = True
        Me.statusCb.Items.AddRange(New Object() {"Active (เป็นสมาชิกอยู่)", "Deactive(ไม่ได้เป็นสมาชิกแล้ว)"})
        Me.statusCb.Location = New System.Drawing.Point(197, 257)
        Me.statusCb.Name = "statusCb"
        Me.statusCb.Size = New System.Drawing.Size(154, 21)
        Me.statusCb.TabIndex = 14
        '
        'sectionCb
        '
        Me.sectionCb.FormattingEnabled = True
        Me.sectionCb.Location = New System.Drawing.Point(197, 211)
        Me.sectionCb.Name = "sectionCb"
        Me.sectionCb.Size = New System.Drawing.Size(154, 21)
        Me.sectionCb.TabIndex = 13
        '
        'sexCb
        '
        Me.sexCb.FormattingEnabled = True
        Me.sexCb.Items.AddRange(New Object() {"Men (ผู้ชาย)", "Woman (ผู้หญิง)"})
        Me.sexCb.Location = New System.Drawing.Point(197, 169)
        Me.sexCb.Name = "sexCb"
        Me.sexCb.Size = New System.Drawing.Size(95, 21)
        Me.sexCb.TabIndex = 12
        '
        'surnameTb
        '
        Me.surnameTb.Location = New System.Drawing.Point(197, 133)
        Me.surnameTb.Name = "surnameTb"
        Me.surnameTb.Size = New System.Drawing.Size(154, 20)
        Me.surnameTb.TabIndex = 11
        '
        'nameTb
        '
        Me.nameTb.Location = New System.Drawing.Point(197, 97)
        Me.nameTb.Name = "nameTb"
        Me.nameTb.Size = New System.Drawing.Size(154, 20)
        Me.nameTb.TabIndex = 10
        '
        'employeeTb
        '
        Me.employeeTb.Location = New System.Drawing.Point(197, 59)
        Me.employeeTb.Name = "employeeTb"
        Me.employeeTb.Size = New System.Drawing.Size(110, 20)
        Me.employeeTb.TabIndex = 9
        '
        'commentLb
        '
        Me.commentLb.AutoSize = True
        Me.commentLb.Location = New System.Drawing.Point(29, 307)
        Me.commentLb.Name = "commentLb"
        Me.commentLb.Size = New System.Drawing.Size(86, 13)
        Me.commentLb.TabIndex = 8
        Me.commentLb.Text = "Comment (อื่นๆ) :"
        '
        'statusLb
        '
        Me.statusLb.AutoSize = True
        Me.statusLb.Location = New System.Drawing.Point(29, 265)
        Me.statusLb.Name = "statusLb"
        Me.statusLb.Size = New System.Drawing.Size(83, 13)
        Me.statusLb.TabIndex = 7
        Me.statusLb.Text = "Status (สถานะ) :"
        '
        'secctionLb
        '
        Me.secctionLb.AutoSize = True
        Me.secctionLb.Location = New System.Drawing.Point(29, 219)
        Me.secctionLb.Name = "secctionLb"
        Me.secctionLb.Size = New System.Drawing.Size(88, 13)
        Me.secctionLb.TabIndex = 6
        Me.secctionLb.Text = "Section (แผนก) :"
        '
        'sexLb
        '
        Me.sexLb.AutoSize = True
        Me.sexLb.Location = New System.Drawing.Point(29, 177)
        Me.sexLb.Name = "sexLb"
        Me.sexLb.Size = New System.Drawing.Size(61, 13)
        Me.sexLb.TabIndex = 5
        Me.sexLb.Text = "Sex (เพศ) :"
        '
        'surnameLb
        '
        Me.surnameLb.AutoSize = True
        Me.surnameLb.Location = New System.Drawing.Point(29, 136)
        Me.surnameLb.Name = "surnameLb"
        Me.surnameLb.Size = New System.Drawing.Size(103, 13)
        Me.surnameLb.TabIndex = 4
        Me.surnameLb.Text = "Surname (นามสกุล) :"
        '
        'nameLb
        '
        Me.nameLb.AutoSize = True
        Me.nameLb.Location = New System.Drawing.Point(29, 97)
        Me.nameLb.Name = "nameLb"
        Me.nameLb.Size = New System.Drawing.Size(63, 13)
        Me.nameLb.TabIndex = 3
        Me.nameLb.Text = "Name (ชื่อ) :"
        '
        'employeeLb
        '
        Me.employeeLb.AutoSize = True
        Me.employeeLb.Location = New System.Drawing.Point(29, 59)
        Me.employeeLb.Name = "employeeLb"
        Me.employeeLb.Size = New System.Drawing.Size(148, 13)
        Me.employeeLb.TabIndex = 2
        Me.employeeLb.Text = "Employee No. (รหัสพนักงาน) :"
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
        Me.downloadGb.Location = New System.Drawing.Point(429, 19)
        Me.downloadGb.Name = "downloadGb"
        Me.downloadGb.Size = New System.Drawing.Size(315, 183)
        Me.downloadGb.TabIndex = 1
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
        Me.deletedbBt.TabIndex = 4
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
        'buttonGb
        '
        Me.buttonGb.Controls.Add(Me.cancelBt)
        Me.buttonGb.Controls.Add(Me.deleteBt)
        Me.buttonGb.Controls.Add(Me.updateBt)
        Me.buttonGb.Controls.Add(Me.addBt)
        Me.buttonGb.Location = New System.Drawing.Point(20, 386)
        Me.buttonGb.Name = "buttonGb"
        Me.buttonGb.Size = New System.Drawing.Size(750, 73)
        Me.buttonGb.TabIndex = 1
        Me.buttonGb.TabStop = False
        '
        'cancelBt
        '
        Me.cancelBt.Location = New System.Drawing.Point(298, 25)
        Me.cancelBt.Name = "cancelBt"
        Me.cancelBt.Size = New System.Drawing.Size(79, 30)
        Me.cancelBt.TabIndex = 3
        Me.cancelBt.Text = "Cancel"
        Me.cancelBt.UseVisualStyleBackColor = True
        '
        'deleteBt
        '
        Me.deleteBt.Location = New System.Drawing.Point(213, 25)
        Me.deleteBt.Name = "deleteBt"
        Me.deleteBt.Size = New System.Drawing.Size(79, 30)
        Me.deleteBt.TabIndex = 2
        Me.deleteBt.Text = "Delete"
        Me.deleteBt.UseVisualStyleBackColor = True
        '
        'updateBt
        '
        Me.updateBt.Location = New System.Drawing.Point(128, 25)
        Me.updateBt.Name = "updateBt"
        Me.updateBt.Size = New System.Drawing.Size(79, 30)
        Me.updateBt.TabIndex = 1
        Me.updateBt.Text = "Update"
        Me.updateBt.UseVisualStyleBackColor = True
        '
        'addBt
        '
        Me.addBt.Location = New System.Drawing.Point(43, 25)
        Me.addBt.Name = "addBt"
        Me.addBt.Size = New System.Drawing.Size(79, 30)
        Me.addBt.TabIndex = 0
        Me.addBt.Text = "Add"
        Me.addBt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 504)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(720, 266)
        Me.DataGridView1.TabIndex = 2
        '
        'showdataGb
        '
        Me.showdataGb.Controls.Add(Me.Label8)
        Me.showdataGb.Controls.Add(Me.Search_TB)
        Me.showdataGb.Controls.Add(Me.refreshBt)
        Me.showdataGb.Location = New System.Drawing.Point(20, 465)
        Me.showdataGb.Name = "showdataGb"
        Me.showdataGb.Size = New System.Drawing.Size(750, 322)
        Me.showdataGb.TabIndex = 3
        Me.showdataGb.TabStop = False
        Me.showdataGb.Text = "Show Data (แสดงข้อมูล)"
        '
        'refreshBt
        '
        Me.refreshBt.Location = New System.Drawing.Point(658, 13)
        Me.refreshBt.Name = "refreshBt"
        Me.refreshBt.Size = New System.Drawing.Size(81, 24)
        Me.refreshBt.TabIndex = 18
        Me.refreshBt.Text = "Refresh"
        Me.refreshBt.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(395, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Search :"
        '
        'Search_TB
        '
        Me.Search_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Search_TB.Location = New System.Drawing.Point(444, 14)
        Me.Search_TB.Name = "Search_TB"
        Me.Search_TB.Size = New System.Drawing.Size(209, 22)
        Me.Search_TB.TabIndex = 35
        '
        'member_regisFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 811)
        Me.Controls.Add(Me.buttonGb)
        Me.Controls.Add(Me.memberGb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.showdataGb)
        Me.Name = "member_regisFm"
        Me.Text = "Member Registration (ระบบสมาชิก)"
        Me.memberGb.ResumeLayout(False)
        Me.memberGb.PerformLayout()
        Me.downloadGb.ResumeLayout(False)
        Me.downloadGb.PerformLayout()
        Me.buttonGb.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.showdataGb.ResumeLayout(False)
        Me.showdataGb.PerformLayout()
        CType(Me.MemberClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents memberGb As System.Windows.Forms.GroupBox
    Friend WithEvents buttonGb As System.Windows.Forms.GroupBox
    Friend WithEvents cancelBt As System.Windows.Forms.Button
    Friend WithEvents deleteBt As System.Windows.Forms.Button
    Friend WithEvents updateBt As System.Windows.Forms.Button
    Friend WithEvents addBt As System.Windows.Forms.Button
    Friend WithEvents downloadGb As System.Windows.Forms.GroupBox
    Friend WithEvents downloaddataBt As System.Windows.Forms.Button
    Friend WithEvents surnameLb As System.Windows.Forms.Label
    Friend WithEvents nameLb As System.Windows.Forms.Label
    Friend WithEvents employeeLb As System.Windows.Forms.Label
    Friend WithEvents commentLb As System.Windows.Forms.Label
    Friend WithEvents statusLb As System.Windows.Forms.Label
    Friend WithEvents secctionLb As System.Windows.Forms.Label
    Friend WithEvents sexLb As System.Windows.Forms.Label
    Friend WithEvents commentTb As System.Windows.Forms.TextBox
    Friend WithEvents statusCb As System.Windows.Forms.ComboBox
    Friend WithEvents sectionCb As System.Windows.Forms.ComboBox
    Friend WithEvents sexCb As System.Windows.Forms.ComboBox
    Friend WithEvents surnameTb As System.Windows.Forms.TextBox
    Friend WithEvents nameTb As System.Windows.Forms.TextBox
    Friend WithEvents employeeTb As System.Windows.Forms.TextBox
    Friend WithEvents searchBt As System.Windows.Forms.Button
    Friend WithEvents filenameLb As System.Windows.Forms.Label
    Friend WithEvents filenameTb As System.Windows.Forms.TextBox
    Friend WithEvents sheetCb As System.Windows.Forms.ComboBox
    Friend WithEvents MemberCommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importBt As System.Windows.Forms.Button
    Friend WithEvents MemberClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents sheetLb As System.Windows.Forms.Label
    Friend WithEvents showdataGb As System.Windows.Forms.GroupBox
    Friend WithEvents clearBt As Button
    Friend WithEvents showsectionBt As Button
    Friend WithEvents refreshBt As Button
    Friend WithEvents deletedbBt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Search_TB As TextBox
End Class
