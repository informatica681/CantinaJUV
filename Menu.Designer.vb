<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        PRUEBA = New Button()
        BtProductos = New Button()
        BtResumen = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        BtSalir = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(142, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(-5, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(797, 100)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 36F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(104, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(400, 71)
        Label2.TabIndex = 0
        Label2.Text = "Menú principal"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(PRUEBA)
        Panel2.Controls.Add(BtProductos)
        Panel2.Controls.Add(BtResumen)
        Panel2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(-5, 98)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(729, 73)
        Panel2.TabIndex = 2
        ' 
        ' PRUEBA
        ' 
        PRUEBA.BackColor = Color.White
        PRUEBA.Font = New Font("Arial Rounded MT Bold", 20.25F)
        PRUEBA.Location = New Point(225, 9)
        PRUEBA.Name = "PRUEBA"
        PRUEBA.Size = New Size(137, 51)
        PRUEBA.TabIndex = 2
        PRUEBA.Text = "VENTA"
        PRUEBA.UseVisualStyleBackColor = False
        ' 
        ' BtProductos
        ' 
        BtProductos.BackColor = Color.White
        BtProductos.Font = New Font("Arial Rounded MT Bold", 20.25F)
        BtProductos.Location = New Point(369, 9)
        BtProductos.Name = "BtProductos"
        BtProductos.Size = New Size(204, 51)
        BtProductos.TabIndex = 3
        BtProductos.Text = "PRODUCTOS"
        BtProductos.UseVisualStyleBackColor = False
        ' 
        ' BtResumen
        ' 
        BtResumen.BackColor = Color.White
        BtResumen.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtResumen.Location = New Point(40, 9)
        BtResumen.Name = "BtResumen"
        BtResumen.Size = New Size(179, 51)
        BtResumen.TabIndex = 1
        BtResumen.Text = "RESUMEN"
        BtResumen.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.loginNe
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(2, 481)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(212, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 60
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(156, 177)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 310)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' BtSalir
        ' 
        BtSalir.BackColor = Color.White
        BtSalir.Font = New Font("Arial Rounded MT Bold", 20.25F)
        BtSalir.Location = New Point(461, 479)
        BtSalir.Name = "BtSalir"
        BtSalir.Size = New Size(137, 51)
        BtSalir.TabIndex = 4
        BtSalir.Text = "SALIR"
        BtSalir.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(608, 536)
        Controls.Add(BtSalir)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtProductos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtResumen As Button
    Friend WithEvents PRUEBA As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtSalir As Button
End Class
