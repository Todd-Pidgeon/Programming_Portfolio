Public Class CsStudent

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-4

    Inherits GeneralStudent

    ' Member variables
    Private dblCompSciHours As Double

    ' Constructor
    Public Sub New()
        dblCompSciHours = 0.0
    End Sub

    ' Overridden UpdateHours method.
    Public Overrides Sub UpdateHours()
        MyBase.UpdateHours()
        dblTotalHours += dblCompSciHours
    End Sub

    ' CompSciHours property procedure
    Public Property CompSciHours() As Double
        Get
            Return dblCompSciHours
        End Get
        Set(ByVal value As Double)
            dblCompSciHours = value
            UpdateHours()
        End Set
    End Property
End Class
