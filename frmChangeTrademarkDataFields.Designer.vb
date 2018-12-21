<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeTrademarkDataFields
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
        Me.lblCurrentDataFieldValue = New System.Windows.Forms.Label()
        Me.txtCurrentDataFieldValue = New System.Windows.Forms.TextBox()
        Me.grpNewDataField = New System.Windows.Forms.GroupBox()
        Me.mskNewDateField = New System.Windows.Forms.MaskedTextBox()
        Me.lstResponsibleAttorney = New System.Windows.Forms.ListBox()
        Me.txtNewDataField = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnChangeValueToNone = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpNewDataField.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(113, 21)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "lblFormTitle"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentDataFieldValue
        '
        Me.lblCurrentDataFieldValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCurrentDataFieldValue.AutoSize = True
        Me.lblCurrentDataFieldValue.Location = New System.Drawing.Point(151, 59)
        Me.lblCurrentDataFieldValue.Name = "lblCurrentDataFieldValue"
        Me.lblCurrentDataFieldValue.Size = New System.Drawing.Size(123, 13)
        Me.lblCurrentDataFieldValue.TabIndex = 1
        Me.lblCurrentDataFieldValue.Text = "lblCurrentDataFieldValue"
        Me.lblCurrentDataFieldValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCurrentDataFieldValue
        '
        Me.txtCurrentDataFieldValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCurrentDataFieldValue.Location = New System.Drawing.Point(454, 56)
        Me.txtCurrentDataFieldValue.Name = "txtCurrentDataFieldValue"
        Me.txtCurrentDataFieldValue.Size = New System.Drawing.Size(144, 20)
        Me.txtCurrentDataFieldValue.TabIndex = 2
        Me.txtCurrentDataFieldValue.Text = "txtCurrentDataFieldValue"
        '
        'grpNewDataField
        '
        Me.grpNewDataField.Controls.Add(Me.mskNewDateField)
        Me.grpNewDataField.Controls.Add(Me.lstResponsibleAttorney)
        Me.grpNewDataField.Controls.Add(Me.txtNewDataField)
        Me.grpNewDataField.Location = New System.Drawing.Point(62, 106)
        Me.grpNewDataField.Name = "grpNewDataField"
        Me.grpNewDataField.Size = New System.Drawing.Size(584, 62)
        Me.grpNewDataField.TabIndex = 3
        Me.grpNewDataField.TabStop = False
        Me.grpNewDataField.Text = "grpNewDataField"
        '
        'mskNewDateField
        '
        Me.mskNewDateField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNewDateField.Location = New System.Drawing.Point(401, 25)
        Me.mskNewDateField.Mask = "00/00/0000"
        Me.mskNewDateField.Name = "mskNewDateField"
        Me.mskNewDateField.Size = New System.Drawing.Size(122, 26)
        Me.mskNewDateField.TabIndex = 3
        Me.mskNewDateField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskNewDateField.ValidatingType = GetType(Date)
        '
        'lstResponsibleAttorney
        '
        Me.lstResponsibleAttorney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResponsibleAttorney.FormattingEnabled = True
        Me.lstResponsibleAttorney.ItemHeight = 20
        Me.lstResponsibleAttorney.Location = New System.Drawing.Point(230, 32)
        Me.lstResponsibleAttorney.Name = "lstResponsibleAttorney"
        Me.lstResponsibleAttorney.Size = New System.Drawing.Size(138, 24)
        Me.lstResponsibleAttorney.TabIndex = 2
        '
        'txtNewDataField
        '
        Me.txtNewDataField.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNewDataField.Location = New System.Drawing.Point(230, 24)
        Me.txtNewDataField.Name = "txtNewDataField"
        Me.txtNewDataField.Size = New System.Drawing.Size(132, 20)
        Me.txtNewDataField.TabIndex = 0
        Me.txtNewDataField.Text = "txtNewDataField"
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDone.Location = New System.Drawing.Point(88, 199)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(112, 34)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "btnDone"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnChangeValueToNone
        '
        Me.btnChangeValueToNone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangeValueToNone.Location = New System.Drawing.Point(231, 199)
        Me.btnChangeValueToNone.Name = "btnChangeValueToNone"
        Me.btnChangeValueToNone.Size = New System.Drawing.Size(112, 34)
        Me.btnChangeValueToNone.TabIndex = 5
        Me.btnChangeValueToNone.Text = "btnChangeValueToNone"
        Me.btnChangeValueToNone.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(374, 199)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 34)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(517, 199)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmChangeTrademarkDataFields
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 278)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnChangeValueToNone)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grpNewDataField)
        Me.Controls.Add(Me.txtCurrentDataFieldValue)
        Me.Controls.Add(Me.lblCurrentDataFieldValue)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmChangeTrademarkDataFields"
        Me.Text = "frmChangeTrademarkDataFields"
        Me.grpNewDataField.ResumeLayout(False)
        Me.grpNewDataField.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblCurrentDataFieldValue As Label
    Friend WithEvents txtCurrentDataFieldValue As TextBox
    Friend WithEvents grpNewDataField As GroupBox
    Friend WithEvents txtNewDataField As TextBox
    Friend WithEvents btnDone As Button
    Friend WithEvents btnChangeValueToNone As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lstResponsibleAttorney As ListBox
    Friend WithEvents mskNewDateField As MaskedTextBox
End Class
