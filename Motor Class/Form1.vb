Public Class MainForm
    Public Shared motors(9) As Motor 'Array for motor
    Public Shared intMotorCount As Integer = 0 'Counter for objects in Motor

    Private Sub MainForm_Load() Handles MyBase.Load

        'Array of motors
        For i As Integer = 0 To 9
            motors(i) = New Motor()
        Next
    End Sub

    Private Sub UpdateListBox()

        'Update list box contents
        Dim i As Integer
        Dim str As String = ""

        'Start with clear list box
        lstMotors.Items.Clear()

        'Load ID numbers in the array into list box
        For i = 0 To intMotorCount - 1
            str = "ID: " & motors(i).MotorID & ", " &
                motors(i).Description & ", " & motors(i).RPM & " RPM, " &
                motors(i).Voltage & " Volts, Status = " & motors(i).Status
            lstMotors.Items.Add(str)
        Next
    End Sub

    Private Sub btnAddMotor_Click(sender As Object, e As EventArgs) Handles btnAddMotor.Click

        'Display add form
        Dim frmADD As New AddForm()
        frmADD.ShowDialog()
        UpdateListBox()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
