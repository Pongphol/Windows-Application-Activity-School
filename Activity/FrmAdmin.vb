Imports MySql.Data.MySqlClient
Public Class FrmAdmin

    Private Sub connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub PictureBox_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm_add_user As New Frmadd_user
        frm_add_user.MdiParent = Me
        frm_add_user.Show()
        CenterForm(frm_add_user)
        'frm.Location = New Point(20, 0)
    End Sub

    Private Sub PictureBox_Act_Click(sender As Object, e As EventArgs)
        Dim frm_act As New FrmActivity
        frm_act.MdiParent = Me
        frm_act.Show()
        CenterForm(frm_act)
    End Sub

    Private Sub FrmAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer_check_anyfrm.Enabled = True
        Me.WindowState = FormWindowState.Maximized
        lb_bot_nstatus.Text = FrmLogin.txtUsername.Text
        lb_bot_date.Text = Date.Now

        Me.Text = "ระบบบริหารจัดการกิจการนักศึกษาของวิทยาลัยเทคโนโลยีวิศวกรรมแหลมฉบัง"

        '------------------------Check Status----------------------
        If ds.Tables("datatable").Rows(0)("status") = "admin" Then
            'Admin
        Else
            'User
            'Frm User
            tbtn_user.Visible = False
            ToolStripSeparator1.Visible = False
            'Frm Log
            tbtn_log.Visible = False
            ToolStripSeparator10.Visible = False
        End If

    End Sub

    Private Sub Timer_check_anyfrm_Tick(sender As Object, e As EventArgs) Handles Timer_check_anyfrm.Tick
        Try
            If Application.OpenForms().OfType(Of Frmadd_user).Any Then
                tbtn_user.Enabled = False
            Else
                tbtn_user.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmActivity).Any Then
                tbtn_activity.Enabled = False
            Else
                tbtn_activity.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmTecher).Any Then
                tbtn_teacher.Enabled = False
            Else
                tbtn_teacher.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmDepartment).Any Then
                tbtn_department.Enabled = False
            Else
                tbtn_department.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmClass).Any Then
                tbtn_class.Enabled = False
            Else
                tbtn_class.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmStudent).Any Then
                tbtn_std.Enabled = False
            Else
                tbtn_std.Enabled = True
            End If

            If Application.OpenForms().OfType(Of Frmimportstd).Any Then
                tbtn_import_std.Enabled = False
            Else
                tbtn_import_std.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmCheckstd_act).Any Then
                tbtn_check_std_act.Enabled = False
            Else
                tbtn_check_std_act.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmCheck_std_list_act).Any Then
                tbtn_check_list_std_act.Enabled = False
            Else
                tbtn_check_list_std_act.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmSplit_list_act).Any Then
                tbtn_split_act.Enabled = False
            Else
                tbtn_split_act.Enabled = True
            End If

            If Application.OpenForms().OfType(Of FrmLog).Any Then
                tbtn_log.Enabled = False
            Else
                tbtn_log.Enabled = True
            End If


        Catch ex As Exception

        End Try

    End Sub



    Private Sub tbtn_user_Click(sender As Object, e As EventArgs) Handles tbtn_user.Click
        Dim frm_add_user As New Frmadd_user
        frm_add_user.MdiParent = Me
        frm_add_user.Show()
        CenterForm(frm_add_user)
    End Sub

    Private Sub tbtn_activity_Click(sender As Object, e As EventArgs) Handles tbtn_activity.Click
        Dim frm_act As New FrmActivity
        frm_act.MdiParent = Me
        frm_act.Show()
        CenterForm(frm_act)
    End Sub



    Private Sub tbtn_department_Click(sender As Object, e As EventArgs) Handles tbtn_department.Click
        Dim frm_dep As New FrmDepartment
        frm_dep.MdiParent = Me
        frm_dep.Show()
        CenterForm(frm_dep)
    End Sub

    Private Sub tbtn_class_Click(sender As Object, e As EventArgs) Handles tbtn_class.Click
        Dim frm_class As New FrmClass
        frm_class.MdiParent = Me
        frm_class.Show()
        CenterForm(frm_class)
    End Sub

    Private Sub tbtn_std_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtn_std.Click
        Dim frm_std As New FrmStudent
        frm_std.MdiParent = Me
        frm_std.Show()
        CenterForm(frm_std)
    End Sub

    Private Sub tbtn_import_std_Click(sender As Object, e As EventArgs) Handles tbtn_import_std.Click
        Dim frm_import_std As New Frmimportstd
        frm_import_std.MdiParent = Me
        frm_import_std.Show()
        CenterForm(frm_import_std)
    End Sub

    Private Sub tbtn_teacher_Click(sender As Object, e As EventArgs) Handles tbtn_teacher.Click
        Dim frm_teacher As New FrmTecher
        frm_teacher.MdiParent = Me
        frm_teacher.Show()
        CenterForm(frm_teacher)
    End Sub

    Private Sub tbtn_check_std_act_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtn_check_std_act.Click
        Dim frm_check_std_act As New FrmCheckstd_act
        frm_check_std_act.MdiParent = Me
        frm_check_std_act.Show()
        CenterForm(frm_check_std_act)
    End Sub

    Private Sub tbtn_check_list_std_act_Click(sender As Object, e As EventArgs) Handles tbtn_check_list_std_act.Click
        Dim frm_chek_std_list_act As New FrmCheck_std_list_act
        frm_chek_std_list_act.MdiParent = Me
        frm_chek_std_list_act.Show()
        CenterForm(frm_chek_std_list_act)
    End Sub

    Private Sub tbtn_split_act_Click(sender As Object, e As EventArgs) Handles tbtn_split_act.Click
        Dim frm_split_act As New FrmSplit_list_act
        frm_split_act.MdiParent = Me
        frm_split_act.Show()
        CenterForm(frm_split_act)
    End Sub

    Private Sub tbtn_log_Click(sender As Object, e As EventArgs) Handles tbtn_log.Click
        Dim frm_log As New FrmLog
        frm_log.MdiParent = Me
        frm_log.Show()
        CenterForm(frm_log)
    End Sub

    Private Sub tbtn_logout_Click(sender As Object, e As EventArgs) Handles tbtn_logout.Click
        If MessageBox.Show("คุณต้องการออกโปรแกรมใช่ไหม", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            connect()
            sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@log_user", Me.lb_bot_nstatus.Text)
            cmd.Parameters.AddWithValue("@log_date", Date.Now)
            cmd.Parameters.AddWithValue("@log_operation", "ออกจากระบบ")
            cmd.ExecuteNonQuery()
            conn.Close()
            Application.Exit()
        Else

        End If
    End Sub
End Class
