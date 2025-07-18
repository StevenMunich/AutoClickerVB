Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO




Public Class Form2


    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10


    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Declare Sub Sleep Lib "kernel32" (ByVal milliseconds As Long)




    '==================================STARTING CODE=====================================================
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MousePosTimer.Start()
    End Sub

    Private Sub MousePosTimer_Tick(sender As Object, e As EventArgs) Handles MousePosTimer.Tick
        Label2.Text = MousePosition.ToString()

        If GetAsyncKeyState(Keys.S) Then

            Me.Cursor = New Cursor(Cursor.Current.Handle)
            TextBox1.Text = Cursor.Position.X
            TextBox2.Text = Cursor.Position.Y
        End If

    End Sub



    '===============================PRIVATE SUBS=======================================
    Dim Int4Timer1 As Integer = 1
    Dim DIalTimerBool As Boolean = False

    Dim RESTART As Boolean = False

    Sub DialNumber()

        'NOTE: Loop is created
        'Restart code, stops timer1. Values are reset for when it is turned on in code.
        'Value of Timer that restarts everything, Label3.text, is reset to = 0
        If RESTART = True Then
            Timer1.Stop()
            RESTART = False
            Label3.Text = 0
        End If

        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(202, 218)
        'Left click AT 675,197

        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        'wait


        'sets interval of timer to 5sec
        Int4Timer1 = 5000
        DIalTimerBool = True
        Timer1.Interval = Int4Timer1
        Timer1.Start()




    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text += 1
        If DIalTimerBool = True Then
            'Types # in dialpad
            My.Computer.Keyboard.SendKeys("2392362000")
            'Calls #
            My.Computer.Keyboard.SendKeys("{Enter}")
            My.Computer.Keyboard.SendKeys("{Enter}")
            My.Computer.Keyboard.SendKeys("{Enter}")
            Call callNumber()
            DIalTimerBool = False
        End If

        'waits x amount of seconds

        If Label3.Text = 13 Then
            'Hangs up
            Me.Cursor = New Cursor(Cursor.Current.Handle)
            Cursor.Position = New Point(1570, 200)
            'Left click AT 675,197

            mouse_event(&H2, 0, 0, 0, 1)
            mouse_event(&H4, 0, 0, 0, 1)
        End If


        'Note: Loop Created
        'After (5sec x 20)= 100 seconds it restarts, but boolean turns timer1 off as well
        'Comeplete Restart, Dialnumber innitiates code and is called at end, creating
        'A Loop. 
        If Label3.Text = 20 Then
            RESTART = True
            Call DialNumber()
        End If


    End Sub



    'NOT NEEDED
    Dim callnumberTimerBool As Boolean = False
    Sub callNumber()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(1387, 281)
        'Left click AT 1496, 200
        'wait 3 seconds then clicks in timer1_Sub

        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        Int4Timer1 = 3000
        callnumberTimerBool = True
        Timer1.Interval = Int4Timer1
        Timer1.Start()


    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call DialNumber()
    End Sub

















    '=======================================NEWBIECODE=============================================


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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        System.Diagnostics.Process.Start("https://hangouts.google.com/?action=chat&pn=%2B12392362000&hl=en")

    End Sub
End Class