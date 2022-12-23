<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstMotors = New System.Windows.Forms.ListBox()
        Me.btnAddMotor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMotors
        '
        Me.lstMotors.FormattingEnabled = True
        Me.lstMotors.ItemHeight = 16
        Me.lstMotors.Location = New System.Drawing.Point(53, 48)
        Me.lstMotors.Name = "lstMotors"
        Me.lstMotors.Size = New System.Drawing.Size(535, 132)
        Me.lstMotors.TabIndex = 0
        '
        'btnAddMotor
        '
        Me.btnAddMotor.Location = New System.Drawing.Point(137, 205)
        Me.btnAddMotor.Name = "btnAddMotor"
        Me.btnAddMotor.Size = New System.Drawing.Size(138, 28)
        Me.btnAddMotor.TabIndex = 1
        Me.btnAddMotor.Text = "&Add Motor"
        Me.btnAddMotor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 28)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 257)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddMotor)
        Me.Controls.Add(Me.lstMotors)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMotors As ListBox
    Friend WithEvents btnAddMotor As Button
    Friend WithEvents btnExit As Button
End Class
