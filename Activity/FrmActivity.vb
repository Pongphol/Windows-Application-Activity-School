Imports MySql.Data.MySqlClient
Public Class FrmActivity
    

    Dim keepvalue_act_id As Integer
    Dim pic As Image
    '======================================================================
    Private Sub connectdb()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub refresh_all_data_user()
        sql = "select act_img,n_act,date_act from tbl_activity order by date_act asc"
        DataGridView_act.DataSource = cmd_dataTable()
    End Sub

    'Private Sub searching()
    '  sql = "select * from tbl_users where user_id like '%" & txt_search_user.Text & "%' or username like '%" & txt_search_user.Text & "%' or password like '%" & txt_search_user.Text & "%' or status like '%" & txt_search_user.Text & "%'"
    ' DataGridView_edit_user.DataSource = cmd_dataTable()
    ' End Sub

    Private Sub change_column_datagrid(ByVal datagrid As DataGridView, ByVal headerstr1() As String)
        Dim datagrid_column_total As Integer = datagrid.Columns.Count
        For i As Integer = 0 To datagrid_column_total - 1
            datagrid.Columns(i).HeaderText = headerstr1(i)
            'DataGridView_act.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_act.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            'DataGridView_act.Columns(i).Width = 283

            DataGridView_act.GridColor = Color.Black
            DataGridView_act.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_act.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_act.CellBorderStyle = DataGridViewCellBorderStyle.None
        Next

    End Sub

    Private Sub change_all_column()
        Dim headertxt() As String = {"ภาพกิจกรรม", "ชื่อกิจกรรม", "วันที่จัดกิจกรรม"}
        change_column_datagrid(DataGridView_act, headertxt)
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
        Try
            With DataGridView_act
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
                .RowTemplate.Height = 120
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionForeColor = Color.White
                .DefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 167, 240)
            End With

            For Each column As DataGridViewImageColumn In DataGridView_act.Columns
                column.ImageLayout = DataGridViewImageCellLayout.Stretch
            Next
        Catch ex As Exception

        End Try
        

    End Sub


    '======================================================================

    Private Sub btn_close_act_Click(sender As Object, e As EventArgs) Handles btn_close_act.Click
        Me.Close()
    End Sub
    Private Sub FrmActivity_Load(sender As Object, e As EventArgs) Handles Me.Load

        sql = "select act_img,n_act,date_act from tbl_activity order by date_act asc"

        DataGridView_act.DataSource = cmd_dataTable()
        change_all_column()
        Set_DTG_edit_user()

    End Sub
    Private Sub btn_add_act_Click(sender As Object, e As EventArgs) Handles btn_add_act.Click
        If txt_add_act.Text = "" Then
            MsgBox("กรุณาใส่ชื่อกิจกรรมด้วย", MsgBoxStyle.Exclamation, "Message")
            Return
        End If
        Try

            If PictureBox_add_act_img.Image Is Nothing Then
                MsgBox("กรุณาเลือกรูปกิจกรรมด้วย", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            'sql = "select count(*) from tbl_activity where n_act='" & txt_add_act.Text.Trim & "'"
            'If cmd_excuteunique() > 0 Then
            'MsgBox("ข้อมูลนี้มีอยู่แล้วในระบบ", MsgBoxStyle.Exclamation, "Message")
            'txt_add_act.Select()
            ' Return
            ' End If

            connectdb()
            Dim nameact As String = txt_add_act.Text
            Dim dateact As Date = DateTimePicker_act.Value
            sql = "insert into tbl_activity(n_act,date_act,act_img) values(@n_act,@date_act,@act_img)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@n_act", nameact)
            cmd.Parameters.AddWithValue("@date_act", dateact)
            If Not PictureBox_add_act_img.Image Is Nothing Then
                Dim mem As New IO.MemoryStream
                PictureBox_add_act_img.Image.Save(mem, Imaging.ImageFormat.Jpeg)
                Dim pic_for_add() As Byte
                pic_for_add = mem.ToArray()

                'Dim msream As New System.IO.MemoryStream()
                ' PictureBox_add_act_img.Image.Save(msream, System.Drawing.Imaging.ImageFormat.Jpeg)
                'Dim pic_for_add() As Byte
                'pic_for_add = msream.GetBuffer()
                cmd.Parameters.AddWithValue("@act_img", pic_for_add)
            End If

            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("ไม่สามารถเพิ่มกิจกรรมได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "เพิ่มกิจกรรม : " + txt_add_act.Text)
                cmd.ExecuteNonQuery()

                MsgBox("เพิ่มกิจกรรมสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                PictureBox_add_act_img.Image = Nothing
                txt_add_act.Text = ""
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation)
        End Try
        conn.Close()

    End Sub

    Private Sub btn_edit_act_Click(sender As Object, e As EventArgs) Handles btn_edit_act.Click
        If txt_edit_nact.Text = "" Then
            MsgBox("กรุณาเลือกกิจกรรม", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        If PictureBox_edit_act_img.Image Is Nothing Then
            MsgBox("กรุณาเลือกรูปกิจกรรมด้วย", MsgBoxStyle.Exclamation, "Message")
            Return
        End If


        Try
            Dim nullstr As String = ""
            connectdb()
            sql = "update tbl_activity set n_act= @n_act where act_id='" & keepvalue_act_id & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@n_act", nullstr)
            If cmd.ExecuteNonQuery() = 0 Then

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If PictureBox_edit_act_img.Image Is Nothing Then
            sql = "update tbl_activity set n_act=@n_act,date_act=@date_act where act_id='" & keepvalue_act_id & "'"
        Else
            sql = "update tbl_activity set n_act=@n_act,date_act=@date_act,act_img=@act_img where act_id='" & keepvalue_act_id & "'"
        End If

        Try
            connectdb()
            sql = "update tbl_activity set n_act=@n_act,date_act=@date_act,act_img=@act_img where act_id='" & keepvalue_act_id & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@n_act", txt_edit_nact.Text)
            cmd.Parameters.AddWithValue("@date_act", DateTimePicker_edit_dateact.Value)
            If Not PictureBox_edit_act_img.Image Is Nothing Then
                Dim mem As New IO.MemoryStream
                PictureBox_edit_act_img.Image.Save(mem, Imaging.ImageFormat.Jpeg)
                Dim pic_for_add() As Byte
                pic_for_add = mem.ToArray()

                'Dim msream As New System.IO.MemoryStream()
                ' PictureBox_add_act_img.Image.Save(msream, System.Drawing.Imaging.ImageFormat.Jpeg)
                'Dim pic_for_add() As Byte
                'pic_for_add = msream.GetBuffer()
                cmd.Parameters.AddWithValue("@act_img", pic_for_add)
            End If


            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("ไม่สามารถบันทึกกิจกรรมได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "แก้ไขกิจกรรม : " + DataGridView_act.Item(1, DataGridView_act.CurrentRow.Index).Value + " | เป็นกิจกรรม : " + txt_edit_nact.Text)
                cmd.ExecuteNonQuery()

                MsgBox("บันทึกกิจกรรมสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView_act_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_act.CellClick
        Dim select_row As Integer = DataGridView_act.CurrentRow.Index
        Try
            PictureBox_edit_act_img.Image = Nothing
            Dim img() As Byte = DataGridView_act.Item(0, select_row).Value
            PictureBox_edit_act_img.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))
            txt_edit_nact.Text = DataGridView_act.Item(1, select_row).Value
            DateTimePicker_edit_dateact.Value = DataGridView_act.Item(2, select_row).Value

        Catch ex As Exception
            ' MsgBox(Err.Description, MsgBoxStyle.Exclamation)
        End Try
        Try
            connectdb()
            sql = "select act_id from tbl_activity where n_act='" & txt_edit_nact.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_act_id = dr.GetInt32("act_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_add_browse_img_Click(sender As Object, e As EventArgs) Handles btn_add_browse_img.Click
        OpenFileDialog_add_act_img.FileName = ""
        OpenFileDialog_add_act_img.Filter = "All Picture File|*.JPEG;*.PNG;*.GIF;*.BMP;*.TIFF;"
        If OpenFileDialog_add_act_img.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(OpenFileDialog_add_act_img.FileName)
            PictureBox_add_act_img.Image = img
        End If
    End Sub

    Private Sub btn_edit_browse_img_Click(sender As Object, e As EventArgs) Handles btn_edit_browse_img.Click
        If OpenFileDialog_add_act_img.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(OpenFileDialog_add_act_img.FileName)
            PictureBox_edit_act_img.Image = img
        End If
    End Sub

    Private Sub btn_delete_act_Click(sender As Object, e As EventArgs) Handles btn_delete_act.Click
        If MessageBox.Show("คุณต้องการจะลบกิจกรรม : " + DataGridView_act.Item(1, DataGridView_act.CurrentRow.Index).Value, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                           , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            sql = "delete from tbl_activity where act_id='" & keepvalue_act_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบกิจกรรม : " + DataGridView_act.Item(1, DataGridView_act.CurrentRow.Index).Value)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
                PictureBox_edit_act_img.Image = Nothing
                txt_edit_nact.Text = ""
                DateTimePicker_edit_dateact.Value = Date.Now
            End If
        Else
            Return
        End If
    End Sub
End Class