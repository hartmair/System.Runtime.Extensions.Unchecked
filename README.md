# VB.NET Unchecked
Unchecked integer operations for VB.NET, see https://stackoverflow.com/questions/2403154/fastest-way-to-do-an-unchecked-integer-addition-in-vb-net.

## Get Started

Install nuget package `VBMath.Unchecked`

```vb
Using System.Numerics

' this will not throw
Dim value = UncheckedInteger.Add(Integer.MaxValue, 1)
```
