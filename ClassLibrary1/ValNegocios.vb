Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class ValNegocios

    Public Function isExpediente(ByVal Expediente As String) As Boolean
        If (Expediente.Length.Equals(9)) Then
            Dim pattern As String = "^[a-zA-Z]{3}[0-9]{6}$"
            Dim pattern2 As String = "^[0-9]{9}$"
            Dim m As Match = Regex.Match(Expediente, pattern, RegexOptions.IgnoreCase)
            Dim m2 As Match = Regex.Match(Expediente, pattern2, RegexOptions.IgnoreCase)
            If m.Success Or m2.Success Then
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function

    Public Function isCP(ByVal Expediente As String) As Boolean
        If (Expediente.Length <= 5 And Expediente.Length > 0) Then
            Dim pattern As String = "^[0-9]+$"
            Dim m As Match = Regex.Match(Expediente, pattern, RegexOptions.IgnoreCase)
            If m.Success Then
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function

    Public Function isAnticipo(ByVal Anticipo As String) As Boolean
        Dim i As Integer
        If Not Integer.TryParse(Anticipo, i) Then
            Return False
        End If
            Return True
        Return False
    End Function

    Public Function isTicket(ByVal Ticket As String) As Boolean
        If Ticket.Length <= 6 Then
            Dim i As Integer
            If Not Integer.TryParse(Ticket, i) Then
                Return False
            End If
            Return True
        End If
        Return False
    End Function

    Public Function comboOption(ByVal Valor As String) As Boolean
        If Valor = Nothing Then
            Return False
        End If
        Return True
    End Function

    Public Function isMonto(ByVal Monto As String) As Boolean
        Dim pattern As String = "^[0-9]+(\.[0-9]+)?$"
        Dim m As Match = Regex.Match(Monto, pattern, RegexOptions.IgnoreCase)
        If m.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function isFecha(ByVal FechaInicio As Date, ByVal FechaFin As Date) As Boolean
        If FechaInicio > FechaFin Then
            Return False
        End If
        Return True
    End Function

    Public Function texto(ByVal text As String) As Boolean
        If text.Length = 0 Then
            Return False
        End If
        Return True
    End Function

End Class
