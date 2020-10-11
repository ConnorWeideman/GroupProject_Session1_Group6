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
        Me.txtDeaths = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(143, 12)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(141, 68)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 86)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(412, 542)
        Me.txtDisplay.TabIndex = 1
        Me.txtDisplay.Text = ""
        '
        'txtWorst
        '
        Me.txtWorst.Location = New System.Drawing.Point(12, 758)
        Me.txtWorst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWorst.Name = "txtWorst"
        Me.txtWorst.Size = New System.Drawing.Size(412, 22)
        Me.txtWorst.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 728)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Worst Disease:"
        '
        'txtDeaths
        '
        Me.txtDeaths.Location = New System.Drawing.Point(12, 677)
        Me.txtDeaths.Name = "txtDeaths"
        Me.txtDeaths.Size = New System.Drawing.Size(412, 22)
        Me.txtDeaths.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 645)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Deaths:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 791)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDeaths)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWorst)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txtDisplay As RichTextBox
    Friend WithEvents txtWorst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeaths As TextBox
    Friend WithEvents Label2 As Label
End Class
