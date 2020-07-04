Public Class add
    Private Sub add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#f6e79c")
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from titles"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            comboAccount.Items.Add(sqldr("title"))
        End While
        sqldr.Close()
        sqlcmd.Dispose()
        sqlcon.Close()
        comboAccount.SelectedIndex = 0
        comboType.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim oldMonthText As String = DateTimePicker1.Text.ToString
        Dim newMonthText As String
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM yyyy"
        newMonthText = DateTimePicker1.Text
        If amountTB.Text = "" Then
            MsgBox("Please specify how much.")
        Else
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "insert into transaction values('','" & amountTB.Text & "','" & id.Text & "','" & comboType.Text & "','" & comboAccount.Text & "','" & oldMonthText & "', '" & newMonthText & "')"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcmd.CommandText = "update business set lastTransaction='" & DateTimePicker1.Text.ToString & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            main.loadMonth()
            main.loadTaccount()
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub amountTB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles amountTB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Letters are not allowed!", vbCritical, "Invalid Input!")
            e.Handled = True
        End If
    End Sub
End Class