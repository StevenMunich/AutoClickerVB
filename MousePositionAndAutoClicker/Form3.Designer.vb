<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.BtnRun = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MousePositionTImer = New System.Windows.Forms.Timer(Me.components)
        Me.btnClrRadio = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnClickCMD = New System.Windows.Forms.Button()
        Me.btnTEST = New System.Windows.Forms.Button()
        Me.TbxY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbxX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddKeyCMD = New System.Windows.Forms.Button()
        Me.TbxKeyBoardCMD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BtnWaitCMD = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.LblPosition = New System.Windows.Forms.Label()
        Me.lblMousePosition = New System.Windows.Forms.Label()
        Me.lblPressInsert = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnRun
        '
        Me.BtnRun.Location = New System.Drawing.Point(327, 90)
        Me.BtnRun.Name = "BtnRun"
        Me.BtnRun.Size = New System.Drawing.Size(85, 36)
        Me.BtnRun.TabIndex = 2
        Me.BtnRun.Text = "RUN"
        Me.BtnRun.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(328, 186)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 25)
        Me.BtnLoad.TabIndex = 4
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MousePositionTImer
        '
        '
        'btnClrRadio
        '
        Me.btnClrRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrRadio.Location = New System.Drawing.Point(125, 335)
        Me.btnClrRadio.Name = "btnClrRadio"
        Me.btnClrRadio.Size = New System.Drawing.Size(43, 20)
        Me.btnClrRadio.TabIndex = 30
        Me.btnClrRadio.Text = "Clear"
        Me.btnClrRadio.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(107, 312)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton2.TabIndex = 29
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "+Right Click"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(107, 291)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1.TabIndex = 28
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "+Left Click"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnClickCMD
        '
        Me.btnClickCMD.Location = New System.Drawing.Point(4, 325)
        Me.btnClickCMD.Name = "btnClickCMD"
        Me.btnClickCMD.Size = New System.Drawing.Size(100, 38)
        Me.btnClickCMD.TabIndex = 27
        Me.btnClickCMD.Text = "Add Click Cmd"
        Me.btnClickCMD.UseVisualStyleBackColor = True
        '
        'btnTEST
        '
        Me.btnTEST.Location = New System.Drawing.Point(12, 286)
        Me.btnTEST.Name = "btnTEST"
        Me.btnTEST.Size = New System.Drawing.Size(89, 23)
        Me.btnTEST.TabIndex = 26
        Me.btnTEST.Text = "Test"
        Me.btnTEST.UseVisualStyleBackColor = True
        '
        'TbxY
        '
        Me.TbxY.Location = New System.Drawing.Point(16, 259)
        Me.TbxY.Name = "TbxY"
        Me.TbxY.Size = New System.Drawing.Size(100, 20)
        Me.TbxY.TabIndex = 25
        Me.TbxY.Text = "675"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Y"
        '
        'TbxX
        '
        Me.TbxX.Location = New System.Drawing.Point(16, 233)
        Me.TbxX.Name = "TbxX"
        Me.TbxX.Size = New System.Drawing.Size(100, 20)
        Me.TbxX.TabIndex = 23
        Me.TbxX.Text = "667"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "X"
        '
        'BtnAddKeyCMD
        '
        Me.BtnAddKeyCMD.Location = New System.Drawing.Point(131, 259)
        Me.BtnAddKeyCMD.Name = "BtnAddKeyCMD"
        Me.BtnAddKeyCMD.Size = New System.Drawing.Size(196, 31)
        Me.BtnAddKeyCMD.TabIndex = 31
        Me.BtnAddKeyCMD.Text = "Add Keyboard CMD"
        Me.BtnAddKeyCMD.UseVisualStyleBackColor = True
        '
        'TbxKeyBoardCMD
        '
        Me.TbxKeyBoardCMD.Location = New System.Drawing.Point(131, 233)
        Me.TbxKeyBoardCMD.Name = "TbxKeyBoardCMD"
        Me.TbxKeyBoardCMD.Size = New System.Drawing.Size(190, 20)
        Me.TbxKeyBoardCMD.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "|"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(9, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "|"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "|"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "|"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(188, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "|"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(188, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "|"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(188, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(9, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "|"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(522, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "|"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 38)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(310, 186)
        Me.ListBox2.TabIndex = 41
        '
        'BtnWaitCMD
        '
        Me.BtnWaitCMD.Location = New System.Drawing.Point(203, 335)
        Me.BtnWaitCMD.Name = "BtnWaitCMD"
        Me.BtnWaitCMD.Size = New System.Drawing.Size(115, 32)
        Me.BtnWaitCMD.TabIndex = 42
        Me.BtnWaitCMD.Text = "Add Wait CMD"
        Me.BtnWaitCMD.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(204, 301)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 28)
        Me.TextBox4.TabIndex = 43
        Me.TextBox4.Text = "30.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Seconds"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(328, 38)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(74, 43)
        Me.btnDelete.TabIndex = 45
        Me.btnDelete.Text = "DELETE COMMAND"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'LblPosition
        '
        Me.LblPosition.AutoSize = True
        Me.LblPosition.Location = New System.Drawing.Point(14, 9)
        Me.LblPosition.Name = "LblPosition"
        Me.LblPosition.Size = New System.Drawing.Size(119, 13)
        Me.LblPosition.TabIndex = 46
        Me.LblPosition.Text = "Current Mouse Position:"
        '
        'lblMousePosition
        '
        Me.lblMousePosition.AutoSize = True
        Me.lblMousePosition.Location = New System.Drawing.Point(139, 9)
        Me.lblMousePosition.Name = "lblMousePosition"
        Me.lblMousePosition.Size = New System.Drawing.Size(13, 13)
        Me.lblMousePosition.TabIndex = 47
        Me.lblMousePosition.Text = "0"
        '
        'lblPressInsert
        '
        Me.lblPressInsert.AutoSize = True
        Me.lblPressInsert.Location = New System.Drawing.Point(14, 22)
        Me.lblPressInsert.Name = "lblPressInsert"
        Me.lblPressInsert.Size = New System.Drawing.Size(119, 13)
        Me.lblPressInsert.TabIndex = 48
        Me.lblPressInsert.Text = "Press INSERT To Copy"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(327, 157)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 50
        Me.BtnSave.Text = "Save File"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(328, 132)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox1.TabIndex = 51
        Me.CheckBox1.Text = "Loop"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearList.ForeColor = System.Drawing.Color.Salmon
        Me.btnClearList.Location = New System.Drawing.Point(12, 384)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(247, 23)
        Me.btnClearList.TabIndex = 52
        Me.btnClearList.Text = "DELETE EVERY COMMAND ON LIST"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 366)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(399, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "________________________________________________________"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(432, 419)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.lblPressInsert)
        Me.Controls.Add(Me.lblMousePosition)
        Me.Controls.Add(Me.LblPosition)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.BtnWaitCMD)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxKeyBoardCMD)
        Me.Controls.Add(Me.BtnAddKeyCMD)
        Me.Controls.Add(Me.btnClrRadio)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnClickCMD)
        Me.Controls.Add(Me.btnTEST)
        Me.Controls.Add(Me.TbxY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbxX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.BtnRun)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "AutoClicker KeyboardPlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRun As Button
    Friend WithEvents BtnLoad As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MousePositionTImer As Timer
    Friend WithEvents btnClrRadio As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnClickCMD As Button
    Friend WithEvents btnTEST As Button
    Friend WithEvents TbxY As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbxX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddKeyCMD As Button
    Friend WithEvents TbxKeyBoardCMD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents BtnWaitCMD As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents LblPosition As Label
    Friend WithEvents lblMousePosition As Label
    Friend WithEvents lblPressInsert As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnSave As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnClearList As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer1 As Timer
End Class
