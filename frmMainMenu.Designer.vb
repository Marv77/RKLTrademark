<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Me.Controls.AddRange(New Control() {grpToHoldButtons, btnMainMenu,
                                            btnPreviousMenu, MonthCalendar1,
                                            pnlTimeOfDayNow, lblTimeOfDayNow,
                                            lblMenuTitle})
        Me.grpToHoldButtons = New System.Windows.Forms.GroupBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnPreviousMenu = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.pnlTimeOfDayNow = New System.Windows.Forms.Panel()
        Me.lblTimeOfDayNow = New System.Windows.Forms.Label()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.grpToHoldButtons.SuspendLayout()
        Me.pnlTimeOfDayNow.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpToHoldButtons
        '
        Me.grpToHoldButtons.Controls.Add(Me.lblMenuTitle)
        Me.grpToHoldButtons.Controls.Add(Me.btnMainMenu)
        Me.grpToHoldButtons.Controls.Add(Me.btnPreviousMenu)
        Me.grpToHoldButtons.Location = New System.Drawing.Point(2, 166)
        Me.grpToHoldButtons.Name = "grpToHoldButtons"
        Me.grpToHoldButtons.Size = New System.Drawing.Size(822, 427)
        Me.grpToHoldButtons.TabIndex = 2
        Me.grpToHoldButtons.TabStop = False
        Me.grpToHoldButtons.Text = "grpToHoldButtons"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(681, 329)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(102, 60)
        Me.btnMainMenu.TabIndex = 1
        Me.btnMainMenu.Text = "btnMainMenu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnPreviousMenu
        '
        Me.btnPreviousMenu.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousMenu.Location = New System.Drawing.Point(62, 329)
        Me.btnPreviousMenu.Name = "btnPreviousMenu"
        Me.btnPreviousMenu.Size = New System.Drawing.Size(102, 60)
        Me.btnPreviousMenu.TabIndex = 0
        Me.btnPreviousMenu.Text = "btnPreviousMenu"
        Me.btnPreviousMenu.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(2, 2)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'pnlTimeOfDayNow
        '
        Me.pnlTimeOfDayNow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTimeOfDayNow.Controls.Add(Me.lblTimeOfDayNow)
        Me.pnlTimeOfDayNow.Location = New System.Drawing.Point(619, 8)
        Me.pnlTimeOfDayNow.Name = "pnlTimeOfDayNow"
        Me.pnlTimeOfDayNow.Size = New System.Drawing.Size(204, 156)
        Me.pnlTimeOfDayNow.TabIndex = 4
        '
        'lblTimeOfDayNow
        '
        Me.lblTimeOfDayNow.AutoSize = True
        Me.lblTimeOfDayNow.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOfDayNow.Location = New System.Drawing.Point(3, 61)
        Me.lblTimeOfDayNow.Name = "lblTimeOfDayNow"
        Me.lblTimeOfDayNow.Size = New System.Drawing.Size(323, 49)
        Me.lblTimeOfDayNow.TabIndex = 0
        Me.lblTimeOfDayNow.Text = "lblTimeOfDayNow"
        Me.lblTimeOfDayNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.AutoSize = True
        Me.lblMenuTitle.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTitle.Location = New System.Drawing.Point(335, 18)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(153, 28)
        Me.lblMenuTitle.TabIndex = 2
        Me.lblMenuTitle.Text = "lblMenuTitle"
        Me.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 605)
        Me.Controls.Add(Me.pnlTimeOfDayNow)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.grpToHoldButtons)
        Me.Name = "frmMainMenu"
        Me.Text = "frmMainMenu"
        Me.grpToHoldButtons.ResumeLayout(False)
        Me.grpToHoldButtons.PerformLayout()
        Me.pnlTimeOfDayNow.ResumeLayout(False)
        Me.pnlTimeOfDayNow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpToHoldButtons As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents pnlTimeOfDayNow As Panel
    Friend WithEvents lblTimeOfDayNow As Label
    Friend WithEvents btnPreviousMenu As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblMenuTitle As Label
End Class
