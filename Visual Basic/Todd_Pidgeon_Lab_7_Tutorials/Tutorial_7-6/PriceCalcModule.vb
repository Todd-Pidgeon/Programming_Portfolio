Module PriceCalcModule
    ' Global constants.
    Public Const g_intMINIMUM_FOR_DISCOUNT As Integer = 5
    Public Const g_decDISCOUNT_PERCENTAGE As Decimal = 0.1D

    ' The CalcDiscountfunction accepts a package total
    ' as an argument and returns the amount of discount
    ' for that total.

    Public Function CalcDiscount(decTotal As Decimal) As Decimal
        Dim decDiscount As Decimal ' To hold the discount.

        ' Calculate the discount.
        decDiscount = decTotal * g_decDISCOUNT_PERCENTAGE

        ' Return the discount.
        Return decDiscount
    End Function
End Module
