<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeDNandSDN
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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnRestoreOrigFullDocketNumber = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCurrentFullDocketNumber = New System.Windows.Forms.Label()
        Me.lblNewFullDocketNumber = New System.Windows.Forms.Label()
        Me.txtNewFullDocketNumber = New System.Windows.Forms.TextBox()
        Me.txtCurrentFullDocketNumber = New System.Windows.Forms.TextBox()
        Me.grpOriginalFullDocketNumber = New System.Windows.Forms.GroupBox()
        Me.txtOriginalFullDocketNumber = New System.Windows.Forms.TextBox()
        Me.pnlChangeDNandSDN = New System.Windows.Forms.Panel()
        Me.pnlChangeSubDocketNumber = New System.Windows.Forms.Panel()
        Me.btnResetSDN = New System.Windows.Forms.Button()
        Me.btnLookUpSDN = New System.Windows.Forms.Button()
        Me.grpEnterNewSubDocketNumber = New System.Windows.Forms.GroupBox()
        Me.txtEnterNewSubDocketNumber = New System.Windows.Forms.TextBox()
        Me.txtCurrentSubDocketNumber = New System.Windows.Forms.TextBox()
        Me.lblCurrentSubDocketNumber = New System.Windows.Forms.Label()
        Me.pnlChangeDocketNumber = New System.Windows.Forms.Panel()
        Me.btnResetDN = New System.Windows.Forms.Button()
        Me.btnLookUpDN = New System.Windows.Forms.Button()
        Me.grpEnterNewDocketNumber = New System.Windows.Forms.GroupBox()
        Me.txtEnterNewDocketNumber = New System.Windows.Forms.TextBox()
        Me.txtCurrentDocketNumber = New System.Windows.Forms.TextBox()
        Me.lblCurrentDocketNumber = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpOriginalFullDocketNumber.SuspendLayout()
        Me.pnlChangeDNandSDN.SuspendLayout()
        Me.pnlChangeSubDocketNumber.SuspendLayout()
        Me.grpEnterNewSubDocketNumber.SuspendLayout()
        Me.pnlChangeDocketNumber.SuspendLayout()
        Me.grpEnterNewDocketNumber.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(133, 19)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "lblFormTitle"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.Location = New System.Drawing.Point(705, 13)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(182, 34)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.28688!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.71312!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDone, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRestoreOrigFullDocketNumber, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(106, 455)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(906, 61)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.Location = New System.Drawing.Point(225, 13)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(182, 34)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDone.Location = New System.Drawing.Point(12, 13)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(182, 34)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "btnDone"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnRestoreOrigFullDocketNumber
        '
        Me.btnRestoreOrigFullDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRestoreOrigFullDocketNumber.Location = New System.Drawing.Point(438, 13)
        Me.btnRestoreOrigFullDocketNumber.Name = "btnRestoreOrigFullDocketNumber"
        Me.btnRestoreOrigFullDocketNumber.Size = New System.Drawing.Size(232, 34)
        Me.btnRestoreOrigFullDocketNumber.TabIndex = 2
        Me.btnRestoreOrigFullDocketNumber.Text = "btnRestoreOrigFullDocketNumber"
        Me.btnRestoreOrigFullDocketNumber.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.58445!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.41555!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblCurrentFullDocketNumber, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNewFullDocketNumber, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNewFullDocketNumber, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCurrentFullDocketNumber, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.grpOriginalFullDocketNumber, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlChangeDNandSDN, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(29, 55)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1052, 394)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'lblCurrentFullDocketNumber
        '
        Me.lblCurrentFullDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCurrentFullDocketNumber.AutoSize = True
        Me.lblCurrentFullDocketNumber.Location = New System.Drawing.Point(266, 13)
        Me.lblCurrentFullDocketNumber.Name = "lblCurrentFullDocketNumber"
        Me.lblCurrentFullDocketNumber.Size = New System.Drawing.Size(139, 13)
        Me.lblCurrentFullDocketNumber.TabIndex = 0
        Me.lblCurrentFullDocketNumber.Text = "lblCurrentFullDocketNumber"
        Me.lblCurrentFullDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNewFullDocketNumber
        '
        Me.lblNewFullDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNewFullDocketNumber.AutoSize = True
        Me.lblNewFullDocketNumber.Location = New System.Drawing.Point(278, 53)
        Me.lblNewFullDocketNumber.Name = "lblNewFullDocketNumber"
        Me.lblNewFullDocketNumber.Size = New System.Drawing.Size(127, 13)
        Me.lblNewFullDocketNumber.TabIndex = 1
        Me.lblNewFullDocketNumber.Text = "lblNewFullDocketNumber"
        Me.lblNewFullDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewFullDocketNumber
        '
        Me.txtNewFullDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNewFullDocketNumber.Location = New System.Drawing.Point(411, 50)
        Me.txtNewFullDocketNumber.Name = "txtNewFullDocketNumber"
        Me.txtNewFullDocketNumber.Size = New System.Drawing.Size(206, 20)
        Me.txtNewFullDocketNumber.TabIndex = 2
        Me.txtNewFullDocketNumber.Text = "txtNewFullDocketNumber"
        '
        'txtCurrentFullDocketNumber
        '
        Me.txtCurrentFullDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCurrentFullDocketNumber.Location = New System.Drawing.Point(411, 10)
        Me.txtCurrentFullDocketNumber.Name = "txtCurrentFullDocketNumber"
        Me.txtCurrentFullDocketNumber.Size = New System.Drawing.Size(206, 20)
        Me.txtCurrentFullDocketNumber.TabIndex = 3
        Me.txtCurrentFullDocketNumber.Text = "txtCurrentFullDocketNumber"
        '
        'grpOriginalFullDocketNumber
        '
        Me.grpOriginalFullDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.grpOriginalFullDocketNumber.Controls.Add(Me.txtOriginalFullDocketNumber)
        Me.grpOriginalFullDocketNumber.Location = New System.Drawing.Point(666, 8)
        Me.grpOriginalFullDocketNumber.Name = "grpOriginalFullDocketNumber"
        Me.TableLayoutPanel2.SetRowSpan(Me.grpOriginalFullDocketNumber, 2)
        Me.grpOriginalFullDocketNumber.Size = New System.Drawing.Size(334, 63)
        Me.grpOriginalFullDocketNumber.TabIndex = 4
        Me.grpOriginalFullDocketNumber.TabStop = False
        Me.grpOriginalFullDocketNumber.Text = "grpOriginalFullDocketNumber"
        '
        'txtOriginalFullDocketNumber
        '
        Me.txtOriginalFullDocketNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOriginalFullDocketNumber.Location = New System.Drawing.Point(62, 28)
        Me.txtOriginalFullDocketNumber.Name = "txtOriginalFullDocketNumber"
        Me.txtOriginalFullDocketNumber.Size = New System.Drawing.Size(215, 20)
        Me.txtOriginalFullDocketNumber.TabIndex = 0
        Me.txtOriginalFullDocketNumber.Text = "txtOriginalFullDocketNumber"
        '
        'pnlChangeDNandSDN
        '
        Me.pnlChangeDNandSDN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.pnlChangeDNandSDN, 3)
        Me.pnlChangeDNandSDN.Controls.Add(Me.pnlChangeSubDocketNumber)
        Me.pnlChangeDNandSDN.Controls.Add(Me.pnlChangeDocketNumber)
        Me.pnlChangeDNandSDN.Location = New System.Drawing.Point(3, 83)
        Me.pnlChangeDNandSDN.Name = "pnlChangeDNandSDN"
        Me.pnlChangeDNandSDN.Size = New System.Drawing.Size(1046, 308)
        Me.pnlChangeDNandSDN.TabIndex = 5
        '
        'pnlChangeSubDocketNumber
        '
        Me.pnlChangeSubDocketNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChangeSubDocketNumber.Controls.Add(Me.btnResetSDN)
        Me.pnlChangeSubDocketNumber.Controls.Add(Me.btnLookUpSDN)
        Me.pnlChangeSubDocketNumber.Controls.Add(Me.grpEnterNewSubDocketNumber)
        Me.pnlChangeSubDocketNumber.Controls.Add(Me.txtCurrentSubDocketNumber)
        Me.pnlChangeSubDocketNumber.Controls.Add(Me.lblCurrentSubDocketNumber)
        Me.pnlChangeSubDocketNumber.Location = New System.Drawing.Point(123, 165)
        Me.pnlChangeSubDocketNumber.Name = "pnlChangeSubDocketNumber"
        Me.pnlChangeSubDocketNumber.Size = New System.Drawing.Size(799, 134)
        Me.pnlChangeSubDocketNumber.TabIndex = 1
        '
        'btnResetSDN
        '
        Me.btnResetSDN.Location = New System.Drawing.Point(450, 99)
        Me.btnResetSDN.Name = "btnResetSDN"
        Me.btnResetSDN.Size = New System.Drawing.Size(124, 30)
        Me.btnResetSDN.TabIndex = 4
        Me.btnResetSDN.Text = "btnResetSDN"
        Me.btnResetSDN.UseVisualStyleBackColor = True
        '
        'btnLookUpSDN
        '
        Me.btnLookUpSDN.Location = New System.Drawing.Point(225, 99)
        Me.btnLookUpSDN.Name = "btnLookUpSDN"
        Me.btnLookUpSDN.Size = New System.Drawing.Size(165, 30)
        Me.btnLookUpSDN.TabIndex = 3
        Me.btnLookUpSDN.Text = "btnLookUpSDN"
        Me.btnLookUpSDN.UseVisualStyleBackColor = True
        '
        'grpEnterNewSubDocketNumber
        '
        Me.grpEnterNewSubDocketNumber.Controls.Add(Me.txtEnterNewSubDocketNumber)
        Me.grpEnterNewSubDocketNumber.Location = New System.Drawing.Point(39, 40)
        Me.grpEnterNewSubDocketNumber.Name = "grpEnterNewSubDocketNumber"
        Me.grpEnterNewSubDocketNumber.Size = New System.Drawing.Size(720, 55)
        Me.grpEnterNewSubDocketNumber.TabIndex = 2
        Me.grpEnterNewSubDocketNumber.TabStop = False
        Me.grpEnterNewSubDocketNumber.Text = "grpEnterNewSubDocketNumber"
        '
        'txtEnterNewSubDocketNumber
        '
        Me.txtEnterNewSubDocketNumber.Location = New System.Drawing.Point(297, 22)
        Me.txtEnterNewSubDocketNumber.Name = "txtEnterNewSubDocketNumber"
        Me.txtEnterNewSubDocketNumber.Size = New System.Drawing.Size(158, 20)
        Me.txtEnterNewSubDocketNumber.TabIndex = 0
        Me.txtEnterNewSubDocketNumber.Text = "txtEnterNewSubDocketNumber"
        '
        'txtCurrentSubDocketNumber
        '
        Me.txtCurrentSubDocketNumber.Location = New System.Drawing.Point(481, 8)
        Me.txtCurrentSubDocketNumber.Name = "txtCurrentSubDocketNumber"
        Me.txtCurrentSubDocketNumber.Size = New System.Drawing.Size(152, 20)
        Me.txtCurrentSubDocketNumber.TabIndex = 1
        Me.txtCurrentSubDocketNumber.Text = "txtCurrentSubDocketNumber"
        '
        'lblCurrentSubDocketNumber
        '
        Me.lblCurrentSubDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCurrentSubDocketNumber.AutoSize = True
        Me.lblCurrentSubDocketNumber.Location = New System.Drawing.Point(198, 10)
        Me.lblCurrentSubDocketNumber.Name = "lblCurrentSubDocketNumber"
        Me.lblCurrentSubDocketNumber.Size = New System.Drawing.Size(142, 13)
        Me.lblCurrentSubDocketNumber.TabIndex = 0
        Me.lblCurrentSubDocketNumber.Text = "lblCurrentSubDocketNumber"
        Me.lblCurrentSubDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlChangeDocketNumber
        '
        Me.pnlChangeDocketNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChangeDocketNumber.Controls.Add(Me.btnResetDN)
        Me.pnlChangeDocketNumber.Controls.Add(Me.btnLookUpDN)
        Me.pnlChangeDocketNumber.Controls.Add(Me.grpEnterNewDocketNumber)
        Me.pnlChangeDocketNumber.Controls.Add(Me.txtCurrentDocketNumber)
        Me.pnlChangeDocketNumber.Controls.Add(Me.lblCurrentDocketNumber)
        Me.pnlChangeDocketNumber.Location = New System.Drawing.Point(123, 16)
        Me.pnlChangeDocketNumber.Name = "pnlChangeDocketNumber"
        Me.pnlChangeDocketNumber.Size = New System.Drawing.Size(799, 134)
        Me.pnlChangeDocketNumber.TabIndex = 0
        '
        'btnResetDN
        '
        Me.btnResetDN.Location = New System.Drawing.Point(453, 97)
        Me.btnResetDN.Name = "btnResetDN"
        Me.btnResetDN.Size = New System.Drawing.Size(124, 30)
        Me.btnResetDN.TabIndex = 4
        Me.btnResetDN.Text = "btnResetDN"
        Me.btnResetDN.UseVisualStyleBackColor = True
        '
        'btnLookUpDN
        '
        Me.btnLookUpDN.Location = New System.Drawing.Point(225, 97)
        Me.btnLookUpDN.Name = "btnLookUpDN"
        Me.btnLookUpDN.Size = New System.Drawing.Size(165, 30)
        Me.btnLookUpDN.TabIndex = 3
        Me.btnLookUpDN.Text = "btnLookUpDN"
        Me.btnLookUpDN.UseVisualStyleBackColor = True
        '
        'grpEnterNewDocketNumber
        '
        Me.grpEnterNewDocketNumber.Controls.Add(Me.txtEnterNewDocketNumber)
        Me.grpEnterNewDocketNumber.Location = New System.Drawing.Point(39, 38)
        Me.grpEnterNewDocketNumber.Name = "grpEnterNewDocketNumber"
        Me.grpEnterNewDocketNumber.Size = New System.Drawing.Size(720, 55)
        Me.grpEnterNewDocketNumber.TabIndex = 2
        Me.grpEnterNewDocketNumber.TabStop = False
        Me.grpEnterNewDocketNumber.Text = "grpEnterNewDocketNumber"
        '
        'txtEnterNewDocketNumber
        '
        Me.txtEnterNewDocketNumber.Location = New System.Drawing.Point(297, 23)
        Me.txtEnterNewDocketNumber.Name = "txtEnterNewDocketNumber"
        Me.txtEnterNewDocketNumber.Size = New System.Drawing.Size(147, 20)
        Me.txtEnterNewDocketNumber.TabIndex = 0
        Me.txtEnterNewDocketNumber.Text = "txtEnterNewDocketNumber"
        '
        'txtCurrentDocketNumber
        '
        Me.txtCurrentDocketNumber.Location = New System.Drawing.Point(481, 6)
        Me.txtCurrentDocketNumber.Name = "txtCurrentDocketNumber"
        Me.txtCurrentDocketNumber.Size = New System.Drawing.Size(113, 20)
        Me.txtCurrentDocketNumber.TabIndex = 1
        Me.txtCurrentDocketNumber.Text = "txtCurrentDocketNumber"
        '
        'lblCurrentDocketNumber
        '
        Me.lblCurrentDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCurrentDocketNumber.AutoSize = True
        Me.lblCurrentDocketNumber.Location = New System.Drawing.Point(246, 10)
        Me.lblCurrentDocketNumber.Name = "lblCurrentDocketNumber"
        Me.lblCurrentDocketNumber.Size = New System.Drawing.Size(123, 13)
        Me.lblCurrentDocketNumber.TabIndex = 0
        Me.lblCurrentDocketNumber.Text = "lblCurrentDocketNumber"
        Me.lblCurrentDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmChangeDNandSDN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 528)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmChangeDNandSDN"
        Me.Text = "frmChangeDNandSDN"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grpOriginalFullDocketNumber.ResumeLayout(False)
        Me.grpOriginalFullDocketNumber.PerformLayout()
        Me.pnlChangeDNandSDN.ResumeLayout(False)
        Me.pnlChangeSubDocketNumber.ResumeLayout(False)
        Me.pnlChangeSubDocketNumber.PerformLayout()
        Me.grpEnterNewSubDocketNumber.ResumeLayout(False)
        Me.grpEnterNewSubDocketNumber.PerformLayout()
        Me.pnlChangeDocketNumber.ResumeLayout(False)
        Me.pnlChangeDocketNumber.PerformLayout()
        Me.grpEnterNewDocketNumber.ResumeLayout(False)
        Me.grpEnterNewDocketNumber.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblCurrentFullDocketNumber As Label
    Friend WithEvents lblNewFullDocketNumber As Label
    Friend WithEvents txtNewFullDocketNumber As TextBox
    Friend WithEvents txtCurrentFullDocketNumber As TextBox
    Friend WithEvents grpOriginalFullDocketNumber As GroupBox
    Friend WithEvents txtOriginalFullDocketNumber As TextBox
    Friend WithEvents pnlChangeDNandSDN As Panel
    Friend WithEvents pnlChangeDocketNumber As Panel
    Friend WithEvents grpEnterNewDocketNumber As GroupBox
    Friend WithEvents txtCurrentDocketNumber As TextBox
    Friend WithEvents lblCurrentDocketNumber As Label
    Friend WithEvents txtEnterNewDocketNumber As TextBox
    Friend WithEvents btnResetDN As Button
    Friend WithEvents btnLookUpDN As Button
    Friend WithEvents pnlChangeSubDocketNumber As Panel
    Friend WithEvents grpEnterNewSubDocketNumber As GroupBox
    Friend WithEvents txtCurrentSubDocketNumber As TextBox
    Friend WithEvents lblCurrentSubDocketNumber As Label
    Friend WithEvents btnLookUpSDN As Button
    Friend WithEvents txtEnterNewSubDocketNumber As TextBox
    Friend WithEvents btnResetSDN As Button
    Friend WithEvents btnRestoreOrigFullDocketNumber As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDone As Button
End Class
