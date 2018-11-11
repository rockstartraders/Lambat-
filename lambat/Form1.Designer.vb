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
        Me.components = New System.ComponentModel.Container()
        Me.Bitag = New System.Windows.Forms.TextBox()
        Me.Etime = New System.Windows.Forms.Timer(Me.components)
        Me.lambat = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Bitag
        '
        Me.Bitag.Location = New System.Drawing.Point(12, 12)
        Me.Bitag.Multiline = True
        Me.Bitag.Name = "Bitag"
        Me.Bitag.Size = New System.Drawing.Size(306, 390)
        Me.Bitag.TabIndex = 0
        '
        'Etime
        '
        Me.Etime.Enabled = True
        Me.Etime.Interval = 60000
        '
        'lambat
        '
        Me.lambat.Enabled = True
        Me.lambat.Interval = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 414)
        Me.Controls.Add(Me.Bitag)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bitag As System.Windows.Forms.TextBox
    Friend WithEvents Etime As System.Windows.Forms.Timer
    Friend WithEvents lambat As System.Windows.Forms.Timer

End Class
