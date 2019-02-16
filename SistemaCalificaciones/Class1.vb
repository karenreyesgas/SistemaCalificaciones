Public Class MyItem
    Public Sub New(ByVal text As String, ByVal value As String)
        t = text
        v = value
    End Sub

    Private t As String
    Private v As String
    Public Property Text() As String
        Get
            Return t
        End Get
        Set(ByVal value As String)
            t = value
        End Set
    End Property
    Public Property Value() As String
        Get
            Return v
        End Get
        Set(ByVal value As String)
            v = value
        End Set
    End Property
End Class