Option Strict On 'Enables strict to enforce strict data typing
Public Class SemesterAverageForm
    Private grade As Double = 0.0
    Private counter As Integer = 0
    Private runningTotal As Double = 0.0
    Private gradeLetter As String = ""
    Const maximum As Integer = 5
    Const minimum As Integer = 0
    Const highestPossible As Integer = 100
    Private marks_array(maximum) As Double

    'test

    ''' <summary>
    ''' Closes and exits the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub
    ''' <summary>
    ''' calls subroutine ResetForm() which resets all textboxes and labels in Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFrom()
    End Sub
    ''' <summary>
    ''' Resets all textboxes and labels in form
    ''' </summary>
    Private Sub ResetFrom()
        'Renables all textboxes
        tbCourseOne.Enabled = True
        tbCourseTwo.Enabled = True
        tbCourseThree.Enabled = True
        tbCourseFour.Enabled = True
        tbCourseFive.Enabled = True
        tbCourseSix.Enabled = True
        'Clear text in all textboxes
        tbCourseOne.Text = ""
        tbCourseTwo.Text = ""
        tbCourseThree.Text = ""
        tbCourseFour.Text = ""
        tbCourseFive.Text = ""
        tbCourseSix.Text = ""
        tbSemester.Text = ""
        'Clears text in all labels
        lbGradeOne.Text = ""
        lbGradeTwo.Text = ""
        lbGradeThree.Text = ""
        lbGradeFour.Text = ""
        lbGradeFive.Text = ""
        lbGradeSix.Text = ""
        lbGradeSemester.Text = ""
        lbErrorOutput.Text = ""
        'Reset all variables
        grade = 0.0
        counter = 0
        runningTotal = 0.0
        gradeLetter = ""
        'Clear Array
        Array.Clear(marks_array, 0, 5) 'Clears array
    End Sub
    ''' <summary>
    ''' Calculates average of all 6 grades entered
    ''' </summary>
    ''' <param name="grade"></param>
    ''' <returns></returns>
    Private Function GradeCheck(grade As Double) As String

        Return ""
    End Function
    ''' <summary>
    ''' Calculates average of array 
    ''' </summary>
    Private Sub AverageCalculator()
        Dim average As Double

        average = runningTotal / (maximum + 1)
        tbSemester.Text = average.ToString("n2")
        RangeChecker(average, gradeLetter)
        lbGradeSemester.Text = gradeLetter

        tbCourseOne.Enabled = False
        tbCourseTwo.Enabled = False
        tbCourseThree.Enabled = False
        tbCourseFour.Enabled = False
        tbCourseFive.Enabled = False
        tbCourseSix.Enabled = False
        tbSemester.Enabled = False

    End Sub

    ''' <summary>
    ''' Checks if input is valid
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidChecker(input As String) As Boolean
        Dim intInput = 0
        Dim status As Boolean = False

        If Double.TryParse(input, grade) Then
            marks_array(counter) = grade
            status = True

        ElseIf Integer.TryParse(input, intInput) Then
            marks_array(counter) = intInput
            status = True

        Else
            lbErrorOutput.Text += "ERROR NOT A NUMBER" & vbCrLf
            status = False

        End If
        counter += 1
        Return status
    End Function


    ''' <summary>
    ''' Checks if input is within range and displays grade letter
    ''' </summary>
    ''' <returns></returns>
    Private Function RangeChecker(testValue As Double, ByRef gradeLetter As String) As Boolean
        Dim status As Boolean = False
        If (testValue >= 0 And testValue <= 100) Then
            runningTotal += testValue
            If (testValue >= 90 And testValue <= 100) Then
                gradeLetter = "A+"
                status = True
            ElseIf (testValue >= 85 And testValue <= 89) Then
                gradeLetter = "A"
                status = True
            ElseIf (testValue >= 80 And testValue <= 84) Then
                gradeLetter = "A-"
                status = True
            ElseIf (testValue >= 77 And testValue <= 79) Then
                gradeLetter = "B+"
                status = True
            ElseIf (testValue >= 73 And testValue <= 76) Then
                gradeLetter = "B"
                status = True
            ElseIf (testValue >= 70 And testValue <= 72) Then
                gradeLetter = "B-"
                status = True
            ElseIf (testValue >= 67 And testValue <= 69) Then
                gradeLetter = "C+"
                status = True
            ElseIf (testValue >= 63 And testValue <= 66) Then
                gradeLetter = "C"
                status = True
            ElseIf (testValue >= 60 And testValue <= 62) Then
                gradeLetter = "C-"
                status = True
            ElseIf (testValue >= 57 And testValue <= 59) Then
                gradeLetter = "D+"
                status = True
            ElseIf (testValue >= 53 And testValue <= 56) Then
                gradeLetter = "D"
                status = True
            ElseIf (testValue >= 50 And testValue <= 52) Then
                gradeLetter = "D-"
                status = True
            ElseIf (testValue >= 0 And testValue <= 49) Then
                gradeLetter = "F"
                status = True
            End If
        Else
            lbErrorOutput.Text += "ERROR IN RANGE" & vbCrLf
        End If
        Return status
    End Function



    ''' <summary>
    ''' Calls ValidChecker() and RangeChecker() to test input and then calculates average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        AverageCalculator()
    End Sub

    ''' <summary>
    ''' Lost Focus for textbox one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseOne_LostFocus(sender As Object, e As EventArgs) Handles tbCourseOne.LostFocus
        Dim input As String = tbCourseOne.Text

        If (counter = (marks_array.Length - 1)) Then
            AverageCalculator()

        Else
            If ValidChecker(input) Then
                If RangeChecker(marks_array(counter - 1), gradeLetter) Then
                    lbGradeOne.Text = gradeLetter
                End If
            Else
                tbCourseOne.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Lost Focus for textbox two
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseTwo_LostFocus(sender As Object, e As EventArgs) Handles tbCourseTwo.LostFocus
        Dim input As String = tbCourseTwo.Text

        If (counter = marks_array.Length - 1) Then
            AverageCalculator()

        Else
            If ValidChecker(input) Then
                If RangeChecker(marks_array(counter - 1), gradeLetter) Then
                    lbGradeTwo.Text = gradeLetter
                End If
            Else
                tbCourseTwo.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Lost Focus for textbox three
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseThree_LostFocus(sender As Object, e As EventArgs) Handles tbCourseThree.LostFocus
        Dim input As String = tbCourseThree.Text

        If (counter = (marks_array.Length - 1)) Then
            AverageCalculator()

        Else
            If ValidChecker(input) Then
                If RangeChecker(marks_array(counter - 1), gradeLetter) Then
                    lbGradeThree.Text = gradeLetter
                End If
            Else
                tbCourseThree.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Lost Focus for textbox four
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseFour_LostFocus(sender As Object, e As EventArgs) Handles tbCourseFour.LostFocus
        Dim input As String = tbCourseFour.Text

        If (counter = (marks_array.Length - 1)) Then
            AverageCalculator()

        Else
            If ValidChecker(input) Then
                If RangeChecker(marks_array(counter - 1), gradeLetter) Then
                    lbGradeFour.Text = gradeLetter
                End If
            Else
                tbCourseFour.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Lost Focus for textbox five
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseFive_LostFocus(sender As Object, e As EventArgs) Handles tbCourseFive.LostFocus
        Dim input As String = tbCourseFive.Text

        If (counter = (marks_array.Length - 1)) Then
            AverageCalculator()

        Else
            If ValidChecker(input) Then
                If RangeChecker(marks_array(counter - 1), gradeLetter) Then
                    lbGradeFive.Text = gradeLetter
                End If
            Else
                tbCourseFive.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Lost Focus for textbox six
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseSix_LostFocus(sender As Object, e As EventArgs) Handles tbCourseSix.LostFocus
        Dim input As String = tbCourseSix.Text

        If (counter = (marks_array.Length - 1)) Then
            If ValidChecker(input) Then
                If RangeChecker(marks_array(counter - 1), gradeLetter) Then
                    lbGradeSix.Text = gradeLetter
                End If
            End If
            tbSemester.Focus()
            AverageCalculator()
        End If
    End Sub
End Class