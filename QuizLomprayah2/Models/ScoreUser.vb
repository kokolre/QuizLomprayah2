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

Partial Public Class ScoreUser
    Public Property score_id As Integer
    <Required(ErrorMessage:="��سҡ�͡ ���ʾ�ѡ�ҹ !")>
    <Display(Name:="���ʾ�ѡ�ҹ")>
    Public Property emp_id As Integer
    <Required(ErrorMessage:="��سҡ�͡ �Ӷ�� !")>
    <Display(Name:="�Ӷ��")>
    Public Property book_ID As Integer
    <Required(ErrorMessage:="��سҡ�͡ �������� !")>
    <Display(Name:="��������")>
    Public Property Score As String
    <Required(ErrorMessage:="��سҡ�͡ ��ṹ !")>
    <Display(Name:="��ṹ")>
    Public Property Status As String
    <Required(ErrorMessage:="��سҡ�͡ ���駷���ͺ !")>
    <Display(Name:="���駷���ͺ")>
    Public Property Round As String
    <Required(ErrorMessage:="��سҡ�͡ �ѹ����ͺ !")>
    <Display(Name:="�ѹ����ͺ")>
    <DataType(DataType.Date)>
    Public Property Scor_Date_Exam As Date

    Public Overridable Property book As book
    Public Overridable Property EmployeeInformation As EmployeeInformation

End Class
