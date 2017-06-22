Public Class Student

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-1

    ' Member variables
    Private strLastName As String
    Private strFirstName As String
    Private strIdNumber As String
    Private dblTestAverage As Double

    ' Constructor
    Public Sub New()
        Debug.WriteLine("Student object being created.")
        strFirstName = "(unknown)"
        strLastName = "(unknown)"
        strIdNumber = "(unknown)"
        dblTestAverage = 0.0
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

    ' IdNumber property procedure
    Public Property IdNumber() As String
        Get
            Return strIdNumber
        End Get
        Set(ByVal value As String)
            strIdNumber = value
        End Set
    End Property

    ' TestAverage property procedure
    Public Property TestAverage() As Double
        Get
            Return dblTestAverage
        End Get
        Set(ByVal value As Double)
            dblTestAverage = value
        End Set
    End Property

    ' Grade read-only property procedure
    Public ReadOnly Property Grade() As String
        Get
            ' Variable to hold the grade.
            Dim strGrade As String

            ' Determine the grade.
            If dblTestAverage >= 90.0 Then
                strGrade = "A"
            ElseIf dblTestAverage >= 80.0 Then
                strGrade = "B"
            ElseIf dblTestAverage >= 70.0 Then
                strGrade = "C"
            ElseIf dblTestAverage >= 60.0 Then
                strGrade = "D"
            Else
                strGrade = "F"
            End If

            ' Return the grade.
            Return strGrade
        End Get
    End Property
End Class
