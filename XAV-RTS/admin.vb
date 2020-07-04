Public Class admin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub loadTitles()
        titleList.Columns.Clear()
        titleList.Columns.Add("Priority", CInt(titleList.Width / 7))
        titleList.Columns.Add("Account Name", CInt(titleList.Width / 1))

        titleList.Items.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from titles"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Dim lv As ListViewItem
            lv = titleList.Items.Add(sqldr("priority").ToString)
            lv.SubItems.Add(sqldr("title").ToString)
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
    End Sub
    Private Sub admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#f6e79c")
        loadAdminPass()
        loadTitles()
        loadBusinessName()

    End Sub
    Sub loadAdminPass()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from login"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            adminPassTB.Text = sqldr("pass")
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passUpdateBTN.Click
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "update login set pass='" & adminPassTB.Text & "'"
        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        sqlcon.Close()
        MsgBox("Password Updated!", vbInformation)
    End Sub


    Private Sub addTitleBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addTitleBTN.Click
        If newTitle.Text = "" Then
        Else
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "insert into titles values('" & prioID.Text & "','" & newTitle.Text & "')"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            MsgBox("Successfully Added!", vbInformation)
            newTitle.Text = ""
            loadTitles()
        End If
    

    End Sub

   

    Private Sub titleList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles titleList.Click
        Dim selectTitle As String = titleList.Items(titleList.FocusedItem.Index).SubItems(1).Text
        Dim confirm = MsgBox("Are you sure you want to delete " + selectTitle, vbYesNo + vbQuestion)
        If confirm = vbYes Then
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "delete from titles where title='" & selectTitle & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            MsgBox("Successfully Deleted!", vbInformation)
            newTitle.Text = ""
            loadTitles()
        End If
    
    End Sub

    Private Sub prioID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles prioID.MouseClick
        prioID.SelectAll()
    End Sub

    Private Sub newTitle_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles newTitle.MouseClick
        newTitle.SelectAll()
    End Sub

    Private Sub loadBusinessName()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from business"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            updateBusinessName.Text = sqldr("businessName")
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
    End Sub

    Private Sub newBusinessName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles updateBusinessName.MouseClick
        updateBusinessName.SelectAll()
    End Sub

    Private Sub bname_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bname_btn.Click
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "update business set businessName='" & updateBusinessName.Text & "' where businessID='" & main.lbl_businessID.Text & "'"
        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        sqlcon.Close()
        MsgBox("Business Name was Updated!")

    End Sub
End Class