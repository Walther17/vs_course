

Imports System

Module Program
    Sub Main()

        Dim i As New Estudiante()

        For Each prop As System.Reflection.PropertyInfo In i.GetType().GetProperties()
            Dim propName As String = prop.Name
            Dim propValue As Object = prop.GetValue(i)

            Console.WriteLine(propName & ": " & propValue)
        Next

        ' Dim i As New Estudiante("D", 3, "32", "wd")

        ' Dim result As String = String.Join(", ", i.GetType().GetProperties().Select(Function(prop) $"{prop.Name}: {prop.GetValue(i)}"))


#Region "Arrays y coleccion de datos"

        Dim miListaDefinida(12) As String

        Dim miListaInicializada() As String = {
            "Luis Sarmiento",
            "Gissel Vargas",
            "Eemly Vargas",
            "Ana Vargas",
            "Samuel Vargas"
        }

        Dim listaNumeros As List(Of Integer) = New List(Of Integer)
        For x = 0 To 10
            listaNumeros.Add(x + 1)
        Next

        Dim itemPosicion4 As Integer = listaNumeros(4)

        Dim ListaAsistentes As List(Of Persona) = New List(Of Persona) From {
            New Estudiante With {
                .Nombre = "Samuel Vargas",
                .Edad = 20,
                .Cedula = "09xxxxxxx"
            },
            New Estudiante With {
                .Nombre = "Ana Vargas",
                .Edad = 21,
                .Cedula = "09xxxxxxx"
            },
            New Estudiante With {
                .Nombre = "Ana Vargas",
                .Edad = 21,
                .Cedula = "09xxxxxxx"
            }
        }

        ListaAsistentes.Add(New Estudiante("Capacitacion c#") With {
                            .Nombre = "Josthin Ayon",
                            .Cedula = "095344471",
                            .Edad = 22
                            })

        ListaAsistentes.ForEach(Sub(data)
                                    Console.WriteLine(data.Cedula)
                                End Sub)

        Dim ususariosLogin As New Dictionary(Of String, String)

        ususariosLogin.Add("Josthin", "0954383949")
        ususariosLogin.Add("Johan", "0")

        Console.WriteLine("Ingrese la clave de Josthin")
        Dim valueJosthin = Console.ReadLine()

        If ususariosLogin.TryGetValue("Josthin", valueJosthin) Then
            Console.WriteLine("Bienvenido")
        Else
            Console.WriteLine("Fuera")
        End If

#End Region

    End Sub

End Module
