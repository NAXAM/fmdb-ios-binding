using System;
using FMDB;
using Foundation;
using ObjCRuntime;

namespace FMDB
{
    // @interface FMResultSet : NSObject
    [BaseType(typeof(NSObject))]
    interface FMResultSet
    {
        // @property (retain, nonatomic) FMDatabase * _Nullable parentDB;
        [NullAllowed, Export("parentDB", ArgumentSemantic.Retain)]
        FMDatabase ParentDB { get; set; }

        // @property (retain, atomic) NSString * _Nullable query;
        [NullAllowed, Export("query", ArgumentSemantic.Retain)]
        string Query { get; set; }

        // @property (readonly) NSMutableDictionary * _Nonnull columnNameToIndexMap;
        [Export("columnNameToIndexMap")]
        NSMutableDictionary ColumnNameToIndexMap { get; }

        // @property (retain, atomic) FMStatement * _Nullable statement;
        [NullAllowed, Export("statement", ArgumentSemantic.Retain)]
        FMStatement Statement { get; set; }

        // +(instancetype _Nonnull)resultSetWithStatement:(FMStatement * _Nonnull)statement usingParentDatabase:(FMDatabase * _Nonnull)aDB;
        [Static]
        [Export("resultSetWithStatement:usingParentDatabase:")]
        FMResultSet ResultSetWithStatement(FMStatement statement, FMDatabase aDB);

        // -(void)close;
        [Export("close")]
        void Close();

        // -(BOOL)next;
        [Export("next")]
         bool Next();

        // -(BOOL)nextWithError:(NSError * _Nullable * _Nullable)outErr;
        [Export("nextWithError:")]
        bool NextWithError([NullAllowed] out NSError outErr);

        // -(BOOL)hasAnotherRow;
        [Export("hasAnotherRow")]
        bool HasAnotherRow { get; }

        // @property (readonly, nonatomic) int columnCount;
        [Export("columnCount")]
        int ColumnCount { get; }

        // -(int)columnIndexForName:(NSString * _Nonnull)columnName;
        [Export("columnIndexForName:")]
        int ColumnIndexForName(string columnName);

        // -(NSString * _Nullable)columnNameForIndex:(int)columnIdx;
        [Export("columnNameForIndex:")]
        [return: NullAllowed]
        string ColumnNameForIndex(int columnIdx);

        // -(int)intForColumn:(NSString * _Nonnull)columnName;
        [Export("intForColumn:")]
        int IntForColumn(string columnName);

        // -(int)intForColumnIndex:(int)columnIdx;
        [Export("intForColumnIndex:")]
        int IntForColumnIndex(int columnIdx);

        // -(long)longForColumn:(NSString * _Nonnull)columnName;
        [Export("longForColumn:")]
        nint LongForColumn(string columnName);

        // -(long)longForColumnIndex:(int)columnIdx;
        [Export("longForColumnIndex:")]
        nint LongForColumnIndex(int columnIdx);

        // -(long long)longLongIntForColumn:(NSString * _Nonnull)columnName;
        [Export("longLongIntForColumn:")]
        long LongLongIntForColumn(string columnName);

        // -(long long)longLongIntForColumnIndex:(int)columnIdx;
        [Export("longLongIntForColumnIndex:")]
        long LongLongIntForColumnIndex(int columnIdx);

        // -(unsigned long long)unsignedLongLongIntForColumn:(NSString * _Nonnull)columnName;
        [Export("unsignedLongLongIntForColumn:")]
        ulong UnsignedLongLongIntForColumn(string columnName);

        // -(unsigned long long)unsignedLongLongIntForColumnIndex:(int)columnIdx;
        [Export("unsignedLongLongIntForColumnIndex:")]
        ulong UnsignedLongLongIntForColumnIndex(int columnIdx);

        // -(BOOL)boolForColumn:(NSString * _Nonnull)columnName;
        [Export("boolForColumn:")]
        bool BoolForColumn(string columnName);

        // -(BOOL)boolForColumnIndex:(int)columnIdx;
        [Export("boolForColumnIndex:")]
        bool BoolForColumnIndex(int columnIdx);

        // -(double)doubleForColumn:(NSString * _Nonnull)columnName;
        [Export("doubleForColumn:")]
        double DoubleForColumn(string columnName);

        // -(double)doubleForColumnIndex:(int)columnIdx;
        [Export("doubleForColumnIndex:")]
        double DoubleForColumnIndex(int columnIdx);

        // -(NSString * _Nullable)stringForColumn:(NSString * _Nonnull)columnName;
        [Export("stringForColumn:")]
        [return: NullAllowed]
        string StringForColumn(string columnName);

        // -(NSString * _Nullable)stringForColumnIndex:(int)columnIdx;
        [Export("stringForColumnIndex:")]
        [return: NullAllowed]
        string StringForColumnIndex(int columnIdx);

        // -(NSDate * _Nullable)dateForColumn:(NSString * _Nonnull)columnName;
        [Export("dateForColumn:")]
        [return: NullAllowed]
        NSDate DateForColumn(string columnName);

        // -(NSDate * _Nullable)dateForColumnIndex:(int)columnIdx;
        [Export("dateForColumnIndex:")]
        [return: NullAllowed]
        NSDate DateForColumnIndex(int columnIdx);

        // -(NSData * _Nullable)dataForColumn:(NSString * _Nonnull)columnName;
        [Export("dataForColumn:")]
        [return: NullAllowed]
        NSData DataForColumn(string columnName);

        // -(NSData * _Nullable)dataForColumnIndex:(int)columnIdx;
        [Export("dataForColumnIndex:")]
        [return: NullAllowed]
        NSData DataForColumnIndex(int columnIdx);

        // -(const unsigned char * _Nullable)UTF8StringForColumn:(NSString * _Nonnull)columnName;
        [Export("UTF8StringForColumn:")]
        [return: NullAllowed]
        unsafe IntPtr UTF8StringForColumn(string columnName);

        // -(const unsigned char * _Nullable)UTF8StringForColumnName:(NSString * _Nonnull)columnName __attribute__((deprecated("Use UTF8StringForColumn instead")));
        [Export("UTF8StringForColumnName:")]
        [return: NullAllowed]
        unsafe IntPtr UTF8StringForColumnName(string columnName);

        // -(const unsigned char * _Nullable)UTF8StringForColumnIndex:(int)columnIdx;
        [Export("UTF8StringForColumnIndex:")]
        [return: NullAllowed]
        unsafe IntPtr UTF8StringForColumnIndex(int columnIdx);

        // -(id _Nullable)objectForColumn:(NSString * _Nonnull)columnName;
        [Export("objectForColumn:")]
        [return: NullAllowed]
        NSObject ObjectForColumn(string columnName);

        // -(id _Nullable)objectForColumnName:(NSString * _Nonnull)columnName __attribute__((deprecated("Use objectForColumn instead")));
        [Export("objectForColumnName:")]
        [return: NullAllowed]
        NSObject ObjectForColumnName(string columnName);

        // -(id _Nullable)objectForColumnIndex:(int)columnIdx;
        [Export("objectForColumnIndex:")]
        [return: NullAllowed]
        NSObject ObjectForColumnIndex(int columnIdx);

        // -(id _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)columnName;
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        NSObject ObjectForKeyedSubscript(string columnName);

        // -(id _Nullable)objectAtIndexedSubscript:(int)columnIdx;
        [Export("objectAtIndexedSubscript:")]
        [return: NullAllowed]
        NSObject ObjectAtIndexedSubscript(int columnIdx);

        // -(NSData * _Nullable)dataNoCopyForColumn:(NSString * _Nonnull)columnName __attribute__((ns_returns_not_retained));
        [Export("dataNoCopyForColumn:")]
        [return: NullAllowed]
        NSData DataNoCopyForColumn(string columnName);

        // -(NSData * _Nullable)dataNoCopyForColumnIndex:(int)columnIdx __attribute__((ns_returns_not_retained));
        [Export("dataNoCopyForColumnIndex:")]
        [return: NullAllowed]
        NSData DataNoCopyForColumnIndex(int columnIdx);

        // -(BOOL)columnIndexIsNull:(int)columnIdx;
        [Export("columnIndexIsNull:")]
        bool ColumnIndexIsNull(int columnIdx);

        // -(BOOL)columnIsNull:(NSString * _Nonnull)columnName;
        [Export("columnIsNull:")]
        bool ColumnIsNull(string columnName);

        // @property (readonly, nonatomic) NSDictionary * _Nullable resultDictionary;
        [NullAllowed, Export("resultDictionary")]
        NSDictionary ResultDictionary { get; }

        // -(NSDictionary * _Nullable)resultDict __attribute__((deprecated("Use resultDictionary instead")));
        [NullAllowed, Export("resultDict")]
        NSDictionary ResultDict { get; }

        // -(void)kvcMagic:(id _Nonnull)object;
        [Export("kvcMagic:")]
        void KvcMagic(NSObject @object);
    }

    // @interface FMDatabasePool : NSObject
    [BaseType(typeof(NSObject))]
    interface FMDatabasePool
    {
        // @property (copy, atomic) NSString * _Nullable path;
        [NullAllowed, Export("path")]
        string Path { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @property (assign, atomic) id _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, atomic) NSUInteger maximumNumberOfDatabasesToCreate;
        [Export("maximumNumberOfDatabasesToCreate")]
        nuint MaximumNumberOfDatabasesToCreate { get; set; }

        // @property (readonly, atomic) int openFlags;
        [Export("openFlags")]
        int OpenFlags { get; }

        // @property (copy, atomic) NSString * _Nullable vfsName;
        [NullAllowed, Export("vfsName")]
        string VfsName { get; set; }

        // +(instancetype _Nonnull)databasePoolWithPath:(NSString * _Nullable)aPath;
        [Static]
        [Export("databasePoolWithPath:")]
        FMDatabasePool DatabasePoolWithPath([NullAllowed] string aPath);

        // +(instancetype _Nonnull)databasePoolWithURL:(NSURL * _Nullable)url;
        [Static]
        [Export("databasePoolWithURL:")]
        FMDatabasePool DatabasePoolWithURL([NullAllowed] NSUrl url);

        // +(instancetype _Nonnull)databasePoolWithPath:(NSString * _Nullable)aPath flags:(int)openFlags;
        [Static]
        [Export("databasePoolWithPath:flags:")]
        FMDatabasePool DatabasePoolWithPath([NullAllowed] string aPath, int openFlags);

        // +(instancetype _Nonnull)databasePoolWithURL:(NSURL * _Nullable)url flags:(int)openFlags;
        [Static]
        [Export("databasePoolWithURL:flags:")]
        FMDatabasePool DatabasePoolWithURL([NullAllowed] NSUrl url, int openFlags);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)aPath;
        [Export("initWithPath:")]
        IntPtr Constructor([NullAllowed] string aPath);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url;
        [Export("initWithURL:")]
        IntPtr Constructor([NullAllowed] NSUrl url);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)aPath flags:(int)openFlags;
        [Export("initWithPath:flags:")]
        IntPtr Constructor([NullAllowed] string aPath, int openFlags);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url flags:(int)openFlags;
        [Export("initWithURL:flags:")]
        IntPtr Constructor([NullAllowed] NSUrl url, int openFlags);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)aPath flags:(int)openFlags vfs:(NSString * _Nullable)vfsName;
        [Export("initWithPath:flags:vfs:")]
        IntPtr Constructor([NullAllowed] string aPath, int openFlags, [NullAllowed] string vfsName);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url flags:(int)openFlags vfs:(NSString * _Nullable)vfsName;
        [Export("initWithURL:flags:vfs:")]
        IntPtr Constructor([NullAllowed] NSUrl url, int openFlags, [NullAllowed] string vfsName);

        // +(Class _Nonnull)databaseClass;
        [Static]
        [Export("databaseClass")]
        Class DatabaseClass { get; }

        // @property (readonly, nonatomic) NSUInteger countOfCheckedInDatabases;
        [Export("countOfCheckedInDatabases")]
        nuint CountOfCheckedInDatabases { get; }

        // @property (readonly, nonatomic) NSUInteger countOfCheckedOutDatabases;
        [Export("countOfCheckedOutDatabases")]
        nuint CountOfCheckedOutDatabases { get; }

        // @property (readonly, nonatomic) NSUInteger countOfOpenDatabases;
        [Export("countOfOpenDatabases")]
        nuint CountOfOpenDatabases { get; }

        // -(void)releaseAllDatabases;
        [Export("releaseAllDatabases")]
        void ReleaseAllDatabases();

        // -(void)inDatabase:(void (^ _Nonnull)(FMDatabase * _Nonnull))block;
        [Export("inDatabase:")]
        void InDatabase(Action<FMDatabase> block);

        // -(void)inTransaction:(void (^ _Nonnull)(FMDatabase * _Nonnull, BOOL * _Nonnull))block;
        [Export("inTransaction:")]
        unsafe void InTransaction(Action<FMDatabase, IntPtr> block);

        // -(void)inDeferredTransaction:(void (^ _Nonnull)(FMDatabase * _Nonnull, BOOL * _Nonnull))block;
        [Export("inDeferredTransaction:")]
        unsafe void InDeferredTransaction(Action<FMDatabase, IntPtr> block);

        // -(NSError * _Nullable)inSavePoint:(void (^ _Nonnull)(FMDatabase * _Nonnull, BOOL * _Nonnull))block;
        [Export("inSavePoint:")]
        [return: NullAllowed]
        unsafe NSError InSavePoint(Action<FMDatabase, IntPtr> block);
    }

    // @interface FMDatabasePoolDelegate (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_FMDatabasePoolDelegate
    {
        // -(BOOL)databasePool:(FMDatabasePool * _Nonnull)pool shouldAddDatabaseToPool:(FMDatabase * _Nonnull)database;
        [Export("databasePool:shouldAddDatabaseToPool:")]
        bool ShouldAddDatabaseToPool(FMDatabasePool pool, FMDatabase database);

        // -(void)databasePool:(FMDatabasePool * _Nonnull)pool didAddDatabase:(FMDatabase * _Nonnull)database;
        [Export("databasePool:didAddDatabase:")]
        void DidAddDatabase(FMDatabasePool pool, FMDatabase database);
    }

    // typedef int (^FMDBExecuteStatementsCallbackBlock)(NSDictionary * _Nonnull);
    delegate int FMDBExecuteStatementsCallbackBlock(NSDictionary arg0);

    // @interface FMDatabase : NSObject
    [BaseType(typeof(NSObject))]
    interface FMDatabase
    {
        // @property (assign, atomic) BOOL traceExecution;
        [Export("traceExecution")]
        bool TraceExecution { get; set; }

        // @property (assign, atomic) BOOL checkedOut;
        [Export("checkedOut")]
        bool CheckedOut { get; set; }

        // @property (assign, atomic) BOOL crashOnErrors;
        [Export("crashOnErrors")]
        bool CrashOnErrors { get; set; }

        // @property (assign, atomic) BOOL logsErrors;
        [Export("logsErrors")]
        bool LogsErrors { get; set; }

        // @property (retain, atomic) NSMutableDictionary * _Nullable cachedStatements;
        [NullAllowed, Export("cachedStatements", ArgumentSemantic.Retain)]
        NSMutableDictionary CachedStatements { get; set; }

        // +(instancetype _Nonnull)databaseWithPath:(NSString * _Nullable)inPath;
        [Static]
        [Export("databaseWithPath:")]
        FMDatabase DatabaseWithPath([NullAllowed] string inPath);

        // +(instancetype _Nonnull)databaseWithURL:(NSURL * _Nullable)url;
        [Static]
        [Export("databaseWithURL:")]
        FMDatabase DatabaseWithURL([NullAllowed] NSUrl url);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)path;
        [Export("initWithPath:")]
        IntPtr Constructor([NullAllowed] string path);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url;
        [Export("initWithURL:")]
        IntPtr Constructor([NullAllowed] NSUrl url);

        // -(BOOL)open;
        [Export("open")]
        bool Open();

        // -(BOOL)openWithFlags:(int)flags;
        [Export("openWithFlags:")]
        bool OpenWithFlags(int flags);

        // -(BOOL)openWithFlags:(int)flags vfs:(NSString * _Nullable)vfsName;
        [Export("openWithFlags:vfs:")]
        bool OpenWithFlags(int flags, [NullAllowed] string vfsName);

        // -(BOOL)close;
        [Export("close")]
        bool Close();

        // @property (readonly, nonatomic) BOOL goodConnection;
        [Export("goodConnection")]
        bool GoodConnection { get; }

        // -(BOOL)executeUpdate:(NSString * _Nonnull)sql withErrorAndBindings:(NSError * _Nullable * _Nullable)outErr, ...;
        [Internal]
        [Export("executeUpdate:withErrorAndBindings:", IsVariadic = true)]
        bool ExecuteUpdate(string sql, [NullAllowed] out NSError outErr, IntPtr varArgs);

        //// -(BOOL)update:(NSString * _Nonnull)sql withErrorAndBindings:(NSError * _Nullable * _Nullable)outErr, ... __attribute__((deprecated("Use executeUpdate:withErrorAndBindings: instead")));
        //[Internal]
        //[Export("update:withErrorAndBindings:", IsVariadic = true)]
        //bool Update(string sql, [NullAllowed] out NSError outErr, IntPtr varArgs);

        // -(BOOL)executeUpdate:(NSString * _Nonnull)sql, ...;
        [Internal]
        [Export("executeUpdate:", IsVariadic = true)]
        bool ExecuteUpdate(string sql, IntPtr varArgs);

        // -(BOOL)executeUpdateWithFormat:(NSString * _Nonnull)format, ... __attribute__((format(NSString, 1, 2)));
        [Internal]
        [Export("executeUpdateWithFormat:", IsVariadic = true)]
        bool ExecuteUpdateWithFormat(string format, IntPtr varArgs);

        // -(BOOL)executeUpdate:(NSString * _Nonnull)sql withArgumentsInArray:(NSArray * _Nonnull)arguments;
        [Export("executeUpdate:withArgumentsInArray:")]
        bool ExecuteUpdateWithArgumentsInArray(string sql, NSObject[] arguments);

        // -(BOOL)executeUpdate:(NSString * _Nonnull)sql values:(NSArray * _Nullable)values error:(NSError * _Nullable * _Nullable)error;
        [Export("executeUpdate:values:error:")]
        bool ExecuteUpdate(string sql, [NullAllowed] NSObject[] values, [NullAllowed] out NSError error);

        // -(BOOL)executeUpdate:(NSString * _Nonnull)sql withParameterDictionary:(NSDictionary * _Nonnull)arguments;
        [Export("executeUpdate:withParameterDictionary:")]
        bool ExecuteUpdate(string sql, NSDictionary arguments);

        // -(BOOL)executeUpdate:(NSString * _Nonnull)sql withVAList:(va_list _Nonnull)args;
        [Export("executeUpdate:withVAList:")]
        unsafe bool ExecuteUpdateWithVAList(string sql, params NSObject[] varArgs);

        // -(BOOL)executeStatements:(NSString * _Nonnull)sql;
        [Export("executeStatements:")]
        bool ExecuteStatements(string sql);

        // -(BOOL)executeStatements:(NSString * _Nonnull)sql withResultBlock:(FMDBExecuteStatementsCallbackBlock _Nullable)block;
        [Export("executeStatements:withResultBlock:")]
        bool ExecuteStatements(string sql, [NullAllowed] FMDBExecuteStatementsCallbackBlock block);

        // @property (readonly, nonatomic) int64_t lastInsertRowId;
        [Export("lastInsertRowId")]
        long LastInsertRowId { get; }

        // @property (readonly, nonatomic) int changes;
        [Export("changes")]
        int Changes { get; }

        // -(FMResultSet * _Nullable)executeQuery:(NSString * _Nonnull)sql, ...;
        [Internal]
        [Export("executeQuery:", IsVariadic = true)]
        [return: NullAllowed]
        FMResultSet ExecuteQuery(string sql, IntPtr varArgs);

        // -(FMResultSet * _Nullable)executeQueryWithFormat:(NSString * _Nonnull)format, ... __attribute__((format(NSString, 1, 2)));
        [Internal]
        [Export("executeQueryWithFormat:", IsVariadic = true)]
        [return: NullAllowed]
        FMResultSet ExecuteQueryWithFormat(string format, IntPtr varArgs);

        // -(FMResultSet * _Nullable)executeQuery:(NSString * _Nonnull)sql withArgumentsInArray:(NSArray * _Nonnull)arguments;
        [Export("executeQuery:withArgumentsInArray:")]
        [return: NullAllowed]
        FMResultSet ExecuteQueryWithArgumentsInArray(string sql, NSObject[] arguments);

        // -(FMResultSet * _Nullable)executeQuery:(NSString * _Nonnull)sql values:(NSArray * _Nullable)values error:(NSError * _Nullable * _Nullable)error;
        [Export("executeQuery:values:error:")]
        [return: NullAllowed]
        FMResultSet ExecuteQuery(string sql, [NullAllowed] NSObject[] values, [NullAllowed] out NSError error);

        // -(FMResultSet * _Nullable)executeQuery:(NSString * _Nonnull)sql withParameterDictionary:(NSDictionary * _Nullable)arguments;
        [Export("executeQuery:withParameterDictionary:")]
        [return: NullAllowed]
        FMResultSet ExecuteQuery(string sql, [NullAllowed] NSDictionary arguments);

        // -(FMResultSet * _Nullable)executeQuery:(NSString * _Nonnull)sql withVAList:(va_list _Nonnull)args;
        [Export("executeQuery:withVAList:")]
        [return: NullAllowed]
        unsafe FMResultSet ExecuteQueryWithVAList(string sql, params NSObject[] varArgs);

        // -(BOOL)beginTransaction;
        [Export("beginTransaction")]
        bool BeginTransaction();

        // -(BOOL)beginDeferredTransaction;
        [Export("beginDeferredTransaction")]
        bool BeginDeferredTransaction();

        // -(BOOL)commit;
        [Export("commit")]
        bool Commit();

        // -(BOOL)rollback;
        [Export("rollback")]
        bool Rollback();

        // @property (readonly, nonatomic) BOOL isInTransaction;
        [Export("isInTransaction")]
        bool IsInTransaction { get; }

        //// -(BOOL)inTransaction __attribute__((deprecated("Use isInTransaction property instead")));
        //[Export ("inTransaction")]
        //bool InTransaction { get; }

        // -(void)clearCachedStatements;
        [Export("clearCachedStatements")]
        void ClearCachedStatements();

        // -(void)closeOpenResultSets;
        [Export("closeOpenResultSets")]
        void CloseOpenResultSets();

        // @property (readonly, nonatomic) BOOL hasOpenResultSets;
        [Export("hasOpenResultSets")]
        bool HasOpenResultSets { get; }

        // @property (nonatomic) BOOL shouldCacheStatements;
        [Export("shouldCacheStatements")]
        bool ShouldCacheStatements { get; set; }

        // -(BOOL)interrupt;
        [Export("interrupt")]
        bool Interrupt();

        // -(BOOL)setKey:(NSString * _Nonnull)key;
        [Export("setKey:")]
        bool SetKey(string key);

        // -(BOOL)rekey:(NSString * _Nonnull)key;
        [Export("rekey:")]
        bool Rekey(string key);

        // -(BOOL)setKeyWithData:(NSData * _Nonnull)keyData;
        [Export("setKeyWithData:")]
        bool SetKeyWithData(NSData keyData);

        // -(BOOL)rekeyWithData:(NSData * _Nonnull)keyData;
        [Export("rekeyWithData:")]
        bool RekeyWithData(NSData keyData);

        // @property (readonly, nonatomic) NSString * _Nullable databasePath;
        [NullAllowed, Export("databasePath")]
        string DatabasePath { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable databaseURL;
        [NullAllowed, Export("databaseURL")]
        NSUrl DatabaseURL { get; }

        // @property (readonly, nonatomic) void * _Nonnull sqliteHandle;
        [Export("sqliteHandle")]
        unsafe NSObject SqliteHandle { get; }

        // -(NSString * _Nonnull)lastErrorMessage;
        [Export("lastErrorMessage")]
        string LastErrorMessage { get; }

        // -(int)lastErrorCode;
        [Export("lastErrorCode")]
        int LastErrorCode { get; }

        // -(int)lastExtendedErrorCode;
        [Export("lastExtendedErrorCode")]
        int LastExtendedErrorCode { get; }

        // -(BOOL)hadError;
        [Export("hadError")]
        bool HadError { get; }

        // -(NSError * _Nonnull)lastError;
        [Export("lastError")]
        NSError LastError { get; }

        // @property (nonatomic) NSTimeInterval maxBusyRetryTimeInterval;
        [Export("maxBusyRetryTimeInterval")]
        double MaxBusyRetryTimeInterval { get; set; }

        // -(BOOL)startSavePointWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)outErr;
        [Export("startSavePointWithName:error:")]
        bool StartSavePointWithName(string name, [NullAllowed] out NSError outErr);

        // -(BOOL)releaseSavePointWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)outErr;
        [Export("releaseSavePointWithName:error:")]
        bool ReleaseSavePointWithName(string name, [NullAllowed] out NSError outErr);

        // -(BOOL)rollbackToSavePointWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)outErr;
        [Export("rollbackToSavePointWithName:error:")]
        bool RollbackToSavePointWithName(string name, [NullAllowed] out NSError outErr);

        // -(NSError * _Nullable)inSavePoint:(void (^ _Nonnull)(BOOL * _Nonnull))block;
        [Export("inSavePoint:")]
        [return: NullAllowed]
        unsafe NSError InSavePoint(Action<IntPtr> block);

        // +(BOOL)isSQLiteThreadSafe;
        [Static]
        [Export("isSQLiteThreadSafe")]
        bool IsSQLiteThreadSafe { get; }

        // +(NSString * _Nonnull)sqliteLibVersion;
        [Static]
        [Export("sqliteLibVersion")]
        string SqliteLibVersion { get; }

        // +(NSString * _Nonnull)FMDBUserVersion;
        [Static]
        [Export("FMDBUserVersion")]
        string FMDBUserVersion { get; }

        // +(SInt32)FMDBVersion;
        [Static]
        [Export("FMDBVersion")]
        int FMDBVersion { get; }

        // -(void)makeFunctionNamed:(NSString * _Nonnull)name arguments:(int)arguments block:(void (^ _Nonnull)(void * _Nonnull, int, void * _Nonnull * _Nonnull))block;
        [Export("makeFunctionNamed:arguments:block:")]
        unsafe void MakeFunctionNamed(string name, int arguments, Action<NSObject, int, IntPtr> block);

        // -(void)makeFunctionNamed:(NSString * _Nonnull)name maximumArguments:(int)count withBlock:(void (^ _Nonnull)(void * _Nonnull, int, void * _Nonnull * _Nonnull))block __attribute__((deprecated("Use makeFunctionNamed:arguments:block:")));
        [Export("makeFunctionNamed:maximumArguments:withBlock:")]
        unsafe void MakeFunctionWithMaximumArguments(string name, int count, Action<NSObject, int, IntPtr> block);

        // -(SqliteValueType)valueType:(void * _Nonnull)argv;
        [Export("valueType:")]
        unsafe SqliteValueType ValueType(NSObject argv);

        // -(int)valueInt:(void * _Nonnull)value;
        [Export("valueInt:")]
        unsafe int ValueInt(NSObject value);

        // -(long long)valueLong:(void * _Nonnull)value;
        [Export("valueLong:")]
        unsafe long ValueLong(NSObject value);

        // -(double)valueDouble:(void * _Nonnull)value;
        [Export("valueDouble:")]
        unsafe double ValueDouble(NSObject value);

        // -(NSData * _Nullable)valueData:(void * _Nonnull)value;
        [Export("valueData:")]
        [return: NullAllowed]
        unsafe NSData ValueData(NSObject value);

        // -(NSString * _Nullable)valueString:(void * _Nonnull)value;
        [Export("valueString:")]
        [return: NullAllowed]
        unsafe string ValueString(NSObject value);

        // -(void)resultNullInContext:(void * _Nonnull)context;
        [Export("resultNullInContext:")]
        unsafe void ResultNullInContext(NSObject context);

        // -(void)resultInt:(int)value context:(void * _Nonnull)context;
        [Export("resultInt:context:")]
        unsafe void ResultInt(int value, NSObject context);

        // -(void)resultLong:(long long)value context:(void * _Nonnull)context;
        [Export("resultLong:context:")]
        unsafe void ResultLong(long value, NSObject context);

        // -(void)resultDouble:(double)value context:(void * _Nonnull)context;
        [Export("resultDouble:context:")]
        unsafe void ResultDouble(double value, NSObject context);

        // -(void)resultData:(NSData * _Nonnull)data context:(void * _Nonnull)context;
        [Export("resultData:context:")]
        unsafe void ResultData(NSData data, NSObject context);

        // -(void)resultString:(NSString * _Nonnull)value context:(void * _Nonnull)context;
        [Export("resultString:context:")]
        unsafe void ResultString(string value, NSObject context);

        // -(void)resultError:(NSString * _Nonnull)error context:(void * _Nonnull)context;
        [Export("resultError:context:")]
        unsafe void ResultError(string error, NSObject context);

        // -(void)resultErrorCode:(int)errorCode context:(void * _Nonnull)context;
        [Export("resultErrorCode:context:")]
        unsafe void ResultErrorCode(int errorCode, NSObject context);

        // -(void)resultErrorNoMemoryInContext:(void * _Nonnull)context;
        [Export("resultErrorNoMemoryInContext:")]
        unsafe void ResultErrorNoMemoryInContext(NSObject context);

        // -(void)resultErrorTooBigInContext:(void * _Nonnull)context;
        [Export("resultErrorTooBigInContext:")]
        unsafe void ResultErrorTooBigInContext(NSObject context);

        // +(NSDateFormatter * _Nonnull)storeableDateFormat:(NSString * _Nonnull)format;
        [Static]
        [Export("storeableDateFormat:")]
        NSDateFormatter StoreableDateFormat(string format);

        // -(BOOL)hasDateFormatter;
        [Export("hasDateFormatter")]
        bool HasDateFormatter { get; }

        // -(void)setDateFormat:(NSDateFormatter * _Nonnull)format;
        [Export("setDateFormat:")]
        void SetDateFormat(NSDateFormatter format);

        // -(NSDate * _Nullable)dateFromString:(NSString * _Nonnull)s;
        [Export("dateFromString:")]
        [return: NullAllowed]
        NSDate DateFromString(string s);

        // -(NSString * _Nonnull)stringFromDate:(NSDate * _Nonnull)date;
        [Export("stringFromDate:")]
        string StringFromDate(NSDate date);
    }

    // @interface FMStatement : NSObject
    [BaseType(typeof(NSObject))]
    interface FMStatement
    {
        // @property (assign, atomic) long useCount;
        [Export("useCount")]
        nint UseCount { get; set; }

        // @property (retain, atomic) NSString * _Nonnull query;
        [Export("query", ArgumentSemantic.Retain)]
        string Query { get; set; }

        // @property (assign, atomic) void * _Nonnull statement;
        [Export("statement", ArgumentSemantic.Assign)]
        unsafe NSString Statement { get; set; }

        // @property (assign, atomic) BOOL inUse;
        [Export("inUse")]
        bool InUse { get; set; }

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)reset;
        [Export("reset")]
        void Reset();
    }

    // @interface FMDatabaseAdditions (FMDatabase)
    [Category]
    [BaseType(typeof(FMDatabase))]
    interface FMDatabase_FMDatabaseAdditions
    {
        // -(int)intForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("intForQuery:", IsVariadic = true)]
        int IntForQuery(string query, IntPtr varArgs);

        // -(long)longForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("longForQuery:", IsVariadic = true)]
        nint LongForQuery(string query, IntPtr varArgs);

        // -(BOOL)boolForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("boolForQuery:", IsVariadic = true)]
        bool BoolForQuery(string query, IntPtr varArgs);

        // -(double)doubleForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("doubleForQuery:", IsVariadic = true)]
        double DoubleForQuery(string query, IntPtr varArgs);

        // -(NSString * _Nullable)stringForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("stringForQuery:", IsVariadic = true)]
        [return: NullAllowed]
        string StringForQuery(string query, IntPtr varArgs);

        // -(NSData * _Nullable)dataForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("dataForQuery:", IsVariadic = true)]
        [return: NullAllowed]
        NSData DataForQuery(string query, IntPtr varArgs);

        // -(NSDate * _Nullable)dateForQuery:(NSString * _Nonnull)query, ...;
        [Internal]
        [Export("dateForQuery:", IsVariadic = true)]
        [return: NullAllowed]
        NSDate DateForQuery(string query, IntPtr varArgs);

        // -(BOOL)tableExists:(NSString * _Nonnull)tableName;
        [Export("tableExists:")]
        bool TableExists(string tableName);

        // -(FMResultSet * _Nonnull)getSchema;
        [Export("getSchema")]
        FMResultSet GetSchema();

        // -(FMResultSet * _Nonnull)getTableSchema:(NSString * _Nonnull)tableName;
        [Export("getTableSchema:")]
        FMResultSet GetTableSchema(string tableName);

        // -(BOOL)columnExists:(NSString * _Nonnull)columnName inTableWithName:(NSString * _Nonnull)tableName;
        [Export("columnExists:inTableWithName:")]
        bool ColumnExists(string columnName, string tableName);

        //// -(BOOL)columnExists:(NSString * _Nonnull)tableName columnName:(NSString * _Nonnull)columnName __attribute__((deprecated("Use columnExists:inTableWithName: instead")));
        //[Export ("columnExists:columnName:")]
        //bool ColumnExists (string tableName, string columnName);

        // -(BOOL)validateSQL:(NSString * _Nonnull)sql error:(NSError * _Nullable * _Nullable)error;
        [Export("validateSQL:error:")]
        bool ValidateSQL(string sql, [NullAllowed] out NSError error);

        // @property (nonatomic) uint32_t applicationID;
        [Export("applicationID")]
		uint GetApplicationID();
		[Export("setApplicationID")]
		void SetApplicationID();

        // @property (nonatomic) uint32_t userVersion;
        [Export("userVersion")]
		uint GetUserVersion();
		[Export("setUserVersion")]
		void SetUserVersion();
    }

    // @interface FMDatabaseQueue : NSObject
    [BaseType(typeof(NSObject))]
    interface FMDatabaseQueue
    {
        // @property (retain, atomic) NSString * _Nullable path;
        [NullAllowed, Export("path", ArgumentSemantic.Retain)]
        string Path { get; set; }

        // @property (readonly, atomic) int openFlags;
        [Export("openFlags")]
        int OpenFlags { get; }

        // @property (copy, atomic) NSString * _Nullable vfsName;
        [NullAllowed, Export("vfsName")]
        string VfsName { get; set; }

        // +(instancetype _Nonnull)databaseQueueWithPath:(NSString * _Nullable)aPath;
        [Static]
        [Export("databaseQueueWithPath:")]
        FMDatabaseQueue DatabaseQueueWithPath([NullAllowed] string aPath);

        // +(instancetype _Nonnull)databaseQueueWithURL:(NSURL * _Nullable)url;
        [Static]
        [Export("databaseQueueWithURL:")]
        FMDatabaseQueue DatabaseQueueWithURL([NullAllowed] NSUrl url);

        // +(instancetype _Nonnull)databaseQueueWithPath:(NSString * _Nullable)aPath flags:(int)openFlags;
        [Static]
        [Export("databaseQueueWithPath:flags:")]
        FMDatabaseQueue DatabaseQueueWithPath([NullAllowed] string aPath, int openFlags);

        // +(instancetype _Nonnull)databaseQueueWithURL:(NSURL * _Nullable)url flags:(int)openFlags;
        [Static]
        [Export("databaseQueueWithURL:flags:")]
        FMDatabaseQueue DatabaseQueueWithURL([NullAllowed] NSUrl url, int openFlags);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)aPath;
        [Export("initWithPath:")]
        IntPtr Constructor([NullAllowed] string aPath);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url;
        [Export("initWithURL:")]
        IntPtr Constructor([NullAllowed] NSUrl url);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)aPath flags:(int)openFlags;
        [Export("initWithPath:flags:")]
        IntPtr Constructor([NullAllowed] string aPath, int openFlags);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url flags:(int)openFlags;
        [Export("initWithURL:flags:")]
        IntPtr Constructor([NullAllowed] NSUrl url, int openFlags);

        // -(instancetype _Nonnull)initWithPath:(NSString * _Nullable)aPath flags:(int)openFlags vfs:(NSString * _Nullable)vfsName;
        [Export("initWithPath:flags:vfs:")]
        IntPtr Constructor([NullAllowed] string aPath, int openFlags, [NullAllowed] string vfsName);

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url flags:(int)openFlags vfs:(NSString * _Nullable)vfsName;
        [Export("initWithURL:flags:vfs:")]
        IntPtr Constructor([NullAllowed] NSUrl url, int openFlags, [NullAllowed] string vfsName);

        // +(Class _Nonnull)databaseClass;
        [Static]
        [Export("databaseClass")]
        Class DatabaseClass { get; }

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)interrupt;
        [Export("interrupt")]
        void Interrupt();

        // -(void)inDatabase:(void (^ _Nonnull)(FMDatabase * _Nonnull))block;
        [Export("inDatabase:")]
        void InDatabase(Action<FMDatabase> block);

        // -(void)inTransaction:(void (^ _Nonnull)(FMDatabase * _Nonnull, BOOL * _Nonnull))block;
        [Export("inTransaction:")]
        unsafe void InTransaction(Action<FMDatabase, IntPtr> block);

        // -(void)inDeferredTransaction:(void (^ _Nonnull)(FMDatabase * _Nonnull, BOOL * _Nonnull))block;
        [Export("inDeferredTransaction:")]
        unsafe void InDeferredTransaction(Action<FMDatabase, IntPtr> block);

        // -(NSError * _Nullable)inSavePoint:(void (^ _Nonnull)(FMDatabase * _Nonnull, BOOL * _Nonnull))block;
        [Export("inSavePoint:")]
        [return: NullAllowed]
        unsafe NSError InSavePoint(Action<FMDatabase, IntPtr> block);
    }

    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double FMDBVersionNumber;
    // 	[Field ("FMDBVersionNumber", "__Internal")]
    // 	double FMDBVersionNumber { get; }

    // 	// extern const unsigned char [] FMDBVersionString;
    // 	[Field ("FMDBVersionString", "__Internal")]
    // 	byte[] FMDBVersionString { get; }

    // 	// extern double FMDBVersionNumber;
    // 	[Field ("FMDBVersionNumber", "__Internal")]
    // 	double FMDBVersionNumber { get; }

    // 	// extern const unsigned char [] FMDBVersionString;
    // 	[Field ("FMDBVersionString", "__Internal")]
    // 	byte[] FMDBVersionString { get; }
    // }
}
