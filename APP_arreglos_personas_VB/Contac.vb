Class Contac
    Inherits Person

    Private telephone As String
    Private gmail As String

    Public Property Telefono As String
        Get
            Return telephone
        End Get
        Set(ByVal value As String)
            telephone = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Property Correo As String
        Get
            Return gmail
        End Get
        Set(ByVal value As String)
            gmail = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        telephone = String.Empty
        gmail = String.Empty
    End Sub

    Public Sub New(ByVal name As String, ByVal last_name_father As String, ByVal last_name_mother As String, ByVal birthdate As DateTime?, ByVal telephone As String, ByVal gmail As String)
        MyBase.New(name, last_name_father, last_name_mother, birthdate)
        Me.telephone = telephone
        Me.gmail = gmail
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & vbLf & "Telefono: " & telephone & vbLf & "Correo: " & gmail
    End Function
End Class
