<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlsTemplates
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
        Me.grpOfRadioButtons = New System.Windows.Forms.GroupBox()
        Me.grpOfYesNoRadioButtons = New System.Windows.Forms.GroupBox()
        Me.grpWithLabelAndYesNoButtons = New System.Windows.Forms.GroupBox()
        Me.lblForYesNoButtons = New System.Windows.Forms.Label()
        Me.grpOfCheckBoxes = New System.Windows.Forms.GroupBox()
        Me.grpOfAllParameterControls = New System.Windows.Forms.GroupBox()
        Me.txtEnterNumbersOnly = New System.Windows.Forms.TextBox()
        Me.txtDateField = New System.Windows.Forms.MaskedTextBox()
        Me.grpWithLabelAndYesNoButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(192, 9)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(1070, 27)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "This Form is used to HOLD the many COMPOSIT Controls that are nneded to prepre th" &
    "e RKLTrademark Program"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpOfRadioButtons
        '
        Me.grpOfRadioButtons.BackColor = System.Drawing.SystemColors.Control
        Me.grpOfRadioButtons.Location = New System.Drawing.Point(73, 53)
        Me.grpOfRadioButtons.Name = "grpOfRadioButtons"
        Me.grpOfRadioButtons.Size = New System.Drawing.Size(1252, 165)
        Me.grpOfRadioButtons.TabIndex = 4
        Me.grpOfRadioButtons.TabStop = False
        Me.grpOfRadioButtons.Text = "grpOfRadioButtons"
        '
        'grpOfYesNoRadioButtons
        '
        Me.grpOfYesNoRadioButtons.Location = New System.Drawing.Point(73, 236)
        Me.grpOfYesNoRadioButtons.Name = "grpOfYesNoRadioButtons"
        Me.grpOfYesNoRadioButtons.Size = New System.Drawing.Size(445, 60)
        Me.grpOfYesNoRadioButtons.TabIndex = 5
        Me.grpOfYesNoRadioButtons.TabStop = False
        Me.grpOfYesNoRadioButtons.Text = "grpOfYesNoRadioButtons"
        '
        'grpWithLabelAndYesNoButtons
        '
        Me.grpWithLabelAndYesNoButtons.Controls.Add(Me.lblForYesNoButtons)
        Me.grpWithLabelAndYesNoButtons.Location = New System.Drawing.Point(569, 236)
        Me.grpWithLabelAndYesNoButtons.Name = "grpWithLabelAndYesNoButtons"
        Me.grpWithLabelAndYesNoButtons.Size = New System.Drawing.Size(693, 60)
        Me.grpWithLabelAndYesNoButtons.TabIndex = 6
        Me.grpWithLabelAndYesNoButtons.TabStop = False
        Me.grpWithLabelAndYesNoButtons.Text = "grpWithLabelAndYesNoButtons"
        '
        'lblForYesNoButtons
        '
        Me.lblForYesNoButtons.AutoSize = True
        Me.lblForYesNoButtons.Location = New System.Drawing.Point(257, 23)
        Me.lblForYesNoButtons.Name = "lblForYesNoButtons"
        Me.lblForYesNoButtons.Size = New System.Drawing.Size(100, 13)
        Me.lblForYesNoButtons.TabIndex = 0
        Me.lblForYesNoButtons.Text = "lblForYesNoButtons"
        Me.lblForYesNoButtons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpOfCheckBoxes
        '
        Me.grpOfCheckBoxes.Location = New System.Drawing.Point(73, 335)
        Me.grpOfCheckBoxes.Name = "grpOfCheckBoxes"
        Me.grpOfCheckBoxes.Size = New System.Drawing.Size(1189, 71)
        Me.grpOfCheckBoxes.TabIndex = 7
        Me.grpOfCheckBoxes.TabStop = False
        Me.grpOfCheckBoxes.Text = "grpOfCheckBoxes"
        '
        'grpOfAllParameterControls
        '
        Me.grpOfAllParameterControls.Location = New System.Drawing.Point(73, 433)
        Me.grpOfAllParameterControls.Name = "grpOfAllParameterControls"
        Me.grpOfAllParameterControls.Size = New System.Drawing.Size(1189, 214)
        Me.grpOfAllParameterControls.TabIndex = 8
        Me.grpOfAllParameterControls.TabStop = False
        Me.grpOfAllParameterControls.Text = "grpOfAllParameterControls"
        '
        'txtEnterNumbersOnly
        '
        Me.txtEnterNumbersOnly.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterNumbersOnly.Location = New System.Drawing.Point(73, 676)
        Me.txtEnterNumbersOnly.Name = "txtEnterNumbersOnly"
        Me.txtEnterNumbersOnly.Size = New System.Drawing.Size(201, 29)
        Me.txtEnterNumbersOnly.TabIndex = 9
        '
        'txtDateField
        '
        Me.txtDateField.BeepOnError = True
        Me.txtDateField.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateField.Location = New System.Drawing.Point(304, 682)
        Me.txtDateField.Mask = "00/00/0000"
        Me.txtDateField.Name = "txtDateField"
        Me.txtDateField.Size = New System.Drawing.Size(99, 26)
        Me.txtDateField.TabIndex = 10
        '
        'frmControlsTemplates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 755)
        Me.Controls.Add(Me.txtDateField)
        Me.Controls.Add(Me.txtEnterNumbersOnly)
        Me.Controls.Add(Me.grpOfAllParameterControls)
        Me.Controls.Add(Me.grpOfCheckBoxes)
        Me.Controls.Add(Me.grpWithLabelAndYesNoButtons)
        Me.Controls.Add(Me.grpOfYesNoRadioButtons)
        Me.Controls.Add(Me.grpOfRadioButtons)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmControlsTemplates"
        Me.Text = "frmControlsTemplates"
        Me.grpWithLabelAndYesNoButtons.ResumeLayout(False)
        Me.grpWithLabelAndYesNoButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents grpOfRadioButtons As GroupBox
    Friend WithEvents grpOfYesNoRadioButtons As GroupBox
    Friend WithEvents grpWithLabelAndYesNoButtons As GroupBox
    Friend WithEvents lblForYesNoButtons As Label
    Friend WithEvents grpOfCheckBoxes As GroupBox
    Friend WithEvents grpOfAllParameterControls As GroupBox
    Friend WithEvents txtEnterNumbersOnly As TextBox
    Friend WithEvents txtDateField As MaskedTextBox
End Class
