Imports MySql.Data.MySqlClient
Public Class FrmClass

    Dim keepvalue_dep_id As Integer
    Dim keepvalue_edit_dep_id As Integer
    Dim keepvalue_edit_class_id As Integer
    '======================================================================
    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub refresh_all_data_user()
        sql = "select dep_n,class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id order by class_name asc"
        DataGridView_Class.DataSource = cmd_dataTable()
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

            DataGridView_Class.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_Class.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataGridView_Class.GridColor = Color.Black
            DataGridView_Class.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_Class.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_Class.CellBorderStyle = DataGridViewCellBorderStyle.None

        Next

    End Sub

    Private Sub change_all_column()
        Dim headertxt() As String = {"สาขา", "ระดับชั้น"}
        change_column_datagrid(DataGridView_Class, headertxt)
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
        With DataGridView_Class
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
    Private Sub FrmClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_add_nclass.Enabled = False
        txt_edit_nclass.Enabled = False
        cbb_edit_dep.Enabled = False

        sql = "select dep_n from tbl_department"
        cmd_db_to_obj(cbb_add_dep)
        cbb_add_dep.Text = "กรุณาเลือกสาขา"

        sql = "select dep_n from tbl_department"
        cmd_db_to_obj(cbb_edit_dep)
        cbb_edit_dep.Text = "กรุณาเลือกสาขา"

        'sql = "select * from tbl_department"
        sql = "select dep_n,class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id order by class_name asc"
        DataGridView_Class.DataSource = cmd_dataTable()
        change_all_column()
        Set_DTG_edit_user()

    End Sub

    Private Sub cbb_add_dep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_add_dep.KeyPress, cbb_edit_dep.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbb_add_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_add_dep.SelectedIndexChanged
        txt_add_nclass.Enabled = True

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_add_dep.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_add_class_Click(sender As Object, e As EventArgs) Handles btn_add_class.Click

        If txt_add_nclass.Text = "" Then
            MsgBox("กรุณาใส่ระดับชั้น", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        sql = "select count(*) from tbl_class where class_name='" & txt_add_nclass.Text & "' and dep_id='" & keepvalue_dep_id & "'"
        If cmd_excuteunique() > 0 Then
            MsgBox("ข้อมูลนี้มีอยู่แล้วในระบบ", MsgBoxStyle.Exclamation, "Message")
            txt_add_nclass.Select()
            Return
        End If


        Try
            connectdb()

            sql = "insert into tbl_class (class_name,dep_id) values (@class_name,@dep_id)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("class_name", txt_add_nclass.Text)
            cmd.Parameters.AddWithValue("dep_id", keepvalue_dep_id)

            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("ไม่สามารถเพิ่มได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เพิ่มระดับชั้น : " + txt_add_nclass.Text + " | สาขา : " + cbb_add_dep.Text)
                cmd.ExecuteNonQuery()

                MsgBox("เพิ่มสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                cbb_add_dep.Text = "กรุณาเลือกสาขา"
                txt_add_nclass.Text = ""
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try


    End Sub
    Private Sub DataGridView_Class_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Class.CellClick
        Dim i As Integer = DataGridView_Class.CurrentRow.Index
        Try
            cbb_edit_dep.Text = DataGridView_Class.Item(0, i).Value
            txt_edit_nclass.Text = DataGridView_Class.Item(1, i).Value
        Catch ex As Exception

        End Try
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & txt_edit_nclass.Text & "' and dep_id='" & keepvalue_edit_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_class_id = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbb_edit_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_edit_dep.SelectedIndexChanged
        txt_edit_nclass.Enabled = True
        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_edit_dep.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub btn_close_class_Click(sender As Object, e As EventArgs) Handles btn_close_class.Click
        Me.Close()
    End Sub

    Private Sub btn_edit_class_Click(sender As Object, e As EventArgs) Handles btn_edit_class.Click
        If txt_edit_nclass.Text = "" Then
            MsgBox("กรุณาเลือกข้อมูล", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        sql = "select count(*) from tbl_class where class_name='" & txt_edit_nclass.Text & "' and dep_id='" & keepvalue_edit_dep_id & "'"
        If cmd_excuteunique() > 0 Then
            MsgBox("ข้อมูลนี้มีอยู่แล้วในระบบ", MsgBoxStyle.Exclamation, "Message")
            txt_add_nclass.Select()
            Return
        End If

        Try
            sql = "update tbl_class inner join tbl_department on tbl_class.dep_id=tbl_department.dep_id " +
                "set tbl_class.class_name='" & txt_edit_nclass.Text.Trim & "',tbl_class.dep_id='" & keepvalue_edit_dep_id & "' " +
                "where tbl_class.class_id='" & keepvalue_edit_class_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถบันทึกได้", MsgBoxStyle.Critical, "Message")
            Else
                Dim mycount As Integer = DataGridView_Class.CurrentRow.Index

                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "แก้ไขระดับชั้น : " + DataGridView_Class.Item(1, mycount).Value + " | สาขา : " + DataGridView_Class.Item(0, mycount).Value + " | เป็นระดับชั้น : " + txt_edit_nclass.Text + " | สาขา : " + cbb_edit_dep.Text)
                cmd.ExecuteNonQuery()

                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btn_delete_class_Click(sender As Object, e As EventArgs) Handles btn_delete_class.Click
        If MessageBox.Show("คุณต้องการจะลบระดั้บชั้น : " + txt_edit_nclass.Text, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                           , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_class where class_id='" & keepvalue_edit_class_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                Dim mycount As Integer = DataGridView_Class.CurrentRow.Index

                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบระดับชั้น : " + DataGridView_Class.Item(1, mycount).Value + " | ของสาขา : " + DataGridView_Class.Item(0, mycount).Value)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                cbb_edit_dep.Text = "กรุณาเลือกสาขา"
                txt_edit_nclass.Text = ""
            End If
        Else
            Return
        End If
    End Sub
End Class