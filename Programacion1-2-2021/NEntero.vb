Public Class NEntero

    Private numero As Integer

    Public Sub New()
        numero = 0
    End Sub

    Public Sub New(new_numero As Integer)
        numero = new_numero
    End Sub

    Public Sub NEntero()
        numero = 0
    End Sub

    Public Sub NEntero(new_numero As Integer)
        numero = new_numero
    End Sub

    Public Function Descargar() As Integer
        Return numero
    End Function

    Public Function getNumero() As Integer
        Return numero
    End Function

    Public Sub Cargar(new_numero As Integer)
        numero = new_numero
    End Sub

    Public Sub setNumero(new_numero As Integer)
        numero = new_numero
    End Sub



    Public Sub invertirNumero()
        Dim aux As Integer
        aux = 0
        While (numero > 0)
            Dim dig = numero Mod 10
            numero = numero \ 10
            aux = aux * 10 + dig
        End While
        numero = aux
    End Sub

    Public Function verificarCapicua()
        Dim numAuxiliar As NEntero
        numAuxiliar = New NEntero()
        numAuxiliar.NEntero()
        numAuxiliar.Cargar(numero)
        numAuxiliar.invertirNumero()

        Return (numero = numAuxiliar.Descargar)
    End Function

    Public Function cantidadDigitos()
        Dim aux As Integer
        aux = numero
        Dim res = 0
        While (aux > 0)
            aux = aux \ 10
            res = res + 1
        End While
        Return res
    End Function


    Public Function verificarFibonacci()
        Dim ant = 0
        Dim act = 1
        Dim fibo = 0

        While (fibo < numero)
            fibo = fibo * 10 + act
            Dim aux = act
            act = act + ant
            ant = aux
        End While
        Return (fibo = numero)
    End Function

    Public Function verifPrimo()
        Dim esPrimo = False
        Dim contador = 0

        For i = 1 To numero
            If (numero Mod i = 0) Then
                contador = contador + 1
            End If
        Next
        Return contador = 2
    End Function

End Class
