Imports MySql.Data.MySqlClient
Public Class FrmLog

    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub refresh_all_data_user()
        sql = "select log_user,log_date,log_operation from tbl_log"
        DataGridView_log.DataSource = cmd_dataTable()
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

            DataGridView_log.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_log.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ' DataGridView_check_std_act.Columns(i).Width = 300

            DataGridView_log.GridColor = Color.Black
            DataGridView_log.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_log.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_log.CellBorderStyle = DataGridViewCellBorderStyle.None


        Next

        'Dim chk As New DataGridViewCheckBoxColumn() With {.HeaderText = "SELECT", .Name = "status_std_act", _
        '.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, _
        '.FlatStyle = FlatStyle.Standard, .ThreeState = False}
        'DataGridView_check_std_not_join_act.Columns.Insert(0, chk)
    End Sub


    Private Sub change_all_column()
        Dim headertxt() As String = {"Log"}
        change_column_datagrid(DataGridView_log, headertxt)
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
        With DataGridView_log
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

            '.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 227, 167)


            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(0).HeaderText = "ผู้ใช้"
            .Columns(1).HeaderText = "เวลา"
            .Columns(2).HeaderText = "การดำเนินงาน"

            .Columns(2).Width = 405

            .EnableHeadersVisualStyles = False ' Set the property EnableHeadersVisualStyles to False | back color to the color 


            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 110, 123)
            '.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 51, 153)


        End With
    End Sub

    Private Sub FrmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select log_user,log_date,log_operation from tbl_log"
        DataGridView_log.DataSource = cmd_dataTable()
        Set_DTG_edit_user()
    End Sub


    Private Sub btn_reset_id_log_Click(sender As Object, e As EventArgs) Handles btn_reset_id_log.Click
        Try
            If MessageBox.Show("คุณต้องการล้างประวัติการใช้งาน", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
                         , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                sql = "delete from tbl_log"
                If cmd_excuteNonquery() = 0 Then
                    MsgBox("ไม่สามารถล้างประวัติการใช้งานได้", MsgBoxStyle.Exclamation, "Message")
                Else
                    sql = "ALTER TABLE tbl_log AUTO_INCREMENT = 1"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.Clear()
                    cmd.ExecuteNonQuery()

                    MsgBox("ล้างประวัติการใช้งานเรียบร้อย", MsgBoxStyle.Information, "Message")
                    refresh_all_data_user()
                End If
            Else
                Return
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_close_frm_log_Click(sender As Object, e As EventArgs) Handles btn_close_frm_log.Click
        Me.Close()
    End Sub
End Class