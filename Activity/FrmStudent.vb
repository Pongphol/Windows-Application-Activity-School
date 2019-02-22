Imports MySql.Data.MySqlClient
Public Class FrmStudent

    'AddHandler checkboxHeader231.CheckedChanged, AddressOf checkboxHeader231_CheckedChanged
    Dim keepvalue_add_class_id As Integer
    Dim keepvalue_add_dep_id As Integer
    Dim keepvalue_edit_class_id As Integer
    Dim keepvalue_edit_dep_id As Integer
    Dim keepvalue_search_class_id As Integer
    Dim keepvalue_search_dep_id As Integer

    Dim keepvalue_add_teach_id As Integer
    Dim keepvalue_edit_teach_id As Integer
    '======================================================================
    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub refresh_all_data_user()
        sql = "select std_id, std_title , std_fname, std_lname,class_name,dep_n,teacher_fname,teacher_lname from tbl_student inner join tbl_class " +
             "on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
             "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
             "order by tbl_class.class_name asc,tbl_teacher.teacher_fname asc"
        DataGridView_student.DataSource = cmd_dataTable()
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

            DataGridView_student.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_student.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView_student.GridColor = Color.Black
            DataGridView_student.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_student.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_student.CellBorderStyle = DataGridViewCellBorderStyle.None
            'DataGridView_student.Rows(i).Cells(2).Value = DataGridView_student.Rows(i).Cells(1).Value + " " + DataGridView_student.Rows(i).Cells(2).Value
        Next

    End Sub

    Private Sub change_all_column()
        Dim headertxt() As String = {"รหัสนักเรียน", "คำนำหน้าชื่อ", "ชื่อ", "นามสกุล", "ระดับชั้น", "สาขา", "ชื่ออาจารย์ที่ปรึกษา", "นามสกุล"}
        change_column_datagrid(DataGridView_student, headertxt)
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
        With DataGridView_student
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

    Private Sub change_header_dgv()

        DataGridView_student.DataSource = ds.Tables("table")
        With DataGridView_student
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "รหัสนักศึกษา"
            .Columns(1).HeaderCell.Value = "คำนำหน้าชื่อ"
            .Columns(2).HeaderCell.Value = "ชื่อ"
            .Columns(3).HeaderCell.Value = "นามสกุล"

        End With
        'DataGridView_student.Rows(i).Cells("std_title").Value
    End Sub

    '======================================================================
    Private Sub btn_close_std_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close_std.Click
        Me.Close()
    End Sub

    Private Sub FrmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = "select dep_n from tbl_department"
            cmd_db_to_obj(cbb_add_dep)
            cbb_add_dep.Text = "กรุณาเลือกสาขา"

            sql = "select class_name from tbl_class"
            cmd_db_to_obj(cbb_add_class)
            cbb_add_class.Text = "กรุณาเลือกระดับชั้น"

            sql = "select dep_n from tbl_department"
            cmd_db_to_obj(cbb_edit_dep)
            cbb_edit_dep.Text = "กรุณาเลือกสาขา"

            sql = "select class_name from tbl_class"
            cmd_db_to_obj(cbb_edit_class)
            cbb_edit_class.Text = "กรุณาเลือกระดับชั้น"

            sql = "select dep_n from tbl_department"
            cmd_db_to_obj(cbb_search_dep_std)
            cbb_search_dep_std.Text = "กรุณาเลือกสาขา"

            sql = "select class_name from tbl_class"
            cmd_db_to_obj(cbb_search_class_std)
            cbb_search_class_std.Text = "กรุณาเลือกระดับชั้น"


            sql = "select std_id, std_title , std_fname, std_lname,class_name,dep_n,teacher_fname,teacher_lname from tbl_student inner join tbl_class " +
             "on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
             "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
             "order by tbl_class.class_name asc,tbl_teacher.teacher_fname asc"
            DataGridView_student.DataSource = cmd_dataTable()
            change_all_column()
            Set_DTG_edit_user()



            cbb_search_dep_std.Items.Add("ทั้งหมด")
            cbb_add_titlestd.Text = ". . ."
            cbb_add_titlestd.Items.Add("นาย")
            cbb_add_titlestd.Items.Add("น.ส.")
            cbb_edit_titlestd.Text = ". . ."
            cbb_edit_titlestd.Items.Add("นาย")
            cbb_edit_titlestd.Items.Add("น.ส.")

            cbb_add_class.Enabled = False
            cbb_edit_dep.Enabled = False
            cbb_edit_class.Enabled = False
            cbb_search_class_std.Enabled = False
            txt_edit_idstd.Enabled = False
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Message")
        End Try

    End Sub

    Private Sub cbb_add_dep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_add_dep.KeyPress, _
        cbb_add_class.KeyPress, cbb_edit_dep.KeyPress, cbb_edit_class.KeyPress, cbb_add_titlestd.KeyPress, cbb_edit_titlestd.KeyPress
        e.Handled = True
    End Sub


    Private Sub cbb_add_dep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_add_dep.SelectedIndexChanged
        cbb_add_class.Text = "กรุณาเลือกระดับชั้น"
        cbb_add_class.Enabled = True

        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_add_dep.Text & "'"
            cmd_db_to_obj(cbb_add_class)
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_add_dep.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_add_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_add_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_add_class.SelectedIndexChanged
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_add_class.Text & "' and dep_id='" & keepvalue_add_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_add_class_id = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select teacher_id from tbl_teacher where class_id='" & keepvalue_add_class_id & "' and dep_id='" & keepvalue_add_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_add_teach_id = dr.GetInt32("teacher_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbb_edit_dep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_edit_dep.SelectedIndexChanged
        'cbb_edit_class.Text = "กรุณาเลือกระดับชั้น"
        'cbb_edit_class.Enabled = True

        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_edit_dep.Text & "'"
            cmd_db_to_obj(cbb_edit_class)
        Catch ex As Exception

        End Try

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

    Private Sub cbb_edit_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbb_edit_class.SelectedIndexChanged
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_edit_class.Text & "' and dep_id='" & keepvalue_edit_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_class_id = dr.GetInt32("class_id")

            End While
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select teacher_id from tbl_teacher where class_id='" & keepvalue_edit_class_id & "' and dep_id='" & keepvalue_edit_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_teach_id = dr.GetInt32("teacher_id")

            End While
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_add_std_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_std.Click
       
        Try
            If txt_add_fstd.Text = "" And txt_add_lstd.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            If cbb_add_dep.Text = "กรุณาเลือกสาขา" Then
                MsgBox("กรุณาเลือกข้อมูลให้ถูกต้อง", MsgBoxStyle.Exclamation, "Message")
                Return
            ElseIf cbb_add_class.Text = "กรุณาเลือกระดับชั้น" Then
                MsgBox("กรุณาเลือกข้อมูลให้ถูกต้อง", MsgBoxStyle.Exclamation, "Message")
                Return
            ElseIf cbb_add_titlestd.Text = ". . ." Then
                MsgBox("กรุณาเลือกข้อมูลให้ถูกต้อง", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "insert into tbl_student (std_title,std_fname,std_lname,class_id,dep_id,teacher_id) values (@std_title,@std_fname,@std_lname,@class_id,@dep_id,@teacher_id)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@std_title", cbb_add_titlestd.Text)
            cmd.Parameters.AddWithValue("@std_fname", txt_add_fstd.Text)
            cmd.Parameters.AddWithValue("@std_lname", txt_add_lstd.Text)
            cmd.Parameters.AddWithValue("@class_id", keepvalue_add_class_id)
            cmd.Parameters.AddWithValue("@dep_id", keepvalue_add_dep_id)
            cmd.Parameters.AddWithValue("@teacher_id", keepvalue_add_teach_id)

            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("ไม่สามารถเพิ่มได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เพิ่มนักศึกษา | สาขา : " + cbb_add_dep.Text + " | ระดับชั้น : " + cbb_add_class.Text)
                cmd.ExecuteNonQuery()

                MsgBox("เพิ่มสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                cbb_add_dep.Text = "กรุณาเลือกสาขา"
                cbb_add_class.Text = "กรุณาเลือกระดับชั้น"
                txt_add_fstd.Text = ""
                txt_add_lstd.Text = ""
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
   
    Private Sub btn_edit_std_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_std.Click
        Try
            If txt_edit_fstd.Text = "" And txt_edit_lstd.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            If cbb_edit_dep.Text = "กรุณาเลือกสาขา" Then
                MsgBox("กรุณาเลือกข้อมูลให้ถูกต้อง", MsgBoxStyle.Exclamation, "Message")
                Return
            ElseIf cbb_edit_class.Text = "กรุณาเลือกระดับชั้น" Then
                MsgBox("กรุณาเลือกข้อมูลให้ถูกต้อง", MsgBoxStyle.Exclamation, "Message")
                Return
            ElseIf cbb_edit_titlestd.Text = ". . ." Then
                MsgBox("กรุณาเลือกข้อมูลให้ถูกต้อง", MsgBoxStyle.Exclamation, "Message")
                Return
            End If
        Catch ex As Exception

        End Try

        Try
            sql = "update tbl_student set std_title='" & cbb_edit_titlestd.Text & "',std_fname='" & txt_edit_fstd.Text.Trim & "',std_lname='" & txt_edit_lstd.Text.Trim & "',class_id='" & keepvalue_edit_class_id & "',dep_id='" & keepvalue_edit_dep_id & "',teacher_id='" & keepvalue_edit_teach_id & "' where std_id='" & txt_edit_idstd.Text & "'"
            ' sql = "update tbl_student inner join tbl_teacher on tbl_student.teacher_id=tbl_teacher.teacher_id " +
            '"set tbl_student.std_fname='" & txt_edit_fstd.Text.Trim & "',tbl_student.std_lname='" & txt_edit_lstd.Text.Trim & "'," +
            '"tbl_student.class_id='" & keepvalue_edit_class_id & "',tbl_student.dep_id='" & keepvalue_edit_dep_id & "'," +
            '"tbl_student.teacher_id='" & keepvalue_edit_teach_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถบันทึกได้", MsgBoxStyle.Critical, "Message")
            Else
                Dim mycount As Integer = DataGridView_student.CurrentRow.Index

                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "แก้ไขข้อมูลนักศึกษา :" + DataGridView_student.Item(0, mycount).Value.ToString + " | สาขา : " + DataGridView_student.Item(5, mycount).Value + " | ระดับชั้น : " + DataGridView_student.Item(4, mycount).Value)
                cmd.ExecuteNonQuery()

                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "Message")
                'refresh_all_data_user()
                btn_search_std.PerformClick()
                cbb_edit_dep.Text = "กรุณาเลือกสาขา"
                cbb_edit_class.Text = "กรุณาเลือกระดับชั้น"
                cbb_edit_titlestd.Text = ". . ."
                txt_edit_idstd.Text = ""
                txt_edit_fstd.Text = ""
                txt_edit_lstd.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView_student_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_student.CellClick
        Dim i As Integer = DataGridView_student.CurrentRow.Index
        Try
            txt_edit_idstd.Text = DataGridView_student.Item(0, i).Value
            cbb_edit_titlestd.Text = DataGridView_student.Item(1, i).Value
            txt_edit_fstd.Text = DataGridView_student.Item(2, i).Value
            txt_edit_lstd.Text = DataGridView_student.Item(3, i).Value
            cbb_edit_class.Text = DataGridView_student.Item(4, i).Value
            cbb_edit_dep.Text = DataGridView_student.Item(5, i).Value
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_edit_class.Text & "' and dep_id='" & keepvalue_edit_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_class_id = dr.GetInt32("class_id")

            End While
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select teacher_id from tbl_teacher where class_id='" & keepvalue_edit_class_id & "' and dep_id='" & keepvalue_edit_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_edit_teach_id = dr.GetInt32("teacher_id")

            End While
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub searching()
        sql = "select std_id,std_title,std_fname,std_lname,class_name,dep_n,teacher_fname,teacher_lname from tbl_student inner join tbl_class on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
            "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
            "where tbl_student.dep_id like '%" & keepvalue_search_dep_id & "%' and tbl_student.class_id like '%" & keepvalue_search_class_id & "%' " +
            "order by tbl_class.class_name asc,tbl_teacher.teacher_fname asc,tbl_student.std_id asc"
        DataGridView_student.DataSource = cmd_dataTable()
    End Sub

    Private Sub btn_search_std_Click(sender As Object, e As EventArgs) Handles btn_search_std.Click
        Try
            If Not txt_search_nstd.Text = String.Empty Then
                cbb_search_dep_std.Text = "ทั้งหมด"
                cbb_search_class_std.Text = "ทั้งหมด"
                sql = "select std_id,std_title,std_fname,std_lname,class_name,dep_n,teacher_fname,teacher_lname from tbl_student inner join " +
                    "tbl_class on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
                    "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
                    "where tbl_student.std_fname like '%" & txt_search_nstd.Text.Trim & "%' or tbl_student.std_lname like '%" & txt_search_nstd.Text.Trim & "%' " +
                    "or std_title like '%" & txt_search_nstd.Text.Trim & "%' " +
                    "order by tbl_class.class_name asc,tbl_teacher.teacher_fname asc"
                DataGridView_student.DataSource = cmd_dataTable()
                Return
            End If

            If cbb_search_dep_std.Text = "กรุณาเลือกสาขา" Or cbb_search_class_std.Text = "กรุณาเลือกระดับชั้น" Then
                MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            

            If cbb_search_dep_std.Text = "ทั้งหมด" And cbb_search_class_std.Text = "ทั้งหมด" Then
                sql = "select std_id, std_title , std_fname, std_lname,class_name,dep_n,teacher_fname,teacher_lname from tbl_student inner join tbl_class " +
             "on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
             "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
             "order by tbl_class.class_name asc,tbl_teacher.teacher_fname asc"
                DataGridView_student.DataSource = cmd_dataTable()
                Return
            End If

            If cbb_search_class_std.Text = "ทั้งหมด" Then
                sql = "select std_id,std_title,std_fname,std_lname,class_name,dep_n,teacher_fname,teacher_lname from tbl_student inner join " +
                    "tbl_class on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
                    "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
                    "where tbl_student.dep_id like '" & keepvalue_search_dep_id & "' " +
                    "order by tbl_class.class_name asc,tbl_teacher.teacher_fname asc,tbl_student.std_id asc"
                DataGridView_student.DataSource = cmd_dataTable()
                Return
            End If

            searching()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub cbb_search_dep_std_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_search_dep_std.KeyPress, cbb_search_class_std.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbb_search_dep_std_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_search_dep_std.SelectedIndexChanged
        cbb_search_class_std.Text = "กรุณาเลือกระดับชั้น"
        cbb_search_class_std.Enabled = True

        Try
            If cbb_search_dep_std.Text = "ทั้งหมด" Then
                cbb_search_class_std.Text = "ทั้งหมด"
                cbb_search_class_std.Enabled = False
            End If
        Catch ex As Exception

        End Try

        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_search_dep_std.Text & "'"
            cmd_db_to_obj(cbb_search_class_std)
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_search_dep_std.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
            cbb_search_class_std.Items.Add("ทั้งหมด")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_search_class_std_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_search_class_std.SelectedIndexChanged
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_search_class_std.Text & "' and dep_id='" & keepvalue_search_dep_id & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_class_id = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_delete_act_Click(sender As Object, e As EventArgs) Handles btn_delete_act.Click
        If MessageBox.Show("คุณต้องการจะลบข้อมูล : " + cbb_edit_titlestd.Text + txt_edit_fstd.Text + "   " + txt_edit_lstd.Text, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                          , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_student where std_id='" & txt_edit_idstd.Text.Trim & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                Dim mycount As Integer = DataGridView_student.CurrentRow.Index

                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบนักศึกษา : " + txt_edit_idstd.Text + " | สาขา : " + cbb_edit_dep.Text + " | ระดับชั้น : " + cbb_edit_class.Text)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                cbb_edit_dep.Text = "กรุณาเลือกสาขา"
                cbb_edit_class.Text = "กรุณาเลือกระดับชั้น"
                cbb_edit_titlestd.Text = ". . ."
                txt_edit_idstd.Text = ""
                txt_edit_fstd.Text = ""
                txt_edit_lstd.Text = ""
            End If
        Else
            Return
        End If
    End Sub

    Private Sub btn_delete_std_from_class_Click(sender As Object, e As EventArgs) Handles btn_delete_std_from_class.Click
        If cbb_search_class_std.Text = "กรุณาเลือกระดับชั้น" Then
            MsgBox("กรุณาเลือกระดับชั้น", MsgBoxStyle.Critical, "Message")
            Return
        End If

        If MessageBox.Show("คุณต้องการจะลบรายชื่อนักศึกษาทั้งหมดของห้อง : " + cbb_search_class_std.Text, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                         , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_student where class_id='" & keepvalue_search_class_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบรายชื่อนักศึกษาทั้งหมดของสาขา : " + cbb_search_dep_std.Text + " | ระดับชั้น : " + cbb_search_class_std.Text)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                cbb_edit_dep.Text = "กรุณาเลือกสาขา"
                cbb_edit_class.Text = "กรุณาเลือกระดับชั้น"
                cbb_edit_titlestd.Text = ". . ."
                txt_edit_idstd.Text = ""
                txt_edit_fstd.Text = ""
                txt_edit_lstd.Text = ""
            End If
        Else
            Return
        End If
    End Sub
End Class