<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.LBLSame2 = New System.Windows.Forms.Label()
        Me.TXTInput = New System.Windows.Forms.TextBox()
        Me.LBLSame1 = New System.Windows.Forms.Label()
        Me.LBLInput = New System.Windows.Forms.Label()
        Me.TXTInput2 = New System.Windows.Forms.TextBox()
        Me.LBLInput2 = New System.Windows.Forms.Label()
        Me.LBLCompare2 = New System.Windows.Forms.Label()
        Me.LBLCompare1 = New System.Windows.Forms.Label()
        Me.LBLConcat2 = New System.Windows.Forms.Label()
        Me.LBLConcat1 = New System.Windows.Forms.Label()
        Me.LBLCopy2 = New System.Windows.Forms.Label()
        Me.LBLCopy1 = New System.Windows.Forms.Label()
        Me.LBLJoin2 = New System.Windows.Forms.Label()
        Me.LBLJoin1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSubmit.Location = New System.Drawing.Point(548, 51)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(75, 33)
        Me.BTNSubmit.TabIndex = 25
        Me.BTNSubmit.Text = "Submit"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'LBLSame2
        '
        Me.LBLSame2.AutoSize = True
        Me.LBLSame2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSame2.Location = New System.Drawing.Point(208, 130)
        Me.LBLSame2.Name = "LBLSame2"
        Me.LBLSame2.Size = New System.Drawing.Size(82, 19)
        Me.LBLSame2.TabIndex = 24
        Me.LBLSame2.Text = "Same String"
        Me.LBLSame2.Visible = False
        '
        'TXTInput
        '
        Me.TXTInput.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTInput.Location = New System.Drawing.Point(212, 12)
        Me.TXTInput.Name = "TXTInput"
        Me.TXTInput.Size = New System.Drawing.Size(297, 26)
        Me.TXTInput.TabIndex = 23
        '
        'LBLSame1
        '
        Me.LBLSame1.AutoSize = True
        Me.LBLSame1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSame1.Location = New System.Drawing.Point(21, 130)
        Me.LBLSame1.Name = "LBLSame1"
        Me.LBLSame1.Size = New System.Drawing.Size(163, 19)
        Me.LBLSame1.TabIndex = 22
        Me.LBLSame1.Text = "Are the strings the same?:"
        '
        'LBLInput
        '
        Me.LBLInput.AutoSize = True
        Me.LBLInput.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLInput.Location = New System.Drawing.Point(22, 15)
        Me.LBLInput.Name = "LBLInput"
        Me.LBLInput.Size = New System.Drawing.Size(128, 19)
        Me.LBLInput.TabIndex = 21
        Me.LBLInput.Text = "Enter Your 1st Text:"
        '
        'TXTInput2
        '
        Me.TXTInput2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTInput2.Location = New System.Drawing.Point(212, 62)
        Me.TXTInput2.Name = "TXTInput2"
        Me.TXTInput2.Size = New System.Drawing.Size(297, 26)
        Me.TXTInput2.TabIndex = 27
        '
        'LBLInput2
        '
        Me.LBLInput2.AutoSize = True
        Me.LBLInput2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLInput2.Location = New System.Drawing.Point(22, 65)
        Me.LBLInput2.Name = "LBLInput2"
        Me.LBLInput2.Size = New System.Drawing.Size(133, 19)
        Me.LBLInput2.TabIndex = 26
        Me.LBLInput2.Text = "Enter Your 2nd Text:"
        '
        'LBLCompare2
        '
        Me.LBLCompare2.AutoSize = True
        Me.LBLCompare2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCompare2.Location = New System.Drawing.Point(209, 173)
        Me.LBLCompare2.Name = "LBLCompare2"
        Me.LBLCompare2.Size = New System.Drawing.Size(66, 19)
        Me.LBLCompare2.TabIndex = 29
        Me.LBLCompare2.Text = "Compare"
        Me.LBLCompare2.Visible = False
        '
        'LBLCompare1
        '
        Me.LBLCompare1.AutoSize = True
        Me.LBLCompare1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCompare1.Location = New System.Drawing.Point(22, 173)
        Me.LBLCompare1.Name = "LBLCompare1"
        Me.LBLCompare1.Size = New System.Drawing.Size(124, 19)
        Me.LBLCompare1.TabIndex = 28
        Me.LBLCompare1.Text = "Comparing Strings:"
        '
        'LBLConcat2
        '
        Me.LBLConcat2.AutoSize = True
        Me.LBLConcat2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLConcat2.Location = New System.Drawing.Point(210, 218)
        Me.LBLConcat2.Name = "LBLConcat2"
        Me.LBLConcat2.Size = New System.Drawing.Size(53, 19)
        Me.LBLConcat2.TabIndex = 31
        Me.LBLConcat2.Text = "Concat"
        Me.LBLConcat2.Visible = False
        '
        'LBLConcat1
        '
        Me.LBLConcat1.AutoSize = True
        Me.LBLConcat1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLConcat1.Location = New System.Drawing.Point(23, 218)
        Me.LBLConcat1.Name = "LBLConcat1"
        Me.LBLConcat1.Size = New System.Drawing.Size(143, 19)
        Me.LBLConcat1.TabIndex = 30
        Me.LBLConcat1.Text = "Concatenating Strings:"
        '
        'LBLCopy2
        '
        Me.LBLCopy2.AutoSize = True
        Me.LBLCopy2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCopy2.Location = New System.Drawing.Point(210, 265)
        Me.LBLCopy2.Name = "LBLCopy2"
        Me.LBLCopy2.Size = New System.Drawing.Size(43, 19)
        Me.LBLCopy2.TabIndex = 33
        Me.LBLCopy2.Text = "Copy"
        Me.LBLCopy2.Visible = False
        '
        'LBLCopy1
        '
        Me.LBLCopy1.AutoSize = True
        Me.LBLCopy1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCopy1.Location = New System.Drawing.Point(23, 265)
        Me.LBLCopy1.Name = "LBLCopy1"
        Me.LBLCopy1.Size = New System.Drawing.Size(108, 19)
        Me.LBLCopy1.TabIndex = 32
        Me.LBLCopy1.Text = "Copying Strings:"
        '
        'LBLJoin2
        '
        Me.LBLJoin2.AutoSize = True
        Me.LBLJoin2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJoin2.Location = New System.Drawing.Point(210, 312)
        Me.LBLJoin2.Name = "LBLJoin2"
        Me.LBLJoin2.Size = New System.Drawing.Size(33, 19)
        Me.LBLJoin2.TabIndex = 35
        Me.LBLJoin2.Text = "Join"
        Me.LBLJoin2.Visible = False
        '
        'LBLJoin1
        '
        Me.LBLJoin1.AutoSize = True
        Me.LBLJoin1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJoin1.Location = New System.Drawing.Point(23, 312)
        Me.LBLJoin1.Name = "LBLJoin1"
        Me.LBLJoin1.Size = New System.Drawing.Size(98, 19)
        Me.LBLJoin1.TabIndex = 34
        Me.LBLJoin1.Text = "Joining Strings:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(365, 364)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(258, 19)
        Me.LinkLabel1.TabIndex = 36
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Go Back to Single String Manipulation"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 394)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LBLJoin2)
        Me.Controls.Add(Me.LBLJoin1)
        Me.Controls.Add(Me.LBLCopy2)
        Me.Controls.Add(Me.LBLCopy1)
        Me.Controls.Add(Me.LBLConcat2)
        Me.Controls.Add(Me.LBLConcat1)
        Me.Controls.Add(Me.LBLCompare2)
        Me.Controls.Add(Me.LBLCompare1)
        Me.Controls.Add(Me.TXTInput2)
        Me.Controls.Add(Me.LBLInput2)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.LBLSame2)
        Me.Controls.Add(Me.TXTInput)
        Me.Controls.Add(Me.LBLSame1)
        Me.Controls.Add(Me.LBLInput)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNSubmit As Button
    Friend WithEvents LBLSame2 As Label
    Friend WithEvents TXTInput As TextBox
    Friend WithEvents LBLSame1 As Label
    Friend WithEvents LBLInput As Label
    Friend WithEvents TXTInput2 As TextBox
    Friend WithEvents LBLInput2 As Label
    Friend WithEvents LBLCompare2 As Label
    Friend WithEvents LBLCompare1 As Label
    Friend WithEvents LBLConcat2 As Label
    Friend WithEvents LBLConcat1 As Label
    Friend WithEvents LBLCopy2 As Label
    Friend WithEvents LBLCopy1 As Label
    Friend WithEvents LBLJoin2 As Label
    Friend WithEvents LBLJoin1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
