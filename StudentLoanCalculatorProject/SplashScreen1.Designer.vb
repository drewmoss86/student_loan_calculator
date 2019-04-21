<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splStudentLoanCalc
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
        Me.components = New System.ComponentModel.Container()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.prgLoading = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAppTitle
        '
        Me.lblAppTitle.BackColor = System.Drawing.Color.Green
        Me.lblAppTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAppTitle.Font = New System.Drawing.Font("Broadway", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppTitle.ForeColor = System.Drawing.Color.White
        Me.lblAppTitle.Location = New System.Drawing.Point(64, 82)
        Me.lblAppTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(300, 89)
        Me.lblAppTitle.TabIndex = 0
        Me.lblAppTitle.Text = "Student Loan Calculator"
        Me.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prgLoading
        '
        Me.prgLoading.Location = New System.Drawing.Point(64, 288)
        Me.prgLoading.Margin = New System.Windows.Forms.Padding(2)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.Size = New System.Drawing.Size(300, 20)
        Me.prgLoading.TabIndex = 1
        Me.prgLoading.Value = 5
        '
        'Timer1
        '
        '
        'lblLoading
        '
        Me.lblLoading.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(169, 266)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(100, 20)
        Me.lblLoading.TabIndex = 2
        Me.lblLoading.Text = "Loading..."
        '
        'splStudentLoanCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.prgLoading)
        Me.Controls.Add(Me.lblAppTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "splStudentLoanCalc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAppTitle As Label
    Friend WithEvents prgLoading As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLoading As Label
End Class
