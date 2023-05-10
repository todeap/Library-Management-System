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
        components = New ComponentModel.Container()
        SearchBox = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        delete = New Button()
        BookBindingSource = New BindingSource(components)
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(BookBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SearchBox
        ' 
        SearchBox.AccessibleDescription = ""
        SearchBox.Location = New Point(32, 65)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(473, 23)
        SearchBox.TabIndex = 0
        SearchBox.Text = "Search book title or Auther name"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(544, 65)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 23)
        Button1.TabIndex = 1
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Chocolate
        Button2.Location = New Point(62, 408)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 36)
        Button2.TabIndex = 3
        Button2.Text = "Add Book"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.OliveDrab
        Button3.Location = New Point(288, 408)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 36)
        Button3.TabIndex = 4
        Button3.Text = "Edit Book"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' delete
        ' 
        delete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        delete.ForeColor = Color.DarkRed
        delete.Location = New Point(519, 408)
        delete.Name = "delete"
        delete.Size = New Size(79, 36)
        delete.TabIndex = 5
        delete.Text = "Delete Book"
        delete.UseVisualStyleBackColor = True
        ' 
        ' BookBindingSource
        ' 
        BookBindingSource.DataSource = GetType(Book)
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(32, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(614, 263)
        DataGridView1.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.FillWeight = 150F
        Column1.HeaderText = "Book Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Auther Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.FillWeight = 200F
        Column3.HeaderText = "Description"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(716, 470)
        Controls.Add(DataGridView1)
        Controls.Add(delete)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(SearchBox)
        Name = "Form1"
        Text = "Form1"
        CType(BookBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents delete As Button
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
