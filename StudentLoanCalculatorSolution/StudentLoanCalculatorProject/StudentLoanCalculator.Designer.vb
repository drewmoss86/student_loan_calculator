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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.radDirectSubLoan = New System.Windows.Forms.RadioButton()
        Me.radDirectUnSubLoan = New System.Windows.Forms.RadioButton()
        Me.radDirectPlusLoan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(66, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(193, 63)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'radDirectSubLoan
        '
        Me.radDirectSubLoan.AutoSize = True
        Me.radDirectSubLoan.Location = New System.Drawing.Point(31, 21)
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
        Me.radDirectUnSubLoan.Location = New System.Drawing.Point(31, 48)
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
        Me.radDirectPlusLoan.Location = New System.Drawing.Point(31, 75)
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
        Me.GroupBox1.Location = New System.Drawing.Point(66, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 109)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.Text = "StudentLoanCalculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents radDirectSubLoan As RadioButton
    Friend WithEvents radDirectUnSubLoan As RadioButton
    Friend WithEvents radDirectPlusLoan As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
