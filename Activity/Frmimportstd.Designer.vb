<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmimportstd
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
        Me.DataGridView_import_std = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_import_dep_std = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbb_import_class_std = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_import_std = New System.Windows.Forms.Button()
        Me.btn_close_importstd = New System.Windows.Forms.Button()
        Me.btn_add_import_std = New System.Windows.Forms.Button()
        Me.OpenFileDialog_import_std = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_import_std, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 10)
        Me.Panel2.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.lb_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 74)
        Me.Panel1.TabIndex = 30
        '
        'lb_menu
        '
        Me.lb_menu.AutoSize = True
        Me.lb_menu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_menu.ForeColor = System.Drawing.Color.White
        Me.lb_menu.Location = New System.Drawing.Point(275, 21)
        Me.lb_menu.Name = "lb_menu"
        Me.lb_menu.Size = New System.Drawing.Size(68, 25)
        Me.lb_menu.TabIndex = 0
        Me.lb_menu.Text = "Import"
        '
        'Panel_left1
        '
        Me.Panel_left1.BackColor = System.Drawing.Color.White
        Me.Panel_left1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left1.Location = New System.Drawing.Point(10, 20)
        Me.Panel_left1.Name = "Panel_left1"
        Me.Panel_left1.Size = New System.Drawing.Size(10, 664)
        Me.Panel_left1.TabIndex = 29
        '
        'Panel_right1
        '
        Me.Panel_right1.BackColor = System.Drawing.Color.White
        Me.Panel_right1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right1.Location = New System.Drawing.Point(628, 20)
        Me.Panel_right1.Name = "Panel_right1"
        Me.Panel_right1.Size = New System.Drawing.Size(10, 664)
        Me.Panel_right1.TabIndex = 28
        '
        'Panel_top2
        '
        Me.Panel_top2.BackColor = System.Drawing.Color.White
        Me.Panel_top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top2.Location = New System.Drawing.Point(10, 10)
        Me.Panel_top2.Name = "Panel_top2"
        Me.Panel_top2.Size = New System.Drawing.Size(628, 10)
        Me.Panel_top2.TabIndex = 27
        '
        'Panel_bottom1
        '
        Me.Panel_bottom1.BackColor = System.Drawing.Color.White
        Me.Panel_bottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom1.Location = New System.Drawing.Point(10, 684)
        Me.Panel_bottom1.Name = "Panel_bottom1"
        Me.Panel_bottom1.Size = New System.Drawing.Size(628, 10)
        Me.Panel_bottom1.TabIndex = 26
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 10)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(10, 684)
        Me.Panel_left.TabIndex = 25
        '
        'Panel_right
        '
        Me.Panel_right.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_right.Location = New System.Drawing.Point(638, 10)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(10, 684)
        Me.Panel_right.TabIndex = 24
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 694)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(648, 10)
        Me.Panel_bottom.TabIndex = 23
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(648, 10)
        Me.Panel_top.TabIndex = 22
        '
        'DataGridView_import_std
        '
        Me.DataGridView_import_std.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_import_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_import_std.Location = New System.Drawing.Point(20, 180)
        Me.DataGridView_import_std.Name = "DataGridView_import_std"
        Me.DataGridView_import_std.Size = New System.Drawing.Size(607, 504)
        Me.DataGridView_import_std.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_import_dep_std)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 64)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สาขา"
        '
        'cbb_import_dep_std
        '
        Me.cbb_import_dep_std.FormattingEnabled = True
        Me.cbb_import_dep_std.Location = New System.Drawing.Point(6, 28)
        Me.cbb_import_dep_std.Name = "cbb_import_dep_std"
        Me.cbb_import_dep_std.Size = New System.Drawing.Size(212, 21)
        Me.cbb_import_dep_std.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbb_import_class_std)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 64)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ระดับชั้น"
        '
        'cbb_import_class_std
        '
        Me.cbb_import_class_std.FormattingEnabled = True
        Me.cbb_import_class_std.Location = New System.Drawing.Point(6, 28)
        Me.cbb_import_class_std.Name = "cbb_import_class_std"
        Me.cbb_import_class_std.Size = New System.Drawing.Size(121, 21)
        Me.cbb_import_class_std.TabIndex = 26
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_import_std)
        Me.GroupBox3.Location = New System.Drawing.Point(395, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 64)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Import"
        '
        'btn_import_std
        '
        Me.btn_import_std.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_import_std.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_import_std.ForeColor = System.Drawing.Color.White
        Me.btn_import_std.Location = New System.Drawing.Point(6, 22)
        Me.btn_import_std.Name = "btn_import_std"
        Me.btn_import_std.Size = New System.Drawing.Size(112, 30)
        Me.btn_import_std.TabIndex = 7
        Me.btn_import_std.Text = "เลือก"
        Me.btn_import_std.UseVisualStyleBackColor = False
        '
        'btn_close_importstd
        '
        Me.btn_close_importstd.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_close_importstd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close_importstd.ForeColor = System.Drawing.Color.White
        Me.btn_close_importstd.Location = New System.Drawing.Point(525, 110)
        Me.btn_close_importstd.Name = "btn_close_importstd"
        Me.btn_close_importstd.Size = New System.Drawing.Size(97, 30)
        Me.btn_close_importstd.TabIndex = 36
        Me.btn_close_importstd.Text = "ออก"
        Me.btn_close_importstd.UseVisualStyleBackColor = False
        '
        'btn_add_import_std
        '
        Me.btn_add_import_std.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_add_import_std.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_import_std.ForeColor = System.Drawing.Color.White
        Me.btn_add_import_std.Location = New System.Drawing.Point(525, 144)
        Me.btn_add_import_std.Name = "btn_add_import_std"
        Me.btn_add_import_std.Size = New System.Drawing.Size(97, 30)
        Me.btn_add_import_std.TabIndex = 37
        Me.btn_add_import_std.Text = "บันทึก"
        Me.btn_add_import_std.UseVisualStyleBackColor = False
        '
        'Frmimportstd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 704)
        Me.Controls.Add(Me.btn_add_import_std)
        Me.Controls.Add(Me.btn_close_importstd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_import_std)
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
        Me.Name = "Frmimportstd"
        Me.Text = "Frmimportstd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_import_std, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents DataGridView_import_std As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_import_dep_std As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_import_class_std As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_import_std As System.Windows.Forms.Button
    Friend WithEvents btn_close_importstd As System.Windows.Forms.Button
    Friend WithEvents btn_add_import_std As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_import_std As System.Windows.Forms.OpenFileDialog
End Class
