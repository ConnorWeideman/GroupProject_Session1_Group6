' *****************************************************************
' Team Number: 6
' Team Member 1 Details: Gerber, Josh 220052458
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Disease
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class Disease
    '<Variables>
    Protected _infected, _deaths, _recovered As Integer
    Protected Shared _totalDeaths As Integer
    Protected _symptoms() As String 'How many symptoms are we going  to have?
    Protected _worstCountry As String
    '</Variables

    Public Sub New(initInfected As Integer) 'Contructor
        Infected = initInfected
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
    Public Property Symptoms() As String()
        Get
            Return _symptoms
        End Get
        Set(value As String())
            _symptoms = value
        End Set
    End Property '</Symptoms> whole array
    Public Property Symptoms(index As Integer) As String
        Get
            Return _symptoms(index)
        End Get
        Set(value As String)
            _symptoms(index) = value
        End Set
    End Property '</Symptoms> single value
    Public Property WorstCountry() As String
        Get
            Return _worstCountry
        End Get
        Set(value As String)
            _worstCountry = value
        End Set
    End Property '</WorstCountry>
    '</Properties>

    Protected Overridable Function CalcMortalityRate() As Double
        'TODO
        Return 0.0
    End Function '</CalcMortalityRate>
    Protected Function CalcInfected() As Integer
        'TODO
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