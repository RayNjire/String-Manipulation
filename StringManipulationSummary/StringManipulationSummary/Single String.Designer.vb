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
        Me.LBLOne2 = New System.Windows.Forms.Label()
        Me.LBLOne1 = New System.Windows.Forms.Label()
        Me.LBLChar2 = New System.Windows.Forms.Label()
        Me.LBLChar1 = New System.Windows.Forms.Label()
        Me.LBLTrim2 = New System.Windows.Forms.Label()
        Me.LBLTrim1 = New System.Windows.Forms.Label()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.LBLUpper2 = New System.Windows.Forms.Label()
        Me.LBLLower2 = New System.Windows.Forms.Label()
        Me.TXTInput = New System.Windows.Forms.TextBox()
        Me.LBLUpper1 = New System.Windows.Forms.Label()
        Me.LBLLower1 = New System.Windows.Forms.Label()
        Me.LBLInput = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'LBLOne2
        '
        Me.LBLOne2.AutoSize = True
        Me.LBLOne2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOne2.Location = New System.Drawing.Point(195, 282)
        Me.LBLOne2.Name = "LBLOne2"
        Me.LBLOne2.Size = New System.Drawing.Size(79, 19)
        Me.LBLOne2.TabIndex = 26
        Me.LBLOne2.Text = "Single Char"
        Me.LBLOne2.Visible = False
        '
        'LBLOne1
        '
        Me.LBLOne1.AutoSize = True
        Me.LBLOne1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOne1.Location = New System.Drawing.Point(28, 282)
        Me.LBLOne1.Name = "LBLOne1"
        Me.LBLOne1.Size = New System.Drawing.Size(102, 19)
        Me.LBLOne1.TabIndex = 25
        Me.LBLOne1.Text = "One Character:"
        '
        'LBLChar2
        '
        Me.LBLChar2.AutoSize = True
        Me.LBLChar2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLChar2.Location = New System.Drawing.Point(195, 232)
        Me.LBLChar2.Name = "LBLChar2"
        Me.LBLChar2.Size = New System.Drawing.Size(79, 19)
        Me.LBLChar2.TabIndex = 24
        Me.LBLChar2.Text = "Total Chars"
        Me.LBLChar2.Visible = False
        '
        'LBLChar1
        '
        Me.LBLChar1.AutoSize = True
        Me.LBLChar1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLChar1.Location = New System.Drawing.Point(28, 232)
        Me.LBLChar1.Name = "LBLChar1"
        Me.LBLChar1.Size = New System.Drawing.Size(148, 19)
        Me.LBLChar1.TabIndex = 23
        Me.LBLChar1.Text = "Number of Characters:"
        '
        'LBLTrim2
        '
        Me.LBLTrim2.AutoSize = True
        Me.LBLTrim2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTrim2.Location = New System.Drawing.Point(195, 183)
        Me.LBLTrim2.Name = "LBLTrim2"
        Me.LBLTrim2.Size = New System.Drawing.Size(56, 19)
        Me.LBLTrim2.TabIndex = 22
        Me.LBLTrim2.Text = "To Trim"
        Me.LBLTrim2.Visible = False
        '
        'LBLTrim1
        '
        Me.LBLTrim1.AutoSize = True
        Me.LBLTrim1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTrim1.Location = New System.Drawing.Point(28, 183)
        Me.LBLTrim1.Name = "LBLTrim1"
        Me.LBLTrim1.Size = New System.Drawing.Size(124, 19)
        Me.LBLTrim1.TabIndex = 21
        Me.LBLTrim1.Text = "Trimmed Sentence:"
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSubmit.Location = New System.Drawing.Point(535, 8)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(75, 33)
        Me.BTNSubmit.TabIndex = 20
        Me.BTNSubmit.Text = "Submit"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'LBLUpper2
        '
        Me.LBLUpper2.AutoSize = True
        Me.LBLUpper2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUpper2.Location = New System.Drawing.Point(195, 128)
        Me.LBLUpper2.Name = "LBLUpper2"
        Me.LBLUpper2.Size = New System.Drawing.Size(68, 19)
        Me.LBLUpper2.TabIndex = 19
        Me.LBLUpper2.Text = "To Upper"
        Me.LBLUpper2.Visible = False
        '
        'LBLLower2
        '
        Me.LBLLower2.AutoSize = True
        Me.LBLLower2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLower2.Location = New System.Drawing.Point(195, 79)
        Me.LBLLower2.Name = "LBLLower2"
        Me.LBLLower2.Size = New System.Drawing.Size(69, 19)
        Me.LBLLower2.TabIndex = 18
        Me.LBLLower2.Text = "To Lower"
        Me.LBLLower2.Visible = False
        '
        'TXTInput
        '
        Me.TXTInput.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTInput.Location = New System.Drawing.Point(199, 12)
        Me.TXTInput.Name = "TXTInput"
        Me.TXTInput.Size = New System.Drawing.Size(297, 26)
        Me.TXTInput.TabIndex = 17
        '
        'LBLUpper1
        '
        Me.LBLUpper1.AutoSize = True
        Me.LBLUpper1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUpper1.Location = New System.Drawing.Point(29, 128)
        Me.LBLUpper1.Name = "LBLUpper1"
        Me.LBLUpper1.Size = New System.Drawing.Size(102, 19)
        Me.LBLUpper1.TabIndex = 16
        Me.LBLUpper1.Text = "To UpperCase:"
        '
        'LBLLower1
        '
        Me.LBLLower1.AutoSize = True
        Me.LBLLower1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLower1.Location = New System.Drawing.Point(28, 79)
        Me.LBLLower1.Name = "LBLLower1"
        Me.LBLLower1.Size = New System.Drawing.Size(103, 19)
        Me.LBLLower1.TabIndex = 15
        Me.LBLLower1.Text = "To LowerCase:"
        '
        'LBLInput
        '
        Me.LBLInput.AutoSize = True
        Me.LBLInput.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLInput.Location = New System.Drawing.Point(28, 15)
        Me.LBLInput.Name = "LBLInput"
        Me.LBLInput.Size = New System.Drawing.Size(106, 19)
        Me.LBLInput.TabIndex = 14
        Me.LBLInput.Text = "Enter Your Text:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(280, 346)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(330, 19)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click Here to Learn About Manipulating 2 Strings"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 374)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LBLOne2)
        Me.Controls.Add(Me.LBLOne1)
        Me.Controls.Add(Me.LBLChar2)
        Me.Controls.Add(Me.LBLChar1)
        Me.Controls.Add(Me.LBLTrim2)
        Me.Controls.Add(Me.LBLTrim1)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.LBLUpper2)
        Me.Controls.Add(Me.LBLLower2)
        Me.Controls.Add(Me.TXTInput)
        Me.Controls.Add(Me.LBLUpper1)
        Me.Controls.Add(Me.LBLLower1)
        Me.Controls.Add(Me.LBLInput)
        Me.Name = "Form1"
        Me.Text = "SINGLE STRING MANIPULATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLOne2 As Label
    Friend WithEvents LBLOne1 As Label
    Friend WithEvents LBLChar2 As Label
    Friend WithEvents LBLChar1 As Label
    Friend WithEvents LBLTrim2 As Label
    Friend WithEvents LBLTrim1 As Label
    Friend WithEvents BTNSubmit As Button
    Friend WithEvents LBLUpper2 As Label
    Friend WithEvents LBLLower2 As Label
    Friend WithEvents TXTInput As TextBox
    Friend WithEvents LBLUpper1 As Label
    Friend WithEvents LBLLower1 As Label
    Friend WithEvents LBLInput As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
