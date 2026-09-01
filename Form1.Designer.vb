<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblnumber1 = New Label()
        lblnumber2 = New Label()
        txtnumber1 = New TextBox()
        txtnumber2 = New TextBox()
        btnadd = New Button()
        btnsubtract = New Button()
        btnmultiply = New Button()
        btndivision = New Button()
        SuspendLayout()
        ' 
        ' lblnumber1
        ' 
        lblnumber1.AutoSize = True
        lblnumber1.Location = New Point(56, 31)
        lblnumber1.Name = "lblnumber1"
        lblnumber1.Size = New Size(60, 15)
        lblnumber1.TabIndex = 0
        lblnumber1.Text = "Number 1"
        ' 
        ' lblnumber2
        ' 
        lblnumber2.AutoSize = True
        lblnumber2.Location = New Point(56, 98)
        lblnumber2.Name = "lblnumber2"
        lblnumber2.Size = New Size(60, 15)
        lblnumber2.TabIndex = 1
        lblnumber2.Text = "Number 2"
        ' 
        ' txtnumber1
        ' 
        txtnumber1.Location = New Point(56, 59)
        txtnumber1.Name = "txtnumber1"
        txtnumber1.Size = New Size(100, 23)
        txtnumber1.TabIndex = 2
        ' 
        ' txtnumber2
        ' 
        txtnumber2.Location = New Point(56, 128)
        txtnumber2.Name = "txtnumber2"
        txtnumber2.Size = New Size(100, 23)
        txtnumber2.TabIndex = 3
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(208, 59)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 23)
        btnadd.TabIndex = 4
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnsubtract
        ' 
        btnsubtract.Location = New Point(208, 127)
        btnsubtract.Name = "btnsubtract"
        btnsubtract.Size = New Size(75, 23)
        btnsubtract.TabIndex = 5
        btnsubtract.Text = "SUBTRACT"
        btnsubtract.UseVisualStyleBackColor = True
        ' 
        ' btnmultiply
        ' 
        btnmultiply.Location = New Point(329, 58)
        btnmultiply.Name = "btnmultiply"
        btnmultiply.Size = New Size(75, 23)
        btnmultiply.TabIndex = 6
        btnmultiply.Text = "MULTIPLY"
        btnmultiply.UseVisualStyleBackColor = True
        ' 
        ' btndivision
        ' 
        btndivision.Location = New Point(329, 127)
        btndivision.Name = "btndivision"
        btndivision.Size = New Size(75, 23)
        btndivision.TabIndex = 7
        btndivision.Text = "DIVISION"
        btndivision.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btndivision)
        Controls.Add(btnmultiply)
        Controls.Add(btnsubtract)
        Controls.Add(btnadd)
        Controls.Add(txtnumber2)
        Controls.Add(txtnumber1)
        Controls.Add(lblnumber2)
        Controls.Add(lblnumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblnumber1 As Label
    Friend WithEvents lblnumber2 As Label
    Friend WithEvents txtnumber1 As TextBox
    Friend WithEvents txtnumber2 As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsubtract As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btndivision As Button

End Class
