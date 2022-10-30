<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtConverter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBinary = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblHex = New System.Windows.Forms.Label()
        Me.lblOctal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(178, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Преобразувай"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(398, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Изчисти"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(594, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Изход"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtConverter
        '
        Me.txtConverter.Location = New System.Drawing.Point(431, 70)
        Me.txtConverter.Name = "txtConverter"
        Me.txtConverter.Size = New System.Drawing.Size(100, 23)
        Me.txtConverter.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Преобразуване на числа"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(282, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Въведи число"
        '
        'lblBinary
        '
        Me.lblBinary.AutoSize = True
        Me.lblBinary.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBinary.Location = New System.Drawing.Point(178, 148)
        Me.lblBinary.Name = "lblBinary"
        Me.lblBinary.Size = New System.Drawing.Size(0, 15)
        Me.lblBinary.TabIndex = 6
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblDecimal.Location = New System.Drawing.Point(334, 148)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(0, 15)
        Me.lblDecimal.TabIndex = 7
        '
        'lblHex
        '
        Me.lblHex.AutoSize = True
        Me.lblHex.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblHex.Location = New System.Drawing.Point(482, 148)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(0, 15)
        Me.lblHex.TabIndex = 8
        '
        'lblOctal
        '
        Me.lblOctal.AutoSize = True
        Me.lblOctal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblOctal.Location = New System.Drawing.Point(650, 148)
        Me.lblOctal.Name = "lblOctal"
        Me.lblOctal.Size = New System.Drawing.Size(0, 15)
        Me.lblOctal.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(164, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Двоична"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(296, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Десетична"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(415, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Шестнадесетична"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(614, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 22)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Осмична"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(875, 318)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblOctal)
        Me.Controls.Add(Me.lblHex)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.lblBinary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConverter)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Преобразуване на числа"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtConverter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBinary As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblHex As Label
    Friend WithEvents lblOctal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
