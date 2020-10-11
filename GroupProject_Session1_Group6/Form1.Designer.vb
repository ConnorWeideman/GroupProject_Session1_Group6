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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.RichTextBox()
        Me.txtWorst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(107, 10)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(106, 55)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(9, 70)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(310, 441)
        Me.txtDisplay.TabIndex = 1
        Me.txtDisplay.Text = ""
        '
        'txtWorst
        '
        Me.txtWorst.Location = New System.Drawing.Point(9, 562)
        Me.txtWorst.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWorst.Name = "txtWorst"
        Me.txtWorst.Size = New System.Drawing.Size(310, 20)
        Me.txtWorst.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 530)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Worst Disease:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 590)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWorst)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txtDisplay As RichTextBox
    Friend WithEvents txtWorst As TextBox
    Friend WithEvents Label1 As Label
End Class
