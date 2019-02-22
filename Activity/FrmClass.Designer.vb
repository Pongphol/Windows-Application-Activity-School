<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClass
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
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.Panel_right = New System.Windows.Forms.Panel()
        Me.Panel_bottom = New System.Windows.Forms.Panel()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.Panel_left1 = New System.Windows.Forms.Panel()
        Me.Panel_right1 = New System.Windows.Forms.Panel()
        Me.Panel_top2 = New System.Windows.Forms.Panel()
        Me.Panel_bottom1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_menu = New System.Windows.Forms.Label()
        Me.DataGridView_Class = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_add_dep = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add_class = New System.Windows.Forms.Button()
        Me.txt_add_nclass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delete_class = New System.Windows.Forms.Button()
        Me.cbb_edit_dep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_edit_class = New System.Windows.Forms.Button()
        Me.txt_edit_nclass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_close_class = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Class, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 654)
        Me.Panel_left.TabIndex = 13
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(516, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 654)
        Me.Panel_right.TabIndex = 12
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 664)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(526, 10)
        Me.Panel_bottom.TabIndex = 11
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(526, 10)
        Me.Panel_top.TabIndex = 10
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 634)
        Me.Panel_left1.TabIndex = 22
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(506, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 634)
        Me.Panel_right1.TabIndex = 21
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(506, 10)
        Me.Panel_top2.TabIndex = 20
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 654)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(506, 10)
        Me.Panel_bottom1.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.lb_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 74)
        Me.Panel1.TabIndex = 23
        '
        'lb_menu
        '
        Me.lb_menu.AutoSize = True
        Me.lb_menu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_menu.ForeColor = System.Drawing.Color.White
        Me.lb_menu.Location = New System.Drawing.Point(270, 21)
        Me.lb_menu.Name = "lb_menu"
        Me.lb_menu.Size = New System.Drawing.Size(71, 25)
        Me.lb_menu.TabIndex = 0
        Me.lb_menu.Text = "ระดับชั้น"
        '
        'DataGridView_Class
        '
        Me.DataGridView_Class.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Class.Location = New System.Drawing.Point(20, 233)
        Me.DataGridView_Class.Name = "DataGridView_Class"
        Me.DataGridView_Class.Size = New System.Drawing.Size(485, 382)
        Me.DataGridView_Class.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_add_dep)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_add_class)
        Me.GroupBox1.Controls.Add(Me.txt_add_nclass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 127)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพิ่มระดับชั้น"
        '
        'cbb_add_dep
        '
        Me.cbb_add_dep.FormattingEnabled = True
        Me.cbb_add_dep.Location = New System.Drawing.Point(61, 19)
        Me.cbb_add_dep.Name = "cbb_add_dep"
        Me.cbb_add_dep.Size = New System.Drawing.Size(161, 21)
        Me.cbb_add_dep.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "สาขา :"
        '
        'btn_add_class
        '
        Me.btn_add_class.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_add_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_class.ForeColor = System.Drawing.Color.White
        Me.btn_add_class.Location = New System.Drawing.Point(61, 70)
        Me.btn_add_class.Name = "btn_add_class"
        Me.btn_add_class.Size = New System.Drawing.Size(161, 39)
        Me.btn_add_class.TabIndex = 10
        Me.btn_add_class.Text = "เพิ่ม"
        Me.btn_add_class.UseVisualStyleBackColor = False
        '
        'txt_add_nclass
        '
        Me.txt_add_nclass.Location = New System.Drawing.Point(61, 44)
        Me.txt_add_nclass.Name = "txt_add_nclass"
        Me.txt_add_nclass.Size = New System.Drawing.Size(161, 20)
        Me.txt_add_nclass.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ระดับชั้น :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delete_class)
        Me.GroupBox2.Controls.Add(Me.cbb_edit_dep)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_edit_class)
        Me.GroupBox2.Controls.Add(Me.txt_edit_nclass)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 127)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "แก้ไขระดับชั้น"
        '
        'btn_delete_class
        '
        Me.btn_delete_class.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_class.ForeColor = System.Drawing.Color.White
        Me.btn_delete_class.Location = New System.Drawing.Point(157, 70)
        Me.btn_delete_class.Name = "btn_delete_class"
        Me.btn_delete_class.Size = New System.Drawing.Size(76, 39)
        Me.btn_delete_class.TabIndex = 18
        Me.btn_delete_class.Text = "ลบ"
        Me.btn_delete_class.UseVisualStyleBackColor = False
        '
        'cbb_edit_dep
        '
        Me.cbb_edit_dep.FormattingEnabled = True
        Me.cbb_edit_dep.Location = New System.Drawing.Point(72, 19)
        Me.cbb_edit_dep.Name = "cbb_edit_dep"
        Me.cbb_edit_dep.Size = New System.Drawing.Size(161, 21)
        Me.cbb_edit_dep.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "สาขา :"
        '
        'btn_edit_class
        '
        Me.btn_edit_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_edit_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_class.ForeColor = System.Drawing.Color.White
        Me.btn_edit_class.Location = New System.Drawing.Point(72, 70)
        Me.btn_edit_class.Name = "btn_edit_class"
        Me.btn_edit_class.Size = New System.Drawing.Size(76, 39)
        Me.btn_edit_class.TabIndex = 15
        Me.btn_edit_class.Text = "บันทึก"
        Me.btn_edit_class.UseVisualStyleBackColor = False
        '
        'txt_edit_nclass
        '
        Me.txt_edit_nclass.Location = New System.Drawing.Point(72, 44)
        Me.txt_edit_nclass.Name = "txt_edit_nclass"
        Me.txt_edit_nclass.Size = New System.Drawing.Size(161, 20)
        Me.txt_edit_nclass.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ระดับชั้น :"
        '
        'btn_close_class
        '
        Me.btn_close_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_close_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_class.ForeColor = System.Drawing.Color.White
        Me.btn_close_class.Location = New System.Drawing.Point(384, 621)
        Me.btn_close_class.Name = "btn_close_class"
        Me.btn_close_class.Size = New System.Drawing.Size(121, 33)
        Me.btn_close_class.TabIndex = 27
        Me.btn_close_class.Text = "ออก"
        Me.btn_close_class.UseVisualStyleBackColor = False
        '
        'FrmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 674)
        Me.Controls.Add(Me.btn_close_class)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_Class)
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
        Me.Name = "FrmClass"
        Me.Text = "FrmClass"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Class, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_left As System.Windows.Forms.Panel
    Friend WithEvents Panel_right As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents Panel_top As System.Windows.Forms.Panel
    Friend WithEvents Panel_left1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_right1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_top2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom1 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_menu As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Class As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_add_dep As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_add_class As System.Windows.Forms.Button
    Friend WithEvents txt_add_nclass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_close_class As System.Windows.Forms.Button
    Friend WithEvents cbb_edit_dep As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_edit_class As System.Windows.Forms.Button
    Friend WithEvents txt_edit_nclass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete_class As System.Windows.Forms.Button
End Class
