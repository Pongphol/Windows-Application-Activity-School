Imports MySql.Data.MySqlClient
Public Class FrmLogin

    Dim strUser As String = "user"

    Dim x, y As Integer
    Dim newpoint As New Point

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer

    Private Sub connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connect()
        sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
        cmd.Parameters.AddWithValue("@log_date", Date.Now)
        cmd.Parameters.AddWithValue("@log_operation", "ออกจากระบบ")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub



    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        KeyPreview = True

        txtUsername.Text = "fluk"
        txtPassword.Text = "1234"

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Panel2.MouseDown, _
        Panel3.MouseDown, Panel4.MouseDown, Panel5.MouseDown, Panel6.MouseDown, Panel7.MouseDown, Panel8.MouseDown, _
        Panel9.MouseDown, GroupBox_login.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Panel2.MouseMove, _
        Panel3.MouseMove, Panel4.MouseMove, Panel5.MouseMove, Panel6.MouseMove, Panel7.MouseMove, Panel8.MouseMove, _
        Panel9.MouseMove, GroupBox_login.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        sql = "select * from tbl_users where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "datatable")

        If ds.Tables("datatable").Rows.Count <= 0 Then
            MsgBox("ใส่รหัสไม่ถูกต้อง", MsgBoxStyle.Critical, "Message")
        Else
            If ds.Tables("datatable").Rows(0)("status") = "admin" Then
                MsgBox("Welcome Admin " + " : " + txtUsername.Text, MsgBoxStyle.Information)
                Me.Hide()
                FrmAdmin.Show()
            Else
                MsgBox("Welcome User " + " : " + txtUsername.Text, MsgBoxStyle.Information)
                Me.Hide()
                FrmAdmin.Show()
            End If
            Try
                connect()
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", txtUsername.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เข้าสู่ระบบ")
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try
           

        End If
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress, txtPassword.KeyPress
        If Not e.KeyChar Like "[A-Z a-z 0-9]" Then

            e.Handled = True
            If Asc(e.KeyChar) = 8 Then ' Backspace = 8
                e.Handled = False
            End If

        End If
    End Sub
End Class