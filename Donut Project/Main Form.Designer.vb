<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCappuccino)
        Me.GroupBox2.Controls.Add(Me.radRegular)
        Me.GroupBox2.Controls.Add(Me.radNoCoffee)
        Me.GroupBox2.Location = New System.Drawing.Point(74, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 141)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee choices"
        '
        'radCappuccino
        '
        Me.radCappuccino.Location = New System.Drawing.Point(17, 101)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(147, 23)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.Text = "Ca&ppuccino ($2.75)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.Location = New System.Drawing.Point(17, 66)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(147, 23)
        Me.radRegular.TabIndex = 1
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNoCoffee
        '
        Me.radNoCoffee.Checked = True
        Me.radNoCoffee.Location = New System.Drawing.Point(17, 33)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(147, 23)
        Me.radNoCoffee.TabIndex = 0
        Me.radNoCoffee.TabStop = True
        Me.radNoCoffee.Text = "&None"
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFilled)
        Me.GroupBox1.Controls.Add(Me.radChocolate)
        Me.GroupBox1.Controls.Add(Me.radSugar)
        Me.GroupBox1.Controls.Add(Me.radGlazed)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 180)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doughnut choices"
        '
        'radFilled
        '
        Me.radFilled.Location = New System.Drawing.Point(23, 135)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(147, 23)
        Me.radFilled.TabIndex = 3
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.Location = New System.Drawing.Point(23, 100)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(147, 23)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.Text = "C&hocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.Location = New System.Drawing.Point(23, 65)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(147, 23)
        Me.radSugar.TabIndex = 1
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.Checked = True
        Me.radGlazed.Location = New System.Drawing.Point(23, 29)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(147, 23)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(81, 30)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(53, 24)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sales tax:"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(81, 74)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(53, 24)
        Me.lblTax.TabIndex = 3
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total due:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(81, 120)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 24)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(333, 258)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(99, 33)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(333, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 33)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(163, 180)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(418, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Our doughnuts and coffee are the best in town!"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 391)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donut Shoppe"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radNoCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents radSugar As System.Windows.Forms.RadioButton
    Friend WithEvents radGlazed As System.Windows.Forms.RadioButton
    Friend WithEvents radFilled As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As Label
End Class
