Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class ValidNegocio
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Function Verify_Expediente(ByVal Expediente As String) As Boolean

            MessageBox.Show(Expediente.Length)

            Return True
        End Function


    End Class
End Namespace

