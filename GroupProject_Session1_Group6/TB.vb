﻿' *****************************************************************
' Team Number: 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Gerber, JD (220052458)
' Team Member 3 Details: Karner, Michael (217028123)
' Team Member 4 Details: Orlando, DA (220004186)
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

    Public Sub New(initInfected As Integer)
        MyBase.New(initInfected)
        _percentActive = 0.0
        _areActive = 0
    End Sub

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
