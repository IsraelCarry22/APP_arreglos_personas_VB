Class Person
    Protected name As String
    Protected last_name_father As String
    Protected last_name_mother As String
    Protected birthdate As DateTime?

    Public Property Nombre As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property Apellido_Paterno As String
        Get
            Return last_name_father
        End Get
        Set(ByVal value As String)
            last_name_father = value
        End Set
    End Property

    Public Property Apellido_Materno As String
        Get
            Return last_name_mother
        End Get
        Set(ByVal value As String)
            last_name_mother = value
        End Set
    End Property

    Public Property Fecha_de_cumpleaños As DateTime?
        Get
            Return birthdate
        End Get
        Set(ByVal value As DateTime?)
            birthdate = value
        End Set
    End Property

    Public ReadOnly Property Edad As Integer
        Get
            Dim age As Integer
            age = (DateTime.Now.Year - birthdate.Value.Year)
            Return age
        End Get
    End Property

    Public Sub New()
        name = String.Empty
        last_name_father = String.Empty
        last_name_mother = String.Empty
        birthdate = Nothing
    End Sub

    Public Sub New(ByVal name As String, ByVal last_name_father As String, ByVal last_name_mother As String, ByVal birthdate As DateTime?)
        Me.name = name
        Me.last_name_father = last_name_father
        Me.last_name_mother = last_name_mother
        Me.birthdate = birthdate
    End Sub

    Public Overrides Function ToString() As String
        Return "Nombre Completo: " & name.ToUpper() & " " & last_name_father.ToUpper() & " " & last_name_mother.ToUpper() & " " & vbLf & "Edad: " & Edad & vbLf & "Fecha cumpleaños: " & birthdate
    End Function
End Class
