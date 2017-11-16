<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDude = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCan1 = New System.Windows.Forms.TextBox()
        Me.TextBoxCan2 = New System.Windows.Forms.TextBox()
        Me.TextBoxCan3 = New System.Windows.Forms.TextBox()
        Me.TextBoxCan4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTotal1 = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal2 = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal3 = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check Boxes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dude"
        '
        'TextBoxDude
        '
        Me.TextBoxDude.Location = New System.Drawing.Point(61, 50)
        Me.TextBoxDude.Name = "TextBoxDude"
        Me.TextBoxDude.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDude.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad"
        '
        'TextBoxCan1
        '
        Me.TextBoxCan1.Location = New System.Drawing.Point(16, 143)
        Me.TextBoxCan1.Name = "TextBoxCan1"
        Me.TextBoxCan1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCan1.TabIndex = 4
        '
        'TextBoxCan2
        '
        Me.TextBoxCan2.Location = New System.Drawing.Point(16, 185)
        Me.TextBoxCan2.Name = "TextBoxCan2"
        Me.TextBoxCan2.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCan2.TabIndex = 5
        '
        'TextBoxCan3
        '
        Me.TextBoxCan3.Location = New System.Drawing.Point(16, 234)
        Me.TextBoxCan3.Name = "TextBoxCan3"
        Me.TextBoxCan3.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCan3.TabIndex = 6
        '
        'TextBoxCan4
        '
        Me.TextBoxCan4.Location = New System.Drawing.Point(16, 276)
        Me.TextBoxCan4.Name = "TextBoxCan4"
        Me.TextBoxCan4.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCan4.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 148)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 126)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 79)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 35)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "totales"
        '
        'TextBoxTotal1
        '
        Me.TextBoxTotal1.Location = New System.Drawing.Point(435, 141)
        Me.TextBoxTotal1.Name = "TextBoxTotal1"
        Me.TextBoxTotal1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal1.TabIndex = 11
        '
        'TextBoxTotal2
        '
        Me.TextBoxTotal2.Location = New System.Drawing.Point(435, 185)
        Me.TextBoxTotal2.Name = "TextBoxTotal2"
        Me.TextBoxTotal2.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal2.TabIndex = 12
        '
        'TextBoxTotal3
        '
        Me.TextBoxTotal3.Location = New System.Drawing.Point(435, 234)
        Me.TextBoxTotal3.Name = "TextBoxTotal3"
        Me.TextBoxTotal3.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal3.TabIndex = 13
        '
        'TextBoxTotal4
        '
        Me.TextBoxTotal4.Location = New System.Drawing.Point(435, 276)
        Me.TextBoxTotal4.Name = "TextBoxTotal4"
        Me.TextBoxTotal4.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal4.TabIndex = 14
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 418)
        Me.Controls.Add(Me.TextBoxTotal4)
        Me.Controls.Add(Me.TextBoxTotal3)
        Me.Controls.Add(Me.TextBoxTotal2)
        Me.Controls.Add(Me.TextBoxTotal1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxCan4)
        Me.Controls.Add(Me.TextBoxCan3)
        Me.Controls.Add(Me.TextBoxCan2)
        Me.Controls.Add(Me.TextBoxCan1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxDude)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDude As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCan1 As TextBox
    Friend WithEvents TextBoxCan2 As TextBox
    Friend WithEvents TextBoxCan3 As TextBox
    Friend WithEvents TextBoxCan4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxTotal1 As TextBox
    Friend WithEvents TextBoxTotal2 As TextBox
    Friend WithEvents TextBoxTotal3 As TextBox
    Friend WithEvents TextBoxTotal4 As TextBox
End Class
