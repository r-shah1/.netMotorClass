Public Class AddForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save user entered data into form

        Dim m As New Motor()
        'Validate inputs
        If txtMotorID.Text.Length <> 5 Then
            MessageBox.Show("Error: The motor ID must be 5 characters.")
            txtMotorID.SelectionStart = 0
            txtMotorID.SelectionLength = txtMotorID.Text.Length
            txtMotorID.Focus()
        ElseIf Val(txtRPM.Text) < 10 Or Val(txtRPM.Text) > 10000 Then
            MessageBox.Show("Error: The RPM must be in range 10 to 10000.")
            txtRPM.SelectionStart = 0
            txtRPM.SelectionLength = txtRPM.Text.Length
            txtRPM.Focus()
        ElseIf Val(txtVoltage.Text) < 1 Or Val(txtVoltage.Text) > 500 Then
            MessageBox.Show("Error: The Voltage must be in the range 1 to 500.")
            txtVoltage.SelectionStart = 0
            txtVoltage.SelectionStart = txtVoltage.Text.Length
        Else
            If MainForm.intMotorCount < 10 Then
                CopyToObject(MainForm.motors(MainForm.intMotorCount))
                MainForm.intMotorCount += 1
                ClearForm()
            Else
                MessageBox.Show("Error: The motor array is full.")
            End If
        End If
    End Sub

    Private Sub CopyToObject(ByVal m As Motor)
        'Copy data from from to motor class
        m.MotorID = txtMotorID.Text
        m.Description = txtDescription.Text
        m.RPM = CSng(txtRPM.Text)
        m.Voltage = CSng(txtVoltage.Text)
        m.Status = GetStatus()
    End Sub

    Private Function GetStatus() As String
        'Return motor status selected by user as string
        Dim stat As String = ""
        If radON.Checked = True Then
            stat = "ON"
        ElseIf radOFF.Checked = True Then
            stat = "OFF"
        ElseIf radMNT.Checked = True Then
            stat = "MNT"
        ElseIf radNA.Checked = True Then
            stat = "NA"
        End If
        Return stat
    End Function

    Private Sub ClearForm()
        'Clear form
        txtMotorID.Clear()
        txtDescription.Clear()
        txtRPM.Clear()
        txtVoltage.Clear()
        radON.Checked = True
        txtMotorID.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear form
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close form without saving to motor array
        Me.Close()
    End Sub
End Class