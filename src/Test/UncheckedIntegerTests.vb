Imports System.Numerics
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace Test

    <TestClass>
    Public Class UncheckedIntegerTests

        <TestMethod>
        Sub OverflowChecks()
            Assert.ThrowsException(Of OverflowException)(Sub()
                                                             Dim x = Integer.MaxValue
                                                             Dim y = 1
                                                             Dim value = x + y
                                                         End Sub)
        End Sub

        <DataRow(1, 1, 2)>
        <DataRow(Integer.MaxValue, 1, Integer.MinValue)>
        <DataRow(Integer.MinValue, -1, Integer.MaxValue)>
        <DataTestMethod>
        Sub Add(x As Integer, y As Integer, expected As Integer)
            Dim actual = UncheckedInteger.Add(x, y)
            Assert.AreEqual(expected, actual)
        End Sub

    End Class

End Namespace

