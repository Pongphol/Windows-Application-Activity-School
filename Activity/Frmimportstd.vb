Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Text



Imports System.IO
Imports System.String
Imports System.Net


Public Class Frmimportstd


    Dim keepvalue_import_dep As Integer
    Dim keepvalue_import_class As Integer
    Dim keepvalue_import_teach_id As Integer
    '======================================================================
    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub refresh_all_data_user()
        sql = "select std_fname,std_lname from tbl_student"
        DataGridView_import_std.DataSource = cmd_dataTable()
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

            DataGridView_import_std.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_import_std.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView_import_std.Columns(i).Width = 300

            DataGridView_import_std.GridColor = Color.Black
            DataGridView_import_std.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_import_std.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_import_std.CellBorderStyle = DataGridViewCellBorderStyle.None

        Next

    End Sub

    Private Sub change_all_column()
        Dim headertxt() As String = {"ชื่อ", "นามสกุล"}
        change_column_datagrid(DataGridView_import_std, headertxt)
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
        With DataGridView_import_std
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

    Private Sub Frmimportstd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'sql = "select dep_n from tbl_department"
            sql = "select distinct dep_n from tbl_department inner join tbl_teacher on tbl_teacher.dep_id=tbl_department.dep_id " +
                "where teacher_id IS NOT NULL"
            cmd_db_to_obj(cbb_import_dep_std)
            cbb_import_dep_std.Text = "กรุณาเลือกสาขา"

            sql = "select class_name from tbl_class inner join tbl_teacher on tbl_teacher.class_id=tbl_class.class_id " +
                "where teacher_id IS NOT NULL"
            cmd_db_to_obj(cbb_import_class_std)
            cbb_import_class_std.Text = "กรุณาเลือกระดับชั้น"

            'sql = "select std_fname,std_lname from tbl_student"
            'DataGridView_import_std.DataSource = cmd_dataTable()
            'change_all_column()
            Set_DTG_edit_user()

            cbb_import_class_std.Enabled = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
       

    End Sub

    Private Sub btn_close_importstd_Click(sender As Object, e As EventArgs) Handles btn_close_importstd.Click
        Me.Close()
    End Sub

    Private Sub cbb_import_dep_std_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_import_dep_std.KeyPress, cbb_import_class_std.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbb_import_dep_std_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_import_dep_std.SelectedIndexChanged
        cbb_import_class_std.Text = "กรุณาเลือกระดับชั้น"
        cbb_import_class_std.Enabled = True
        
        Try
            'sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_import_dep_std.Text & "'"
            sql = "select class_name from tbl_class inner join tbl_teacher on tbl_teacher.dep_id=tbl_department.dep_id " +
                "inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_import_dep_std.Text & "' " +
                "and teacher_id IS NOT NULL"
            cmd_db_to_obj(cbb_import_class_std)
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_import_dep_std.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_import_dep = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_import_class_std_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_import_class_std.SelectedIndexChanged

        Try

            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_import_class_std.Text & "' and dep_id='" & keepvalue_import_dep & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_import_class = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select teacher_id from tbl_teacher where class_id='" & keepvalue_import_class & "' and dep_id='" & keepvalue_import_dep & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_import_teach_id = dr.GetInt32("teacher_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_import_std_Click(sender As Object, e As EventArgs) Handles btn_import_std.Click
        OpenFileDialog_import_std.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        ' OpenFileDialog_import_std.InitialDirectory = "C:\Users\Doubledrift\Desktop\list\csv"
        OpenFileDialog_import_std.Filter = "CSV Files (*.csv)|*.csv"
        Try
            If OpenFileDialog_import_std.ShowDialog(Me) = DialogResult.OK Then
                Dim odf As New System.IO.FileInfo(OpenFileDialog_import_std.FileName)
                'Dim sConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Text;Data Source=" & odf.DirectoryName
                Dim sConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & odf.DirectoryName & ";Extended Properties='text;HDR=Yes;FMT=Delimited;'"
                Dim objConn As New OleDbConnection(sConnectionString)
                objConn.Open()
                ' Dim objCmdSelect As New OleDbCommand("SELECT * FROM " & odf.Name, objConn)
                Dim objCmdSelect As New OleDbCommand("SELECT * FROM [" & odf.Name & "]", objConn)
                Dim objAdapter1 As New OleDbDataAdapter

                objAdapter1.SelectCommand = objCmdSelect
                Dim objDataset1 As New DataSet

                objAdapter1.Fill(objDataset1, "test")
                DataGridView_import_std.DataSource = objDataset1.Tables(0).DefaultView

                objConn.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub


    Private Sub btn_add_import_std_Click(sender As Object, e As EventArgs) Handles btn_add_import_std.Click

        If cbb_import_dep_std.Text = "กรุณาเลือกสาขา" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        If cbb_import_class_std.Text = "กรุณาเลือกระดับชั้น" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        If DataGridView_import_std.CurrentCell Is Nothing Then
            MsgBox("ไม่สามารถเพิ่มข้อมูลได้", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        Try
            connectdb()

            For x As Integer = 0 To DataGridView_import_std.Rows.Count - 1

                Dim txt_std_id As String = DataGridView_import_std.Rows(x).Cells(0).Value 'รหัสนักศึกษา
                Dim txt_std_title As String = DataGridView_import_std.Rows(x).Cells(1).Value 'คำนำหน้าชื่อ
                Dim txt_std_fname As String = DataGridView_import_std.Rows(x).Cells(2).Value 'ชื่อ
                Dim txt_std_lname As String = DataGridView_import_std.Rows(x).Cells(3).Value 'นามสกุล

                'sql = "select count(*) from tbl_student where std_fname='" & DataGridView_import_std.Rows(x).Cells(0).Value & "' and std_lname='" & DataGridView_import_std.Rows(x).Cells(1).Value & "'"
                'If cmd_excuteunique() > 0 Then
                'MsgBox("ข้อมูลนี้มีอยู่แล้วในระบบ", MsgBoxStyle.Exclamation, "Message")
                ' Return
                'End If

                sql = "insert into tbl_student (std_id,std_title,std_fname,std_lname,class_id,dep_id,teacher_id) values (@std_id,@std_title,@std_fname,@std_lname,@class_id,@dep_id,@teacher_id)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@std_id", txt_std_id)
                cmd.Parameters.AddWithValue("@std_title", txt_std_title)
                cmd.Parameters.AddWithValue("@std_fname", txt_std_fname)
                cmd.Parameters.AddWithValue("@std_lname", txt_std_lname)
                cmd.Parameters.AddWithValue("@class_id", keepvalue_import_class)
                cmd.Parameters.AddWithValue("@dep_id", keepvalue_import_dep)
                cmd.Parameters.AddWithValue("@teacher_id", keepvalue_import_teach_id)
                If cmd.ExecuteNonQuery() = 0 Then MsgBox("ไม่สามารถเพิ่มข้อมูลได้", MsgBoxStyle.Exclamation, "Message")

            Next

            Dim total_std As Integer = DataGridView_import_std.Rows.Count
            sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
            cmd.Parameters.AddWithValue("@log_date", Date.Now)
            cmd.Parameters.AddWithValue("@log_operation", "เพิ่มรายชื่อนักศึกษาสาขา : " + cbb_import_dep_std.Text + " | ระดับชั้น : " + cbb_import_class_std.Text + " | จำนวน : " + total_std.ToString + " คน")
            cmd.ExecuteNonQuery()

            conn.Close()

            MsgBox("เพิ่มข้อมูลสำเร็จ", MsgBoxStyle.Information, "Message")

            DataGridView_import_std.DataSource = Nothing
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("ไม่สามารถเพิ่มข้อมูลได้", MsgBoxStyle.Exclamation, "Message")
        End Try
    End Sub

End Class