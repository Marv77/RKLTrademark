<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu2
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
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.btnPreviousMenu = New System.Windows.Forms.Button()
        Me.pnlTimeOfDayNow = New System.Windows.Forms.Panel()
        Me.lblTimeOfDayNow = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.tplMainMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.pnlHeading = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblRKLTrademark = New System.Windows.Forms.Label()
        Me.lblChartered = New System.Windows.Forms.Label()
        Me.lblRKL = New System.Windows.Forms.Label()
        Me.pnlTimeOfDayNow.SuspendLayout()
        Me.tplMainMenu.SuspendLayout()
        Me.pnlHeading.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblMenuTitle.AutoSize = True
        Me.lblMenuTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTitle.Location = New System.Drawing.Point(446, 170)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(156, 40)
        Me.lblMenuTitle.TabIndex = 2
        Me.lblMenuTitle.Text = "lblMenuTitle"
        Me.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPreviousMenu
        '
        Me.btnPreviousMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreviousMenu.Location = New System.Drawing.Point(83, 393)
        Me.btnPreviousMenu.Name = "btnPreviousMenu"
        Me.tplMainMenu.SetRowSpan(Me.btnPreviousMenu, 2)
        Me.btnPreviousMenu.Size = New System.Drawing.Size(153, 114)
        Me.btnPreviousMenu.TabIndex = 1
        Me.btnPreviousMenu.Text = "btnPreviousMenu"
        Me.btnPreviousMenu.UseVisualStyleBackColor = True
        '
        'pnlTimeOfDayNow
        '
        Me.pnlTimeOfDayNow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlTimeOfDayNow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlTimeOfDayNow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTimeOfDayNow.Controls.Add(Me.lblTimeOfDayNow)
        Me.pnlTimeOfDayNow.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTimeOfDayNow.Location = New System.Drawing.Point(813, 3)
        Me.pnlTimeOfDayNow.Name = "pnlTimeOfDayNow"
        Me.pnlTimeOfDayNow.Size = New System.Drawing.Size(245, 164)
        Me.pnlTimeOfDayNow.TabIndex = 1
        '
        'lblTimeOfDayNow
        '
        Me.lblTimeOfDayNow.AutoSize = True
        Me.lblTimeOfDayNow.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOfDayNow.Location = New System.Drawing.Point(-3, 45)
        Me.lblTimeOfDayNow.Name = "lblTimeOfDayNow"
        Me.lblTimeOfDayNow.Size = New System.Drawing.Size(441, 67)
        Me.lblTimeOfDayNow.TabIndex = 0
        Me.lblTimeOfDayNow.Text = "lblTimeOfDayNow"
        Me.lblTimeOfDayNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'tplMainMenu
        '
        Me.tplMainMenu.ColumnCount = 3
        Me.tplMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239.0!))
        Me.tplMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 571.0!))
        Me.tplMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tplMainMenu.Controls.Add(Me.pnlTimeOfDayNow, 2, 0)
        Me.tplMainMenu.Controls.Add(Me.MonthCalendar1, 0, 0)
        Me.tplMainMenu.Controls.Add(Me.lblMenuTitle, 1, 1)
        Me.tplMainMenu.Controls.Add(Me.btnMainMenu, 2, 5)
        Me.tplMainMenu.Controls.Add(Me.btnPreviousMenu, 0, 5)
        Me.tplMainMenu.Controls.Add(Me.pnlHeading, 1, 0)
        Me.tplMainMenu.Location = New System.Drawing.Point(3, 4)
        Me.tplMainMenu.Name = "tplMainMenu"
        Me.tplMainMenu.RowCount = 9
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tplMainMenu.Size = New System.Drawing.Size(1061, 568)
        Me.tplMainMenu.TabIndex = 4
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMainMenu.Location = New System.Drawing.Point(813, 393)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.tplMainMenu.SetRowSpan(Me.btnMainMenu, 2)
        Me.btnMainMenu.Size = New System.Drawing.Size(153, 114)
        Me.btnMainMenu.TabIndex = 3
        Me.btnMainMenu.Text = "btnMainMenu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'pnlHeading
        '
        Me.pnlHeading.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHeading.Controls.Add(Me.lblVersion)
        Me.pnlHeading.Controls.Add(Me.lblRKLTrademark)
        Me.pnlHeading.Controls.Add(Me.lblChartered)
        Me.pnlHeading.Controls.Add(Me.lblRKL)
        Me.pnlHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeading.Location = New System.Drawing.Point(242, 3)
        Me.pnlHeading.Name = "pnlHeading"
        Me.pnlHeading.Size = New System.Drawing.Size(565, 164)
        Me.pnlHeading.TabIndex = 4
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(230, 142)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(76, 18)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "lblVersion"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRKLTrademark
        '
        Me.lblRKLTrademark.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRKLTrademark.AutoSize = True
        Me.lblRKLTrademark.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRKLTrademark.Location = New System.Drawing.Point(102, 90)
        Me.lblRKLTrademark.Name = "lblRKLTrademark"
        Me.lblRKLTrademark.Size = New System.Drawing.Size(326, 44)
        Me.lblRKLTrademark.TabIndex = 2
        Me.lblRKLTrademark.Text = "lblRKLTrademark"
        Me.lblRKLTrademark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChartered
        '
        Me.lblChartered.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChartered.AutoSize = True
        Me.lblChartered.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartered.Location = New System.Drawing.Point(252, 60)
        Me.lblChartered.Name = "lblChartered"
        Me.lblChartered.Size = New System.Drawing.Size(114, 22)
        Me.lblChartered.TabIndex = 1
        Me.lblChartered.Text = "lblChartered"
        Me.lblChartered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRKL
        '
        Me.lblRKL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRKL.AutoSize = True
        Me.lblRKL.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRKL.Location = New System.Drawing.Point(121, 16)
        Me.lblRKL.Name = "lblRKL"
        Me.lblRKL.Size = New System.Drawing.Size(123, 41)
        Me.lblRKL.TabIndex = 0
        Me.lblRKL.Text = "lblRKL"
        Me.lblRKL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMainMenu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 623)
        Me.Controls.Add(Me.tplMainMenu)
        Me.Name = "frmMainMenu2"
        Me.Text = "frmMainMenu2"
        Me.pnlTimeOfDayNow.ResumeLayout(False)
        Me.pnlTimeOfDayNow.PerformLayout()
        Me.tplMainMenu.ResumeLayout(False)
        Me.tplMainMenu.PerformLayout()
        Me.pnlHeading.ResumeLayout(False)
        Me.pnlHeading.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPreviousMenu As Button
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents pnlTimeOfDayNow As Panel
    Friend WithEvents lblTimeOfDayNow As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents tplMainMenu As TableLayoutPanel
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents pnlHeading As Panel
    Friend WithEvents lblRKL As Label
    Friend WithEvents lblChartered As Label
    Friend WithEvents lblRKLTrademark As Label
    Friend WithEvents lblVersion As Label
End Class
