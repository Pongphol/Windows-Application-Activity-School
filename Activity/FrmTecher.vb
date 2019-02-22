Imports MySql.Data.MySqlClient
Public Class FrmTecher

    Dim keepvalue_add_dep As Integer
    Dim keepvalue_add_class As Integer
    Dim keepvalue_edit_dep As Integer
    Dim keepvalue_edit_class As Integer
    Dim keepvalue_edit_teach_id As Integer
    '======================================================================
    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub refresh_all_data_user()
        sql = "select teacher_fname,teacher_lname,class_name,dep_n from tbl_teacher inner join " +
            "tbl_class on tbl_class.class_id=tbl_teacher.class_id inner join " +
            "tbl_department on tbl_department.dep_id=tbl_teacher.dep_id"

        DataGridView_teacher.DataSource = cmd_dataTable()
    End Sub

    'Private Sub searching()
    '  sql = "select * from tbl_users where user_id like '%" & txt_search_user.Text & "%' or username like '%" & txt_search_user.Text & "%' or password like '%" & txt_search_user.Text & "%' or status like '%" & txt_search_user.Text & "%'"
    ' DataGridView_edit_user.DataSource = cmd_dataTable()
    ' End Sub

    Friend Sub cmd_db_to_obj(obj As Object)
        connectdb()
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        obj.items.clear()
        While dr.Read
            obj.items.add(dr(0))
        End While
        dr.Close()
    End Sub

    Private Sub change_column_datagrid(ByVal datagrid As DataGridView, ByVal headerstr1() As String)
        Dim datagrid_column_total As Integer = datagrid.Columns.Count
        For i As Integer = 0 To datagrid_column_total - 1
            datagrid.Columns(i).HeaderText = headerstr1(i)

            DataGridView_teacher.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_teacher.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataGridView_teacher.GridColor = Color.Black
            DataGridView_teacher.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_teacher.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_teacher.CellBorderStyle = DataGridViewCellBorderStyle.None

        Next

    End Sub

    Private Sub change_all_column()
        Dim headertxt() As String = {"รหัสอาจารย์", "ชื่ออาจารย์", "ระดับชั้นที่ปรึกษา"}
        change_column_datagrid(DataGridView_teacher, headertxt)
    End Sub
    Private Sub change_all_column_join()
        Dim headertxt() As String = {"ชื่อ", "นามสกุล", "ระดั้บชั้นที่ปรึกษา", "สาขา"}
        change_column_datagrid(DataGridView_teacher, headertxt)
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
        With DataGridView_teacher
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
    '======================================================================

    Private Sub Frmadd_techer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "select dep_n from tbl_department"
        cmd_db_to_obj(cbb_add_dep_teach)
        cbb_add_dep_teach.Text = "กรุณาเลือกสาขา"

        sql = "select class_name from tbl_class"
        cmd_db_to_obj(cbb_add_class_teach)
        cbb_add_class_teach.Text = "กรุณาเลือกระดับชั้น"

        sql = "select dep_n from tbl_department"
        cmd_db_to_obj(cbb_edit_dep_teach)
        cbb_edit_dep_teach.Text = "กรุณาเลือกสาขา"

        sql = "select class_name from tbl_class"
        cmd_db_to_obj(cbb_edit_class_teach)
        cbb_edit_class_teach.Text = "กรุณาเลือกระดับชั้น"


        sql = "select teacher_fname,teacher_lname,class_name,dep_n from tbl_teacher inner join " +
            "tbl_class on tbl_class.class_id=tbl_teacher.class_id inner join " +
            "tbl_department on tbl_department.dep_id=tbl_teacher.dep_id"

        DataGridView_teacher.DataSource = cmd_dataTable()
        change_all_column_join()
        ' change_all_column()
        Set_DTG_edit_user()

        cbb_add_class_teach.Enabled = False
        cbb_edit_class_teach.Enabled = False
        cbb_edit_dep_teach.Enabled = False

        txt_add_fteach.Enabled = False
        txt_add_lteach.Enabled = False

        txt_edit_fteach.Enabled = False
        txt_edit_lteach.Enabled = False

    End Sub

    Private Sub btn_add_teach_Click(sender As Object, e As EventArgs) Handles btn_add_teach.Click

        If txt_add_fteach.Text = "" And txt_add_lteach.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        If cbb_add_class_teach.Text = "กรุณาเลือกระดับชั้น" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        Try
            'sql = "select count(*) from tbl_teacher where teacher_fname='" & txt_add_fteach.Text.Trim & "' and teacher_lname='" & txt_add_lteach.Text.Trim & "' " +
            '"and class_id='" & keepvalue_add_class & "' and dep_id='" & keepvalue_add_dep & "'"
            sql = "select count(*) from tbl_teacher where class_id='" & keepvalue_add_class & "' and dep_id='" & keepvalue_add_dep & "'"
            If cmd_excuteunique() > 0 Then
                MsgBox("ไม่สามารถเพิ่มข้อมูลได้", MsgBoxStyle.Exclamation, "Message")
                txt_add_fteach.Select()
                Return
            End If
        Catch ex As Exception

        End Try

        Try
            connectdb()
            Dim fnameteach As String = txt_add_fteach.Text.Trim
            Dim lnameteach As String = txt_add_lteach.Text.Trim

            sql = "insert into tbl_teacher (teacher_fname,teacher_lname,class_id,dep_id) values (@teacher_fname,@teacher_lname,@class_id,@dep_id)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("teacher_fname", fnameteach)
            cmd.Parameters.AddWithValue("teacher_lname", lnameteach)
            cmd.Parameters.AddWithValue("class_id", keepvalue_add_class)
            cmd.Parameters.AddWithValue("dep_id", keepvalue_add_dep)

            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("ไม่สามารถเพิ่มได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เพิ่มอาจารย์ที่ปรึกษาสาขา : " + cbb_add_dep_teach.Text + " | ระดับชั้น : " + cbb_add_class_teach.Text)
                cmd.ExecuteNonQuery()

                MsgBox("เพิ่มสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                txt_add_fteach.Text = ""
                txt_add_lteach.Text = ""
            End If

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Message")
        End Try

    End Sub


    Private Sub btn_close_teacher_Click(sender As Object, e As EventArgs) Handles btn_close_teacher.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_teacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_teacher.CellClick

        Try
            Dim i As Integer = DataGridView_teacher.CurrentRow.Index
            txt_edit_fteach.Text = DataGridView_teacher.Item(0, i).Value
            txt_edit_lteach.Text = DataGridView_teacher.Item(1, i).Value
            cbb_edit_class_teach.Text = DataGridView_teacher.Item(2, i).Value
            cbb_edit_dep_teach.Text = DataGridView_teacher.Item(3, i).Value
        Catch ex As Exception

        End Try


        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_edit_class_teach.Text & "' and dep_id='" & keepvalue_edit_dep & "'"

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_class = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select teacher_id from tbl_teacher where class_id='" & keepvalue_edit_class & "' and dep_id='" & keepvalue_edit_dep & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_teach_id = dr.GetInt32("teacher_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

        cbb_edit_class_teach.Enabled = False
        cbb_edit_dep_teach.Enabled = False

    End Sub

    Private Sub cbb_add_dep_teach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_add_dep_teach.KeyPress, cbb_add_class_teach.KeyPress, _
        cbb_edit_dep_teach.KeyPress, cbb_edit_class_teach.KeyPress
        ' e.KeyChar = String.Empty
        e.Handled = True
    End Sub

    Private Sub cbb_add_dep_teach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_add_dep_teach.SelectedIndexChanged
        cbb_add_class_teach.Text = "กรุณาเลือกระดับชั้น"
        cbb_add_class_teach.Enabled = True
        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_add_dep_teach.Text & "'"
            cmd_db_to_obj(cbb_add_class_teach)
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_add_dep_teach.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_add_dep = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_add_class_teach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_add_class_teach.SelectedIndexChanged
        txt_add_fteach.Enabled = True
        txt_add_lteach.Enabled = True
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_add_class_teach.Text & "' and dep_id='" & keepvalue_add_dep & "'"

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_add_class = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbb_edit_dep_teach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_edit_dep_teach.SelectedIndexChanged
        'cbb_edit_class_teach.Text = "กรุณาเลือกระดับชั้น"
        'cbb_edit_class_teach.Enabled = True
        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_edit_dep_teach.Text & "'"
            cmd_db_to_obj(cbb_edit_class_teach)
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_edit_dep_teach.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_dep = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_edit_class_teach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_edit_class_teach.SelectedIndexChanged
        txt_edit_fteach.Enabled = True
        txt_edit_lteach.Enabled = True
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_edit_class_teach.Text & "' and dep_id='" & keepvalue_edit_dep & "'"

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_class = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select teacher_id from tbl_teacher where class_id='" & keepvalue_edit_class & "' and dep_id='" & keepvalue_edit_dep & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_teach_id = dr.GetInt32("teacher_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btn_edit_teach_Click(sender As Object, e As EventArgs) Handles btn_edit_teach.Click
        Try
            If txt_edit_fteach.Text = "" Or txt_edit_lteach.Text = "" Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            sql = "select count(*) from tbl_teacher where teacher_fname='" & txt_edit_fteach.Text.Trim & "' and teacher_lname='" & txt_edit_lteach.Text.Trim & "' " +
                "and class_id='" & keepvalue_edit_class & "' and dep_id='" & keepvalue_edit_dep & "'"
            If cmd_excuteunique() > 0 Then
                MsgBox("ไม่สามารถตั้งชื่อซ้ำกันได้", MsgBoxStyle.Exclamation, "Message")
                txt_add_fteach.Select()
                Return
            End If

            sql = "update tbl_teacher set teacher_fname='" & txt_edit_fteach.Text.Trim & "',teacher_lname='" & txt_edit_lteach.Text.Trim & "'," +
            "class_id='" & keepvalue_edit_class & "',dep_id='" & keepvalue_edit_dep & "' where teacher_id='" & keepvalue_edit_teach_id & "'"

            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถบันทึกได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "แก้ไขข้อมูลอาจารย์ที่ปรึกษาสาขา : " + cbb_edit_dep_teach.Text + " | ระดับชั้น : " + cbb_edit_class_teach.Text)
                cmd.ExecuteNonQuery()

                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub btn_delete_teach_Click(sender As Object, e As EventArgs) Handles btn_delete_teach.Click
        If MessageBox.Show("คุณต้องการจะลบข้อมูลนี้ใช่ไหม", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                          , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_teacher where teacher_id='" & keepvalue_edit_teach_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบอาจารย์ที่ปรึกษาสาขา : " + cbb_edit_dep_teach.Text + " | ระดับชั้น : " + cbb_edit_class_teach.Text)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                cbb_edit_dep_teach.Text = "กรุณาเลือกสาขา"
                cbb_edit_class_teach.Text = "กรุณาเลือกระดับชั้น"
                txt_edit_fteach.Text = ""
                txt_edit_lteach.Text = ""
            End If
        Else
            Return
        End If
    End Sub
End Class