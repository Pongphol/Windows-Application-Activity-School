Imports MySql.Data.MySqlClient
Public Class FrmDepartment


    Dim keepvalue_dep_id As Integer
    '======================================================================
    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub refresh_all_data_user()
        sql = "select dep_n from tbl_department"
        DataGridView_Class.DataSource = cmd_dataTable()
    End Sub

    'Private Sub searching()
    '  sql = "select * from tbl_users where user_id like '%" & txt_search_user.Text & "%' or username like '%" & txt_search_user.Text & "%' or password like '%" & txt_search_user.Text & "%' or status like '%" & txt_search_user.Text & "%'"
    ' DataGridView_edit_user.DataSource = cmd_dataTable()
    ' End Sub

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
        Dim headertxt() As String = {"ชื่อสาขา"}
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

    Private Sub btn_close_class_Click(sender As Object, e As EventArgs) Handles btn_close_class.Click
        Me.Close()
    End Sub

    Private Sub btn_add_teach_Click(sender As Object, e As EventArgs) Handles btn_add_class.Click
        If txt_add_dep_n.Text = "" Then
            MsgBox("กรุณาใส่ชื่อสาขา", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        sql = "select count(*) from tbl_department where dep_n='" & txt_add_dep_n.Text.Trim & "'"
        If cmd_excuteunique() > 0 Then
            MsgBox("ไม่สามารถตั้งชื่อซ้ำกันได้", MsgBoxStyle.Exclamation, "Message")
            txt_add_dep_n.Select()
            Return
        End If

        Try
            connectdb()
            Dim nclass As String = txt_add_dep_n.Text.Trim
            sql = "insert into tbl_department (dep_n) values (@dep_n)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dep_n", nclass)

            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("ไม่สามารถเพิ่มได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เพิ่มสาขา : " + nclass)
                cmd.ExecuteNonQuery()

                MsgBox("เพิ่มสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                txt_add_dep_n.Text = ""
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FrmClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select dep_n from tbl_department"
        DataGridView_Class.DataSource = cmd_dataTable()
        change_all_column()
        Set_DTG_edit_user()

        txt_edit_dep_n.Enabled = False


    End Sub

    Private Sub DataGridView_Class_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Class.CellClick
        Dim i As Integer = DataGridView_Class.CurrentRow.Index
        Try
            txt_edit_dep_n.Text = DataGridView_Class.Item(0, i).Value
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & txt_edit_dep_n.Text.Trim & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

        txt_edit_dep_n.Enabled = True
    End Sub

    Private Sub btn_edit_dep_Click(sender As Object, e As EventArgs) Handles btn_edit_dep.Click
        Try

            If txt_edit_dep_n.Text = "" Then
                MsgBox("กรุณาเลือกข้อมูล", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            sql = "select count(*) from tbl_department where dep_n='" & txt_edit_dep_n.Text.Trim & "'"
            If cmd_excuteunique() > 0 Then
                MsgBox("ไม่สามารถตั้งชื่อซ้ำกันได้", MsgBoxStyle.Exclamation, "Message")
                txt_add_dep_n.Select()
                Return
            End If

            sql = "update tbl_department set dep_n='" & txt_edit_dep_n.Text.Trim & "' where dep_id='" & keepvalue_dep_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถบันทึกได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "แก้ไขสาขา : " + DataGridView_Class.Item(0, DataGridView_Class.CurrentRow.Index).Value + " | เป็นสาขา : " + txt_edit_dep_n.Text)
                cmd.ExecuteNonQuery()

                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_delete_dep_Click(sender As Object, e As EventArgs) Handles btn_delete_dep.Click
        If MessageBox.Show("คุณต้องการจะลบสาขา : " + DataGridView_Class.Item(0, DataGridView_Class.CurrentRow.Index).Value, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                          , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_department where dep_id='" & keepvalue_dep_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบสาขา : " + DataGridView_Class.Item(0, DataGridView_Class.CurrentRow.Index).Value)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                txt_edit_dep_n.Text = ""
            End If
        Else
            Return
        End If
    End Sub
End Class