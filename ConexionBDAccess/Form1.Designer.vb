<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconexion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgtabla = New System.Windows.Forms.DataGridView()
        Me.btnmostrar = New System.Windows.Forms.Button()
        CType(Me.dgtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conexion a BD con Access"
        '
        'dgtabla
        '
        Me.dgtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtabla.Location = New System.Drawing.Point(61, 67)
        Me.dgtabla.Name = "dgtabla"
        Me.dgtabla.RowHeadersWidth = 51
        Me.dgtabla.RowTemplate.Height = 24
        Me.dgtabla.Size = New System.Drawing.Size(680, 288)
        Me.dgtabla.TabIndex = 1
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(311, 375)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(150, 23)
        Me.btnmostrar.TabIndex = 2
        Me.btnmostrar.Text = "Mostrar Tabla"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'frmconexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.dgtabla)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmconexion"
        Me.Text = "Form1"
        CType(Me.dgtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgtabla As DataGridView
    Friend WithEvents btnmostrar As Button
End Class
