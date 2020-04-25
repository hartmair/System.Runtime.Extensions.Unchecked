# System.Runtime.Extensions.Unchecked
Unchecked integer operations for VB.NET, see [Fastest way to do an unchecked integer addition in VB.Net?
](https://stackoverflow.com/questions/2403154/fastest-way-to-do-an-unchecked-integer-addition-in-vb-net).

## Get Started

Install nuget package [VBMath.Unchecked](https://www.nuget.org/packages/VBMath.Unchecked)

```vb
Using System.Numerics

' this will not throw
Dim value = UncheckedInteger.Add(Integer.MaxValue, 1)
```

## Contribute

File an issue or provide a pull request.
