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

Partial Public Class News
    Public Property news_id As Integer
    <Required(ErrorMessage:="��سҡ�͡ ��Ǣ�͢��� !")>
    <Display(Name:="��Ǣ�͢���")>
    Public Property news_title As String
    <Required(ErrorMessage:="��سҡ�͡ �����Ң��� !")>
    <Display(Name:="�����Ң���")>
    Public Property news_full_content As String
    <Required(ErrorMessage:="��سҡ�͡ ���ʾ�ѡ�ҹ !")>
    <Display(Name:="���ʾ�ѡ�ҹ")>
    Public Property emp_id As Integer
    <Required(ErrorMessage:="��سҡ�͡ �ѹ����С�� !")>
    <Display(Name:="�ѹ����С��")>
    <DataType(DataType.Date)>
    Public Property date_news_published As Date

    Public Overridable Property EmployeeInformation As EmployeeInformation

End Class
