# Benchmarks.StringTrimTrailingChar

## Question

Is there any measurable difference between `string.EndsWith(char)` & `string[x] == char` for scenarios that conditionally remove a trailing character?

## Results

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT
  Job-TVHPKX : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT

LaunchCount=10  

```
|                            Method |       Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|       CharEquals_WithoutSemicolon |  0.2998 ns | 0.0048 ns | 0.0174 ns |    1 |      - |       0 B |
|          CharEquals_WithSemicolon | 13.0144 ns | 0.0431 ns | 0.1533 ns |    5 | 0.0152 |      48 B |
| CharEquals_InRef_WithoutSemicolon |  2.2023 ns | 0.0054 ns | 0.0198 ns |    3 |      - |       0 B |
|    CharEquals_InRef_WithSemicolon | 14.8911 ns | 0.0244 ns | 0.0866 ns |    7 | 0.0152 |      48 B |
|         EndsWith_WithoutSemicolon |  1.7061 ns | 0.0033 ns | 0.0118 ns |    2 |      - |       0 B |
|            EndsWith_WithSemicolon | 14.2716 ns | 0.0250 ns | 0.0905 ns |    6 | 0.0152 |      48 B |
|   EndsWith_InRef_WithoutSemicolon |  2.6133 ns | 0.0042 ns | 0.0152 ns |    4 |      - |       0 B |
|      EndsWith_InRef_WithSemicolon | 15.2992 ns | 0.0230 ns | 0.0813 ns |    8 | 0.0152 |      48 B |
