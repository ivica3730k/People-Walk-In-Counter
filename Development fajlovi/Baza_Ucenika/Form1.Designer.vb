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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.showall_btn = New System.Windows.Forms.Button()
        Me.srch_btn = New System.Windows.Forms.Button()
        Me.savetoxml_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(296, 229)
        Me.DataGridView1.TabIndex = 34
        '
        'showall_btn
        '
        Me.showall_btn.Location = New System.Drawing.Point(12, 274)
        Me.showall_btn.Name = "showall_btn"
        Me.showall_btn.Size = New System.Drawing.Size(296, 23)
        Me.showall_btn.TabIndex = 35
        Me.showall_btn.Text = "Prikaži sve datume"
        Me.showall_btn.UseVisualStyleBackColor = True
        '
        'srch_btn
        '
        Me.srch_btn.Location = New System.Drawing.Point(229, 245)
        Me.srch_btn.Name = "srch_btn"
        Me.srch_btn.Size = New System.Drawing.Size(79, 23)
        Me.srch_btn.TabIndex = 38
        Me.srch_btn.Text = "Traži"
        Me.srch_btn.UseVisualStyleBackColor = True
        '
        'savetoxml_btn
        '
        Me.savetoxml_btn.Location = New System.Drawing.Point(12, 331)
        Me.savetoxml_btn.Name = "savetoxml_btn"
        Me.savetoxml_btn.Size = New System.Drawing.Size(296, 23)
        Me.savetoxml_btn.TabIndex = 39
        Me.savetoxml_btn.Text = "Spremi u tablicu"
        Me.savetoxml_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Sortiranje:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.ComboBox1.Location = New System.Drawing.Point(72, 304)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 43
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 248)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 359)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savetoxml_btn)
        Me.Controls.Add(Me.srch_btn)
        Me.Controls.Add(Me.showall_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Brojač posjeta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents showall_btn As Button
    Friend WithEvents srch_btn As Button
    Friend WithEvents savetoxml_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
