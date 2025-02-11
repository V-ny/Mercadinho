Public Class Form1

    Dim posicao As Integer = 1
    Dim quantprod As Integer = 5
    Dim codigo(quantprod) As String
    Dim cdescricao(quantprod) As String
    Dim preco(quantprod) As String
    Dim achou As Boolean


    Private Sub atualizatela()

        tbposicao.Text = posicao
        tbcodigo.Text = codigo(posicao)
        tbdescricao.Text = cdescricao(posicao)
        tbpreco.Text = preco(posicao)

    End Sub

    Private Sub destrava(ByVal ordem As Boolean)

        tbcodigo.Enabled = ordem
        tbdescricao.Enabled = ordem
        tbpreco.Enabled = ordem
        btnsalvar.Enabled = ordem
        btnnovo.Enabled = Not (ordem)
        btneditar.Enabled = Not (ordem)
        btndeletar.Enabled = Not (ordem)
        btnanterior.Enabled = Not (ordem)
        btnprox.Enabled = Not (ordem)

    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click

        destrava(False)
        codigo(posicao) = tbcodigo.Text
        cdescricao(posicao) = tbdescricao.Text
        preco(posicao) = tbpreco.Text

    End Sub

    Private Sub btdeletar_Click(sender As Object, e As EventArgs) Handles btndeletar.Click

        If MsgBox("Tem certeza?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            tbcodigo.Text = ""
            tbdescricao.Text = ""
            tbpreco.Text = ""
            codigo(posicao) = ""
            cdescricao(posicao) = ""
            preco(posicao) = ""

        End If

    End Sub

    Friend WithEvents Label5 As Label

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        destrava(True)

    End Sub

    Private Sub btnprox_Click(sender As Object, e As EventArgs) Handles btnprox.Click

        If posicao = quantprod Then
            posicao = 1
        Else
            posicao = posicao + 1
        End If
        atualizatela()

    End Sub
    Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click

        If posicao = 1 Then
            posicao = quantprod
        Else
            posicao = posicao - 1
        End If
        atualizatela()

    End Sub
    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click

        For contador As Integer = 1 To quantprod
            If achou = False Then
                If codigo(contador) = "" Then
                    achou = True
                    posicao = contador
                End If
            End If
        Next
        If achou = False Then
            MsgBox("Não há espaço em memória")
        Else
            atualizatela()
            destrava(True)
        End If
        achou = False

    End Sub



End Class
