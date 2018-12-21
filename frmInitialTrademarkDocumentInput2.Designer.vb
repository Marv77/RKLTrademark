<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitialTrademarkDocumentInput2
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
        Me.tlpForForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDocketNumber = New System.Windows.Forms.Panel()
        Me.lblDocketNumber = New System.Windows.Forms.Label()
        Me.txtDocketNumber = New System.Windows.Forms.TextBox()
        Me.btnLookUpDN = New System.Windows.Forms.Button()
        Me.grpClientName = New System.Windows.Forms.GroupBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpSubDocketNumber = New System.Windows.Forms.GroupBox()
        Me.btnDoneSDN = New System.Windows.Forms.Button()
        Me.txtSubDocketNumber = New System.Windows.Forms.TextBox()
        Me.lblSubDocketNumber = New System.Windows.Forms.Label()
        Me.grpInputOfMark = New System.Windows.Forms.GroupBox()
        Me.lblInputOfMarkInstructions = New System.Windows.Forms.Label()
        Me.rtbInputOfMark = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblTab1 = New System.Windows.Forms.Label()
        Me.lblTab2 = New System.Windows.Forms.Label()
        Me.lblTab3 = New System.Windows.Forms.Label()
        Me.tlpForForm.SuspendLayout()
        Me.pnlDocketNumber.SuspendLayout()
        Me.grpClientName.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpSubDocketNumber.SuspendLayout()
        Me.grpInputOfMark.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForForm
        '
        Me.tlpForForm.ColumnCount = 3
        Me.tlpForForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.68317!))
        Me.tlpForForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.31683!))
        Me.tlpForForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 467.0!))
        Me.tlpForForm.Controls.Add(Me.pnlDocketNumber, 0, 0)
        Me.tlpForForm.Controls.Add(Me.grpClientName, 1, 0)
        Me.tlpForForm.Controls.Add(Me.grpSubDocketNumber, 0, 1)
        Me.tlpForForm.Controls.Add(Me.GroupBox1, 0, 4)
        Me.tlpForForm.Controls.Add(Me.grpInputOfMark, 0, 2)
        Me.tlpForForm.Controls.Add(Me.TabControl1, 1, 3)
        Me.tlpForForm.Location = New System.Drawing.Point(12, 12)
        Me.tlpForForm.Name = "tlpForForm"
        Me.tlpForForm.RowCount = 5
        Me.tlpForForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783!))
        Me.tlpForForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217!))
        Me.tlpForForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.tlpForForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tlpForForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpForForm.Size = New System.Drawing.Size(1276, 500)
        Me.tlpForForm.TabIndex = 0
        '
        'pnlDocketNumber
        '
        Me.pnlDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlDocketNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlDocketNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDocketNumber.Controls.Add(Me.lblDocketNumber)
        Me.pnlDocketNumber.Controls.Add(Me.txtDocketNumber)
        Me.pnlDocketNumber.Controls.Add(Me.btnLookUpDN)
        Me.pnlDocketNumber.Location = New System.Drawing.Point(5, 5)
        Me.pnlDocketNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlDocketNumber.Name = "pnlDocketNumber"
        Me.pnlDocketNumber.Size = New System.Drawing.Size(447, 39)
        Me.pnlDocketNumber.TabIndex = 0
        '
        'lblDocketNumber
        '
        Me.lblDocketNumber.AutoSize = True
        Me.lblDocketNumber.Location = New System.Drawing.Point(19, 9)
        Me.lblDocketNumber.Name = "lblDocketNumber"
        Me.lblDocketNumber.Size = New System.Drawing.Size(89, 13)
        Me.lblDocketNumber.TabIndex = 2
        Me.lblDocketNumber.Text = "lblDocketNumber"
        Me.lblDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDocketNumber
        '
        Me.txtDocketNumber.Location = New System.Drawing.Point(200, 6)
        Me.txtDocketNumber.Name = "txtDocketNumber"
        Me.txtDocketNumber.Size = New System.Drawing.Size(110, 20)
        Me.txtDocketNumber.TabIndex = 1
        Me.txtDocketNumber.Text = "txtDocketNumber"
        '
        'btnLookUpDN
        '
        Me.btnLookUpDN.Location = New System.Drawing.Point(316, 6)
        Me.btnLookUpDN.Name = "btnLookUpDN"
        Me.btnLookUpDN.Size = New System.Drawing.Size(124, 24)
        Me.btnLookUpDN.TabIndex = 0
        Me.btnLookUpDN.Text = "btnLookUpDN"
        Me.btnLookUpDN.UseVisualStyleBackColor = True
        '
        'grpClientName
        '
        Me.grpClientName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpForForm.SetColumnSpan(Me.grpClientName, 2)
        Me.grpClientName.Controls.Add(Me.txtClientName)
        Me.grpClientName.Location = New System.Drawing.Point(461, 3)
        Me.grpClientName.Name = "grpClientName"
        Me.grpClientName.Size = New System.Drawing.Size(798, 44)
        Me.grpClientName.TabIndex = 2
        Me.grpClientName.TabStop = False
        Me.grpClientName.Text = "grpClientName"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(10, 12)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(777, 20)
        Me.txtClientName.TabIndex = 0
        Me.txtClientName.Text = "txtClientName"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(3, 430)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.65501!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.34499!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 21)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'grpSubDocketNumber
        '
        Me.grpSubDocketNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSubDocketNumber.Controls.Add(Me.btnDoneSDN)
        Me.grpSubDocketNumber.Controls.Add(Me.txtSubDocketNumber)
        Me.grpSubDocketNumber.Controls.Add(Me.lblSubDocketNumber)
        Me.grpSubDocketNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSubDocketNumber.Location = New System.Drawing.Point(3, 53)
        Me.grpSubDocketNumber.Name = "grpSubDocketNumber"
        Me.grpSubDocketNumber.Size = New System.Drawing.Size(452, 36)
        Me.grpSubDocketNumber.TabIndex = 3
        Me.grpSubDocketNumber.TabStop = False
        Me.grpSubDocketNumber.Text = "grpSubDocketNumber"
        '
        'btnDoneSDN
        '
        Me.btnDoneSDN.Location = New System.Drawing.Point(342, 9)
        Me.btnDoneSDN.Name = "btnDoneSDN"
        Me.btnDoneSDN.Size = New System.Drawing.Size(95, 28)
        Me.btnDoneSDN.TabIndex = 2
        Me.btnDoneSDN.Text = "btnDoneSDN"
        Me.btnDoneSDN.UseVisualStyleBackColor = True
        '
        'txtSubDocketNumber
        '
        Me.txtSubDocketNumber.Location = New System.Drawing.Point(212, 11)
        Me.txtSubDocketNumber.Name = "txtSubDocketNumber"
        Me.txtSubDocketNumber.Size = New System.Drawing.Size(126, 20)
        Me.txtSubDocketNumber.TabIndex = 1
        Me.txtSubDocketNumber.Text = "txtSubDocketNumber"
        '
        'lblSubDocketNumber
        '
        Me.lblSubDocketNumber.AutoSize = True
        Me.lblSubDocketNumber.Location = New System.Drawing.Point(1, 14)
        Me.lblSubDocketNumber.Name = "lblSubDocketNumber"
        Me.lblSubDocketNumber.Size = New System.Drawing.Size(108, 13)
        Me.lblSubDocketNumber.TabIndex = 0
        Me.lblSubDocketNumber.Text = "lblSubDocketNumber"
        '
        'grpInputOfMark
        '
        Me.grpInputOfMark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpForForm.SetColumnSpan(Me.grpInputOfMark, 3)
        Me.grpInputOfMark.Controls.Add(Me.rtbInputOfMark)
        Me.grpInputOfMark.Controls.Add(Me.lblInputOfMarkInstructions)
        Me.grpInputOfMark.Location = New System.Drawing.Point(3, 95)
        Me.grpInputOfMark.Name = "grpInputOfMark"
        Me.grpInputOfMark.Size = New System.Drawing.Size(1270, 202)
        Me.grpInputOfMark.TabIndex = 4
        Me.grpInputOfMark.TabStop = False
        Me.grpInputOfMark.Text = "grpInputOfMark"
        '
        'lblInputOfMarkInstructions
        '
        Me.lblInputOfMarkInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInputOfMarkInstructions.AutoSize = True
        Me.lblInputOfMarkInstructions.Location = New System.Drawing.Point(239, 20)
        Me.lblInputOfMarkInstructions.Name = "lblInputOfMarkInstructions"
        Me.lblInputOfMarkInstructions.Size = New System.Drawing.Size(130, 13)
        Me.lblInputOfMarkInstructions.TabIndex = 0
        Me.lblInputOfMarkInstructions.Text = "lblInputOfMarkInstructions"
        Me.lblInputOfMarkInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbInputOfMark
        '
        Me.rtbInputOfMark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbInputOfMark.Location = New System.Drawing.Point(4, 107)
        Me.rtbInputOfMark.Name = "rtbInputOfMark"
        Me.rtbInputOfMark.Size = New System.Drawing.Size(1262, 85)
        Me.rtbInputOfMark.TabIndex = 1
        Me.rtbInputOfMark.Text = ""
        '
        'TabControl1
        '
        Me.tlpForForm.SetColumnSpan(Me.TabControl1, 2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(461, 303)
        Me.TabControl1.Name = "TabControl1"
        Me.tlpForForm.SetRowSpan(Me.TabControl1, 2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 190)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTab1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 164)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblTab2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(800, 164)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblTab3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(800, 164)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(800, 164)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblTab1
        '
        Me.lblTab1.AutoSize = True
        Me.lblTab1.Location = New System.Drawing.Point(62, 55)
        Me.lblTab1.Name = "lblTab1"
        Me.lblTab1.Size = New System.Drawing.Size(42, 13)
        Me.lblTab1.TabIndex = 0
        Me.lblTab1.Text = "lblTab1"
        '
        'lblTab2
        '
        Me.lblTab2.AutoSize = True
        Me.lblTab2.Location = New System.Drawing.Point(59, 58)
        Me.lblTab2.Name = "lblTab2"
        Me.lblTab2.Size = New System.Drawing.Size(42, 13)
        Me.lblTab2.TabIndex = 0
        Me.lblTab2.Text = "lblTab2"
        '
        'lblTab3
        '
        Me.lblTab3.AutoSize = True
        Me.lblTab3.Location = New System.Drawing.Point(108, 60)
        Me.lblTab3.Name = "lblTab3"
        Me.lblTab3.Size = New System.Drawing.Size(42, 13)
        Me.lblTab3.TabIndex = 0
        Me.lblTab3.Text = "lblTab3"
        '
        'frmInitialTrademarkDocumentInput2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 552)
        Me.Controls.Add(Me.tlpForForm)
        Me.Name = "frmInitialTrademarkDocumentInput2"
        Me.Text = "frmInitialTrademarkDocumentInput2"
        Me.tlpForForm.ResumeLayout(False)
        Me.pnlDocketNumber.ResumeLayout(False)
        Me.pnlDocketNumber.PerformLayout()
        Me.grpClientName.ResumeLayout(False)
        Me.grpClientName.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.grpSubDocketNumber.ResumeLayout(False)
        Me.grpSubDocketNumber.PerformLayout()
        Me.grpInputOfMark.ResumeLayout(False)
        Me.grpInputOfMark.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpForForm As TableLayoutPanel
    Friend WithEvents pnlDocketNumber As Panel
    Friend WithEvents btnLookUpDN As Button
    Friend WithEvents txtDocketNumber As TextBox
    Friend WithEvents lblDocketNumber As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents grpClientName As GroupBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents grpSubDocketNumber As GroupBox
    Friend WithEvents btnDoneSDN As Button
    Friend WithEvents txtSubDocketNumber As TextBox
    Friend WithEvents lblSubDocketNumber As Label
    Friend WithEvents grpInputOfMark As GroupBox
    Friend WithEvents lblInputOfMarkInstructions As Label
    Friend WithEvents rtbInputOfMark As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblTab1 As Label
    Friend WithEvents lblTab2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblTab3 As Label
    Friend WithEvents TabPage4 As TabPage
End Class
