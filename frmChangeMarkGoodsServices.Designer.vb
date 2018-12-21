<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeMarkGoodsServices
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
        Me.grpCurrentMarkGoodsServices = New System.Windows.Forms.GroupBox()
        Me.txtCurrentMarkGoodsServices = New System.Windows.Forms.TextBox()
        Me.grpNewMarkGoodsServices = New System.Windows.Forms.GroupBox()
        Me.rtbNewMarkGoodsServices = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblCharactersRemaining = New System.Windows.Forms.Label()
        Me.grpCurrentMarkGoodsServices.SuspendLayout()
        Me.grpNewMarkGoodsServices.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(358, 25)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "lblFormTitle"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCurrentMarkGoodsServices
        '
        Me.grpCurrentMarkGoodsServices.Controls.Add(Me.txtCurrentMarkGoodsServices)
        Me.grpCurrentMarkGoodsServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCurrentMarkGoodsServices.Location = New System.Drawing.Point(35, 61)
        Me.grpCurrentMarkGoodsServices.Name = "grpCurrentMarkGoodsServices"
        Me.grpCurrentMarkGoodsServices.Size = New System.Drawing.Size(1311, 60)
        Me.grpCurrentMarkGoodsServices.TabIndex = 1
        Me.grpCurrentMarkGoodsServices.TabStop = False
        Me.grpCurrentMarkGoodsServices.Text = "grpCurrentMarkGoodsServices"
        '
        'txtCurrentMarkGoodsServices
        '
        Me.txtCurrentMarkGoodsServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentMarkGoodsServices.Location = New System.Drawing.Point(34, 26)
        Me.txtCurrentMarkGoodsServices.Name = "txtCurrentMarkGoodsServices"
        Me.txtCurrentMarkGoodsServices.Size = New System.Drawing.Size(1240, 31)
        Me.txtCurrentMarkGoodsServices.TabIndex = 0
        Me.txtCurrentMarkGoodsServices.Text = "txtCurrentMarkGoodsServices"
        '
        'grpNewMarkGoodsServices
        '
        Me.grpNewMarkGoodsServices.Controls.Add(Me.rtbNewMarkGoodsServices)
        Me.grpNewMarkGoodsServices.Location = New System.Drawing.Point(35, 140)
        Me.grpNewMarkGoodsServices.Name = "grpNewMarkGoodsServices"
        Me.grpNewMarkGoodsServices.Size = New System.Drawing.Size(1311, 60)
        Me.grpNewMarkGoodsServices.TabIndex = 2
        Me.grpNewMarkGoodsServices.TabStop = False
        Me.grpNewMarkGoodsServices.Text = "grpNewMarkGoodsServices"
        '
        'rtbNewMarkGoodsServices
        '
        Me.rtbNewMarkGoodsServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbNewMarkGoodsServices.Location = New System.Drawing.Point(34, 21)
        Me.rtbNewMarkGoodsServices.Name = "rtbNewMarkGoodsServices"
        Me.rtbNewMarkGoodsServices.Size = New System.Drawing.Size(1240, 33)
        Me.rtbNewMarkGoodsServices.TabIndex = 0
        Me.rtbNewMarkGoodsServices.Text = "rtbNewMarkGoodsServices"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19305!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80695!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDone, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCharactersRemaining, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(165, 218)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1076, 46)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(560, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.Location = New System.Drawing.Point(309, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(130, 37)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDone.Location = New System.Drawing.Point(60, 4)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(130, 37)
        Me.btnDone.TabIndex = 0
        Me.btnDone.Text = "btnDone"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblCharactersRemaining
        '
        Me.lblCharactersRemaining.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCharactersRemaining.AutoEllipsis = True
        Me.lblCharactersRemaining.AutoSize = True
        Me.lblCharactersRemaining.Location = New System.Drawing.Point(754, 16)
        Me.lblCharactersRemaining.Name = "lblCharactersRemaining"
        Me.lblCharactersRemaining.Size = New System.Drawing.Size(319, 13)
        Me.lblCharactersRemaining.TabIndex = 3
        Me.lblCharactersRemaining.Text = "lblCharactersRemaining"
        Me.lblCharactersRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmChangeMarkGoodsServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 292)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grpNewMarkGoodsServices)
        Me.Controls.Add(Me.grpCurrentMarkGoodsServices)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmChangeMarkGoodsServices"
        Me.Text = "frmChangeMarkGoodsServices"
        Me.grpCurrentMarkGoodsServices.ResumeLayout(False)
        Me.grpCurrentMarkGoodsServices.PerformLayout()
        Me.grpNewMarkGoodsServices.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents grpCurrentMarkGoodsServices As GroupBox
    Friend WithEvents txtCurrentMarkGoodsServices As TextBox
    Friend WithEvents grpNewMarkGoodsServices As GroupBox
    Friend WithEvents rtbNewMarkGoodsServices As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lblCharactersRemaining As Label
End Class
