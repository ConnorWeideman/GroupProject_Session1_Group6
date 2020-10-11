Option Strict On
Option Explicit On
Option Infer Off

' *****************************************************************
' Team Number: assigned to team 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Gerber, JD (220052458)
' Team Member 3 Details: Karner, Michael (217028123)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Form1
' *****************************************************************

Public Class HIV
    Inherits Disease

    'Variables 
    Private _haveAids As Integer
    Private _blood As Integer
    Private _sexual As Integer

    Public Sub New(initInfected As Integer)
        MyBase.New(initInfected)
        _blood = 0
        _sexual = 0
        _haveAids = 0
    End Sub

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