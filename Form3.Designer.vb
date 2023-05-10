<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        auther_name = New TextBox()
        book_name = New TextBox()
        book_des = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(112, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 21)
        Label1.TabIndex = 0
        Label1.Text = "Auther Name  :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightGray
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(112, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 21)
        Label2.TabIndex = 1
        Label2.Text = "Book Name   : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightGray
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(112, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 21)
        Label3.TabIndex = 2
        Label3.Text = "Book Description :"
        ' 
        ' auther_name
        ' 
        auther_name.Location = New Point(262, 93)
        auther_name.Name = "auther_name"
        auther_name.Size = New Size(423, 23)
        auther_name.TabIndex = 3
        ' 
        ' book_name
        ' 
        book_name.Location = New Point(262, 143)
        book_name.Name = "book_name"
        book_name.Size = New Size(423, 23)
        book_name.TabIndex = 4
        ' 
        ' book_des
        ' 
        book_des.Location = New Point(262, 201)
        book_des.Name = "book_des"
        book_des.Size = New Size(423, 23)
        book_des.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(334, 285)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 42)
        Button1.TabIndex = 6
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(book_des)
        Controls.Add(book_name)
        Controls.Add(auther_name)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents auther_name As TextBox
    Friend WithEvents book_name As TextBox
    Friend WithEvents book_des As TextBox
    Friend WithEvents Button1 As Button
End Class
