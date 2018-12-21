<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome1
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
        Me.grpTopHeading = New System.Windows.Forms.GroupBox()
        Me.lblChartered = New System.Windows.Forms.Label()
        Me.lblRKLHeading = New System.Windows.Forms.Label()
        Me.lblRKLDBPath = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblTotalRecordCount = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblChangeDate = New System.Windows.Forms.Label()
        Me.lblTodaysDate = New System.Windows.Forms.Label()
        Me.rtbUserName = New System.Windows.Forms.RichTextBox()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpTopHeading.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTopHeading
        '
        Me.grpTopHeading.BackColor = System.Drawing.Color.Aqua
        Me.grpTopHeading.Controls.Add(Me.lblChartered)
        Me.grpTopHeading.Controls.Add(Me.lblRKLHeading)
        Me.grpTopHeading.Location = New System.Drawing.Point(28, 15)
        Me.grpTopHeading.Name = "grpTopHeading"
        Me.grpTopHeading.Size = New System.Drawing.Size(936, 91)
        Me.grpTopHeading.TabIndex = 0
        Me.grpTopHeading.TabStop = False
        Me.grpTopHeading.Text = "grpTopHeading"
        '
        'lblChartered
        '
        Me.lblChartered.AutoSize = True
        Me.lblChartered.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartered.Location = New System.Drawing.Point(431, 56)
        Me.lblChartered.Name = "lblChartered"
        Me.lblChartered.Size = New System.Drawing.Size(114, 22)
        Me.lblChartered.TabIndex = 1
        Me.lblChartered.Text = "lblChartered"
        Me.lblChartered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRKLHeading
        '
        Me.lblRKLHeading.AutoSize = True
        Me.lblRKLHeading.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRKLHeading.Location = New System.Drawing.Point(352, 16)
        Me.lblRKLHeading.Name = "lblRKLHeading"
        Me.lblRKLHeading.Size = New System.Drawing.Size(224, 36)
        Me.lblRKLHeading.TabIndex = 0
        Me.lblRKLHeading.Text = "lblRKLHeading"
        Me.lblRKLHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRKLDBPath
        '
        Me.lblRKLDBPath.AutoSize = True
        Me.lblRKLDBPath.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRKLDBPath.Location = New System.Drawing.Point(241, 360)
        Me.lblRKLDBPath.Name = "lblRKLDBPath"
        Me.lblRKLDBPath.Size = New System.Drawing.Size(95, 16)
        Me.lblRKLDBPath.TabIndex = 1
        Me.lblRKLDBPath.Text = "lblRKLDBPath"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(63, 112)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(169, 32)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "lblWelcome"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(378, 160)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(156, 29)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "lblCopyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalRecordCount
        '
        Me.lblTotalRecordCount.AutoSize = True
        Me.lblTotalRecordCount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecordCount.Location = New System.Drawing.Point(247, 228)
        Me.lblTotalRecordCount.Name = "lblTotalRecordCount"
        Me.lblTotalRecordCount.Size = New System.Drawing.Size(215, 24)
        Me.lblTotalRecordCount.TabIndex = 4
        Me.lblTotalRecordCount.Text = "lblTotalRecordCount"
        Me.lblTotalRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpLogin.Controls.Add(Me.DateTimePicker1)
        Me.grpLogin.Controls.Add(Me.lblChangeDate)
        Me.grpLogin.Controls.Add(Me.lblTodaysDate)
        Me.grpLogin.Controls.Add(Me.rtbUserName)
        Me.grpLogin.Controls.Add(Me.lblLoginName)
        Me.grpLogin.Location = New System.Drawing.Point(58, 269)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(876, 87)
        Me.grpLogin.TabIndex = 5
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "grpLogin"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(834, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(18, 20)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Value = New Date(2017, 8, 29, 10, 57, 30, 0)
        '
        'lblChangeDate
        '
        Me.lblChangeDate.AutoSize = True
        Me.lblChangeDate.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeDate.Location = New System.Drawing.Point(461, 56)
        Me.lblChangeDate.Name = "lblChangeDate"
        Me.lblChangeDate.Size = New System.Drawing.Size(148, 23)
        Me.lblChangeDate.TabIndex = 3
        Me.lblChangeDate.Text = "lblChangeDate"
        Me.lblChangeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTodaysDate
        '
        Me.lblTodaysDate.AutoSize = True
        Me.lblTodaysDate.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaysDate.Location = New System.Drawing.Point(47, 57)
        Me.lblTodaysDate.Name = "lblTodaysDate"
        Me.lblTodaysDate.Size = New System.Drawing.Size(144, 23)
        Me.lblTodaysDate.TabIndex = 2
        Me.lblTodaysDate.Text = "lblTodaysDate"
        Me.lblTodaysDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbUserName
        '
        Me.rtbUserName.BackColor = System.Drawing.SystemColors.Window
        Me.rtbUserName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtbUserName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbUserName.Location = New System.Drawing.Point(590, 16)
        Me.rtbUserName.Name = "rtbUserName"
        Me.rtbUserName.Size = New System.Drawing.Size(152, 28)
        Me.rtbUserName.TabIndex = 1
        Me.rtbUserName.Text = "rtbUserName"
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginName.Location = New System.Drawing.Point(242, 18)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(152, 24)
        Me.lblLoginName.TabIndex = 0
        Me.lblLoginName.Text = "lblLoginName"
        Me.lblLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(183, 382)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(264, 46)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "btnContinue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(524, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(264, 46)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Welcome1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.lblTotalRecordCount)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblRKLDBPath)
        Me.Controls.Add(Me.grpTopHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Welcome1"
        Me.Text = "Welcome1"
        Me.grpTopHeading.ResumeLayout(False)
        Me.grpTopHeading.PerformLayout()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTopHeading As GroupBox
    Friend WithEvents lblRKLDBPath As Label
    Friend WithEvents lblRKLHeading As Label
    Friend WithEvents lblChartered As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblTotalRecordCount As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents lblLoginName As Label
    Friend WithEvents rtbUserName As RichTextBox
    Friend WithEvents lblTodaysDate As Label
    Friend WithEvents lblChangeDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnExit As Button
End Class
