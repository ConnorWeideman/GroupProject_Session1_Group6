' *****************************************************************
' Team Number: 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Gerber, JD (220052458)
' Team Member 3 Details: Karner, MCR (217028123)
' Team Member 4 Details: Orlando, DA (220004186)
' Practical: Team Project
' Class name: TB
' *****************************************************************

Option Explicit On
Option Strict On
Option Infer Off

<Serializable()> Public Class TB
    Inherits Disease
    'Variables
    Private _areActive As Integer

    'Constructor
    Public Sub New(initInfected As Integer)
        MyBase.New(initInfected)
        _areActive = 0
    End Sub

    Private Function CalcPercentActive() As Double
        'Calculating Percentage of active TB patients
        Return _areActive / _infected * 100

    End Function

    Public Property areActive() As Integer 'Property method
        Get
            Return _areActive
        End Get
        Set(value As Integer)
            _areActive = value
        End Set
    End Property

    Public Overrides Function display() As String
        'Displaying the data
        Dim temp As String

        temp = "Common Symptoms: " & vbNewLine & "Fever, Cough, Night chills, Chest pain " & vbNewLine _
            & "Currect Infected Patients: " & _infected & vbNewLine _
            & "Deaths for TB: " & _deaths & vbNewLine _
            & "Recovered from TB: " & _recovered & vbNewLine _
            & "Active TB Cases: " & _areActive & vbNewLine _
            & "Percentage of Cases that are Active: " & Format(CalcPercentActive(), "0.##")
        Return temp
    End Function
End Class
