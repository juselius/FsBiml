    namespace FsBiml

    module Attr =
        open Xml

        let Access = attr "Access"
        let Action = attr "Action"
        let ActionAtEvent = attr "ActionAtEvent"
        let ActionAtTimeout = attr "ActionAtTimeout"
        let AfterEvent = attr "AfterEvent"
        let AfterTimeout = attr "AfterTimeout"
        let AgeBased = attr "AgeBased"
        let AggregateFunction = attr "AggregateFunction"
        let AggregationStorage = attr "AggregationStorage"
        let AggregationUsage = attr "AggregationUsage"
        let AllMemberAggregationUsage = attr "AllMemberAggregationUsage"
        let AllowAppend = attr "AllowAppend"
        let AllowDuplicateNames = attr "AllowDuplicateNames"
        let AllowImplicitStringConversion = attr "AllowImplicitStringConversion"
        let AllTablesAndViews = attr "AllTablesAndViews"
        let AlwaysUseDefaultCodePage = attr "AlwaysUseDefaultCodePage"
        let AnnotationType = attr "AnnotationType"
        let ArchiveAttribute = attr "ArchiveAttribute"
        let AttributeHierarchyEnabled = attr "AttributeHierarchyEnabled"
        let AttributeHierarchyOptimizedState = attr "AttributeHierarchyOptimizedState"
        let AttributeHierarchyOrdered = attr "AttributeHierarchyOrdered"
        let AttributeHierarchyVisible = attr "AttributeHierarchyVisible"
        let AttributeType = attr "AttributeType"
        let AutoCreateConfigurationsType = attr "AutoCreateConfigurationsType"
        let AutoExtendFactor = attr "AutoExtendFactor"
        let AutoPassThrough = attr "AutoPassThrough"
        let BackupCompressionOption = attr "BackupCompressionOption"
        let BackupDeviceType = attr "BackupDeviceType"
        let BackupFileExtension = attr "BackupFileExtension"
        let BackupTailLog = attr "BackupTailLog"
        let BatchSize = attr "BatchSize"
        let BLOBTempStoragePath = attr "BLOBTempStoragePath"
        let BoundarySide = attr "BoundarySide"
        let BreakOnError = attr "BreakOnError"
        let BufferTempStoragePath = attr "BufferTempStoragePath"
        let BuildAction = attr "BuildAction"
        let BypassPrepare = attr "BypassPrepare"
        let BypassProxyOnLocalAddress = attr "BypassProxyOnLocalAddress"
        let CacheMode = attr "CacheMode"
        let CacheSize32 = attr "CacheSize32"
        let CacheSize64 = attr "CacheSize64"
        let CaptionIsMdx = attr "CaptionIsMdx"
        let Cardinality = attr "Cardinality"
        let CaseSensitive = attr "CaseSensitive"
        let CaseSensitiveTermExtraction = attr "CaseSensitiveTermExtraction"
        let CaseSensitiveTermLookup = attr "CaseSensitiveTermLookup"
        let CheckConstraints = attr "CheckConstraints"
        let CheckpointUsage = attr "CheckpointUsage"
        let ChunkSize = attr "ChunkSize"
        let CloneIndexes = attr "CloneIndexes"
        let CloneKeys = attr "CloneKeys"
        let CloneStaticSources = attr "CloneStaticSources"
        let Clustered = attr "Clustered"
        let CodePage = attr "CodePage"
        let Column = attr "Column"
        let ColumnType = attr "ColumnType"
        let CompactLargeObjects = attr "CompactLargeObjects"
        let CompressionType = attr "CompressionType"
        let ContainsId = attr "ContainsId"
        let CopyAllDefaults = attr "CopyAllDefaults"
        let CopyAllDriObjects = attr "CopyAllDriObjects"
        let CopyAllLogins = attr "CopyAllLogins"
        let CopyAllObjects = attr "CopyAllObjects"
        let CopyAllPartitionFunctions = attr "CopyAllPartitionFunctions"
        let CopyAllPartitionSchemes = attr "CopyAllPartitionSchemes"
        let CopyAllRules = attr "CopyAllRules"
        let CopyAllSchemas = attr "CopyAllSchemas"
        let CopyAllSqlAssemblies = attr "CopyAllSqlAssemblies"
        let CopyAllStoredProcedures = attr "CopyAllStoredProcedures"
        let CopyAllTables = attr "CopyAllTables"
        let CopyAllUserDefinedAggregates = attr "CopyAllUserDefinedAggregates"
        let CopyAllUserDefinedDataTypes = attr "CopyAllUserDefinedDataTypes"
        let CopyAllUserDefinedFunctions = attr "CopyAllUserDefinedFunctions"
        let CopyAllUserDefinedTypes = attr "CopyAllUserDefinedTypes"
        let CopyAllUsers = attr "CopyAllUsers"
        let CopyAllViews = attr "CopyAllViews"
        let CopyAllXmlSchemaCollections = attr "CopyAllXmlSchemaCollections"
        let CopyData = attr "CopyData"
        let CopyDatabaseRoles = attr "CopyDatabaseRoles"
        let CopyDatabaseUsers = attr "CopyDatabaseUsers"
        let CopyForeignKeys = attr "CopyForeignKeys"
        let CopyFullTextIndexes = attr "CopyFullTextIndexes"
        let CopyIndexes = attr "CopyIndexes"
        let CopyObjectLevelPermissions = attr "CopyObjectLevelPermissions"
        let CopyPrimaryKeys = attr "CopyPrimaryKeys"
        let CopyReferenceTable = attr "CopyReferenceTable"
        let CopySchema = attr "CopySchema"
        let CopySids = attr "CopySids"
        let CopySqlServerLogins = attr "CopySqlServerLogins"
        let CopyTriggers = attr "CopyTriggers"
        let CountDistinctScale = attr "CountDistinctScale"
        let CreatePackageConfiguration = attr "CreatePackageConfiguration"
        let CreateSubfolder = attr "CreateSubfolder"
        let CurrentStorageMode = attr "CurrentStorageMode"
        let DataAggregation = attr "DataAggregation"
        let DatabaseName = attr "DatabaseName"
        let DatabaseSizeLimit = attr "DatabaseSizeLimit"
        let DataFileOverWritable = attr "DataFileOverWritable"
        let DataFormat = attr "DataFormat"
        let DataMimeType = attr "DataMimeType"
        let DataType = attr "DataType"
        let DataTypeCodeOverride = attr "DataTypeCodeOverride"
        let Default = attr "Default"
        let DefaultBufferMaxRows = attr "DefaultBufferMaxRows"
        let DefaultBufferSize = attr "DefaultBufferSize"
        let DelayValidation = attr "DelayValidation"
        let DeleteOutputOnPathDetached = attr "DeleteOutputOnPathDetached"
        let Delimiters = attr "Delimiters"
        let DestinationOverwrite = attr "DestinationOverwrite"
        let DestinationTranslateChar = attr "DestinationTranslateChar"
        let DiffAlgorithm = attr "DiffAlgorithm"
        let DimensionType = attr "DimensionType"
        let Direction = attr "Direction"
        let Disabled = attr "Disabled"
        let DisableEventHandlers = attr "DisableEventHandlers"
        let DrillThroughAccess = attr "DrillThroughAccess"
        let DropExisting = attr "DropExisting"
        let DropExistingIndex = attr "DropExistingIndex"
        let DropObjectsFirst = attr "DropObjectsFirst"
        let EliminateDuplicates = attr "EliminateDuplicates"
        let EmitMergePackage = attr "EmitMergePackage"
        let EnableCheckOption = attr "EnableCheckOption"
        let Enabled = attr "Enabled"
        let EnableEncryption = attr "EnableEncryption"
        let EnableInferredMember = attr "EnableInferredMember"
        let EnableJobsAtDestination = attr "EnableJobsAtDestination"
        let EnableSchemaBinding = attr "EnableSchemaBinding"
        let EnableSsl = attr "EnableSsl"
        let EnableViewMetadata = attr "EnableViewMetadata"
        let EncryptionAlgorithm = attr "EncryptionAlgorithm"
        let EngineThreads = attr "EngineThreads"
        let EntryPoint = attr "EntryPoint"
        let EnumerationMode = attr "EnumerationMode"
        let EnumerationType = attr "EnumerationType"
        let ErrorIfMessageTimeOut = attr "ErrorIfMessageTimeOut"
        let ErrorRowDisposition = attr "ErrorRowDisposition"
        let EstimatedCount = attr "EstimatedCount"
        let EstimatedRows = attr "EstimatedRows"
        let EvaluateAsExpression = attr "EvaluateAsExpression"
        let EvaluationOperation = attr "EvaluationOperation"
        let EvaluationValue = attr "EvaluationValue"
        let ExclusionGroup = attr "ExclusionGroup"
        let ExecuteOutOfProcess = attr "ExecuteOutOfProcess"
        let Exhaustive = attr "Exhaustive"
        let ExistingBackupsAction = attr "ExistingBackupsAction"
        let ExistingData = attr "ExistingData"
        let FailOnDifference = attr "FailOnDifference"
        let FailOnFixedAttributeChange = attr "FailOnFixedAttributeChange"
        let FailOnTimeout = attr "FailOnTimeout"
        let FailOnValidationFail = attr "FailOnValidationFail"
        let FailPackageOnFailure = attr "FailPackageOnFailure"
        let FailParentOnFailure = attr "FailParentOnFailure"
        let FailTaskIfReturnCodeIsNotSuccessValue = attr "FailTaskIfReturnCodeIsNotSuccessValue"
        let FastParse = attr "FastParse"
        let FDStrengthThreshold = attr "FDStrengthThreshold"
        let FieldTerminator = attr "FieldTerminator"
        let FileExtension = attr "FileExtension"
        let FileTypeSelected = attr "FileTypeSelected"
        let FileUsageType = attr "FileUsageType"
        let FillFactor = attr "FillFactor"
        let FireTriggers = attr "FireTriggers"
        let FirstRow = attr "FirstRow"
        let FlatFileType = attr "FlatFileType"
        let ForcedExecutionValue = attr "ForcedExecutionValue"
        let ForcedExecutionValueDataType = attr "ForcedExecutionValueDataType"
        let ForceExecutionResult = attr "ForceExecutionResult"
        let ForceExecutionValue = attr "ForceExecutionValue"
        let ForceRebuildInterval = attr "ForceRebuildInterval"
        let ForceTruncate = attr "ForceTruncate"
        let ForeignKeyConstraintMode = attr "ForeignKeyConstraintMode"
        let FormatString = attr "FormatString"
        let FreeSpacePercentLimit = attr "FreeSpacePercentLimit"
        let FrequentValueThreshold = attr "FrequentValueThreshold"
        let FullControl = attr "FullControl"
        let GenerateScriptsInUnicode = attr "GenerateScriptsInUnicode"
        let GroupByKeyScale = attr "GroupByKeyScale"
        let GroupingBehavior = attr "GroupingBehavior"
        let HasSideEffects = attr "HasSideEffects"
        let HeaderRowDelimiter = attr "HeaderRowDelimiter"
        let HiddenAttribute = attr "HiddenAttribute"
        let HideMemberIf = attr "HideMemberIf"
        let HierarchyUniqueNameStyle = attr "HierarchyUniqueNameStyle"
        let IdentityIncrement = attr "IdentityIncrement"
        let IdentitySeed = attr "IdentitySeed"
        let IfObjectExists = attr "IfObjectExists"
        let IgnoreDatabasesInNotOnlineState = attr "IgnoreDatabasesInNotOnlineState"
        let IgnoreDupKey = attr "IgnoreDupKey"
        let IgnoreLeadingSpaces = attr "IgnoreLeadingSpaces"
        let IgnoreTrailingSpaces = attr "IgnoreTrailingSpaces"
        let IgnoreUnrelatedDimensions = attr "IgnoreUnrelatedDimensions"
        let IncludeDependentObjects = attr "IncludeDependentObjects"
        let IncludeExtendedProperties = attr "IncludeExtendedProperties"
        let IncludeFirstLevelSubfolders = attr "IncludeFirstLevelSubfolders"
        let IncludeInDebugDump = attr "IncludeInDebugDump"
        let IncludeIndexes = attr "IncludeIndexes"
        let InclusionStrengthThreshold = attr "InclusionStrengthThreshold"
        let InclusionThresholdSetting = attr "InclusionThresholdSetting"
        let IncomingRowChangeType = attr "IncomingRowChangeType"
        let Increment = attr "Increment"
        let Inherit = attr "Inherit"
        let InnerElementType = attr "InnerElementType"
        let InputColumnUsageType = attr "InputColumnUsageType"
        let InputKeyColumnName = attr "InputKeyColumnName"
        let InvalidXmlCharacterProcessing = attr "InvalidXmlCharacterProcessing"
        let InvalidXMLCharacterProcessing = attr "InvalidXMLCharacterProcessing"
        let Invocation = attr "Invocation"
        let IsAggregatable = attr "IsAggregatable"
        let IsArray = attr "IsArray"
        let IsEnabled = attr "IsEnabled"
        let IsEntryPoint = attr "IsEntryPoint"
        let IsErrorOutput = attr "IsErrorOutput"
        let IsNullable = attr "IsNullable"
        let IsolationLevel = attr "IsolationLevel"
        let IsOutput = attr "IsOutput"
        let IsReadOnly = attr "IsReadOnly"
        let IsRequired = attr "IsRequired"
        let IsSensitive = attr "IsSensitive"
        let IsSorted = attr "IsSorted"
        let IsStoredProcedure = attr "IsStoredProcedure"
        let IsSynchronous = attr "IsSynchronous"
        let IsTransferTypeAscii = attr "IsTransferTypeAscii"
        let IsUnicode = attr "IsUnicode"
        let IsUsed = attr "IsUsed"
        let KeepIdentity = attr "KeepIdentity"
        let KeepNulls = attr "KeepNulls"
        let KeepOnline = attr "KeepOnline"
        let KeyDuplicate = attr "KeyDuplicate"
        let KeyErrorAction = attr "KeyErrorAction"
        let KeyErrorLimit = attr "KeyErrorLimit"
        let KeyErrorLimitAction = attr "KeyErrorLimitAction"
        let KeyNotFound = attr "KeyNotFound"
        let KeyStrengthThreshold = attr "KeyStrengthThreshold"
        let Language = attr "Language"
        let LastRow = attr "LastRow"
        let LateArriving = attr "LateArriving"
        let Latency = attr "Latency"
        let Length = attr "Length"
        let LocaleId = attr "LocaleId"
        let LogicalType = attr "LogicalType"
        let LookupProviderFactory = attr "LookupProviderFactory"
        let MatchIndexOptions = attr "MatchIndexOptions"
        let MatchType = attr "MatchType"
        let Materialized = attr "Materialized"
        let MaxActiveConnections = attr "MaxActiveConnections"
        let MaxBuffersPerInput = attr "MaxBuffersPerInput"
        let MaxConcurrentExecutables = attr "MaxConcurrentExecutables"
        let MaxErrorCount = attr "MaxErrorCount"
        let MaxErrors = attr "MaxErrors"
        let MaximumInsertCommitSize = attr "MaximumInsertCommitSize"
        let MaximumRows = attr "MaximumRows"
        let MaximumThreads = attr "MaximumThreads"
        let MaxMemoryUsage = attr "MaxMemoryUsage"
        let MaxNumberOfPatterns = attr "MaxNumberOfPatterns"
        let MaxNumberOfViolations = attr "MaxNumberOfViolations"
        let MaxOutputMatchesPerInput = attr "MaxOutputMatchesPerInput"
        let MaxParallelTasks = attr "MaxParallelTasks"
        let MeasureFormat = attr "MeasureFormat"
        let MemberKeysUnique = attr "MemberKeysUnique"
        let MemberNamesUnique = attr "MemberNamesUnique"
        let MemberNameUnique = attr "MemberNameUnique"
        let MemberUniqueNameStyle = attr "MemberUniqueNameStyle"
        let MinSimilarity = attr "MinSimilarity"
        let Namespace = attr "Namespace"
        let NoMatchBehavior = attr "NoMatchBehavior"
        let NullClonedColumns = attr "NullClonedColumns"
        let NullKeyConvertedToUnknown = attr "NullKeyConvertedToUnknown"
        let NullKeyNotAllowed = attr "NullKeyNotAllowed"
        let NullProcessing = attr "NullProcessing"
        let NumberOfEvents = attr "NumberOfEvents"
        let NumberOfRows = attr "NumberOfRows"
        let Numerals = attr "Numerals"
        let OlderThanTimeUnits = attr "OlderThanTimeUnits"
        let OlderThanTimeUnitType = attr "OlderThanTimeUnitType"
        let Online = attr "Online"
        let OnlineMode = attr "OnlineMode"
        let OptimizedState = attr "OptimizedState"
        let Optionality = attr "Optionality"
        let OrderBy = attr "OrderBy"
        let OutputKeyColumnName = attr "OutputKeyColumnName"
        let OutputType = attr "OutputType"
        let Overwrite = attr "Overwrite"
        let OverwriteDestination = attr "OverwriteDestination"
        let OverwriteWsdlFile = attr "OverwriteWsdlFile"
        let PadIndex = attr "PadIndex"
        let PartitionType = attr "PartitionType"
        let PassThrough = attr "PassThrough"
        let PercentageDataCoverageDesired = attr "PercentageDataCoverageDesired"
        let PercentageOfRows = attr "PercentageOfRows"
        let PipelineVersion = attr "PipelineVersion"
        let PivotKeyValueColumnDataType = attr "PivotKeyValueColumnDataType"
        let PivotKeyValueColumnLength = attr "PivotKeyValueColumnLength"
        let PivotKeyValueColumnName = attr "PivotKeyValueColumnName"
        let PivotKeyValueColumnPrecision = attr "PivotKeyValueColumnPrecision"
        let PivotKeyValueColumnScale = attr "PivotKeyValueColumnScale"
        let Precision = attr "Precision"
        let Priority = attr "Priority"
        let PriorityClass = attr "PriorityClass"
        let Process = attr "Process"
        let ProcessAffectedObjects = attr "ProcessAffectedObjects"
        let ProcessingMode = attr "ProcessingMode"
        let ProcessingOrder = attr "ProcessingOrder"
        let ProcessingPriority = attr "ProcessingPriority"
        let ProcessSubfolders = attr "ProcessSubfolders"
        let ProtectionLevel = attr "ProtectionLevel"
        let Provider = attr "Provider"
        let PutResultInOneNode = attr "PutResultInOneNode"
        let ReadDefinition = attr "ReadDefinition"
        let ReadOnly = attr "ReadOnly"
        let ReadOnlyAttribute = attr "ReadOnlyAttribute"
        let ReattachSourceDatabase = attr "ReattachSourceDatabase"
        let ReceiveMessageTimeOut = attr "ReceiveMessageTimeOut"
        let ReindexWithOriginalAmount = attr "ReindexWithOriginalAmount"
        let RelativePath = attr "RelativePath"
        let RemoveBackupRestoreHistory = attr "RemoveBackupRestoreHistory"
        let RemoveDBMaintenanceHistory = attr "RemoveDBMaintenanceHistory"
        let RemoveFromQueue = attr "RemoveFromQueue"
        let RemoveSqlAgentHistory = attr "RemoveSqlAgentHistory"
        let ReplaceExisting = attr "ReplaceExisting"
        let Replicate = attr "Replicate"
        let RequireFullFileName = attr "RequireFullFileName"
        let ResultSet = attr "ResultSet"
        let RetainDays = attr "RetainDays"
        let RetainNulls = attr "RetainNulls"
        let RetainSameConnection = attr "RetainSameConnection"
        let Retries = attr "Retries"
        let RetrieveFileNameFormat = attr "RetrieveFileNameFormat"
        let ReturnFreedSpaceToDB = attr "ReturnFreedSpaceToDB"
        let RowTerminator = attr "RowTerminator"
        let RunInOptimizedMode = attr "RunInOptimizedMode"
        let SamplingSeed = attr "SamplingSeed"
        let SaveCheckpoints = attr "SaveCheckpoints"
        let SaveOperationResult = attr "SaveOperationResult"
        let Scale = attr "Scale"
        let ScdType = attr "ScdType"
        let ScoreOutputColumn = attr "ScoreOutputColumn"
        let ScoreType = attr "ScoreType"
        let ScriptCacheProcessingMode = attr "ScriptCacheProcessingMode"
        let ScriptErrorHandlingMode = attr "ScriptErrorHandlingMode"
        let ScriptLanguage = attr "ScriptLanguage"
        let Seed = attr "Seed"
        let ServerPort = attr "ServerPort"
        let ServerVersion = attr "ServerVersion"
        let SilenceInterval = attr "SilenceInterval"
        let SilenceOverrideInterval = attr "SilenceOverrideInterval"
        let SimilarityScoreColumnName = attr "SimilarityScoreColumnName"
        let SingleFilegroup = attr "SingleFilegroup"
        let SkipUnsupported = attr "SkipUnsupported"
        let SortInTempdb = attr "SortInTempdb"
        let SortInTempDB = attr "SortInTempDB"
        let SortKeyPosition = attr "SortKeyPosition"
        let SortOrder = attr "SortOrder"
        let SourceTranslateChar = attr "SourceTranslateChar"
        let SsasDataType = attr "SsasDataType"
        let State = attr "State"
        let StatusGraphic = attr "StatusGraphic"
        let StopOnOperationFailure = attr "StopOnOperationFailure"
        let StorageMode = attr "StorageMode"
        let StringCompareType = attr "StringCompareType"
        let SuccessValue = attr "SuccessValue"
        let SupersetColumnsKeyThreshold = attr "SupersetColumnsKeyThreshold"
        let SupersetColumnsKeyThresholdSetting = attr "SupersetColumnsKeyThresholdSetting"
        let SupportsExpression = attr "SupportsExpression"
        let SuppressConfigurationWarnings = attr "SuppressConfigurationWarnings"
        let Symbols = attr "Symbols"
        let SystemAttribute = attr "SystemAttribute"
        let TableLock = attr "TableLock"
        let TakeDatabaseOffline = attr "TakeDatabaseOffline"
        let TargetType = attr "TargetType"
        let TermFrequencyThreshold = attr "TermFrequencyThreshold"
        let TerminateProcessAfterTimeout = attr "TerminateProcessAfterTimeout"
        let TermMaxLength = attr "TermMaxLength"
        let TermOutputColumn = attr "TermOutputColumn"
        let TermType = attr "TermType"
        let TextQualified = attr "TextQualified"
        let ThresholdSetting = attr "ThresholdSetting"
        let Timeout = attr "Timeout"
        let TransactionMode = attr "TransactionMode"
        let TreatNullsAsEqual = attr "TreatNullsAsEqual"
        let TrendGraphic = attr "TrendGraphic"
        let Trimming = attr "Trimming"
        let TruncationRowDisposition = attr "TruncationRowDisposition"
        let Type = attr "Type"
        let Unique = attr "Unique"
        let UnknownMember = attr "UnknownMember"
        let UpdateSampleValue = attr "UpdateSampleValue"
        let UpdateScanType = attr "UpdateScanType"
        let UpdateType = attr "UpdateType"
        let Usage = attr "Usage"
        let UsageType = attr "UsageType"
        let Use2000Format = attr "Use2000Format"
        let UseBinaryFormat = attr "UseBinaryFormat"
        let UseCollation = attr "UseCollation"
        let UseEncryption = attr "UseEncryption"
        let UseFastLoadIfAvailable = attr "UseFastLoadIfAvailable"
        let UsePassiveMode = attr "UsePassiveMode"
        let UserName = attr "UserName"
        let UsesDispositions = attr "UsesDispositions"
        let UseSingleTransaction = attr "UseSingleTransaction"
        let UseWindowsAuthentication = attr "UseWindowsAuthentication"
        let ValidateExternalMetadata = attr "ValidateExternalMetadata"
        let ValidationType = attr "ValidationType"
        let ValueDistributionOption = attr "ValueDistributionOption"
        let VerifyIntegrity = attr "VerifyIntegrity"
        let Version = attr "Version"
        let ViewType = attr "ViewType"
        let Visible = attr "Visible"
        let VisualTotals = attr "VisualTotals"
        let VstaMajorVersion = attr "VstaMajorVersion"
        let VstaMinorVersion = attr "VstaMinorVersion"
        let WarmCaches = attr "WarmCaches"
        let WindowStyle = attr "WindowStyle"
        let WithGrantOption = attr "WithGrantOption"
        let WritebackTable = attr "WritebackTable"
        let WriteByteOrderMark = attr "WriteByteOrderMark"
        let WriteOption = attr "WriteOption"
        let XPathOperation = attr "XPathOperation"
