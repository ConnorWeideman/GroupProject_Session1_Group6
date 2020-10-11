' *****************************************************************
' Team Number: assigned to team 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Gerber, JD (220052458)
' Team Member 3 Details: Karner, Michael (217028123)
' Team Member 4 Details: Orlando, DA (220004186)
' Practical: Team Project
' Class name: Form1
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class Disease
    '<Variables>
    Protected _infected, _deaths, _recovered As Integer
    Protected Shared _totalDeaths As Integer
    '</Variables

    Public Sub New(initInfected As Integer) 'Contructor
        _infected = MakePos(initInfected)
        _deaths = 0
        _recovered = 0
        _totalDeaths = 0
    End Sub '</New>

    '<Properties>
    Public Property Infected() As Integer
        Get
            Return _infected
        End Get
        Set(value As Integer)
            _infected = value
        End Set
    End Property '</Infected>
    Public Property Deaths() As Integer
        Get
            Return _deaths
        End Get
        Set(value As Integer)
            _deaths = value
        End Set
    End Property '</Deaths>
    Public Property Recovered() As Integer
        Get
            Return _recovered
        End Get
        Set(value As Integer)
            _recovered = value
        End Set
    End Property '</Recovered>
    Public Property TotalDeaths() As Integer
        Get
            Return _totalDeaths
        End Get
        Set(value As Integer)
            _totalDeaths = value
        End Set
    End Property '</TotalDeaths>
    '</Properties>

    Public Overridable Function CalcMortalityRate() As Double
        'Percentage that have died out of the amount of those that have been infected by the disease
        Return Deaths / (Recovered + Infected) * 100
    End Function '</CalcMortalityRate>
    Protected Function CalcInfected() As Integer
        'calculates the number of infected individuals as each day the infected individuals is incremented but never decreased when individuals die or recover
        _infected -= _deaths + _recovered
        Return Infected
    End Function '</CaclInfected>
    Private Function MakePos(num As Integer) As Integer
        If num < 0 Then 'If negative
            num = CInt(num / -1) 'Make positive
        End If

        Return num
    End Function '</MakePos>
    Public MustOverride Function display() As String
End Class '</Disease>