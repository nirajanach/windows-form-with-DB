Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


<Table("UserTbl")>
Public Class AccountDetail
    <Column>
    <Key>
    Private _Id As Guid
    Public Property Id() As Guid
        Get
            Return _Id
        End Get
        Set(ByVal value As Guid)
            _Id = value
        End Set
    End Property

    <Column>
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property



    <Column>
    Private _Address As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property

    <Column>
    Private _City As String
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property

    <Column>
    Private _State As String
    Public Property State() As String
        Get
            Return _State
        End Get
        Set(ByVal value As String)
            _State = value
        End Set
    End Property

    <Column>
    Private _PostCode As Integer
    Public Property PostCode() As Integer
        Get
            Return _PostCode
        End Get
        Set(ByVal value As Integer)
            _PostCode = value
        End Set
    End Property

    <Column>
    Private _Contact As String
    Public Property Contact() As String
        Get
            Return _Contact
        End Get
        Set(ByVal value As String)
            _Contact = value
        End Set
    End Property

    <Column>
    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    <Column>
    Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property

    <Column>
    Private _Mobile1 As String
    Public Property Mobile1() As String
        Get
            Return _Mobile1
        End Get
        Set(ByVal value As String)
            _Mobile1 = value
        End Set
    End Property

    <Column>
    Private _Mobile2 As String
    Public Property Mobile2() As String
        Get
            Return _Mobile2
        End Get
        Set(ByVal value As String)
            _Mobile2 = value
        End Set
    End Property

    <Column>
    Private _Landline As Integer
    Public Property Landline() As Integer
        Get
            Return _Landline
        End Get
        Set(ByVal value As Integer)
            _Landline = value
        End Set
    End Property

    <Column>
    Private _Fax As Integer
    Public Property Fax() As Integer
        Get
            Return _Fax
        End Get
        Set(ByVal value As Integer)
            _Fax = value
        End Set
    End Property

    <Column>
    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    <Column>
    Private _Email2 As String
    Public Property Email2() As String
        Get
            Return _Email2
        End Get
        Set(ByVal value As String)
            _Email2 = value
        End Set
    End Property

    <Column>
    Private _Website As String
    Public Property Website() As String
        Get
            Return _Website
        End Get
        Set(ByVal value As String)
            _Website = value
        End Set
    End Property

    <Column>
    Private _ABN As Integer
    Public Property ABN() As Integer
        Get
            Return _ABN
        End Get
        Set(ByVal value As Integer)
            _ABN = value
        End Set
    End Property




End Class
