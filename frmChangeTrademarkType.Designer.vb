<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeTrademarkType
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
        Me.lblCurrentTrademarkType = New System.Windows.Forms.Label()
        Me.txtCurrentTrademarkType = New System.Windows.Forms.TextBox()
        Me.lblNewTrademarkType = New System.Windows.Forms.Label()
        Me.txtNewTrademarkType = New System.Windows.Forms.TextBox()
        Me.grpTrademarkTypeBeingChanged = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(211, 24)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "lblFormTitle"
        '
        'lblCurrentTrademarkType
        '
        Me.lblCurrentTrademarkType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCurrentTrademarkType.AutoSize = True
        Me.lblCurrentTrademarkType.Location = New System.Drawing.Point(217, 71)
        Me.lblCurrentTrademarkType.Name = "lblCurrentTrademarkType"
        Me.lblCurrentTrademarkType.Size = New System.Drawing.Size(126, 13)
        Me.lblCurrentTrademarkType.TabIndex = 1
        Me.lblCurrentTrademarkType.Text = "lblCurrentTrademarkType"
        Me.lblCurrentTrademarkType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCurrentTrademarkType
        '
        Me.txtCurrentTrademarkType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCurrentTrademarkType.Location = New System.Drawing.Point(482, 72)
        Me.txtCurrentTrademarkType.Name = "txtCurrentTrademarkType"
        Me.txtCurrentTrademarkType.Size = New System.Drawing.Size(309, 20)
        Me.txtCurrentTrademarkType.TabIndex = 2
        Me.txtCurrentTrademarkType.Text = "txtCurrentTrademarkType"
        '
        'lblNewTrademarkType
        '
        Me.lblNewTrademarkType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNewTrademarkType.AutoSize = True
        Me.lblNewTrademarkType.Location = New System.Drawing.Point(250, 114)
        Me.lblNewTrademarkType.Name = "lblNewTrademarkType"
        Me.lblNewTrademarkType.Size = New System.Drawing.Size(114, 13)
        Me.lblNewTrademarkType.TabIndex = 3
        Me.lblNewTrademarkType.Text = "lblNewTrademarkType"
        Me.lblNewTrademarkType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewTrademarkType
        '
        Me.txtNewTrademarkType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNewTrademarkType.Location = New System.Drawing.Point(483, 113)
        Me.txtNewTrademarkType.Name = "txtNewTrademarkType"
        Me.txtNewTrademarkType.Size = New System.Drawing.Size(307, 20)
        Me.txtNewTrademarkType.TabIndex = 4
        Me.txtNewTrademarkType.Text = "txtNewTrademarkType"
        '
        'grpTrademarkTypeBeingChanged
        '
        Me.grpTrademarkTypeBeingChanged.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTrademarkTypeBeingChanged.Location = New System.Drawing.Point(12, 156)
        Me.grpTrademarkTypeBeingChanged.Name = "grpTrademarkTypeBeingChanged"
        Me.grpTrademarkTypeBeingChanged.Size = New System.Drawing.Size(962, 155)
        Me.grpTrademarkTypeBeingChanged.TabIndex = 5
        Me.grpTrademarkTypeBeingChanged.TabStop = False
        Me.grpTrademarkTypeBeingChanged.Text = "grpTrademarkTypeBeingChanged"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.82759!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.17241!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDone, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(119, 328)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(753, 38)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnDone
        '
        Me.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDone.Location = New System.Drawing.Point(86, 3)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(144, 32)
        Me.btnDone.TabIndex = 0
        Me.btnDone.Text = "btnDone"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(304, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(144, 32)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(523, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmChangeTrademarkType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 384)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grpTrademarkTypeBeingChanged)
        Me.Controls.Add(Me.txtNewTrademarkType)
        Me.Controls.Add(Me.lblNewTrademarkType)
        Me.Controls.Add(Me.txtCurrentTrademarkType)
        Me.Controls.Add(Me.lblCurrentTrademarkType)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmChangeTrademarkType"
        Me.Text = "frmChangeTrademarkType"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblCurrentTrademarkType As Label
    Friend WithEvents txtCurrentTrademarkType As TextBox
    Friend WithEvents lblNewTrademarkType As Label
    Friend WithEvents txtNewTrademarkType As TextBox
    Friend WithEvents grpTrademarkTypeBeingChanged As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDone As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
End Class
