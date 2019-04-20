<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.radDirectSubLoan = New System.Windows.Forms.RadioButton()
        Me.radDirectUnSubLoan = New System.Windows.Forms.RadioButton()
        Me.radDirectPlusLoan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLoanAmt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLoanDuration = New System.Windows.Forms.Label()
        Me.txtLoanDuration = New System.Windows.Forms.TextBox()
        Me.lblLoanAmt = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(68, 431)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 54)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(322, 431)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(165, 54)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'radDirectSubLoan
        '
        Me.radDirectSubLoan.AutoSize = True
        Me.radDirectSubLoan.Location = New System.Drawing.Point(7, 21)
        Me.radDirectSubLoan.Name = "radDirectSubLoan"
        Me.radDirectSubLoan.Size = New System.Drawing.Size(175, 21)
        Me.radDirectSubLoan.TabIndex = 2
        Me.radDirectSubLoan.TabStop = True
        Me.radDirectSubLoan.Text = "Direct Subsidized Loan"
        Me.radDirectSubLoan.UseVisualStyleBackColor = True
        '
        'radDirectUnSubLoan
        '
        Me.radDirectUnSubLoan.AutoSize = True
        Me.radDirectUnSubLoan.Location = New System.Drawing.Point(7, 48)
        Me.radDirectUnSubLoan.Name = "radDirectUnSubLoan"
        Me.radDirectUnSubLoan.Size = New System.Drawing.Size(191, 21)
        Me.radDirectUnSubLoan.TabIndex = 3
        Me.radDirectUnSubLoan.TabStop = True
        Me.radDirectUnSubLoan.Text = "Direct Unsubsidized Loan"
        Me.radDirectUnSubLoan.UseVisualStyleBackColor = True
        '
        'radDirectPlusLoan
        '
        Me.radDirectPlusLoan.AutoSize = True
        Me.radDirectPlusLoan.Location = New System.Drawing.Point(7, 75)
        Me.radDirectPlusLoan.Name = "radDirectPlusLoan"
        Me.radDirectPlusLoan.Size = New System.Drawing.Size(142, 21)
        Me.radDirectPlusLoan.TabIndex = 4
        Me.radDirectPlusLoan.TabStop = True
        Me.radDirectPlusLoan.Text = "Direct PLUS Loan"
        Me.radDirectPlusLoan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDirectSubLoan)
        Me.GroupBox1.Controls.Add(Me.radDirectPlusLoan)
        Me.GroupBox1.Controls.Add(Me.radDirectUnSubLoan)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 109)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtLoanAmt
        '
        Me.txtLoanAmt.Location = New System.Drawing.Point(6, 51)
        Me.txtLoanAmt.Name = "txtLoanAmt"
        Me.txtLoanAmt.Size = New System.Drawing.Size(229, 22)
        Me.txtLoanAmt.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLoanDuration)
        Me.GroupBox2.Controls.Add(Me.txtLoanDuration)
        Me.GroupBox2.Controls.Add(Me.txtLoanAmt)
        Me.GroupBox2.Controls.Add(Me.lblLoanAmt)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 179)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblLoanDuration
        '
        Me.lblLoanDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoanDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanDuration.Location = New System.Drawing.Point(7, 93)
        Me.lblLoanDuration.Name = "lblLoanDuration"
        Me.lblLoanDuration.Size = New System.Drawing.Size(123, 23)
        Me.lblLoanDuration.TabIndex = 10
        Me.lblLoanDuration.Text = "Loan Duration:"
        '
        'txtLoanDuration
        '
        Me.txtLoanDuration.Location = New System.Drawing.Point(6, 119)
        Me.txtLoanDuration.Name = "txtLoanDuration"
        Me.txtLoanDuration.Size = New System.Drawing.Size(101, 22)
        Me.txtLoanDuration.TabIndex = 10
        '
        'lblLoanAmt
        '
        Me.lblLoanAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoanAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmt.Location = New System.Drawing.Point(6, 25)
        Me.lblLoanAmt.Name = "lblLoanAmt"
        Me.lblLoanAmt.Size = New System.Drawing.Size(124, 23)
        Me.lblLoanAmt.TabIndex = 9
        Me.lblLoanAmt.Text = "Loan Amount:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 507)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.Text = "StudentLoanCalculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents radDirectSubLoan As RadioButton
    Friend WithEvents radDirectUnSubLoan As RadioButton
    Friend WithEvents radDirectPlusLoan As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLoanAmt As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblLoanDuration As Label
    Friend WithEvents txtLoanDuration As TextBox
    Friend WithEvents lblLoanAmt As Label
End Class
