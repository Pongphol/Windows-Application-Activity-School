<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lb_bot_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_bot_nstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_bot_line = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_bot_ndate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_bot_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer_check_anyfrm = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbtn_user = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_activity = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_department = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_class = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_teacher = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_std = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_check_std_act = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_check_list_std_act = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_split_act = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_import_std = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_log = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtn_logout = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 72)
        Me.Panel1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lb_bot_status, Me.lb_bot_nstatus, Me.lb_bot_line, Me.lb_bot_ndate, Me.lb_bot_date})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 786)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1135, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lb_bot_status
        '
        Me.lb_bot_status.Name = "lb_bot_status"
        Me.lb_bot_status.Size = New System.Drawing.Size(63, 17)
        Me.lb_bot_status.Text = "Welcome :"
        '
        'lb_bot_nstatus
        '
        Me.lb_bot_nstatus.Name = "lb_bot_nstatus"
        Me.lb_bot_nstatus.Size = New System.Drawing.Size(16, 17)
        Me.lb_bot_nstatus.Text = "..."
        '
        'lb_bot_line
        '
        Me.lb_bot_line.Name = "lb_bot_line"
        Me.lb_bot_line.Size = New System.Drawing.Size(10, 17)
        Me.lb_bot_line.Text = "|"
        '
        'lb_bot_ndate
        '
        Me.lb_bot_ndate.Name = "lb_bot_ndate"
        Me.lb_bot_ndate.Size = New System.Drawing.Size(62, 17)
        Me.lb_bot_ndate.Text = "Login On :"
        '
        'lb_bot_date
        '
        Me.lb_bot_date.Name = "lb_bot_date"
        Me.lb_bot_date.Size = New System.Drawing.Size(16, 17)
        Me.lb_bot_date.Text = "..."
        '
        'Timer_check_anyfrm
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_user, Me.ToolStripSeparator1, Me.tbtn_activity, Me.ToolStripSeparator3, Me.tbtn_department, Me.ToolStripSeparator4, Me.tbtn_class, Me.ToolStripSeparator2, Me.tbtn_teacher, Me.ToolStripSeparator5, Me.tbtn_std, Me.ToolStripSeparator6, Me.tbtn_check_std_act, Me.ToolStripSeparator7, Me.tbtn_check_list_std_act, Me.ToolStripSeparator8, Me.tbtn_split_act, Me.ToolStripSeparator9, Me.tbtn_import_std, Me.ToolStripSeparator10, Me.tbtn_log, Me.ToolStripSeparator11, Me.tbtn_logout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1135, 72)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbtn_user
        '
        Me.tbtn_user.Image = CType(resources.GetObject("tbtn_user.Image"), System.Drawing.Image)
        Me.tbtn_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_user.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_user.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_user.Name = "tbtn_user"
        Me.tbtn_user.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_user.Size = New System.Drawing.Size(72, 69)
        Me.tbtn_user.Text = "สมาชิก"
        Me.tbtn_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_user.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.tbtn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_activity
        '
        Me.tbtn_activity.Image = CType(resources.GetObject("tbtn_activity.Image"), System.Drawing.Image)
        Me.tbtn_activity.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_activity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_activity.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_activity.Name = "tbtn_activity"
        Me.tbtn_activity.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_activity.Size = New System.Drawing.Size(86, 69)
        Me.tbtn_activity.Text = "เพิ่มกิจกรรม"
        Me.tbtn_activity.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_activity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_department
        '
        Me.tbtn_department.Image = CType(resources.GetObject("tbtn_department.Image"), System.Drawing.Image)
        Me.tbtn_department.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_department.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_department.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_department.Name = "tbtn_department"
        Me.tbtn_department.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_department.Size = New System.Drawing.Size(72, 69)
        Me.tbtn_department.Text = "เพิ่มสาขา"
        Me.tbtn_department.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_department.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_class
        '
        Me.tbtn_class.Image = CType(resources.GetObject("tbtn_class.Image"), System.Drawing.Image)
        Me.tbtn_class.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_class.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_class.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_class.Name = "tbtn_class"
        Me.tbtn_class.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_class.Size = New System.Drawing.Size(86, 69)
        Me.tbtn_class.Text = "เพิ่มระดับชั้น"
        Me.tbtn_class.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_class.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_teacher
        '
        Me.tbtn_teacher.Image = CType(resources.GetObject("tbtn_teacher.Image"), System.Drawing.Image)
        Me.tbtn_teacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_teacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_teacher.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_teacher.Name = "tbtn_teacher"
        Me.tbtn_teacher.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_teacher.Size = New System.Drawing.Size(82, 69)
        Me.tbtn_teacher.Text = "เพิ่มอาจารย์"
        Me.tbtn_teacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_teacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_std
        '
        Me.tbtn_std.Image = CType(resources.GetObject("tbtn_std.Image"), System.Drawing.Image)
        Me.tbtn_std.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_std.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_std.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_std.Name = "tbtn_std"
        Me.tbtn_std.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_std.Size = New System.Drawing.Size(72, 69)
        Me.tbtn_std.Text = "นักเรียน"
        Me.tbtn_std.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_std.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_check_std_act
        '
        Me.tbtn_check_std_act.Image = CType(resources.GetObject("tbtn_check_std_act.Image"), System.Drawing.Image)
        Me.tbtn_check_std_act.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_check_std_act.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_check_std_act.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_check_std_act.Name = "tbtn_check_std_act"
        Me.tbtn_check_std_act.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_check_std_act.Size = New System.Drawing.Size(117, 69)
        Me.tbtn_check_std_act.Text = "เช็ครายชื่อนักศึกษา"
        Me.tbtn_check_std_act.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_check_std_act.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_check_list_std_act
        '
        Me.tbtn_check_list_std_act.Image = CType(resources.GetObject("tbtn_check_list_std_act.Image"), System.Drawing.Image)
        Me.tbtn_check_list_std_act.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_check_list_std_act.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_check_list_std_act.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_check_list_std_act.Name = "tbtn_check_list_std_act"
        Me.tbtn_check_list_std_act.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_check_list_std_act.Size = New System.Drawing.Size(152, 69)
        Me.tbtn_check_list_std_act.Text = "ดูรายชื่อนักศึกษา(กิจกรรม)"
        Me.tbtn_check_list_std_act.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_check_list_std_act.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_split_act
        '
        Me.tbtn_split_act.Image = CType(resources.GetObject("tbtn_split_act.Image"), System.Drawing.Image)
        Me.tbtn_split_act.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_split_act.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_split_act.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_split_act.Name = "tbtn_split_act"
        Me.tbtn_split_act.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_split_act.Size = New System.Drawing.Size(135, 69)
        Me.tbtn_split_act.Text = "รายชื่อห้องที่ส่งใบรายชื่อ"
        Me.tbtn_split_act.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_split_act.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_import_std
        '
        Me.tbtn_import_std.Image = CType(resources.GetObject("tbtn_import_std.Image"), System.Drawing.Image)
        Me.tbtn_import_std.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_import_std.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_import_std.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_import_std.Name = "tbtn_import_std"
        Me.tbtn_import_std.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_import_std.Size = New System.Drawing.Size(72, 69)
        Me.tbtn_import_std.Text = "Import"
        Me.tbtn_import_std.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_import_std.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_log
        '
        Me.tbtn_log.Image = CType(resources.GetObject("tbtn_log.Image"), System.Drawing.Image)
        Me.tbtn_log.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_log.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_log.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_log.Name = "tbtn_log"
        Me.tbtn_log.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_log.Size = New System.Drawing.Size(103, 69)
        Me.tbtn_log.Text = "ประวัติการใช้งาน"
        Me.tbtn_log.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 72)
        '
        'tbtn_logout
        '
        Me.tbtn_logout.Image = CType(resources.GetObject("tbtn_logout.Image"), System.Drawing.Image)
        Me.tbtn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbtn_logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbtn_logout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_logout.Name = "tbtn_logout"
        Me.tbtn_logout.Padding = New System.Windows.Forms.Padding(10)
        Me.tbtn_logout.Size = New System.Drawing.Size(91, 103)
        Me.tbtn_logout.Text = "ออกจากระบบ"
        Me.tbtn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tbtn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbtn_logout.ToolTipText = "ออกจากระบบ"
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 808)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "FrmAdmin"
        Me.ShowIcon = False
        Me.Text = "Admin Panel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lb_bot_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lb_bot_nstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer_check_anyfrm As System.Windows.Forms.Timer
    Friend WithEvents lb_bot_line As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lb_bot_ndate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lb_bot_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbtn_user As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_activity As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_department As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_class As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_teacher As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_std As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_check_std_act As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_check_list_std_act As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_split_act As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_import_std As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_log As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_logout As System.Windows.Forms.ToolStripButton

End Class
