Public Class Vector
    Const Max = 100
    Private v(Max) As Integer
    Private dimension As Integer

    Public Sub New()
        dimension = 0
    End Sub

    Public Sub Vector()
        dimension = 0
    End Sub

    Public Sub Copiar(original() As Integer, a As Integer, b As Integer)
        Dim vCopia As Vector = New Vector()
        vCopia.Vector()

        For i = a To b
            vCopia.Cargar(original(i))
        Next

        v = vCopia.v
        dimension = b - a + 1
    End Sub

    Public Sub Vector(_dimension As Integer)
        dimension = _dimension
        For i = 1 To dimension
            v(i) = 0
        Next
    End Sub

    Public Sub CargarDimension(_dimension As Integer)
        dimension = _dimension
    End Sub

    Public Function DescargarDimension()
        Return dimension
    End Function

    Public Sub CargarRand(_dimension As Integer)
        dimension = _dimension
        For i = 1 To dimension
            v(i) = Rnd() * 10
        Next
    End Sub

    Public Sub CargarRand(_dimension As Integer, a As Integer, b As Integer)
        Dim i As Integer
        dimension = _dimension
        For i = 1 To dimension
            v(i) = a + Rnd() * (b - a)
        Next
    End Sub

    Public Sub Cargar(elem As Integer)
        dimension = dimension + 1
        v(dimension) = elem
    End Sub

    Public Sub Cargar(elem As Integer, i As Integer)
        If (i <= dimension + 1) Then
            v(i) = elem
        End If
    End Sub

    Public Function Descargar(i As Integer)
        Return v(i)
    End Function

    Public Function DescargarToString()
        Dim res = "[ "
        For i = 1 To dimension
            res = res + v(i).ToString + " , "
        Next
        res = res + " ]"

        Return res
    End Function

    Public Sub CargarFibonacci()
        Dim ant = 1
        Dim act = 0

        For i = 1 To dimension
            v(i) = act
            Dim aux = act
            act = ant + act
            ant = aux
        Next
    End Sub

    Public Function ContarElementosSubmultiplosPosicion()
        Dim contador = 0
        For i = 1 To dimension
            If (v(i) Mod i = 0) Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    Public Function MayorElementoMultiploDeM(m As Integer)
        Dim mayor = 0
        For i = 1 To dimension
            If ((i Mod m = 0) And (v(i) > mayor)) Then
                mayor = v(i)
            End If
        Next
        Return mayor
    End Function


    Public Function VerificarOrd(a As Integer, b As Integer) As Boolean
        Dim res = True
        For i = a To b
            If (i < b) Then
                If (v(i) > v(i + 1)) Then
                    res = False
                End If
            End If
        Next
        Return res
    End Function

    Public Sub Invertir()
        For i = 1 To dimension \ 2
            Dim aux = v(i)
            v(i) = v(dimension - i + 1)
            v(dimension - i + 1) = aux
        Next
    End Sub

    Public Function existeElemento(elem As Integer)
        Dim existe = False
        For i = 1 To dimension
            If (elem = v(i)) Then
                existe = True
            End If
        Next
        Return existe
    End Function

    Public Function Interseccion(v2 As Vector) As Vector
        Dim res As Vector = New Vector()
        res.Vector()

        For i = 1 To dimension
            If (v2.existeElemento(v(i)) And Not res.existeElemento(v(i))) Then
                res.Cargar(v(i))
            End If
        Next
        Return res
    End Function

    Public Function Union(v2 As Vector) As Vector
        Dim res As Vector = New Vector()
        res.Vector()
        For i = 1 To dimension
            res.Cargar(v(i))
        Next

        For i = 1 To v2.DescargarDimension
            If (Not res.existeElemento(v2.Descargar(i))) Then
                res.Cargar(v2.Descargar(i))
            End If
        Next

        Return res
    End Function

    Public Sub SepararPrimosNoPrimos(ByRef primos As Vector, ByRef noPrimos As Vector)

        For i = 1 To dimension
            Dim ne As NEntero = New NEntero
            ne.NEntero()
            ne.Cargar(v(i))

            If (ne.verifPrimo) Then
                primos.Cargar(ne.Descargar)
            Else
                noPrimos.Cargar(ne.Descargar)
            End If
        Next
    End Sub


    Public Function cantidadElementoRepetido(elem As Integer)
        Dim cantidad = 0
        For i = 1 To dimension
            If (elem = v(i)) Then
                cantidad = cantidad + 1
            End If
        Next
        Return cantidad
    End Function

    Public Sub eliminarElemento(elem As Integer)
        Dim i = 1
        While (i <= dimension)
            If (elem = v(i)) Then
                For j = i To dimension
                    v(j) = v(j + 1)
                Next
                dimension = dimension - 1
            Else
                i = i + 1
            End If
        End While
    End Sub

    Public Function elementoMenosRepetido(a As Integer, b As Integer)

        Dim vCopia As Vector = New Vector()
        vCopia.Copiar(v, a, b)

        Dim menor = 0
        Dim frec = 100000

        While (vCopia.DescargarDimension > 0)
            Dim frecuencia = vCopia.cantidadElementoRepetido(vCopia.Descargar(1))
            If (frec > frecuencia) Then
                frec = frecuencia
                menor = vCopia.Descargar(1)
            End If
            vCopia.eliminarElemento(vCopia.Descargar(1))
        End While

        Return menor
    End Function



    Public Function posicionMenorElemento()
        Dim menor = v(1)
        Dim posicion = 1
        For i = 1 To dimension
            If (v(i) < menor) Then
                menor = v(i)
                posicion = i
            End If
        Next
        Return posicion
    End Function

    Public Function elementoMenosRepetido2(a As Integer, b As Integer)

        Dim numeros As Vector = New Vector()
        numeros.Vector()

        Dim frecuencias As Vector = New Vector()
        frecuencias.Vector()

        For i = a To b
            If (Not numeros.existeElemento(v(i))) Then
                numeros.Cargar(v(i))
                frecuencias.Cargar(cantidadElementoRepetidoRango(v(i), a, b))
            End If
        Next

        Dim pos = frecuencias.posicionMenorElemento()

        Return numeros.Descargar(pos)
    End Function


    Public Function esDigitoPrimo(dig As Integer)
        Return (dig = 3) Or (dig = 5) Or (dig = 7)
    End Function

    Public Sub ordenarDescendente()
        For i = 1 To dimension
            For j = i To dimension
                If (v(i) < v(j)) Then
                    Dim aux = v(i)
                    v(i) = v(j)
                    v(j) = aux
                End If
            Next
        Next
    End Sub

    Public Sub ejericio8practico2(a As Integer, b As Integer)
        Dim primos As Vector = New Vector()
        Dim noPrimos As Vector = New Vector()
        primos.Vector()
        noPrimos.Vector()

        For i = a To b
            Dim num As NEntero = New NEntero()
            num.NEntero()
            num.Cargar(v(i))
            If (num.verifPrimo()) Then
                primos.Cargar(num.Descargar)
            Else
                noPrimos.Cargar(num.Descargar)
            End If
        Next
        primos.ordenarDescendente()
        noPrimos.ordenarDescendente()

        Dim k = a

        For j = 1 To primos.DescargarDimension
            v(k) = primos.Descargar(j)
            k = k + 1
        Next

        For j = 1 To noPrimos.DescargarDimension
            v(k) = noPrimos.Descargar(j)
            k = k + 1
        Next

    End Sub

    Public Function seRepiteRango(elem As Integer, a As Integer, b As Integer)
        Dim contador = 0
        For i = a To b
            If (elem = v(i)) Then
                contador = contador + 1
            End If
        Next
        Return contador > 1
    End Function

    Public Sub eliminarPos(pos As Integer)
        dimension = dimension - 1
        For i = pos To dimension
            v(i) = v(i + 1)
        Next
    End Sub

    Public Sub eliminarRepetidosRango(a As Integer, b As Integer)
        For i = a To b
            If (seRepiteRango(v(i), a, b)) Then
                eliminarPos(i)
                i = i - 1
                b = b - 1
            End If
        Next
    End Sub

    Public Function cantidadElementoRepetidoRango(elem As Integer, a As Integer, b As Integer)
        Dim cantidad = 0
        For i = a To b
            If (elem = v(i)) Then
                cantidad = cantidad + 1
            End If
        Next
        Return cantidad
    End Function

    Public Sub menorMayorFrecuenciaRango(a As Integer, b As Integer, ByRef v1 As Vector,
                                         ByRef v2 As Vector)
        Dim frecMenor = 10000
        Dim frecMayor = 0
        Dim numMenor = 0
        Dim numMayor = 0
        For i = a To b
            Dim frecAcual = cantidadElementoRepetidoRango(v(i), a, b)
            If (frecAcual > frecMayor) Then
                frecMayor = frecAcual
                numMayor = v(i)
            End If

            If (frecAcual < frecMenor) Then
                frecMenor = frecAcual
                numMenor = v(i)
            End If
        Next
        v1.Cargar(numMenor)
        v1.Cargar(numMayor)

        v2.Cargar(frecMenor)
        v2.Cargar(frecMayor)
    End Sub

End Class
