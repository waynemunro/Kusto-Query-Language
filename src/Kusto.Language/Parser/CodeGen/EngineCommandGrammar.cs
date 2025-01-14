﻿// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// WARNING: Do not modify this file
//          This file is auto generated from the template file 'EngineCommandGrammar.tt'
//          Instead modify the corresponding input info file in the Kusto.Language.Generator project.
//          After making changes, use the right-click menu on the .tt file and select 'run custom tool'.

using System;
using System.Linq;
using System.Collections.Generic;
using Kusto.Language.Symbols;
using Kusto.Language.Syntax;
using Kusto.Language.Editor;

namespace Kusto.Language.Parsing
{
    using static Parsers<LexicalToken>;
    using static SyntaxParsers;
    using Utils;
    using System.Text;

    public class EngineCommandGrammar : CommandGrammar
    {
        public EngineCommandGrammar(GlobalState globals) : base(globals)
        {
        }

        internal override Parser<LexicalToken, Command>[] CreateCommandParsers(PredefinedRuleParsers rules)
        {
            var shape0 = CD(CompletionHint.Literal);
            var shape1 = new [] {CD(), CD("UserName", CompletionHint.Literal)};
            var shape2 = new [] {CD(), CD("Reason", CompletionHint.Literal)};
            var shape3 = new [] {CD("SkipResults"), CD(CompletionHint.Literal, isOptional: true)};
            var shape4 = CD(CompletionHint.Database);
            var shape5 = new [] {CD(), CD(), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape6 = new [] {CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal)};
            var shape7 = new [] {CD(), CD(), CD("RecoverabilityValue")};
            var shape8 = CD(CompletionHint.MaterializedView);
            var shape9 = new [] {CD(), CD(), CD("SoftDeleteValue", CompletionHint.Literal), CD(isOptional: true)};
            var shape10 = CD(CompletionHint.Table);
            var shape11 = CD(CompletionHint.Column);
            var shape12 = CD(CompletionHint.None);
            var shape13 = new [] {CD(), CD(), CD(), CD(), CD("PolicyName", CompletionHint.Literal)};
            var shape14 = new [] {CD(), CD(), CD(), CD(), CD("RowStorePolicy", CompletionHint.Literal)};
            var shape15 = CD(CompletionHint.Tabular);
            var shape16 = new [] {CD(), CD(), CD("HotData", CompletionHint.Literal), CD(), CD(), CD("HotIndex", CompletionHint.Literal)};
            var shape17 = new [] {CD(), CD(), CD("Timespan", CompletionHint.Literal)};
            var shape18 = new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal)};
            var shape19 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD()};
            var shape20 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("PolicyName", CompletionHint.Literal)};
            var shape21 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal)};
            var shape22 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("MergePolicy", CompletionHint.Literal)};
            var shape23 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ShardingPolicy", CompletionHint.Literal)};
            var shape24 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ShardsGroupingPolicy", CompletionHint.Literal)};
            var shape25 = new [] {CD("PropertyName", CompletionHint.None), CD(), CD("PropertyValue", CompletionHint.Literal)};
            var shape26 = new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD()};
            var shape27 = CD(CompletionHint.EntityGroup);
            var shape28 = new [] {CD(), CD(), CD("clusterName", CompletionHint.Literal), CD(), CD(), CD(), CD(), CD("databaseName", CompletionHint.Literal), CD()};
            var shape29 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Literal), CD()};
            var shape30 = new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.EntityGroup), CD(), CD(), CD()};
            var shape31 = new [] {CD(), CD(CompletionHint.Tabular)};
            var shape32 = new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD("csl")};
            var shape33 = new [] {CD("ColumnName", CompletionHint.None), CD(), CD("ColumnType")};
            var shape34 = new [] {CD("PartitionType"), CD(isOptional: true)};
            var shape35 = new [] {CD(), CD(CompletionHint.Literal, isOptional: true)};
            var shape36 = new [] {CD(), CD(), CD("DateTimeFormat", CompletionHint.Literal), CD(), CD("PartitionName", CompletionHint.None), CD()};
            var shape37 = new [] {CD("PropertyName", CompletionHint.None), CD(), CD("Value", CompletionHint.Literal)};
            var shape38 = new [] {CD(), CD(), CD(CompletionHint.None), CD()};
            var shape39 = CD(CompletionHint.ExternalTable);
            var shape40 = new [] {CD(), CD(), CD("modificationKind")};
            var shape41 = new [] {CD("d1", CompletionHint.Literal), CD(), CD("d2", CompletionHint.Literal)};
            var shape42 = new [] {CD(), CD(), CD("p", CompletionHint.Literal)};
            var shape43 = new [] {CD(), CD(), CD("databaseNameOverride", CompletionHint.None)};
            var shape44 = new [] {CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal), CD()};
            var shape45 = new [] {CD(), CD("serializedDatabaseMetadataOverride", CompletionHint.Literal)};
            var shape46 = new [] {CD(), CD(), CD("prefetchExtents", CompletionHint.Literal)};
            var shape47 = new [] {CD(), CD("name", CompletionHint.MaterializedView)};
            var shape48 = new [] {CD(), CD("name", CompletionHint.Table)};
            var shape49 = new [] {CD(), CD(), CD("hotDataToken", CompletionHint.Literal), CD(), CD(), CD("hotIndexToken", CompletionHint.Literal)};
            var shape50 = new [] {CD(), CD(), CD("hotToken", CompletionHint.Literal)};
            var shape51 = CD(isOptional: true);
            var shape52 = CD(CompletionHint.Function);
            var shape53 = new [] {CD("PropertyName"), CD(), CD("PropertyValue", CompletionHint.Literal)};
            var shape54 = new [] {CD(), CD(), CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView)};
            var shape55 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD()};
            var shape56 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape57 = new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD()};
            var shape58 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD()};
            var shape59 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal)};
            var shape60 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("MergePolicy", CompletionHint.Literal)};
            var shape61 = new [] {CD("ColumnName", CompletionHint.Column), CD()};
            var shape62 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(CompletionHint.Column), CD()};
            var shape63 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("ShardingPolicy", CompletionHint.Literal)};
            var shape64 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("UpdatePolicy", CompletionHint.Literal)};
            var shape65 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(), CD(isOptional: true)};
            var shape66 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD("rowStoreKey", CompletionHint.Literal), CD(isOptional: true)};
            var shape67 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD("rowStoreName", CompletionHint.None), CD(isOptional: true)};
            var shape68 = new [] {CD(), CD(), CD(CompletionHint.Table), CD(), CD(CompletionHint.None), CD(), CD(isOptional: true)};
            var shape69 = new [] {CD("ColumnName", CompletionHint.Column), CD(), CD("DocString", CompletionHint.Literal)};
            var shape70 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(CompletionHint.Column), CD()};
            var shape71 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape72 = new [] {CD("BlobContainerUrl", CompletionHint.Literal), CD(), CD("StorageAccountKey", CompletionHint.Literal)};
            var shape73 = new [] {CD(), CD(CompletionHint.Database), CD()};
            var shape74 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD(), CD(), CD(), CD("TableKind"), CD(), CD(), CD(CompletionHint.None), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape75 = new [] {CD("PartitionFunction"), CD(), CD("DateTimeColumn", CompletionHint.None), CD(), CD("BinValue", CompletionHint.Literal), CD()};
            var shape76 = new [] {CD("PartitionFunction"), CD(), CD("DateTimeColumn", CompletionHint.None), CD()};
            var shape77 = new [] {CD("PartitionType"), CD(), CD("PartitionFunction"), CD(), CD("StringColumn", CompletionHint.None), CD(), CD("HashMod", CompletionHint.Literal), CD()};
            var shape78 = new [] {CD(), CD("StringColumn", CompletionHint.None)};
            var shape79 = new [] {CD("PartitionName", CompletionHint.None), CD(), CD()};
            var shape80 = new [] {CD("PathSeparator", CompletionHint.Literal), CD()};
            var shape81 = new [] {CD(), CD(), CD(), CD(CompletionHint.Literal), CD()};
            var shape82 = new [] {CD(), CD(), CD(), CD(CompletionHint.None), CD(), CD(isOptional: true), CD()};
            var shape83 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD(), CD(), CD(), CD("TableKind"), CD(), CD(), CD("DataFormatKind"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape84 = new [] {CD(), CD(), CD(), CD(), CD(), CD(CompletionHint.Table), CD()};
            var shape85 = new [] {CD(), CD(), CD("WorkloadGroupName", CompletionHint.None), CD("WorkloadGroup", CompletionHint.Literal)};
            var shape86 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)};
            var shape87 = new [] {CD(), CD(isOptional: true)};
            var shape88 = new [] {CD(), CD(), CD(isOptional: true)};
            var shape89 = new [] {CD("TableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD()};
            var shape90 = new [] {CD(), CD(), CD(CompletionHint.None), CD(isOptional: true)};
            var shape91 = new [] {CD(), CD(), CD("TableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD(), CD(isOptional: true)};
            var shape92 = new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD()};
            var shape93 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD()};
            var shape94 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD()};
            var shape95 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD()};
            var shape96 = new [] {CD(), CD("LimitCount", CompletionHint.Literal)};
            var shape97 = new [] {CD(), CD("AppName", CompletionHint.Literal), CD(isOptional: true)};
            var shape98 = new [] {CD(), CD(), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape99 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD()};
            var shape100 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape101 = new [] {CD(), CD("TableName", CompletionHint.Table)};
            var shape102 = new [] {CD(), CD(), CD(), CD("TrimSize", CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape103 = new [] {CD(), CD(), CD(), CD("externalTableName", CompletionHint.ExternalTable), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape104 = new [] {CD(), CD(), CD(CompletionHint.Database), CD()};
            var shape105 = new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape106 = new [] {CD(), CD(), CD("materializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)};
            var shape107 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape108 = new [] {CD(), CD(), CD("ContinuousExportName", CompletionHint.None)};
            var shape109 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView)};
            var shape110 = new [] {CD(), CD(CompletionHint.Literal), CD()};
            var shape111 = new [] {CD(), CD(), CD(CompletionHint.None)};
            var shape112 = new [] {CD(), CD(), CD(), CD("QueryOrCommand", CompletionHint.Tabular)};
            var shape113 = new [] {CD(), CD("TableName", CompletionHint.None)};
            var shape114 = new [] {CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape115 = new [] {CD(), CD(), CD("StoredQueryResultName", CompletionHint.None), CD(), CD("Query", CompletionHint.Tabular)};
            var shape116 = new [] {CD(), CD(), CD(), CD(), CD("Scope"), CD()};
            var shape117 = new [] {CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()};
            var shape118 = new [] {CD(), CD(), CD("Tag", CompletionHint.Literal)};
            var shape119 = new [] {CD(), CD(), CD(), CD(), CD(isOptional: true)};
            var shape120 = new [] {CD(), CD(), CD("ContinuousExportName", CompletionHint.None), CD()};
            var shape121 = new [] {CD(), CD("Version", CompletionHint.Literal)};
            var shape122 = new [] {CD("DatabaseName", CompletionHint.Database), CD(isOptional: true)};
            var shape123 = new [] {CD(), CD(), CD(), CD(isOptional: true), CD(), CD(isOptional: true)};
            var shape124 = new [] {CD(), CD(CompletionHint.Database, isOptional: true)};
            var shape125 = new [] {CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)};
            var shape126 = new [] {CD(), CD("databaseVersion", CompletionHint.Literal)};
            var shape127 = new [] {CD("databaseName", CompletionHint.Database), CD()};
            var shape128 = new [] {CD("DatabaseName", CompletionHint.Database), CD()};
            var shape129 = new [] {CD(), CD("Version", CompletionHint.Literal), CD()};
            var shape130 = new [] {CD(), CD(), CD(), CD(isOptional: true)};
            var shape131 = new [] {CD(), CD(), CD("DatabaseName"), CD(), CD()};
            var shape132 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD()};
            var shape133 = new [] {CD("Principal", CompletionHint.Literal), CD()};
            var shape134 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD()};
            var shape135 = new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.EntityGroup)};
            var shape136 = new [] {CD(), CD("excludedFunctions", CompletionHint.Literal)};
            var shape137 = new [] {CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape138 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD()};
            var shape139 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD("MappingName", CompletionHint.Literal)};
            var shape140 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable)};
            var shape141 = new [] {CD(), CD("databaseName", CompletionHint.Database)};
            var shape142 = new [] {CD(), CD("threshold", CompletionHint.Literal)};
            var shape143 = new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD(isOptional: true)};
            var shape144 = new [] {CD("kind"), CD()};
            var shape145 = new [] {CD(), CD(CompletionHint.MaterializedView), CD(), CD()};
            var shape146 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD()};
            var shape147 = new [] {CD(), CD(), CD("viewName", CompletionHint.MaterializedView), CD(), CD(isOptional: true)};
            var shape148 = new [] {CD(), CD(), CD("viewName", CompletionHint.MaterializedView), CD()};
            var shape149 = new [] {CD(), CD(CompletionHint.Table), CD(), CD()};
            var shape150 = new [] {CD(), CD(CompletionHint.Table), CD()};
            var shape151 = new [] {CD(), CD(), CD(CompletionHint.Table), CD()};
            var shape152 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD()};
            var shape153 = new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD()};
            var shape154 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal)};

            Func<SyntaxElement> missing0 = () => CreateMissingToken("(");
            Func<SyntaxElement> missing1 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral()));
            Func<SyntaxElement> missing2 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal), CD("operationRole")}, CreateMissingToken("from"), rules.MissingStringLiteral(), CreateMissingToken("admins", "monitors", "unrestrictedviewers", "users", "viewers"));
            Func<SyntaxElement> missing3 = () => (SyntaxElement)new CustomNode(shape7, CreateMissingToken("recoverability"), CreateMissingToken("="), CreateMissingToken("disabled", "enabled"));
            Func<SyntaxElement> missing4 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape28, CreateMissingToken("cluster"), CreateMissingToken("("), rules.MissingStringLiteral(), CreateMissingToken(")"), CreateMissingToken("."), CreateMissingToken("database"), CreateMissingToken("("), rules.MissingStringLiteral(), CreateMissingToken(")"))));
            Func<SyntaxElement> missing5 = () => (SyntaxElement)new CustomNode(shape31, CreateMissingToken("<|"), rules.MissingExpression());
            Func<SyntaxElement> missing6 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape61, rules.MissingNameReference(), CreateMissingToken("asc", "desc"))));
            Func<SyntaxElement> missing7 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape33, rules.MissingNameDeclaration(), CreateMissingToken(":"), rules.MissingType())));
            Func<SyntaxElement> missing8 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("docstring"), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing9 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape69, rules.MissingNameReference(), CreateMissingToken(":"), rules.MissingStringLiteral())));
            Func<SyntaxElement> missing10 = () => CreateMissingToken("*");
            Func<SyntaxElement> missing11 = () => (SyntaxElement)new CustomNode(shape16, CreateMissingToken("hotdata"), CreateMissingToken("="), rules.MissingValue(), CreateMissingToken("hotindex"), CreateMissingToken("="), rules.MissingValue());
            Func<SyntaxElement> missing12 = () => CreateMissingToken("<|");
            Func<SyntaxElement> missing13 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape25, rules.MissingNameDeclaration(), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing14 = () => CreateMissingToken("decryption-certificate-thumbprint");
            Func<SyntaxElement> missing15 = () => (SyntaxElement)new CustomNode(shape72, rules.MissingStringLiteral(), CreateMissingToken(";"), rules.MissingStringLiteral());
            Func<SyntaxElement> missing16 = () => CreateMissingToken("disable", "enable");
            Func<SyntaxElement> missing17 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD("hours", CompletionHint.Literal), CD()}, CreateMissingToken("older"), rules.MissingValue(), CreateMissingToken("hours"));
            Func<SyntaxElement> missing18 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape37, rules.MissingNameDeclaration(), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing19 = () => CreateMissingToken("adl");
            Func<SyntaxElement> missing20 = () => (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")"));
            Func<SyntaxElement> missing21 = () => (SyntaxElement)new CustomNode(shape34, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")"))));
            Func<SyntaxElement> missing22 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape79, rules.MissingNameDeclaration(), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape34, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")")))))));
            Func<SyntaxElement> missing23 = () => new SyntaxList<SyntaxElement>((SyntaxElement)new CustomNode(shape35, (SyntaxElement)new CustomNode(shape36, CreateMissingToken("datetime_pattern"), CreateMissingToken("("), rules.MissingStringLiteral(), CreateMissingToken(","), rules.MissingNameDeclaration(), CreateMissingToken(")")), rules.MissingStringLiteral()));
            Func<SyntaxElement> missing24 = () => (SyntaxElement)new CustomNode(shape80, rules.MissingStringLiteral(), new SyntaxList<SyntaxElement>((SyntaxElement)new CustomNode(shape35, (SyntaxElement)new CustomNode(shape36, CreateMissingToken("datetime_pattern"), CreateMissingToken("("), rules.MissingStringLiteral(), CreateMissingToken(","), rules.MissingNameDeclaration(), CreateMissingToken(")")), rules.MissingStringLiteral())));
            Func<SyntaxElement> missing25 = () => CreateMissingToken("dataformat");
            Func<SyntaxElement> missing26 = () => CreateMissingToken("from");
            Func<SyntaxElement> missing27 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(), CD("databaseNamePrefix", CompletionHint.None)}, CreateMissingToken("database-name-prefix"), CreateMissingToken("="), rules.MissingNameDeclaration());
            Func<SyntaxElement> missing28 = () => (SyntaxElement)new CustomNode(shape49, CreateMissingToken("hotdata"), CreateMissingToken("="), rules.MissingValue(), CreateMissingToken("hotindex"), CreateMissingToken("="), rules.MissingValue());
            Func<SyntaxElement> missing29 = () => (SyntaxElement)new CustomNode(shape41, rules.MissingValue(), CreateMissingToken(".."), rules.MissingValue());
            Func<SyntaxElement> missing30 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape42, CreateMissingToken("hot_window"), CreateMissingToken("="), (SyntaxElement)new CustomNode(shape41, rules.MissingValue(), CreateMissingToken(".."), rules.MissingValue()))));
            Func<SyntaxElement> missing31 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameDeclaration()));
            Func<SyntaxElement> missing32 = () => (SyntaxElement)new CustomNode(shape38, CreateMissingToken("materialized-views"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameDeclaration())), CreateMissingToken(")"));
            Func<SyntaxElement> missing33 = () => (SyntaxElement)new CustomNode(shape44, CreateMissingToken("from"), rules.MissingStringLiteral(), (SyntaxElement)new CustomNode(shape38, CreateMissingToken("materialized-views"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameDeclaration())), CreateMissingToken(")")));
            Func<SyntaxElement> missing34 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("FunctionName", CompletionHint.Function)}, CreateMissingToken("with"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape37, rules.MissingNameDeclaration(), CreateMissingToken("="), rules.MissingValue()))), CreateMissingToken(")"), rules.MissingNameReference());
            Func<SyntaxElement> missing35 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("dimensionTables"), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing36 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD("policies", CompletionHint.Literal)}, CreateMissingToken("internal"), rules.MissingStringLiteral());
            Func<SyntaxElement> missing37 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameReference()));
            Func<SyntaxElement> missing38 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(new [] {CD("ColumnName", CompletionHint.None), CD()}, rules.MissingNameDeclaration(), CreateMissingToken("asc", "desc"))));
            Func<SyntaxElement> missing39 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("Query", CompletionHint.Literal)}, CreateMissingToken("with"), CreateMissingToken("("), SyntaxList<SeparatedElement<SyntaxElement>>.Empty(), CreateMissingToken(")"), rules.MissingStringLiteral());
            Func<SyntaxElement> missing40 = () => (SyntaxElement)new CustomNode(shape101, CreateMissingToken("async"), rules.MissingNameReference());
            Func<SyntaxElement> missing41 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("creationTime"), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing42 = () => new SyntaxList<SyntaxElement>(rules.MissingValue());
            Func<SyntaxElement> missing43 = () => CreateMissingToken("extents");
            Func<SyntaxElement> missing44 = () => (SyntaxElement)new CustomNode(CreateMissingToken("async"), CreateMissingToken("extents"));
            Func<SyntaxElement> missing45 = () => (SyntaxElement)new CustomNode(CreateMissingToken("async"), CreateMissingToken("table"));
            Func<SyntaxElement> missing46 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape33, rules.MissingNameDeclaration(), CreateMissingToken(":"), rules.MissingType()))), CreateMissingToken(")"))));
            Func<SyntaxElement> missing47 = () => (SyntaxElement)new CustomNode(shape26, CreateMissingToken("over"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameDeclaration())), CreateMissingToken(")"), CreateMissingToken("to"));
            Func<SyntaxElement> missing48 = () => (SyntaxElement)new CustomNode(shape34, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")"))));
            Func<SyntaxElement> missing49 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape79, rules.MissingNameDeclaration(), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape34, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")")))))));
            Func<SyntaxElement> missing50 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("FunctionName", CompletionHint.None)}, CreateMissingToken("with"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape37, rules.MissingNameDeclaration(), CreateMissingToken("="), rules.MissingValue()))), CreateMissingToken(")"), rules.MissingNameDeclaration());
            Func<SyntaxElement> missing51 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("autoUpdateSchema"), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing52 = () => (SyntaxElement)new CustomNode(shape54, CreateMissingToken("with"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("autoUpdateSchema"), CreateMissingToken("="), rules.MissingValue()))), CreateMissingToken(")"), rules.MissingNameReference());
            Func<SyntaxElement> missing53 = () => (SyntaxElement)new CustomNode(shape34, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")"))));
            Func<SyntaxElement> missing54 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape79, rules.MissingNameDeclaration(), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape34, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape75, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(), CreateMissingToken(","), rules.MissingValue(), CreateMissingToken(")")))))));
            Func<SyntaxElement> missing55 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(), CD(), CD(), CD("MaterializedViewName", CompletionHint.None)}, CreateMissingToken("with"), CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("autoUpdateSchema"), CreateMissingToken("="), rules.MissingValue()))), CreateMissingToken(")"), rules.MissingNameDeclaration());
            Func<SyntaxElement> missing56 = () => (SyntaxElement)new CustomNode(CreateMissingToken("async"), CreateMissingToken("table"));
            Func<SyntaxElement> missing57 = () => (SyntaxElement)new CustomNode(CreateMissingToken("all"), CreateMissingToken("tables"));
            Func<SyntaxElement> missing58 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingValue()));
            Func<SyntaxElement> missing59 = () => (SyntaxElement)new CustomNode(CreateMissingToken("all"), CreateMissingToken("tables"));
            Func<SyntaxElement> missing60 = () => (SyntaxElement)new CustomNode(CreateMissingToken("all"), CreateMissingToken("tables"));
            Func<SyntaxElement> missing61 = () => (SyntaxElement)new CustomNode(shape114, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingValue())), CreateMissingToken(")"), (SyntaxElement)new CustomNode(shape101, CreateMissingToken("from"), rules.MissingNameReference()));
            Func<SyntaxElement> missing62 = () => (SyntaxElement)new CustomNode(CreateMissingToken("database"), CreateMissingToken("script"));
            Func<SyntaxElement> missing63 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD("Data", CompletionHint.None), CD()}, CreateMissingToken("["), rules.MissingInputText(), CreateMissingToken("]"));
            Func<SyntaxElement> missing64 = () => (SyntaxElement)new CustomNode(CreateMissingToken("async"), CreateMissingToken("into"));
            Func<SyntaxElement> missing65 = () => (SyntaxElement)new CustomNode(shape110, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral())), CreateMissingToken(")"));
            Func<SyntaxElement> missing66 = () => (SyntaxElement)new CustomNode(CreateMissingToken("async"), CreateMissingToken("extents"));
            Func<SyntaxElement> missing67 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(new [] {CD("NewColumnName", CompletionHint.None), CD(), CD("ColumnName", CompletionHint.Column)}, rules.MissingNameDeclaration(), CreateMissingToken("="), rules.MissingNameReference())));
            Func<SyntaxElement> missing68 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(new [] {CD("NewTableName", CompletionHint.None), CD(), CD("TableName", CompletionHint.Table)}, rules.MissingNameDeclaration(), CreateMissingToken("="), rules.MissingNameReference())));
            Func<SyntaxElement> missing69 = () => (SyntaxElement)new CustomNode(CreateMissingToken("async"), CreateMissingToken("extents"));
            Func<SyntaxElement> missing70 = () => (SyntaxElement)new CustomNode(shape113, CreateMissingToken("async"), rules.MissingNameDeclaration());
            Func<SyntaxElement> missing71 = () => (SyntaxElement)new CustomNode(shape114, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral())), CreateMissingToken(")"), (SyntaxElement)new CustomNode(shape3, CreateMissingToken("skip-results"), rules.MissingStringLiteral()));
            Func<SyntaxElement> missing72 = () => (SyntaxElement)new CustomNode(shape114, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral())), CreateMissingToken(")"), (SyntaxElement)new CustomNode(shape35, CreateMissingToken("skip-results"), rules.MissingStringLiteral()));
            Func<SyntaxElement> missing73 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)}, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral())), CreateMissingToken(")"), rules.MissingStringLiteral());
            Func<SyntaxElement> missing74 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape118, CreateMissingToken("tags"), CreateMissingToken("!contains", "!has", "contains", "has"), rules.MissingStringLiteral())));
            Func<SyntaxElement> missing75 = () => CreateMissingToken("roles");
            Func<SyntaxElement> missing76 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape122, rules.MissingNameReference(), (SyntaxElement)new CustomNode(shape121, CreateMissingToken("if_later_than"), rules.MissingStringLiteral()))));
            Func<SyntaxElement> missing77 = () => CreateMissingToken("mappings");
            Func<SyntaxElement> missing78 = () => (SyntaxElement)new CustomNode(shape35, CreateMissingToken("operations"), rules.MissingValue());
            Func<SyntaxElement> missing79 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD(CompletionHint.Literal)}, CreateMissingToken("details"), rules.MissingValue());
            Func<SyntaxElement> missing80 = () => (SyntaxElement)new CustomNode(shape87, CreateMissingToken("databases"), (SyntaxElement)new CustomNode(shape73, CreateMissingToken("("), SyntaxList<SeparatedElement<SyntaxElement>>.Empty(), CreateMissingToken(")")));
            Func<SyntaxElement> missing81 = () => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape53, CreateMissingToken("reconstructCsl"), CreateMissingToken("="), rules.MissingValue())));
            Func<SyntaxElement> missing82 = () => (SyntaxElement)new CustomNode(CreateMissingToken("corrupted"), CreateMissingToken("datetime"));
            Func<SyntaxElement> missing83 = () => (SyntaxElement)new CustomNode(new [] {CD(), CD("TableName", CompletionHint.None), CD()}, CreateMissingToken("as"), rules.MissingNameDeclaration(), CreateMissingToken("version"));

            var fragment0 = Custom(
                    Token("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape1);
            var fragment1 = Custom(
                    Token("reason"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape2);
            var fragment2 = Custom(
                    Token("skip-results"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape0)),
                    shape3);
            var fragment3 = Custom(
                    Token("recoverability"),
                    RequiredToken("="),
                    RequiredToken("disabled", "enabled"),
                    shape7);
            var fragment4 = Custom(
                    Token("softdelete"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    Optional(
                        fragment3),
                    shape9);
            var fragment5 = Custom(
                    Token("hotdata"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken("hotindex"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape16);
            var fragment6 = Custom(
                    Token("hot"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape17);
            var fragment7 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape25)),
                        missing13),
                    RequiredToken(")"),
                    RequiredToken("decryption-certificate-thumbprint"),
                    shape26);
            var fragment8 = Custom(
                    Token("cluster"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(")"),
                    RequiredToken("."),
                    RequiredToken("database"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(")"),
                    shape28);
            var fragment9 = Custom(
                    Token("database"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(")"),
                    shape29);
            var fragment10 = Custom(
                    Token("async"),
                    Token("extent"));
            var fragment11 = Custom(
                    Token("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape31);
            var fragment12 = Custom(
                    rules.NameDeclaration,
                    RequiredToken(":"),
                    Required(rules.Type, rules.MissingType),
                    shape33);
            var fragment13 = Custom(
                    rules.NameDeclaration,
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape37);
            var fragment14 = Custom(
                    Token("datetime_pattern"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(","),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken(")"),
                    shape36);
            var fragment15 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment13),
                        missing18),
                    RequiredToken(")"),
                    shape38);
            var fragment16 = Custom(
                    Token("hot_window"),
                    RequiredToken("="),
                    Required(
                        Custom(
                            rules.Value,
                            RequiredToken(".."),
                            Required(rules.Value, rules.MissingValue),
                            shape41),
                        missing29),
                    shape42);
            var fragment17 = Custom(
                    Token("caching-policies-modification-kind"),
                    Token("="),
                    Token("none", "replace", "union"),
                    shape40);
            var fragment18 = Custom(
                    Token("caching-policies-modification-kind"),
                    RequiredToken("="),
                    RequiredToken("none", "replace", "union"),
                    shape40);
            var fragment19 = Custom(
                    Token("database-name-override"),
                    RequiredToken("="),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape43);
            var fragment20 = Custom(
                    Token("metadata"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape45);
            var fragment21 = Custom(
                    Token("prefetch-extents"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape46);
            var fragment22 = Custom(
                    Token("principals-modification-kind"),
                    RequiredToken("="),
                    RequiredToken("none", "replace", "union"),
                    shape40);
            var fragment23 = Custom(
                    Token("external"),
                    Token("tables"));
            var fragment24 = Custom(
                    Token("external"),
                    RequiredToken("tables"));
            var fragment25 = Custom(
                    Token("materialized-views"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                shape12),
                            missingElement: rules.MissingNameDeclaration),
                        missing31),
                    RequiredToken(")"),
                    shape38);
            var fragment26 = Custom(
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape47);
            var fragment27 = Custom(
                    Token("tables"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                shape12),
                            missingElement: rules.MissingNameDeclaration),
                        missing31),
                    RequiredToken(")"),
                    shape38);
            var fragment28 = Custom(
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    shape48);
            var fragment29 = Custom(
                    Token(","),
                    Required(
                        OneOrMoreCommaList(
                            fragment16),
                        missing30));
            var fragment30 = Custom(
                    rules.ColumnNameReference,
                    RequiredToken("asc", "desc"),
                    shape61);
            var fragment31 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    Token("docstring"),
                                    Token("folder"),
                                    If(Not(And(Token("docstring", "folder"))), rules.NameDeclaration)),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape53)),
                        missing8),
                    RequiredToken(")"));
            var fragment32 = Custom(
                    rules.ColumnNameReference,
                    RequiredToken(":"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape69);
            var fragment33 = Custom(
                    rules.StringLiteral,
                    Token(";"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape72);
            var fragment34 = Custom(
                    Token("("),
                    ZeroOrMoreCommaList(
                        Custom(
                            If(Not(Token(")")), rules.DatabaseNameReference),
                            shape4),
                        missingElement: rules.MissingNameReference
                        ),
                    RequiredToken(")"),
                    shape73);
            var fragment35 = Custom(
                    Token("partition"),
                    RequiredToken("by"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken(":"),
                                Required(
                                    First(
                                        Custom(
                                            Token("datetime"),
                                            Optional(
                                                Custom(
                                                    Token("="),
                                                    Required(
                                                        First(
                                                            Custom(
                                                                Token("bin"),
                                                                RequiredToken("("),
                                                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                                                RequiredToken(","),
                                                                Required(rules.Value, rules.MissingValue),
                                                                RequiredToken(")"),
                                                                shape75),
                                                            Custom(
                                                                Token("startofday", "startofmonth", "startofweek", "startofyear"),
                                                                RequiredToken("("),
                                                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                                                RequiredToken(")"),
                                                                shape76)),
                                                        missing20))),
                                            shape34),
                                        Custom(
                                            Token("long"),
                                            RequiredToken("="),
                                            RequiredToken("hash"),
                                            RequiredToken("("),
                                            Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                            RequiredToken(","),
                                            Required(rules.Value, rules.MissingValue),
                                            RequiredToken(")"),
                                            shape77),
                                        Custom(
                                            Token("string"),
                                            Optional(
                                                Custom(
                                                    Token("="),
                                                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                                    shape78)),
                                            shape34)),
                                    missing48),
                                shape79)),
                        missing49),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("pathformat"),
                            RequiredToken("="),
                            RequiredToken("("),
                            Required(
                                First(
                                    Custom(
                                        rules.StringLiteral,
                                        Required(
                                            OneOrMoreList(
                                                Custom(
                                                    First(
                                                        fragment14,
                                                        Custom(
                                                            If(Not(Token("datetime_pattern")), rules.NameDeclaration),
                                                            shape12)),
                                                    Optional(
                                                        Custom(
                                                            rules.StringLiteral,
                                                            shape0)),
                                                    shape35)),
                                            missing23),
                                        shape80),
                                    OneOrMoreList(
                                        Custom(
                                            First(
                                                Custom(
                                                    Token("datetime_pattern"),
                                                    RequiredToken("("),
                                                    rules.StringLiteral,
                                                    Token(","),
                                                    rules.NameDeclaration,
                                                    Token(")"),
                                                    shape36),
                                                fragment14,
                                                Custom(
                                                    If(Not(Token("datetime_pattern")), rules.NameDeclaration),
                                                    shape12)),
                                            Optional(
                                                Custom(
                                                    rules.StringLiteral,
                                                    shape0)),
                                            shape35))),
                                missing24),
                            RequiredToken(")"),
                            shape81)),
                    RequiredToken("dataformat"),
                    shape82);
            var fragment36 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    ZeroOrMoreCommaList(
                        fragment13),
                    RequiredToken(")"),
                    shape38);
            var fragment37 = Custom(
                    rules.NameDeclaration,
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing7),
                    RequiredToken(")"),
                    shape89);
            var fragment38 = Custom(
                    First(
                        Token("autoUpdateSchema"),
                        Token("backfill"),
                        Token("dimensionTables"),
                        Token("docString"),
                        Token("effectiveDateTime"),
                        Token("folder"),
                        Token("lookback"),
                        Token("updateExtentsCreationTime"),
                        If(Not(And(Token("autoUpdateSchema", "backfill", "dimensionTables", "docString", "effectiveDateTime", "folder", "lookback", "updateExtentsCreationTime"))), rules.NameDeclaration)),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape53);
            var fragment39 = Custom(
                    Token("async"),
                    RequiredToken("table"));
            var fragment40 = Custom(
                    Token("limit"),
                    Required(rules.Value, rules.MissingValue),
                    shape96);
            var fragment41 = Custom(
                    Token("application"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment0),
                    shape97);
            var fragment42 = Custom(
                    Token("all"),
                    RequiredToken("tables"));
            var fragment43 = Custom(
                    Token("trim"),
                    RequiredToken("by"),
                    RequiredToken("datasize", "extentsize"),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken("bytes", "GB", "MB"),
                    Optional(
                        fragment40),
                    shape102);
            var fragment44 = Custom(
                    Token("from"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    shape101);
            var fragment45 = Custom(
                    Token("skip-results"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape0)),
                    shape35);
            var fragment46 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment13),
                        missing13),
                    RequiredToken(")"),
                    RequiredToken("<|"),
                    shape26);
            var fragment47 = Custom(
                    Token("async"),
                    Token("to"));
            var fragment48 = Custom(
                    First(
                        Token("creationTime"),
                        Token("distributed"),
                        Token("docstring"),
                        Token("extend_schema"),
                        Token("folder"),
                        Token("format"),
                        Token("ignoreFirstRecord"),
                        Token("ingestIfNotExists"),
                        Token("ingestionMappingReference"),
                        Token("ingestionMapping"),
                        Token("persistDetails"),
                        Token("policy_ingestionTime"),
                        Token("recreate_schema"),
                        Token("tags"),
                        Token("validationPolicy"),
                        Token("zipPattern"),
                        If(Not(And(Token("creationTime", "distributed", "docstring", "extend_schema", "folder", "format", "ignoreFirstRecord", "ingestIfNotExists", "ingestionMappingReference", "ingestionMapping", "persistDetails", "policy_ingestionTime", "recreate_schema", "tags", "validationPolicy", "zipPattern"))), rules.NameDeclaration)),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape53);
            var fragment49 = Custom(
                    Token("async"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    shape101);
            var fragment50 = Custom(
                    Token("async"),
                    RequiredToken("extents"));
            var fragment51 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment48),
                        missing41),
                    RequiredToken(")"),
                    RequiredToken("<|"));
            var fragment52 = Custom(
                    Token("async"),
                    Required(If(Not(Token("stored_query_result")), rules.NameDeclaration), rules.MissingNameDeclaration),
                    shape113);
            var fragment53 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape114);
            var fragment54 = Custom(
                    Token("none"),
                    Optional(
                        Custom(
                            Token("skip-results"))),
                    shape87);
            var fragment55 = Custom(
                    Token("async"),
                    Token("stored_query_result"));
            var fragment56 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    RequiredToken("scope"),
                    RequiredToken("="),
                    RequiredToken("cluster", "workloadgroup"),
                    RequiredToken(")"),
                    shape116);
            var fragment57 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    RequiredToken("extentsShowFilteringRuntimePolicy"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken(")"),
                    shape117);
            var fragment58 = Custom(
                    Token("where"),
                    Required(
                        OneOrMoreList(
                            Custom(
                                Token("tags"),
                                RequiredToken("!contains", "!has", "contains", "has"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                shape118),
                            separatorParser: Token("and")),
                        missing74),
                    Optional(
                        fragment57),
                    shape88);
            var fragment59 = Custom(
                    Token("cluster"),
                    Token("databases"));
            var fragment60 = Custom(
                    Token("databases"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.DatabaseNameReference,
                            shape4),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    shape104);
            var fragment61 = Custom(
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape0),
                        missingElement: rules.MissingValue),
                    Token(")"),
                    Optional(Token("hot")),
                    shape114);
            var fragment62 = Custom(
                    Token("database"),
                    Optional(
                        Custom(
                            If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                            shape4)),
                    shape124);
            var fragment63 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0),
                            missingElement: rules.MissingValue),
                        missing58),
                    RequiredToken(")"),
                    Optional(Token("hot")),
                    shape114);
            var fragment64 = Custom(
                    Token("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape126);
            var fragment65 = Custom(
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("schema"),
                    shape128);
            var fragment66 = Custom(
                    Token("if_later_than"),
                    rules.StringLiteral,
                    Token("as"),
                    shape129);
            var fragment67 = Custom(
                    rules.StringLiteral,
                    RequiredToken("roles"),
                    shape133);
            var fragment68 = Custom(
                    Token("except"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape136);
            var fragment69 = Custom(
                    Token("threshold"),
                    Required(rules.Value, rules.MissingValue),
                    shape142);
            var fragment70 = Custom(
                    Token("apacheavro", "avro", "csv", "json", "orc", "parquet", "sstream", "w3clogfile"),
                    RequiredToken("mappings"),
                    shape144);
            var fragment71 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0),
                            missingElement: rules.MissingValue),
                        missing58),
                    RequiredToken(")"),
                    shape110);
            var fragment72 = Custom(
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    shape151);
            var fragment73 = Custom(
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    shape101);

            var AddClusterBlockedPrincipals = Command("AddClusterBlockedPrincipals", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("blockedprincipals"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        First(
                            fragment41,
                            fragment0)),
                    Optional(
                        First(
                            Custom(
                                Token("period"),
                                Required(rules.Value, rules.MissingValue),
                                Optional(
                                    fragment1),
                                new [] {CD(), CD("Period", CompletionHint.Literal), CD(isOptional: true)}),
                            fragment1)),
                    new [] {CD(), CD(), CD(), CD("Principal", CompletionHint.Literal), CD(isOptional: true), CD(isOptional: true)}));

            var AddClusterRole = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("admins", "alldatabaseadmins", "alldatabasemonitors", "alldatabaseviewers", "databasecreators", "monitors", "ops", "users", "viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape98));

            var AddDatabaseRole = Command("AddDatabaseRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors", "monitors", "unrestrictedviewers", "users", "viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape100));

            var AddExternalTableAdmins = Command("AddExternalTableAdmins", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment45,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape103));

            var AddFollowerDatabaseAuthorizedPrincipals = Command("AddFollowerDatabaseAuthorizedPrincipals", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            Custom(
                                Token("from"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                RequiredToken("admins", "monitors", "unrestrictedviewers", "users", "viewers"),
                                new [] {CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal), CD("operationRole")}),
                            Custom(
                                Token("admins", "monitors", "unrestrictedviewers", "users", "viewers"))),
                        missing2),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape0)),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var AddFunctionRole = Command("AddFunctionRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape105));

            var AddMaterializedViewAdmins = Command("AddMaterializedViewAdmins", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape0)),
                    shape106));

            var AddTableRole = Command("AddTableRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape107));

            var AlterMergeClusterPolicyCallout = Command("AlterMergeClusterPolicyCallout", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterMergeClusterPolicyCapacity = Command("AlterMergeClusterPolicyCapacity", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("capacity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterMergeClusterPolicyDiagnostics = Command("AlterMergeClusterPolicyDiagnostics", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape13));

            var AlterMergeClusterPolicyMultiDatabaseAdmins = Command("AlterMergeClusterPolicyMultiDatabaseAdmins", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("multidatabaseadmins"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterMergeClusterPolicyQueryWeakConsistency = Command("AlterMergeClusterPolicyQueryWeakConsistency", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("query_weak_consistency"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterMergeClusterPolicyRequestClassification = Command("AlterMergeClusterPolicyRequestClassification", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterMergeClusterPolicySharding = Command("AlterMergeClusterPolicySharding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape6));

            var AlterMergeClusterPolicyStreamingIngestion = Command("AlterMergeClusterPolicyStreamingIngestion", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape6));

            var AlterMergeClusterPolicyRowStore = Command("AlterMergeClusterPolicyRowStore", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("policy"),
                    RequiredToken("rowstore"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape14));

            var AlterMergeColumnPolicyEncoding = Command("AlterMergeColumnPolicyEncoding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.TableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape18));

            var AlterMergeDatabasePolicyDiagnostics = Command("AlterMergeDatabasePolicyDiagnostics", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape20));

            var AlterMergeDatabasePolicyEncoding = Command("AlterMergeDatabasePolicyEncoding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape21));

            var AlterMergeDatabasePolicyMerge = Command("AlterMergeDatabasePolicyMerge", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape22));

            var AlterMergeDatabasePolicyRetention = Command("AlterMergeDatabasePolicyRetention", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(
                        First(
                            fragment3,
                            fragment4,
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing3),
                    shape19));

            var AlterMergeDatabasePolicySharding = Command("AlterMergeDatabasePolicySharding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape23));

            var AlterMergeDatabasePolicyShardsGrouping = Command("AlterMergeDatabasePolicyShardsGrouping", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape24));

            var AlterMergeDatabasePolicyStreamingIngestion = Command("AlterMergeDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("StreamingIngestionPolicy", CompletionHint.Literal)}));

            var AlterMergeEntityGroup = Command("AlterMergeEntityGroup", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            First(
                                fragment8,
                                fragment9)),
                        missing4),
                    RequiredToken(")"),
                    shape30));

            var AlterMergeExtentTagsFromQuery = Command("AlterMergeExtentTagsFromQuery", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    First(
                        fragment10,
                        Custom(
                            Token("async"),
                            RequiredToken("extent")),
                        Token("extent")),
                    RequiredToken("tags"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Required(
                        fragment11,
                        missing5),
                    shape32));

            var AlterMergeMaterializedViewPolicyPartitioning = Command("AlterMergeMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape56));

            var AlterMergeMaterializedViewPolicyRetention = Command("AlterMergeMaterializedViewPolicyRetention", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("retention"),
                    Required(
                        First(
                            fragment3,
                            fragment4,
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing3),
                    shape55));

            var AlterMergeTablePolicyEncoding = Command("AlterMergeTablePolicyEncoding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape59));

            var AlterMergeTablePolicyMerge = Command("AlterMergeTablePolicyMerge", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape60));

            var AlterMergeTablePolicyRetention = Command("AlterMergeTablePolicyRetention", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(
                        First(
                            fragment3,
                            fragment4,
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing3),
                    shape58));

            var AlterMergeTablePolicyRowOrder = Command("AlterMergeTablePolicyRowOrder", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("roworder"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment30),
                        missing6),
                    RequiredToken(")"),
                    shape62));

            var AlterMergeTablePolicySharding = Command("AlterMergeTablePolicySharding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape63));

            var AlterMergeTablePolicyStreamingIngestion = Command("AlterMergeTablePolicyStreamingIngestion", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("StreamingIngestionPolicy", CompletionHint.Literal)}));

            var AlterMergeTablePolicyUpdate = Command("AlterMergeTablePolicyUpdate", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("policy"),
                    RequiredToken("update"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape64));

            var AlterMergeTable = Command("AlterMergeTable", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing7),
                    RequiredToken(")"),
                    Optional(
                        fragment31),
                    shape68));

            var AlterMergeTableColumnDocStrings = Command("AlterMergeTableColumnDocStrings", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("column-docstrings"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment32),
                        missing9),
                    RequiredToken(")"),
                    shape70));

            var AlterMergeTablePolicyPartitioning = Command("AlterMergeTablePolicyPartitioning", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape71));

            var AlterMergeWorkloadGroup = Command("AlterMergeWorkloadGroup", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape85));

            var AlterCache = Command("AlterCache", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cache"),
                    RequiredToken("on"),
                    Required(
                        First(
                            Token("*"),
                            Custom(
                                rules.BracketedStringLiteral,
                                shape0)),
                        missing10),
                    Required(rules.BracketedStringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("Action", CompletionHint.Literal)}));

            var AlterClusterPolicyCaching = Command("AlterClusterPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing11)));

            var AlterClusterPolicyCallout = Command("AlterClusterPolicyCallout", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterClusterPolicyCapacity = Command("AlterClusterPolicyCapacity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("capacity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterClusterPolicyDiagnostics = Command("AlterClusterPolicyDiagnostics", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape13));

            var AlterClusterPolicyIngestionBatching = Command("AlterClusterPolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)}));

            var AlterClusterPolicyManagedIdentity = Command("AlterClusterPolicyManagedIdentity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("ManagedIdentityPolicy", CompletionHint.Literal)}));

            var AlterClusterPolicyMultiDatabaseAdmins = Command("AlterClusterPolicyMultiDatabaseAdmins", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("multidatabaseadmins"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterClusterPolicyQueryWeakConsistency = Command("AlterClusterPolicyQueryWeakConsistency", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("query_weak_consistency"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape5));

            var AlterClusterPolicyRequestClassification = Command("AlterClusterPolicyRequestClassification", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD(), CD("Policy", CompletionHint.Literal), CD(), CD("Query", CompletionHint.Tabular)}));

            var AlterClusterPolicyRowStore = Command("AlterClusterPolicyRowStore", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape14));

            var AlterClusterPolicySandbox = Command("AlterClusterPolicySandbox", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sandbox"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("SandboxPolicy", CompletionHint.Literal)}));

            var AlterClusterPolicySharding = Command("AlterClusterPolicySharding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape6));

            var AlterClusterPolicyStreamingIngestion = Command("AlterClusterPolicyStreamingIngestion", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    RequiredToken("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("StreamingIngestionPolicy", CompletionHint.Literal)}));

            var AlterClusterStorageKeys = Command("AlterClusterStorageKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    First(
                        Custom(
                            Token("async"),
                            Token("cluster")),
                        Custom(
                            Token("async"),
                            RequiredToken("cluster")),
                        Token("cluster")),
                    RequiredToken("storage"),
                    RequiredToken("keys"),
                    Required(
                        First(
                            Token("decryption-certificate-thumbprint"),
                            fragment7),
                        missing14),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("thumbprint", CompletionHint.Literal)}));

            var AlterColumnsPolicyEncodingByQuery = Command("AlterColumnsPolicyEncodingByQuery", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("columns"),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal), CD(), CD("QueryOrCommand", CompletionHint.Tabular)}));

            var AlterColumnPolicyCaching = Command("AlterColumnPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing11),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD()}));

            var AlterColumnPolicyEncodingType = Command("AlterColumnPolicyEncodingType", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Token("type"),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD(), CD(), CD("EncodingPolicyType", CompletionHint.Literal)}));

            var AlterColumnPolicyEncoding = Command("AlterColumnPolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    Token("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape18));

            var AlterColumnType = Command("AlterColumnType", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.DatabaseTableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("type"),
                    RequiredToken("="),
                    Required(rules.Type, rules.MissingType),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD("ColumnType")}));

            var AlterDatabaseIngestionMapping = Command("AlterDatabaseIngestionMapping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)}));

            var AlterDatabasePersistMetadata = Command("AlterDatabasePersistMetadata", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("persist"),
                    RequiredToken("metadata"),
                    Required(
                        First(
                            fragment33,
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing15),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal)}));

            var AlterDatabasePolicyCaching = Command("AlterDatabasePolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing11),
                    shape19));

            var AlterDatabasePolicyDiagnostics = Command("AlterDatabasePolicyDiagnostics", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape20));

            var AlterDatabasePolicyEncoding = Command("AlterDatabasePolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape21));

            var AlterDatabasePolicyExtentTagsRetention = Command("AlterDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ExtentTagsRetentionPolicy", CompletionHint.Literal)}));

            var AlterDatabasePolicyIngestionBatching = Command("AlterDatabasePolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)}));

            var AlterDatabasePolicyManagedIdentity = Command("AlterDatabasePolicyManagedIdentity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("managed_identity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ManagedIdentityPolicy", CompletionHint.Literal)}));

            var AlterDatabasePolicyMerge = Command("AlterDatabasePolicyMerge", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape22));

            var AlterDatabasePolicyRetention = Command("AlterDatabasePolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterDatabasePolicySharding = Command("AlterDatabasePolicySharding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape23));

            var AlterDatabasePolicyShardsGrouping = Command("AlterDatabasePolicyShardsGrouping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape24));

            var AlterDatabasePolicyStreamingIngestion = Command("AlterDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    RequiredToken("streamingingestion"),
                    Required(
                        First(
                            Custom(
                                Token("disable", "enable")),
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing16),
                    shape19));

            var AlterDatabasePrettyName = Command("AlterDatabasePrettyName", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("prettyname"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("DatabasePrettyName", CompletionHint.Literal)}));

            var AlterDatabaseStorageKeys = Command("AlterDatabaseStorageKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    First(
                        Custom(
                            Token("async"),
                            Token("database")),
                        Custom(
                            Token("async"),
                            RequiredToken("database")),
                        Token("database")),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("storage"),
                    RequiredToken("keys"),
                    Required(
                        First(
                            Token("decryption-certificate-thumbprint"),
                            fragment7),
                        missing14),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD(), CD("thumbprint", CompletionHint.Literal)}));

            var AlterEntityGroup = Command("AlterEntityGroup", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            First(
                                fragment8,
                                fragment9)),
                        missing4),
                    RequiredToken(")"),
                    shape30));

            var AlterExtentContainersAdd = Command("AlterExtentContainersAdd", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    rules.DatabaseNameReference,
                    Token("add"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        Custom(
                            rules.Value,
                            Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                            new [] {CD("hardDeletePeriod", CompletionHint.Literal), CD("containerId", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD("container", CompletionHint.Literal), CD(CompletionHint.Literal, isOptional: true)}));

            var AlterExtentContainersDrop = Command("AlterExtentContainersDrop", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    rules.DatabaseNameReference,
                    Token("drop"),
                    Optional(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape0)),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var AlterExtentContainersRecycle = Command("AlterExtentContainersRecycle", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    rules.DatabaseNameReference,
                    Token("recycle"),
                    Required(
                        First(
                            Custom(
                                Token("older"),
                                Required(
                                    First(
                                        rules.Value,
                                        rules.Value),
                                    rules.MissingValue),
                                RequiredToken("hours"),
                                new [] {CD(), CD("hours", CompletionHint.Literal), CD()}),
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0)),
                        missing17),
                    shape134));

            var AlterExtentContainersSet = Command("AlterExtentContainersSet", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("set"),
                    RequiredToken("state"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    RequiredToken("to"),
                    RequiredToken("readonly", "readwrite"),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD("container", CompletionHint.Literal), CD(), CD()}));

            var AlterExtentTagsFromQuery = Command("AlterExtentTagsFromQuery", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    First(
                        fragment10,
                        Token("extent")),
                    RequiredToken("tags"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Required(
                        fragment11,
                        missing5),
                    shape32));

            var AlterSqlExternalTable = Command("AlterSqlExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("sql"),
                        RequiredToken("table"),
                        RequiredToken("="),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment15)}
                    ,
                    shape74));

            var AlterStorageExternalTable = Command("AlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing7),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        Required(
                            First(
                                Token("adl").Hide(),
                                Token("blob").Hide(),
                                Token("storage")),
                            missing19),
                        Required(
                            First(
                                Token("dataformat"),
                                fragment35),
                            missing25),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape0),
                                missingElement: rules.MissingStringLiteral),
                            missing1),
                        RequiredToken(")"),
                        Optional(
                            fragment15)}
                    ,
                    shape83));

            var AlterExternalTableDocString = Command("AlterExternalTableDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.ExternalTable), CD(), CD("docStringValue", CompletionHint.Literal)}));

            var AlterExternalTableFolder = Command("AlterExternalTableFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.ExternalTable), CD(), CD("folderValue", CompletionHint.Literal)}));

            var AlterExternalTableMapping = Command("AlterExternalTableMapping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape86));

            var AlterFollowerClusterConfiguration = Command("AlterFollowerClusterConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("cluster"),
                    RequiredToken("configuration"),
                    RequiredToken("from"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(
                        First(
                            Custom(
                                Token("database-name-prefix"),
                                RequiredToken("="),
                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                new [] {CD(), CD(), CD("databaseNamePrefix", CompletionHint.None)}),
                            Custom(
                                Token("default-caching-policies-modification-kind"),
                                RequiredToken("="),
                                RequiredToken("none", "replace", "union"),
                                shape40),
                            Custom(
                                Token("default-principals-modification-kind"),
                                RequiredToken("="),
                                RequiredToken("none", "replace", "union"),
                                shape40),
                            Custom(
                                Token("follow-authorized-principals"),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                new [] {CD(), CD(), CD("followAuthorizedPrincipals", CompletionHint.Literal)})),
                        missing27),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal), CD()}));

            var AlterFollowerDatabaseAuthorizedPrincipals = Command("AlterFollowerDatabaseAuthorizedPrincipals", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    First(
                        Custom(
                            Token("from"),
                            rules.StringLiteral,
                            Token("policy"),
                            shape44),
                        Token("policy")),
                    RequiredToken("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing28),
                    Optional(
                        First(
                            fragment29,
                            OneOrMoreCommaList(
                                fragment16))),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD(), CD(), CD("hotWindows", isOptional: true)}));

            var AlterFollowerDatabaseConfiguration = Command("AlterFollowerDatabaseConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    First(
                        fragment17,
                        fragment18,
                        fragment19,
                        Custom(
                            Token("from"),
                            rules.StringLiteral,
                            First(
                                fragment17,
                                fragment18,
                                fragment19,
                                fragment20,
                                fragment21,
                                fragment22),
                            shape44),
                        fragment20,
                        fragment21,
                        fragment22),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD()}));

            var AlterFollowerDatabaseChildEntities = Command("AlterFollowerDatabaseChildEntities", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        Token("database"),
                        rules.DatabaseNameReference,
                        First(
                            fragment23,
                            fragment24,
                            Custom(
                                Token("from"),
                                rules.StringLiteral,
                                First(
                                    fragment23,
                                    fragment24,
                                    Token("materialized-views"),
                                    Token("tables")),
                                shape44),
                            Token("materialized-views"),
                            Token("tables")),
                        RequiredToken("exclude", "include"),
                        RequiredToken("add", "drop"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.WildcardedNameDeclaration,
                                    shape12),
                                missingElement: rules.MissingNameDeclaration),
                            missing31),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD("entityListKind"), CD("operationName"), CD(), CD(CompletionHint.None), CD()}));

            var AlterFollowerTablesPolicyCaching = Command("AlterFollowerTablesPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            Custom(
                                Token("from"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                Required(
                                    First(
                                        fragment25,
                                        fragment26,
                                        fragment27,
                                        fragment28),
                                    missing32),
                                shape44),
                            fragment25,
                            fragment26,
                            fragment27,
                            fragment28),
                        missing33),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing28),
                    Optional(
                        First(
                            fragment29,
                            OneOrMoreCommaList(
                                fragment16))),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD(), CD(), CD(), CD("hotWindows", isOptional: true)}));

            var AlterFunctionDocString = Command("AlterFunctionDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    If(Not(Token("with")), rules.DatabaseFunctionNameReference),
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(CompletionHint.Function), CD(), CD("Documentation", CompletionHint.Literal)}));

            var AlterFunctionFolder = Command("AlterFunctionFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    If(Not(Token("with")), rules.DatabaseFunctionNameReference),
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD(), CD("Folder", CompletionHint.Literal)}));

            var AlterFunction = Command("AlterFunction", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(
                        First(
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment13),
                                    missing18),
                                RequiredToken(")"),
                                Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                                new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("FunctionName", CompletionHint.Function)}),
                            Custom(
                                If(Not(Token("with")), rules.DatabaseFunctionNameReference),
                                shape52)),
                        missing34),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration)));

            var AlterMaterializedViewAutoUpdateSchema = Command("AlterMaterializedViewAutoUpdateSchema", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("autoUpdateSchema"),
                    RequiredToken("false", "true"),
                    shape94));

            var AlterMaterializedViewDocString = Command("AlterMaterializedViewDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("Documentation", CompletionHint.Literal)}));

            var AlterMaterializedViewFolder = Command("AlterMaterializedViewFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("Folder", CompletionHint.Literal)}));

            var AlterMaterializedViewLookback = Command("AlterMaterializedViewLookback", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("lookback"),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("Lookback", CompletionHint.Literal)}));

            var AlterMaterializedView = Command("AlterMaterializedView", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    First(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            OneOrMoreCommaList(
                                Custom(
                                    First(
                                        Token("dimensionTables"),
                                        Token("lookback"),
                                        If(Not(And(Token("dimensionTables", "lookback"))), rules.NameDeclaration)),
                                    RequiredToken("="),
                                    rules.Value,
                                    shape53)),
                            Token(")"),
                            rules.MaterializedViewNameReference,
                            shape54),
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        First(
                                            Token("dimensionTables"),
                                            Token("lookback"),
                                            If(Not(And(Token("dimensionTables", "lookback"))), rules.NameDeclaration)),
                                        RequiredToken("="),
                                        Required(rules.Value, rules.MissingValue),
                                        shape53)),
                                missing35),
                            RequiredToken(")"),
                            Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                            shape54),
                        Custom(
                            If(Not(Token("with")), rules.MaterializedViewNameReference),
                            shape8)),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    shape84));

            var AlterMaterializedViewPolicyCaching = Command("AlterMaterializedViewPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing11),
                    shape55));

            var AlterMaterializedViewPolicyPartitioning = Command("AlterMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape56));

            var AlterMaterializedViewPolicyRetention = Command("AlterMaterializedViewPolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterMaterializedViewPolicyRowLevelSecurity = Command("AlterMaterializedViewPolicyRowLevelSecurity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(If(Not(Token("with")), rules.MaterializedViewNameReference), rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("row_level_security"),
                    RequiredToken("disable", "enable"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(), CD("Query", CompletionHint.Literal)}));

            var AlterPoliciesOfRetention = Command("AlterPoliciesOfRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("policies"),
                    RequiredToken("of"),
                    RequiredToken("retention"),
                    Required(
                        First(
                            Custom(
                                Token("internal"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                new [] {CD(), CD("policies", CompletionHint.Literal)}),
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing36)));

            var AlterTablesPolicyCaching = Command("AlterTablesPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing11),
                    Optional(
                        First(
                            fragment29,
                            OneOrMoreCommaList(
                                fragment16))),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD(), CD(isOptional: true)}));

            var AlterTablesPolicyIngestionBatching = Command("AlterTablesPolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)}));

            var AlterTablesPolicyIngestionTime = Command("AlterTablesPolicyIngestionTime", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("ingestiontime"),
                    RequiredToken("true"),
                    shape57));

            var AlterTablesPolicyMerge = Command("AlterTablesPolicyMerge", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD("policy", CompletionHint.Literal)}));

            var AlterTablesPolicyRestrictedViewAccess = Command("AlterTablesPolicyRestrictedViewAccess", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("restricted_view_access"),
                    RequiredToken("false", "true"),
                    shape57));

            var AlterTablesPolicyRetention = Command("AlterTablesPolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape10),
                        missingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterTablesPolicyRowOrder = Command("AlterTablesPolicyRowOrder", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("tables"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.TableNameReference,
                                    shape10),
                                missingElement: rules.MissingNameReference),
                            missing37),
                        RequiredToken(")"),
                        RequiredToken("policy"),
                        RequiredToken("roworder"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.NameDeclaration,
                                    RequiredToken("asc", "desc"),
                                    new [] {CD("ColumnName", CompletionHint.None), CD()})),
                            missing38),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD(), CD(CompletionHint.None), CD()}));

            var AlterTableColumnStatisticsMethod = Command("AlterTableColumnStatisticsMethod", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("column"),
                    RequiredToken("statistics"),
                    RequiredToken("method"),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(), CD("newMethod", CompletionHint.Literal)}));

            var AlterTablePolicyAutoDelete = Command("AlterTablePolicyAutoDelete", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("auto_delete"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("AutoDeletePolicy", CompletionHint.Literal)}));

            var AlterTablePolicyCaching = Command("AlterTablePolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment5,
                            fragment6),
                        missing11),
                    shape58));

            var AlterTablePolicyEncoding = Command("AlterTablePolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape59));

            var AlterTablePolicyExtentTagsRetention = Command("AlterTablePolicyExtentTagsRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("ExtentTagsRetentionPolicy", CompletionHint.Literal)}));

            var AlterTablePolicyIngestionBatching = Command("AlterTablePolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)}));

            var AlterTablePolicyMerge = Command("AlterTablePolicyMerge", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape60));

            var AlterTablePolicyRestrictedViewAccess = Command("AlterTablePolicyRestrictedViewAccess", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("restricted_view_access"),
                    RequiredToken("false", "true"),
                    shape58));

            var AlterTablePolicyRetention = Command("AlterTablePolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterTablePolicyRowOrder = Command("AlterTablePolicyRowOrder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("roworder"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment30),
                        missing6),
                    RequiredToken(")"),
                    shape62));

            var AlterTablePolicySharding = Command("AlterTablePolicySharding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape63));

            var AlterTablePolicyStreamingIngestion = Command("AlterTablePolicyStreamingIngestion", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(
                        First(
                            Custom(
                                Token("disable", "enable")),
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing16),
                    shape58));

            var AlterTablePolicyUpdate = Command("AlterTablePolicyUpdate", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    RequiredToken("update"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape64));

            var AlterTableRowStoreReferencesDisableBlockedKeys = Command("AlterTableRowStoreReferencesDisableBlockedKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("disable"),
                    Token("blocked"),
                    RequiredToken("keys"),
                    Optional(
                        fragment15),
                    shape65));

            var AlterTableRowStoreReferencesDisableKey = Command("AlterTableRowStoreReferencesDisableKey", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("disable"),
                    Token("key"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment15),
                    shape66));

            var AlterTableRowStoreReferencesDisableRowStore = Command("AlterTableRowStoreReferencesDisableRowStore", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("disable"),
                    RequiredToken("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment15),
                    shape67));

            var AlterTableRowStoreReferencesDropBlockedKeys = Command("AlterTableRowStoreReferencesDropBlockedKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("drop"),
                    Token("blocked"),
                    RequiredToken("keys"),
                    Optional(
                        fragment15),
                    shape65));

            var AlterTableRowStoreReferencesDropKey = Command("AlterTableRowStoreReferencesDropKey", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("drop"),
                    Token("key"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment15),
                    shape66));

            var AlterTableRowStoreReferencesDropRowStore = Command("AlterTableRowStoreReferencesDropRowStore", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("rowstore_references"),
                    RequiredToken("drop"),
                    RequiredToken("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment15),
                    shape67));

            var AlterTable = Command("AlterTable", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing7),
                    RequiredToken(")"),
                    Optional(
                        fragment31),
                    shape68));

            var AlterTableColumnDocStrings = Command("AlterTableColumnDocStrings", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("column-docstrings"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment32),
                        missing9),
                    RequiredToken(")"),
                    shape70));

            var AlterTableColumnsPolicyEncoding = Command("AlterTableColumnsPolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("columns"),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD("EncodingPolicies", CompletionHint.Literal)}));

            var AlterTableColumnStatistics = Command("AlterTableColumnStatistics", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("column"),
                    RequiredToken("statistics"),
                    ZeroOrMoreCommaList(
                        Custom(
                            rules.NameDeclaration,
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            new [] {CD("c2", CompletionHint.None), CD("statisticsValues2", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(CompletionHint.None)}));

            var AlterTableDocString = Command("AlterTableDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("Documentation", CompletionHint.Literal)}));

            var AlterTableFolder = Command("AlterTableFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("Folder", CompletionHint.Literal)}));

            var AlterTableIngestionMapping = Command("AlterTableIngestionMapping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)}));

            var AlterTablePolicyIngestionTime = Command("AlterTablePolicyIngestionTime", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    Token("ingestiontime"),
                    RequiredToken("true"),
                    shape58));

            var AlterTablePolicyPartitioning = Command("AlterTablePolicyPartitioning", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape71));

            var AlterTablePolicyRowLevelSecurity = Command("AlterTablePolicyRowLevelSecurity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("row_level_security"),
                    RequiredToken("disable", "enable"),
                    Required(
                        First(
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                ZeroOrMoreCommaList(
                                    fragment13),
                                RequiredToken(")"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("Query", CompletionHint.Literal)}),
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing39),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD()}));

            var AppendTable = Command("AppendTable", 
                Custom(
                    Token("append", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment49,
                            Custom(
                                If(Not(Token("async")), rules.TableNameReference),
                                shape10)),
                        missing40),
                    Required(
                        First(
                            Token("<|"),
                            fragment51),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape112));

            var AttachDatabaseMetadata = Command("AttachDatabaseMetadata", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("metadata"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment33,
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing15),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Literal)}));

            var AttachDatabase = Command("AttachDatabase", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(If(Not(Token("metadata")), rules.DatabaseNameReference), rules.MissingNameReference),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment33,
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing15),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Literal)}));

            var AttachExtentsIntoTableByContainer = Command("AttachExtentsIntoTableByContainer", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Token("extents"),
                    Token("into"),
                    Token("table"),
                    rules.TableNameReference,
                    Token("by"),
                    Token("container"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(
                        OneOrMoreList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0)),
                        missing42),
                    new [] {CD(), CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD("containerUri", CompletionHint.Literal), CD(CompletionHint.Literal)}));

            var AttachExtentsIntoTableByMetadata = Command("AttachExtentsIntoTableByMetadata", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment50,
                            Token("extents")),
                        missing44),
                    ZeroOrMoreList(
                        Custom(
                            Token("into"),
                            RequiredToken("table"),
                            Required(rules.TableNameReference, rules.MissingNameReference),
                            new [] {CD(), CD(), CD("tableName", CompletionHint.Table)})),
                    RequiredToken("by"),
                    RequiredToken("metadata"),
                    Required(
                        fragment11,
                        missing5),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("csl")}));

            var CancelOperation = Command("CancelOperation", 
                Custom(
                    Token("cancel", CompletionKind.CommandPrefix),
                    Token("operation"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD("obj", CompletionHint.Literal), CD(isOptional: true)}));

            var CancelQuery = Command("CancelQuery", 
                Custom(
                    Token("cancel", CompletionKind.CommandPrefix),
                    RequiredToken("query"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("ClientRequestId", CompletionHint.Literal)}));

            var CleanDatabaseExtentContainers = Command("CleanDatabaseExtentContainers", 
                Custom(
                    Token("clean", CompletionKind.CommandPrefix),
                    RequiredToken("databases"),
                    Optional(
                        First(
                            fragment34,
                            Custom(
                                Token("async"),
                                Optional(
                                    fragment34),
                                shape87))),
                    RequiredToken("extentcontainers"),
                    new [] {CD(), CD(), CD(isOptional: true), CD()}));

            var ClearRemoteClusterDatabaseSchema = Command("ClearRemoteClusterDatabaseSchema", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("clear", CompletionKind.CommandPrefix),
                        Token("cache"),
                        RequiredToken("remote-schema"),
                        RequiredToken("cluster"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        RequiredToken("."),
                        RequiredToken("database"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("clusterName", CompletionHint.Literal), CD(), CD(), CD(), CD(), CD("databaseName", CompletionHint.Literal), CD()}));

            var ClearDatabaseCacheQueryResults = Command("ClearDatabaseCacheQueryResults", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cache"),
                    Token("query_results")));

            var ClearDatabaseCacheQueryWeakConsistency = Command("ClearDatabaseCacheQueryWeakConsistency", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cache"),
                    Token("query_weak_consistency")));

            var ClearDatabaseCacheStreamingIngestionSchema = Command("ClearDatabaseCacheStreamingIngestionSchema", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("database"),
                    RequiredToken("cache"),
                    RequiredToken("streamingingestion"),
                    RequiredToken("schema")));

            var ClearMaterializedViewData = Command("ClearMaterializedViewData", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("data"),
                    shape146));

            var ClearMaterializedViewStatistics = Command("ClearMaterializedViewStatistics", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("statistics"),
                    shape148));

            var ClearTableCacheStreamingIngestionSchema = Command("ClearTableCacheStreamingIngestionSchema", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("cache"),
                    RequiredToken("streamingingestion"),
                    RequiredToken("schema"),
                    shape58));

            var ClearTableData = Command("ClearTableData", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment39,
                            Token("table")),
                        missing45),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("data"),
                    shape152));

            var CreateMergeTables = Command("CreateMergeTables", 
                Custom(
                    Token("create-merge", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            fragment37),
                        missing46),
                    Optional(
                        fragment15),
                    shape90));

            var CreateMergeTable = Command("CreateMergeTable", 
                Custom(
                    Token("create-merge", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing7),
                    RequiredToken(")"),
                    Optional(
                        fragment31),
                    shape91));

            var CreateOrAlterContinuousExport = Command("CreateOrAlterContinuousExport", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Custom(
                                Token("over"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.NameDeclaration,
                                            shape12),
                                        missingElement: rules.MissingNameDeclaration),
                                    missing31),
                                RequiredToken(")"),
                                RequiredToken("to"),
                                shape26),
                            Token("to")),
                        missing47),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            Token("<|"),
                            fragment46),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD("ContinuousExportName", CompletionHint.None), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD("Query", CompletionHint.Tabular)}));

            var CreateOrAlterSqlExternalTable = Command("CreateOrAlterSqlExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("sql"),
                        RequiredToken("table"),
                        RequiredToken("="),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment15)}
                    ,
                    shape74));

            var CreateOrAlterStorageExternalTable = Command("CreateOrAlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        RequiredToken("table"),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing7),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        Required(
                            First(
                                Token("adl").Hide(),
                                Token("blob").Hide(),
                                Token("storage")),
                            missing19),
                        Required(
                            First(
                                Token("dataformat"),
                                fragment35),
                            missing25),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape0),
                                missingElement: rules.MissingStringLiteral),
                            missing1),
                        RequiredToken(")"),
                        Optional(
                            fragment15)}
                    ,
                    shape83));

            var CreateOrAlterFunction = Command("CreateOrAlterFunction", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(
                        First(
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment13),
                                    missing18),
                                RequiredToken(")"),
                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("FunctionName", CompletionHint.None)}),
                            Custom(
                                If(Not(Token("with")), rules.NameDeclaration),
                                shape12)),
                        missing50),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration)));

            var CreateOrAlterMaterializedView = Command("CreateOrAlterMaterializedView", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(
                        First(
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment38),
                                    missing51),
                                RequiredToken(")"),
                                Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                                shape54),
                            Custom(
                                If(Not(Token("with")), rules.MaterializedViewNameReference),
                                shape8)),
                        missing52),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    shape84));

            var CreateOrAleterWorkloadGroup = Command("CreateOrAleterWorkloadGroup", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape85));

            var CreateBasicAuthUser = Command("CreateBasicAuthUser", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("basicauth"),
                    RequiredToken("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        Custom(
                            Token("password"),
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            new [] {CD(), CD("Password", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD(), CD("UserName", CompletionHint.Literal), CD(isOptional: true)}));

            var CreateDatabasePersist = Command("CreateDatabasePersist", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.NameDeclaration,
                    Token("persist"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(Token("ifnotexists")),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var CreateDatabaseVolatile = Command("CreateDatabaseVolatile", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.NameDeclaration,
                    Token("volatile"),
                    Optional(Token("ifnotexists")),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(), CD(isOptional: true)}));

            var CreateDatabaseIngestionMapping = Command("CreateDatabaseIngestionMapping", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)}));

            var CreateEntityGroupCommand = Command("CreateEntityGroupCommand", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            First(
                                fragment8,
                                fragment9)),
                        missing4),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.None), CD(), CD(), CD()}));

            var CreateSqlExternalTable = Command("CreateSqlExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("sql"),
                        RequiredToken("table"),
                        RequiredToken("="),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment15)}
                    ,
                    shape74));

            var CreateStorageExternalTable = Command("CreateStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing7),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        Required(
                            First(
                                Token("adl").Hide(),
                                Token("blob").Hide(),
                                Token("storage")),
                            missing19),
                        Required(
                            First(
                                Token("dataformat"),
                                fragment35),
                            missing25),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape0),
                                missingElement: rules.MissingStringLiteral),
                            missing1),
                        RequiredToken(")"),
                        Optional(
                            fragment15)}
                    ,
                    shape83));

            var CreateExternalTableMapping = Command("CreateExternalTableMapping", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape86));

            var CreateFunction = Command("CreateFunction", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("function"),
                    Optional(
                        First(
                            Custom(
                                Token("ifnotexists"),
                                Optional(
                                    fragment36),
                                shape87),
                            fragment36)),
                    Required(If(Not(And(Token("ifnotexists", "with"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration),
                    new [] {CD(), CD(), CD(isOptional: true), CD("FunctionName", CompletionHint.None), CD()}));

            var CreateRequestSupport = Command("CreateRequestSupport", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("request_support"),
                    Optional(
                        fragment15),
                    shape88));

            var CreateRowStore = Command("CreateRowStore", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Optional(
                        fragment15),
                    shape88));

            var CreateTables = Command("CreateTables", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            fragment37),
                        missing46),
                    Optional(
                        fragment15),
                    shape90));

            var CreateTable = Command("CreateTable", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.NameDeclaration,
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing7),
                    RequiredToken(")"),
                    Optional(
                        fragment31),
                    shape91));

            var CreateTableBasedOnAnother = Command("CreateTableBasedOnAnother", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.NameDeclaration,
                    Token("based-on"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment31),
                    new [] {CD(), CD(), CD("NewTableName", CompletionHint.None), CD(), CD("TableName", CompletionHint.None), CD(isOptional: true)}));

            var CreateTableIngestionMapping = Command("CreateTableIngestionMapping", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.None), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)}));

            var CreateTempStorage = Command("CreateTempStorage", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("tempstorage")));

            var CreateMaterializedView = Command("CreateMaterializedView", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Optional(
                        First(
                            Custom(
                                Token("async"),
                                Optional(Token("ifnotexists")),
                                shape87),
                            Token("ifnotexists"))),
                    RequiredToken("materialized-view"),
                    Required(
                        First(
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment38),
                                    missing51),
                                RequiredToken(")"),
                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                new [] {CD(), CD(), CD(), CD(), CD("MaterializedViewName", CompletionHint.None)}),
                            Custom(
                                If(Not(Token("with")), rules.NameDeclaration),
                                shape12)),
                        missing55),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var DefineTables = Command("DefineTables", 
                Custom(
                    Token("define", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            fragment37),
                        missing46),
                    Optional(
                        fragment15),
                    shape90));

            var DefineTable = Command("DefineTable", 
                Custom(
                    Token("define", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing7),
                    RequiredToken(")"),
                    Optional(
                        fragment31),
                    shape91));

            var DeleteClusterPolicyCaching = Command("DeleteClusterPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("caching")));

            var DeleteClusterPolicyCallout = Command("DeleteClusterPolicyCallout", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout")));

            var DeleteClusterPolicyManagedIdentity = Command("DeleteClusterPolicyManagedIdentity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity")));

            var DeleteClusterPolicyRequestClassification = Command("DeleteClusterPolicyRequestClassification", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification")));

            var DeleteClusterPolicyRowStore = Command("DeleteClusterPolicyRowStore", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore")));

            var DeleteClusterPolicySandbox = Command("DeleteClusterPolicySandbox", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sandbox")));

            var DeleteClusterPolicySharding = Command("DeleteClusterPolicySharding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding")));

            var DeleteClusterPolicyStreamingIngestion = Command("DeleteClusterPolicyStreamingIngestion", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("policy"),
                    RequiredToken("streamingingestion")));

            var DeleteColumnPolicyCaching = Command("DeleteColumnPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    shape92));

            var DeleteColumnPolicyEncoding = Command("DeleteColumnPolicyEncoding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.TableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    shape92));

            var DeleteDatabasePolicyCaching = Command("DeleteDatabasePolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape93));

            var DeleteDatabasePolicyDiagnostics = Command("DeleteDatabasePolicyDiagnostics", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("diagnostics"),
                    shape93));

            var DeleteDatabasePolicyEncoding = Command("DeleteDatabasePolicyEncoding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("encoding"),
                    shape93));

            var DeleteDatabasePolicyExtentTagsRetention = Command("DeleteDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape93));

            var DeleteDatabasePolicyIngestionBatching = Command("DeleteDatabasePolicyIngestionBatching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape93));

            var DeleteDatabasePolicyManagedIdentity = Command("DeleteDatabasePolicyManagedIdentity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("managed_identity"),
                    shape93));

            var DeleteDatabasePolicyMerge = Command("DeleteDatabasePolicyMerge", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("merge"),
                    shape93));

            var DeleteDatabasePolicyRetention = Command("DeleteDatabasePolicyRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("retention"),
                    shape93));

            var DeleteDatabasePolicySharding = Command("DeleteDatabasePolicySharding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("sharding"),
                    shape93));

            var DeleteDatabasePolicyShardsGrouping = Command("DeleteDatabasePolicyShardsGrouping", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    shape93));

            var DeleteDatabasePolicyStreamingIngestion = Command("DeleteDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("streamingingestion"),
                    shape93));

            var DropFollowerDatabasePolicyCaching = Command("DropFollowerDatabasePolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD()}));

            var DropFollowerTablesPolicyCaching = Command("DropFollowerTablesPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            fragment25,
                            fragment26,
                            fragment27,
                            fragment28),
                        missing32),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD(), CD()}));

            var DeleteMaterializedViewPolicyCaching = Command("DeleteMaterializedViewPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape94));

            var DeleteMaterializedViewPolicyPartitioning = Command("DeleteMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    shape94));

            var DeleteMaterializedViewPolicyRowLevelSecurity = Command("DeleteMaterializedViewPolicyRowLevelSecurity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("row_level_security"),
                    shape94));

            var DeletePoliciesOfRetention = Command("DeletePoliciesOfRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("policies"),
                    RequiredToken("of"),
                    RequiredToken("retention"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD()}));

            var DeleteTablePolicyAutoDelete = Command("DeleteTablePolicyAutoDelete", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("auto_delete"),
                    shape95));

            var DeleteTablePolicyCaching = Command("DeleteTablePolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape95));

            var DeleteTablePolicyEncoding = Command("DeleteTablePolicyEncoding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("encoding"),
                    shape95));

            var DeleteTablePolicyExtentTagsRetention = Command("DeleteTablePolicyExtentTagsRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape95));

            var DeleteTablePolicyIngestionBatching = Command("DeleteTablePolicyIngestionBatching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape95));

            var DeleteTablePolicyMerge = Command("DeleteTablePolicyMerge", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("merge"),
                    shape95));

            var DeleteTablePolicyRestrictedViewAccess = Command("DeleteTablePolicyRestrictedViewAccess", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("restricted_view_access"),
                    shape95));

            var DeleteTablePolicyRetention = Command("DeleteTablePolicyRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("retention"),
                    shape95));

            var DeleteTablePolicyRowOrder = Command("DeleteTablePolicyRowOrder", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("roworder"),
                    shape95));

            var DeleteTablePolicySharding = Command("DeleteTablePolicySharding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("sharding"),
                    shape95));

            var DeleteTablePolicyStreamingIngestion = Command("DeleteTablePolicyStreamingIngestion", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    shape95));

            var DeleteTablePolicyUpdate = Command("DeleteTablePolicyUpdate", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("policy"),
                    RequiredToken("update"),
                    shape95));

            var DeleteTablePolicyIngestionTime = Command("DeleteTablePolicyIngestionTime", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    Token("ingestiontime"),
                    shape95));

            var DeleteTablePolicyPartitioning = Command("DeleteTablePolicyPartitioning", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    shape95));

            var DeleteTablePolicyRowLevelSecurity = Command("DeleteTablePolicyRowLevelSecurity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape95));

            var DeleteTableRecords = Command("DeleteTableRecords", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment39,
                            Token("table")),
                        missing56),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("records"),
                    Required(
                        First(
                            Custom(
                                fragment11),
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment13),
                                    missing13),
                                RequiredToken(")"),
                                Required(
                                    fragment11,
                                    missing5),
                                new [] {CD(), CD(), CD(CompletionHint.None), CD(), CD("csl")})),
                        missing5),
                    shape95));

            var DetachDatabase = Command("DetachDatabase", 
                Custom(
                    Token("detach", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database)}));

            var DisableContinuousExport = Command("DisableContinuousExport", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("ContinousExportName", CompletionHint.None)}));

            var DisableDatabaseMaintenanceMode = Command("DisableDatabaseMaintenanceMode", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("maintenance_mode"),
                    shape99));

            var DisablePlugin = Command("DisablePlugin", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    RequiredToken("plugin"),
                    Required(
                        First(
                            rules.StringLiteral,
                            rules.NameDeclaration),
                        rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("pluginName", CompletionHint.Literal)}));

            var DropPretendExtentsByProperties = Command("DropPretendExtentsByProperties", 
                Custom(
                    Token("drop-pretend", CompletionKind.CommandPrefix),
                    RequiredToken("extents"),
                    Required(
                        First(
                            Token("from"),
                            Custom(
                                Token("older"),
                                Required(rules.Value, rules.MissingValue),
                                RequiredToken("days", "hours"),
                                RequiredToken("from"),
                                new [] {CD(), CD("Older", CompletionHint.Literal), CD(), CD()})),
                        missing26),
                    Required(
                        First(
                            fragment42,
                            Custom(
                                If(Not(Token("all")), rules.TableNameReference),
                                shape10)),
                        missing57),
                    Optional(
                        First(
                            fragment40,
                            fragment43)),
                    shape119));

            var DropBasicAuthUser = Command("DropBasicAuthUser", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("basicauth"),
                    RequiredToken("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("UserName", CompletionHint.Literal)}));

            var DropClusterBlockedPrincipals = Command("DropClusterBlockedPrincipals", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("blockedprincipals"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        First(
                            fragment41,
                            fragment0)),
                    new [] {CD(), CD(), CD(), CD("Principal", CompletionHint.Literal), CD(isOptional: true)}));

            var DropClusterRole = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("admins", "alldatabaseadmins", "alldatabasemonitors", "alldatabaseviewers", "databasecreators", "monitors", "ops", "users", "viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape98));

            var DropColumn = Command("DropColumn", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.TableColumnNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column)}));

            var DropContinuousExport = Command("DropContinuousExport", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape108));

            var DropDatabaseIngestionMapping = Command("DropDatabaseIngestionMapping", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal)}));

            var DropDatabasePrettyName = Command("DropDatabasePrettyName", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("prettyname"),
                    shape99));

            var DropDatabaseRole = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors", "monitors", "unrestrictedviewers", "users", "viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape100));

            var DropEmptyExtentContainers = Command("DropEmptyExtentContainers", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    First(
                        Custom(
                            Token("async"),
                            Token("empty")),
                        Custom(
                            Token("async"),
                            RequiredToken("empty")),
                        Token("empty")),
                    RequiredToken("extentcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("until"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    Optional(
                        First(
                            Custom(
                                Token("whatif"),
                                Optional(
                                    fragment15),
                                shape87),
                            fragment15)),
                    new [] {CD(), CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD("d", CompletionHint.Literal), CD(isOptional: true)}));

            var DropEntityGroup = Command("DropEntityGroup", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    shape135));

            var DropExtentsPartitionMetadata = Command("DropExtentsPartitionMetadata", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    Token("partition"),
                    RequiredToken("metadata"),
                    RequiredToken("from"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            Custom(
                                fragment11),
                            Custom(
                                Token("between"),
                                RequiredToken("("),
                                Required(rules.Value, rules.MissingValue),
                                RequiredToken(".."),
                                Required(rules.Value, rules.MissingValue),
                                RequiredToken(")"),
                                Required(
                                    fragment11,
                                    missing5),
                                new [] {CD(), CD(), CD("d1", CompletionHint.Literal), CD(), CD("d2", CompletionHint.Literal), CD(), CD("csl")})),
                        missing5),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD()}));

            var DropExtents = Command("DropExtents", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.AnyGuidLiteralOrString,
                                            shape0),
                                        missingElement: rules.MissingValue),
                                    missing58),
                                RequiredToken(")"),
                                Optional(
                                    fragment44),
                                shape114),
                            Custom(
                                Token("<|"),
                                Required(rules.QueryInput, rules.MissingExpression),
                                new [] {CD(), CD("Query", CompletionHint.Tabular)}),
                            Custom(
                                Token("from"),
                                Required(
                                    First(
                                        fragment42,
                                        Custom(
                                            If(Not(Token("all")), rules.TableNameReference),
                                            shape10)),
                                    missing59),
                                Optional(
                                    First(
                                        fragment40,
                                        fragment43)),
                                shape88),
                            Custom(
                                Token("older"),
                                Required(rules.Value, rules.MissingValue),
                                RequiredToken("days", "hours"),
                                RequiredToken("from"),
                                Required(
                                    First(
                                        fragment42,
                                        Custom(
                                            If(Not(Token("all")), rules.TableNameReference),
                                            shape10)),
                                    missing60),
                                Optional(
                                    First(
                                        fragment40,
                                        fragment43)),
                                new [] {CD(), CD("Older", CompletionHint.Literal), CD(), CD(), CD(), CD(isOptional: true)}),
                            Custom(
                                Token("whatif"),
                                RequiredToken("<|"),
                                Required(rules.QueryInput, rules.MissingExpression),
                                new [] {CD(), CD(), CD("Query", CompletionHint.Tabular)})),
                        missing61)));

            var DropExtentTagsRetention = Command("DropExtentTagsRetention", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extent"),
                    Token("tags"),
                    RequiredToken("retention")));

            var DropExtent = Command("DropExtent", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extent"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    Optional(
                        fragment44),
                    new [] {CD(), CD(), CD("ExtentId", CompletionHint.Literal), CD(isOptional: true)}));

            var DropExternalTableAdmins = Command("DropExternalTableAdmins", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment45,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape103));

            var DropExternalTableMapping = Command("DropExternalTableMapping", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape139));

            var DropExternalTable = Command("DropExternalTable", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    shape140));

            var DropFollowerDatabases = Command("DropFollowerDatabases", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("follower"),
                    First(
                        fragment60,
                        Custom(
                            Token("databases"),
                            RequiredToken("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.DatabaseNameReference,
                                        shape4),
                                    missingElement: rules.MissingNameReference),
                                missing37),
                            RequiredToken(")"),
                            shape104),
                        Custom(
                            Token("database"),
                            rules.DatabaseNameReference,
                            shape141)),
                    RequiredToken("from"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal)}));

            var DropFollowerDatabaseAuthorizedPrincipals = Command("DropFollowerDatabaseAuthorizedPrincipals", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "monitors", "unrestrictedviewers", "users", "viewers"),
                    Required(
                        First(
                            Token("("),
                            Custom(
                                Token("from"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                RequiredToken("("),
                                shape44)),
                        missing0),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD("operationRole"), CD(), CD(CompletionHint.Literal), CD()}));

            var DropFunctions = Command("DropFunctions", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("functions"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseFunctionNameReference,
                                shape52),
                            missingElement: rules.MissingNameReference),
                        missing37),
                    RequiredToken(")"),
                    Optional(Token("ifexists")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Function), CD(), CD(isOptional: true)}));

            var DropFunctionRole = Command("DropFunctionRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape105));

            var DropFunction = Command("DropFunction", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    Optional(Token("ifexists")),
                    shape143));

            var DropMaterializedViewAdmins = Command("DropMaterializedViewAdmins", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape0)),
                    shape106));

            var DropMaterializedView = Command("DropMaterializedView", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape109));

            var DropRowStore = Command("DropRowStore", 
                Custom(
                    Token("detach", "drop"),
                    Token("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(Token("ifexists")),
                    new [] {CD(), CD(), CD("rowStoreName", CompletionHint.None), CD(isOptional: true)}));

            var StoredQueryResultsDrop = Command("StoredQueryResultsDrop", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("stored_query_results"),
                    RequiredToken("by"),
                    RequiredToken("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("Principal", CompletionHint.Literal)}));

            var StoredQueryResultDrop = Command("StoredQueryResultDrop", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("StoredQueryResultName", CompletionHint.None)}));

            var DropStoredQueryResultContainers = Command("DropStoredQueryResultContainers", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("storedqueryresultcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    Required(
                        OneOrMoreList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0)),
                        missing42),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(CompletionHint.Literal)}));

            var DropTables = Command("DropTables", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("tables"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.TableNameReference,
                                shape10),
                            missingElement: rules.MissingNameReference),
                        missing37),
                    RequiredToken(")"),
                    Optional(Token("ifexists")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(isOptional: true)}));

            var DropTableColumns = Command("DropTableColumns", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("columns"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.ColumnNameReference,
                                shape11),
                            missingElement: rules.MissingNameReference),
                        missing37),
                    RequiredToken(")"),
                    shape70));

            var DropTableIngestionMapping = Command("DropTableIngestionMapping", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape154));

            var DropTableRole = Command("DropTableRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("admins", "ingestors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Optional(
                        First(
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape0))),
                    shape107));

            var DropTable = Command("DropTable", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Optional(Token("ifexists")),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(isOptional: true)}));

            var DropTempStorage = Command("DropTempStorage", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("tempstorage"),
                    RequiredToken("older"),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD(), CD("olderThan", CompletionHint.Literal)}));

            var DropUnusedStoredQueryResultContainers = Command("DropUnusedStoredQueryResultContainers", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("unused"),
                    RequiredToken("storedqueryresultcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD(), CD("databaseName", CompletionHint.Database)}));

            var DropWorkloadGroup = Command("DropWorkloadGroup", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("WorkloadGroupName", CompletionHint.None)}));

            var EnableContinuousExport = Command("EnableContinuousExport", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape108));

            var EnableDatabaseMaintenanceMode = Command("EnableDatabaseMaintenanceMode", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("maintenance_mode"),
                    shape99));

            var EnableDisableMaterializedView = Command("EnableDisableMaterializedView", 
                Custom(
                    Token("disable", "enable"),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape109));

            var EnablePlugin = Command("EnablePlugin", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    RequiredToken("plugin"),
                    Required(
                        First(
                            rules.StringLiteral,
                            rules.NameDeclaration),
                        rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("name", CompletionHint.Literal)}));

            var ExecuteDatabaseScript = Command("ExecuteDatabaseScript", 
                Custom(
                    Token("execute", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            Custom(
                                Token("database"),
                                RequiredToken("script")),
                            Token("script")),
                        missing62),
                    RequiredToken("<|"),
                    Required(rules.ScriptInput, rules.MissingStatement),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Tabular)}));

            var ExportToSqlTable = Command("ExportToSqlTable", 
                Custom(
                    Token("export", CompletionKind.CommandPrefix),
                    First(
                        fragment47,
                        Token("to")),
                    Token("sql"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(
                        First(
                            Token("<|"),
                            fragment46),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD("SqlTableName", CompletionHint.None), CD("SqlConnectionString", CompletionHint.Literal), CD(), CD("Query", CompletionHint.Tabular)}));

            var ExportToExternalTable = Command("ExportToExternalTable", 
                Custom(
                    Token("export", CompletionKind.CommandPrefix),
                    First(
                        fragment47,
                        Token("to")),
                    Token("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            Token("<|"),
                            fragment46),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD("Query", CompletionHint.Tabular)}));

            var ExportToStorage = Command("ExportToStorage", 
                Custom(
                    Token("export", CompletionKind.CommandPrefix),
                    Optional(
                        First(
                            Custom(
                                Token("async"),
                                Optional(Token("compressed")),
                                shape87),
                            Token("compressed"))),
                    RequiredToken("to"),
                    RequiredToken("csv", "json", "parquet", "tsv"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape0),
                            missingElement: rules.MissingStringLiteral),
                        missing1),
                    RequiredToken(")"),
                    Required(
                        First(
                            Token("<|"),
                            fragment46),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(), CD("Query", CompletionHint.Tabular)}));

            var IngestInlineIntoTable = Command("IngestInlineIntoTable", 
                Custom(
                    Token("ingest", CompletionKind.CommandPrefix),
                    Token("inline"),
                    RequiredToken("into"),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Custom(
                                Token("["),
                                Required(rules.BracketedInputText, rules.MissingInputText),
                                RequiredToken("]"),
                                new [] {CD(), CD("Data", CompletionHint.None), CD()}),
                            Custom(
                                Token("<|"),
                                Required(rules.InputText, rules.MissingInputText),
                                new [] {CD(), CD("Data", CompletionHint.None)}),
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment48),
                                    missing41),
                                RequiredToken(")"),
                                RequiredToken("<|"),
                                Required(rules.InputText, rules.MissingInputText),
                                new [] {CD(), CD(), CD(), CD(), CD(), CD("Data", CompletionHint.None)})),
                        missing63),
                    new [] {CD(), CD(), CD(), CD(), CD("TableName", CompletionHint.None), CD()}));

            var IngestIntoTable = Command("IngestIntoTable", 
                Custom(
                    Token("ingest", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            Custom(
                                Token("async"),
                                RequiredToken("into")),
                            Token("into")),
                        missing64),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.StringLiteral,
                                            shape0),
                                        missingElement: rules.MissingStringLiteral),
                                    missing1),
                                RequiredToken(")"),
                                shape110),
                            Custom(
                                rules.StringLiteral,
                                shape0)),
                        missing65),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            Required(
                                OneOrMoreCommaList(
                                    fragment48),
                                missing41),
                            RequiredToken(")"))),
                    new [] {CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true)}));

            var MergeDatabaseShardGroups = Command("MergeDatabaseShardGroups", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    Token("database").Hide(),
                    RequiredToken("shard-groups").Hide()));

            var MergeExtentsDryrun = Command("MergeExtentsDryrun", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    Token("dryrun"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0),
                            missingElement: rules.MissingValue),
                        missing58),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(CompletionHint.Literal), CD()}));

            var MergeExtents = Command("MergeExtents", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment49,
                            Custom(
                                If(Not(And(Token("database", "dryrun", "async"))), rules.TableNameReference),
                                shape10)),
                        missing40),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0),
                            missingElement: rules.MissingValue),
                        missing58),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            RequiredToken("rebuild"),
                            RequiredToken("="),
                            RequiredToken("true"),
                            RequiredToken(")"))),
                    shape137));

            var MoveExtentsFrom = Command("MoveExtentsFrom", 
                Custom(
                    Token("move", CompletionKind.CommandPrefix),
                    First(
                        Custom(
                            Token("async"),
                            Token("extents")),
                        Token("extents")),
                    First(
                        Custom(
                            Token("("),
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape0),
                                missingElement: rules.MissingValue),
                            Token(")"),
                            shape110),
                        fragment71,
                        Token("all")),
                    RequiredToken("from"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("SourceTableName", CompletionHint.Table), CD(), CD(), CD("DestinationTableName", CompletionHint.Table)}));

            var MoveExtentsQuery = Command("MoveExtentsQuery", 
                Custom(
                    Token("move", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment50,
                            Token("extents")),
                        missing66),
                    RequiredToken("to"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD(), CD("DestinationTableName", CompletionHint.Table), CD(), CD("Query", CompletionHint.Tabular)}));

            var PatchExtentCorruptedDatetime = Command("PatchExtentCorruptedDatetime", 
                Custom(
                    Token("patch"),
                    Required(
                        First(
                            Token("extents"),
                            Custom(
                                Token("table"),
                                Required(rules.TableNameReference, rules.MissingNameReference),
                                RequiredToken("extents"),
                                shape150)),
                        missing43),
                    RequiredToken("corrupted"),
                    RequiredToken("datetime")).Hide());

            var RenameColumns = Command("RenameColumns", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("columns"),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken("="),
                                Required(rules.DatabaseTableColumnNameReference, rules.MissingNameReference),
                                new [] {CD("NewColumnName", CompletionHint.None), CD(), CD("ColumnName", CompletionHint.Column)})),
                        missing67),
                    shape111));

            var RenameColumn = Command("RenameColumn", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.DatabaseTableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD("NewColumnName", CompletionHint.None)}));

            var RenameMaterializedView = Command("RenameMaterializedView", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("NewMaterializedViewName", CompletionHint.None)}));

            var RenameTables = Command("RenameTables", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken("="),
                                Required(rules.TableNameReference, rules.MissingNameReference),
                                new [] {CD("NewTableName", CompletionHint.None), CD(), CD("TableName", CompletionHint.Table)})),
                        missing68),
                    shape111));

            var RenameTable = Command("RenameTable", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("NewTableName", CompletionHint.None)}));

            var ReplaceExtents = Command("ReplaceExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("replace", CompletionKind.CommandPrefix),
                        Required(
                            First(
                                fragment50,
                                Token("extents")),
                            missing69),
                        RequiredToken("in"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("<|"),
                        RequiredToken("{"),
                        Required(rules.QueryInput, rules.MissingExpression),
                        RequiredToken("}"),
                        RequiredToken(","),
                        RequiredToken("{"),
                        Required(rules.QueryInput, rules.MissingExpression),
                        RequiredToken("}")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD("DestinationTableName", CompletionHint.Table), CD(), CD(), CD("ExtentsToDropQuery", CompletionHint.Tabular), CD(), CD(), CD(), CD("ExtentsToMoveQuery", CompletionHint.Tabular), CD()}));

            var SetOrAppendTable = Command("SetOrAppendTable", 
                Custom(
                    Token("set-or-append", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment52,
                            Custom(
                                If(Not(Token("async")), rules.NameDeclaration),
                                shape12)),
                        missing70),
                    Required(
                        First(
                            Token("<|"),
                            fragment51),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape112));

            var StoredQueryResultSetOrReplace = Command("StoredQueryResultSetOrReplace", 
                Custom(
                    Token("set-or-replace", CompletionKind.CommandPrefix),
                    First(
                        fragment55,
                        Token("stored_query_result")),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Token("<|"),
                            fragment51),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape115));

            var SetOrReplaceTable = Command("SetOrReplaceTable", 
                Custom(
                    Token("set-or-replace", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment52,
                            Custom(
                                If(Not(And(Token("async", "stored_query_result"))), rules.NameDeclaration),
                                shape12)),
                        missing70),
                    Required(
                        First(
                            Token("<|"),
                            fragment51),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape112));

            var SetAccess = Command("SetAccess", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("access"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    RequiredToken("readonly", "readwrite"),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("AccessMode")}));

            var SetClusterRole = Command("SetClusterRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("admins", "alldatabaseadmins", "alldatabasemonitors", "alldatabaseviewers", "databasecreators", "monitors", "ops", "users", "viewers"),
                    Required(
                        First(
                            fragment53,
                            fragment54),
                        missing71),
                    new [] {CD(), CD(), CD("Role"), CD()}));

            var SetContinuousExportCursor = Command("SetContinuousExportCursor", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("cursor"),
                    RequiredToken("to"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("jobName", CompletionHint.None), CD(), CD(), CD("cursorValue", CompletionHint.Literal)}));

            var SetDatabaseRole = Command("SetDatabaseRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors", "monitors", "unrestrictedviewers", "users", "viewers"),
                    Required(
                        First(
                            fragment53,
                            fragment54),
                        missing71),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD("Role"), CD()}));

            var SetExternalTableAdmins = Command("SetExternalTableAdmins", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.StringLiteral,
                                            shape0),
                                        missingElement: rules.MissingStringLiteral),
                                    missing1),
                                RequiredToken(")"),
                                Optional(
                                    First(
                                        fragment45,
                                        Custom(
                                            rules.StringLiteral,
                                            shape0))),
                                shape114),
                            Custom(
                                Token("none"),
                                Optional(Token("skip-results")),
                                shape87)),
                        missing72),
                    new [] {CD(), CD(), CD(), CD("externalTableName", CompletionHint.ExternalTable), CD(), CD()}));

            var SetFunctionRole = Command("SetFunctionRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    Required(
                        First(
                            fragment53,
                            fragment54),
                        missing71),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD("Role"), CD()}));

            var SetMaterializedViewAdmins = Command("SetMaterializedViewAdmins", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("admins"),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.StringLiteral,
                                            shape0),
                                        missingElement: rules.MissingStringLiteral),
                                    missing1),
                                RequiredToken(")"),
                                Optional(
                                    Custom(
                                        rules.StringLiteral,
                                        shape0)),
                                new [] {CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)}),
                            Token("none")),
                        missing73),
                    new [] {CD(), CD(), CD("materializedViewName", CompletionHint.MaterializedView), CD(), CD()}));

            var SetMaterializedViewConcurrency = Command("SetMaterializedViewConcurrency", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("concurrency"),
                    Optional(
                        Custom(
                            Token("="),
                            Required(
                                First(
                                    rules.Value,
                                    rules.Value),
                                rules.MissingValue),
                            new [] {CD(), CD("n", CompletionHint.Literal)})),
                    shape147));

            var SetMaterializedViewCursor = Command("SetMaterializedViewCursor", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("cursor"),
                    RequiredToken("to"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("CursorValue", CompletionHint.Literal)}));

            var StoredQueryResultSet = Command("StoredQueryResultSet", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    First(
                        fragment55,
                        Token("stored_query_result")),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Token("<|"),
                            fragment51),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape115));

            var SetTableRowStoreReferences = Command("SetTableRowStoreReferences", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("rowstore_references"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("references", CompletionHint.Literal)}));

            var SetTableRole = Command("SetTableRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors"),
                    Required(
                        First(
                            fragment53,
                            fragment54),
                        missing71),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD("Role"), CD()}));

            var SetTable = Command("SetTable", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Required(
                        First(
                            fragment52,
                            Custom(
                                If(Not(And(Token("access", "cluster", "continuous-export", "database", "external", "function", "materialized-view", "async", "stored_query_result", "table"))), rules.NameDeclaration),
                                shape12)),
                        missing70),
                    Required(
                        First(
                            Token("<|"),
                            fragment51),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape112));

            var ShowBasicAuthUsers = Command("ShowBasicAuthUsers", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("basicauth"),
                    RequiredToken("users")));

            var ShowCache = Command("ShowCache", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cache")));

            var ShowCallStacks = Command("ShowCallStacks", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("callstacks"),
                    Optional(
                        fragment15),
                    shape88));

            var ShowCapacity = Command("ShowCapacity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("capacity"),
                    Optional(
                        First(
                            Custom(
                                Token("data-export", "extents-merge", "extents-partition", "ingestions", "periodic-storage-artifacts-cleanup", "purge-storage-artifacts-cleanup", "queries", "stored-query-results", "streaming-ingestion-post-processing", "table-purge"),
                                Optional(
                                    fragment56),
                                new [] {CD("Resource"), CD(isOptional: true)}),
                            fragment56)),
                    shape88));

            var ShowCertificates = Command("ShowCertificates", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("certificates")));

            var ShowClusterAdminState = Command("ShowClusterAdminState", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("admin"),
                    RequiredToken("state")));

            var ShowClusterBlockedPrincipals = Command("ShowClusterBlockedPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("blockedprincipals")));

            var ShowClusterExtentsMetadata = Command("ShowClusterExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("extents"),
                    Optional(
                        First(
                            fragment61,
                            Token("hot"))),
                    Token("metadata"),
                    Optional(
                        First(
                            fragment58,
                            fragment57)),
                    shape123));

            var ShowClusterExtents = Command("ShowClusterExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("extents"),
                    Optional(
                        First(
                            fragment63,
                            Token("hot"))),
                    Optional(
                        First(
                            fragment58,
                            fragment57)),
                    shape125));

            var ShowClusterJournal = Command("ShowClusterJournal", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("journal")));

            var ShowClusterMonitoring = Command("ShowClusterMonitoring", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("monitoring")));

            var ShowClusterNetwork = Command("ShowClusterNetwork", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("network"),
                    Optional(
                        Custom(
                            rules.Value,
                            shape0)),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var ShowClusterPendingContinuousExports = Command("ShowClusterPendingContinuousExports", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("pending"),
                    RequiredToken("continuous-exports"),
                    Optional(
                        fragment15),
                    shape119));

            var ShowClusterPolicyCaching = Command("ShowClusterPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("caching")));

            var ShowClusterPolicyCallout = Command("ShowClusterPolicyCallout", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout")));

            var ShowClusterPolicyCapacity = Command("ShowClusterPolicyCapacity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("capacity")));

            var ShowClusterPolicyDiagnostics = Command("ShowClusterPolicyDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("diagnostics")));

            var ShowClusterPolicyIngestionBatching = Command("ShowClusterPolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("ingestionbatching")));

            var ShowClusterPolicyManagedIdentity = Command("ShowClusterPolicyManagedIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity")));

            var ShowClusterPolicyMultiDatabaseAdmins = Command("ShowClusterPolicyMultiDatabaseAdmins", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("multidatabaseadmins")));

            var ShowClusterPolicyQueryWeakConsistency = Command("ShowClusterPolicyQueryWeakConsistency", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("query_weak_consistency")));

            var ShowClusterPolicyRequestClassification = Command("ShowClusterPolicyRequestClassification", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification")));

            var ShowClusterPolicyRowStore = Command("ShowClusterPolicyRowStore", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore")));

            var ShowClusterPolicySandbox = Command("ShowClusterPolicySandbox", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sandbox")));

            var ShowClusterPolicySharding = Command("ShowClusterPolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding"),
                    Optional(
                        fragment15),
                    shape119));

            var ShowClusterPolicyStreamingIngestion = Command("ShowClusterPolicyStreamingIngestion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    RequiredToken("streamingingestion")));

            var ShowClusterPrincipals = Command("ShowClusterPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("principals")));

            var ShowClusterPrincipalRoles = Command("ShowClusterPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment67),
                        missing75),
                    Optional(
                        fragment15),
                    shape119));

            var ShowClusterSandboxesStats = Command("ShowClusterSandboxesStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("sandboxes"),
                    RequiredToken("stats")));

            var ShowClusterScaleIn = Command("ShowClusterScaleIn", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("scalein"),
                    Required(
                        First(
                            rules.Value,
                            rules.Value),
                        rules.MissingValue),
                    RequiredToken("nodes"),
                    new [] {CD(), CD(), CD(), CD("num", CompletionHint.Literal), CD()}));

            var ShowClusterServices = Command("ShowClusterServices", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("services")));

            var ShowClusterStorageKeysHash = Command("ShowClusterStorageKeysHash", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("storage"),
                    RequiredToken("keys"),
                    RequiredToken("hash")));

            var ShowCluster = Command("ShowCluster", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster")));

            var ShowColumnPolicyCaching = Command("ShowColumnPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("column"),
                    First(
                        Token("*"),
                        If(Not(Token("*")), rules.DatabaseTableColumnNameReference)),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD("ColumnName"), CD(), CD()}));

            var ShowColumnPolicyEncoding = Command("ShowColumnPolicyEncoding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(If(Not(Token("*")), rules.TableColumnNameReference), rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    shape92));

            var ShowCommandsAndQueries = Command("ShowCommandsAndQueries", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commands-and-queries")));

            var ShowCommands = Command("ShowCommands", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commands")));

            var ShowCommConcurrency = Command("ShowCommConcurrency", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commconcurrency")));

            var ShowCommPools = Command("ShowCommPools", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commpools")));

            var ShowContinuousExports = Command("ShowContinuousExports", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-exports")));

            var ShowContinuousExportExportedArtifacts = Command("ShowContinuousExportExportedArtifacts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    rules.NameDeclaration,
                    Token("exported-artifacts"),
                    shape120));

            var ShowContinuousExportFailures = Command("ShowContinuousExportFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    rules.NameDeclaration,
                    Token("failures"),
                    shape120));

            var ShowContinuousExport = Command("ShowContinuousExport", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape108));

            var ShowDatabasesSchemaAsJson = Command("ShowDatabasesSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.DatabaseNameReference,
                            Optional(
                                Custom(
                                    Token("if_later_than"),
                                    rules.StringLiteral,
                                    shape121)),
                            shape122)),
                    Token(")"),
                    Token("schema"),
                    Token("as"),
                    RequiredToken("json"),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Database), CD(), CD(), CD(), CD()}));

            var ShowDatabasesSchema = Command("ShowDatabasesSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseNameReference,
                                Optional(
                                    fragment64),
                                shape122)),
                        missing76),
                    RequiredToken(")"),
                    RequiredToken("schema"),
                    Optional(Token("details")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Database), CD(), CD(), CD(isOptional: true)}));

            var ShowClusterDatabasesDataStats = Command("ShowClusterDatabasesDataStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment59,
                        Token("databases")),
                    Token("datastats")));

            var ShowClusterDatabasesDetails = Command("ShowClusterDatabasesDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment59,
                        Token("databases")),
                    Token("details")));

            var ShowClusterDatabasesIdentity = Command("ShowClusterDatabasesIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment59,
                        Token("databases")),
                    RequiredToken("identity")));

            var ShowDatabasesManagementGroups = Command("ShowDatabasesManagementGroups", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("management"),
                    RequiredToken("groups")));

            var ShowClusterDatabasesPolicies = Command("ShowClusterDatabasesPolicies", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment59,
                        Token("databases")),
                    Token("policies")));

            var ShowClusterDatabases = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment59,
                        Custom(
                            Token("cluster"),
                            RequiredToken("databases")),
                        Token("databases")),
                    Optional(
                        Custom(
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.DatabaseNameReference,
                                        shape4),
                                    missingElement: rules.MissingNameReference),
                                missing37),
                            RequiredToken(")"),
                            shape73)),
                    shape88));

            var ShowDatabaseCacheQueryResults = Command("ShowDatabaseCacheQueryResults", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cache"),
                    RequiredToken("query_results")));

            var ShowDatabaseDataStats = Command("ShowDatabaseDataStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("datastats")));

            var ShowDatabaseDetails = Command("ShowDatabaseDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("details")));

            var ShowDatabaseExtentsMetadata = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment60,
                        fragment62),
                    Token("extents"),
                    Optional(
                        First(
                            fragment61,
                            Token("hot"))),
                    Token("metadata"),
                    Optional(
                        First(
                            fragment58,
                            fragment57)),
                    shape123));

            var ShowDatabaseExtents = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment60,
                        Custom(
                            Token("databases"),
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.DatabaseNameReference,
                                        shape4),
                                    missingElement: rules.MissingNameReference),
                                missing37),
                            RequiredToken(")"),
                            shape104),
                        fragment62),
                    RequiredToken("extents"),
                    Optional(
                        First(
                            fragment63,
                            Token("hot"))),
                    Optional(
                        First(
                            fragment58,
                            fragment57)),
                    shape125));

            var ShowDatabaseExtentTagsStatistics = Command("ShowDatabaseExtentTagsStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extent"),
                    RequiredToken("tags"),
                    RequiredToken("statistics"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            RequiredToken("minCreationTime"),
                            RequiredToken("="),
                            Required(rules.Value, rules.MissingValue),
                            RequiredToken(")"),
                            new [] {CD(), CD(), CD(), CD(), CD("minCreationTime", CompletionHint.Literal), CD()})),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseIdentity = Command("ShowDatabaseIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("identity")));

            var ShowDatabasePolicies = Command("ShowDatabasePolicies", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("policies")));

            var ShowDatabaseCslSchema = Command("ShowDatabaseCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("cslschema"),
                        Custom(
                            If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                            Token("cslschema"),
                            shape127)),
                    Optional(
                        First(
                            fragment64,
                            Custom(
                                Token("script"),
                                Optional(
                                    fragment64),
                                shape87))),
                    shape130));

            var ShowDatabaseExtentsPartitioningStatistics = Command("ShowDatabaseExtentsPartitioningStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("extents"),
                        Custom(
                            If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                            Token("extents"),
                            shape128)),
                    Token("partitioning"),
                    RequiredToken("statistics")));

            var ShowDatabaseIngestionMappings = Command("ShowDatabaseIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("ingestion"),
                        Custom(
                            If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                            Token("ingestion"),
                            shape127)),
                    Required(
                        First(
                            Token("mappings"),
                            fragment70),
                        missing77),
                    Optional(
                        First(
                            fragment15,
                            Custom(
                                rules.StringLiteral,
                                Optional(
                                    fragment15),
                                new [] {CD("name", CompletionHint.Literal), CD(isOptional: true)}))),
                    shape119));

            var ShowDatabaseSchemaAsCslScript = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("schema"),
                        fragment65),
                    First(
                        Token("as"),
                        fragment66),
                    Token("csl"),
                    RequiredToken("script"),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseSchemaAsJson = Command("ShowDatabaseSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("schema"),
                        fragment65),
                    First(
                        Token("as"),
                        fragment66),
                    RequiredToken("json")));

            var ShowDatabaseSchema = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("schema"),
                        fragment65),
                    Optional(
                        First(
                            Custom(
                                Token("details"),
                                Optional(
                                    fragment64),
                                shape87),
                            fragment64)),
                    shape130));

            var DatabaseShardGroupsStatisticsShow = Command("DatabaseShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("shard-groups").Hide(),
                        Custom(
                            If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                            Token("shard-groups").Hide(),
                            shape128)),
                    RequiredToken("statistics").Hide()));

            var ShowDatabaseExtentContainersCleanOperations = Command("ShowDatabaseExtentContainersCleanOperations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("extentcontainers"),
                    RequiredToken("clean"),
                    RequiredToken("operations"),
                    Optional(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape0)),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var ShowDatabaseJournal = Command("ShowDatabaseJournal", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("journal"),
                    shape99));

            var ShowDatabasePolicyCaching = Command("ShowDatabasePolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("caching"),
                    shape131));

            var ShowDatabasePolicyDiagnostics = Command("ShowDatabasePolicyDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("diagnostics"),
                    shape93));

            var ShowDatabasePolicyEncoding = Command("ShowDatabasePolicyEncoding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("encoding"),
                    shape93));

            var ShowDatabasePolicyExtentTagsRetention = Command("ShowDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape131));

            var ShowDatabasePolicyHardRetentionViolations = Command("ShowDatabasePolicyHardRetentionViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("hardretention"),
                    RequiredToken("violations"),
                    shape132));

            var ShowDatabasePolicyIngestionBatching = Command("ShowDatabasePolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape131));

            var ShowDatabasePolicyManagedIdentity = Command("ShowDatabasePolicyManagedIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("managed_identity"),
                    shape93));

            var ShowDatabasePolicyMerge = Command("ShowDatabasePolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("merge"),
                    shape131));

            var ShowDatabasePolicyRetention = Command("ShowDatabasePolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("retention"),
                    shape131));

            var ShowDatabasePolicySharding = Command("ShowDatabasePolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("sharding"),
                    shape131));

            var ShowDatabasePolicyShardsGrouping = Command("ShowDatabasePolicyShardsGrouping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    First(
                        Token("*"),
                        If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference)),
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    shape131));

            var ShowDatabasePolicySoftRetentionViolations = Command("ShowDatabasePolicySoftRetentionViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("softretention"),
                    RequiredToken("violations"),
                    shape132));

            var ShowDatabasePolicyStreamingIngestion = Command("ShowDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("policy"),
                    RequiredToken("streamingingestion"),
                    shape93));

            var ShowDatabasePrincipals = Command("ShowDatabasePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("principals"),
                    shape99));

            var ShowDatabasePrincipalRoles = Command("ShowDatabasePrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment67),
                        missing75),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabasePurgeOperation = Command("ShowDatabasePurgeOperation", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    Token("purge"),
                    Required(
                        First(
                            Custom(
                                Token("operations"),
                                Optional(
                                    Custom(
                                        rules.AnyGuidLiteralOrString,
                                        shape0)),
                                shape35),
                            Custom(
                                Token("operation"),
                                Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                                new [] {CD(), CD("obj", CompletionHint.Literal)})),
                        missing78),
                    shape134));

            var ShowDatabaseSchemaViolations = Command("ShowDatabaseSchemaViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("cache", "datastats", "details", "extents", "extent", "identity", "policies", "cslschema", "ingestion", "schema", "shard-groups", "*"))), rules.DatabaseNameReference),
                    RequiredToken("schema"),
                    RequiredToken("violations"),
                    shape134));

            var ShowDatabase = Command("ShowDatabase", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database")));

            var ShowDiagnostics = Command("ShowDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("diagnostics"),
                    Optional(
                        fragment56),
                    shape88));

            var ShowEntityGroups = Command("ShowEntityGroups", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("entity_groups")));

            var ShowEntityGroup = Command("ShowEntityGroup", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    shape135));

            var ShowEntitySchema = Command("ShowEntitySchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("entity"),
                    Required(rules.QualifiedNameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    Optional(
                        First(
                            fragment68,
                            Custom(
                                Token("in"),
                                RequiredToken("databases"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.StringLiteral,
                                            shape0),
                                        missingElement: rules.MissingStringLiteral),
                                    missing1),
                                RequiredToken(")"),
                                Optional(
                                    fragment68),
                                shape137))),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD("entity", CompletionHint.None), CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowExtentContainers = Command("ShowExtentContainers", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    Optional(
                        fragment15),
                    shape88));

            var ShowExtentColumnStorageStats = Command("ShowExtentColumnStorageStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("extent"),
                    rules.AnyGuidLiteralOrString,
                    Token("column"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("storage"),
                    RequiredToken("stats"),
                    new [] {CD(), CD(), CD("extentId", CompletionHint.Literal), CD(), CD("columnName", CompletionHint.None), CD(), CD()}));

            var ShowExtentDetails = Command("ShowExtentDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("extent"),
                    Required(
                        First(
                            Custom(
                                Token("details"),
                                Required(
                                    First(
                                        Custom(
                                            rules.AnyGuidLiteralOrString,
                                            shape0),
                                        Custom(
                                            rules.NameDeclaration,
                                            shape12)),
                                    rules.MissingValue),
                                new [] {CD(), CD(CompletionHint.Literal)}),
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0),
                            Custom(
                                If(Not(Token("details")), rules.NameDeclaration),
                                shape12)),
                        missing79)));

            var ShowExternalTables = Command("ShowExternalTables", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("tables")));

            var ShowExternalTableArtifacts = Command("ShowExternalTableArtifacts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("artifacts"),
                    Optional(
                        fragment40),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(isOptional: true)}));

            var ShowExternalTableCslSchema = Command("ShowExternalTableCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("cslschema"),
                    shape138));

            var ShowExternalTableMappings = Command("ShowExternalTableMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("mappings"),
                    shape138));

            var ShowExternalTableMapping = Command("ShowExternalTableMapping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape139));

            var ShowExternalTablePrincipals = Command("ShowExternalTablePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("principals"),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.ExternalTable), CD()}));

            var ShowExternalTablesPrincipalRoles = Command("ShowExternalTablesPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment67),
                        missing75),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(), CD(isOptional: true)}));

            var ShowExternalTableSchema = Command("ShowExternalTableSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("csl", "json"),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(), CD()}));

            var ShowExternalTable = Command("ShowExternalTable", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    shape140));

            var ShowFabricCache = Command("ShowFabricCache", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabriccache")));

            var ShowFabricClocks = Command("ShowFabricClocks", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabricclocks")));

            var ShowFabricLocks = Command("ShowFabricLocks", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabriclocks")));

            var ShowFabric = Command("ShowFabric", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabric"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("id", CompletionHint.None)}));

            var ShowFeatureFlags = Command("ShowFeatureFlags", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("featureflags")));

            var ShowFollowerDatabase = Command("ShowFollowerDatabase", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Required(
                        First(
                            Custom(
                                Token("databases"),
                                Optional(
                                    fragment34),
                                shape87),
                            Custom(
                                Token("database"),
                                Required(rules.DatabaseNameReference, rules.MissingNameReference),
                                shape141)),
                        missing80)));

            var ShowFreshness = Command("ShowFreshness", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("freshness").Hide(),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Optional(
                        First(
                            Custom(
                                Token("column"),
                                Required(rules.ColumnNameReference, rules.MissingNameReference),
                                Optional(
                                    fragment69),
                                new [] {CD(), CD("columnName", CompletionHint.Column), CD(isOptional: true)}),
                            fragment69)),
                    new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD(isOptional: true)}));

            var ShowFunctions = Command("ShowFunctions", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("functions")));

            var ShowFunctionPrincipals = Command("ShowFunctionPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("principals"),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD()}));

            var ShowFunctionPrincipalRoles = Command("ShowFunctionPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment67),
                        missing75),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD(), CD(), CD(isOptional: true)}));

            var ShowFunctionSchemaAsJson = Command("ShowFunctionSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    Optional(
                        fragment36),
                    new [] {CD(), CD(), CD("functionName", CompletionHint.Function), CD(), CD(), CD(), CD(isOptional: true)}));

            var ShowFunction = Command("ShowFunction", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    Optional(
                        fragment36),
                    shape143));

            var ShowIngestionFailures = Command("ShowIngestionFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    Token("failures"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            RequiredToken("OperationId"),
                            RequiredToken("="),
                            Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                            RequiredToken(")"),
                            new [] {CD(), CD(), CD(), CD(), CD("OperationId", CompletionHint.Literal), CD()})),
                    shape130));

            var ShowIngestionMappings = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        Custom(
                            Token("cluster"),
                            Token("ingestion")),
                        Custom(
                            Token("cluster"),
                            RequiredToken("ingestion")),
                        Token("ingestion")),
                    Required(
                        First(
                            Token("mappings"),
                            fragment70),
                        missing77),
                    Optional(
                        fragment15),
                    shape130));

            var ShowJournal = Command("ShowJournal", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("journal")));

            var ShowMaterializedViewsDetails = Command("ShowMaterializedViewsDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-views"),
                    First(
                        Custom(
                            Token("("),
                            OneOrMoreCommaList(
                                Custom(
                                    rules.MaterializedViewNameReference,
                                    shape8),
                                missingElement: rules.MissingNameReference),
                            Token(")"),
                            Token("details"),
                            shape145),
                        Custom(
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.MaterializedViewNameReference,
                                        shape8),
                                    missingElement: rules.MissingNameReference),
                                missing37),
                            RequiredToken(")"),
                            RequiredToken("details"),
                            shape145),
                        Token("details"))));

            var ShowMaterializedViews = Command("ShowMaterializedViews", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-views")));

            var ShowMaterializedViewCslSchema = Command("ShowMaterializedViewCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("cslschema"),
                    shape146));

            var ShowMaterializedViewDetails = Command("ShowMaterializedViewDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("details"),
                    shape146));

            var ShowMaterializedViewDiagnostics = Command("ShowMaterializedViewDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("diagnostics"),
                    Optional(
                        fragment15),
                    shape147));

            var ShowMaterializedViewExtents = Command("ShowMaterializedViewExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("extents"),
                    Optional(
                        First(
                            fragment63,
                            Token("hot"))),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(isOptional: true)}));

            var ShowMaterializedViewFailures = Command("ShowMaterializedViewFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("failures"),
                    shape148));

            var ShowMaterializedViewPolicyCaching = Command("ShowMaterializedViewPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape94));

            var ShowMaterializedViewPolicyMerge = Command("ShowMaterializedViewPolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("merge"),
                    shape94));

            var ShowMaterializedViewPolicyPartitioning = Command("ShowMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    shape94));

            var ShowMaterializedViewPolicyRetention = Command("ShowMaterializedViewPolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("retention"),
                    shape94));

            var ShowMaterializedViewPolicyRowLevelSecurity = Command("ShowMaterializedViewPolicyRowLevelSecurity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape94));

            var ShowMaterializedViewPrincipals = Command("ShowMaterializedViewPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("principals"),
                    shape146));

            var ShowMaterializedViewSchemaAsJson = Command("ShowMaterializedViewSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    shape55));

            var ShowMaterializedViewStatistics = Command("ShowMaterializedViewStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("statistics"),
                    shape148));

            var ShowMaterializedView = Command("ShowMaterializedView", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape109));

            var ShowMemory = Command("ShowMemory", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("memory"),
                    Optional(Token("details")),
                    shape88));

            var ShowMemPools = Command("ShowMemPools", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("mempools")));

            var ShowOperations = Command("ShowOperations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("operations"),
                    Optional(
                        First(
                            fragment71,
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape0))),
                    shape88));

            var ShowOperationDetails = Command("ShowOperationDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("operation"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    RequiredToken("details"),
                    new [] {CD(), CD(), CD("OperationId", CompletionHint.Literal), CD()}));

            var ShowPlugins = Command("ShowPlugins", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("plugins"),
                    Optional(
                        fragment15),
                    shape88));

            var ShowPrincipalAccess = Command("ShowPrincipalAccess", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("principal"),
                    Token("access"),
                    Optional(
                        fragment15),
                    shape130));

            var ShowPrincipalRoles = Command("ShowPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment67),
                        missing75),
                    Optional(
                        fragment15),
                    shape130));

            var ShowQueries = Command("ShowQueries", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("queries")));

            var ShowQueryExecution = Command("ShowQueryExecution", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("queryexecution"),
                    Required(
                        fragment11,
                        missing5),
                    new [] {CD(), CD(), CD("queryText")}));

            var ShowQueryPlan = Command("ShowQueryPlan", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("queryplan"),
                    Required(
                        First(
                            Token("<|"),
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            First(
                                                Token("reconstructCsl"),
                                                If(Not(Token("reconstructCsl")), rules.NameDeclaration)),
                                            RequiredToken("="),
                                            Required(rules.Value, rules.MissingValue),
                                            shape53)),
                                    missing81),
                                RequiredToken(")"),
                                RequiredToken("<|"))),
                        missing12),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD("Query", CompletionHint.Tabular)}));

            var ShowQueryCallTree = Command("ShowQueryCallTree", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("query"),
                    RequiredToken("call-tree"),
                    Required(
                        fragment11,
                        missing5),
                    new [] {CD(), CD(), CD(), CD("queryText")}));

            var ShowRequestSupport = Command("ShowRequestSupport", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("request_support"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("key", CompletionHint.Literal)}));

            var ShowRowStores = Command("ShowRowStores", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstores")));

            var ShowRowStoreSeals = Command("ShowRowStoreSeals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Token("seals"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.Literal), CD(isOptional: true)}));

            var ShowRowStoreTransactions = Command("ShowRowStoreTransactions", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Token("transactions")));

            var ShowRowStore = Command("ShowRowStore", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Required(If(Not(And(Token("seals", "transactions"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("rowStoreName", CompletionHint.None)}));

            var ShowRunningQueries = Command("ShowRunningQueries", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("running"),
                    RequiredToken("queries"),
                    Optional(
                        Custom(
                            Token("by"),
                            Required(
                                First(
                                    Token("*"),
                                    fragment0),
                                missing10))),
                    shape130));

            var ShowSchema = Command("ShowSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        Custom(
                            Token("cluster"),
                            Token("schema")),
                        Token("schema")),
                    Optional(
                        First(
                            Custom(
                                Token("as"),
                                RequiredToken("json")),
                            Token("details"))),
                    shape88));

            var ShowServicePoints = Command("ShowServicePoints", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("servicepoints")));

            var StoredQueryResultsShow = Command("StoredQueryResultsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("stored_query_results"),
                    Optional(
                        fragment36),
                    shape88));

            var StoredQueryResultShowSchema = Command("StoredQueryResultShowSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("schema"),
                    new [] {CD(), CD(), CD("StoredQueryResultName", CompletionHint.None), CD()}));

            var ShowStreamingIngestionFailures = Command("ShowStreamingIngestionFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("streamingingestion"),
                    Token("failures")));

            var ShowStreamingIngestionStatistics = Command("ShowStreamingIngestionStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("streamingingestion"),
                    RequiredToken("statistics")));

            var ShowTablesColumnStatistics = Command("ShowTablesColumnStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("column"),
                    RequiredToken("statistics"),
                    RequiredToken("older"),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("outdatewindow", CompletionHint.Literal)}));

            var ShowTablesDetails = Command("ShowTablesDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    First(
                        Custom(
                            Token("("),
                            OneOrMoreCommaList(
                                Custom(
                                    rules.TableNameReference,
                                    shape10),
                                missingElement: rules.MissingNameReference),
                            Token(")"),
                            Token("details"),
                            shape149),
                        Token("details"))));

            var TablesShardGroupsStatisticsShow = Command("TablesShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    First(
                        Custom(
                            Token("("),
                            OneOrMoreCommaList(
                                Custom(
                                    rules.TableNameReference,
                                    shape10),
                                missingElement: rules.MissingNameReference),
                            Token(")"),
                            Token("shard-groups").Hide(),
                            shape149),
                        Token("shard-groups").Hide()),
                    RequiredToken("statistics").Hide()));

            var ShowTables = Command("ShowTables", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Optional(
                        Custom(
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.TableNameReference,
                                        shape10),
                                    missingElement: rules.MissingNameReference),
                                missing37),
                            RequiredToken(")"),
                            shape150)),
                    shape88));

            var ShowExtentCorruptedDatetime = Command("ShowExtentCorruptedDatetime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        Token("extents"),
                        Custom(
                            Token("table"),
                            If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                            Token("extents"),
                            shape150)),
                    Required(
                        Custom(
                            Token("corrupted"),
                            RequiredToken("datetime")),
                        missing82).Hide()));

            var ShowTableExtentsMetadata = Command("ShowTableExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment72,
                        fragment73),
                    Token("extents"),
                    Optional(
                        First(
                            fragment61,
                            Token("hot"))),
                    Token("metadata"),
                    Optional(
                        First(
                            fragment58,
                            fragment57)),
                    shape123));

            var ShowTableExtents = Command("ShowTableExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    First(
                        fragment72,
                        Custom(
                            Token("tables"),
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.TableNameReference,
                                        shape10),
                                    missingElement: rules.MissingNameReference),
                                missing37),
                            RequiredToken(")"),
                            shape151),
                        fragment73),
                    RequiredToken("extents"),
                    Optional(
                        First(
                            fragment63,
                            Token("hot"))),
                    Optional(
                        First(
                            fragment58,
                            fragment57)),
                    shape125));

            var ShowTableStarPolicyCaching = Command("ShowTableStarPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("caching")));

            var ShowTableStarPolicyExtentTagsRetention = Command("ShowTableStarPolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("extent_tags_retention")));

            var ShowTableStarPolicyIngestionBatching = Command("ShowTableStarPolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("ingestionbatching")));

            var ShowTableStarPolicyIngestionTime = Command("ShowTableStarPolicyIngestionTime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("ingestiontime")));

            var ShowTableStarPolicyMerge = Command("ShowTableStarPolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("merge")));

            var ShowTableStarPolicyPartitioning = Command("ShowTableStarPolicyPartitioning", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("partitioning")));

            var ShowTableStarPolicyRestrictedViewAccess = Command("ShowTableStarPolicyRestrictedViewAccess", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("restricted_view_access")));

            var ShowTableStarPolicyRetention = Command("ShowTableStarPolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("retention")));

            var ShowTableStarPolicyRowLevelSecurity = Command("ShowTableStarPolicyRowLevelSecurity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("row_level_security")));

            var ShowTableStarPolicyRowOrder = Command("ShowTableStarPolicyRowOrder", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("roworder")));

            var ShowTableStarPolicySharding = Command("ShowTableStarPolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("sharding")));

            var ShowTableStarPolicyUpdate = Command("ShowTableStarPolicyUpdate", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    RequiredToken("policy"),
                    RequiredToken("update")));

            var ShowTableUsageStatisticsDetails = Command("ShowTableUsageStatisticsDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("usage"),
                    Token("statistics"),
                    Token("details")));

            var ShowTableUsageStatistics = Command("ShowTableUsageStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("usage"),
                    RequiredToken("statistics"),
                    Optional(
                        Custom(
                            Token("by"),
                            Required(rules.Value, rules.MissingValue),
                            new [] {CD(), CD("partitionBy", CompletionHint.Literal)})),
                    shape119));

            var ShowTablePolicyAutoDelete = Command("ShowTablePolicyAutoDelete", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("auto_delete"),
                    shape95));

            var ShowTablePolicyCaching = Command("ShowTablePolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("caching"),
                    shape95));

            var ShowTablePolicyEncoding = Command("ShowTablePolicyEncoding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("encoding"),
                    shape95));

            var ShowTablePolicyExtentTagsRetention = Command("ShowTablePolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape95));

            var ShowTablePolicyIngestionBatching = Command("ShowTablePolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape95));

            var ShowTablePolicyMerge = Command("ShowTablePolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("merge"),
                    shape95));

            var ShowTablePolicyPartitioning = Command("ShowTablePolicyPartitioning", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("partitioning"),
                    shape95));

            var ShowTablePolicyRestrictedViewAccess = Command("ShowTablePolicyRestrictedViewAccess", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("restricted_view_access"),
                    shape95));

            var ShowTablePolicyRetention = Command("ShowTablePolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("retention"),
                    shape95));

            var ShowTablePolicyRowOrder = Command("ShowTablePolicyRowOrder", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("roworder"),
                    shape95));

            var ShowTablePolicySharding = Command("ShowTablePolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("sharding"),
                    shape95));

            var ShowTablePolicyStreamingIngestion = Command("ShowTablePolicyStreamingIngestion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("streamingingestion"),
                    shape95));

            var ShowTablePolicyUpdate = Command("ShowTablePolicyUpdate", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("policy"),
                    RequiredToken("update"),
                    shape95));

            var ShowTableRowStoreReferences = Command("ShowTableRowStoreReferences", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("rowstore_references"),
                    shape152));

            var ShowTableRowStoreSealInfo = Command("ShowTableRowStoreSealInfo", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    Token("rowstore_sealinfo"),
                    shape153));

            var ShowTableRowStores = Command("ShowTableRowStores", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.DatabaseTableNameReference),
                    RequiredToken("rowstores"),
                    shape153));

            var ShowTableColumnsClassification = Command("ShowTableColumnsClassification", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("columns"),
                    RequiredToken("classification"),
                    shape95));

            var ShowTableColumnStatitics = Command("ShowTableColumnStatitics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("column"),
                    RequiredToken("statistics"),
                    shape95));

            var ShowTableCslSchema = Command("ShowTableCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("cslschema"),
                    shape152));

            var ShowTableDetails = Command("ShowTableDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("details"),
                    shape152));

            var ShowTableDimensions = Command("ShowTableDimensions", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("dimensions"),
                    shape152));

            var ShowTableIngestionMappings = Command("ShowTableIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("ingestion"),
                    Token("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    Token("mappings"),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("MappingKind"), CD()}));

            var ShowTableIngestionMapping = Command("ShowTableIngestionMapping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape154));

            var ShowTablePolicyIngestionTime = Command("ShowTablePolicyIngestionTime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("policy"),
                    Token("ingestiontime"),
                    shape95));

            var ShowTablePolicyRowLevelSecurity = Command("ShowTablePolicyRowLevelSecurity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape95));

            var ShowTablePrincipals = Command("ShowTablePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("principals"),
                    shape152));

            var ShowTablePrincipalRoles = Command("ShowTablePrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment67),
                        missing75),
                    Optional(
                        fragment15),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(isOptional: true)}));

            var ShowTableSchemaAsJson = Command("ShowTableSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    shape58));

            var TableShardGroupsStatisticsShow = Command("TableShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("shard-groups").Hide(),
                    Token("statistics").Hide(),
                    shape95));

            var TableShardGroupsShow = Command("TableShardGroupsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("shard-groups").Hide(),
                    shape152));

            var TableShardsGroupMetadataShow = Command("TableShardsGroupMetadataShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("shards-group").Hide(),
                    rules.AnyGuidLiteralOrString,
                    Token("shards").Hide(),
                    Token("metadata").Hide(),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("ShardsGroupId", CompletionHint.Literal), CD(), CD()}));

            var TableShardsGroupShow = Command("TableShardsGroupShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(And(Token("*", "usage"))), rules.TableNameReference),
                    Token("shards-group").Hide(),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    RequiredToken("shards").Hide(),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("ShardsGroupId", CompletionHint.Literal), CD()}));

            var ShowTable = Command("ShowTable", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(If(Not(And(Token("*", "usage"))), rules.TableNameReference), rules.MissingNameReference),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table)}));

            var ShowTcpConnections = Command("ShowTcpConnections", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tcpconnections")));

            var ShowTcpPorts = Command("ShowTcpPorts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tcpports")));

            var ShowThreadPools = Command("ShowThreadPools", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("threadpools")));

            var ShowVersion = Command("ShowVersion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("version")));

            var ShowWorkloadGroups = Command("ShowWorkloadGroups", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("workload_groups")));

            var ShowWorkloadGroup = Command("ShowWorkloadGroup", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("WorkloadGroup", CompletionHint.None)}));

            var UndoDropTable = Command("UndoDropTable", 
                Custom(
                    Token("undo", CompletionKind.CommandPrefix),
                    RequiredToken("drop"),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Custom(
                                Token("as"),
                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                RequiredToken("version"),
                                new [] {CD(), CD("TableName", CompletionHint.None), CD()}),
                            Token("version")),
                        missing83),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(Token("internal")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.None), CD(), CD(), CD("Version", CompletionHint.Literal), CD(isOptional: true)}));

            var commandParsers = new Parser<LexicalToken, Command>[]
            {
                AddClusterBlockedPrincipals,
                AddClusterRole,
                AddDatabaseRole,
                AddExternalTableAdmins,
                AddFollowerDatabaseAuthorizedPrincipals,
                AddFunctionRole,
                AddMaterializedViewAdmins,
                AddTableRole,
                AlterMergeClusterPolicyCallout,
                AlterMergeClusterPolicyCapacity,
                AlterMergeClusterPolicyDiagnostics,
                AlterMergeClusterPolicyMultiDatabaseAdmins,
                AlterMergeClusterPolicyQueryWeakConsistency,
                AlterMergeClusterPolicyRequestClassification,
                AlterMergeClusterPolicySharding,
                AlterMergeClusterPolicyStreamingIngestion,
                AlterMergeClusterPolicyRowStore,
                AlterMergeColumnPolicyEncoding,
                AlterMergeDatabasePolicyDiagnostics,
                AlterMergeDatabasePolicyEncoding,
                AlterMergeDatabasePolicyMerge,
                AlterMergeDatabasePolicyRetention,
                AlterMergeDatabasePolicySharding,
                AlterMergeDatabasePolicyShardsGrouping,
                AlterMergeDatabasePolicyStreamingIngestion,
                AlterMergeEntityGroup,
                AlterMergeExtentTagsFromQuery,
                AlterMergeMaterializedViewPolicyPartitioning,
                AlterMergeMaterializedViewPolicyRetention,
                AlterMergeTablePolicyEncoding,
                AlterMergeTablePolicyMerge,
                AlterMergeTablePolicyRetention,
                AlterMergeTablePolicyRowOrder,
                AlterMergeTablePolicySharding,
                AlterMergeTablePolicyStreamingIngestion,
                AlterMergeTablePolicyUpdate,
                AlterMergeTable,
                AlterMergeTableColumnDocStrings,
                AlterMergeTablePolicyPartitioning,
                AlterMergeWorkloadGroup,
                AlterCache,
                AlterClusterPolicyCaching,
                AlterClusterPolicyCallout,
                AlterClusterPolicyCapacity,
                AlterClusterPolicyDiagnostics,
                AlterClusterPolicyIngestionBatching,
                AlterClusterPolicyManagedIdentity,
                AlterClusterPolicyMultiDatabaseAdmins,
                AlterClusterPolicyQueryWeakConsistency,
                AlterClusterPolicyRequestClassification,
                AlterClusterPolicyRowStore,
                AlterClusterPolicySandbox,
                AlterClusterPolicySharding,
                AlterClusterPolicyStreamingIngestion,
                AlterClusterStorageKeys,
                AlterColumnsPolicyEncodingByQuery,
                AlterColumnPolicyCaching,
                AlterColumnPolicyEncodingType,
                AlterColumnPolicyEncoding,
                AlterColumnType,
                AlterDatabaseIngestionMapping,
                AlterDatabasePersistMetadata,
                AlterDatabasePolicyCaching,
                AlterDatabasePolicyDiagnostics,
                AlterDatabasePolicyEncoding,
                AlterDatabasePolicyExtentTagsRetention,
                AlterDatabasePolicyIngestionBatching,
                AlterDatabasePolicyManagedIdentity,
                AlterDatabasePolicyMerge,
                AlterDatabasePolicyRetention,
                AlterDatabasePolicySharding,
                AlterDatabasePolicyShardsGrouping,
                AlterDatabasePolicyStreamingIngestion,
                AlterDatabasePrettyName,
                AlterDatabaseStorageKeys,
                AlterEntityGroup,
                AlterExtentContainersAdd,
                AlterExtentContainersDrop,
                AlterExtentContainersRecycle,
                AlterExtentContainersSet,
                AlterExtentTagsFromQuery,
                AlterSqlExternalTable,
                AlterStorageExternalTable,
                AlterExternalTableDocString,
                AlterExternalTableFolder,
                AlterExternalTableMapping,
                AlterFollowerClusterConfiguration,
                AlterFollowerDatabaseAuthorizedPrincipals,
                AlterFollowerDatabaseConfiguration,
                AlterFollowerDatabaseChildEntities,
                AlterFollowerTablesPolicyCaching,
                AlterFunctionDocString,
                AlterFunctionFolder,
                AlterFunction,
                AlterMaterializedViewAutoUpdateSchema,
                AlterMaterializedViewDocString,
                AlterMaterializedViewFolder,
                AlterMaterializedViewLookback,
                AlterMaterializedView,
                AlterMaterializedViewPolicyCaching,
                AlterMaterializedViewPolicyPartitioning,
                AlterMaterializedViewPolicyRetention,
                AlterMaterializedViewPolicyRowLevelSecurity,
                AlterPoliciesOfRetention,
                AlterTablesPolicyCaching,
                AlterTablesPolicyIngestionBatching,
                AlterTablesPolicyIngestionTime,
                AlterTablesPolicyMerge,
                AlterTablesPolicyRestrictedViewAccess,
                AlterTablesPolicyRetention,
                AlterTablesPolicyRowOrder,
                AlterTableColumnStatisticsMethod,
                AlterTablePolicyAutoDelete,
                AlterTablePolicyCaching,
                AlterTablePolicyEncoding,
                AlterTablePolicyExtentTagsRetention,
                AlterTablePolicyIngestionBatching,
                AlterTablePolicyMerge,
                AlterTablePolicyRestrictedViewAccess,
                AlterTablePolicyRetention,
                AlterTablePolicyRowOrder,
                AlterTablePolicySharding,
                AlterTablePolicyStreamingIngestion,
                AlterTablePolicyUpdate,
                AlterTableRowStoreReferencesDisableBlockedKeys,
                AlterTableRowStoreReferencesDisableKey,
                AlterTableRowStoreReferencesDisableRowStore,
                AlterTableRowStoreReferencesDropBlockedKeys,
                AlterTableRowStoreReferencesDropKey,
                AlterTableRowStoreReferencesDropRowStore,
                AlterTable,
                AlterTableColumnDocStrings,
                AlterTableColumnsPolicyEncoding,
                AlterTableColumnStatistics,
                AlterTableDocString,
                AlterTableFolder,
                AlterTableIngestionMapping,
                AlterTablePolicyIngestionTime,
                AlterTablePolicyPartitioning,
                AlterTablePolicyRowLevelSecurity,
                AppendTable,
                AttachDatabaseMetadata,
                AttachDatabase,
                AttachExtentsIntoTableByContainer,
                AttachExtentsIntoTableByMetadata,
                CancelOperation,
                CancelQuery,
                CleanDatabaseExtentContainers,
                ClearRemoteClusterDatabaseSchema,
                ClearDatabaseCacheQueryResults,
                ClearDatabaseCacheQueryWeakConsistency,
                ClearDatabaseCacheStreamingIngestionSchema,
                ClearMaterializedViewData,
                ClearMaterializedViewStatistics,
                ClearTableCacheStreamingIngestionSchema,
                ClearTableData,
                CreateMergeTables,
                CreateMergeTable,
                CreateOrAlterContinuousExport,
                CreateOrAlterSqlExternalTable,
                CreateOrAlterStorageExternalTable,
                CreateOrAlterFunction,
                CreateOrAlterMaterializedView,
                CreateOrAleterWorkloadGroup,
                CreateBasicAuthUser,
                CreateDatabasePersist,
                CreateDatabaseVolatile,
                CreateDatabaseIngestionMapping,
                CreateEntityGroupCommand,
                CreateSqlExternalTable,
                CreateStorageExternalTable,
                CreateExternalTableMapping,
                CreateFunction,
                CreateRequestSupport,
                CreateRowStore,
                CreateTables,
                CreateTable,
                CreateTableBasedOnAnother,
                CreateTableIngestionMapping,
                CreateTempStorage,
                CreateMaterializedView,
                DefineTables,
                DefineTable,
                DeleteClusterPolicyCaching,
                DeleteClusterPolicyCallout,
                DeleteClusterPolicyManagedIdentity,
                DeleteClusterPolicyRequestClassification,
                DeleteClusterPolicyRowStore,
                DeleteClusterPolicySandbox,
                DeleteClusterPolicySharding,
                DeleteClusterPolicyStreamingIngestion,
                DeleteColumnPolicyCaching,
                DeleteColumnPolicyEncoding,
                DeleteDatabasePolicyCaching,
                DeleteDatabasePolicyDiagnostics,
                DeleteDatabasePolicyEncoding,
                DeleteDatabasePolicyExtentTagsRetention,
                DeleteDatabasePolicyIngestionBatching,
                DeleteDatabasePolicyManagedIdentity,
                DeleteDatabasePolicyMerge,
                DeleteDatabasePolicyRetention,
                DeleteDatabasePolicySharding,
                DeleteDatabasePolicyShardsGrouping,
                DeleteDatabasePolicyStreamingIngestion,
                DropFollowerDatabasePolicyCaching,
                DropFollowerTablesPolicyCaching,
                DeleteMaterializedViewPolicyCaching,
                DeleteMaterializedViewPolicyPartitioning,
                DeleteMaterializedViewPolicyRowLevelSecurity,
                DeletePoliciesOfRetention,
                DeleteTablePolicyAutoDelete,
                DeleteTablePolicyCaching,
                DeleteTablePolicyEncoding,
                DeleteTablePolicyExtentTagsRetention,
                DeleteTablePolicyIngestionBatching,
                DeleteTablePolicyMerge,
                DeleteTablePolicyRestrictedViewAccess,
                DeleteTablePolicyRetention,
                DeleteTablePolicyRowOrder,
                DeleteTablePolicySharding,
                DeleteTablePolicyStreamingIngestion,
                DeleteTablePolicyUpdate,
                DeleteTablePolicyIngestionTime,
                DeleteTablePolicyPartitioning,
                DeleteTablePolicyRowLevelSecurity,
                DeleteTableRecords,
                DetachDatabase,
                DisableContinuousExport,
                DisableDatabaseMaintenanceMode,
                DisablePlugin,
                DropPretendExtentsByProperties,
                DropBasicAuthUser,
                DropClusterBlockedPrincipals,
                DropClusterRole,
                DropColumn,
                DropContinuousExport,
                DropDatabaseIngestionMapping,
                DropDatabasePrettyName,
                DropDatabaseRole,
                DropEmptyExtentContainers,
                DropEntityGroup,
                DropExtentsPartitionMetadata,
                DropExtents,
                DropExtentTagsRetention,
                DropExtent,
                DropExternalTableAdmins,
                DropExternalTableMapping,
                DropExternalTable,
                DropFollowerDatabases,
                DropFollowerDatabaseAuthorizedPrincipals,
                DropFunctions,
                DropFunctionRole,
                DropFunction,
                DropMaterializedViewAdmins,
                DropMaterializedView,
                DropRowStore,
                StoredQueryResultsDrop,
                StoredQueryResultDrop,
                DropStoredQueryResultContainers,
                DropTables,
                DropTableColumns,
                DropTableIngestionMapping,
                DropTableRole,
                DropTable,
                DropTempStorage,
                DropUnusedStoredQueryResultContainers,
                DropWorkloadGroup,
                EnableContinuousExport,
                EnableDatabaseMaintenanceMode,
                EnableDisableMaterializedView,
                EnablePlugin,
                ExecuteDatabaseScript,
                ExportToSqlTable,
                ExportToExternalTable,
                ExportToStorage,
                IngestInlineIntoTable,
                IngestIntoTable,
                MergeDatabaseShardGroups,
                MergeExtentsDryrun,
                MergeExtents,
                MoveExtentsFrom,
                MoveExtentsQuery,
                PatchExtentCorruptedDatetime,
                RenameColumns,
                RenameColumn,
                RenameMaterializedView,
                RenameTables,
                RenameTable,
                ReplaceExtents,
                SetOrAppendTable,
                StoredQueryResultSetOrReplace,
                SetOrReplaceTable,
                SetAccess,
                SetClusterRole,
                SetContinuousExportCursor,
                SetDatabaseRole,
                SetExternalTableAdmins,
                SetFunctionRole,
                SetMaterializedViewAdmins,
                SetMaterializedViewConcurrency,
                SetMaterializedViewCursor,
                StoredQueryResultSet,
                SetTableRowStoreReferences,
                SetTableRole,
                SetTable,
                ShowBasicAuthUsers,
                ShowCache,
                ShowCallStacks,
                ShowCapacity,
                ShowCertificates,
                ShowClusterAdminState,
                ShowClusterBlockedPrincipals,
                ShowClusterExtentsMetadata,
                ShowClusterExtents,
                ShowClusterJournal,
                ShowClusterMonitoring,
                ShowClusterNetwork,
                ShowClusterPendingContinuousExports,
                ShowClusterPolicyCaching,
                ShowClusterPolicyCallout,
                ShowClusterPolicyCapacity,
                ShowClusterPolicyDiagnostics,
                ShowClusterPolicyIngestionBatching,
                ShowClusterPolicyManagedIdentity,
                ShowClusterPolicyMultiDatabaseAdmins,
                ShowClusterPolicyQueryWeakConsistency,
                ShowClusterPolicyRequestClassification,
                ShowClusterPolicyRowStore,
                ShowClusterPolicySandbox,
                ShowClusterPolicySharding,
                ShowClusterPolicyStreamingIngestion,
                ShowClusterPrincipals,
                ShowClusterPrincipalRoles,
                ShowClusterSandboxesStats,
                ShowClusterScaleIn,
                ShowClusterServices,
                ShowClusterStorageKeysHash,
                ShowCluster,
                ShowColumnPolicyCaching,
                ShowColumnPolicyEncoding,
                ShowCommandsAndQueries,
                ShowCommands,
                ShowCommConcurrency,
                ShowCommPools,
                ShowContinuousExports,
                ShowContinuousExportExportedArtifacts,
                ShowContinuousExportFailures,
                ShowContinuousExport,
                ShowDatabasesSchemaAsJson,
                ShowDatabasesSchema,
                ShowClusterDatabasesDataStats,
                ShowClusterDatabasesDetails,
                ShowClusterDatabasesIdentity,
                ShowDatabasesManagementGroups,
                ShowClusterDatabasesPolicies,
                ShowClusterDatabases,
                ShowDatabaseCacheQueryResults,
                ShowDatabaseDataStats,
                ShowDatabaseDetails,
                ShowDatabaseExtentsMetadata,
                ShowDatabaseExtents,
                ShowDatabaseExtentTagsStatistics,
                ShowDatabaseIdentity,
                ShowDatabasePolicies,
                ShowDatabaseCslSchema,
                ShowDatabaseExtentsPartitioningStatistics,
                ShowDatabaseIngestionMappings,
                ShowDatabaseSchemaAsCslScript,
                ShowDatabaseSchemaAsJson,
                ShowDatabaseSchema,
                DatabaseShardGroupsStatisticsShow,
                ShowDatabaseExtentContainersCleanOperations,
                ShowDatabaseJournal,
                ShowDatabasePolicyCaching,
                ShowDatabasePolicyDiagnostics,
                ShowDatabasePolicyEncoding,
                ShowDatabasePolicyExtentTagsRetention,
                ShowDatabasePolicyHardRetentionViolations,
                ShowDatabasePolicyIngestionBatching,
                ShowDatabasePolicyManagedIdentity,
                ShowDatabasePolicyMerge,
                ShowDatabasePolicyRetention,
                ShowDatabasePolicySharding,
                ShowDatabasePolicyShardsGrouping,
                ShowDatabasePolicySoftRetentionViolations,
                ShowDatabasePolicyStreamingIngestion,
                ShowDatabasePrincipals,
                ShowDatabasePrincipalRoles,
                ShowDatabasePurgeOperation,
                ShowDatabaseSchemaViolations,
                ShowDatabase,
                ShowDiagnostics,
                ShowEntityGroups,
                ShowEntityGroup,
                ShowEntitySchema,
                ShowExtentContainers,
                ShowExtentColumnStorageStats,
                ShowExtentDetails,
                ShowExternalTables,
                ShowExternalTableArtifacts,
                ShowExternalTableCslSchema,
                ShowExternalTableMappings,
                ShowExternalTableMapping,
                ShowExternalTablePrincipals,
                ShowExternalTablesPrincipalRoles,
                ShowExternalTableSchema,
                ShowExternalTable,
                ShowFabricCache,
                ShowFabricClocks,
                ShowFabricLocks,
                ShowFabric,
                ShowFeatureFlags,
                ShowFollowerDatabase,
                ShowFreshness,
                ShowFunctions,
                ShowFunctionPrincipals,
                ShowFunctionPrincipalRoles,
                ShowFunctionSchemaAsJson,
                ShowFunction,
                ShowIngestionFailures,
                ShowIngestionMappings,
                ShowJournal,
                ShowMaterializedViewsDetails,
                ShowMaterializedViews,
                ShowMaterializedViewCslSchema,
                ShowMaterializedViewDetails,
                ShowMaterializedViewDiagnostics,
                ShowMaterializedViewExtents,
                ShowMaterializedViewFailures,
                ShowMaterializedViewPolicyCaching,
                ShowMaterializedViewPolicyMerge,
                ShowMaterializedViewPolicyPartitioning,
                ShowMaterializedViewPolicyRetention,
                ShowMaterializedViewPolicyRowLevelSecurity,
                ShowMaterializedViewPrincipals,
                ShowMaterializedViewSchemaAsJson,
                ShowMaterializedViewStatistics,
                ShowMaterializedView,
                ShowMemory,
                ShowMemPools,
                ShowOperations,
                ShowOperationDetails,
                ShowPlugins,
                ShowPrincipalAccess,
                ShowPrincipalRoles,
                ShowQueries,
                ShowQueryExecution,
                ShowQueryPlan,
                ShowQueryCallTree,
                ShowRequestSupport,
                ShowRowStores,
                ShowRowStoreSeals,
                ShowRowStoreTransactions,
                ShowRowStore,
                ShowRunningQueries,
                ShowSchema,
                ShowServicePoints,
                StoredQueryResultsShow,
                StoredQueryResultShowSchema,
                ShowStreamingIngestionFailures,
                ShowStreamingIngestionStatistics,
                ShowTablesColumnStatistics,
                ShowTablesDetails,
                TablesShardGroupsStatisticsShow,
                ShowTables,
                ShowExtentCorruptedDatetime,
                ShowTableExtentsMetadata,
                ShowTableExtents,
                ShowTableStarPolicyCaching,
                ShowTableStarPolicyExtentTagsRetention,
                ShowTableStarPolicyIngestionBatching,
                ShowTableStarPolicyIngestionTime,
                ShowTableStarPolicyMerge,
                ShowTableStarPolicyPartitioning,
                ShowTableStarPolicyRestrictedViewAccess,
                ShowTableStarPolicyRetention,
                ShowTableStarPolicyRowLevelSecurity,
                ShowTableStarPolicyRowOrder,
                ShowTableStarPolicySharding,
                ShowTableStarPolicyUpdate,
                ShowTableUsageStatisticsDetails,
                ShowTableUsageStatistics,
                ShowTablePolicyAutoDelete,
                ShowTablePolicyCaching,
                ShowTablePolicyEncoding,
                ShowTablePolicyExtentTagsRetention,
                ShowTablePolicyIngestionBatching,
                ShowTablePolicyMerge,
                ShowTablePolicyPartitioning,
                ShowTablePolicyRestrictedViewAccess,
                ShowTablePolicyRetention,
                ShowTablePolicyRowOrder,
                ShowTablePolicySharding,
                ShowTablePolicyStreamingIngestion,
                ShowTablePolicyUpdate,
                ShowTableRowStoreReferences,
                ShowTableRowStoreSealInfo,
                ShowTableRowStores,
                ShowTableColumnsClassification,
                ShowTableColumnStatitics,
                ShowTableCslSchema,
                ShowTableDetails,
                ShowTableDimensions,
                ShowTableIngestionMappings,
                ShowTableIngestionMapping,
                ShowTablePolicyIngestionTime,
                ShowTablePolicyRowLevelSecurity,
                ShowTablePrincipals,
                ShowTablePrincipalRoles,
                ShowTableSchemaAsJson,
                TableShardGroupsStatisticsShow,
                TableShardGroupsShow,
                TableShardsGroupMetadataShow,
                TableShardsGroupShow,
                ShowTable,
                ShowTcpConnections,
                ShowTcpPorts,
                ShowThreadPools,
                ShowVersion,
                ShowWorkloadGroups,
                ShowWorkloadGroup,
                UndoDropTable
            };

            return commandParsers;
        }
    }
}

