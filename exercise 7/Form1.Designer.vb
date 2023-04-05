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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radChoc = New System.Windows.Forms.RadioButton()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radReg = New System.Windows.Forms.RadioButton()
        Me.radCap = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(767, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Our doughnuts and coffee are the best in town!"
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(847, 473)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(173, 60)
        Me.btnCal.TabIndex = 1
        Me.btnCal.Text = "&Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(847, 574)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 59)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFilled)
        Me.GroupBox1.Controls.Add(Me.radChoc)
        Me.GroupBox1.Controls.Add(Me.radSugar)
        Me.GroupBox1.Controls.Add(Me.radGlazed)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(79, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 248)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doughnut choices "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCap)
        Me.GroupBox2.Controls.Add(Me.radReg)
        Me.GroupBox2.Controls.Add(Me.radNone)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(79, 432)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 216)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee choices"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblSales)
        Me.GroupBox3.Controls.Add(Me.lblSub)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(532, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 254)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(24, 38)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(140, 24)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(24, 83)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(126, 24)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radChoc
        '
        Me.radChoc.AutoSize = True
        Me.radChoc.Location = New System.Drawing.Point(24, 137)
        Me.radChoc.Name = "radChoc"
        Me.radChoc.Size = New System.Drawing.Size(162, 24)
        Me.radChoc.TabIndex = 2
        Me.radChoc.TabStop = True
        Me.radChoc.Text = "C&hocolate ($1.25)"
        Me.radChoc.UseVisualStyleBackColor = True
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(24, 191)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(127, 24)
        Me.radFilled.TabIndex = 3
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(24, 41)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(69, 24)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radReg
        '
        Me.radReg.AutoSize = True
        Me.radReg.Location = New System.Drawing.Point(24, 95)
        Me.radReg.Name = "radReg"
        Me.radReg.Size = New System.Drawing.Size(145, 24)
        Me.radReg.TabIndex = 1
        Me.radReg.TabStop = True
        Me.radReg.Text = "&Regular ($1.50)"
        Me.radReg.UseVisualStyleBackColor = True
        '
        'radCap
        '
        Me.radCap.AutoSize = True
        Me.radCap.Location = New System.Drawing.Point(24, 159)
        Me.radCap.Name = "radCap"
        Me.radCap.Size = New System.Drawing.Size(175, 24)
        Me.radCap.TabIndex = 2
        Me.radCap.TabStop = True
        Me.radCap.Text = "Ca&ppuccino ($2.75)"
        Me.radCap.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sales tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total due:"
        '
        'lblSub
        '
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSub.Location = New System.Drawing.Point(101, 23)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(82, 38)
        Me.lblSub.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(117, 179)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 39)
        Me.lblTotal.TabIndex = 5
        '
        'lblSales
        '
        Me.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSales.Location = New System.Drawing.Point(117, 110)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(82, 38)
        Me.lblSales.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 726)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChoc As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radCap As RadioButton
    Friend WithEvents radReg As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
