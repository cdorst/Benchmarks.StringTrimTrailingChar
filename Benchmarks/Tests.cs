using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using static Benchmarks.Constants;
using static Benchmarks.Scenarios;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    [RPlotExporter]
    [SimpleJob(10)]
    public class Tests
    {
        [Benchmark]
        public string CharEquals_WithoutSemicolon()
            => CharEquals(WithoutSemicolon);

        [Benchmark]
        public string CharEquals_WithSemicolon()
            => CharEquals(WithSemicolon);
        [Benchmark]
        public string CharEquals_InRef_WithoutSemicolon()
            => CharEquals_InRef(WithoutSemicolon);

        [Benchmark]
        public string CharEquals_InRef_WithSemicolon()
            => CharEquals_InRef(WithSemicolon);

        [Benchmark]
        public string EndsWith_WithoutSemicolon()
            => EndsWith(WithoutSemicolon);

        [Benchmark]
        public string EndsWith_WithSemicolon()
            => EndsWith(WithSemicolon);

        [Benchmark]
        public string EndsWith_InRef_WithoutSemicolon()
            => EndsWith_InRef(WithoutSemicolon);

        [Benchmark]
        public string EndsWith_InRef_WithSemicolon()
            => EndsWith_InRef(WithSemicolon);
    }
}
