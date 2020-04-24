Namespace Numerics

    ''' <summary>
    ''' Provides utility methods for unchecked integer operations that do not throw <see cref="OverflowException"/>.
    ''' </summary>
    Public Class UncheckedInteger

        Public Shared Function Add(x As Byte, y As Byte) As Byte
            Return x + y
        End Function
        Public Shared Function Subtract(x As Byte, y As Byte) As Byte
            Return x - y
        End Function
        Public Shared Function Multiply(x As Byte, y As Byte) As Byte
            Return x * y
        End Function

        <CLSCompliant(False)>
        Public Shared Function Add(x As SByte, y As SByte) As SByte
            Return x + y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Subtract(x As SByte, y As SByte) As SByte
            Return x - y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Multiply(x As SByte, y As SByte) As SByte
            Return x * y
        End Function

        <CLSCompliant(False)>
        Public Shared Function Add(x As UShort, y As UShort) As UShort
            Return x + y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Subtract(x As UShort, y As UShort) As UShort
            Return x - y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Multiply(x As UShort, y As UShort) As UShort
            Return x * y
        End Function

        Public Shared Function Add(x As Short, y As Short) As Short
            Return x + y
        End Function
        Public Shared Function Subtract(x As Short, y As Short) As Short
            Return x - y
        End Function
        Public Shared Function Multiply(x As Short, y As Short) As Short
            Return x * y
        End Function

        <CLSCompliant(False)>
        Public Shared Function Add(x As UInteger, y As UInteger) As UInteger
            Return x + y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Subtract(x As UInteger, y As UInteger) As UInteger
            Return x - y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Multiply(x As UInteger, y As UInteger) As UInteger
            Return x * y
        End Function

        Public Shared Function Add(x As Integer, y As Integer) As Integer
            Return x + y
        End Function
        Public Shared Function Subtract(x As Integer, y As Integer) As Integer
            Return x - y
        End Function
        Public Shared Function Multiply(x As Integer, y As Integer) As Integer
            Return x * y
        End Function

        <CLSCompliant(False)>
        Public Shared Function Add(x As ULong, y As ULong) As ULong
            Return x + y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Subtract(x As ULong, y As ULong) As ULong
            Return x - y
        End Function
        <CLSCompliant(False)>
        Public Shared Function Multiply(x As ULong, y As ULong) As ULong
            Return x * y
        End Function

        Public Shared Function Add(x As Long, y As Long) As Long
            Return x + y
        End Function
        Public Shared Function Subtract(x As Long, y As Long) As Long
            Return x - y
        End Function
        Public Shared Function Multiply(x As Long, y As Long) As Long
            Return x * y
        End Function

    End Class

End Namespace
