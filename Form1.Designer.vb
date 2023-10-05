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
        btnClose = New Button()
        btnSum = New Button()
        lblFirstNumber = New Label()
        lblSecondNumber = New Label()
        txtFirstNumber = New TextBox()
        txtSum = New TextBox()
        txtSecondNumber = New TextBox()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(371, 357)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSum
        ' 
        btnSum.Location = New Point(260, 273)
        btnSum.Name = "btnSum"
        btnSum.Size = New Size(94, 29)
        btnSum.TabIndex = 0
        btnSum.Text = "Sum"
        btnSum.UseVisualStyleBackColor = True
        ' 
        ' lblFirstNumber
        ' 
        lblFirstNumber.AutoSize = True
        lblFirstNumber.Location = New Point(260, 131)
        lblFirstNumber.Name = "lblFirstNumber"
        lblFirstNumber.Size = New Size(94, 20)
        lblFirstNumber.TabIndex = 1
        lblFirstNumber.Text = "First Number"
        ' 
        ' lblSecondNumber
        ' 
        lblSecondNumber.AutoSize = True
        lblSecondNumber.Location = New Point(260, 199)
        lblSecondNumber.Name = "lblSecondNumber"
        lblSecondNumber.Size = New Size(116, 20)
        lblSecondNumber.TabIndex = 1
        lblSecondNumber.Text = "Second Number"
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Location = New Point(458, 128)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(125, 27)
        txtFirstNumber.TabIndex = 2
        ' 
        ' txtSum
        ' 
        txtSum.Location = New Point(458, 273)
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(125, 27)
        txtSum.TabIndex = 2
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Location = New Point(458, 199)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(125, 27)
        txtSecondNumber.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtSecondNumber)
        Controls.Add(txtSum)
        Controls.Add(txtFirstNumber)
        Controls.Add(lblSecondNumber)
        Controls.Add(lblFirstNumber)
        Controls.Add(btnSum)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Sub Procedures"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents lblSecondNumber As Label
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents txtSum As TextBox
    Friend WithEvents txtSecondNumber As TextBox
End Class
