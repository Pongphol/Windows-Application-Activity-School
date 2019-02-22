Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class FrmCheck_std_list_act

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
        sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
                    "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
                    "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
                    "and tbl_student.class_id='" & keepvalue_search_class_id & "'"
        DataGridView_check_std_not_join_act.DataSource = cmd_dataTable()
    End Sub

    Private Sub searching()
        sql = "select std_fname, std_lname,class_name,dep_n,status_std from tbl_check_std_act inner join tbl_class on tbl_class.class_id=tbl_student.class_id inner join tbl_department on tbl_department.dep_id=tbl_student.dep_id " +
            "inner join  tbl_teacher on tbl_teacher.teacher_id=tbl_student.teacher_id " +
            "where tbl_student.dep_id like '%" & keepvalue_search_dep_id & "%' and tbl_student.class_id like '%" & keepvalue_search_class_id & "%'"
        DataGridView_check_std_not_join_act.DataSource = cmd_dataTable()
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

            DataGridView_check_std_not_join_act.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView_check_std_not_join_act.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ' DataGridView_check_std_act.Columns(i).Width = 300

            DataGridView_check_std_not_join_act.GridColor = Color.Black
            DataGridView_check_std_not_join_act.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView_check_std_not_join_act.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView_check_std_not_join_act.CellBorderStyle = DataGridViewCellBorderStyle.None
            


        Next
        'Dim chk As New DataGridViewCheckBoxColumn() With {.HeaderText = "SELECT", .Name = "status_std_act", _
        '.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, _
        '.FlatStyle = FlatStyle.Standard, .ThreeState = False}
        'DataGridView_check_std_not_join_act.Columns.Insert(0, chk)
    End Sub


    Private Sub change_all_column()
        Dim headertxt() As String = {"รหัสนักศึกษา", "คำนำหน้าชื่อ", "ชื่อ", "นามสกุล", "สถานะการเข้าร่วม"}
        change_column_datagrid(DataGridView_check_std_not_join_act, headertxt)
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
        With DataGridView_check_std_not_join_act
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

   

    Private Sub FrmCheck_std_list_act_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            sql = "select n_act from tbl_activity"
            cmd_db_to_obj(cbb_search_act)
            cbb_search_act.Text = "กรุณาเลือกกิจกรรม"

            sql = "select dep_n from tbl_department"
            cmd_db_to_obj(cbb_search_dep)
            cbb_search_dep.Text = "กรุณาเลือกสาขา"

            sql = "select class_name from tbl_class"
            cmd_db_to_obj(cbb_search_class)
            cbb_search_class.Text = "กรุณาเลือกระดับชั้น"


            sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
            "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id"

            'DataGridView_check_std_not_join_act.DataSource = cmd_dataTable()
            'change_all_column()

            Set_DTG_edit_user()

            cbb_search_status_std.Text = "กรุณาเลือกสถานะ"
            cbb_search_status_std.Items.Add("เข้าร่วม")
            cbb_search_status_std.Items.Add("ไม่เข้าร่วม")
            cbb_search_status_std.Items.Add("ทั้งหมด")

            cbb_search_dep.Enabled = False
            cbb_search_class.Enabled = False
            cbb_search_status_std.Enabled = False

            txt_path.Enabled = False
            txt_edit_std_id.Enabled = False
            txt_edit_std_fname.Enabled = False
            txt_edit_std_lname.Enabled = False
            rbtn_status_std_join.Enabled = False
            rbtn_status_std_not_join.Enabled = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub btn_confirm_search_std_act_Click(sender As Object, e As EventArgs) Handles btn_confirm_search_std_act.Click
        If cbb_search_act.Text = "กรุณาเลือกกิจกรรม" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        ElseIf cbb_search_dep.Text = "กรุณาเลือกสาขา" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        ElseIf cbb_search_class.Text = "กรุณาเลือกระดับชั้น" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        ElseIf cbb_search_status_std.Text = "กรุณาเลือกสถานะ" Then
            MsgBox("กรุณาเลือกข้อมูลให้ครบ", MsgBoxStyle.Exclamation, "Message")
            Return
        End If

        Try
            If btn_confirm_search_std_act.Text = "ยืนยัน" Then
                If MessageBox.Show("ต้องการที่จะยืนยันข้อมูลใช่ไหม", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                           , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    cbb_search_act.Enabled = False
                    cbb_search_dep.Enabled = False
                    cbb_search_class.Enabled = False
                    cbb_search_status_std.Enabled = False
                    txt_edit_std_id.Text = ""
                    txt_edit_std_fname.Text = ""
                    txt_edit_std_lname.Text = ""
                    rbtn_status_std_join.Checked = False
                    rbtn_status_std_not_join.Checked = False
                    DataGridView_check_std_not_join_act.DataSource = Nothing
                    btn_confirm_search_std_act.Text = "ยกเลิก"

                    If cbb_search_status_std.Text = "ทั้งหมด" Then
                        sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
                   "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
                   "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
                   "and tbl_student.class_id='" & keepvalue_search_class_id & "'"
                    Else
                        sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
                    "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
                    "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
                    "and tbl_student.class_id='" & keepvalue_search_class_id & "' and tbl_check_std_act.status_std_act='" & cbb_search_status_std.Text & "'"
                    End If

                    If cbb_search_class.Text = "ทั้งหมด" Then
                        sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
                   "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
                   "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
                   "and tbl_check_std_act.status_std_act='" & cbb_search_status_std.Text & "'"
                    End If

                    If cbb_search_class.Text = "ทั้งหมด" And cbb_search_status_std.Text = "ทั้งหมด" Then
                        sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
                    "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
                    "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "'"
                    End If

                    DataGridView_check_std_not_join_act.DataSource = cmd_dataTable()
                    change_all_column()
                    Set_DTG_edit_user()
                End If
            ElseIf btn_confirm_search_std_act.Text = "ยกเลิก" Then
                cbb_search_act.Enabled = True
                cbb_search_dep.Enabled = True
                cbb_search_class.Enabled = True
                cbb_search_status_std.Enabled = True
                txt_edit_std_id.Text = ""
                txt_edit_std_fname.Text = ""
                txt_edit_std_lname.Text = ""
                rbtn_status_std_join.Checked = False
                rbtn_status_std_not_join.Checked = False
                DataGridView_check_std_not_join_act.DataSource = Nothing
                btn_confirm_search_std_act.Text = "ยืนยัน"
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub btn_close_check_list_act_Click(sender As Object, e As EventArgs) Handles btn_close_check_list_act.Click
        Me.Close()
    End Sub

    Private Sub cbb_search_act_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbb_search_act.KeyPress, cbb_search_dep.KeyPress, _
        cbb_search_class.KeyPress, cbb_search_status_std.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbb_search_act_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_search_act.SelectedIndexChanged
        cbb_search_dep.Enabled = True
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

    Private Sub cbb_search_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_search_dep.SelectedIndexChanged
        cbb_search_class.Text = "กรุณาเลือกระดับชั้น"
        cbb_search_class.Enabled = True

        Try
            sql = "select class_name from tbl_class inner join tbl_department on tbl_department.dep_id=tbl_class.dep_id where tbl_department.dep_n='" & cbb_search_dep.Text & "'"
            cmd_db_to_obj(cbb_search_class)
            cbb_search_class.Items.Add("ทั้งหมด")
        Catch ex As Exception

        End Try

        Try
            connectdb()
            sql = "select dep_id from tbl_department where dep_n='" & cbb_search_dep.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_dep_id = dr.GetInt32("dep_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbb_search_class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_search_class.SelectedIndexChanged
        cbb_search_status_std.Enabled = True
        Try
            connectdb()
            sql = "select class_id from tbl_class where class_name='" & cbb_search_class.Text & "' and dep_id='" & keepvalue_search_dep_id & "'"

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                keepvalue_search_class_id = dr.GetInt32("class_id")
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_edit_std_act_Click(sender As Object, e As EventArgs) Handles btn_edit_std_act.Click
        Try
            If txt_edit_std_id.Text = "" Or txt_edit_std_fname.Text = "" Or txt_edit_std_lname.Text = "" Then
                MsgBox("กรุณาเลือกข้อมูล", MsgBoxStyle.Exclamation, "Message")
                Return
            End If

            connectdb()
            For x As Integer = 0 To DataGridView_check_std_not_join_act.Rows.Count - 1
                Dim txt_std_id As Long = DataGridView_check_std_not_join_act.Rows(x).Cells(0).Value
                Dim txt_status_std As String = DataGridView_check_std_not_join_act.Rows(x).Cells(4).Value
                sql = "update tbl_check_std_act set status_std_act=@status_std_act where std_id=@std_id"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@std_id", txt_std_id)
                cmd.Parameters.AddWithValue("@status_std_act", txt_status_std)
                If cmd.ExecuteNonQuery() = 0 Then MsgBox("ไม่สามารถบันทึกได้", MsgBoxStyle.Critical, "Message")
            Next
            sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
            cmd.Parameters.AddWithValue("@log_date", Date.Now)
            cmd.Parameters.AddWithValue("@log_operation", "แก้ไขสถานะการเข้าร่วมกิจกรรม : " + cbb_search_act.Text + " | สาขา : " + cbb_search_dep.Text + " | ระดับชั้น : " + cbb_search_class.Text)
            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("บันทึกข้อมูลสำเร็จ", MsgBoxStyle.Information, "Message")
            refresh_all_data_user()

            If cbb_search_status_std.Text = "ทั้งหมด" Then
                sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
           "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
           "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
           "and tbl_student.class_id='" & keepvalue_search_class_id & "'"
            Else
                sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
            "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
            "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
            "and tbl_student.class_id='" & keepvalue_search_class_id & "' and tbl_check_std_act.status_std_act='" & cbb_search_status_std.Text & "'"
            End If

            If cbb_search_class.Text = "ทั้งหมด" Then
                sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
           "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
           "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "' " +
           "and tbl_check_std_act.status_std_act='" & cbb_search_status_std.Text & "'"
            End If

            If cbb_search_class.Text = "ทั้งหมด" And cbb_search_status_std.Text = "ทั้งหมด" Then
                sql = "select tbl_check_std_act.std_id,std_title,std_fname,std_lname,status_std_act from tbl_check_std_act " +
            "inner join tbl_student on tbl_student.std_id=tbl_check_std_act.std_id " +
            "where tbl_check_std_act.act_id='" & keepvalue_search_act_id & "' and tbl_student.dep_id='" & keepvalue_search_dep_id & "'"
            End If

            DataGridView_check_std_not_join_act.DataSource = cmd_dataTable()

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DataGridView_check_std_not_join_act_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_check_std_not_join_act.CellClick
        rbtn_status_std_join.Enabled = True
        rbtn_status_std_not_join.Enabled = True
        Dim i As Integer = DataGridView_check_std_not_join_act.CurrentRow.Index
        Try
            Dim keepvalue_status_std As String
            txt_edit_std_id.Text = DataGridView_check_std_not_join_act.Item(0, i).Value
            txt_edit_std_fname.Text = DataGridView_check_std_not_join_act.Item(2, i).Value
            txt_edit_std_lname.Text = DataGridView_check_std_not_join_act.Item(3, i).Value
            keepvalue_status_std = DataGridView_check_std_not_join_act.Item(4, i).Value

            If keepvalue_status_std = "เข้าร่วม" Then
                rbtn_status_std_join.Checked = True

            ElseIf keepvalue_status_std = "ไม่เข้าร่วม" Then
                rbtn_status_std_not_join.Checked = True

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbtn_status_std_join_Click(sender As Object, e As EventArgs) Handles rbtn_status_std_join.Click
        Try
            Dim i As Integer = DataGridView_check_std_not_join_act.CurrentRow.Index
            DataGridView_check_std_not_join_act.Item(4, i).Value = "เข้าร่วม"
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub rbtn_status_std_not_join_Click(sender As Object, e As EventArgs) Handles rbtn_status_std_not_join.Click
        Try
            Dim i As Integer = DataGridView_check_std_not_join_act.CurrentRow.Index
            DataGridView_check_std_not_join_act.Item(4, i).Value = "ไม่เข้าร่วม"
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub btn_brownse_Click(sender As Object, e As EventArgs) Handles btn_brownse.Click
        SaveFileDialog_Export.FileName = ""
        'SaveFileDialog_Export.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog_Export.Filter = "PDF (*.pdf)|*.pdf"
        If SaveFileDialog_Export.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_path.Text = SaveFileDialog_Export.FileName
        End If
    End Sub
    Private Sub btn_export_file_Click(sender As Object, e As EventArgs) Handles btn_export_file.Click
        Try
            '**************************************** PDF ****************************************

            Dim Angsananew As BaseFont = BaseFont.CreateFont("c:\windows\fonts\ANGSA.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim THSaraban As BaseFont = BaseFont.CreateFont("c:\windows\fonts\THSarabun.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim Paragraph As New Paragraph ' declaration for new paragraph
            Dim Paragraph1 As New Paragraph ' declaration for new paragraph
            Dim Paragraph2 As New Paragraph ' declaration for new paragraph
            Dim logo_entech As System.Drawing.Image = System.Drawing.Image.FromHbitmap(My.Resources.logo_entech.GetHbitmap())
            Dim img As Image = Image.GetInstance(logo_entech, System.Drawing.Imaging.ImageFormat.Png)
            Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20) ' set pdf page size
            PdfFile.AddTitle(txt_title_file.Text) ' set our pdf title
            Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(txt_path.Text, FileMode.Create))
            PdfFile.Open()

            ' declaration font type
            'Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pTitle As New Font(THSaraban, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pTitle1 As New Font(THSaraban, 26, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pDate As New Font(THSaraban, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pTable As New Font(THSaraban, 14, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
            Dim pTable_header As New Font(THSaraban, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

            ' insert title into pdf file
            'img.ScalePercent(50.0F)
            img.Alignment = Element.ALIGN_CENTER
            img.ScaleToFit(150.0F, 150.0F)


            Paragraph1 = New Paragraph(New Chunk("En-tech", pTitle1))
            Paragraph1.Alignment = Element.ALIGN_CENTER
            Paragraph1.SpacingAfter = 10.0F
            Paragraph = New Paragraph(New Chunk(txt_title_file.Text, pTitle))
            Paragraph.Alignment = Element.ALIGN_CENTER
            Paragraph.SpacingAfter = 10.0F


            ' set and add page with current settings
            PdfFile.Add(img)
            PdfFile.Add(Paragraph1)
            PdfFile.Add(Paragraph)

            ' create data into table
            Dim PdfTable As New PdfPTable(DataGridView_check_std_not_join_act.Columns.Count)
            ' setting width of table
            PdfTable.TotalWidth = 500.0F
            PdfTable.LockedWidth = True

            Dim widths(0 To DataGridView_check_std_not_join_act.Columns.Count - 1) As Single
            For i As Integer = 0 To DataGridView_check_std_not_join_act.Columns.Count - 1
                widths(i) = 1.0F
            Next

            PdfTable.SetWidths(widths)
            PdfTable.HorizontalAlignment = 0
            PdfTable.SpacingBefore = 5.0F

            ' declaration pdf cells
            Dim pdfcell As PdfPCell = New PdfPCell

            ' create pdf header
            For i As Integer = 0 To DataGridView_check_std_not_join_act.Columns.Count - 1

                pdfcell = New PdfPCell(New Phrase(New Chunk(DataGridView_check_std_not_join_act.Columns(i).HeaderText, pTable_header)))
                ' alignment header table
                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ' add cells into pdf table
                PdfTable.AddCell(pdfcell)
            Next

            ' add data into pdf table
            For i As Integer = 0 To DataGridView_check_std_not_join_act.Rows.Count - 1
                For j As Integer = 0 To DataGridView_check_std_not_join_act.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(DataGridView_check_std_not_join_act(j, i).Value.ToString(), pTable))
                    PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    PdfTable.AddCell(pdfcell)
                Next
            Next

            ' add pdf table into pdf document
            PdfFile.Add(PdfTable)


            Dim DateNow = Format(Date.Now(), "dd MMM yyyy")

            Paragraph2 = New Paragraph(New Chunk("วันที่ " + DateNow, pDate))
            Paragraph2.Alignment = Element.ALIGN_RIGHT
            Paragraph2.SpacingAfter = 10.0F
            PdfFile.Add(Paragraph2)

            PdfFile.Close() ' close all sessions

            ' show message if hasben exported
            connectdb()
            sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
            cmd.Parameters.AddWithValue("@log_date", Date.Now)
            cmd.Parameters.AddWithValue("@log_operation", "Export PDF รายชื่อกิจกรรม : " + cbb_search_act.Text + " | สาขา : " + cbb_search_dep.Text + " | ระดับชั้น : " + cbb_search_class.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Export PDF Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("ไม่สามารถ Export ได้", MsgBoxStyle.Critical, "Message")
        End Try
    End Sub

    Private Sub btn_delete_std_act_Click(sender As Object, e As EventArgs) Handles btn_delete_std_act.Click
        If cbb_search_act.Text = "กรุณาเลือกกิจกรรม" Then
            MsgBox("กรุณาเลือกกิจกรรม", MsgBoxStyle.Critical, "Message")
            Return
        End If

        If MessageBox.Show("คุณต้องการจะลบรายชื่อกิจกรรม : " & cbb_search_act.Text, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                         , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            If cbb_search_class.Text = "ทั้งหมด" Then
                sql = "delete from tbl_check_std_act where act_id='" & keepvalue_search_act_id & "' and dep_id='" & keepvalue_search_dep_id & "'"
                If cmd_excuteNonquery() = 0 Then
                    MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
                Else
                    sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                    cmd.Parameters.AddWithValue("@log_date", Date.Now)
                    cmd.Parameters.AddWithValue("@log_operation", "ลบรายชื่อกิจกรรม : " + cbb_search_act.Text + " | สาขา : " + cbb_search_dep.Text + " | ระดับชั้น : " + cbb_search_class.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                    refresh_all_data_user()
                End If
                Return
            End If

            sql = "delete from tbl_check_std_act where act_id='" & keepvalue_search_act_id & "' " +
                "and class_id='" & keepvalue_search_class_id & "' and dep_id='" & keepvalue_search_dep_id & "'"
            If cmd_excuteNonquery() = 0 Then
                MsgBox("ไม่สามารถลบได้", MsgBoxStyle.Critical, "Message")
            Else
                sql = "insert into tbl_log (log_user,log_date,log_operation) values (@log_user,@log_date,@log_operation)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@log_user", FrmAdmin.lb_bot_nstatus.Text)
                cmd.Parameters.AddWithValue("@log_date", Date.Now)
                cmd.Parameters.AddWithValue("@log_operation", "ลบรายชื่อกิจกรรม : " + cbb_search_act.Text + " | สาขา : " + cbb_search_dep.Text + " | ระดับชั้น : " + cbb_search_class.Text)
                cmd.ExecuteNonQuery()

                MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "Message")
                refresh_all_data_user()
            End If
        Else
            Return
        End If
    End Sub
End Class