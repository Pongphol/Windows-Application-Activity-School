<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudent
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
        Me.Panel_top2 = New System.Windows.Forms.Panel()
        Me.Panel_menu = New System.Windows.Forms.Panel()
        Me.lb_menu_act = New System.Windows.Forms.Label()
        Me.Panel_left1 = New System.Windows.Forms.Panel()
        Me.Panel_right1 = New System.Windows.Forms.Panel()
        Me.Panel_top1 = New System.Windows.Forms.Panel()
        Me.Panel_bottom1 = New System.Windows.Forms.Panel()
        Me.Panel_right = New System.Windows.Forms.Panel()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.Panel_bottom = New System.Windows.Forms.Panel()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.DataGridView_student = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_add_titlestd = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbb_add_class = New System.Windows.Forms.ComboBox()
        Me.cbb_add_dep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_add_class = New System.Windows.Forms.Label()
        Me.btn_add_std = New System.Windows.Forms.Button()
        Me.txt_add_lstd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_add_fstd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close_std = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delete_act = New System.Windows.Forms.Button()
        Me.cbb_edit_titlestd = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_edit_lstd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbb_edit_class = New System.Windows.Forms.ComboBox()
        Me.cbb_edit_dep = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_edit_std = New System.Windows.Forms.Button()
        Me.txt_edit_fstd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_edit_idstd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_search_nstd = New System.Windows.Forms.TextBox()
        Me.btn_search_std = New System.Windows.Forms.Button()
        Me.cbb_search_class_std = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbb_search_dep_std = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_delete_std_from_class = New System.Windows.Forms.Button()
        Me.Panel_menu.SuspendLayout()
        CType(Me.DataGridView_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(20, 99)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(1064, 10)
        Me.Panel_top2.TabIndex = 24
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_menu.Controls.Add(Me.lb_menu_act)
        Me.Panel_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_menu.Location = New System.Drawing.Point(20, 20)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(1064, 79)
        Me.Panel_menu.TabIndex = 23
        '
        'lb_menu_act
        '
        Me.lb_menu_act.AutoSize = True
        Me.lb_menu_act.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_menu_act.ForeColor = System.Drawing.Color.White
        Me.lb_menu_act.Location = New System.Drawing.Point(510, 25)
        Me.lb_menu_act.Name = "lb_menu_act"
        Me.lb_menu_act.Size = New System.Drawing.Size(86, 25)
        Me.lb_menu_act.TabIndex = 0
        Me.lb_menu_act.Text = "Student"
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 715)
        Me.Panel_left1.TabIndex = 22
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(1084, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 715)
        Me.Panel_right1.TabIndex = 21
        '
        'Panel_top1
        '
        Me.Panel_top1.BackColor = System.Drawing.Color.White
        Me.Panel_top1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top1.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top1.Name = "Panel_top1"
        Me.Panel_top1.Size = New System.Drawing.Size(1084, 10)
        Me.Panel_top1.TabIndex = 20
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 735)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(1084, 10)
        Me.Panel_bottom1.TabIndex = 19
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(1094, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 735)
        Me.Panel_right.TabIndex = 18
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 735)
        Me.Panel_left.TabIndex = 17
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 745)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(1104, 10)
        Me.Panel_bottom.TabIndex = 16
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(1104, 10)
        Me.Panel_top.TabIndex = 15
        '
        'DataGridView_student
        '
        Me.DataGridView_student.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_student.Location = New System.Drawing.Point(20, 161)
        Me.DataGridView_student.Name = "DataGridView_student"
        Me.DataGridView_student.Size = New System.Drawing.Size(759, 574)
        Me.DataGridView_student.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_add_titlestd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbb_add_class)
        Me.GroupBox1.Controls.Add(Me.cbb_add_dep)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lb_add_class)
        Me.GroupBox1.Controls.Add(Me.btn_add_std)
        Me.GroupBox1.Controls.Add(Me.txt_add_lstd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_add_fstd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(785, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 208)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพิ่มนักเรียน"
        '
        'cbb_add_titlestd
        '
        Me.cbb_add_titlestd.FormattingEnabled = True
        Me.cbb_add_titlestd.Location = New System.Drawing.Point(83, 72)
        Me.cbb_add_titlestd.Name = "cbb_add_titlestd"
        Me.cbb_add_titlestd.Size = New System.Drawing.Size(202, 21)
        Me.cbb_add_titlestd.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "คำนำหน้าชื่อ :"
        '
        'cbb_add_class
        '
        Me.cbb_add_class.FormattingEnabled = True
        Me.cbb_add_class.Location = New System.Drawing.Point(83, 45)
        Me.cbb_add_class.Name = "cbb_add_class"
        Me.cbb_add_class.Size = New System.Drawing.Size(202, 21)
        Me.cbb_add_class.TabIndex = 10
        '
        'cbb_add_dep
        '
        Me.cbb_add_dep.FormattingEnabled = True
        Me.cbb_add_dep.Location = New System.Drawing.Point(83, 19)
        Me.cbb_add_dep.Name = "cbb_add_dep"
        Me.cbb_add_dep.Size = New System.Drawing.Size(202, 21)
        Me.cbb_add_dep.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "สาขา :"
        '
        'lb_add_class
        '
        Me.lb_add_class.AutoSize = True
        Me.lb_add_class.Location = New System.Drawing.Point(25, 48)
        Me.lb_add_class.Name = "lb_add_class"
        Me.lb_add_class.Size = New System.Drawing.Size(53, 13)
        Me.lb_add_class.TabIndex = 7
        Me.lb_add_class.Text = "ระดับชั้น :"
        '
        'btn_add_std
        '
        Me.btn_add_std.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_add_std.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_std.ForeColor = System.Drawing.Color.White
        Me.btn_add_std.Location = New System.Drawing.Point(83, 153)
        Me.btn_add_std.Name = "btn_add_std"
        Me.btn_add_std.Size = New System.Drawing.Size(202, 40)
        Me.btn_add_std.TabIndex = 6
        Me.btn_add_std.Text = "เพิ่ม"
        Me.btn_add_std.UseVisualStyleBackColor = False
        '
        'txt_add_lstd
        '
        Me.txt_add_lstd.Location = New System.Drawing.Point(83, 126)
        Me.txt_add_lstd.Name = "txt_add_lstd"
        Me.txt_add_lstd.Size = New System.Drawing.Size(202, 20)
        Me.txt_add_lstd.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "นามสกุล :"
        '
        'txt_add_fstd
        '
        Me.txt_add_fstd.Location = New System.Drawing.Point(83, 99)
        Me.txt_add_fstd.Name = "txt_add_fstd"
        Me.txt_add_fstd.Size = New System.Drawing.Size(202, 20)
        Me.txt_add_fstd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ชื่อ :"
        '
        'btn_close_std
        '
        Me.btn_close_std.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_close_std.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_std.ForeColor = System.Drawing.Color.White
        Me.btn_close_std.Location = New System.Drawing.Point(963, 702)
        Me.btn_close_std.Name = "btn_close_std"
        Me.btn_close_std.Size = New System.Drawing.Size(121, 33)
        Me.btn_close_std.TabIndex = 27
        Me.btn_close_std.Text = "ออก"
        Me.btn_close_std.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delete_act)
        Me.GroupBox2.Controls.Add(Me.cbb_edit_titlestd)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_edit_lstd)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbb_edit_class)
        Me.GroupBox2.Controls.Add(Me.cbb_edit_dep)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btn_edit_std)
        Me.GroupBox2.Controls.Add(Me.txt_edit_fstd)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_edit_idstd)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(785, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 226)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "แก้ไขข้อมูลนักเรียน"
        '
        'btn_delete_act
        '
        Me.btn_delete_act.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_delete_act.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_act.ForeColor = System.Drawing.Color.White
        Me.btn_delete_act.Location = New System.Drawing.Point(202, 173)
        Me.btn_delete_act.Name = "btn_delete_act"
        Me.btn_delete_act.Size = New System.Drawing.Size(85, 39)
        Me.btn_delete_act.TabIndex = 15
        Me.btn_delete_act.Text = "ลบ"
        Me.btn_delete_act.UseVisualStyleBackColor = False
        '
        'cbb_edit_titlestd
        '
        Me.cbb_edit_titlestd.FormattingEnabled = True
        Me.cbb_edit_titlestd.Location = New System.Drawing.Point(83, 94)
        Me.cbb_edit_titlestd.Name = "cbb_edit_titlestd"
        Me.cbb_edit_titlestd.Size = New System.Drawing.Size(202, 21)
        Me.cbb_edit_titlestd.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "คำนำหน้าชื่อ :"
        '
        'txt_edit_lstd
        '
        Me.txt_edit_lstd.Location = New System.Drawing.Point(83, 146)
        Me.txt_edit_lstd.Name = "txt_edit_lstd"
        Me.txt_edit_lstd.Size = New System.Drawing.Size(202, 20)
        Me.txt_edit_lstd.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "นามสกุล :"
        '
        'cbb_edit_class
        '
        Me.cbb_edit_class.FormattingEnabled = True
        Me.cbb_edit_class.Location = New System.Drawing.Point(83, 45)
        Me.cbb_edit_class.Name = "cbb_edit_class"
        Me.cbb_edit_class.Size = New System.Drawing.Size(202, 21)
        Me.cbb_edit_class.TabIndex = 10
        '
        'cbb_edit_dep
        '
        Me.cbb_edit_dep.FormattingEnabled = True
        Me.cbb_edit_dep.Location = New System.Drawing.Point(83, 19)
        Me.cbb_edit_dep.Name = "cbb_edit_dep"
        Me.cbb_edit_dep.Size = New System.Drawing.Size(202, 21)
        Me.cbb_edit_dep.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "สาขา :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ระดับชั้น :"
        '
        'btn_edit_std
        '
        Me.btn_edit_std.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_edit_std.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_std.ForeColor = System.Drawing.Color.White
        Me.btn_edit_std.Location = New System.Drawing.Point(85, 173)
        Me.btn_edit_std.Name = "btn_edit_std"
        Me.btn_edit_std.Size = New System.Drawing.Size(85, 39)
        Me.btn_edit_std.TabIndex = 6
        Me.btn_edit_std.Text = "บันทึก"
        Me.btn_edit_std.UseVisualStyleBackColor = False
        '
        'txt_edit_fstd
        '
        Me.txt_edit_fstd.Location = New System.Drawing.Point(83, 120)
        Me.txt_edit_fstd.Name = "txt_edit_fstd"
        Me.txt_edit_fstd.Size = New System.Drawing.Size(202, 20)
        Me.txt_edit_fstd.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ชื่อ :"
        '
        'txt_edit_idstd
        '
        Me.txt_edit_idstd.Location = New System.Drawing.Point(83, 70)
        Me.txt_edit_idstd.Name = "txt_edit_idstd"
        Me.txt_edit_idstd.Size = New System.Drawing.Size(202, 20)
        Me.txt_edit_idstd.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "รหัส :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_search_nstd)
        Me.GroupBox3.Controls.Add(Me.btn_search_std)
        Me.GroupBox3.Controls.Add(Me.cbb_search_class_std)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cbb_search_dep_std)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 44)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'txt_search_nstd
        '
        Me.txt_search_nstd.Location = New System.Drawing.Point(451, 14)
        Me.txt_search_nstd.Name = "txt_search_nstd"
        Me.txt_search_nstd.Size = New System.Drawing.Size(138, 20)
        Me.txt_search_nstd.TabIndex = 14
        '
        'btn_search_std
        '
        Me.btn_search_std.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_search_std.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search_std.ForeColor = System.Drawing.Color.White
        Me.btn_search_std.Location = New System.Drawing.Point(595, 11)
        Me.btn_search_std.Name = "btn_search_std"
        Me.btn_search_std.Size = New System.Drawing.Size(149, 27)
        Me.btn_search_std.TabIndex = 13
        Me.btn_search_std.Text = "ค้นหา"
        Me.btn_search_std.UseVisualStyleBackColor = False
        '
        'cbb_search_class_std
        '
        Me.cbb_search_class_std.FormattingEnabled = True
        Me.cbb_search_class_std.Location = New System.Drawing.Point(304, 13)
        Me.cbb_search_class_std.Name = "cbb_search_class_std"
        Me.cbb_search_class_std.Size = New System.Drawing.Size(131, 21)
        Me.cbb_search_class_std.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "ระดับชั้น :"
        '
        'cbb_search_dep_std
        '
        Me.cbb_search_dep_std.FormattingEnabled = True
        Me.cbb_search_dep_std.Location = New System.Drawing.Point(38, 13)
        Me.cbb_search_dep_std.Name = "cbb_search_dep_std"
        Me.cbb_search_dep_std.Size = New System.Drawing.Size(202, 21)
        Me.cbb_search_dep_std.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "สาขา :"
        '
        'btn_delete_std_from_class
        '
        Me.btn_delete_std_from_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_delete_std_from_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_std_from_class.ForeColor = System.Drawing.Color.White
        Me.btn_delete_std_from_class.Location = New System.Drawing.Point(870, 561)
        Me.btn_delete_std_from_class.Name = "btn_delete_std_from_class"
        Me.btn_delete_std_from_class.Size = New System.Drawing.Size(202, 40)
        Me.btn_delete_std_from_class.TabIndex = 30
        Me.btn_delete_std_from_class.Text = "ลบรายชื่อทั้งหมดในระดับชั้น"
        Me.btn_delete_std_from_class.UseVisualStyleBackColor = False
        '
        'FrmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 755)
        Me.Controls.Add(Me.btn_delete_std_from_class)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_close_std)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_student)
        Me.Controls.Add(Me.Panel_top2)
        Me.Controls.Add(Me.Panel_menu)
        Me.Controls.Add(Me.Panel_left1)
        Me.Controls.Add(Me.Panel_right1)
        Me.Controls.Add(Me.Panel_top1)
        Me.Controls.Add(Me.Panel_bottom1)
        Me.Controls.Add(Me.Panel_right)
        Me.Controls.Add(Me.Panel_left)
        Me.Controls.Add(Me.Panel_bottom)
        Me.Controls.Add(Me.Panel_top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStudent"
        Me.Text = "FrmStudent"
        Me.Panel_menu.ResumeLayout(False)
        Me.Panel_menu.PerformLayout()
        CType(Me.DataGridView_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_top2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_menu As System.Windows.Forms.Panel
    Friend WithEvents lb_menu_act As System.Windows.Forms.Label
    Friend WithEvents Panel_left1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_right1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_top1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_right As System.Windows.Forms.Panel
    Friend WithEvents Panel_left As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents Panel_top As System.Windows.Forms.Panel
    Friend WithEvents DataGridView_student As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add_std As System.Windows.Forms.Button
    Friend WithEvents txt_add_lstd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_add_fstd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_close_std As System.Windows.Forms.Button
    Friend WithEvents cbb_add_class As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_add_dep As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_add_class As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_edit_class As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_edit_dep As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_edit_std As System.Windows.Forms.Button
    Friend WithEvents txt_edit_fstd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_edit_lstd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_search_class_std As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbb_search_dep_std As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_search_nstd As System.Windows.Forms.TextBox
    Friend WithEvents btn_search_std As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbb_add_titlestd As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_edit_titlestd As System.Windows.Forms.ComboBox
    Friend WithEvents txt_edit_idstd As System.Windows.Forms.TextBox
    Friend WithEvents btn_delete_act As System.Windows.Forms.Button
    Friend WithEvents btn_delete_std_from_class As System.Windows.Forms.Button
End Class
