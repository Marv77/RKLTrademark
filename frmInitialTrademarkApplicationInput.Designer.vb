<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInitialTrademarkApplicationInput
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
        Me.tlpInitialTrademarkInput = New System.Windows.Forms.TableLayoutPanel()
        Me.grpInputOfGoodsAndOrServices = New System.Windows.Forms.GroupBox()
        Me.lblGoodsCharactersRemaining = New System.Windows.Forms.Label()
        Me.btnClearInputOfGoodAndOrServices = New System.Windows.Forms.Button()
        Me.btnDoneInputOfGoodAndOrServices = New System.Windows.Forms.Button()
        Me.rtbInputOfGoodsAndOrServices = New System.Windows.Forms.RichTextBox()
        Me.lblInputOfGoodsAndOrServices = New System.Windows.Forms.Label()
        Me.grpInputOfMark = New System.Windows.Forms.GroupBox()
        Me.btnClearInputOfMark = New System.Windows.Forms.Button()
        Me.btnDoneInputOfMark = New System.Windows.Forms.Button()
        Me.lblMarkCharactersRemaining = New System.Windows.Forms.Label()
        Me.rtbInputOfMark = New System.Windows.Forms.RichTextBox()
        Me.lblInputOfMarkInstructions = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpDocketNumberSubDocketNumber = New System.Windows.Forms.GroupBox()
        Me.grpCountryCode = New System.Windows.Forms.GroupBox()
        Me.btnCountryCode = New System.Windows.Forms.Button()
        Me.txtCountryCode = New System.Windows.Forms.TextBox()
        Me.lblCountryCode = New System.Windows.Forms.Label()
        Me.grpTrademarkOwnersEntityStatus = New System.Windows.Forms.GroupBox()
        Me.grpForeignClientReferenceNumber = New System.Windows.Forms.GroupBox()
        Me.btnForeignClientReferenceNumber = New System.Windows.Forms.Button()
        Me.txtForeignClientReferenceNumber = New System.Windows.Forms.TextBox()
        Me.lblForeignClientReferenceNumber = New System.Windows.Forms.Label()
        Me.grpSelectResponsibleAttorney = New System.Windows.Forms.GroupBox()
        Me.lstSelectResponsibleAttorney = New System.Windows.Forms.ListBox()
        Me.grpClientDocketNumber = New System.Windows.Forms.GroupBox()
        Me.btnClientDocketNumber = New System.Windows.Forms.Button()
        Me.txtClientDocketNumber = New System.Windows.Forms.TextBox()
        Me.lblClientDocketNumber = New System.Windows.Forms.Label()
        Me.grpSubDocketNumber = New System.Windows.Forms.GroupBox()
        Me.btnLookUpSDN = New System.Windows.Forms.Button()
        Me.txtSubDocketNumber = New System.Windows.Forms.TextBox()
        Me.lblSubDocketNumber = New System.Windows.Forms.Label()
        Me.grpClientName = New System.Windows.Forms.GroupBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.grpDocketNumber = New System.Windows.Forms.GroupBox()
        Me.btnLookUpDN = New System.Windows.Forms.Button()
        Me.txtDocketNumber = New System.Windows.Forms.TextBox()
        Me.lblDocketNumber = New System.Windows.Forms.Label()
        Me.grpCategoryOfTrademarkType = New System.Windows.Forms.GroupBox()
        Me.grpFirstUseDateInCommerce = New System.Windows.Forms.GroupBox()
        Me.btnFirstUseDateInCommerce = New System.Windows.Forms.Button()
        Me.txtFirstUseDateInCommerce = New System.Windows.Forms.MaskedTextBox()
        Me.lblFirstUseDateInCommerce = New System.Windows.Forms.Label()
        Me.grpWIPOFilingDate = New System.Windows.Forms.GroupBox()
        Me.txtWIPOFilingDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblWIPOFilingDate = New System.Windows.Forms.Label()
        Me.grpMadridProtocolSerialNumber = New System.Windows.Forms.GroupBox()
        Me.btnMadridProtocolSerialNumber = New System.Windows.Forms.Button()
        Me.txtMadridProtocolSerialNumber = New System.Windows.Forms.TextBox()
        Me.lblMadridProtocolSerialNumber = New System.Windows.Forms.Label()
        Me.grpFirstUseDate = New System.Windows.Forms.GroupBox()
        Me.btnFirstUseDate = New System.Windows.Forms.Button()
        Me.txtFirstUseDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblFirstUseDate = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.tlpInitialTrademarkInput.SuspendLayout()
        Me.grpInputOfGoodsAndOrServices.SuspendLayout()
        Me.grpInputOfMark.SuspendLayout()
        Me.grpDocketNumberSubDocketNumber.SuspendLayout()
        Me.grpCountryCode.SuspendLayout()
        Me.grpForeignClientReferenceNumber.SuspendLayout()
        Me.grpSelectResponsibleAttorney.SuspendLayout()
        Me.grpClientDocketNumber.SuspendLayout()
        Me.grpSubDocketNumber.SuspendLayout()
        Me.grpClientName.SuspendLayout()
        Me.grpDocketNumber.SuspendLayout()
        Me.grpCategoryOfTrademarkType.SuspendLayout()
        Me.grpFirstUseDateInCommerce.SuspendLayout()
        Me.grpWIPOFilingDate.SuspendLayout()
        Me.grpMadridProtocolSerialNumber.SuspendLayout()
        Me.grpFirstUseDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpInitialTrademarkInput
        '
        Me.tlpInitialTrademarkInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tlpInitialTrademarkInput.ColumnCount = 3
        Me.tlpInitialTrademarkInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.72414!))
        Me.tlpInitialTrademarkInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.27586!))
        Me.tlpInitialTrademarkInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 490.0!))
        Me.tlpInitialTrademarkInput.Controls.Add(Me.grpInputOfGoodsAndOrServices, 0, 3)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.grpInputOfMark, 0, 2)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.btnDone, 0, 5)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.btnReset, 1, 5)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.TableLayoutPanel1, 0, 4)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.btnCancel, 2, 5)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.grpDocketNumberSubDocketNumber, 0, 1)
        Me.tlpInitialTrademarkInput.Controls.Add(Me.grpCategoryOfTrademarkType, 0, 0)
        Me.tlpInitialTrademarkInput.Location = New System.Drawing.Point(3, 49)
        Me.tlpInitialTrademarkInput.Name = "tlpInitialTrademarkInput"
        Me.tlpInitialTrademarkInput.RowCount = 5
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpInitialTrademarkInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpInitialTrademarkInput.Size = New System.Drawing.Size(1393, 704)
        Me.tlpInitialTrademarkInput.TabIndex = 0
        '
        'grpInputOfGoodsAndOrServices
        '
        Me.tlpInitialTrademarkInput.SetColumnSpan(Me.grpInputOfGoodsAndOrServices, 3)
        Me.grpInputOfGoodsAndOrServices.Controls.Add(Me.lblGoodsCharactersRemaining)
        Me.grpInputOfGoodsAndOrServices.Controls.Add(Me.btnClearInputOfGoodAndOrServices)
        Me.grpInputOfGoodsAndOrServices.Controls.Add(Me.btnDoneInputOfGoodAndOrServices)
        Me.grpInputOfGoodsAndOrServices.Controls.Add(Me.rtbInputOfGoodsAndOrServices)
        Me.grpInputOfGoodsAndOrServices.Controls.Add(Me.lblInputOfGoodsAndOrServices)
        Me.grpInputOfGoodsAndOrServices.Location = New System.Drawing.Point(3, 457)
        Me.grpInputOfGoodsAndOrServices.Name = "grpInputOfGoodsAndOrServices"
        Me.grpInputOfGoodsAndOrServices.Size = New System.Drawing.Size(1302, 134)
        Me.grpInputOfGoodsAndOrServices.TabIndex = 14
        Me.grpInputOfGoodsAndOrServices.TabStop = False
        Me.grpInputOfGoodsAndOrServices.Text = "grpInputOfGoodsAndOrServices"
        '
        'lblGoodsCharactersRemaining
        '
        Me.lblGoodsCharactersRemaining.AutoSize = True
        Me.lblGoodsCharactersRemaining.Location = New System.Drawing.Point(877, 101)
        Me.lblGoodsCharactersRemaining.Name = "lblGoodsCharactersRemaining"
        Me.lblGoodsCharactersRemaining.Size = New System.Drawing.Size(149, 13)
        Me.lblGoodsCharactersRemaining.TabIndex = 8
        Me.lblGoodsCharactersRemaining.Text = "lblGoodsCharactersRemaining"
        '
        'btnClearInputOfGoodAndOrServices
        '
        Me.btnClearInputOfGoodAndOrServices.Location = New System.Drawing.Point(529, 91)
        Me.btnClearInputOfGoodAndOrServices.Name = "btnClearInputOfGoodAndOrServices"
        Me.btnClearInputOfGoodAndOrServices.Size = New System.Drawing.Size(317, 34)
        Me.btnClearInputOfGoodAndOrServices.TabIndex = 7
        Me.btnClearInputOfGoodAndOrServices.Text = "btnClearInputOfGoodAndOrServices"
        Me.btnClearInputOfGoodAndOrServices.UseVisualStyleBackColor = True
        '
        'btnDoneInputOfGoodAndOrServices
        '
        Me.btnDoneInputOfGoodAndOrServices.Location = New System.Drawing.Point(197, 91)
        Me.btnDoneInputOfGoodAndOrServices.Name = "btnDoneInputOfGoodAndOrServices"
        Me.btnDoneInputOfGoodAndOrServices.Size = New System.Drawing.Size(317, 34)
        Me.btnDoneInputOfGoodAndOrServices.TabIndex = 6
        Me.btnDoneInputOfGoodAndOrServices.Text = "btnDoneInputOfGoodAndOrServices"
        Me.btnDoneInputOfGoodAndOrServices.UseVisualStyleBackColor = True
        '
        'rtbInputOfGoodsAndOrServices
        '
        Me.rtbInputOfGoodsAndOrServices.Location = New System.Drawing.Point(6, 55)
        Me.rtbInputOfGoodsAndOrServices.Name = "rtbInputOfGoodsAndOrServices"
        Me.rtbInputOfGoodsAndOrServices.Size = New System.Drawing.Size(1240, 27)
        Me.rtbInputOfGoodsAndOrServices.TabIndex = 5
        Me.rtbInputOfGoodsAndOrServices.Text = "rtbInputOfGoodsAndOrServices"
        '
        'lblInputOfGoodsAndOrServices
        '
        Me.lblInputOfGoodsAndOrServices.AutoSize = True
        Me.lblInputOfGoodsAndOrServices.Location = New System.Drawing.Point(333, 23)
        Me.lblInputOfGoodsAndOrServices.Name = "lblInputOfGoodsAndOrServices"
        Me.lblInputOfGoodsAndOrServices.Size = New System.Drawing.Size(154, 13)
        Me.lblInputOfGoodsAndOrServices.TabIndex = 4
        Me.lblInputOfGoodsAndOrServices.Text = "lblInputOfGoodsAndOrServices"
        '
        'grpInputOfMark
        '
        Me.tlpInitialTrademarkInput.SetColumnSpan(Me.grpInputOfMark, 3)
        Me.grpInputOfMark.Controls.Add(Me.btnClearInputOfMark)
        Me.grpInputOfMark.Controls.Add(Me.btnDoneInputOfMark)
        Me.grpInputOfMark.Controls.Add(Me.lblMarkCharactersRemaining)
        Me.grpInputOfMark.Controls.Add(Me.rtbInputOfMark)
        Me.grpInputOfMark.Controls.Add(Me.lblInputOfMarkInstructions)
        Me.grpInputOfMark.Location = New System.Drawing.Point(3, 311)
        Me.grpInputOfMark.Name = "grpInputOfMark"
        Me.grpInputOfMark.Size = New System.Drawing.Size(1302, 139)
        Me.grpInputOfMark.TabIndex = 13
        Me.grpInputOfMark.TabStop = False
        Me.grpInputOfMark.Text = "grpInputOfMark"
        '
        'btnClearInputOfMark
        '
        Me.btnClearInputOfMark.Location = New System.Drawing.Point(544, 80)
        Me.btnClearInputOfMark.Name = "btnClearInputOfMark"
        Me.btnClearInputOfMark.Size = New System.Drawing.Size(262, 33)
        Me.btnClearInputOfMark.TabIndex = 4
        Me.btnClearInputOfMark.Text = "btnClearInputOfMark"
        Me.btnClearInputOfMark.UseVisualStyleBackColor = True
        '
        'btnDoneInputOfMark
        '
        Me.btnDoneInputOfMark.Location = New System.Drawing.Point(248, 80)
        Me.btnDoneInputOfMark.Name = "btnDoneInputOfMark"
        Me.btnDoneInputOfMark.Size = New System.Drawing.Size(252, 34)
        Me.btnDoneInputOfMark.TabIndex = 3
        Me.btnDoneInputOfMark.Text = "btnDoneInputOfMark"
        Me.btnDoneInputOfMark.UseVisualStyleBackColor = True
        '
        'lblMarkCharactersRemaining
        '
        Me.lblMarkCharactersRemaining.AutoSize = True
        Me.lblMarkCharactersRemaining.Location = New System.Drawing.Point(843, 89)
        Me.lblMarkCharactersRemaining.Name = "lblMarkCharactersRemaining"
        Me.lblMarkCharactersRemaining.Size = New System.Drawing.Size(142, 13)
        Me.lblMarkCharactersRemaining.TabIndex = 2
        Me.lblMarkCharactersRemaining.Text = "lblMarkCharactersRemaining"
        '
        'rtbInputOfMark
        '
        Me.rtbInputOfMark.Location = New System.Drawing.Point(6, 48)
        Me.rtbInputOfMark.Name = "rtbInputOfMark"
        Me.rtbInputOfMark.Size = New System.Drawing.Size(1240, 27)
        Me.rtbInputOfMark.TabIndex = 1
        Me.rtbInputOfMark.Text = "rtbInputOfMark"
        '
        'lblInputOfMarkInstructions
        '
        Me.lblInputOfMarkInstructions.AutoSize = True
        Me.lblInputOfMarkInstructions.Location = New System.Drawing.Point(521, 21)
        Me.lblInputOfMarkInstructions.Name = "lblInputOfMarkInstructions"
        Me.lblInputOfMarkInstructions.Size = New System.Drawing.Size(130, 13)
        Me.lblInputOfMarkInstructions.TabIndex = 0
        Me.lblInputOfMarkInstructions.Text = "lblInputOfMarkInstructions"
        Me.lblInputOfMarkInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDone
        '
        Me.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDone.Location = New System.Drawing.Point(157, 666)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(270, 32)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "btnDone"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReset.Location = New System.Drawing.Point(531, 666)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(270, 32)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.tlpInitialTrademarkInput.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 733.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 599)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1387, 56)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.Location = New System.Drawing.Point(905, 666)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(270, 32)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpDocketNumberSubDocketNumber
        '
        Me.tlpInitialTrademarkInput.SetColumnSpan(Me.grpDocketNumberSubDocketNumber, 3)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpCountryCode)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpTrademarkOwnersEntityStatus)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpForeignClientReferenceNumber)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpSelectResponsibleAttorney)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpClientDocketNumber)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpSubDocketNumber)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpClientName)
        Me.grpDocketNumberSubDocketNumber.Controls.Add(Me.grpDocketNumber)
        Me.grpDocketNumberSubDocketNumber.Location = New System.Drawing.Point(3, 133)
        Me.grpDocketNumberSubDocketNumber.Name = "grpDocketNumberSubDocketNumber"
        Me.grpDocketNumberSubDocketNumber.Size = New System.Drawing.Size(1387, 172)
        Me.grpDocketNumberSubDocketNumber.TabIndex = 11
        Me.grpDocketNumberSubDocketNumber.TabStop = False
        Me.grpDocketNumberSubDocketNumber.Text = "grpDocketNumberSubDocketNumber"
        '
        'grpCountryCode
        '
        Me.grpCountryCode.Controls.Add(Me.btnCountryCode)
        Me.grpCountryCode.Controls.Add(Me.txtCountryCode)
        Me.grpCountryCode.Controls.Add(Me.lblCountryCode)
        Me.grpCountryCode.Location = New System.Drawing.Point(9, 69)
        Me.grpCountryCode.Name = "grpCountryCode"
        Me.grpCountryCode.Size = New System.Drawing.Size(484, 44)
        Me.grpCountryCode.TabIndex = 7
        Me.grpCountryCode.TabStop = False
        Me.grpCountryCode.Text = "grpCountryCode"
        '
        'btnCountryCode
        '
        Me.btnCountryCode.Location = New System.Drawing.Point(404, 13)
        Me.btnCountryCode.Name = "btnCountryCode"
        Me.btnCountryCode.Size = New System.Drawing.Size(67, 25)
        Me.btnCountryCode.TabIndex = 2
        Me.btnCountryCode.Text = "btnCountryCode"
        Me.btnCountryCode.UseVisualStyleBackColor = True
        '
        'txtCountryCode
        '
        Me.txtCountryCode.Location = New System.Drawing.Point(350, 14)
        Me.txtCountryCode.Name = "txtCountryCode"
        Me.txtCountryCode.Size = New System.Drawing.Size(47, 20)
        Me.txtCountryCode.TabIndex = 1
        '
        'lblCountryCode
        '
        Me.lblCountryCode.AutoSize = True
        Me.lblCountryCode.Location = New System.Drawing.Point(8, 17)
        Me.lblCountryCode.Name = "lblCountryCode"
        Me.lblCountryCode.Size = New System.Drawing.Size(78, 13)
        Me.lblCountryCode.TabIndex = 0
        Me.lblCountryCode.Text = "lblCountryCode"
        Me.lblCountryCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpTrademarkOwnersEntityStatus
        '
        Me.grpTrademarkOwnersEntityStatus.Location = New System.Drawing.Point(504, 70)
        Me.grpTrademarkOwnersEntityStatus.Name = "grpTrademarkOwnersEntityStatus"
        Me.grpTrademarkOwnersEntityStatus.Size = New System.Drawing.Size(625, 44)
        Me.grpTrademarkOwnersEntityStatus.TabIndex = 6
        Me.grpTrademarkOwnersEntityStatus.TabStop = False
        Me.grpTrademarkOwnersEntityStatus.Text = "grpTrademarkOwnersEntityStatus"
        '
        'grpForeignClientReferenceNumber
        '
        Me.grpForeignClientReferenceNumber.Controls.Add(Me.btnForeignClientReferenceNumber)
        Me.grpForeignClientReferenceNumber.Controls.Add(Me.txtForeignClientReferenceNumber)
        Me.grpForeignClientReferenceNumber.Controls.Add(Me.lblForeignClientReferenceNumber)
        Me.grpForeignClientReferenceNumber.Location = New System.Drawing.Point(642, 118)
        Me.grpForeignClientReferenceNumber.Name = "grpForeignClientReferenceNumber"
        Me.grpForeignClientReferenceNumber.Size = New System.Drawing.Size(744, 50)
        Me.grpForeignClientReferenceNumber.TabIndex = 5
        Me.grpForeignClientReferenceNumber.TabStop = False
        Me.grpForeignClientReferenceNumber.Text = "grpForeignClientReferenceNumber"
        '
        'btnForeignClientReferenceNumber
        '
        Me.btnForeignClientReferenceNumber.Location = New System.Drawing.Point(641, 15)
        Me.btnForeignClientReferenceNumber.Name = "btnForeignClientReferenceNumber"
        Me.btnForeignClientReferenceNumber.Size = New System.Drawing.Size(93, 24)
        Me.btnForeignClientReferenceNumber.TabIndex = 2
        Me.btnForeignClientReferenceNumber.Text = "btnForeignClientReferenceNumber"
        Me.btnForeignClientReferenceNumber.UseVisualStyleBackColor = True
        '
        'txtForeignClientReferenceNumber
        '
        Me.txtForeignClientReferenceNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForeignClientReferenceNumber.Location = New System.Drawing.Point(314, 14)
        Me.txtForeignClientReferenceNumber.Name = "txtForeignClientReferenceNumber"
        Me.txtForeignClientReferenceNumber.Size = New System.Drawing.Size(319, 26)
        Me.txtForeignClientReferenceNumber.TabIndex = 1
        Me.txtForeignClientReferenceNumber.Text = "txtForeignClientReferenceNumber"
        '
        'lblForeignClientReferenceNumber
        '
        Me.lblForeignClientReferenceNumber.AutoSize = True
        Me.lblForeignClientReferenceNumber.Location = New System.Drawing.Point(5, 22)
        Me.lblForeignClientReferenceNumber.Name = "lblForeignClientReferenceNumber"
        Me.lblForeignClientReferenceNumber.Size = New System.Drawing.Size(165, 13)
        Me.lblForeignClientReferenceNumber.TabIndex = 0
        Me.lblForeignClientReferenceNumber.Text = "lblForeignClientReferenceNumber"
        Me.lblForeignClientReferenceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpSelectResponsibleAttorney
        '
        Me.grpSelectResponsibleAttorney.Controls.Add(Me.lstSelectResponsibleAttorney)
        Me.grpSelectResponsibleAttorney.Location = New System.Drawing.Point(1138, 72)
        Me.grpSelectResponsibleAttorney.Name = "grpSelectResponsibleAttorney"
        Me.grpSelectResponsibleAttorney.Size = New System.Drawing.Size(241, 44)
        Me.grpSelectResponsibleAttorney.TabIndex = 4
        Me.grpSelectResponsibleAttorney.TabStop = False
        Me.grpSelectResponsibleAttorney.Text = "grpSelectResponsibleAttorney"
        '
        'lstSelectResponsibleAttorney
        '
        Me.lstSelectResponsibleAttorney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectResponsibleAttorney.FormattingEnabled = True
        Me.lstSelectResponsibleAttorney.ItemHeight = 20
        Me.lstSelectResponsibleAttorney.Location = New System.Drawing.Point(51, 19)
        Me.lstSelectResponsibleAttorney.Name = "lstSelectResponsibleAttorney"
        Me.lstSelectResponsibleAttorney.ScrollAlwaysVisible = True
        Me.lstSelectResponsibleAttorney.Size = New System.Drawing.Size(141, 24)
        Me.lstSelectResponsibleAttorney.TabIndex = 0
        '
        'grpClientDocketNumber
        '
        Me.grpClientDocketNumber.Controls.Add(Me.btnClientDocketNumber)
        Me.grpClientDocketNumber.Controls.Add(Me.txtClientDocketNumber)
        Me.grpClientDocketNumber.Controls.Add(Me.lblClientDocketNumber)
        Me.grpClientDocketNumber.Location = New System.Drawing.Point(7, 118)
        Me.grpClientDocketNumber.Name = "grpClientDocketNumber"
        Me.grpClientDocketNumber.Size = New System.Drawing.Size(629, 50)
        Me.grpClientDocketNumber.TabIndex = 3
        Me.grpClientDocketNumber.TabStop = False
        Me.grpClientDocketNumber.Text = "grpClientDocketNumber"
        '
        'btnClientDocketNumber
        '
        Me.btnClientDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClientDocketNumber.Location = New System.Drawing.Point(524, 15)
        Me.btnClientDocketNumber.Name = "btnClientDocketNumber"
        Me.btnClientDocketNumber.Size = New System.Drawing.Size(97, 25)
        Me.btnClientDocketNumber.TabIndex = 2
        Me.btnClientDocketNumber.Text = "btnClientDocketNumber"
        Me.btnClientDocketNumber.UseVisualStyleBackColor = True
        '
        'txtClientDocketNumber
        '
        Me.txtClientDocketNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtClientDocketNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientDocketNumber.Location = New System.Drawing.Point(233, 16)
        Me.txtClientDocketNumber.Name = "txtClientDocketNumber"
        Me.txtClientDocketNumber.Size = New System.Drawing.Size(285, 26)
        Me.txtClientDocketNumber.TabIndex = 1
        Me.txtClientDocketNumber.Text = "txtClientDocketNumber"
        '
        'lblClientDocketNumber
        '
        Me.lblClientDocketNumber.AutoSize = True
        Me.lblClientDocketNumber.Location = New System.Drawing.Point(10, 18)
        Me.lblClientDocketNumber.Name = "lblClientDocketNumber"
        Me.lblClientDocketNumber.Size = New System.Drawing.Size(115, 13)
        Me.lblClientDocketNumber.TabIndex = 0
        Me.lblClientDocketNumber.Text = "lblClientDocketNumber"
        Me.lblClientDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpSubDocketNumber
        '
        Me.grpSubDocketNumber.BackColor = System.Drawing.SystemColors.Control
        Me.grpSubDocketNumber.Controls.Add(Me.btnLookUpSDN)
        Me.grpSubDocketNumber.Controls.Add(Me.txtSubDocketNumber)
        Me.grpSubDocketNumber.Controls.Add(Me.lblSubDocketNumber)
        Me.grpSubDocketNumber.Location = New System.Drawing.Point(921, 18)
        Me.grpSubDocketNumber.Name = "grpSubDocketNumber"
        Me.grpSubDocketNumber.Size = New System.Drawing.Size(466, 48)
        Me.grpSubDocketNumber.TabIndex = 2
        Me.grpSubDocketNumber.TabStop = False
        Me.grpSubDocketNumber.Text = "grpSubDocketNumber"
        '
        'btnLookUpSDN
        '
        Me.btnLookUpSDN.Location = New System.Drawing.Point(343, 14)
        Me.btnLookUpSDN.Name = "btnLookUpSDN"
        Me.btnLookUpSDN.Size = New System.Drawing.Size(119, 28)
        Me.btnLookUpSDN.TabIndex = 2
        Me.btnLookUpSDN.Text = "btnLookUpSDN"
        Me.btnLookUpSDN.UseVisualStyleBackColor = True
        '
        'txtSubDocketNumber
        '
        Me.txtSubDocketNumber.Location = New System.Drawing.Point(217, 17)
        Me.txtSubDocketNumber.Name = "txtSubDocketNumber"
        Me.txtSubDocketNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtSubDocketNumber.TabIndex = 1
        Me.txtSubDocketNumber.Text = "txtSubDocketNumber"
        '
        'lblSubDocketNumber
        '
        Me.lblSubDocketNumber.AutoSize = True
        Me.lblSubDocketNumber.Location = New System.Drawing.Point(6, 21)
        Me.lblSubDocketNumber.Name = "lblSubDocketNumber"
        Me.lblSubDocketNumber.Size = New System.Drawing.Size(108, 13)
        Me.lblSubDocketNumber.TabIndex = 0
        Me.lblSubDocketNumber.Text = "lblSubDocketNumber"
        '
        'grpClientName
        '
        Me.grpClientName.Controls.Add(Me.txtClientName)
        Me.grpClientName.Location = New System.Drawing.Point(423, 18)
        Me.grpClientName.Name = "grpClientName"
        Me.grpClientName.Size = New System.Drawing.Size(494, 48)
        Me.grpClientName.TabIndex = 1
        Me.grpClientName.TabStop = False
        Me.grpClientName.Text = "grpClientName"
        '
        'txtClientName
        '
        Me.txtClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.Location = New System.Drawing.Point(6, 19)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(483, 26)
        Me.txtClientName.TabIndex = 0
        Me.txtClientName.Text = "txtClientName"
        '
        'grpDocketNumber
        '
        Me.grpDocketNumber.Controls.Add(Me.btnLookUpDN)
        Me.grpDocketNumber.Controls.Add(Me.txtDocketNumber)
        Me.grpDocketNumber.Controls.Add(Me.lblDocketNumber)
        Me.grpDocketNumber.Location = New System.Drawing.Point(7, 18)
        Me.grpDocketNumber.Name = "grpDocketNumber"
        Me.grpDocketNumber.Size = New System.Drawing.Size(411, 48)
        Me.grpDocketNumber.TabIndex = 0
        Me.grpDocketNumber.TabStop = False
        Me.grpDocketNumber.Text = "grpDocketNumber"
        '
        'btnLookUpDN
        '
        Me.btnLookUpDN.Location = New System.Drawing.Point(279, 15)
        Me.btnLookUpDN.Name = "btnLookUpDN"
        Me.btnLookUpDN.Size = New System.Drawing.Size(125, 26)
        Me.btnLookUpDN.TabIndex = 2
        Me.btnLookUpDN.Text = "btnLookUpDN"
        Me.btnLookUpDN.UseVisualStyleBackColor = True
        '
        'txtDocketNumber
        '
        Me.txtDocketNumber.Location = New System.Drawing.Point(184, 17)
        Me.txtDocketNumber.Name = "txtDocketNumber"
        Me.txtDocketNumber.Size = New System.Drawing.Size(90, 20)
        Me.txtDocketNumber.TabIndex = 1
        Me.txtDocketNumber.Text = "txtDocketNumber"
        '
        'lblDocketNumber
        '
        Me.lblDocketNumber.AutoSize = True
        Me.lblDocketNumber.Location = New System.Drawing.Point(10, 21)
        Me.lblDocketNumber.Name = "lblDocketNumber"
        Me.lblDocketNumber.Size = New System.Drawing.Size(89, 13)
        Me.lblDocketNumber.TabIndex = 0
        Me.lblDocketNumber.Text = "lblDocketNumber"
        Me.lblDocketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpCategoryOfTrademarkType
        '
        Me.tlpInitialTrademarkInput.SetColumnSpan(Me.grpCategoryOfTrademarkType, 3)
        Me.grpCategoryOfTrademarkType.Controls.Add(Me.grpFirstUseDateInCommerce)
        Me.grpCategoryOfTrademarkType.Controls.Add(Me.grpWIPOFilingDate)
        Me.grpCategoryOfTrademarkType.Controls.Add(Me.grpMadridProtocolSerialNumber)
        Me.grpCategoryOfTrademarkType.Controls.Add(Me.grpFirstUseDate)
        Me.grpCategoryOfTrademarkType.Location = New System.Drawing.Point(3, 3)
        Me.grpCategoryOfTrademarkType.Name = "grpCategoryOfTrademarkType"
        Me.grpCategoryOfTrademarkType.Size = New System.Drawing.Size(1387, 124)
        Me.grpCategoryOfTrademarkType.TabIndex = 16
        Me.grpCategoryOfTrademarkType.TabStop = False
        Me.grpCategoryOfTrademarkType.Text = "grpCategoryOfTrademarkType"
        '
        'grpFirstUseDateInCommerce
        '
        Me.grpFirstUseDateInCommerce.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.grpFirstUseDateInCommerce.Controls.Add(Me.btnFirstUseDateInCommerce)
        Me.grpFirstUseDateInCommerce.Controls.Add(Me.txtFirstUseDateInCommerce)
        Me.grpFirstUseDateInCommerce.Controls.Add(Me.lblFirstUseDateInCommerce)
        Me.grpFirstUseDateInCommerce.Location = New System.Drawing.Point(775, 65)
        Me.grpFirstUseDateInCommerce.Name = "grpFirstUseDateInCommerce"
        Me.grpFirstUseDateInCommerce.Size = New System.Drawing.Size(489, 53)
        Me.grpFirstUseDateInCommerce.TabIndex = 5
        Me.grpFirstUseDateInCommerce.TabStop = False
        Me.grpFirstUseDateInCommerce.Text = "grpFirstUseDateInCommerce"
        '
        'btnFirstUseDateInCommerce
        '
        Me.btnFirstUseDateInCommerce.Location = New System.Drawing.Point(404, 17)
        Me.btnFirstUseDateInCommerce.Name = "btnFirstUseDateInCommerce"
        Me.btnFirstUseDateInCommerce.Size = New System.Drawing.Size(74, 25)
        Me.btnFirstUseDateInCommerce.TabIndex = 12
        Me.btnFirstUseDateInCommerce.Text = "btnFirstUseDateInCommerce"
        Me.btnFirstUseDateInCommerce.UseVisualStyleBackColor = True
        '
        'txtFirstUseDateInCommerce
        '
        Me.txtFirstUseDateInCommerce.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtFirstUseDateInCommerce.BeepOnError = True
        Me.txtFirstUseDateInCommerce.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstUseDateInCommerce.Location = New System.Drawing.Point(301, 17)
        Me.txtFirstUseDateInCommerce.Mask = "00/00/0000"
        Me.txtFirstUseDateInCommerce.Name = "txtFirstUseDateInCommerce"
        Me.txtFirstUseDateInCommerce.Size = New System.Drawing.Size(99, 26)
        Me.txtFirstUseDateInCommerce.TabIndex = 11
        Me.txtFirstUseDateInCommerce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstUseDateInCommerce
        '
        Me.lblFirstUseDateInCommerce.AutoSize = True
        Me.lblFirstUseDateInCommerce.Location = New System.Drawing.Point(24, 21)
        Me.lblFirstUseDateInCommerce.Name = "lblFirstUseDateInCommerce"
        Me.lblFirstUseDateInCommerce.Size = New System.Drawing.Size(137, 13)
        Me.lblFirstUseDateInCommerce.TabIndex = 0
        Me.lblFirstUseDateInCommerce.Text = "lblFirstUseDateInCommerce"
        Me.lblFirstUseDateInCommerce.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpWIPOFilingDate
        '
        Me.grpWIPOFilingDate.Controls.Add(Me.txtWIPOFilingDate)
        Me.grpWIPOFilingDate.Controls.Add(Me.lblWIPOFilingDate)
        Me.grpWIPOFilingDate.Location = New System.Drawing.Point(772, 12)
        Me.grpWIPOFilingDate.Name = "grpWIPOFilingDate"
        Me.grpWIPOFilingDate.Size = New System.Drawing.Size(521, 53)
        Me.grpWIPOFilingDate.TabIndex = 2
        Me.grpWIPOFilingDate.TabStop = False
        Me.grpWIPOFilingDate.Text = "grpWIPOFilingDate"
        '
        'txtWIPOFilingDate
        '
        Me.txtWIPOFilingDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtWIPOFilingDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtWIPOFilingDate.BeepOnError = True
        Me.txtWIPOFilingDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWIPOFilingDate.Location = New System.Drawing.Point(293, 18)
        Me.txtWIPOFilingDate.Mask = "00/00/0000"
        Me.txtWIPOFilingDate.Name = "txtWIPOFilingDate"
        Me.txtWIPOFilingDate.Size = New System.Drawing.Size(99, 26)
        Me.txtWIPOFilingDate.TabIndex = 14
        Me.txtWIPOFilingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWIPOFilingDate
        '
        Me.lblWIPOFilingDate.AutoSize = True
        Me.lblWIPOFilingDate.Location = New System.Drawing.Point(109, 24)
        Me.lblWIPOFilingDate.Name = "lblWIPOFilingDate"
        Me.lblWIPOFilingDate.Size = New System.Drawing.Size(93, 13)
        Me.lblWIPOFilingDate.TabIndex = 0
        Me.lblWIPOFilingDate.Text = "lblWIPOFilingDate"
        Me.lblWIPOFilingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpMadridProtocolSerialNumber
        '
        Me.grpMadridProtocolSerialNumber.Controls.Add(Me.btnMadridProtocolSerialNumber)
        Me.grpMadridProtocolSerialNumber.Controls.Add(Me.txtMadridProtocolSerialNumber)
        Me.grpMadridProtocolSerialNumber.Controls.Add(Me.lblMadridProtocolSerialNumber)
        Me.grpMadridProtocolSerialNumber.Location = New System.Drawing.Point(94, 13)
        Me.grpMadridProtocolSerialNumber.Name = "grpMadridProtocolSerialNumber"
        Me.grpMadridProtocolSerialNumber.Size = New System.Drawing.Size(655, 53)
        Me.grpMadridProtocolSerialNumber.TabIndex = 1
        Me.grpMadridProtocolSerialNumber.TabStop = False
        Me.grpMadridProtocolSerialNumber.Text = "grpMadridProtocolSerialNumber"
        '
        'btnMadridProtocolSerialNumber
        '
        Me.btnMadridProtocolSerialNumber.Location = New System.Drawing.Point(571, 18)
        Me.btnMadridProtocolSerialNumber.Name = "btnMadridProtocolSerialNumber"
        Me.btnMadridProtocolSerialNumber.Size = New System.Drawing.Size(68, 23)
        Me.btnMadridProtocolSerialNumber.TabIndex = 2
        Me.btnMadridProtocolSerialNumber.Text = "btnMadridProtocolSerialNumber"
        Me.btnMadridProtocolSerialNumber.UseVisualStyleBackColor = True
        '
        'txtMadridProtocolSerialNumber
        '
        Me.txtMadridProtocolSerialNumber.Location = New System.Drawing.Point(274, 19)
        Me.txtMadridProtocolSerialNumber.Name = "txtMadridProtocolSerialNumber"
        Me.txtMadridProtocolSerialNumber.Size = New System.Drawing.Size(291, 20)
        Me.txtMadridProtocolSerialNumber.TabIndex = 1
        Me.txtMadridProtocolSerialNumber.Text = "txtMadridProtocolSerialNumber"
        '
        'lblMadridProtocolSerialNumber
        '
        Me.lblMadridProtocolSerialNumber.AutoSize = True
        Me.lblMadridProtocolSerialNumber.Location = New System.Drawing.Point(21, 22)
        Me.lblMadridProtocolSerialNumber.Name = "lblMadridProtocolSerialNumber"
        Me.lblMadridProtocolSerialNumber.Size = New System.Drawing.Size(151, 13)
        Me.lblMadridProtocolSerialNumber.TabIndex = 0
        Me.lblMadridProtocolSerialNumber.Text = "lblMadridProtocolSerialNumber"
        Me.lblMadridProtocolSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpFirstUseDate
        '
        Me.grpFirstUseDate.Controls.Add(Me.btnFirstUseDate)
        Me.grpFirstUseDate.Controls.Add(Me.txtFirstUseDate)
        Me.grpFirstUseDate.Controls.Add(Me.lblFirstUseDate)
        Me.grpFirstUseDate.Location = New System.Drawing.Point(308, 65)
        Me.grpFirstUseDate.Name = "grpFirstUseDate"
        Me.grpFirstUseDate.Size = New System.Drawing.Size(439, 53)
        Me.grpFirstUseDate.TabIndex = 0
        Me.grpFirstUseDate.TabStop = False
        Me.grpFirstUseDate.Text = "grpFirstUseDate"
        '
        'btnFirstUseDate
        '
        Me.btnFirstUseDate.Location = New System.Drawing.Point(325, 20)
        Me.btnFirstUseDate.Name = "btnFirstUseDate"
        Me.btnFirstUseDate.Size = New System.Drawing.Size(53, 24)
        Me.btnFirstUseDate.TabIndex = 14
        Me.btnFirstUseDate.Text = "btnFirstUseDate"
        Me.btnFirstUseDate.UseVisualStyleBackColor = True
        '
        'txtFirstUseDate
        '
        Me.txtFirstUseDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtFirstUseDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstUseDate.BeepOnError = True
        Me.txtFirstUseDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstUseDate.Location = New System.Drawing.Point(215, 19)
        Me.txtFirstUseDate.Mask = "00/00/0000"
        Me.txtFirstUseDate.Name = "txtFirstUseDate"
        Me.txtFirstUseDate.Size = New System.Drawing.Size(99, 26)
        Me.txtFirstUseDate.TabIndex = 13
        Me.txtFirstUseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstUseDate
        '
        Me.lblFirstUseDate.AutoSize = True
        Me.lblFirstUseDate.Location = New System.Drawing.Point(52, 23)
        Me.lblFirstUseDate.Name = "lblFirstUseDate"
        Me.lblFirstUseDate.Size = New System.Drawing.Size(78, 13)
        Me.lblFirstUseDate.TabIndex = 0
        Me.lblFirstUseDate.Text = "lblFirstUseDate"
        Me.lblFirstUseDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(508, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "lblFormTitle"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInitialTrademarkApplicationInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 801)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.tlpInitialTrademarkInput)
        Me.Name = "frmInitialTrademarkApplicationInput"
        Me.Text = "frmInitialTrademarkApplicationInput"
        Me.tlpInitialTrademarkInput.ResumeLayout(False)
        Me.grpInputOfGoodsAndOrServices.ResumeLayout(False)
        Me.grpInputOfGoodsAndOrServices.PerformLayout()
        Me.grpInputOfMark.ResumeLayout(False)
        Me.grpInputOfMark.PerformLayout()
        Me.grpDocketNumberSubDocketNumber.ResumeLayout(False)
        Me.grpCountryCode.ResumeLayout(False)
        Me.grpCountryCode.PerformLayout()
        Me.grpForeignClientReferenceNumber.ResumeLayout(False)
        Me.grpForeignClientReferenceNumber.PerformLayout()
        Me.grpSelectResponsibleAttorney.ResumeLayout(False)
        Me.grpClientDocketNumber.ResumeLayout(False)
        Me.grpClientDocketNumber.PerformLayout()
        Me.grpSubDocketNumber.ResumeLayout(False)
        Me.grpSubDocketNumber.PerformLayout()
        Me.grpClientName.ResumeLayout(False)
        Me.grpClientName.PerformLayout()
        Me.grpDocketNumber.ResumeLayout(False)
        Me.grpDocketNumber.PerformLayout()
        Me.grpCategoryOfTrademarkType.ResumeLayout(False)
        Me.grpFirstUseDateInCommerce.ResumeLayout(False)
        Me.grpFirstUseDateInCommerce.PerformLayout()
        Me.grpWIPOFilingDate.ResumeLayout(False)
        Me.grpWIPOFilingDate.PerformLayout()
        Me.grpMadridProtocolSerialNumber.ResumeLayout(False)
        Me.grpMadridProtocolSerialNumber.PerformLayout()
        Me.grpFirstUseDate.ResumeLayout(False)
        Me.grpFirstUseDate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpInitialTrademarkInput As TableLayoutPanel
    Friend WithEvents btnDone As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents grpDocketNumberSubDocketNumber As GroupBox
    Friend WithEvents grpSubDocketNumber As GroupBox
    Friend WithEvents btnLookUpSDN As Button
    Friend WithEvents txtSubDocketNumber As TextBox
    Friend WithEvents lblSubDocketNumber As Label
    Friend WithEvents grpClientName As GroupBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents grpDocketNumber As GroupBox
    Friend WithEvents btnLookUpDN As Button
    Friend WithEvents txtDocketNumber As TextBox
    Friend WithEvents lblDocketNumber As Label
    Friend WithEvents grpClientDocketNumber As GroupBox
    Friend WithEvents btnClientDocketNumber As Button
    Friend WithEvents txtClientDocketNumber As TextBox
    Friend WithEvents lblClientDocketNumber As Label
    Friend WithEvents grpInputOfMark As GroupBox
    Friend WithEvents btnClearInputOfMark As Button
    Friend WithEvents btnDoneInputOfMark As Button
    Friend WithEvents lblMarkCharactersRemaining As Label
    Friend WithEvents rtbInputOfMark As RichTextBox
    Friend WithEvents lblInputOfMarkInstructions As Label
    Friend WithEvents grpInputOfGoodsAndOrServices As GroupBox
    Friend WithEvents lblGoodsCharactersRemaining As Label
    Friend WithEvents btnClearInputOfGoodAndOrServices As Button
    Friend WithEvents btnDoneInputOfGoodAndOrServices As Button
    Friend WithEvents rtbInputOfGoodsAndOrServices As RichTextBox
    Friend WithEvents lblInputOfGoodsAndOrServices As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents grpFirstUseDateInCommerce As GroupBox
    Friend WithEvents txtFirstUseDateInCommerce As MaskedTextBox
    Friend WithEvents lblFirstUseDateInCommerce As Label
    Friend WithEvents grpSelectResponsibleAttorney As GroupBox
    Friend WithEvents lstSelectResponsibleAttorney As ListBox
    Friend WithEvents btnFirstUseDateInCommerce As Button
    Friend WithEvents grpCategoryOfTrademarkType As GroupBox
    Friend WithEvents grpFirstUseDate As GroupBox
    Friend WithEvents lblFirstUseDate As Label
    Friend WithEvents btnFirstUseDate As Button
    Friend WithEvents txtFirstUseDate As MaskedTextBox
    Friend WithEvents grpMadridProtocolSerialNumber As GroupBox
    Friend WithEvents btnMadridProtocolSerialNumber As Button
    Friend WithEvents txtMadridProtocolSerialNumber As TextBox
    Friend WithEvents lblMadridProtocolSerialNumber As Label
    Friend WithEvents grpWIPOFilingDate As GroupBox
    Friend WithEvents lblWIPOFilingDate As Label
    Friend WithEvents txtWIPOFilingDate As MaskedTextBox
    Friend WithEvents grpForeignClientReferenceNumber As GroupBox
    Friend WithEvents txtForeignClientReferenceNumber As TextBox
    Friend WithEvents lblForeignClientReferenceNumber As Label
    Friend WithEvents btnForeignClientReferenceNumber As Button
    Friend WithEvents grpTrademarkOwnersEntityStatus As GroupBox
    Friend WithEvents grpCountryCode As GroupBox
    Friend WithEvents btnCountryCode As Button
    Friend WithEvents txtCountryCode As TextBox
    Friend WithEvents lblCountryCode As Label
End Class
