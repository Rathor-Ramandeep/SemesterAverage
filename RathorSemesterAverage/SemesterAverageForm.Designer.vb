<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterAverageForm
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
        Me.SemesterAverageToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbCourseOne = New System.Windows.Forms.TextBox()
        Me.tbCourseTwo = New System.Windows.Forms.TextBox()
        Me.tbCourseThree = New System.Windows.Forms.TextBox()
        Me.tbCourseFour = New System.Windows.Forms.TextBox()
        Me.tbCourseFive = New System.Windows.Forms.TextBox()
        Me.tbCourseSix = New System.Windows.Forms.TextBox()
        Me.lbErrorOutput = New System.Windows.Forms.Label()
        Me.tbSemester = New System.Windows.Forms.TextBox()
        Me.lbGradeOne = New System.Windows.Forms.Label()
        Me.lbGradeTwo = New System.Windows.Forms.Label()
        Me.lbGradeThree = New System.Windows.Forms.Label()
        Me.lbGradeFour = New System.Windows.Forms.Label()
        Me.lbGradeFive = New System.Windows.Forms.Label()
        Me.lbGradeSix = New System.Windows.Forms.Label()
        Me.lbGradeSemester = New System.Windows.Forms.Label()
        Me.lbCourseOne = New System.Windows.Forms.Label()
        Me.lbCourseTwo = New System.Windows.Forms.Label()
        Me.lbCourseFour = New System.Windows.Forms.Label()
        Me.lbCourseThree = New System.Windows.Forms.Label()
        Me.lbCourseSix = New System.Windows.Forms.Label()
        Me.lbCourseFive = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbCourseOne
        '
        Me.tbCourseOne.Location = New System.Drawing.Point(113, 29)
        Me.tbCourseOne.Name = "tbCourseOne"
        Me.tbCourseOne.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseOne.TabIndex = 1
        Me.tbCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.tbCourseOne, "Enter Grade Here")
        '
        'tbCourseTwo
        '
        Me.tbCourseTwo.Location = New System.Drawing.Point(113, 68)
        Me.tbCourseTwo.Name = "tbCourseTwo"
        Me.tbCourseTwo.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseTwo.TabIndex = 4
        Me.tbCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.tbCourseTwo, "Enter Grade Here")
        '
        'tbCourseThree
        '
        Me.tbCourseThree.Location = New System.Drawing.Point(113, 107)
        Me.tbCourseThree.Name = "tbCourseThree"
        Me.tbCourseThree.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseThree.TabIndex = 7
        Me.tbCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.tbCourseThree, "Enter Grade Here")
        '
        'tbCourseFour
        '
        Me.tbCourseFour.Location = New System.Drawing.Point(113, 146)
        Me.tbCourseFour.Name = "tbCourseFour"
        Me.tbCourseFour.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseFour.TabIndex = 10
        Me.tbCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.tbCourseFour, "Enter Grade Here")
        '
        'tbCourseFive
        '
        Me.tbCourseFive.Location = New System.Drawing.Point(113, 185)
        Me.tbCourseFive.Name = "tbCourseFive"
        Me.tbCourseFive.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseFive.TabIndex = 13
        Me.tbCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.tbCourseFive, "Enter Grade Here")
        '
        'tbCourseSix
        '
        Me.tbCourseSix.Location = New System.Drawing.Point(113, 224)
        Me.tbCourseSix.Name = "tbCourseSix"
        Me.tbCourseSix.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseSix.TabIndex = 16
        Me.tbCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.tbCourseSix, "Enter Grade Here")
        '
        'lbErrorOutput
        '
        Me.lbErrorOutput.BackColor = System.Drawing.SystemColors.Control
        Me.lbErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbErrorOutput.Location = New System.Drawing.Point(12, 300)
        Me.lbErrorOutput.Name = "lbErrorOutput"
        Me.lbErrorOutput.Size = New System.Drawing.Size(322, 144)
        Me.lbErrorOutput.TabIndex = 21
        Me.SemesterAverageToolTip.SetToolTip(Me.lbErrorOutput, "Output Will Post Here")
        '
        'tbSemester
        '
        Me.tbSemester.Enabled = False
        Me.tbSemester.Location = New System.Drawing.Point(113, 260)
        Me.tbSemester.Name = "tbSemester"
        Me.tbSemester.Size = New System.Drawing.Size(100, 22)
        Me.tbSemester.TabIndex = 19
        Me.tbSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SemesterAverageToolTip.SetToolTip(Me.tbSemester, "Enter Grade Here")
        '
        'lbGradeOne
        '
        Me.lbGradeOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeOne.Location = New System.Drawing.Point(234, 29)
        Me.lbGradeOne.Name = "lbGradeOne"
        Me.lbGradeOne.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeOne.TabIndex = 2
        Me.lbGradeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeOne, "Corresponding Grades Will Post Here")
        '
        'lbGradeTwo
        '
        Me.lbGradeTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeTwo.Location = New System.Drawing.Point(234, 68)
        Me.lbGradeTwo.Name = "lbGradeTwo"
        Me.lbGradeTwo.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeTwo.TabIndex = 5
        Me.lbGradeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeTwo, "Corresponding Grades Will Post Here")
        '
        'lbGradeThree
        '
        Me.lbGradeThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeThree.Location = New System.Drawing.Point(234, 107)
        Me.lbGradeThree.Name = "lbGradeThree"
        Me.lbGradeThree.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeThree.TabIndex = 8
        Me.lbGradeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeThree, "Corresponding Grades Will Post Here")
        '
        'lbGradeFour
        '
        Me.lbGradeFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeFour.Location = New System.Drawing.Point(234, 146)
        Me.lbGradeFour.Name = "lbGradeFour"
        Me.lbGradeFour.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeFour.TabIndex = 11
        Me.lbGradeFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeFour, "Corresponding Grades Will Post Here")
        '
        'lbGradeFive
        '
        Me.lbGradeFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeFive.Location = New System.Drawing.Point(234, 185)
        Me.lbGradeFive.Name = "lbGradeFive"
        Me.lbGradeFive.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeFive.TabIndex = 14
        Me.lbGradeFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeFive, "Corresponding Grades Will Post Here")
        '
        'lbGradeSix
        '
        Me.lbGradeSix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeSix.Location = New System.Drawing.Point(234, 224)
        Me.lbGradeSix.Name = "lbGradeSix"
        Me.lbGradeSix.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeSix.TabIndex = 17
        Me.lbGradeSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeSix, "Corresponding Grades Will Post Here")
        '
        'lbGradeSemester
        '
        Me.lbGradeSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeSemester.Location = New System.Drawing.Point(234, 259)
        Me.lbGradeSemester.Name = "lbGradeSemester"
        Me.lbGradeSemester.Size = New System.Drawing.Size(100, 23)
        Me.lbGradeSemester.TabIndex = 20
        Me.lbGradeSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lbGradeSemester, "Corresponding Grades Will Post Here")
        '
        'lbCourseOne
        '
        Me.lbCourseOne.Location = New System.Drawing.Point(12, 29)
        Me.lbCourseOne.Name = "lbCourseOne"
        Me.lbCourseOne.Size = New System.Drawing.Size(69, 17)
        Me.lbCourseOne.TabIndex = 0
        Me.lbCourseOne.Text = "Course &1:"
        Me.lbCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseTwo
        '
        Me.lbCourseTwo.Location = New System.Drawing.Point(12, 68)
        Me.lbCourseTwo.Name = "lbCourseTwo"
        Me.lbCourseTwo.Size = New System.Drawing.Size(69, 17)
        Me.lbCourseTwo.TabIndex = 3
        Me.lbCourseTwo.Text = "Course &2:"
        Me.lbCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseFour
        '
        Me.lbCourseFour.Location = New System.Drawing.Point(12, 146)
        Me.lbCourseFour.Name = "lbCourseFour"
        Me.lbCourseFour.Size = New System.Drawing.Size(69, 17)
        Me.lbCourseFour.TabIndex = 9
        Me.lbCourseFour.Text = "Course &4:"
        Me.lbCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseThree
        '
        Me.lbCourseThree.Location = New System.Drawing.Point(12, 107)
        Me.lbCourseThree.Name = "lbCourseThree"
        Me.lbCourseThree.Size = New System.Drawing.Size(69, 17)
        Me.lbCourseThree.TabIndex = 6
        Me.lbCourseThree.Text = "Course &3:"
        Me.lbCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseSix
        '
        Me.lbCourseSix.Location = New System.Drawing.Point(12, 224)
        Me.lbCourseSix.Name = "lbCourseSix"
        Me.lbCourseSix.Size = New System.Drawing.Size(69, 17)
        Me.lbCourseSix.TabIndex = 15
        Me.lbCourseSix.Text = "Course &6:"
        Me.lbCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseFive
        '
        Me.lbCourseFive.Location = New System.Drawing.Point(12, 185)
        Me.lbCourseFive.Name = "lbCourseFive"
        Me.lbCourseFive.Size = New System.Drawing.Size(69, 17)
        Me.lbCourseFive.TabIndex = 12
        Me.lbCourseFive.Text = "Course &5:"
        Me.lbCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 471)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(137, 471)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 471)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbSemester
        '
        Me.lbSemester.Location = New System.Drawing.Point(12, 260)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(72, 17)
        Me.lbSemester.TabIndex = 18
        Me.lbSemester.Text = "&Semester:"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SemesterAverageForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(346, 506)
        Me.Controls.Add(Me.tbSemester)
        Me.Controls.Add(Me.lbGradeSemester)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbErrorOutput)
        Me.Controls.Add(Me.tbCourseSix)
        Me.Controls.Add(Me.tbCourseFive)
        Me.Controls.Add(Me.tbCourseFour)
        Me.Controls.Add(Me.tbCourseThree)
        Me.Controls.Add(Me.tbCourseTwo)
        Me.Controls.Add(Me.tbCourseOne)
        Me.Controls.Add(Me.lbGradeSix)
        Me.Controls.Add(Me.lbGradeFive)
        Me.Controls.Add(Me.lbGradeFour)
        Me.Controls.Add(Me.lbGradeThree)
        Me.Controls.Add(Me.lbGradeTwo)
        Me.Controls.Add(Me.lbGradeOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbCourseSix)
        Me.Controls.Add(Me.lbCourseFive)
        Me.Controls.Add(Me.lbCourseFour)
        Me.Controls.Add(Me.lbCourseThree)
        Me.Controls.Add(Me.lbCourseTwo)
        Me.Controls.Add(Me.lbCourseOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SemesterAverageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SemesterAverageToolTip As ToolTip
    Friend WithEvents lbCourseOne As Label
    Friend WithEvents lbCourseTwo As Label
    Friend WithEvents lbCourseFour As Label
    Friend WithEvents lbCourseThree As Label
    Friend WithEvents lbCourseSix As Label
    Friend WithEvents lbCourseFive As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbGradeOne As Label
    Friend WithEvents lbGradeTwo As Label
    Friend WithEvents lbGradeThree As Label
    Friend WithEvents lbGradeFour As Label
    Friend WithEvents lbGradeFive As Label
    Friend WithEvents lbGradeSix As Label
    Friend WithEvents tbCourseOne As TextBox
    Friend WithEvents tbCourseTwo As TextBox
    Friend WithEvents tbCourseThree As TextBox
    Friend WithEvents tbCourseFour As TextBox
    Friend WithEvents tbCourseFive As TextBox
    Friend WithEvents tbCourseSix As TextBox
    Friend WithEvents lbErrorOutput As Label
    Friend WithEvents tbSemester As TextBox
    Friend WithEvents lbGradeSemester As Label
    Friend WithEvents lbSemester As Label
End Class
