Option Strict On
Option Explicit On
Option Infer Off



Public Class Malaria
    Inherits Disease

    'Variables 
    Private _Net As Integer
    Private _spray As Integer
    Private _injection As Integer

    Public Property net() As Integer
        Get
            Return _Net
        End Get
        Set(value As Integer)
            _Net = value
        End Set
    End Property

    Public Property spray() As Integer
        Get
            Return _spray
        End Get
        Set(value As Integer)
            _spray = value
        End Set
    End Property

    Public Property injection() As Integer
        Get
            Return _injection
        End Get
        Set(value As Integer)
            _injection = value
        End Set
    End Property


    Public Overrides Function display() As String
        Throw New NotImplementedException()
    End Function
End Class