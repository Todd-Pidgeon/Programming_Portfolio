Public Class Customer
    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Programming Challege 12-11

    Inherits Person
    ' Member variables
    Private intCustomerNumber As Integer
    Private bolMailingList As Boolean
    Private strComments As String

    ' Constructor
    Public Sub New()
        intCustomerNumber = 0
        bolMailingList = False
        strComments = "(unknown)"
    End Sub

    ' CustomerNumber property procedure
    Public Property CustomerNumber() As Integer
        Get
            Return intCustomerNumber
        End Get
        Set(ByVal value As Integer)
            intCustomerNumber = value
        End Set
    End Property

    ' MailingList property procedure
    Public Property MailingList() As Boolean
        Get
            Return bolMailingList
        End Get
        Set(ByVal value As Boolean)
            bolMailingList = value
        End Set
    End Property

    ' Comments property procedure
    Public Property Comments() As String
        Get
            Return strComments
        End Get
        Set(ByVal value As String)
            strComments = value
        End Set
    End Property
End Class
