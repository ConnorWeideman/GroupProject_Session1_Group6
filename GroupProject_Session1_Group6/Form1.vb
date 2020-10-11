Option Strict On
Option Explicit On
Option Infer Off

' *****************************************************************
' Team Number: assigned to team 6
' Team Member 1 Details: Weideman, C (220145487)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Form1
' *****************************************************************

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1

    Private Diseases(2) As Disease
    Private numWeeks As Integer
    Private Const NL As String = vbNewLine

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        numWeeks = CInt(InputBox("How many weeks would you like to track the diseases for?"))

        'Setup Diseases
        Diseases(0) = New HIV
        Diseases(1) = New Malaria
        Diseases(2) = New TB

        Diseases(0).Infected = CInt(InputBox("How many are initially infected with HIV at the start of tracking?"))
        Diseases(1).Infected = CInt(InputBox("How many are initially infected with Malaria at the start of tracking?"))
        Diseases(2).Infected = CInt(InputBox("How many are initially infected with TB at the start of tracking?"))

        'Each Week Input
        For i As Integer = 1 To numWeeks

            'Input infected, deaths and recovered for each disease
            For i1 As Integer = 0 To 2

                Dim deaths, newInfected, recovered As Integer
                Dim disease As String

                If (i1 = 0) Then
                    disease = "HIV"
                ElseIf (i1 = 1) Then
                    disease = "Malaria"
                ElseIf (i1 = 2) Then
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
            tempHIV = TryCast(Diseases(0), HIV)
            If (tempHIV) Then

                Dim haveAids, blood, sexual As Integer

                haveAids = CInt(InputBox("In week " + CStr(i) + " how many new people were diagnosed with AIDS?"))
                blood = CInt(InputBox("Of those infected with HIV in week " + CStr(i) + ", how many people were infected through blood?"))
                sexual = CInt(InputBox("Of those infected with HIV in week " + CStr(i) + " how many people were infected through sexual contact?"))

                tempHIV.haveAids += haveAids
                tempHIV.Blood += blood
                tempHIV.Sexual += sexual

                Diseases(0) = tempHIV

            End If

            'Malaria
            tempMalaria = TryCast(Diseases(1), Malaria)
            If (tempMalaria) Then

                Dim net, spray, injection As Integer

                net = CInt(InputBox("Of those infected with Malaria in week " + CStr(i) + " how many people were using a mosquito net?"))
                spray = CInt(InputBox("Of those infected with Malaria in week " + CStr(i) + " how many people were using a mosquito repellent spray?"))
                injection = CInt(InputBox("Of those infected with Malaria in week " + CStr(i) + " how many people had the Malaria injection?"))

                tempMalaria.Net += net
                tempMalaria.Spray += spray
                tempMalaria.Injection += injection

                Diseases(1) = tempMalaria

            End If

            'TB
            tempTB = TryCast(Diseases(2), TB)
            If (tempTB) Then

                Dim active As Integer

                active = CInt(InputBox("Of those infected with TB in week " + CStr(i) + " how many people have active TB?"))

                tempTB.areActive += active

                Diseases(2) = tempTB

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
            & Diseases(0).Display() & NL & NL _
            & "Malaria:" & NL _
            & Diseases(1).Display() & NL & NL _
            & "TB:" & NL _
            & Diseases(2).Display()

        'Save To File
        Dim FS As FileStream
        Dim BF As BinaryFormatter

        FS = New FileStream("Data.txt", FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        BF.Serialize(FS, Diseases)

        FS.Close()

    End Sub

End Class
