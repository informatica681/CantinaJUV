<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        ComboBox1 = New ComboBox()
        BtCancelar = New Button()
        BtGuardar = New Button()
        BtAgregar = New Button()
        BtNoGuardarCam = New Button()
        BtGuardarCamb = New Button()
        BtEliminar = New Button()
        Label5 = New Label()
        Label4 = New Label()
        LbNom = New Label()
        TbPrecioUnit = New TextBox()
        TbCantidad = New TextBox()
        TbNombre = New TextBox()
        BtVolver = New Button()
        BtModificar = New Button()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(BtCancelar)
        GroupBox1.Controls.Add(BtGuardar)
        GroupBox1.Controls.Add(BtAgregar)
        GroupBox1.Controls.Add(BtNoGuardarCam)
        GroupBox1.Controls.Add(BtGuardarCamb)
        GroupBox1.Controls.Add(BtEliminar)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(LbNom)
        GroupBox1.Controls.Add(TbPrecioUnit)
        GroupBox1.Controls.Add(TbCantidad)
        GroupBox1.Controls.Add(TbNombre)
        GroupBox1.Controls.Add(BtVolver)
        GroupBox1.Controls.Add(BtModificar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(18, 103)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1014, 641)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.Login1
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(462, 561)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(249, 68)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 62
        PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Rounded MT Bold", 15.75F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(615, 103)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(236, 38)
        ComboBox1.TabIndex = 1
        ' 
        ' BtCancelar
        ' 
        BtCancelar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtCancelar.Location = New Point(760, 417)
        BtCancelar.Margin = New Padding(3, 4, 3, 4)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(150, 67)
        BtCancelar.TabIndex = 9
        BtCancelar.Text = "Cancelar"
        BtCancelar.UseVisualStyleBackColor = True
        ' 
        ' BtGuardar
        ' 
        BtGuardar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtGuardar.Location = New Point(603, 419)
        BtGuardar.Margin = New Padding(3, 4, 3, 4)
        BtGuardar.Name = "BtGuardar"
        BtGuardar.Size = New Size(147, 67)
        BtGuardar.TabIndex = 8
        BtGuardar.Text = "Guardar"
        BtGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtAgregar
        ' 
        BtAgregar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtAgregar.Location = New Point(514, 355)
        BtAgregar.Margin = New Padding(3, 4, 3, 4)
        BtAgregar.Name = "BtAgregar"
        BtAgregar.Size = New Size(150, 55)
        BtAgregar.TabIndex = 5
        BtAgregar.Text = "Agregar"
        BtAgregar.UseVisualStyleBackColor = True
        ' 
        ' BtNoGuardarCam
        ' 
        BtNoGuardarCam.Font = New Font("Arial Rounded MT Bold", 18F)
        BtNoGuardarCam.Location = New Point(761, 417)
        BtNoGuardarCam.Margin = New Padding(3, 4, 3, 4)
        BtNoGuardarCam.Name = "BtNoGuardarCam"
        BtNoGuardarCam.Size = New Size(146, 91)
        BtNoGuardarCam.TabIndex = 11
        BtNoGuardarCam.Text = "No Guardar Cambios"
        BtNoGuardarCam.UseVisualStyleBackColor = True
        ' 
        ' BtGuardarCamb
        ' 
        BtGuardarCamb.Font = New Font("Arial Rounded MT Bold", 18F)
        BtGuardarCamb.Location = New Point(597, 417)
        BtGuardarCamb.Margin = New Padding(3, 4, 3, 4)
        BtGuardarCamb.Name = "BtGuardarCamb"
        BtGuardarCamb.Size = New Size(158, 91)
        BtGuardarCamb.TabIndex = 10
        BtGuardarCamb.Text = "Guardar Cambios"
        BtGuardarCamb.UseVisualStyleBackColor = True
        ' 
        ' BtEliminar
        ' 
        BtEliminar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtEliminar.Location = New Point(851, 357)
        BtEliminar.Margin = New Padding(3, 4, 3, 4)
        BtEliminar.Name = "BtEliminar"
        BtEliminar.Size = New Size(152, 52)
        BtEliminar.TabIndex = 7
        BtEliminar.Text = "Eliminar"
        BtEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 18F)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(473, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(244, 34)
        Label5.TabIndex = 10
        Label5.Text = "Precio Unitario:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 18F)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(553, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 34)
        Label4.TabIndex = 9
        Label4.Text = "Cantidad:"
        ' 
        ' LbNom
        ' 
        LbNom.AutoSize = True
        LbNom.Font = New Font("Arial Rounded MT Bold", 18F)
        LbNom.ForeColor = SystemColors.ButtonFace
        LbNom.Location = New Point(567, 195)
        LbNom.Name = "LbNom"
        LbNom.Size = New Size(142, 34)
        LbNom.TabIndex = 8
        LbNom.Text = "Nombre:"
        ' 
        ' TbPrecioUnit
        ' 
        TbPrecioUnit.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbPrecioUnit.Location = New Point(699, 291)
        TbPrecioUnit.Margin = New Padding(3, 4, 3, 4)
        TbPrecioUnit.Name = "TbPrecioUnit"
        TbPrecioUnit.Size = New Size(145, 38)
        TbPrecioUnit.TabIndex = 4
        ' 
        ' TbCantidad
        ' 
        TbCantidad.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbCantidad.Location = New Point(699, 240)
        TbCantidad.Margin = New Padding(3, 4, 3, 4)
        TbCantidad.Name = "TbCantidad"
        TbCantidad.Size = New Size(145, 38)
        TbCantidad.TabIndex = 3
        ' 
        ' TbNombre
        ' 
        TbNombre.Font = New Font("Arial Rounded MT Bold", 15.7F)
        TbNombre.Location = New Point(699, 189)
        TbNombre.Margin = New Padding(3, 4, 3, 4)
        TbNombre.Name = "TbNombre"
        TbNombre.Size = New Size(281, 38)
        TbNombre.TabIndex = 2
        ' 
        ' BtVolver
        ' 
        BtVolver.Font = New Font("Arial Rounded MT Bold", 18F)
        BtVolver.Location = New Point(830, 584)
        BtVolver.Margin = New Padding(3, 4, 3, 4)
        BtVolver.Name = "BtVolver"
        BtVolver.Size = New Size(178, 45)
        BtVolver.TabIndex = 12
        BtVolver.Text = "<< Volver"
        BtVolver.UseVisualStyleBackColor = True
        ' 
        ' BtModificar
        ' 
        BtModificar.Font = New Font("Arial Rounded MT Bold", 18F)
        BtModificar.Location = New Point(671, 355)
        BtModificar.Margin = New Padding(3, 4, 3, 4)
        BtModificar.Name = "BtModificar"
        BtModificar.Size = New Size(174, 55)
        BtModificar.TabIndex = 6
        BtModificar.Text = "Modificar"
        BtModificar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(597, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(314, 54)
        Label2.TabIndex = 2
        Label2.Text = "Modificación"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(113, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 54)
        Label1.TabIndex = 1
        Label1.Text = "Productos"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.IndianRed
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.Maroon
        DataGridView1.Location = New Point(24, 75)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(431, 528)
        DataGridView1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(23, 7)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 92)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 36F)
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label3.Location = New Point(237, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(689, 88)
        Label3.TabIndex = 18
        Label3.Text = "ALTA DE PRODUCTOS"
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1054, 767)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Productos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Productos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtVolver As Button
    Friend WithEvents BtModificar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LbNom As Label
    Friend WithEvents TbPrecioUnit As TextBox
    Friend WithEvents TbCantidad As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtAgregar As Button
    Friend WithEvents BtNoGuardarCam As Button
    Friend WithEvents BtGuardarCamb As Button
    Friend WithEvents BtEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
