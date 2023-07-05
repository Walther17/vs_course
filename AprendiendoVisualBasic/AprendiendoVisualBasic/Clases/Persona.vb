Public Class Persona

    Private CI As String
    Private _Nombre As String
    Private _Edad As Integer
    Private _UniqueId As String

    Public Sub New()

        Console.WriteLine("Inicializando constructor persona")

    End Sub

    ' Public ReadOnly Property Id() As String

    ' Get
    'Return _UniqueId.Substring(4)
    'End Get

    'End Property

    Public Property Nombre As String

        Get
            Return _Nombre
        End Get

        Set(nombre As String)
            _Nombre = nombre
        End Set

    End Property

    Public Property Edad As Integer

        Get
            Return _Edad
        End Get

        Set(Edad As Integer)
            _Edad = Edad
        End Set

    End Property

    Public Property Cedula As String

        Get
            Return CI
        End Get

        Set(Cip As String)
            CI = Cip
        End Set

    End Property

    Public Overrides Function ToString() As String

        Return String.Format("[ {0}, {1}, {2} ]", Cedula, Nombre, Edad)

    End Function

End Class