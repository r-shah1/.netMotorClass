<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMotorID = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblMotorRPM = New System.Windows.Forms.Label()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.txtMotorID = New System.Windows.Forms.TextBox()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.txtRPM = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.radON = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radOFF = New System.Windows.Forms.RadioButton()
        Me.radNA = New System.Windows.Forms.RadioButton()
        Me.radMNT = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 291)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Record"
        '
        'lblMotorID
        '
        Me.lblMotorID.AutoSize = True
        Me.lblMotorID.Location = New System.Drawing.Point(88, 102)
        Me.lblMotorID.Name = "lblMotorID"
        Me.lblMotorID.Size = New System.Drawing.Size(61, 17)
        Me.lblMotorID.TabIndex = 1
        Me.lblMotorID.Text = "Motor ID"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(70, 132)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        '
        'lblMotorRPM
        '
        Me.lblMotorRPM.AutoSize = True
        Me.lblMotorRPM.Location = New System.Drawing.Point(71, 162)
        Me.lblMotorRPM.Name = "lblMotorRPM"
        Me.lblMotorRPM.Size = New System.Drawing.Size(78, 17)
        Me.lblMotorRPM.TabIndex = 3
        Me.lblMotorRPM.Text = "Motor RPM"
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(93, 192)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(56, 17)
        Me.lblVoltage.TabIndex = 4
        Me.lblVoltage.Text = "Voltage"
        '
        'txtMotorID
        '
        Me.txtMotorID.Location = New System.Drawing.Point(155, 99)
        Me.txtMotorID.Name = "txtMotorID"
        Me.txtMotorID.Size = New System.Drawing.Size(137, 23)
        Me.txtMotorID.TabIndex = 5
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(155, 189)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(137, 23)
        Me.txtVoltage.TabIndex = 6
        '
        'txtRPM
        '
        Me.txtRPM.Location = New System.Drawing.Point(155, 159)
        Me.txtRPM.Name = "txtRPM"
        Me.txtRPM.Size = New System.Drawing.Size(137, 23)
        Me.txtRPM.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(155, 129)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(210, 23)
        Me.txtDescription.TabIndex = 8
        '
        'radON
        '
        Me.radON.AutoSize = True
        Me.radON.Location = New System.Drawing.Point(442, 130)
        Me.radON.Name = "radON"
        Me.radON.Size = New System.Drawing.Size(47, 21)
        Me.radON.TabIndex = 9
        Me.radON.TabStop = True
        Me.radON.Text = "ON"
        Me.radON.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Motor Status"
        '
        'radOFF
        '
        Me.radOFF.AutoSize = True
        Me.radOFF.Location = New System.Drawing.Point(442, 157)
        Me.radOFF.Name = "radOFF"
        Me.radOFF.Size = New System.Drawing.Size(53, 21)
        Me.radOFF.TabIndex = 11
        Me.radOFF.TabStop = True
        Me.radOFF.Text = "OFF"
        Me.radOFF.UseVisualStyleBackColor = True
        '
        'radNA
        '
        Me.radNA.AutoSize = True
        Me.radNA.Location = New System.Drawing.Point(442, 211)
        Me.radNA.Name = "radNA"
        Me.radNA.Size = New System.Drawing.Size(45, 21)
        Me.radNA.TabIndex = 12
        Me.radNA.TabStop = True
        Me.radNA.Text = "NA"
        Me.radNA.UseVisualStyleBackColor = True
        '
        'radMNT
        '
        Me.radMNT.AutoSize = True
        Me.radMNT.Location = New System.Drawing.Point(442, 184)
        Me.radMNT.Name = "radMNT"
        Me.radMNT.Size = New System.Drawing.Size(56, 21)
        Me.radMNT.TabIndex = 13
        Me.radMNT.TabStop = True
        Me.radMNT.Text = "MNT"
        Me.radMNT.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(73, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 28)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(227, 263)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 28)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(389, 263)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 28)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 364)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.radMNT)
        Me.Controls.Add(Me.radNA)
        Me.Controls.Add(Me.radOFF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radON)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtRPM)
        Me.Controls.Add(Me.txtVoltage)
        Me.Controls.Add(Me.txtMotorID)
        Me.Controls.Add(Me.lblVoltage)
        Me.Controls.Add(Me.lblMotorRPM)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblMotorID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddForm"
        Me.Text = "Add New Motor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMotorID As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblMotorRPM As Label
    Friend WithEvents lblVoltage As Label
    Friend WithEvents txtMotorID As TextBox
    Friend WithEvents txtVoltage As TextBox
    Friend WithEvents txtRPM As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents radON As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents radOFF As RadioButton
    Friend WithEvents radNA As RadioButton
    Friend WithEvents radMNT As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
