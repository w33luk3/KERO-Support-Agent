Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class ticketForm


    Private da As MySqlDataAdapter
    Private bsource As BindingSource = New BindingSource()
    Private ds As DataSet = Nothing
    Private sql As String
    Private conn As MySqlConnection
    Private iReturn As Boolean
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub LoadEmails()
        Try
            sql = "server=77.72.0.110; user id=tsniuk_wp; password=?CH0vdFv4f~$; database=tsniuk_wpdat"
            conn = New MySqlConnection(sql)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM wpiy_users WHERE user_email ='" & emailTextBox.Text & "'", conn)
            Dim myreader As MySqlDataReader
            myreader = cmd.ExecuteReader()
            myreader.Read()

            If myreader.HasRows Then
                nameeTextBox.Text = myreader.Item("user_login").ToString
                idTextBox.Text = myreader.Item("ID").ToString
                Label1.Visible = False

                SaveTicket()
            Else
                Label1.Visible = True
                ' Resize form from 264, 347 to 264, 430

                MessageBox.Show("This email address has not been resistered yet, please vist www.techstopni.uk to register your account", "Account Needed")


            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub SaveTicket()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MMM dd, yyyy hh:mm:ss"

        Using SQLConnection As New MySqlConnection("server=77.72.0.110; user id=tsniuk_wp; password=?CH0vdFv4f~$; database=tsniuk_wpdat")
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    'Cust_Name, Cust_Addr1, Cust_Addr2, Cust_Town, Cust_County, Cust_PostCode, Cust_Phone, Cust_Fax, Cust_Contact, 
                    '
                    '.CommandText = "INSERT INTO wpiy_wsdesk_tickets (ticket_id, ticket_author, ticket_email, ticket_date, ticket_updated, ticket_title, ticket_content, ticket_parent, ticket_category, ticket_vendor, ticket_trash) " &
                    '               "values (?Name, ?TicketEmail, ?TicketAuthor, ?Subject, ?Message)"
                    .CommandText = "INSERT INTO wpiy_wsdesk_tickets (ticket_author, ticket_email, ticket_title, ticket_content, ticket_date, ticket_category) " &
                               "values (?TicketAuthor, ?TicketEmail, ?Subject, ?Message, ?Date, ?Cat)"
                    '.CommandText = "INSERT INTO customer (Cust_Name, Cust_Addr1, Cust_Addr2, Cust_Town, Cust_County, Cust_PostCode, Cust_Phone, Cust_Fax, Cust_Contact, Cust_AccCode) " &
                    '               "values (?Name, ?Address1, ?Address2, ?Town, ?County, ?PostCode, ?Phone, ?Fax, ?Contact, ?AccountNumer)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    '16', '19', 'test@test.com', 'Jan 12, 2018 12:22:51 PM', '2018-01-12 13:51:47', 'test', 'test', '0', 'raiser_reply', '', '1'

                    .Parameters.AddWithValue("?Name", Trim(nameeTextBox.Text).ToString())
                    .Parameters.AddWithValue("?TicketEmail", Trim(emailTextBox.Text).ToString())
                    .Parameters.AddWithValue("?TicketAuthor", Trim(idTextBox.Text).ToString())
                    .Parameters.AddWithValue("?Subject", Trim(subjectTextBox.Text).ToString())
                    .Parameters.AddWithValue("?Message", Trim(messageTextBox.Text).ToString())
                    .Parameters.AddWithValue("?Date", (time.ToString(format)))
                    .Parameters.AddWithValue("?Cat", ("raiser_reply"))

                End With


                Try

                    ''If SQLConnection.State = ConnectionState.Open Then

                    ''    MsgBox("Open")
                    ''    MsgBox(sqlCommand.CommandText.ToString)
                    ''Else
                    ''    MsgBox("Closed")
                    ''End If

                    SQLConnection.Open()

                    sqlCommand.ExecuteNonQuery()


                    iReturn = True
                    Me.Hide()
                    Me.WindowState = FormWindowState.Minimized
                    trayIcon.Visible = True
                    clearTextboxes()
                    MessageBox.Show("Your ticket has been successfully sent, you should receive a confirmation email shortly", "Support Ticket Created")



                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                    iReturn = False
                Finally
                    SQLConnection.Close()
                End Try
            End Using
        End Using

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()


        Me.Top = (Screen.Height) - (Me.Height)
        Me.Left = (Screen.Width) - (Me.Width)
    End Sub

    Private Sub sendPictureBox_Click(sender As Object, e As EventArgs) Handles sendPictureBox.Click
        Try

            Dim conn = New MySqlConnection()
            ' conn.ConnectionString = connString
            conn.ConnectionString = "server=77.72.0.110; user id=tsniuk_wp; password=?CH0vdFv4f~$; database=tsniuk_wpdat"
            conn.Open()

            LoadEmails()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Me.Cursor = Cursors.SizeAll

    End Sub

    Private Sub mainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            'If pinIconPictureBox.Image Is unpin Then   #### is for docking to the rhs
            '    Me.Top = Cursor.Position.Y - mousey
            'Else
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            'End If

            'If Application.OpenForms().OfType(Of Forms).Any Then
            '    forms.Top = Cursor.Position.Y - mousey
            '    Form.Left = Cursor.Position.X - mousex

        End If


        trayIcon.Visible = False

    End Sub

    Private Sub trayIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles trayIcon.MouseClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            trayIcon.Visible = True
        Else
            Me.WindowState = FormWindowState.Normal
            trayIcon.Visible = True
            Me.Show()
        End If



        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()


        Me.Top = (Screen.Height) - (Me.Height)
        Me.Left = (Screen.Width) - (Me.Width)
    End Sub

    Private Sub closePictureBox_Click(sender As Object, e As EventArgs) Handles closePictureBox.Click
        Me.Hide()
        Me.WindowState = FormWindowState.Minimized
        trayIcon.Visible = True
    End Sub

    Private Sub clearTextboxes()
        nameeTextBox.Text = String.Empty
        idTextBox.Text = String.Empty
        nameTextBox.Text = String.Empty
        emailTextBox.Text = String.Empty
        subjectTextBox.Text = String.Empty
        messageTextBox.Text = String.Empty
    End Sub

    Private Sub websitePictureBox_Click(sender As Object, e As EventArgs) Handles websitePictureBox.Click
        Process.Start("https://www.techstopni.uk/client-home/")
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TableLayoutPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub TableLayoutPanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseUp
        drag = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub messageTextBox_TextChanged(sender As Object, e As EventArgs) Handles messageTextBox.TextChanged

    End Sub

    Private Sub TableLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseMove
        If drag Then
            'If pinIconPictureBox.Image Is unpin Then   #### is for docking to the rhs
            '    Me.Top = Cursor.Position.Y - mousey
            'Else
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            'End If

            'If Application.OpenForms().OfType(Of Forms).Any Then
            '    forms.Top = Cursor.Position.Y - mousey
            '    Form.Left = Cursor.Position.X - mousex

        End If


        trayIcon.Visible = False
    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged

    End Sub
End Class
