' *****************************************************************
' Team Number: 6
' Team Member 1 Details: Gerber, J 220052458
' Team Member 2 Details: Orlando, D 220004186
' Team Member 3 Details: Karner, M 217028123
' Team Member 4 Details: Weideman, C 220145487
' Practical: Team Project
' Class name: Malaria
' *****************************************************************


Option Strict On
Option Explicit On
Option Infer Off


Public Class Malaria
    Inherits Disease

    'Variables 
    Private _Net As Integer
    Private _spray As Integer
    Private _injection As Integer

    'Constructor
    Public Sub New(initInfected As Integer)
        MyBase.New(initInfected)
        _Net = 0
        _spray = 0
        _injection = 0
    End Sub

    'Property Methods
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
    'End of Properties

    'Display All Data
    Public Overrides Function display() As String
        Dim temp As String

        temp = "Common Symptoms: " & vbNewLine & "Fever, Naseua, Anaemia, Diarrhoea" & vbNewLine _
            & "Currect Infected Patients: " & _infected & vbNewLine _
            & "Deaths for Malaria: " & _deaths & vbNewLine _
            & "Recovered from Malaria: " & _recovered & vbNewLine _
            & "People that used nets as prevention: " & _Net & vbNewLine _
            & "People that used bug spray as prevention: " & _spray & vbNewLine _
            & "People that used anti-malaria injection as prevention: " & _injection & vbNewLine

        Return temp
    End Function
End Class