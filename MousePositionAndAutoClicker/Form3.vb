
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Form3

    '// CONSTANTS FOR MOUSE EVENT
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    '// Functions
    '// GETS KEYSTROKES
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    '// Mouse_event for clicks,
    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)
    '//UNUSED FUNCTION
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    '// Global Variables
    Dim OpenFileDialongFilenameString As String = 0
    Dim X As Integer
    Dim Y As Integer
    Dim CrownJEWBool As Boolean = False
    Dim LoopRun As Boolean = True

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MousePositionTImer.Start()
    End Sub

    Private Sub MousePositionTImer_Tick(sender As Object, e As EventArgs) Handles MousePositionTImer.Tick
        lblMousePosition.Text = MousePosition.ToString() 'Shows X,Y coordinates on screen

        If GetAsyncKeyState(Keys.Insert) Then 'copies X,Y coordinates when 'INSERT' key is pressed.
            Me.Cursor = New Cursor(Cursor.Current.Handle)
            TbxX.Text = Cursor.Position.X
            TbxY.Text = Cursor.Position.Y
        End If

        If GetAsyncKeyState(Keys.End) Then

            MsgBox("Fire")
            ' LoopRun = False
            ' CheckBox1.Checked = False
            'Timer1.Stop()
        End If




    End Sub



    'LOAD FILE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()  ' Call ShowDialog

        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try

                Dim text As String = path ' Read in text.

                ' For debugging.
                OpenFileDialongFilenameString = text.ToString()

                Call readlinebyline() 'Code to read line-by;line

            Catch ex As Exception
                MsgBox("Error opening" & OpenFileDialongFilenameString)
            End Try
        End If
    End Sub

    'SAVE FILE
    Dim SaveFileDialongFilenameString As String = 0
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim result As DialogResult = SaveFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = SaveFileDialog1.FileName
            Try
                ' Read in text.
                Dim text As String = path

                ' For debugging.
                SaveFileDialongFilenameString = text.ToString()
            Catch
                MsgBox("ERROR PROCESSING")
            End Try
            'MsgBox(SaveFileDialongFilenameString) '//for debugging
        End If

        Try
            Dim SI As Integer = 0
            Dim SI5 As String = ListBox2.Items.Count
            MsgBox(SI5)

            Dim file As System.IO.StreamWriter 'retrieves file name & location
            file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialongFilenameString, True)

            'writes data to the file
            Do While SI < SI5
                file.WriteLine(ListBox2.Items(SI))
                SI = SI + 1
            Loop

            file.Close()
        Catch ex As Exception
            MsgBox("ERROR SAVING")
        End Try

    End Sub

    'TEST
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnTEST.Click
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(TbxX.Text, TbxY.Text)

        If RadioButton1.Checked = True Then
            mouse_event(&H2, 0, 0, 0, 1)
            mouse_event(&H4, 0, 0, 0, 1)
        ElseIf RadioButton2.Checked = True Then
            mouse_event(&H8, 0, 0, 0, 1)
            mouse_event(&H10, 0, 0, 0, 1)
        End If

    End Sub

    'Add Click CMD
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnClickCMD.Click

        Dim S As String = "M"
        If RadioButton1.Checked = True Then
            S = "L"
        ElseIf RadioButton2.Checked = True Then
            S = "R"
        End If

        ListBox2.Items.Add(S & TbxX.Text + " " & TbxY.Text)

    End Sub

    'Add Type CMD
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles BtnAddKeyCMD.Click
        If TbxKeyBoardCMD.Text = Nothing Then
            MsgBox("Add A Text to Say", vbOKOnly)
        Else
            ListBox2.Items.Add("T" & TbxKeyBoardCMD.Text)
        End If

    End Sub
    'Add Wait CMD
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles BtnWaitCMD.Click
        ListBox2.Items.Add("W" & TextBox4.Text)
    End Sub



    '=======================+++^^^^^^^^^^^CROWNING JEWEL^^^^^^^^^^^^+++========================='



    'RUNS THE BOT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRun.Click



        Timer1.Start()

        '//WORKING CODE
        If CheckBox1.Checked = True Then


            While LoopRun = True
                Call CrownJewel()
            End While
            '//END LoOp when Home Key is pressed(line  ). Boolean is set to false
        Else

            Call CrownJewel()
        End If



    End Sub

    'DELETE
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndices(0))
        Catch ex As Exception 'if Value is NULL nothing is done, error is handled
        End Try 'TRY STATEMENT INCASE A NULL VALUE CREATES AN ERROR.
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles btnClrRadio.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub


    '==============================CALLED SUBS===================================
    '// 5 MAIN FUNCTIONS: 1Right_CLICK: 2Left_Click: 3Move_Mouse: 4TYPE_KEYBOARD: 5WAIT_(x)amount


    Sub CrownJewel()


        Dim I As Integer = 0
        Dim amount As String = ListBox2.Items.Count

        If amount = I Then 'I = the amount on list, needs to be reset to zero for next time.
            I = 0
        Else

            Do Until I = amount
                Dim S As String = ListBox2.Items(I) 'Item on List; Commands Followed by Next.         
                Dim SS As String = S.Chars(0) 'First Character of Line: R L M T W

                '//1st FUNCTION
                If (SS = "R") Then 'Right Clicks
                    Dim coordinates() As String = S.Substring(1).Split(" ") ' After 1 string split by " "
                    X = Convert.ToInt32(coordinates(0))
                    Y = Convert.ToInt32(coordinates(1))
                    Me.Cursor = New Cursor(Cursor.Current.Handle)
                    Cursor.Position = New Point(X, Y)
                    mouse_event(&H8, 0, 0, 0, 1)
                    mouse_event(&H10, 0, 0, 0, 1)

                    '//2nd FUNCTION
                ElseIf (SS = "L") Then 'Left Click
                    Dim coordinates() As String = S.Substring(1).Split(" ")
                    X = Convert.ToInt32(coordinates(0))
                    Y = Convert.ToInt32(coordinates(1))
                    Me.Cursor = New Cursor(Cursor.Current.Handle)
                    Cursor.Position = New Point(X, Y)
                    mouse_event(&H2, 0, 0, 0, 1)
                    mouse_event(&H4, 0, 0, 0, 1)


                    '//3rd FUNCTION
                ElseIf (SS = "M") Then 'Moves mouse without Clicking
                    Dim coordinates() As String = S.Substring(1).Split(" ")
                    X = Convert.ToInt32(coordinates(0))
                    Y = Convert.ToInt32(coordinates(1))
                    Me.Cursor = New Cursor(Cursor.Current.Handle)
                    Cursor.Position = New Point(X, Y)


                    '//4th FUNCTION - To Type Text/Keystrokes ^c for CTRL+C ^v for CTRL+V ^a for CTRL+A &a for ALT+A *a for SHIFT+A 
                ElseIf (SS = "T") Then
                    Dim Text2Type As String = S.Substring(1) 'grabs text to send
                    My.Computer.Keyboard.SendKeys(Text2Type) 'types in text

                    '//5th FUNCTION - To Wait
                ElseIf (SS = "W") Then
                    Dim TIME As String = S.Substring(1) 'gets time value
                    Try
                        System.Threading.Thread.Sleep(TIME * 1000) 'times by milliseconds
                    Catch ex As Exception
                    End Try
                Else
                    'null
                End If
                I += 1 'runs next commands
            Loop

        End If



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
            '//STEVENS NOTES: Changed to add to a LISTBOX
            ListBox2.Items.Add(strLine)

            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop

        'Close the file.
        objStreamReader.Close()
    End Sub



    'WriteFile(TEST) -----IS NOT USED
    Private Sub WriteFile()

        Dim SI As Integer = 0
        Dim SI5 As String = ListBox2.Items.Count
        MsgBox(SI5)

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("c:\Gmail\test.txt", True)


        Do While SI < SI5
            file.WriteLine(ListBox2.Items(SI))
            SI = SI + 1
        Loop

        file.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClearList.Click

        ListBox2.Items.Clear()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        LoopRun = True
    End Sub


End Class