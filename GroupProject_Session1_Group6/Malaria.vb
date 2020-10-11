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

Public Class Malaria
    Inherits Disease

    'Variables 
    Private _Net As Integer
    Private _spray As Integer
    Private _injection As Integer

    Public Sub New(initInfected As Integer)
        MyBase.New(initInfected)
        _Net = 0
        _spray = 0
        _injection = 0
    End Sub
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