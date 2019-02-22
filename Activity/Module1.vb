Imports MySql.Data.MySqlClient

Module Module1

    Public conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=db_activity")
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public dr As MySqlDataReader
    Public sql As String
    Public Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        '' Note: call this from frm's Load event!
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 20
        frm.Location = New Point(x, y)
    End Sub



End Module
