Option Strict On
Option Explicit On
Option Infer Off

' *****************************************************************
' Team Number: assigned to team 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Gerber, JD (220052458)
' Team Member 3 Details: Karner, Michael (217028123)
' Team Member 4 Details: Orlando, DA (220004186)
' Practical: Team Project
' Class name: Form1
' *****************************************************************

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1

    'Variables Including Constant
    Private Diseases(2) As Disease
    Private numWeeks As Integer
    Private Const NL As String = vbNewLine

    'Enumerator
    Private Enum D
        HIV = 0
        Malaria = 1
        TB = 2
    End Enum

    'On Button Click
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Weeks Tracked
        numWeeks = CInt(InputBox("How many weeks would you like to track the diseases for?"))

        'Disease Initial States
        Dim initHIV, initMal, initTB As Integer

        initHIV = CInt(InputBox("How many are initially infected with HIV at the start of tracking?"))
        initMal = CInt(InputBox("How many are initially infected with Malaria at the start of tracking?"))
        initTB = CInt(InputBox("How many are initially infected with TB at the start of tracking?"))

        'Setup Diseases
        Diseases(D.HIV) = New HIV(initHIV)
        Diseases(D.Malaria) = New Malaria(initMal)
        Diseases(D.TB) = New TB(initTB)

        'Each Week Input
        For i As Integer = 1 To numWeeks

            'Input infected, deaths and recovered for each disease
            For i1 As Integer = 0 To 2

                Dim deaths, newInfected, recovered As Integer
                Dim disease As String

                If (i1 = D.HIV) Then
                    disease = "HIV"
                ElseIf (i1 = D.Malaria) Then
                    disease = "Malaria"
                ElseIf (i1 = D.TB) Then
                    disease = "TB"
                End If

                newInfected = CInt(InputBox("In week " + CStr(i) + " how many people were infected with " + disease + "?"))
                recovered = CInt(InputBox("In week " + CStr(i) + " how many people recovered from " + disease + "?"))
                deaths = CInt(InputBox("In week " + CStr(i) + " how many people died from " + disease + "?"))

                Diseases(i1).Infected += newInfected
                Diseases(i1).Recovered += recovered
                Diseases(i1).Deaths += deaths

            Next

            'Disease Specific
            Dim tempHIV As HIV
            Dim tempMalaria As Malaria
            Dim tempTB As TB

            'HIV
            tempHIV = TryCast(Diseases(D.HIV), HIV)
            If Not (tempHIV Is Nothing) Then

                Dim haveAids, blood, sexual As Integer

                haveAids = CInt(InputBox("In week " + CStr(i) + " how many new people were diagnosed with AIDS?"))
                blood = CInt(InputBox("Of those infected with HIV in week " + CStr(i) + ", how many people were infected through blood?"))
                sexual = CInt(InputBox("Of those infected with HIV in week " + CStr(i) + ", how many people were infected through sexual contact?"))

                tempHIV.haveAids += haveAids
                tempHIV.blood += blood
                tempHIV.sexual += sexual

                Diseases(D.HIV) = tempHIV

            End If

            'Malaria
            tempMalaria = TryCast(Diseases(D.Malaria), Malaria)
            If Not (tempMalaria Is Nothing) Then

                Dim net, spray, injection As Integer

                net = CInt(InputBox("Of those infected with Malaria in week " + CStr(i) + ", how many people were using a mosquito net?"))
                spray = CInt(InputBox("Of those infected with Malaria in week " + CStr(i) + ", how many people were using a mosquito repellent spray?"))
                injection = CInt(InputBox("Of those infected with Malaria in week " + CStr(i) + ", how many people had the Malaria injection?"))

                tempMalaria.net += net
                tempMalaria.spray += spray
                tempMalaria.injection += injection

                Diseases(D.Malaria) = tempMalaria

            End If

            'TB
            tempTB = TryCast(Diseases(D.TB), TB)
            If Not (tempTB Is Nothing) Then

                Dim active As Integer

                active = CInt(InputBox("Of those infected with TB in week " + CStr(i) + ", how many people have active TB?"))

                tempTB.areActive += active

                Diseases(D.TB) = tempTB

            End If

        Next

        'Calc Worst
        Dim worstMortality As Double = 0
        Dim currentMortality As Double
        Dim worstIndex As Integer

        For i As Integer = 0 To 2

            currentMortality = Diseases(i).CalcMortalityRate()

            If currentMortality > worstMortality Then

                worstIndex = i
                worstMortality = currentMortality

            End If

        Next

        'Display Worst
        If worstIndex = 0 Then
            txtWorst.Text = "HIV"
        ElseIf worstIndex = 1 Then
            txtWorst.Text = "Malaria"
        ElseIf worstIndex = 2 Then
            txtWorst.Text = "TB"
        End If

        'Display Data
        txtDisplay.Text = "HIV:" & NL _
            & Diseases(D.HIV).display() & NL & NL _
            & "Malaria:" & NL _
            & Diseases(D.Malaria).display() & NL & NL _
            & "TB:" & NL _
            & Diseases(D.TB).display()

        'Display Deaths
        txtDeaths.Text = CStr(Diseases(D.HIV).TotalDeaths)

        'Save To File
        Dim FS As FileStream
        Dim BF As BinaryFormatter

        FS = New FileStream("Data.txt", FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        BF.Serialize(FS, Diseases)

        FS.Close()

    End Sub

End Class
