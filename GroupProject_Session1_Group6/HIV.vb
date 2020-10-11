Option Strict On
Option Explicit On
Option Infer Off

' *****************************************************************
' Team Number: 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Gerber, JD (220052458)
' Team Member 3 Details: Karner, Michael (217028123)
' Team Member 4 Details: Orlando, DA (220004186)
' Practical: Team Project
' Class name: HIV
' *****************************************************************

<Serializable()> Public Class HIV
    Inherits Disease

    'Variables 
    Private _haveAids As Integer
    Private _blood As Integer
    Private _sexual As Integer

    'Constructor
    Public Sub New(initInfected As Integer)
        MyBase.New(initInfected)
        _blood = 0
        _sexual = 0
        _haveAids = 0
    End Sub

    'Property Methods
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
    'End Properties

    'Display All Data
    Public Overrides Function display() As String
        Dim temp As String

        temp = "Common Symptoms: " & vbNewLine & "Fever, Sore Throat, Headache, Fatigue" & vbNewLine _
            & "Currect Infected Patients: " & _infected & vbNewLine _
            & "Deaths for HIV: " & _deaths & vbNewLine _
            & "Recovered from HIV: " & _recovered & vbNewLine _
            & "HIV Patients that have aids: " & _haveAids & vbNewLine _
            & "Infected by blood contact: " & _blood & vbNewLine _
            & "Infected by sexual contacts: " & _sexual & vbNewLine

        Return temp
    End Function
End Class