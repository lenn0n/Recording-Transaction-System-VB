Public Class main
    Dim isLogin As Boolean = False
    Dim pass As String
    Dim isMatch As Boolean = False
    Dim businessID As Integer
    Dim businessName As String
    Dim owneroftheBusiness As String
    Dim bType As String
    Dim tAccountLeft As Integer = 30
    Dim columns As ArrayList = New ArrayList()
    'Okay, our identifier which business we are dealing off, we have global variables:
    'businessID = the uniqueness of each business in the database.
    'businessName = the name of the business.
    'Lastly, owneroftheBusiness = the name of the owner of the business.
    Private Sub checkerID_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkerID.Tick
        If isLogin = True Then
            loginpanel.Hide()
            infoLabel.Show()
        Else
            infoLabel.Hide()
            loginpanel.Show()
            greetingspanel.Hide()
            menutabs.Enabled = False
        End If
    End Sub
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkerID.Start()
        loadBusinessNames()
        Me.BackColor = ColorTranslator.FromHtml("#5588a3")
        menutabs.BackColor = ColorTranslator.FromHtml("#00334e")
        tAccountPanel.BackColor = ColorTranslator.FromHtml("#e8e8e8")
        greetingspanel.BackColor = ColorTranslator.FromHtml("#e8e8e8")
        menutabs.ForeColor = Color.White
        loginpanel.BackColor = ColorTranslator.FromHtml("#e8e8e8")
    End Sub
    Sub loadMonth()
        Dim month As ArrayList = New ArrayList()
        hideCombi.Items.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from transaction where businessID='" & businessID & "'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            If hideCombi.Items.Contains(sqldr("monthYear")) Then
            Else
                hideCombi.Items.Add(sqldr("monthYear"))
            End If
        End While
        sqldr.Close()
        sqlcmd.Dispose()
        sqlcon.Close()
        If hideCombi.Items.Count > 0 Then
            hideCombi.Show()
            hideLabel.Show()
            hideCombi.SelectedIndex = 0
        Else
            hideCombi.Hide()
            hideLabel.Hide()
        End If
    End Sub
    Private Sub eventTrigger(ByVal Sendr As Object, ByVal e As EventArgs)
        Dim lv As ListView
        lv = CType(Sendr, ListView)
        MsgBox(lv.FocusedItem.Text)
    End Sub
    Sub loadTaccount()
        columns.Clear()
        tAccountLeft = 30
        tAccountPanel.Show()
        'madugo ito, hahaha let's start!
        tAccountPanel.Controls.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from transaction where businessID='" & businessID & "' and monthYear='" & hideCombi.Text & "' ORDER BY id ASC"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            If columns.Contains(sqldr("title")) Then
            Else
                columns.Add(sqldr("title"))
            End If
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        For Each items In columns
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from transaction where businessID='" & businessID & "' and title='" & items & "' and monthYear='" & hideCombi.Text & "' ORDER BY id ASC"
            sqldr = sqlcmd.ExecuteReader
            Dim groupBox As New GroupBox
            Dim lv As New ListView
            With groupBox
                .Top = 30
                .Left = tAccountLeft
                .Text = items
                .Size = New Size(280, 300)
                .Font = New Font("Times New Roman", 14, FontStyle.Bold)
            End With
            With lv
                .Top = 30
                .Left = 10
                .Height = 260
                .Width = 260
                .Name = items
                .Columns.Add("ID", CInt(lv.Width / 100))
                .Columns.Add("Date", CInt(lv.Width / 2.4))
                .Columns.Add("Debit", CInt(lv.Width / 3.5))
                .Columns.Add("Credit", CInt(lv.Width / 3.5))
                .View = View.Details
                .GridLines = True
                .FullRowSelect = True
                .Font = New Font("Times New Roman", 14, FontStyle.Regular)
            End With
            Dim totalDebit As Integer = 0
            Dim totalCredit As Integer = 0
            While (sqldr.Read)
                Dim putZeroTo As ListViewItem
                If sqldr("type") = "Debit" Then
                    putZeroTo = lv.Items.Add(sqldr("id"))
                    putZeroTo.SubItems.Add(sqldr("date"))
                    putZeroTo.SubItems.Add(sqldr("amount"))
                    putZeroTo.SubItems.Add(" ")
                    totalDebit += Val(sqldr("amount"))
                Else
                    putZeroTo = lv.Items.Add(sqldr("id"))
                    putZeroTo.SubItems.Add(sqldr("date"))
                    putZeroTo.SubItems.Add(" ")
                    putZeroTo.SubItems.Add(sqldr("amount"))
                    totalCredit += Val(sqldr("amount"))
                End If
            End While
            Dim totalofAll As Integer = 0
            If totalDebit > totalCredit Then
                'this is debit section
                totalofAll = totalDebit - totalCredit
                Dim putZeroTo As ListViewItem
                putZeroTo = lv.Items.Add("Balances: " + totalofAll.ToString)
                putZeroTo.SubItems.Add("Balances: ")
                putZeroTo.SubItems.Add(totalofAll)
                putZeroTo.SubItems.Add(" ")
            Else
                'this is credit section
                Dim putZeroTo As ListViewItem
                totalofAll = totalCredit - totalDebit
                putZeroTo = lv.Items.Add("Balances: " + totalofAll.ToString)
                putZeroTo.SubItems.Add("Balances: ")
                putZeroTo.SubItems.Add(" ")
                putZeroTo.SubItems.Add(totalofAll)
            End If
            groupBox.Controls.Add(lv)
            tAccountPanel.Controls.Add(groupBox)
            tAccountLeft += 295
            sqlcmd.Dispose()
            sqldr.Close()
            sqlcon.Close()
            AddHandler lv.Click, AddressOf eventTrigger 'This is the event trigger. Cool!
        Next
        Dim spaces As New PictureBox
        With spaces
            .Top = 30
            .Left = tAccountLeft - 80
        End With
        tAccountPanel.Controls.Add(spaces)
    End Sub
    Sub logMe()
        Try
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from login"
            sqldr = sqlcmd.ExecuteReader
            While sqldr.Read
                If sqldr("pass") = passTB.Text Then
                    isMatch = True
                End If
            End While
            sqlcmd.Dispose()
            sqldr.Close()
            sqlcon.Close()
        Catch ex As Exception
            MsgBox("Please connect to XAMPP and start Apache and mySQL.", vbInformation)
            Me.Close()
        End Try
    End Sub
    Sub loadBusinessNames()
        Try
            businessSelector.Items.Clear()
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from business"
            sqldr = sqlcmd.ExecuteReader
            While sqldr.Read
                businessSelector.Items.Add(sqldr("businessName"))
            End While
            sqlcmd.Dispose()
            sqldr.Close()
            sqlcon.Close()
            Try
                businessSelector.SelectedIndex = 0 'lets just make it not empty
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox("Please connect to XAMPP and start Apache and mySQL.", vbInformation)
            Me.Close()
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles passTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            logMe() 'login method!
            If isMatch = True Then
                isLogin = True
                isMatch = False 'Lets return to original state, for later use of login.
                greetingspanel.Show()
            Else
                MsgBox("Invalid Pass", vbCritical) 'Too Bad!
                passTB.Clear()
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim isDone = MsgBox("Are you sure you want to close?", vbYesNo + vbInformation, "Confirm Exit?")
        If isDone = vbYes Then
            Me.Close() 'Goodbye!
        Else
            Exit Sub 'Nothing to do!
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles existingBusiness.CheckedChanged
        If existingBusiness.Checked = True Then
            businessSelector.Enabled = True
            newBusinessName.Enabled = False
            newBusinessOwner.Enabled = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            businessSelector.Enabled = False
            newBusinessName.Enabled = True
            newBusinessOwner.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_greetings_proceed.Click
        If existingBusiness.Checked = True Then
            'use already created business
            If businessSelector.Text = "" Then
                MsgBox("Not available business entity!")
            Else
                sqlcon.Open()
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select * from business where businessName ='" & businessSelector.Text & "'"
                sqldr = sqlcmd.ExecuteReader
                While sqldr.Read
                    owneroftheBusiness = sqldr("ownerName")
                    businessID = sqldr("businessID")
                    lbl_businessID.Text = sqldr("businessID")
                    businessName = businessSelector.Text
                End While
                sqlcmd.Dispose()
                sqldr.Close()
                sqlcon.Close()
                greetingspanel.Hide()
                menutabs.Enabled = True
                infoLabel.Text = "Business Info: (" + businessName.ToString + ") " + owneroftheBusiness.ToString + ""
                loadMonth()
                loadTaccount()
                loadBusinessNames()
            End If
        Else
            'create new business
            If newBusinessName.Text = "" Or newBusinessOwner.Text = "" Then
                MsgBox("Please input first!")
            Else
                If newBusinessName.Text.Contains("'") Or newBusinessOwner.Text.Contains("'") Then
                    MsgBox("Sorry! Single Quotation ( ' ) is not allowed to input.", vbCritical)
                Else
                    'lets check if business is already exist!
                    Dim isAlreadyCreated As Boolean = False
                    sqlcon.Open()
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "select * from business where businessName ='" & newBusinessName.Text & "'"
                    sqldr = sqlcmd.ExecuteReader
                    While sqldr.Read
                        isAlreadyCreated = True
                    End While
                    sqlcmd.Dispose()
                    sqldr.Close()
                    sqlcon.Close()
                    If isAlreadyCreated = False Then
                        'okay time to add to database
                        Dim dt As Date = Date.Today
                        Dim dateNow As String = dt.ToString("MMMM'/'dd'/'yyyy")
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = "insert into business values(' ','" & newBusinessName.Text & "','" & newBusinessOwner.Text & "','" & dateNow & "')"
                        sqlcmd.ExecuteNonQuery()
                        sqlcmd.Dispose()
                        sqlcon.Close()
                        MsgBox("Sucessfully Created!", vbInformation)
                        greetingspanel.Hide()
                        menutabs.Enabled = True
                        'but I have to get its ID! so lets do it again!
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = "select * from business where businessName='" & newBusinessName.Text & "'"
                        sqldr = sqlcmd.ExecuteReader
                        While sqldr.Read
                            owneroftheBusiness = sqldr("ownerName")
                            businessID = sqldr("businessID") 'this is all I want!
                            businessName = newBusinessName.Text
                            lbl_businessID.Text = sqldr("businessID")
                        End While
                        sqlcmd.Dispose()
                        sqldr.Close()
                        sqlcon.Close()
                        'so we can populate below the label infoLabel.text, this is important also for global identifier.
                        infoLabel.Text = "Business Info: (" + businessName.ToString + ") " + owneroftheBusiness.ToString + ""
                        loadMonth()
                        loadTaccount()
                        existingBusiness.Checked = True
                        loadBusinessNames()
                    Else
                        MsgBox("Sorry! This business name was already created! Please choose another", vbCritical)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ChangeBusinessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeBusinessToolStripMenuItem.Click
        greetingspanel.Show()
        menutabs.Enabled = False
        tAccountPanel.Hide()
        infoLabel.Text = ""
        hideLabel.Hide()
        hideCombi.Hide()
    End Sub
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        add.id.Text = businessID
        add.Show()
        add.Focus()
    End Sub
    Private Sub DeleteBusinessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBusinessToolStripMenuItem.Click
        'delete section
        Dim delete = MsgBox("Are you sure you want to delete all recorded transactions in " + businessName + "?", vbYesNo + vbQuestion)
        If delete = vbYes Then
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "delete from business where businessID='" & businessID & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcmd.CommandText = "delete from transaction where businessID='" & businessID & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            menutabs.Enabled = False
            loadBusinessNames()
            tAccountPanel.Hide()
            greetingspanel.Show()
            infoLabel.Text = ""
            hideLabel.Hide()
            hideCombi.Hide()
            MsgBox("Deleted Successfully!", vbInformation)
        Else
        End If
    End Sub
    Private Sub UpdateSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSettingsToolStripMenuItem.Click
        admin.Show()
        admin.Focus()
    End Sub
    Private Sub newBusinessName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles newBusinessName.MouseClick
        newBusinessName.SelectAll()
    End Sub
    Private Sub newBusinessOwner_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles newBusinessOwner.MouseClick
        newBusinessOwner.SelectAll()
    End Sub
    Private Sub hideCombi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hideCombi.SelectedIndexChanged
        loadTaccount()
    End Sub
End Class
