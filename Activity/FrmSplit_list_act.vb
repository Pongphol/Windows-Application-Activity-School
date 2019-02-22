Imports MySql.Data.MySqlClient
Public Class FrmSplit_list_act

    Dim keepvalue_search_act_id As Integer

    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub refresh_all_data_user()
        sql = ""
        DataGridView_Split.DataSource = cmd_dataTable()
    End Sub

    Private Sub searching()
       
    End Sub

    Friend Sub cmd_db_to_obj(ByVal obj As Object)
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

            DataGridView_Split.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_Split.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ' DataGridView_check_std_act.Columns(i).Width = 300

            DataGridView_Split.GridColor = Color.Black
            DataGridView_Split.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_Split.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_Split.CellBorderStyle = DataGridViewCellBorderStyle.None


        Next

        'Dim chk As New DataGridViewCheckBoxColumn() With {.HeaderText = "SELECT", .Name = "status_std_act", _
        '.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, _
        '.FlatStyle = FlatStyle.Standard, .ThreeState = False}
        'DataGridView_check_std_not_join_act.Columns.Insert(0, chk)
    End Sub


    Private Sub change_all_column()
        Dim headertxt() As String = {"สาขา", "ระดับชั้น"}
        change_column_datagrid(DataGridView_Split, headertxt)
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
        With DataGridView_Split
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

    Private Sub btn_close_frm_split_Click(sender As Object, e As EventArgs) Handles btn_close_frm_split.Click
        Me.Close()
    End Sub

    Private Sub FrmSplit_list_act_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "select n_act from tbl_activity"
            cmd_db_to_obj(cbb_search_act)
            cbb_search_act.Text = "กรุณาเลือกกิจกรรม"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_confirm_search_split_Click(sender As Object, e As EventArgs) Handles btn_confirm_search_split.Click
        Try
            If cbb_search_act.Text = "กรุณาเลือกกิจกรรม" Then
                MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            If btn_confirm_search_split.Text = "ยืนยัน" Then
                cbb_search_act.Enabled = False
                btn_confirm_search_split.Text = "ยกเลิก"
                sql = "select distinct tbl_department.dep_n,tbl_class.class_name from tbl_class " +
                        "left join tbl_check_std_act on tbl_check_std_act.class_id=tbl_class.class_id " +
                        "inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id " +
                        "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "'"
                DataGridView_Split.DataSource = cmd_dataTable()
                change_all_column()
                Set_DTG_edit_user()
                
            ElseIf btn_confirm_search_split.Text = "ยกเลิก" Then
                DataGridView_Split.DataSource = Nothing
                cbb_search_act.Enabled = True
                btn_confirm_search_split.Text = "ยืนยัน"
            End If

            

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub cbb_search_act_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_search_act.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbb_search_act_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_search_act.SelectedIndexChanged
        Try
            connectdb()
            sql = "select act_id from tbl_activity where n_act='" & cbb_search_act.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_act_id = dr.GetInt32("act_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class