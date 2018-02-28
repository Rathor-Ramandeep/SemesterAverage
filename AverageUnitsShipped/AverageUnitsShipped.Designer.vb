<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbUnitsIn = New System.Windows.Forms.TextBox()
        Me.tbUnitsOut = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDayNumber = New System.Windows.Forms.Label()
        Me.lbAverageOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 322)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(103, 32)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Calculates Average of Units Shipped")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(139, 322)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 32)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Resets Application to Initial State")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(266, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Exits Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbUnitsIn
        '
        Me.tbUnitsIn.Location = New System.Drawing.Point(139, 22)
        Me.tbUnitsIn.Name = "tbUnitsIn"
        Me.tbUnitsIn.Size = New System.Drawing.Size(68, 22)
        Me.tbUnitsIn.TabIndex = 1
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbUnitsIn, "Input Number of Units Sold for Each Day Here")
        '
        'tbUnitsOut
        '
        Me.tbUnitsOut.BackColor = System.Drawing.Color.White
        Me.tbUnitsOut.Enabled = False
        Me.tbUnitsOut.Location = New System.Drawing.Point(12, 50)
        Me.tbUnitsOut.Multiline = True
        Me.tbUnitsOut.Name = "tbUnitsOut"
        Me.tbUnitsOut.Size = New System.Drawing.Size(356, 236)
        Me.tbUnitsOut.TabIndex = 3
        Me.tbUnitsOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbUnitsOut, "Shows Inputs by User")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(63, 21)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(52, 23)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDayNumber
        '
        Me.lbDayNumber.Location = New System.Drawing.Point(231, 22)
        Me.lbDayNumber.Name = "lbDayNumber"
        Me.lbDayNumber.Size = New System.Drawing.Size(52, 23)
        Me.lbDayNumber.TabIndex = 2
        Me.lbDayNumber.Text = "Day 1"
        Me.lbDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAverageOut
        '
        Me.lbAverageOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageOut.Location = New System.Drawing.Point(12, 289)
        Me.lbAverageOut.Name = "lbAverageOut"
        Me.lbAverageOut.Size = New System.Drawing.Size(356, 30)
        Me.lbAverageOut.TabIndex = 7
        Me.lbAverageOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(382, 366)
        Me.Controls.Add(Me.lbAverageOut)
        Me.Controls.Add(Me.tbUnitsOut)
        Me.Controls.Add(Me.lbDayNumber)
        Me.Controls.Add(Me.tbUnitsIn)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnitsIn As TextBox
    Friend WithEvents lbDayNumber As Label
    Friend WithEvents tbUnitsOut As TextBox
    Friend WithEvents lbAverageOut As Label
End Class
