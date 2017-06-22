Public Class PreferredCustomer
    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Programming Challege 12-12

    Inherits Customer
    ' Member variables
    Private decPurchaseAmount As Decimal
    Private sngDiscountLevel As Single

    ' Constructor
    Public Sub New()
        decPurchaseAmount = 0
        sngDiscountLevel = 0
    End Sub

    ' PurchaseAmount property procedure
    Public Property PurchaseAmount() As Decimal
        Get
            Return decPurchaseAmount
        End Get
        Set(ByVal value As Decimal)
            decPurchaseAmount = value
        End Set
    End Property

    ' DiscountLevel property procedure
    Public ReadOnly Property DiscountLevel() As Single
        Get
            ' Variable to hold the grade.

            ' Determine the level.
            If decPurchaseAmount >= 2000.0 Then
                sngDiscountLevel = 10
            ElseIf decPurchaseAmount >= 1500.0 Then
                sngDiscountLevel = 7
            ElseIf decPurchaseAmount >= 1000.0 Then
                sngDiscountLevel = 6
            ElseIf decPurchaseAmount >= 500.0 Then
                sngDiscountLevel = 5
            End If

            ' Return the grade.
            Return sngDiscountLevel
        End Get
    End Property
End Class
