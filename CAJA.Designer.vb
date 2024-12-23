<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAJA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAJA))
        GroupBox1 = New GroupBox()
        BtIngresar = New Button()
        PictureBox2 = New PictureBox()
        BtHistorial = New Button()
        BtReiniciar = New Button()
        TBMontoFinal = New TextBox()
        Label4 = New Label()
        TbMontoinicial = New TextBox()
        BtVolver = New Button()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        PictureBox3 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        GroupBox1.Controls.Add(BtIngresar)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(BtHistorial)
        GroupBox1.Controls.Add(BtReiniciar)
        GroupBox1.Controls.Add(TBMontoFinal)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TbMontoinicial)
        GroupBox1.Controls.Add(BtVolver)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(12, 71)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(720, 499)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' BtIngresar
        ' 
        BtIngresar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtIngresar.Location = New Point(86, 169)
        BtIngresar.Name = "BtIngresar"
        BtIngresar.Size = New Size(139, 45)
        BtIngresar.TabIndex = 2
        BtIngresar.Text = "Ingresar"
        BtIngresar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.Login1
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(7, 433)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(218, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 60
        PictureBox2.TabStop = False
        ' 
        ' BtHistorial
        ' 
        BtHistorial.Font = New Font("Arial Rounded MT Bold", 18F)
        BtHistorial.Location = New Point(80, 360)
        BtHistorial.Name = "BtHistorial"
        BtHistorial.Size = New Size(139, 45)
        BtHistorial.TabIndex = 5
        BtHistorial.Text = "Historial"
        BtHistorial.UseVisualStyleBackColor = True
        ' 
        ' BtReiniciar
        ' 
        BtReiniciar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtReiniciar.Location = New Point(54, 309)
        BtReiniciar.Name = "BtReiniciar"
        BtReiniciar.Size = New Size(192, 45)
        BtReiniciar.TabIndex = 4
        BtReiniciar.Text = "Reiniciar día"
        BtReiniciar.UseVisualStyleBackColor = True
        ' 
        ' TBMontoFinal
        ' 
        TBMontoFinal.Enabled = False
        TBMontoFinal.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TBMontoFinal.Location = New Point(92, 271)
        TBMontoFinal.Name = "TBMontoFinal"
        TBMontoFinal.Size = New Size(127, 32)
        TBMontoFinal.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 18F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(86, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 28)
        Label4.TabIndex = 11
        Label4.Text = "Monto final"
        ' 
        ' TbMontoinicial
        ' 
        TbMontoinicial.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbMontoinicial.Location = New Point(92, 131)
        TbMontoinicial.Name = "TbMontoinicial"
        TbMontoinicial.Size = New Size(127, 32)
        TbMontoinicial.TabIndex = 1
        ' 
        ' BtVolver
        ' 
        BtVolver.Font = New Font("Arial Rounded MT Bold", 18F)
        BtVolver.Location = New Point(577, 450)
        BtVolver.Name = "BtVolver"
        BtVolver.Size = New Size(138, 36)
        BtVolver.TabIndex = 6
        BtVolver.Text = "<< Volver"
        BtVolver.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 27.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(301, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(413, 43)
        Label2.TabIndex = 2
        Label2.Text = "Listado de Venta Final"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(74, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 28)
        Label1.TabIndex = 1
        Label1.Text = "Monto Inicial"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.IndianRed
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Enabled = False
        DataGridView1.GridColor = Color.Maroon
        DataGridView1.Location = New Point(343, 96)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(327, 342)
        DataGridView1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 36F)
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label3.Location = New Point(235, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(281, 71)
        Label3.TabIndex = 62
        Label3.Text = "RESUMEN"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Arial Rounded MT Bold", 11.25F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(536, 38)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(155, 23)
        DateTimePicker1.TabIndex = 63
        DateTimePicker1.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(16, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 63
        PictureBox3.TabStop = False
        ' 
        ' CAJA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(742, 577)
        Controls.Add(PictureBox3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CAJA"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CAJA"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbMontoinicial As TextBox
    Friend WithEvents BtVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TBMontoFinal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtReiniciar As Button
    Friend WithEvents BtHistorial As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtIngresar As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
