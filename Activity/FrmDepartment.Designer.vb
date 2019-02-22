<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartment
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
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.Panel_bottom = New System.Windows.Forms.Panel()
        Me.Panel_right = New System.Windows.Forms.Panel()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.Panel_top2 = New System.Windows.Forms.Panel()
        Me.Panel_bottom1 = New System.Windows.Forms.Panel()
        Me.Panel_left1 = New System.Windows.Forms.Panel()
        Me.Panel_right1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_menu = New System.Windows.Forms.Label()
        Me.DataGridView_Class = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_add_class = New System.Windows.Forms.Button()
        Me.txt_add_dep_n = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delete_dep = New System.Windows.Forms.Button()
        Me.txt_edit_dep_n = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_edit_dep = New System.Windows.Forms.Button()
        Me.btn_close_class = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Class, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(617, 10)
        Me.Panel_top.TabIndex = 3
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 622)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(617, 10)
        Me.Panel_bottom.TabIndex = 4
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(607, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 612)
        Me.Panel_right.TabIndex = 8
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 612)
        Me.Panel_left.TabIndex = 9
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(597, 10)
        Me.Panel_top2.TabIndex = 16
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 612)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(597, 10)
        Me.Panel_bottom1.TabIndex = 15
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 592)
        Me.Panel_left1.TabIndex = 18
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(597, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 592)
        Me.Panel_right1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.lb_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 74)
        Me.Panel1.TabIndex = 19
        '
        'lb_menu
        '
        Me.lb_menu.AutoSize = True
        Me.lb_menu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_menu.ForeColor = System.Drawing.Color.White
        Me.lb_menu.Location = New System.Drawing.Point(275, 21)
        Me.lb_menu.Name = "lb_menu"
        Me.lb_menu.Size = New System.Drawing.Size(51, 25)
        Me.lb_menu.TabIndex = 0
        Me.lb_menu.Text = "สาขา"
        '
        'DataGridView_Class
        '
        Me.DataGridView_Class.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Class.Location = New System.Drawing.Point(20, 104)
        Me.DataGridView_Class.Name = "DataGridView_Class"
        Me.DataGridView_Class.Size = New System.Drawing.Size(386, 508)
        Me.DataGridView_Class.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 10)
        Me.Panel2.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_add_class)
        Me.GroupBox1.Controls.Add(Me.txt_add_dep_n)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(413, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 99)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพิ่มสาขา"
        '
        'btn_add_class
        '
        Me.btn_add_class.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_add_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_class.ForeColor = System.Drawing.Color.White
        Me.btn_add_class.Location = New System.Drawing.Point(60, 48)
        Me.btn_add_class.Name = "btn_add_class"
        Me.btn_add_class.Size = New System.Drawing.Size(112, 39)
        Me.btn_add_class.TabIndex = 7
        Me.btn_add_class.Text = "เพิ่ม"
        Me.btn_add_class.UseVisualStyleBackColor = False
        '
        'txt_add_dep_n
        '
        Me.txt_add_dep_n.Location = New System.Drawing.Point(60, 22)
        Me.txt_add_dep_n.Name = "txt_add_dep_n"
        Me.txt_add_dep_n.Size = New System.Drawing.Size(112, 20)
        Me.txt_add_dep_n.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อสาขา :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delete_dep)
        Me.GroupBox2.Controls.Add(Me.txt_edit_dep_n)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_edit_dep)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 146)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "แก้ไขสาขา"
        '
        'btn_delete_dep
        '
        Me.btn_delete_dep.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete_dep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_dep.ForeColor = System.Drawing.Color.White
        Me.btn_delete_dep.Location = New System.Drawing.Point(60, 101)
        Me.btn_delete_dep.Name = "btn_delete_dep"
        Me.btn_delete_dep.Size = New System.Drawing.Size(112, 39)
        Me.btn_delete_dep.TabIndex = 10
        Me.btn_delete_dep.Text = "ลบ"
        Me.btn_delete_dep.UseVisualStyleBackColor = False
        '
        'txt_edit_dep_n
        '
        Me.txt_edit_dep_n.Location = New System.Drawing.Point(60, 29)
        Me.txt_edit_dep_n.Name = "txt_edit_dep_n"
        Me.txt_edit_dep_n.Size = New System.Drawing.Size(112, 20)
        Me.txt_edit_dep_n.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ชื่อสาขา :"
        '
        'btn_edit_dep
        '
        Me.btn_edit_dep.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_edit_dep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_dep.ForeColor = System.Drawing.Color.White
        Me.btn_edit_dep.Location = New System.Drawing.Point(60, 55)
        Me.btn_edit_dep.Name = "btn_edit_dep"
        Me.btn_edit_dep.Size = New System.Drawing.Size(112, 39)
        Me.btn_edit_dep.TabIndex = 7
        Me.btn_edit_dep.Text = "บันทึก"
        Me.btn_edit_dep.UseVisualStyleBackColor = False
        '
        'btn_close_class
        '
        Me.btn_close_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_close_class.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_class.ForeColor = System.Drawing.Color.White
        Me.btn_close_class.Location = New System.Drawing.Point(476, 579)
        Me.btn_close_class.Name = "btn_close_class"
        Me.btn_close_class.Size = New System.Drawing.Size(121, 33)
        Me.btn_close_class.TabIndex = 24
        Me.btn_close_class.Text = "ออก"
        Me.btn_close_class.UseVisualStyleBackColor = False
        '
        'FrmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 632)
        Me.Controls.Add(Me.btn_close_class)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
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
        Me.Name = "FrmDepartment"
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
    Friend WithEvents Panel_top As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents Panel_right As System.Windows.Forms.Panel
    Friend WithEvents Panel_left As System.Windows.Forms.Panel
    Friend WithEvents Panel_top2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottom1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_left1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_right1 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_menu As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Class As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_add_dep_n As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_add_class As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_edit_dep As System.Windows.Forms.Button
    Friend WithEvents btn_close_class As System.Windows.Forms.Button
    Friend WithEvents txt_edit_dep_n As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_delete_dep As System.Windows.Forms.Button
End Class
