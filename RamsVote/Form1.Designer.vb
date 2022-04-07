<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVote
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
        Me.txtCheckStudentID = New System.Windows.Forms.TextBox()
        Me.lblCheckStudentID = New System.Windows.Forms.Label()
        Me.btnCheckStudentID = New System.Windows.Forms.Button()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.lblStudentIDSample = New System.Windows.Forms.Label()
        Me.grpSignIn = New System.Windows.Forms.GroupBox()
        Me.grpVoting = New System.Windows.Forms.GroupBox()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.rdbCandidate2 = New System.Windows.Forms.RadioButton()
        Me.rdbCandidate1 = New System.Windows.Forms.RadioButton()
        Me.lblHomecomingElection = New System.Windows.Forms.Label()
        Me.lblChooseCandidate = New System.Windows.Forms.Label()
        Me.grpConfirmation = New System.Windows.Forms.GroupBox()
        Me.LblCandidateChosen = New System.Windows.Forms.Label()
        Me.rdbCandidate2Confirm = New System.Windows.Forms.RadioButton()
        Me.rdbCandidate1Confirm = New System.Windows.Forms.RadioButton()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.LblCorrectOrIncorrect = New System.Windows.Forms.Label()
        Me.lblConfim = New System.Windows.Forms.Label()
        Me.grpThankYou = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblThankYou = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.grpSignIn.SuspendLayout()
        Me.grpVoting.SuspendLayout()
        Me.grpConfirmation.SuspendLayout()
        Me.grpThankYou.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCheckStudentID
        '
        Me.txtCheckStudentID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCheckStudentID.Location = New System.Drawing.Point(70, 89)
        Me.txtCheckStudentID.Name = "txtCheckStudentID"
        Me.txtCheckStudentID.Size = New System.Drawing.Size(100, 20)
        Me.txtCheckStudentID.TabIndex = 0
        '
        'lblCheckStudentID
        '
        Me.lblCheckStudentID.AutoSize = True
        Me.lblCheckStudentID.BackColor = System.Drawing.SystemColors.Control
        Me.lblCheckStudentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCheckStudentID.Location = New System.Drawing.Point(6, 92)
        Me.lblCheckStudentID.Name = "lblCheckStudentID"
        Me.lblCheckStudentID.Size = New System.Drawing.Size(58, 13)
        Me.lblCheckStudentID.TabIndex = 1
        Me.lblCheckStudentID.Text = "Student ID"
        '
        'btnCheckStudentID
        '
        Me.btnCheckStudentID.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCheckStudentID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCheckStudentID.Location = New System.Drawing.Point(70, 125)
        Me.btnCheckStudentID.Name = "btnCheckStudentID"
        Me.btnCheckStudentID.Size = New System.Drawing.Size(100, 33)
        Me.btnCheckStudentID.TabIndex = 2
        Me.btnCheckStudentID.Text = "Sign in"
        Me.btnCheckStudentID.UseVisualStyleBackColor = False
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.Location = New System.Drawing.Point(67, 51)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(39, 13)
        Me.lblSignIn.TabIndex = 4
        Me.lblSignIn.Text = "Sign in"
        '
        'lblStudentIDSample
        '
        Me.lblStudentIDSample.AutoSize = True
        Me.lblStudentIDSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentIDSample.Location = New System.Drawing.Point(6, 161)
        Me.lblStudentIDSample.Name = "lblStudentIDSample"
        Me.lblStudentIDSample.Size = New System.Drawing.Size(253, 13)
        Me.lblStudentIDSample.TabIndex = 5
        Me.lblStudentIDSample.Text = "Important: Type 900123413 for student ID! "
        '
        'grpSignIn
        '
        Me.grpSignIn.Controls.Add(Me.lblDescription2)
        Me.grpSignIn.Controls.Add(Me.lblCheckStudentID)
        Me.grpSignIn.Controls.Add(Me.lblStudentIDSample)
        Me.grpSignIn.Controls.Add(Me.txtCheckStudentID)
        Me.grpSignIn.Controls.Add(Me.lblSignIn)
        Me.grpSignIn.Controls.Add(Me.btnCheckStudentID)
        Me.grpSignIn.Location = New System.Drawing.Point(12, 39)
        Me.grpSignIn.Name = "grpSignIn"
        Me.grpSignIn.Size = New System.Drawing.Size(346, 207)
        Me.grpSignIn.TabIndex = 6
        Me.grpSignIn.TabStop = False
        Me.grpSignIn.Text = "StudentSignUpPage"
        '
        'grpVoting
        '
        Me.grpVoting.Controls.Add(Me.lblDate)
        Me.grpVoting.Controls.Add(Me.lblStartDate)
        Me.grpVoting.Controls.Add(Me.lblDueDate)
        Me.grpVoting.Controls.Add(Me.btnVote)
        Me.grpVoting.Controls.Add(Me.rdbCandidate2)
        Me.grpVoting.Controls.Add(Me.rdbCandidate1)
        Me.grpVoting.Controls.Add(Me.lblHomecomingElection)
        Me.grpVoting.Controls.Add(Me.lblChooseCandidate)
        Me.grpVoting.Location = New System.Drawing.Point(364, 39)
        Me.grpVoting.Name = "grpVoting"
        Me.grpVoting.Size = New System.Drawing.Size(203, 207)
        Me.grpVoting.TabIndex = 7
        Me.grpVoting.TabStop = False
        Me.grpVoting.Text = "VotingPage"
        Me.grpVoting.Visible = False
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVote.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVote.Location = New System.Drawing.Point(37, 163)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(97, 30)
        Me.btnVote.TabIndex = 4
        Me.btnVote.Text = "Vote"
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'rdbCandidate2
        '
        Me.rdbCandidate2.AutoSize = True
        Me.rdbCandidate2.Location = New System.Drawing.Point(37, 130)
        Me.rdbCandidate2.Name = "rdbCandidate2"
        Me.rdbCandidate2.Size = New System.Drawing.Size(97, 17)
        Me.rdbCandidate2.TabIndex = 3
        Me.rdbCandidate2.TabStop = True
        Me.rdbCandidate2.Text = "Cameron Harris"
        Me.rdbCandidate2.UseVisualStyleBackColor = True
        '
        'rdbCandidate1
        '
        Me.rdbCandidate1.AutoSize = True
        Me.rdbCandidate1.Location = New System.Drawing.Point(37, 91)
        Me.rdbCandidate1.Name = "rdbCandidate1"
        Me.rdbCandidate1.Size = New System.Drawing.Size(81, 17)
        Me.rdbCandidate1.TabIndex = 2
        Me.rdbCandidate1.TabStop = True
        Me.rdbCandidate1.Text = "Alice Brown"
        Me.rdbCandidate1.UseVisualStyleBackColor = True
        '
        'lblHomecomingElection
        '
        Me.lblHomecomingElection.AutoSize = True
        Me.lblHomecomingElection.BackColor = System.Drawing.SystemColors.Info
        Me.lblHomecomingElection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomecomingElection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHomecomingElection.Location = New System.Drawing.Point(34, 16)
        Me.lblHomecomingElection.Name = "lblHomecomingElection"
        Me.lblHomecomingElection.Size = New System.Drawing.Size(129, 13)
        Me.lblHomecomingElection.TabIndex = 1
        Me.lblHomecomingElection.Text = "Homecoming Election"
        '
        'lblChooseCandidate
        '
        Me.lblChooseCandidate.AutoSize = True
        Me.lblChooseCandidate.Location = New System.Drawing.Point(34, 60)
        Me.lblChooseCandidate.Name = "lblChooseCandidate"
        Me.lblChooseCandidate.Size = New System.Drawing.Size(117, 13)
        Me.lblChooseCandidate.TabIndex = 0
        Me.lblChooseCandidate.Text = "Choose one candidate:"
        '
        'grpConfirmation
        '
        Me.grpConfirmation.Controls.Add(Me.LblCandidateChosen)
        Me.grpConfirmation.Controls.Add(Me.rdbCandidate2Confirm)
        Me.grpConfirmation.Controls.Add(Me.rdbCandidate1Confirm)
        Me.grpConfirmation.Controls.Add(Me.btnNo)
        Me.grpConfirmation.Controls.Add(Me.btnYes)
        Me.grpConfirmation.Controls.Add(Me.LblCorrectOrIncorrect)
        Me.grpConfirmation.Controls.Add(Me.lblConfim)
        Me.grpConfirmation.Location = New System.Drawing.Point(573, 39)
        Me.grpConfirmation.Name = "grpConfirmation"
        Me.grpConfirmation.Size = New System.Drawing.Size(226, 207)
        Me.grpConfirmation.TabIndex = 8
        Me.grpConfirmation.TabStop = False
        Me.grpConfirmation.Text = "ConfirmationPage"
        Me.grpConfirmation.Visible = False
        '
        'LblCandidateChosen
        '
        Me.LblCandidateChosen.AutoSize = True
        Me.LblCandidateChosen.Location = New System.Drawing.Point(6, 60)
        Me.LblCandidateChosen.Name = "LblCandidateChosen"
        Me.LblCandidateChosen.Size = New System.Drawing.Size(206, 13)
        Me.LblCandidateChosen.TabIndex = 6
        Me.LblCandidateChosen.Text = "You have chosen the following candidate:"
        '
        'rdbCandidate2Confirm
        '
        Me.rdbCandidate2Confirm.AutoSize = True
        Me.rdbCandidate2Confirm.Location = New System.Drawing.Point(9, 125)
        Me.rdbCandidate2Confirm.Name = "rdbCandidate2Confirm"
        Me.rdbCandidate2Confirm.Size = New System.Drawing.Size(97, 17)
        Me.rdbCandidate2Confirm.TabIndex = 5
        Me.rdbCandidate2Confirm.TabStop = True
        Me.rdbCandidate2Confirm.Text = "Cameron Harris"
        Me.rdbCandidate2Confirm.UseVisualStyleBackColor = True
        '
        'rdbCandidate1Confirm
        '
        Me.rdbCandidate1Confirm.AutoSize = True
        Me.rdbCandidate1Confirm.Location = New System.Drawing.Point(9, 92)
        Me.rdbCandidate1Confirm.Name = "rdbCandidate1Confirm"
        Me.rdbCandidate1Confirm.Size = New System.Drawing.Size(81, 17)
        Me.rdbCandidate1Confirm.TabIndex = 4
        Me.rdbCandidate1Confirm.TabStop = True
        Me.rdbCandidate1Confirm.Text = "Alice Brown"
        Me.rdbCandidate1Confirm.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNo.Location = New System.Drawing.Point(104, 175)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnYes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnYes.Location = New System.Drawing.Point(9, 175)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'LblCorrectOrIncorrect
        '
        Me.LblCorrectOrIncorrect.AutoSize = True
        Me.LblCorrectOrIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrectOrIncorrect.Location = New System.Drawing.Point(40, 154)
        Me.LblCorrectOrIncorrect.Name = "LblCorrectOrIncorrect"
        Me.LblCorrectOrIncorrect.Size = New System.Drawing.Size(105, 18)
        Me.LblCorrectOrIncorrect.TabIndex = 1
        Me.LblCorrectOrIncorrect.Text = "Is this correct?"
        '
        'lblConfim
        '
        Me.lblConfim.AutoSize = True
        Me.lblConfim.BackColor = System.Drawing.SystemColors.Info
        Me.lblConfim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfim.Location = New System.Drawing.Point(6, 27)
        Me.lblConfim.Name = "lblConfim"
        Me.lblConfim.Size = New System.Drawing.Size(91, 13)
        Me.lblConfim.TabIndex = 0
        Me.lblConfim.Text = "Please Confirm"
        '
        'grpThankYou
        '
        Me.grpThankYou.Controls.Add(Me.lblEmail)
        Me.grpThankYou.Controls.Add(Me.btnExit)
        Me.grpThankYou.Controls.Add(Me.lblThankYou)
        Me.grpThankYou.Location = New System.Drawing.Point(364, 252)
        Me.grpThankYou.Name = "grpThankYou"
        Me.grpThankYou.Size = New System.Drawing.Size(435, 118)
        Me.grpThankYou.TabIndex = 9
        Me.grpThankYou.TabStop = False
        Me.grpThankYou.Text = "ThankyouPage"
        Me.grpThankYou.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(179, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblThankYou
        '
        Me.lblThankYou.AutoSize = True
        Me.lblThankYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThankYou.Location = New System.Drawing.Point(138, 34)
        Me.lblThankYou.Name = "lblThankYou"
        Me.lblThankYou.Size = New System.Drawing.Size(155, 20)
        Me.lblThankYou.TabIndex = 0
        Me.lblThankYou.Text = "Thank you for voting!"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescription.Location = New System.Drawing.Point(34, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(669, 13)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "**This is a simple prototype that includes some of the user requirements but not " &
    "all of them. It is to demonstrate how the website will look like**"
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Location = New System.Drawing.Point(6, 175)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(276, 13)
        Me.lblDescription2.TabIndex = 6
        Me.lblDescription2.Text = "If you type an invalid ID, the system will not let you sign in"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(101, 64)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(205, 13)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "You have been sent an email confirmation"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(123, 38)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(65, 13)
        Me.lblDueDate.TabIndex = 5
        Me.lblDueDate.Text = "01/13/2022"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(34, 38)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(68, 13)
        Me.lblStartDate.TabIndex = 6
        Me.lblStartDate.Text = "01/01/2022 "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(102, 38)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(16, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "---"
        '
        'frmVote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(810, 376)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.grpThankYou)
        Me.Controls.Add(Me.grpConfirmation)
        Me.Controls.Add(Me.grpVoting)
        Me.Controls.Add(Me.grpSignIn)
        Me.Name = "frmVote"
        Me.Text = "RamsVOTE"
        Me.grpSignIn.ResumeLayout(False)
        Me.grpSignIn.PerformLayout()
        Me.grpVoting.ResumeLayout(False)
        Me.grpVoting.PerformLayout()
        Me.grpConfirmation.ResumeLayout(False)
        Me.grpConfirmation.PerformLayout()
        Me.grpThankYou.ResumeLayout(False)
        Me.grpThankYou.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCheckStudentID As TextBox
    Friend WithEvents lblCheckStudentID As Label
    Friend WithEvents btnCheckStudentID As Button
    Friend WithEvents lblSignIn As Label
    Friend WithEvents lblStudentIDSample As Label
    Friend WithEvents grpSignIn As GroupBox
    Friend WithEvents grpVoting As GroupBox
    Friend WithEvents btnVote As Button
    Friend WithEvents rdbCandidate2 As RadioButton
    Friend WithEvents rdbCandidate1 As RadioButton
    Friend WithEvents lblHomecomingElection As Label
    Friend WithEvents lblChooseCandidate As Label
    Friend WithEvents grpConfirmation As GroupBox
    Friend WithEvents LblCandidateChosen As Label
    Friend WithEvents rdbCandidate2Confirm As RadioButton
    Friend WithEvents rdbCandidate1Confirm As RadioButton
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents LblCorrectOrIncorrect As Label
    Friend WithEvents lblConfim As Label
    Friend WithEvents grpThankYou As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblThankYou As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDescription2 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblDueDate As Label
End Class
