Option Strict On 'Enables strict to enforce strict data typing

Public Class frmAverageUnitsShipped
    Private counter As Integer = 0 'Declares private global variable counter as integer starting at 0
    Private days_array(6) As Integer 'Declares private global array days_array of type integer with size 7
    Private running_total As Double = 0.0 'Declares private new double running_total




    ''' <summary>
    ''' Event handler for when exit button is clicked 
    ''' Exits and closes the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0) 'Exits and ends the application
    End Sub
    ''' <summary>
    ''' Event handler for when reset button is clicked 
    ''' Resets all textboxes, lables, and clears days_array
    ''' Renables input texbox and enter button
    ''' Resets running_total and sets focus in input textbox 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbUnitsIn.Text = "" 'Clears textbox
        tbUnitsOut.Text = "" 'Clears textbox 
        lbDayNumber.Text = "Day 1" 'Resets day label to "Day 1"
        lbAverageOut.Text = "" 'Resets output box with average to blank
        tbUnitsIn.Enabled = True 'Enables the input textbox to allow user input
        counter = 0 'Resets counter to 0
        Array.Clear(days_array, 0, 6) 'Clears array
        btnEnter.Enabled = True 'Enable enter button
        running_total = 0.0 'Resets running_total to 0.0
        tbUnitsIn.Select() 'Return user's focus to input textbox
    End Sub
    ''' <summary>
    ''' Event handler for every time the enter button is clicked
    ''' Each time the user clicks enter, the program will validate and add the input to the array
    ''' After 7 days, the average will be calculated and printed to the screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim counter As Integer
        'Declarations
        Dim average As Double = 0.0 'Declares new string average and initializes with a blank string
        Dim input As Integer = 0 'Declares new integer input and initializes to 0

        'Input
        If Integer.TryParse(tbUnitsIn.Text, input) Then 'If input is a valid integer
            If (0 <= input And input <= 1000) Then 'If input is above 0

                days_array(counter) = input 'Add input to days_array at position counter
                tbUnitsOut.Text += days_array(counter).ToString() & vbCrLf 'Append days_array at position counter to tbUnitsOut and vbCrLf (Carriage Return and Line Feed)
                running_total += days_array(counter) 'Append the value of days_array at position index to running_total

                counter += 1 'Increment counter by 1

                If counter = 7 Then 'If counter equals 7
                    tbUnitsIn.Enabled = False 'Disable the input textbox to prevent further user input
                    btnEnter.Enabled = False 'Disable enter button

                    average = running_total / (days_array.Length) 'Average equals running_total divided by size of days_array 
                    lbAverageOut.Text = "The average is: " + average.ToString("n2") 'Output calculated average to lbAverageOut to 2 decimal places

                Else
                    lbDayNumber.Text = "Day " & (counter + 1).ToString() 'Increment lbDayNumber by 1 (to the next day of the week)

                End If 'End if

            Else 'Else if input is a negetive number
                MessageBox.Show("ERROR: Input must be between 0 and 1000 inclusive!") 'Throw error if input is out of range
            End If 'End if

        Else 'Else if input is not a valid number
            MessageBox.Show("ERROR: Input must be a whole number!") 'Throw error if input is not a whole number
        End If 'End if

        tbUnitsIn.ResetText() 'Resets text in tbUnitsIn for next input
    End Sub
End Class