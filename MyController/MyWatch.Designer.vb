<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyWatch
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.HH = New System.Windows.Forms.Label()
        Me.MM = New System.Windows.Forms.Label()
        Me.SS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'HH
        '
        Me.HH.AutoSize = True
        Me.HH.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HH.Location = New System.Drawing.Point(126, 110)
        Me.HH.Name = "HH"
        Me.HH.Size = New System.Drawing.Size(42, 31)
        Me.HH.TabIndex = 0
        Me.HH.Text = "00"
        '
        'MM
        '
        Me.MM.AutoSize = True
        Me.MM.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MM.Location = New System.Drawing.Point(293, 110)
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(42, 31)
        Me.MM.TabIndex = 1
        Me.MM.Text = "00"
        '
        'SS
        '
        Me.SS.AutoSize = True
        Me.SS.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SS.Location = New System.Drawing.Point(446, 110)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(42, 31)
        Me.SS.TabIndex = 1
        Me.SS.Text = "57"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MyWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.HH)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "MyWatch"
        Me.Size = New System.Drawing.Size(651, 360)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HH As Label
    Friend WithEvents MM As Label
    Friend WithEvents SS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
