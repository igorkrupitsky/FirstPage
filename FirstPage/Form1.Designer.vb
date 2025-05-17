<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.btnProcess = New System.Windows.Forms.Button
		Me.txtFrom = New System.Windows.Forms.TextBox
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
		Me.fldFrom = New System.Windows.Forms.FolderBrowserDialog
		Me.fldTo = New System.Windows.Forms.FolderBrowserDialog
		Me.btnFrom = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.txtOutput = New System.Windows.Forms.TextBox
		Me.selPages = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'btnProcess
		'
		Me.btnProcess.Location = New System.Drawing.Point(117, 74)
		Me.btnProcess.Name = "btnProcess"
		Me.btnProcess.Size = New System.Drawing.Size(384, 23)
		Me.btnProcess.TabIndex = 0
		Me.btnProcess.Text = "Process"
		Me.btnProcess.UseVisualStyleBackColor = True
		'
		'txtFrom
		'
		Me.txtFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtFrom.Location = New System.Drawing.Point(117, 20)
		Me.txtFrom.Name = "txtFrom"
		Me.txtFrom.Size = New System.Drawing.Size(384, 20)
		Me.txtFrom.TabIndex = 1
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar1.Location = New System.Drawing.Point(12, 318)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(523, 17)
		Me.ProgressBar1.TabIndex = 5
		'
		'btnFrom
		'
		Me.btnFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnFrom.Location = New System.Drawing.Point(507, 16)
		Me.btnFrom.Name = "btnFrom"
		Me.btnFrom.Size = New System.Drawing.Size(28, 23)
		Me.btnFrom.TabIndex = 6
		Me.btnFrom.Text = "..."
		Me.btnFrom.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(11, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(36, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Folder"
		'
		'txtOutput
		'
		Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtOutput.Location = New System.Drawing.Point(12, 120)
		Me.txtOutput.Multiline = True
		Me.txtOutput.Name = "txtOutput"
		Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtOutput.Size = New System.Drawing.Size(522, 192)
		Me.txtOutput.TabIndex = 12
		'
		'selPages
		'
		Me.selPages.FormattingEnabled = True
		Me.selPages.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
		Me.selPages.Location = New System.Drawing.Point(117, 47)
		Me.selPages.Name = "selPages"
		Me.selPages.Size = New System.Drawing.Size(384, 21)
		Me.selPages.TabIndex = 13
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(14, 54)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 13)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Number of pages"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(552, 345)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.selPages)
		Me.Controls.Add(Me.txtOutput)
		Me.Controls.Add(Me.btnFrom)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtFrom)
		Me.Controls.Add(Me.btnProcess)
		Me.Name = "Form1"
		Me.Text = "First Page"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents fldFrom As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents fldTo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnFrom As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
	Friend WithEvents selPages As System.Windows.Forms.ComboBox
	Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
