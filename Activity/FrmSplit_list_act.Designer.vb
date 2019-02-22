<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplit_list_act
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
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.DataGridView_Split = New System.Windows.Forms.DataGridView()
        Me.btn_close_frm_split = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbb_search_act = New System.Windows.Forms.ComboBox()
        Me.btn_confirm_search_split = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 10)
        Me.Panel2.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.lb_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 74)
        Me.Panel1.TabIndex = 40
        '
        'lb_menu
        '
        Me.lb_menu.AutoSize = True
        Me.lb_menu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_menu.ForeColor = System.Drawing.Color.White
        Me.lb_menu.Location = New System.Drawing.Point(174, 22)
        Me.lb_menu.Name = "lb_menu"
        Me.lb_menu.Size = New System.Drawing.Size(190, 25)
        Me.lb_menu.TabIndex = 0
        Me.lb_menu.Text = "รายชื่อห้องที่ส่งใบกิจกรรม"
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 577)
        Me.Panel_left1.TabIndex = 39
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(544, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 577)
        Me.Panel_right1.TabIndex = 38
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(544, 10)
        Me.Panel_top2.TabIndex = 37
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 597)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(544, 10)
        Me.Panel_bottom1.TabIndex = 36
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 597)
        Me.Panel_left.TabIndex = 35
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(554, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 597)
        Me.Panel_right.TabIndex = 34
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 607)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(564, 10)
        Me.Panel_bottom.TabIndex = 33
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(564, 10)
        Me.Panel_top.TabIndex = 32
        '
        'DataGridView_Split
        '
        Me.DataGridView_Split.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Split.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Split.Location = New System.Drawing.Point(20, 144)
        Me.DataGridView_Split.Name = "DataGridView_Split"
        Me.DataGridView_Split.Size = New System.Drawing.Size(523, 414)
        Me.DataGridView_Split.TabIndex = 42
        '
        'btn_close_frm_split
        '
        Me.btn_close_frm_split.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_close_frm_split.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_frm_split.ForeColor = System.Drawing.Color.White
        Me.btn_close_frm_split.Location = New System.Drawing.Point(432, 564)
        Me.btn_close_frm_split.Name = "btn_close_frm_split"
        Me.btn_close_frm_split.Size = New System.Drawing.Size(106, 30)
        Me.btn_close_frm_split.TabIndex = 43
        Me.btn_close_frm_split.Text = "ออก"
        Me.btn_close_frm_split.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "กิจกรรม :"
        '
        'cbb_search_act
        '
        Me.cbb_search_act.FormattingEnabled = True
        Me.cbb_search_act.Location = New System.Drawing.Point(83, 112)
        Me.cbb_search_act.Name = "cbb_search_act"
        Me.cbb_search_act.Size = New System.Drawing.Size(337, 21)
        Me.cbb_search_act.TabIndex = 53
        '
        'btn_confirm_search_split
        '
        Me.btn_confirm_search_split.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_confirm_search_split.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm_search_split.ForeColor = System.Drawing.Color.White
        Me.btn_confirm_search_split.Location = New System.Drawing.Point(426, 105)
        Me.btn_confirm_search_split.Name = "btn_confirm_search_split"
        Me.btn_confirm_search_split.Size = New System.Drawing.Size(112, 33)
        Me.btn_confirm_search_split.TabIndex = 70
        Me.btn_confirm_search_split.Text = "ยืนยัน"
        Me.btn_confirm_search_split.UseVisualStyleBackColor = False
        '
        'FrmSplit_list_act
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 617)
        Me.Controls.Add(Me.btn_confirm_search_split)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbb_search_act)
        Me.Controls.Add(Me.btn_close_frm_split)
        Me.Controls.Add(Me.DataGridView_Split)
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
        Me.Name = "FrmSplit_list_act"
        Me.Text = "FrmSplit_list_act"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
    Friend WithEvents DataGridView_Split As System.Windows.Forms.DataGridView
    Friend WithEvents btn_close_frm_split As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbb_search_act As System.Windows.Forms.ComboBox
    Friend WithEvents btn_confirm_search_split As System.Windows.Forms.Button
End Class
