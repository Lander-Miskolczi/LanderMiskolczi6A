Form/Class Global Variable to support the usage of the following code:

    Private bolValidInput As Boolean = True

Key Down Code:

        bolValidInput = False
        If My.Computer.Keyboard.ShiftKeyDown Then 'Disallows the use of the shift key
            bolValidInput = False
            Return
        End If

        Select Case e.KeyCode
            Case Keys.D0 To Keys.D9
                bolValidInput = True
            Case Keys.NumPad0 To Keys.NumPad9
                bolValidInput = True
            Case Keys.Back, Keys.Delete
                bolValidInput = True
            Case Keys.Left, Keys.Right
                bolValidInput = True
            Case Else
                bolValidInput = False
        End Select

Key Press Code:

        'If e.Handled = True don't pass the key on
        'If e.Handled = False do pass the key on
        'Long Form Method:

        If bolValidInput Then
            e.Handled = False
        Else
            e.Handled = True
        End If