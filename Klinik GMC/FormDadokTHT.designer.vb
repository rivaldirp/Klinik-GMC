<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDadokTHT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDadokTHT))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtPukul = New System.Windows.Forms.ComboBox()
        Me.TxtKeluh = New System.Windows.Forms.TextBox()
        Me.TxtUpas = New System.Windows.Forms.TextBox()
        Me.TxtNapas = New System.Windows.Forms.TextBox()
        Me.TxtNadok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnIdDpu = New System.Windows.Forms.ColumnHeader()
        Me.ColumnNamaDpu = New System.Windows.Forms.ColumnHeader()
        Me.ColumnNoDpu = New System.Windows.Forms.ColumnHeader()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(228, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Dokter Spesialis THT"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(14, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(634, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtPukul
        '
        Me.TxtPukul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtPukul.FormattingEnabled = True
        Me.TxtPukul.Items.AddRange(New Object() {"07.00-08.00", "08.00-09.00", "09.00-10.00", "10.00-11.00", "11.00-12.00", "12.00-13.00", "13.00-14.00", "14.00-15.00"})
        Me.TxtPukul.Location = New System.Drawing.Point(256, 339)
        Me.TxtPukul.Name = "TxtPukul"
        Me.TxtPukul.Size = New System.Drawing.Size(155, 23)
        Me.TxtPukul.TabIndex = 23
        '
        'TxtKeluh
        '
        Me.TxtKeluh.Location = New System.Drawing.Point(256, 310)
        Me.TxtKeluh.Name = "TxtKeluh"
        Me.TxtKeluh.Size = New System.Drawing.Size(295, 23)
        Me.TxtKeluh.TabIndex = 22
        '
        'TxtUpas
        '
        Me.TxtUpas.Location = New System.Drawing.Point(256, 281)
        Me.TxtUpas.Name = "TxtUpas"
        Me.TxtUpas.Size = New System.Drawing.Size(295, 23)
        Me.TxtUpas.TabIndex = 21
        '
        'TxtNapas
        '
        Me.TxtNapas.Location = New System.Drawing.Point(256, 252)
        Me.TxtNapas.Name = "TxtNapas"
        Me.TxtNapas.Size = New System.Drawing.Size(295, 23)
        Me.TxtNapas.TabIndex = 20
        '
        'TxtNadok
        '
        Me.TxtNadok.Location = New System.Drawing.Point(256, 223)
        Me.TxtNadok.Name = "TxtNadok"
        Me.TxtNadok.ReadOnly = True
        Me.TxtNadok.Size = New System.Drawing.Size(295, 23)
        Me.TxtNadok.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Pukul"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Keluhan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Usia Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nama Dokter"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnIdDpu, Me.ColumnNamaDpu, Me.ColumnNoDpu})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(14, 67)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(674, 126)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnIdDpu
        '
        Me.ColumnIdDpu.Text = "Id "
        Me.ColumnIdDpu.Width = 35
        '
        'ColumnNamaDpu
        '
        Me.ColumnNamaDpu.Text = "Nama Dokter"
        Me.ColumnNamaDpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnNamaDpu.Width = 400
        '
        'ColumnNoDpu
        '
        Me.ColumnNoDpu.Text = "No. Telp"
        Me.ColumnNoDpu.Width = 280
        '
        'FormDadokTHT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(700, 422)
        Me.Controls.Add(Me.TxtPukul)
        Me.Controls.Add(Me.TxtKeluh)
        Me.Controls.Add(Me.TxtUpas)
        Me.Controls.Add(Me.TxtNapas)
        Me.Controls.Add(Me.TxtNadok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDadokTHT"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtPukul As ComboBox
    Friend WithEvents TxtKeluh As TextBox
    Friend WithEvents TxtUpas As TextBox
    Friend WithEvents TxtNapas As TextBox
    Friend WithEvents TxtNadok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnIdDpu As ColumnHeader
    Friend WithEvents ColumnNamaDpu As ColumnHeader
    Friend WithEvents ColumnNoDpu As ColumnHeader
End Class
