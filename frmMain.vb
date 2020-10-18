'*******************************************
'*******************************************
'Programmer: Your name goes here
'Course: ITSE 1332.xxxx (VB)
'Program purpose: Program Purpose Goes here
'*******************************************
'*******************************************

#Region "Compiler_Directives"

'*******************************************
Option Explicit On  'Forces explicit declaration of all variables in a file, or allows implicit declarations of variables
Option Strict On    'Restricts implicit data type conversions to only widening conversions, disallows late binding, and disallows implicit typing
Option Infer Off    'Disables the use of local type inference in declaring variables
#Disable Warning IDE1006    'Disables warnings over class naming convention for controls
'*******************************************

#End Region

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the Application
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class