<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class htglgkrn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRad = New System.Windows.Forms.TextBox()
        Me.kllLing = New System.Windows.Forms.TextBox()
        Me.luasLing = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keliling Lingkaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Luas Lingkaran"
        '
        'txtRad
        '
        Me.txtRad.Location = New System.Drawing.Point(202, 65)
        Me.txtRad.Name = "txtRad"
        Me.txtRad.Size = New System.Drawing.Size(100, 26)
        Me.txtRad.TabIndex = 3
        '
        'kllLing
        '
        Me.kllLing.Location = New System.Drawing.Point(202, 104)
        Me.kllLing.Name = "kllLing"
        Me.kllLing.Size = New System.Drawing.Size(227, 26)
        Me.kllLing.TabIndex = 4
        '
        'luasLing
        '
        Me.luasLing.Location = New System.Drawing.Point(202, 149)
        Me.luasLing.Name = "luasLing"
        Me.luasLing.Size = New System.Drawing.Size(239, 26)
        Me.luasLing.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(433, 51)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 40)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Hitung"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'htglgkrn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.luasLing)
        Me.Controls.Add(Me.kllLing)
        Me.Controls.Add(Me.txtRad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "htglgkrn"
        Me.Text = "Hitung Lingkaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRad As TextBox
    Friend WithEvents kllLing As TextBox
    Friend WithEvents luasLing As TextBox
    Friend WithEvents btnCalc As Button
End Class
