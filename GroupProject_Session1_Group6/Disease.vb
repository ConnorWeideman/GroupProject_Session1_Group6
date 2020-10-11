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
    '</Variables

    Public Sub New(initInfected As Integer) 'Contructor
        Infected = MakePos(initInfected)
    End Sub '</New>

    Public Enum symtoms
        sneezing
        coughing
        fever
        headache
        stomachPain
        fatigue
        sweating
        nausea
        anemia
        chills
        malaise
        diorrhea
        chestPain
        weightLoss
    End Enum

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

    Protected Overridable Function CalcMortalityRate() As Double 'we dont need this because we just need to divide deaths by the number of days
        Return Deaths / (Recovered + Infected) * 100
    End Function '</CalcMortalityRate>
    Protected Function CalcInfected() As Integer
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