﻿using System;
using Foundatio.Parsers.LuceneQueries.Visitors;
using Nest;

namespace Foundatio.Parsers.ElasticQueries.Visitors {
    public interface IElasticQueryVisitorContext : IQueryVisitorContext {
        Operator DefaultOperator { get; set; }
        bool UseScoring { get; set; }
        string[] DefaultFields { get; set; }
        Func<string, IProperty> GetPropertyMappingFunc { get; set; }
    }
}