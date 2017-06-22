Public Class GeneralStudent

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-4

    ' Member variables
    Private strLastName As String
    Private strFirstName As String
    Private strIdNum As String

    Private dblMathHours As Double
    Private dblCommHours As Double
    Private dblHumHours As Double
    Private dblElectHours As Double
    Protected dblTotalHours As Double

    ' Constructor
    Public Sub New()
        strFirstName = "(unknown)"
        strLastName = "(unknown)"
        strIdNum = "(unknown)"
        dblMathHours = 0.0
        dblCommHours = 0.0
        dblHumHours = 0.0
        dblElectHours = 0.0
        dblTotalHours = 0.0
    End Sub

    ' The UpdateHours procedure updates the hours completed.
    Public Overridable Sub UpdateHours()
        dblTotalHours = dblMathHours + dblCommHours + dblHumHours + dblElectHours
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
            Return strIdNum
        End Get
        Set(ByVal value As String)
            strIdNum = value
        End Set
    End Property

    ' MathHours property procedure
    Public Property MathHours() As Double
        Get
            Return dblMathHours
        End Get
        Set(ByVal value As Double)
            dblMathHours = value
        End Set
    End Property

    ' CommHours property procedure
    Public Property CommHours() As Double
        Get
            Return dblCommHours
        End Get
        Set(ByVal value As Double)
            dblCommHours = value
        End Set
    End Property

    ' HumHours property procedure
    Public Property HumHours() As Double
        Get
            Return dblHumHours
        End Get
        Set(ByVal value As Double)
            dblHumHours = value
        End Set
    End Property

    ' ElectHours property procedure
    Public Property ElectHours() As Double
        Get
            Return dblElectHours
        End Get
        Set(ByVal value As Double)
            dblElectHours = value
        End Set
    End Property

    ' HoursCompleted property (read-only)
    Public ReadOnly Property HoursCompleted() As Double
        Get
            Return dblTotalHours
        End Get
    End Property

    ' Overridden ToString method
    Public Overrides Function ToString() As String
        Dim str As String
        str = "Name: " & strLastName & ", " &
            strFirstName & " Completed Hours: " &
            dblTotalHours.ToString()
        Return str
    End Function
End Class
