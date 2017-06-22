Public Class Person

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Programming Challenge 12-11

    ' Member variables
    Private strLastName As String
    Private strFirstName As String
    Private strAddress As String
    Private strCity As String
    Private strState As String
    Private strZip As String
    Private strPhone As String

    ' Constructor
    Public Sub New()
        Debug.WriteLine("Student object being created.")
        strFirstName = "(unknown)"
        strLastName = "(unknown)"
        strAddress = "(unknown)"
        strCity = "(unknown)"
        strState = "(unknown)"
        strZip = "(unknown)"
        strPhone = "(unknown)"

    End Sub

    ' Lastname property procedure
    Public Property Lastname() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property

    ' Firstname property procedure
    Public Property Firstname() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property

    ' Address property procedure
    Public Property Address() As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property

    ' City property procedure
    Public Property City() As String
        Get
            Return strCity
        End Get
        Set(ByVal value As String)
            strCity = value
        End Set
    End Property

    ' State property procedure
    Public Property State() As String
        Get
            Return strState
        End Get
        Set(ByVal value As String)
            strState = value
        End Set
    End Property

    ' Zip property procedure
    Public Property Zip() As String
        Get
            Return strZip
        End Get
        Set(ByVal value As String)
            strZip = value
        End Set
    End Property

    ' Phone property procedure
    Public Property Phone() As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
            strPhone = value
        End Set
    End Property
End Class
