Option Strict On
Option Explicit On
Option Infer Off


Public Class HIV
    Inherits Disease

    'Variables 
    Private _haveAids As Integer
    Private _blood As Integer
    Private _sexual As Integer

    Public Property haveAids() As Integer
        Get
            Return _haveAids
        End Get
        Set(value As Integer)
            _haveAids = value
        End Set
    End Property

    Public Property blood() As Integer
        Get
            Return _blood
        End Get
        Set(value As Integer)
            _blood = value
        End Set
    End Property

    Public Property sexual() As Integer
        Get
            Return _sexual
        End Get
        Set(value As Integer)
            _sexual = value
        End Set
    End Property

    Public Overrides Function display() As String
        Throw New NotImplementedException()
    End Function
End Class