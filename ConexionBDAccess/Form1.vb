Imports System.Data.OleDb

Public Class frmconexion
    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Dim conexion As String
        conexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & "bdempresa.mdb" & ";"

        Dim seleccion As String = "SELECT * FROM clientes"
        Dim adaptadordedatos As OleDbDataAdapter
        Dim tabladedatos As New DataTable

        Try
            adaptadordedatos = New OleDbDataAdapter(seleccion, conexion)
            adaptadordedatos.Fill(tabladedatos)
            dgtabla.DataSource = tabladedatos

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
