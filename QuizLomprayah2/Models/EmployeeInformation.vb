'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Partial Public Class EmployeeInformation
    Public Property emp_id As Integer
    <Required(ErrorMessage:="��سҡ�͡ ���ʾ�ѡ�ҹ !")>
    <Display(Name:="���ʾ�ѡ�ҹ")>
    Public Property employee_ID As String
    <Required(ErrorMessage:="��سҡ�͡ ���� !")>
    <Display(Name:="����")>
    Public Property Name As String
    <Required(ErrorMessage:="��سҡ�͡ ���ʡ�� !")>
    <Display(Name:="���ʡ��")>
    Public Property LastName As String
    Public Property Position_id As Nullable(Of Integer)
    <Required(ErrorMessage:="��سҡ�͡ Ἱ� !")>
    <Display(Name:="Ἱ�")>
    Public Property Department As String
    Public Property Branch_id As Nullable(Of Integer)
    <Required(ErrorMessage:="��سҡ�͡ �ѹ���������ӧҹ !")>
    <Display(Name:="�ѹ���������ӧҹ")>
    <DataType(DataType.Date)>
    Public Property StartDate As Nullable(Of Date)

    Public Overridable Property BranchTable As BranchTable
    Public Overridable Property PositionTable As PositionTable
    Public Overridable Property News As ICollection(Of News) = New HashSet(Of News)
    Public Overridable Property ScoreUser As ICollection(Of ScoreUser) = New HashSet(Of ScoreUser)

End Class
