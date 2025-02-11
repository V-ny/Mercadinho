<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbposicao = New System.Windows.Forms.TextBox()
        Me.tbcodigo = New System.Windows.Forms.TextBox()
        Me.tbdescricao = New System.Windows.Forms.TextBox()
        Me.tbpreco = New System.Windows.Forms.TextBox()
        Me.btndeletar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btnprox = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(22, 160)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(820, 317)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tbpreco)
        Me.TabPage1.Controls.Add(Me.tbdescricao)
        Me.TabPage1.Controls.Add(Me.tbcodigo)
        Me.TabPage1.Controls.Add(Me.tbposicao)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btndeletar)
        Me.TabPage1.Controls.Add(Me.btneditar)
        Me.TabPage1.Controls.Add(Me.btnsalvar)
        Me.TabPage1.Controls.Add(Me.btnnovo)
        Me.TabPage1.Controls.Add(Me.btnprox)
        Me.TabPage1.Controls.Add(Me.btnanterior)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(812, 291)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(812, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Posição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descrição:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Preço:"
        '
        'tbposicao
        '
        Me.tbposicao.Location = New System.Drawing.Point(292, 149)
        Me.tbposicao.Name = "tbposicao"
        Me.tbposicao.Size = New System.Drawing.Size(220, 20)
        Me.tbposicao.TabIndex = 12
        Me.tbposicao.Text = "1"
        '
        'tbcodigo
        '
        Me.tbcodigo.Location = New System.Drawing.Point(292, 185)
        Me.tbcodigo.Name = "tbcodigo"
        Me.tbcodigo.Size = New System.Drawing.Size(220, 20)
        Me.tbcodigo.TabIndex = 13
        '
        'tbdescricao
        '
        Me.tbdescricao.Location = New System.Drawing.Point(292, 217)
        Me.tbdescricao.Name = "tbdescricao"
        Me.tbdescricao.Size = New System.Drawing.Size(220, 20)
        Me.tbdescricao.TabIndex = 14
        '
        'tbpreco
        '
        Me.tbpreco.Location = New System.Drawing.Point(292, 250)
        Me.tbpreco.Name = "tbpreco"
        Me.tbpreco.Size = New System.Drawing.Size(220, 20)
        Me.tbpreco.TabIndex = 15
        '
        'btndeletar
        '
        Me.btndeletar.BackgroundImage = Global.Mercadinho_do_ViniL.My.Resources.Resources.Ionic_Ionicons_Remove_circle_sharp_512
        Me.btndeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndeletar.Location = New System.Drawing.Point(543, 21)
        Me.btndeletar.Name = "btndeletar"
        Me.btndeletar.Size = New System.Drawing.Size(94, 91)
        Me.btndeletar.TabIndex = 7
        Me.btndeletar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.Mercadinho_do_ViniL.My.Resources.Resources.Pictogrammers_Material_Pen_512
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.Location = New System.Drawing.Point(418, 21)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(94, 91)
        Me.btneditar.TabIndex = 6
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.BackgroundImage = Global.Mercadinho_do_ViniL.My.Resources.Resources.Ionic_Ionicons_Save_512
        Me.btnsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalvar.Location = New System.Drawing.Point(292, 21)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(94, 91)
        Me.btnsalvar.TabIndex = 5
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnnovo
        '
        Me.btnnovo.BackgroundImage = Global.Mercadinho_do_ViniL.My.Resources.Resources.Aniket_Suvarna_Box_Regular_Bx_add_to_queue_512
        Me.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnovo.Location = New System.Drawing.Point(167, 21)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(94, 91)
        Me.btnnovo.TabIndex = 4
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'btnprox
        '
        Me.btnprox.BackgroundImage = Global.Mercadinho_do_ViniL.My.Resources.Resources.icons8_avançar_16
        Me.btnprox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnprox.Location = New System.Drawing.Point(680, 125)
        Me.btnprox.Name = "btnprox"
        Me.btnprox.Size = New System.Drawing.Size(94, 91)
        Me.btnprox.TabIndex = 3
        Me.btnprox.UseVisualStyleBackColor = True
        '
        'btnanterior
        '
        Me.btnanterior.BackgroundImage = Global.Mercadinho_do_ViniL.My.Resources.Resources.icons8_voltar_16
        Me.btnanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnanterior.Location = New System.Drawing.Point(33, 125)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(94, 91)
        Me.btnanterior.TabIndex = 2
        Me.btnanterior.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 111)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 492)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btndeletar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnnovo As Button
    Friend WithEvents btnprox As Button
    Friend WithEvents btnanterior As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbpreco As TextBox
    Friend WithEvents tbdescricao As TextBox
    Friend WithEvents tbcodigo As TextBox
    Friend WithEvents tbposicao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
