<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPromptForStudentID = New System.Windows.Forms.Label()
        Me.tbxStudentID = New System.Windows.Forms.TextBox()
        Me.lblLookUpResults = New System.Windows.Forms.Label()
        Me.gbxPINSelection = New System.Windows.Forms.GroupBox()
        Me.tbxPin = New System.Windows.Forms.TextBox()
        Me.btnClearPIN = New System.Windows.Forms.Button()
        Me.btnVerifyPIN = New System.Windows.Forms.Button()
        Me.BtnClearStudentID = New System.Windows.Forms.Button()
        Me.btnValidateStudentID = New System.Windows.Forms.Button()
        Me.pbxTSTCLogo = New System.Windows.Forms.PictureBox()
        Me.gbxPINSelection.SuspendLayout()
        CType(Me.pbxTSTCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(230, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPromptForStudentID
        '
        Me.lblPromptForStudentID.AutoSize = True
        Me.lblPromptForStudentID.Location = New System.Drawing.Point(37, 105)
        Me.lblPromptForStudentID.Name = "lblPromptForStudentID"
        Me.lblPromptForStudentID.Size = New System.Drawing.Size(152, 19)
        Me.lblPromptForStudentID.TabIndex = 0
        Me.lblPromptForStudentID.Text = "Enter a Student ID #:"
        '
        'tbxStudentID
        '
        Me.tbxStudentID.Location = New System.Drawing.Point(195, 102)
        Me.tbxStudentID.MaxLength = 7
        Me.tbxStudentID.Name = "tbxStudentID"
        Me.tbxStudentID.Size = New System.Drawing.Size(139, 26)
        Me.tbxStudentID.TabIndex = 1
        '
        'lblLookUpResults
        '
        Me.lblLookUpResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLookUpResults.Location = New System.Drawing.Point(37, 138)
        Me.lblLookUpResults.Name = "lblLookUpResults"
        Me.lblLookUpResults.Size = New System.Drawing.Size(297, 27)
        Me.lblLookUpResults.TabIndex = 2
        Me.lblLookUpResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxPINSelection
        '
        Me.gbxPINSelection.Controls.Add(Me.tbxPin)
        Me.gbxPINSelection.Controls.Add(Me.btnClearPIN)
        Me.gbxPINSelection.Controls.Add(Me.btnVerifyPIN)
        Me.gbxPINSelection.Enabled = False
        Me.gbxPINSelection.Location = New System.Drawing.Point(37, 249)
        Me.gbxPINSelection.Name = "gbxPINSelection"
        Me.gbxPINSelection.Size = New System.Drawing.Size(297, 132)
        Me.gbxPINSelection.TabIndex = 5
        Me.gbxPINSelection.TabStop = False
        Me.gbxPINSelection.Text = " PIN Selection"
        Me.gbxPINSelection.Visible = False
        '
        'tbxPin
        '
        Me.tbxPin.Location = New System.Drawing.Point(19, 26)
        Me.tbxPin.MaxLength = 7
        Me.tbxPin.Name = "tbxPin"
        Me.tbxPin.Size = New System.Drawing.Size(157, 26)
        Me.tbxPin.TabIndex = 0
        '
        'btnClearPIN
        '
        Me.btnClearPIN.ForeColor = System.Drawing.Color.Black
        Me.btnClearPIN.Location = New System.Drawing.Point(101, 68)
        Me.btnClearPIN.Name = "btnClearPIN"
        Me.btnClearPIN.Size = New System.Drawing.Size(75, 48)
        Me.btnClearPIN.TabIndex = 2
        Me.btnClearPIN.Text = "Clear PIN"
        Me.btnClearPIN.UseVisualStyleBackColor = True
        '
        'btnVerifyPIN
        '
        Me.btnVerifyPIN.ForeColor = System.Drawing.Color.Black
        Me.btnVerifyPIN.Location = New System.Drawing.Point(19, 68)
        Me.btnVerifyPIN.Name = "btnVerifyPIN"
        Me.btnVerifyPIN.Size = New System.Drawing.Size(75, 48)
        Me.btnVerifyPIN.TabIndex = 1
        Me.btnVerifyPIN.Text = "Verify PIN"
        Me.btnVerifyPIN.UseVisualStyleBackColor = True
        '
        'BtnClearStudentID
        '
        Me.BtnClearStudentID.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClearStudentID.ForeColor = System.Drawing.Color.Black
        Me.BtnClearStudentID.Location = New System.Drawing.Point(37, 178)
        Me.BtnClearStudentID.Name = "BtnClearStudentID"
        Me.BtnClearStudentID.Size = New System.Drawing.Size(106, 52)
        Me.BtnClearStudentID.TabIndex = 3
        Me.BtnClearStudentID.Text = "Clear Student ID"
        Me.BtnClearStudentID.UseVisualStyleBackColor = True
        '
        'btnValidateStudentID
        '
        Me.btnValidateStudentID.ForeColor = System.Drawing.Color.Black
        Me.btnValidateStudentID.Location = New System.Drawing.Point(228, 178)
        Me.btnValidateStudentID.Name = "btnValidateStudentID"
        Me.btnValidateStudentID.Size = New System.Drawing.Size(106, 52)
        Me.btnValidateStudentID.TabIndex = 4
        Me.btnValidateStudentID.Text = "Validate Student ID"
        Me.btnValidateStudentID.UseVisualStyleBackColor = True
        '
        'pbxTSTCLogo
        '
        Me.pbxTSTCLogo.Image = Global.VB_Student_ID_Application_Framework.My.Resources.Resources.TSTC_Logo
        Me.pbxTSTCLogo.Location = New System.Drawing.Point(31, 16)
        Me.pbxTSTCLogo.Name = "pbxTSTCLogo"
        Me.pbxTSTCLogo.Size = New System.Drawing.Size(305, 71)
        Me.pbxTSTCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxTSTCLogo.TabIndex = 7
        Me.pbxTSTCLogo.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnValidateStudentID
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.CancelButton = Me.BtnClearStudentID
        Me.ClientSize = New System.Drawing.Size(366, 445)
        Me.Controls.Add(Me.pbxTSTCLogo)
        Me.Controls.Add(Me.btnValidateStudentID)
        Me.Controls.Add(Me.BtnClearStudentID)
        Me.Controls.Add(Me.gbxPINSelection)
        Me.Controls.Add(Me.lblLookUpResults)
        Me.Controls.Add(Me.tbxStudentID)
        Me.Controls.Add(Me.lblPromptForStudentID)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "2020.07 (GitHub)"
        Me.Text = "TSTC Student PIN selection"
        Me.gbxPINSelection.ResumeLayout(False)
        Me.gbxPINSelection.PerformLayout()
        CType(Me.pbxTSTCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblPromptForStudentID As Label
    Friend WithEvents tbxStudentID As TextBox
    Friend WithEvents lblLookUpResults As Label
    Friend WithEvents gbxPINSelection As GroupBox
    Friend WithEvents BtnClearStudentID As Button
    Friend WithEvents btnValidateStudentID As Button
    Friend WithEvents btnVerifyPIN As Button
    Friend WithEvents btnClearPIN As Button
    Friend WithEvents pbxTSTCLogo As PictureBox
    Friend WithEvents tbxPin As TextBox
End Class
