' *****************************************************************
' Team Number: 6
' Team Member 1 Details: Gerber, Josh 220052458
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: TB
' *****************************************************************

Option Explicit On
Option Strict On
Option Infer Off

Public Class TB
    Inherits Disease
    'Variables
    Private _percentActive As Double
    Private _areActive As Integer

    Public Property percentActive() As Double
        Get
            Return _percentActive
        End Get
        Set(value As Double)
            _percentActive = value
        End Set
    End Property

    Public Property areActive() As Integer
        Get
            Return _areActive
        End Get
        Set(value As Integer)
            _areActive = value
        End Set
    End Property

    Public Overrides Function display() As String
        Throw New NotImplementedException()
    End Function
End Class
