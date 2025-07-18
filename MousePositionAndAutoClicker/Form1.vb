Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Form1
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    '==================================================================================================
    '====================================Variables=====================================================
    Dim OpenFileDialongFilenameString As String = 0

    Dim Commands(100) As String


    'Private Sub btnSubscribe_Click(sender As Object, e As EventArgs) Handles btnSubscribe.Click
    ' Replace with your actual PayPal subscription link
    ' Dim paypalUrl As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=YOUR_BUTTON_ID"
    '  Process.Start(paypalUrl)
    'End Sub

    '=================================================================================



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)

        Label8.Text = MousePosition.ToString()

    End Sub





    Dim BUttonINT As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Me.Cursor = New Cursor(Cursor.Current.Handle)
        'Cursor.Position = New Point(TextBox1.Text, TextBox2.Text)

        'gatthers listebox items in array and msgbox each one
        Dim I As Integer = 0
        Dim S As String = ListBox1.Items(I)

        Do While Not S Is Nothing
            Try
                MsgBox(S)
                I = I + 1
                S = ListBox1.Items(I)
            Catch ex As Exception
                S = Nothing

            End Try

        Loop
        ' If S = "Type" Then
        'MsgBox(S)
        ' I = I + 1
        '  S = ListBox1.Items(I)
        ' MsgBox("Text to type=" & S)
        ' End If




        'This code makes Label6 adds itself +1 everytime it is pressed.
        'Label6.Text += 1
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(TextBox1.Text, TextBox2.Text)


        If RadioButton1.Checked = True Then
            mouse_event(&H2, 0, 0, 0, 1)
            mouse_event(&H4, 0, 0, 0, 1)
        ElseIf RadioButton2.Checked = True Then
            mouse_event(&H8, 0, 0, 0, 1)
            mouse_event(&H10, 0, 0, 0, 1)

        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                Dim text As String = path

                ' For debugging.
                OpenFileDialongFilenameString = text.ToString()

                'If condition, Choice between (Load it all)-(Line By Line)
                If CheckBox1.Checked = True Then
                    'Code ran when checkbox is checked
                    'Call LoadToListBox()


                    'Code to read line-by;line
                    Call readlinebyline()

                    'If "Load file to listbox" is not checked.
                Else
                    'Call filereader1()
                    Call readfirstline()

                End If
            Catch ex As Exception

                ' Report an error.
                OpenFileDialongFilenameString = "Error"
                MsgBox(OpenFileDialongFilenameString)
            End Try
        End If
    End Sub


    '===============================CALL SUBS=========================================


    Sub filereader1()
        Dim fileReader As String
        Try
            fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialongFilenameString.ToString())
            Label7.Text = fileReader.ToString()
            File.ReadLines(OpenFileDialongFilenameString)
        Catch
            MsgBox("Error reading file")
        End Try
    End Sub

    Sub LoadToListBox()

        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialongFilenameString)


        stringReader = fileReader.ReadToEnd()
        ListBox1.Items.Add(stringReader.ToString())

    End Sub
    Sub readlinebyline()
        Dim objStreamReader As StreamReader
        Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(OpenFileDialongFilenameString)

        'Read the first line of text.
        strLine = objStreamReader.ReadLine

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing

            'Write the line to the Console window.
            ListBox1.Items.Add(strLine)

            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop

        'Close the file.
        objStreamReader.Close()
    End Sub



    Dim stringReader As String
    Sub readfirstline()
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialongFilenameString)


            stringReader = fileReader.ReadLine()
            MsgBox("The first line of the file is " & stringReader)

            If stringReader = "Click" Then
                stringReader = fileReader.ReadLine()
                MsgBox("X=" & stringReader)
                stringReader = fileReader.ReadLine()
                MsgBox("Y=" & stringReader)
            End If


            If stringReader = "Type" Then
                stringReader = fileReader.ReadLine()
                MsgBox("Typ" & stringReader)

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub





    '==================================MINOR SUBS============================


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ListBox1.Items.Add("Click")
        ListBox1.Items.Add(TextBox1.Text)
        ListBox1.Items.Add(TextBox2.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Try
            TextBox1.Text = TextBox1.Text * 1
        Catch ex As Exception
            TextBox1.Text = 777
            MsgBox("Textbox1 & 2 must be numberical values")
        End Try


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            TextBox2.Text = TextBox2.Text * 1
        Catch ex As Exception
            TextBox2.Text = 777
            MsgBox("Textbox1 & 2 must be numberical values")
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub


    '===================================Imaginary:Source Subs--------------------------
    Sub ReadListBox1AsAnArray()
        'gatthers listebox items in array and msgbox each one
        Dim I As Integer = 0
        Dim S As String = ListBox1.Items(I)

        Do While Not S Is Nothing
            Try
                MsgBox(S)
                I = I + 1
                S = ListBox1.Items(I)
            Catch ex As Exception
                S = Nothing

            End Try


        Loop

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class
