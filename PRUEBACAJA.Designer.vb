<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRUEBACAJA
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRUEBACAJA))
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        TbCant = New TextBox()
        BtAnotar = New Button()
        ComboBox1 = New ComboBox()
        ProductosBindingSource = New BindingSource(components)
        TbPrecio = New TextBox()
        TbSubTotal = New TextBox()
        BtMenos = New Button()
        BtMas = New Button()
        DataGridView1 = New DataGridView()
        TbNombre = New TextBox()
        BtImprimir = New Button()
        TbTOTAL = New TextBox()
        LbNom = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BtVolver = New Button()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        BtVaciar = New Button()
        TbVuelto = New TextBox()
        Label6 = New Label()
        TbImporte = New TextBox()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        CType(ProductosBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' TbCant
        ' 
        TbCant.Enabled = False
        TbCant.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbCant.Location = New Point(306, 78)
        TbCant.Name = "TbCant"
        TbCant.Size = New Size(61, 32)
        TbCant.TabIndex = 10
        ' 
        ' BtAnotar
        ' 
        BtAnotar.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtAnotar.Location = New Point(260, 216)
        BtAnotar.Name = "BtAnotar"
        BtAnotar.Size = New Size(148, 40)
        BtAnotar.TabIndex = 11
        BtAnotar.Text = "Comanda"
        BtAnotar.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(44, 78)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 32)
        ComboBox1.TabIndex = 42
        ' 
        ' ProductosBindingSource
        ' 
        ProductosBindingSource.DataSource = GetType(Productos)
        ' 
        ' TbPrecio
        ' 
        TbPrecio.Enabled = False
        TbPrecio.Location = New Point(104, 2)
        TbPrecio.Name = "TbPrecio"
        TbPrecio.Size = New Size(61, 23)
        TbPrecio.TabIndex = 43
        TbPrecio.Visible = False
        ' 
        ' TbSubTotal
        ' 
        TbSubTotal.Enabled = False
        TbSubTotal.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbSubTotal.Location = New Point(260, 164)
        TbSubTotal.Name = "TbSubTotal"
        TbSubTotal.Size = New Size(148, 32)
        TbSubTotal.TabIndex = 44
        ' 
        ' BtMenos
        ' 
        BtMenos.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtMenos.Location = New Point(260, 77)
        BtMenos.Name = "BtMenos"
        BtMenos.Size = New Size(39, 33)
        BtMenos.TabIndex = 45
        BtMenos.Text = "-"
        BtMenos.TextAlign = ContentAlignment.BottomCenter
        BtMenos.UseVisualStyleBackColor = True
        ' 
        ' BtMas
        ' 
        BtMas.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtMas.Location = New Point(373, 78)
        BtMas.Name = "BtMas"
        BtMas.Size = New Size(35, 32)
        BtMas.TabIndex = 46
        BtMas.Text = "+"
        BtMas.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.IndianRed
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Enabled = False
        DataGridView1.GridColor = Color.Maroon
        DataGridView1.Location = New Point(455, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(367, 385)
        DataGridView1.TabIndex = 47
        ' 
        ' TbNombre
        ' 
        TbNombre.Enabled = False
        TbNombre.Location = New Point(37, 2)
        TbNombre.Name = "TbNombre"
        TbNombre.Size = New Size(61, 23)
        TbNombre.TabIndex = 48
        TbNombre.Visible = False
        ' 
        ' BtImprimir
        ' 
        BtImprimir.BackgroundImage = My.Resources.Resources.IMpresora
        BtImprimir.BackgroundImageLayout = ImageLayout.Zoom
        BtImprimir.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtImprimir.Location = New Point(624, 544)
        BtImprimir.Name = "BtImprimir"
        BtImprimir.Size = New Size(89, 47)
        BtImprimir.TabIndex = 49
        BtImprimir.UseVisualStyleBackColor = True
        ' 
        ' TbTOTAL
        ' 
        TbTOTAL.Enabled = False
        TbTOTAL.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TbTOTAL.Location = New Point(624, 413)
        TbTOTAL.Name = "TbTOTAL"
        TbTOTAL.Size = New Size(198, 50)
        TbTOTAL.TabIndex = 50
        ' 
        ' LbNom
        ' 
        LbNom.AutoSize = True
        LbNom.Font = New Font("Arial Rounded MT Bold", 18F)
        LbNom.ForeColor = Color.White
        LbNom.Location = New Point(52, 47)
        LbNom.Name = "LbNom"
        LbNom.Size = New Size(152, 28)
        LbNom.TabIndex = 53
        LbNom.Text = "PRODUCTO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 18F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(259, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 28)
        Label2.TabIndex = 54
        Label2.Text = "SUBTOTAL"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(457, 416)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 43)
        Label3.TabIndex = 55
        Label3.Text = "TOTAL $"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 18F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(259, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 28)
        Label4.TabIndex = 57
        Label4.Text = "CANTIDAD"
        ' 
        ' BtVolver
        ' 
        BtVolver.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtVolver.Location = New Point(624, 608)
        BtVolver.Name = "BtVolver"
        BtVolver.Size = New Size(198, 34)
        BtVolver.TabIndex = 58
        BtVolver.Text = "<< Volver"
        BtVolver.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(BtVaciar)
        GroupBox1.Controls.Add(TbVuelto)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TbImporte)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(BtVolver)
        GroupBox1.Controls.Add(TbCant)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(BtAnotar)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TbPrecio)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TbSubTotal)
        GroupBox1.Controls.Add(LbNom)
        GroupBox1.Controls.Add(BtMenos)
        GroupBox1.Controls.Add(TbTOTAL)
        GroupBox1.Controls.Add(BtMas)
        GroupBox1.Controls.Add(BtImprimir)
        GroupBox1.Controls.Add(TbNombre)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(12, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(886, 647)
        GroupBox1.TabIndex = 59
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(718, 544)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 47)
        Button1.TabIndex = 66
        Button1.Text = "SALIR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtVaciar
        ' 
        BtVaciar.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtVaciar.Location = New Point(260, 341)
        BtVaciar.Name = "BtVaciar"
        BtVaciar.Size = New Size(148, 65)
        BtVaciar.TabIndex = 65
        BtVaciar.Text = "Limpiar Comanda"
        BtVaciar.UseVisualStyleBackColor = True
        ' 
        ' TbVuelto
        ' 
        TbVuelto.Enabled = False
        TbVuelto.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbVuelto.Location = New Point(624, 507)
        TbVuelto.Name = "TbVuelto"
        TbVuelto.Size = New Size(198, 32)
        TbVuelto.TabIndex = 64
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 18F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(492, 510)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 28)
        Label6.TabIndex = 63
        Label6.Text = "VUELTO $ "
        ' 
        ' TbImporte
        ' 
        TbImporte.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbImporte.Location = New Point(624, 469)
        TbImporte.Name = "TbImporte"
        TbImporte.Size = New Size(198, 32)
        TbImporte.TabIndex = 62
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 18F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(480, 470)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 28)
        Label5.TabIndex = 61
        Label5.Text = "IMPORTE $"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.Login1
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(6, 590)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(218, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 59
        PictureBox2.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Arial Rounded MT Bold", 11.25F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(725, 31)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(155, 23)
        DateTimePicker1.TabIndex = 59
        DateTimePicker1.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(343, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 71)
        Label1.TabIndex = 61
        Label1.Text = "VENTA"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(13, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 62
        PictureBox3.TabStop = False
        ' 
        ' PRUEBACAJA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(910, 738)
        Controls.Add(PictureBox3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PRUEBACAJA"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PRUEBACAJA"
        CType(ProductosBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents TbHAM As TextBox
    Friend WithEvents TbSODA As TextBox
    Friend WithEvents TbPapaFrita As TextBox
    Friend WithEvents TbCant As TextBox
    Friend WithEvents BtAnotar As Button
    Friend WithEvents TbCantH As TextBox
    Friend WithEvents TbCantS As TextBox
    Friend WithEvents TbCantPF As TextBox
    Friend WithEvents TbCantCH As TextBox
    Friend WithEvents TbChoripan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbCantTF As TextBox
    Friend WithEvents TbTortaFrita As TextBox
    Friend WithEvents TbCantV As TextBox
    Friend WithEvents TbVino As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbCantCe As TextBox
    Friend WithEvents TbCerveza As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbCanAM As TextBox
    Friend WithEvents TbAguaMineral As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbCanSA As TextBox
    Friend WithEvents TbSaborizada As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbCantF As TextBox
    Friend WithEvents TbFernet As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbCantG As TextBox
    Friend WithEvents TbGancia As TextBox
    Friend WithEvents fd As Label
    Friend WithEvents TbCantTGas As TextBox
    Friend WithEvents TbTarroGaseosa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents TbPrecio As TextBox
    Friend WithEvents TbSubTotal As TextBox
    Friend WithEvents BtMenos As Button
    Friend WithEvents BtMas As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents BtImprimir As Button
    Friend WithEvents TbTOTAL As TextBox
    Friend WithEvents LbNom As Label
    Friend WithEvents BtVolver As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TbVuelto As TextBox
    Friend WithEvents TbImporte As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtVaciar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
