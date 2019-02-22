<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActivity))
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.Panel_bottom = New System.Windows.Forms.Panel()
        Me.Panel_right = New System.Windows.Forms.Panel()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.Panel_top1 = New System.Windows.Forms.Panel()
        Me.Panel_bottom1 = New System.Windows.Forms.Panel()
        Me.Panel_left1 = New System.Windows.Forms.Panel()
        Me.Panel_right1 = New System.Windows.Forms.Panel()
        Me.Panel_menu = New System.Windows.Forms.Panel()
        Me.lb_menu_act = New System.Windows.Forms.Label()
        Me.btn_close_act = New System.Windows.Forms.Button()
        Me.DataGridView_act = New System.Windows.Forms.DataGridView()
        Me.Panel_top2 = New System.Windows.Forms.Panel()
        Me.GroupBox_add_act = New System.Windows.Forms.GroupBox()
        Me.btn_add_browse_img = New System.Windows.Forms.Button()
        Me.PictureBox_add_act_img = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker_act = New System.Windows.Forms.DateTimePicker()
        Me.btn_add_act = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_add_act = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_edit_act = New System.Windows.Forms.GroupBox()
        Me.btn_delete_act = New System.Windows.Forms.Button()
        Me.btn_edit_browse_img = New System.Windows.Forms.Button()
        Me.PictureBox_edit_act_img = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker_edit_dateact = New System.Windows.Forms.DateTimePicker()
        Me.btn_edit_act = New System.Windows.Forms.Button()
        Me.lb_edit_dateact = New System.Windows.Forms.Label()
        Me.txt_edit_nact = New System.Windows.Forms.TextBox()
        Me.lb_edit_nact = New System.Windows.Forms.Label()
        Me.OpenFileDialog_add_act_img = New System.Windows.Forms.OpenFileDialog()
        Me.Panel_menu.SuspendLayout()
        CType(Me.DataGridView_act, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_add_act.SuspendLayout()
        CType(Me.PictureBox_add_act_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_edit_act.SuspendLayout()
        CType(Me.PictureBox_edit_act_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(943, 10)
        Me.Panel_top.TabIndex = 1
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 770)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(943, 10)
        Me.Panel_bottom.TabIndex = 2
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(933, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 760)
        Me.Panel_right.TabIndex = 4
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 760)
        Me.Panel_left.TabIndex = 5
        '
        'Panel_top1
        '
        Me.Panel_top1.BackColor = System.Drawing.Color.White
        Me.Panel_top1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top1.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top1.Name = "Panel_top1"
        Me.Panel_top1.Size = New System.Drawing.Size(923, 10)
        Me.Panel_top1.TabIndex = 6
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 760)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(923, 10)
        Me.Panel_bottom1.TabIndex = 7
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 740)
        Me.Panel_left1.TabIndex = 8
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(923, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 740)
        Me.Panel_right1.TabIndex = 9
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_menu.Controls.Add(Me.lb_menu_act)
        Me.Panel_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_menu.Location = New System.Drawing.Point(20, 20)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(903, 79)
        Me.Panel_menu.TabIndex = 10
        '
        'lb_menu_act
        '
        Me.lb_menu_act.AutoSize = True
        Me.lb_menu_act.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_menu_act.ForeColor = System.Drawing.Color.White
        Me.lb_menu_act.Location = New System.Drawing.Point(420, 25)
        Me.lb_menu_act.Name = "lb_menu_act"
        Me.lb_menu_act.Size = New System.Drawing.Size(76, 25)
        Me.lb_menu_act.TabIndex = 0
        Me.lb_menu_act.Text = "กิจกรรม"
        '
        'btn_close_act
        '
        Me.btn_close_act.BackColor = System.Drawing.Color.Crimson
        Me.btn_close_act.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_act.ForeColor = System.Drawing.Color.White
        Me.btn_close_act.Location = New System.Drawing.Point(802, 725)
        Me.btn_close_act.Name = "btn_close_act"
        Me.btn_close_act.Size = New System.Drawing.Size(121, 33)
        Me.btn_close_act.TabIndex = 11
        Me.btn_close_act.Text = "ออก"
        Me.btn_close_act.UseVisualStyleBackColor = False
        '
        'DataGridView_act
        '
        Me.DataGridView_act.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_act.Location = New System.Drawing.Point(20, 109)
        Me.DataGridView_act.Name = "DataGridView_act"
        Me.DataGridView_act.Size = New System.Drawing.Size(570, 651)
        Me.DataGridView_act.TabIndex = 12
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(20, 99)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(903, 10)
        Me.Panel_top2.TabIndex = 13
        '
        'GroupBox_add_act
        '
        Me.GroupBox_add_act.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_add_act.Controls.Add(Me.btn_add_browse_img)
        Me.GroupBox_add_act.Controls.Add(Me.PictureBox_add_act_img)
        Me.GroupBox_add_act.Controls.Add(Me.DateTimePicker_act)
        Me.GroupBox_add_act.Controls.Add(Me.btn_add_act)
        Me.GroupBox_add_act.Controls.Add(Me.Label2)
        Me.GroupBox_add_act.Controls.Add(Me.txt_add_act)
        Me.GroupBox_add_act.Controls.Add(Me.Label1)
        Me.GroupBox_add_act.Location = New System.Drawing.Point(596, 115)
        Me.GroupBox_add_act.Name = "GroupBox_add_act"
        Me.GroupBox_add_act.Size = New System.Drawing.Size(321, 281)
        Me.GroupBox_add_act.TabIndex = 14
        Me.GroupBox_add_act.TabStop = False
        Me.GroupBox_add_act.Text = "เพิ่มกิจกรรม"
        '
        'btn_add_browse_img
        '
        Me.btn_add_browse_img.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_add_browse_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_browse_img.ForeColor = System.Drawing.Color.White
        Me.btn_add_browse_img.Location = New System.Drawing.Point(6, 79)
        Me.btn_add_browse_img.Name = "btn_add_browse_img"
        Me.btn_add_browse_img.Size = New System.Drawing.Size(79, 35)
        Me.btn_add_browse_img.TabIndex = 7
        Me.btn_add_browse_img.Text = "Browse..."
        Me.btn_add_browse_img.UseVisualStyleBackColor = False
        '
        'PictureBox_add_act_img
        '
        Me.PictureBox_add_act_img.BackColor = System.Drawing.Color.White
        Me.PictureBox_add_act_img.ErrorImage = CType(resources.GetObject("PictureBox_add_act_img.ErrorImage"), System.Drawing.Image)
        Me.PictureBox_add_act_img.Location = New System.Drawing.Point(91, 79)
        Me.PictureBox_add_act_img.Name = "PictureBox_add_act_img"
        Me.PictureBox_add_act_img.Size = New System.Drawing.Size(210, 145)
        Me.PictureBox_add_act_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_add_act_img.TabIndex = 6
        Me.PictureBox_add_act_img.TabStop = False
        '
        'DateTimePicker_act
        '
        Me.DateTimePicker_act.Location = New System.Drawing.Point(92, 53)
        Me.DateTimePicker_act.Name = "DateTimePicker_act"
        Me.DateTimePicker_act.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker_act.TabIndex = 5
        '
        'btn_add_act
        '
        Me.btn_add_act.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_add_act.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_act.ForeColor = System.Drawing.Color.White
        Me.btn_add_act.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_act.Location = New System.Drawing.Point(92, 230)
        Me.btn_add_act.Name = "btn_add_act"
        Me.btn_add_act.Size = New System.Drawing.Size(211, 39)
        Me.btn_add_act.TabIndex = 4
        Me.btn_add_act.Text = "เพิ่มกิจกรรม"
        Me.btn_add_act.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "วันที่จัดกิจกรรม :"
        '
        'txt_add_act
        '
        Me.txt_add_act.Location = New System.Drawing.Point(91, 24)
        Me.txt_add_act.Name = "txt_add_act"
        Me.txt_add_act.Size = New System.Drawing.Size(210, 20)
        Me.txt_add_act.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อกิจกรรม :"
        '
        'GroupBox_edit_act
        '
        Me.GroupBox_edit_act.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_edit_act.Controls.Add(Me.btn_delete_act)
        Me.GroupBox_edit_act.Controls.Add(Me.btn_edit_browse_img)
        Me.GroupBox_edit_act.Controls.Add(Me.PictureBox_edit_act_img)
        Me.GroupBox_edit_act.Controls.Add(Me.DateTimePicker_edit_dateact)
        Me.GroupBox_edit_act.Controls.Add(Me.btn_edit_act)
        Me.GroupBox_edit_act.Controls.Add(Me.lb_edit_dateact)
        Me.GroupBox_edit_act.Controls.Add(Me.txt_edit_nact)
        Me.GroupBox_edit_act.Controls.Add(Me.lb_edit_nact)
        Me.GroupBox_edit_act.Location = New System.Drawing.Point(596, 402)
        Me.GroupBox_edit_act.Name = "GroupBox_edit_act"
        Me.GroupBox_edit_act.Size = New System.Drawing.Size(321, 288)
        Me.GroupBox_edit_act.TabIndex = 15
        Me.GroupBox_edit_act.TabStop = False
        Me.GroupBox_edit_act.Text = "แก้ไขกิจกรรม"
        '
        'btn_delete_act
        '
        Me.btn_delete_act.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete_act.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_act.ForeColor = System.Drawing.Color.White
        Me.btn_delete_act.Location = New System.Drawing.Point(202, 236)
        Me.btn_delete_act.Name = "btn_delete_act"
        Me.btn_delete_act.Size = New System.Drawing.Size(103, 39)
        Me.btn_delete_act.TabIndex = 9
        Me.btn_delete_act.Text = "ลบ"
        Me.btn_delete_act.UseVisualStyleBackColor = False
        '
        'btn_edit_browse_img
        '
        Me.btn_edit_browse_img.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_edit_browse_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_browse_img.ForeColor = System.Drawing.Color.White
        Me.btn_edit_browse_img.Location = New System.Drawing.Point(7, 85)
        Me.btn_edit_browse_img.Name = "btn_edit_browse_img"
        Me.btn_edit_browse_img.Size = New System.Drawing.Size(79, 35)
        Me.btn_edit_browse_img.TabIndex = 8
        Me.btn_edit_browse_img.Text = "Browse..."
        Me.btn_edit_browse_img.UseVisualStyleBackColor = False
        '
        'PictureBox_edit_act_img
        '
        Me.PictureBox_edit_act_img.BackColor = System.Drawing.Color.White
        Me.PictureBox_edit_act_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_edit_act_img.ErrorImage = CType(resources.GetObject("PictureBox_edit_act_img.ErrorImage"), System.Drawing.Image)
        Me.PictureBox_edit_act_img.Location = New System.Drawing.Point(93, 85)
        Me.PictureBox_edit_act_img.Name = "PictureBox_edit_act_img"
        Me.PictureBox_edit_act_img.Size = New System.Drawing.Size(210, 145)
        Me.PictureBox_edit_act_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_edit_act_img.TabIndex = 7
        Me.PictureBox_edit_act_img.TabStop = False
        '
        'DateTimePicker_edit_dateact
        '
        Me.DateTimePicker_edit_dateact.Location = New System.Drawing.Point(92, 58)
        Me.DateTimePicker_edit_dateact.Name = "DateTimePicker_edit_dateact"
        Me.DateTimePicker_edit_dateact.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker_edit_dateact.TabIndex = 5
        '
        'btn_edit_act
        '
        Me.btn_edit_act.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_edit_act.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_act.ForeColor = System.Drawing.Color.White
        Me.btn_edit_act.Location = New System.Drawing.Point(93, 236)
        Me.btn_edit_act.Name = "btn_edit_act"
        Me.btn_edit_act.Size = New System.Drawing.Size(103, 39)
        Me.btn_edit_act.TabIndex = 4
        Me.btn_edit_act.Text = "บันทึก"
        Me.btn_edit_act.UseVisualStyleBackColor = False
        '
        'lb_edit_dateact
        '
        Me.lb_edit_dateact.AutoSize = True
        Me.lb_edit_dateact.Location = New System.Drawing.Point(0, 57)
        Me.lb_edit_dateact.Name = "lb_edit_dateact"
        Me.lb_edit_dateact.Size = New System.Drawing.Size(86, 13)
        Me.lb_edit_dateact.TabIndex = 2
        Me.lb_edit_dateact.Text = "วันที่จัดกิจกรรม :"
        '
        'txt_edit_nact
        '
        Me.txt_edit_nact.Location = New System.Drawing.Point(91, 29)
        Me.txt_edit_nact.Name = "txt_edit_nact"
        Me.txt_edit_nact.Size = New System.Drawing.Size(210, 20)
        Me.txt_edit_nact.TabIndex = 1
        '
        'lb_edit_nact
        '
        Me.lb_edit_nact.AutoSize = True
        Me.lb_edit_nact.Location = New System.Drawing.Point(20, 32)
        Me.lb_edit_nact.Name = "lb_edit_nact"
        Me.lb_edit_nact.Size = New System.Drawing.Size(65, 13)
        Me.lb_edit_nact.TabIndex = 0
        Me.lb_edit_nact.Text = "ชื่อกิจกรรม :"
        '
        'OpenFileDialog_add_act_img
        '
        Me.OpenFileDialog_add_act_img.FileName = "OpenFileDialog1"
        '
        'FrmActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 780)
        Me.Controls.Add(Me.GroupBox_edit_act)
        Me.Controls.Add(Me.GroupBox_add_act)
        Me.Controls.Add(Me.Panel_top2)
        Me.Controls.Add(Me.DataGridView_act)
        Me.Controls.Add(Me.btn_close_act)
        Me.Controls.Add(Me.Panel_menu)
        Me.Controls.Add(Me.Panel_right1)
        Me.Controls.Add(Me.Panel_left1)
        Me.Controls.Add(Me.Panel_bottom1)
        Me.Controls.Add(Me.Panel_top1)
        Me.Controls.Add(Me.Panel_left)
        Me.Controls.Add(Me.Panel_right)
        Me.Controls.Add(Me.Panel_bottom)
        Me.Controls.Add(Me.Panel_top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmActivity"
        Me.Text = "FrmActivity"
        Me.Panel_menu.ResumeLayout(False)
        Me.Panel_menu.PerformLayout()
        CType(Me.DataGridView_act, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_add_act.ResumeLayout(False)
        Me.GroupBox_add_act.PerformLayout()
        CType(Me.PictureBox_add_act_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_edit_act.ResumeLayout(False)
        Me.GroupBox_edit_act.PerformLayout()
        CType(Me.PictureBox_edit_act_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_top As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents Panel_right As System.Windows.Forms.Panel
    Friend WithEvents Panel_left As System.Windows.Forms.Panel
    Friend WithEvents Panel_top1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_left1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_right1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_menu As System.Windows.Forms.Panel
    Friend WithEvents lb_menu_act As System.Windows.Forms.Label
    Friend WithEvents btn_close_act As System.Windows.Forms.Button
    Friend WithEvents DataGridView_act As System.Windows.Forms.DataGridView
    Friend WithEvents Panel_top2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox_add_act As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add_act As System.Windows.Forms.Button
    Friend WithEvents txt_add_act As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_act As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox_edit_act As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_edit_dateact As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_edit_act As System.Windows.Forms.Button
    Friend WithEvents lb_edit_dateact As System.Windows.Forms.Label
    Friend WithEvents txt_edit_nact As System.Windows.Forms.TextBox
    Friend WithEvents lb_edit_nact As System.Windows.Forms.Label
    Friend WithEvents PictureBox_add_act_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_add_browse_img As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_add_act_img As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox_edit_act_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_edit_browse_img As System.Windows.Forms.Button
    Friend WithEvents btn_delete_act As System.Windows.Forms.Button
End Class
