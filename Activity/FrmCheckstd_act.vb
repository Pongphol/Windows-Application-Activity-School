Imports MySql.Data.MySqlClient
Public Class FrmCheckstd_act

    Dim keepvalue_search_act_id As Integer
    Dim keepvalue_search_dep_id As Integer
    Dim keepvalue_search_class_id As Integer

    Dim keepvalue_status As String

    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub refresh_all_data_user()
        sql = "select std_id,std_title,std_fname,std_lname from tbl_student"
        DataGridView_check_std_act.DataSource = cmd_dataTable()
    End Sub

    Private Sub searching()
        sql = "select std_fname, std_lname,class_name,dep_n,status_std from tbl_check_std_act inner join tbl_class on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
            "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
            "where tbl_student.dep_id like '%" & keepvalue_search_dep_id & "%' and tbl_student.class_id like '%" & keepvalue_search_class_id & "%'"
        DataGridView_check_std_act.DataSource = cmd_dataTable()
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

            DataGridView_check_std_act.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_check_std_act.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ' DataGridView_check_std_act.Columns(i).Width = 300

            DataGridView_check_std_act.GridColor = Color.Black
            DataGridView_check_std_act.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_check_std_act.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_check_std_act.CellBorderStyle = DataGridViewCellBorderStyle.None

            

        Next
       


    End Sub


    Private Sub change_all_column()
        Dim headertxt() As String = {"รหัสนักศึกษา", "คำนำหน้าชื่อ", "ชื่อ", "นามสกุล", "เข้าร่วมกิจกรรม"}
        change_column_datagrid(DataGridView_check_std_act, headertxt)
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
        With DataGridView_check_std_act
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = True
            .ReadOnly = False
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

    Private Sub FrmCheckstd_act_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        Try
            sql = "select n_act from tbl_activity"
            cmd_db_to_obj(cbb_search_check_act)
            cbb_search_check_act.Text = "กรุณาเลือกกิจกรรม"

            sql = "select dep_n from tbl_department"
            cmd_db_to_obj(cbb_search_check_dep)
            cbb_search_check_dep.Text = "กรุณาเลือกสาขา"

            sql = "select class_name from tbl_class"
            cmd_db_to_obj(cbb_search_check_class)
            cbb_search_check_class.Text = "กรุณาเลือกระดับชั้น"

            'sql = "select std_id,std_title,std_fname,std_lname from tbl_student"
            'DataGridView_check_std_act.DataSource = cmd_dataTable()
            'change_all_column()
            'Set_DTG_edit_user()
        Catch ex As Exception

        End Try
        

        cbb_search_check_dep.Enabled = False
        cbb_search_check_class.Enabled = False
    End Sub

    Private Sub cbb_search_check_act_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbb_search_check_act.KeyPress, cbb_search_check_dep.KeyPress, _
        cbb_search_check_class.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbb_search_check_act_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_search_check_act.SelectedIndexChanged
        cbb_search_check_dep.Enabled = True
        Try
            connectdb()
            sql = "select act_id from tbl_activity where n_act='" & cbb_search_check_act.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_act_id = dr.GetInt32("act_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_search_check_dep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_search_check_dep.SelectedIndexChanged
        cbb_search_check_class.Text = "กรุณาเลือกระดับชั้น"
        cbb_search_check_class.Enabled = True

        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_search_check_dep.Text & "'"
            cmd_db_to_obj(cbb_search_check_class)
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_search_check_dep.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_search_check_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_search_check_class.SelectedIndexChanged
         Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_search_check_class.Text & "' and dep_id='" & keepvalue_search_dep_id & "'"

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_class_id = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_check_std_act_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_check_std_act.CellClick
       
    End Sub

    Private Sub btn_confirm_check_std_act_Click(sender As Object, e As EventArgs) Handles btn_confirm_check_std_act.Click
        If cbb_search_check_act.Text = "กรุณาเลือกกิจกรรม" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        ElseIf cbb_search_check_dep.Text = "กรุณาเลือกสาขา" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        ElseIf cbb_search_check_class.Text = "กรุณาเลือกระดับชั้น" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        Try

            If btn_confirm_check_std_act.Text = "ยืนยัน" Then

                If MessageBox.Show("ต้องการที่จะยืนยันข้อมูลใช่ไหม", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                           , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    cbb_search_check_act.Enabled = False
                    cbb_search_check_dep.Enabled = False
                    cbb_search_check_class.Enabled = False
                    btn_confirm_check_std_act.Text = "ยกเลิก"
                    sql = "select std_id,std_title,std_fname,std_lname from tbl_student where dep_id='" & keepvalue_search_dep_id & "' and class_id='" & keepvalue_search_class_id & "'"
                    DataGridView_check_std_act.DataSource = cmd_dataTable()
                    change_all_column()
                    Set_DTG_edit_user()



                    Dim chk As New DataGridViewCheckBoxColumn()
                    DataGridView_check_std_act.Columns.Add(chk)
                    chk.HeaderText = "เข้าร่วมกิจกรรม"
                    chk.Name = "chk"

                    For i As Integer = 0 To Me.DataGridView_check_std_act.RowCount - 1
                        Me.DataGridView_check_std_act(4, i).Value = True
                        If Me.DataGridView_check_std_act(4, i).Value = True Then
                            keepvalue_status = "เข้าร่วม"

                        End If
                        If Me.DataGridView_check_std_act(4, i).Value = False Then
                            keepvalue_status = "ไม่เข้าร่วม"

                        End If
                    Next
                    Me.DataGridView_check_std_act.EndEdit()
                    Return
                End If 'End If msgbox
            End If

            If btn_confirm_check_std_act.Text = "ยกเลิก" Then
                cbb_search_check_act.Enabled = True
                cbb_search_check_dep.Enabled = True
                cbb_search_check_class.Enabled = True
                btn_confirm_check_std_act.Text = "ยืนยัน"
                DataGridView_check_std_act.Columns.Clear()
                DataGridView_check_std_act.DataSource = Nothing
            End If


            'For Each item As DataGridViewRow In DataGridView_check_std_act.Rows
            'If Boolean.Parse(item.Cells(4).Value.ToString) Then
            'MsgBox("Select Row : " + item.Cells(4).RowIndex.ToString)
            'End If
            'Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_add_check_std_act_Click(sender As Object, e As EventArgs) Handles btn_add_check_std_act.Click
        If DataGridView_check_std_act.CurrentCell Is Nothing Then
            MsgBox("ไม่สามารถเพิ่มข้อมูลได้", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        Try
            connectdb()

            For x As Integer = 0 To DataGridView_check_std_act.Rows.Count - 1
                If Me.DataGridView_check_std_act(4, x).Value = True Then
                    keepvalue_status = "เข้าร่วม"

                End If
                If Me.DataGridView_check_std_act(4, x).Value = False Then
                    keepvalue_status = "ไม่เข้าร่วม"

                End If

                Me.DataGridView_check_std_act.EndEdit()
                Dim txt_std_id As String = DataGridView_check_std_act.Rows(x).Cells(0).Value 'รหัสนักศึกษา
                Dim txt_std_act_id As String = keepvalue_search_act_id 'รหัสกิจกรรม
                Dim txt_std_status As String = keepvalue_status 'สถานนะการเข้าร่วมกิจกรรม

                sql = "select count(*) from tbl_check_std_act where std_id='" & DataGridView_check_std_act.Rows(x).Cells(0).Value & "' and act_id='" & keepvalue_search_act_id & "' " +
                    "and class_id='" & keepvalue_search_class_id & "' and dep_id='" & keepvalue_search_dep_id & "'"
                If cmd_excuteunique() > 0 Then
                    MsgBox("ข้อมูลนี้มีอยู่แล้วในระบบ", MsgBoxStyle.Exclamation, "Message")
                    Return
                End If

                sql = "insert into tbl_check_std_act (std_id,act_id,class_id,dep_id,status_std_act) values (@std_id,@act_id,@class_id,@dep_id,@status_std_act)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@std_id", txt_std_id)
                cmd.Parameters.AddWithValue("@act_id", txt_std_act_id)
                cmd.Parameters.AddWithValue("@class_id", keepvalue_search_class_id)
                cmd.Parameters.AddWithValue("@dep_id", keepvalue_search_dep_id)
                cmd.Parameters.AddWithValue("@status_std_act", txt_std_status)
                'cmd.Parameters.AddWithValue("@log_msg", "เพิ่มกิจกรรม : " + cbb_search_check_act.Text + " | สาขา : " + cbb_search_check_dep.Text + " | ระดับชั้น : " + cbb_search_check_class.Text + " | เวลา : " + Date.Now)

                If cmd.ExecuteNonQuery() = 0 Then MsgBox("ไม่สามารถเพิ่มได้", MsgBoxStyle.Critical, "Message")

            Next
            sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
            cmd.Parameters.AddWithValue("@log_date", Date.Now)
            cmd.Parameters.AddWithValue("@log_operation", "เพิ่มรายชื่อนักศึกษากิจกรรม : " + cbb_search_check_act.Text + " | สาขา : " + cbb_search_check_dep.Text + " | ระดับชั้น : " + cbb_search_check_class.Text)
            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("เพิ่มข้อมูลสำเร็จ", MsgBoxStyle.Information, "Message")
            btn_confirm_check_std_act.PerformClick()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Message")

        End Try
    End Sub


End Class