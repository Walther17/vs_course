
' Visual Basic es un lenguaje de programación de alto nivel desarrollado por Microsoft.
' Es parte de la plataforma de desarrollo de software .NET y se utiliza principalmente para crear aplicaciones de escritorio, aplicaciones web y servicios web.

Public Class ArraysVB


#Region "Declaraciones y Tipos de Literales"

    Dim Edad As Int64
    Dim Titulo As String = "Propiedad Inicializada"
    Dim FechaNac As Date = "23/08/2003"
    Const PI As Decimal = 3.1415646473
    Dim Age As String = "19"
    Dim Casado As Boolean = False
    Dim ageConvert As Integer = Convert.ToInt32(Age)

#End Region

#Region "Arreglos"
    Sub arreglos()
        Dim Nombres() As String = {
        "Dev Joander", "Josthyn",
        "Carlos"
        }
        Console.WriteLine("Arreglos")

        For Each numero As String In Nombres
            Console.WriteLine(numero)
        Next

        ReDim Preserve Nombres(4) ' redimensionar un arreglo (array) preservando los datos existentes en él
        Nombres(3) = "Luis"
        Nombres(4) = "Ana"
        Console.WriteLine("Arreglos Updated")
        For Each numero As String In Nombres
            Console.WriteLine(numero)
        Next

    End Sub
#End Region

#Region "Captura De Datos por Consola"

    Sub capturaDeDatos()
        Dim n1 As Integer
        Dim n2 As Integer
        Dim r As Integer

        Console.WriteLine("Suma de numeros")
        Console.WriteLine("Ingrese el número 1")
        n1 = Console.ReadLine()
        Console.WriteLine("Ingrese el número 1")
        n2 = Console.ReadLine()
        r = n1 + n2
        Console.WriteLine("El resultado es " & r)
    End Sub

#End Region

#Region "Manipulación de fechas"
    Sub fechas()
        Console.WriteLine("Fechas")
        Console.WriteLine(Date.Now.CompareTo(Date.Parse("03/04/2023").Date))
    End Sub
#End Region


End Class


