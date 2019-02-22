<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLog
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_menu = New System.Windows.Forms.Label()
        Me.Panel_left1 = New System.Windows.Forms.Panel()
        Me.Panel_right1 = New System.Windows.Forms.Panel()
        Me.Panel_top2 = New System.Windows.Forms.Panel()
        Me.Panel_bottom1 = New System.Windows.Forms.Panel()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.Panel_right = New System.Windows.Forms.Panel()
        Me.Panel_bottom = New System.Windows.Forms.Panel()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView_log = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_reset_id_log = New System.Windows.Forms.Button()
        Me.btn_close_frm_log = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.lb_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 74)
        Me.Panel1.TabIndex = 49
        '
        'lb_menu
        '
        Me.lb_menu.AutoSize = True
        Me.lb_menu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_menu.ForeColor = System.Drawing.Color.White
        Me.lb_menu.Location = New System.Drawing.Point(351, 22)
        Me.lb_menu.Name = "lb_menu"
        Me.lb_menu.Size = New System.Drawing.Size(128, 25)
        Me.lb_menu.TabIndex = 0
        Me.lb_menu.Text = "ประวัติการใช้งาน"
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 524)
        Me.Panel_left1.TabIndex = 48
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(812, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 524)
        Me.Panel_right1.TabIndex = 47
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(812, 10)
        Me.Panel_top2.TabIndex = 46
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 544)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(812, 10)
        Me.Panel_bottom1.TabIndex = 45
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 544)
        Me.Panel_left.TabIndex = 44
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(822, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 544)
        Me.Panel_right.TabIndex = 43
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 554)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(832, 10)
        Me.Panel_bottom.TabIndex = 42
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(832, 10)
        Me.Panel_top.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 10)
        Me.Panel2.TabIndex = 51
        '
        'DataGridView_log
        '
        Me.DataGridView_log.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_log.Location = New System.Drawing.Point(20, 104)
        Me.DataGridView_log.Name = "DataGridView_log"
        Me.DataGridView_log.Size = New System.Drawing.Size(643, 440)
        Me.DataGridView_log.TabIndex = 52
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_reset_id_log)
        Me.GroupBox2.Location = New System.Drawing.Point(669, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 79)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'btn_reset_id_log
        '
        Me.btn_reset_id_log.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_reset_id_log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reset_id_log.ForeColor = System.Drawing.Color.White
        Me.btn_reset_id_log.Location = New System.Drawing.Point(8, 19)
        Me.btn_reset_id_log.Name = "btn_reset_id_log"
        Me.btn_reset_id_log.Size = New System.Drawing.Size(123, 45)
        Me.btn_reset_id_log.TabIndex = 0
        Me.btn_reset_id_log.Text = "ล้างประวัติการใช้งาน"
        Me.btn_reset_id_log.UseVisualStyleBackColor = False
        '
        'btn_close_frm_log
        '
        Me.btn_close_frm_log.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_close_frm_log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_frm_log.ForeColor = System.Drawing.Color.White
        Me.btn_close_frm_log.Location = New System.Drawing.Point(694, 508)
        Me.btn_close_frm_log.Name = "btn_close_frm_log"
        Me.btn_close_frm_log.Size = New System.Drawing.Size(106, 30)
        Me.btn_close_frm_log.TabIndex = 54
        Me.btn_close_frm_log.Text = "ออก"
        Me.btn_close_frm_log.UseVisualStyleBackColor = False
        '
        'FrmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 564)
        Me.Controls.Add(Me.btn_close_frm_log)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView_log)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_left1)
        Me.Controls.Add(Me.Panel_right1)
        Me.Controls.Add(Me.Panel_top2)
        Me.Controls.Add(Me.Panel_bottom1)
        Me.Controls.Add(Me.Panel_left)
        Me.Controls.Add(Me.Panel_right)
        Me.Controls.Add(Me.Panel_bottom)
        Me.Controls.Add(Me.Panel_top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLog"
        Me.Text = "FrmLog"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_menu As System.Windows.Forms.Label
    Friend WithEvents Panel_left1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_right1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_top2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_left As System.Windows.Forms.Panel
    Friend WithEvents Panel_right As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents Panel_top As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView_log As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_reset_id_log As System.Windows.Forms.Button
    Friend WithEvents btn_close_frm_log As System.Windows.Forms.Button
End Class
