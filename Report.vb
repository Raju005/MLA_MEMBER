Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class REPORTVIEWER
    Dim gconnection As New GlobalClass
    Public str As String
    Dim myconn As SqlConnection
    Public sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Public ssql, TableName As String
    Public Report As Object
    Dim ds As DataSet
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetDetails(ssql, TableName, Report)
    End Sub
    Public Function GetDetails(ByVal sqlstring As String, ByVal Tabname As String, ByVal rpt As Object)
        Try
            If sqlstring <> "" And Tabname <> "" Then
                myconn = New SqlConnection(gconnection.Getconnection())
                Dim adp As New SqlDataAdapter
                Dim ds As New DataSet
                adp = New SqlDataAdapter(sqlstring, myconn)
                adp.Fill(ds, Tabname)
                rpt.SetDataSource(ds)
                CrystalReportViewer1.ReportSource = rpt
                CrystalReportViewer1.Zoom(100)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEMBER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Public Function GetDetails1(ByVal ssql As String, ByVal Tab As String, ByVal rpt As Object)
        Dim dt As New DataTable
        myconn = New SqlConnection(gconnection.Getconnection())
        gadapter = New SqlDataAdapter(ssql, myconn)
        gadapter.SelectCommand.CommandTimeout = 10000
        gadapter.Fill(dt)
        dt.TableName = Tab
        If gdataset.Tables.Contains(Tab) = True Then
            gdataset.Tables.Remove(Tab)
        End If
        gdataset.Tables.Add(dt)
        rpt.SetDataSource(gdataset)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Zoom(100)
    End Function

    Public Function GetDetails2(ByVal ssql As String, ByVal Tab As String, ByVal rpt As Object)
        Dim dt As New DataTable
        myconn = New SqlConnection(gconnection.Getconnection())
        gadapter = New SqlDataAdapter(ssql, myconn)
        gadapter.SelectCommand.CommandTimeout = 10000
        gadapter.Fill(dt)
        dt.TableName = Tab
        If gdataset.Tables.Contains(Tab) = True Then
            gdataset.Tables.Remove(Tab)
        End If
        gdataset.Tables.Add(dt)
        'rpt.SetDataSource(gdataset)
        rpt.Subreports(0).SetDataSource(gdataset)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Zoom(100)
    End Function
    Public Function GetDetails3(ByVal ssql As String, ByVal Tab As String, ByVal rpt As Object)
        Dim dt As New DataTable
        myconn = New SqlConnection(gconnection.Getconnection())
        gadapter = New SqlDataAdapter(ssql, myconn)
        gadapter.Fill(dt)
        dt.TableName = Tab
        If gdataset.Tables.Contains(Tab) = True Then
            gdataset.Tables.Remove(Tab)
        End If
        gdataset.Tables.Add(dt)
        'rpt.SetDataSource(gdataset)
        rpt.Subreports(1).SetDataSource(gdataset)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Zoom(100)
    End Function
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
    End Sub
End Class