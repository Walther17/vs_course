Public Class Estudiante : Inherits Persona

    Private _Curso As String

    Public Property Curso As String

        Get
            Return _Curso
        End Get

        Set(curso As String)
            _Curso = curso
        End Set

    End Property

    Public Sub New(Optional cursop As String = ".Net Framework")

        MyBase.New()
        Console.WriteLine("Inicalizando constructor estudiante")
        Curso = cursop

    End Sub


    Public Function GetMessage() As String

        Return "Retornando mensaje desde estudiante"

    End Function


End Class
