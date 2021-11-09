Public Class Form1

    Private n As NEntero = New NEntero()
    Private v As Vector = New Vector()
    Private v2 As Vector = New Vector()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n.NEntero()
        v.Vector()
    End Sub


    Private Sub VerificarFibonaciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarFibonaciToolStripMenuItem.Click
        If (n.verificarFibonacci) Then
            Label1.Text = "Es fibonacci"
        Else
            Label1.Text = "No es fibonacci"
        End If
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n.Cargar(TextBox1.Text)
    End Sub

    Private Sub VerificarCapicuaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarCapicuaToolStripMenuItem.Click
        If (n.verificarCapicua) Then
            Label1.Text = "Es capicua"
        Else
            Label1.Text = "No es capicua"
        End If
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        Label1.Text = n.Descargar()

    End Sub

    Private Sub CargarFibbonaciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarFibbonaciToolStripMenuItem.Click
        v.CargarDimension(TextBox1.Text)
        v.CargarFibonacci()
        Label1.Text = v.DescargarToString()
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        v.CargarRand(TextBox1.Text)
        v2.CargarRand(TextBox2.Text)
    End Sub

    Private Sub ContarESubMPosicionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContarESubMPosicionToolStripMenuItem.Click
        Label1.Text = v.DescargarToString()
        Label2.Text = v.ContarElementosSubmultiplosPosicion()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        Label1.Text = v.DescargarToString()
        Label2.Text = v2.DescargarToString()
    End Sub

    Private Sub MayorEMultiposDeMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayorEMultiposDeMToolStripMenuItem.Click
        Label1.Text = v.DescargarToString()
        Label2.Text = v.MayorElementoMultiploDeM(TextBox1.Text).ToString
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        'v.Cargar(TextBox1.Text)
        v.Cargar(4)
        v.Cargar(7)
        v.Cargar(6)
        v.Cargar(1)
        v.Cargar(5)
        v.Cargar(5)
        v.Cargar(1)
        v.Cargar(5)
        v.Cargar(5)
        v.Cargar(9)
        v.Cargar(7)
        v.Cargar(8)
        v.Cargar(8)
        v.Cargar(2)
        v.Cargar(6)
        v.Cargar(1)
        v.Cargar(1)

    End Sub

    Private Sub CargarPosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarPosToolStripMenuItem.Click
        v.Cargar(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub VerificarOrdenadoRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarOrdenadoRangoToolStripMenuItem.Click
        If (v.VerificarOrd(TextBox1.Text, TextBox2.Text)) Then
            Label2.Text = "Esta ordenado"
        Else
            Label2.Text = "Esta desordenado"
        End If
    End Sub

    Private Sub InvertirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirToolStripMenuItem.Click
        v.Invertir()
        Label2.Text = v.DescargarToString()

    End Sub

    Private Sub InterseccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterseccionToolStripMenuItem.Click
        Label3.Text = v.Interseccion(v2).DescargarToString()
    End Sub

    Private Sub UnionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnionToolStripMenuItem.Click
        Label3.Text = v.Union(v2).DescargarToString()
    End Sub

    Private Sub MenosRepetidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenosRepetidoToolStripMenuItem.Click
        Label3.Text = v.elementoMenosRepetido2(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SepararPrimosNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SepararPrimosNoPrimosToolStripMenuItem.Click
        v.ejericio8practico2(TextBox1.Text, TextBox2.Text)
        Label3.Text = v.DescargarToString()
    End Sub

    Private Sub EliminarRepetidosRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRepetidosRangoToolStripMenuItem.Click
        v.eliminarRepetidosRango(TextBox1.Text, TextBox2.Text)
        Label3.Text = v.DescargarToString()
    End Sub

    Private Sub MenorMayorRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenorMayorRangoToolStripMenuItem.Click
        Dim v1 As Vector = New Vector()
        Dim v2 As Vector = New Vector()

        v.menorMayorFrecuenciaRango(TextBox1.Text, TextBox2.Text, v1, v2)
        Label3.Text = v1.DescargarToString() + " " + v2.DescargarToString()
    End Sub
End Class
