Imports MySql.Data.MySqlClient
Public Class Frmadd_user
    Dim sql As String

    'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer

    '======================================================================

    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub


    Private Sub refresh_all_data_user()
        sql = "select user_id,username,password,status from tbl_users"
        DataGridView_edit_user.DataSource = cmd_dataTable()
    End Sub

    Private Sub searching()
        sql = "select user_id,username,password,status from tbl_users where user_id like '%" & txt_search_user.Text & "%' or username like '%" & txt_search_user.Text & "%' or password like '%" & txt_search_user.Text & "%' or status like '%" & txt_search_user.Text & "%'"
        DataGridView_edit_user.DataSource = cmd_dataTable()
    End Sub

    Private Sub change_column_datagrid(ByVal datagrid As DataGridView, ByVal headerstr() As String)
        Dim datagrid_column_total As Integer = datagrid.Columns.Count
        For i As Integer = 0 To datagrid_column_total - 1
            datagrid.Columns(i).HeaderText = headerstr(i)

            DataGridView_edit_user.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_edit_user.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataGridView_edit_user.GridColor = Color.Black
            DataGridView_edit_user.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_edit_user.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_edit_user.CellBorderStyle = DataGridViewCellBorderStyle.None

        Next

    End Sub

    Private Sub change_all_column()
        Dim headertxt() As String = {"User ID", "Username", "Password", "สถานะ"}
        change_column_datagrid(DataGridView_edit_user, headertxt)
    End Sub

    Friend Function cmd_dataTable()
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "table")
        Return ds.Tables("table")
    End Function

    Friend Function cmd_excuteunique()
        connectdb()
        cmd = New MySqlCommand(sql, conn)
        Return cmd.ExecuteScalar
    End Function

    Friend Function cmd_excuteNonquery()
        connectdb()
        cmd = New MySqlCommand(sql, conn)
        Return cmd.ExecuteNonQuery
        
    End Function

    '======================================================================

    Private Sub Set_DTG_edit_user()
        With DataGridView_edit_user
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = True
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .AllowUserToResizeColumns = False
            .ColumnHeadersHeightSizeMode = _
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .AllowUserToResizeRows = False
            .RowHeadersWidthSizeMode = _
            DataGridViewRowHeadersWidthSizeMode.DisableResizing

            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = SystemColors.ActiveBorder
            .RowHeadersVisible = False
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 167, 240)
        End With

    End Sub


    Private Sub btn_close_adduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close_adduser.Click
        Me.Close()
    End Sub

    Private Sub btn_adduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adduser.Click


        If txt_add_username.Text = "" Or txt_add_pass_user.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        sql = "select count(*) from tbl_users where username='" & txt_add_username.Text & "'"
        If cmd_excuteunique() > 0 Then
            MsgBox("Username นี้มีอยู่แล้วในระบบ", MsgBoxStyle.Exclamation, "Message")
            txt_add_username.Select()
            Return
        End If

        Try
            Dim statususer As String = "user"
            sql = "insert into tbl_users (username,password,status) values ('" & txt_add_username.Text & "','" & txt_add_pass_user.Text & "','" & statususer & "')"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("เพิ่มข้อมูลไม่สำเร็จ", MsgBoxStyle.Exclamation, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เพิ่มสมาชิก : " + txt_add_username.Text)
                cmd.ExecuteNonQuery()

                MsgBox("ข้อมูลถูกเพิ่มแล้ว", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                txt_add_username.Text = ""
                txt_add_pass_user.Text = ""
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        conn.Close()

    End Sub
    Private Sub btn_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_user.Click
        Try

            If txt_edit_pass.Text = "" Then
                MsgBox("กรุณากำหนดรหัสผ่านด้วย", MsgBoxStyle.Exclamation, "Message")
                Return
            ElseIf txt_edit_pass.Text.Length <= 3 Then
                MsgBox("กรุณาใส่รหัสตั้งแต่ 3 ตัวขึ้นไป", MsgBoxStyle.Exclamation, "Message")
                Return
            End If


            'If txt_edit_pass.Text >= Chr(161) And txt_edit_pass.Text <= Chr(206) Then
            'MsgBox("ไม่สามารถตั้งรหัสเป็นภาษาไทยได้", MsgBoxStyle.Exclamation, "Message")
            'Return
            'End If

            sql = "update tbl_users set password='" & txt_edit_pass.Text.Trim & "' where username='" & txt_edit_username.Text & "'"
            If cmd_excuteNonquery() = 0 Then

                MsgBox("ไม่สามารถบันทึกได้", MsgBoxStyle.Critical, "Message")
            Else
                Dim mycount As Integer = DataGridView_edit_user.CurrentRow.Index

                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "แก้ไขรหัสผ่านสมาชิก : " + DataGridView_edit_user.Item(1, mycount).Value)
                cmd.ExecuteNonQuery()

                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        '' Note: call this from frm's Load event!
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 20
        frm.Location = New Point(x, y)
    End Sub

    Private Sub Frmadd_user_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "select user_id,username,password,status from tbl_users"
        'sql = "select * from tbl_users inner join tbl_activity on tbl_activity.act_id=tbl_users.tbl_activity_act_id"

        DataGridView_edit_user.DataSource = cmd_dataTable()
        change_all_column()
        Set_DTG_edit_user()

        CenterForm(Me) ' Center When Start Form

        'Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        Timer_Search.Enabled = True

        txt_edit_id.Enabled = False
        txt_edit_username.Enabled = False
        txt_edit_status.Enabled = False


    End Sub

    Private Sub btn_search_user_Click(sender As Object, e As EventArgs) Handles btn_search_user.Click
        If txt_search_user.Text = String.Empty Then
            'MsgBox("กรุณาใส่คำที่จะค้นหาด้วย", MsgBoxStyle.Exclamation, "Message")
            sql = "select user_id,username,password,status from tbl_users where user_id like '%" & txt_search_user.Text & "%' or username like '%" & txt_search_user.Text & "%' or password like '%" & txt_search_user.Text & "%' or status like '%" & txt_search_user.Text & "%'"
            DataGridView_edit_user.DataSource = cmd_dataTable()
            Return
        End If
        searching()
    End Sub

    Private Sub DataGridView_edit_user_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_edit_user.CellClick
        Dim i As Integer = DataGridView_edit_user.CurrentRow.Index
        Try

            txt_edit_id.Text = DataGridView_edit_user.Item(0, i).Value
            txt_edit_username.Text = DataGridView_edit_user.Item(1, i).Value
            txt_edit_pass.Text = DataGridView_edit_user.Item(2, i).Value
            txt_edit_status.Text = DataGridView_edit_user.Item(3, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer_Search_Tick(sender As Object, e As EventArgs) Handles Timer_Search.Tick
        If CheckBox_search_user.Checked Then
            searching()
        End If
    End Sub

    Private Sub btn_del_user_Click(sender As Object, e As EventArgs) Handles btn_del_user.Click
        If MessageBox.Show("คุณต้องการจะลบข้อมูลใช่ไหม", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                           , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_users where username='" & txt_edit_username.Text & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบสมาชิก : " + txt_edit_username.Text)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If
        Else
            Return
        End If
    End Sub

    Private Sub txt_edit_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_edit_pass.KeyPress, _
        txt_add_username.KeyPress, txt_add_pass_user.KeyPress
        If Not e.KeyChar Like "[A-Z a-z 0-9]" Then

            e.Handled = True
            If Asc(e.KeyChar) = 8 Then ' Backspace = 8
                e.Handled = False
            End If

        End If

        'Select Case Asc(e.KeyChar)
        'Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
        'e.Handled = False
        'End Select

        ' Select Case Asc(e.KeyChar)
        ' Case 48 To 71
        ' e.Handled = False
        ' Case 65 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
        'e.Handled = False
        '  Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
        ' e.Handled = False
        '    Case Else
        ' e.Handled = True
        ' MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษ")
        ' End Select

    End Sub
End Class