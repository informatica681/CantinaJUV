<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        BtReiniciarHisto = New Button()
        PictureBox2 = New PictureBox()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        BtVolver = New Button()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 36F)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(132, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(567, 71)
        Label1.TabIndex = 64
        Label1.Text = "HISTORIAL DE VENTA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        GroupBox1.Controls.Add(BtReiniciarHisto)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(BtVolver)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(727, 481)
        GroupBox1.TabIndex = 62
        GroupBox1.TabStop = False
        ' 
        ' BtReiniciarHisto
        ' 
        BtReiniciarHisto.Font = New Font("Arial Rounded MT Bold", 18F)
        BtReiniciarHisto.Location = New Point(96, 341)
        BtReiniciarHisto.Name = "BtReiniciarHisto"
        BtReiniciarHisto.Size = New Size(149, 65)
        BtReiniciarHisto.TabIndex = 2
        BtReiniciarHisto.Text = "Reiniciar historial"
        BtReiniciarHisto.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.Login1
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(6, 419)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(218, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 61
        PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Rounded MT Bold", 15.75F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(83, 121)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 32)
        ComboBox1.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(137, 333)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(155, 23)
        DateTimePicker1.TabIndex = 59
        DateTimePicker1.Visible = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.IndianRed
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.DarkRed
        DataGridView1.Location = New Point(330, 27)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.Size = New Size(338, 383)
        DataGridView1.TabIndex = 47
        ' 
        ' BtVolver
        ' 
        BtVolver.Font = New Font("Arial Rounded MT Bold", 18F)
        BtVolver.Location = New Point(519, 419)
        BtVolver.Name = "BtVolver"
        BtVolver.Size = New Size(149, 34)
        BtVolver.TabIndex = 3
        BtVolver.Text = "<< Volver"
        BtVolver.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 27.75F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(65, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 86)
        Label2.TabIndex = 54
        Label2.Text = "Seleccione " & vbCrLf & "una fecha"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 65
        PictureBox3.TabStop = False
        ' 
        ' Historial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(757, 572)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Historial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Historial"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtReiniciarHisto As Button
End Class
