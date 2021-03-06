//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Response.proto
// Note: requires additional types generated from: AddResponse.proto
// Note: requires additional types generated from: BulkAddResponse.proto
// Note: requires additional types generated from: BulkGetResponse.proto
// Note: requires additional types generated from: BulkInsertResponse.proto
// Note: requires additional types generated from: BulkRemoveResponse.proto
// Note: requires additional types generated from: ClearResponse.proto
// Note: requires additional types generated from: ContainResponse.proto
// Note: requires additional types generated from: CountResponse.proto
// Note: requires additional types generated from: DisposeResponse.proto
// Note: requires additional types generated from: GetCacheItemResponse.proto
// Note: requires additional types generated from: GetResponse.proto
// Note: requires additional types generated from: GetEnumeratorResponse.proto
// Note: requires additional types generated from: GetHashmapResponse.proto
// Note: requires additional types generated from: GetTypeMapResponse.proto
// Note: requires additional types generated from: InitializeCacheResponse.proto
// Note: requires additional types generated from: InsertReponse.proto
// Note: requires additional types generated from: RaiseCustomEventResponse.proto
// Note: requires additional types generated from: RegisterKeyNotifResponse.proto
// Note: requires additional types generated from: RegisterBulkKeyNotifResponse.proto
// Note: requires additional types generated from: RegisterNotifResponse.proto
// Note: requires additional types generated from: LockResponse.proto
// Note: requires additional types generated from: RemoveResponse.proto
// Note: requires additional types generated from: SearchResponse.proto
// Note: requires additional types generated from: SearchEntriesResponse.proto
// Note: requires additional types generated from: UnlockResponse.proto
// Note: requires additional types generated from: VerifyLockResponse.proto
// Note: requires additional types generated from: IsLockedResponse.proto
// Note: requires additional types generated from: UnregisterBulkKeyNotifResponse.proto
// Note: requires additional types generated from: UnregisterKeyNotifResponse.proto
// Note: requires additional types generated from: GetLoggingInfoResponse.proto
// Note: requires additional types generated from: Exception.proto
// Note: requires additional types generated from: HashmapChangedEventResponse.proto
// Note: requires additional types generated from: CacheStoppedEventResponse.proto
// Note: requires additional types generated from: ConfigModifiedEventResponse.proto
// Note: requires additional types generated from: LoggingInfoModifiedEventResponse.proto
// Note: requires additional types generated from: QueueFullEventResponse.proto
// Note: requires additional types generated from: ItemRemoveCallbackResponse.proto
// Note: requires additional types generated from: ItemUpdatedCallbackResponse.proto
// Note: requires additional types generated from: HeartBeatResponse.proto
// Note: requires additional types generated from: BulkDeleteResponse.proto
// Note: requires additional types generated from: DeleteResponse.proto
// Note: requires additional types generated from: GetNextChunkResponse.proto
// Note: requires additional types generated from: AddAttributeResponse.proto
// Note: requires additional types generated from: CompactTypeRegisterEvent.proto
// Note: requires additional types generated from: FragmentedResponse.proto
// Note: requires additional types generated from: BulkEventResponse.proto
// Note: requires additional types generated from: GetProductVersionResponse.proto
// Note: requires additional types generated from: GetServerMappingResponse.proto
// Note: requires additional types generated from: GetOptimalServerResponse.proto
// Note: requires additional types generated from: GetRunningServersResponse.proto
// Note: requires additional types generated from: NodeJoinedEventResponse.proto
// Note: requires additional types generated from: NodeLeftEventResponse.proto
// Note: requires additional types generated from: GetCacheBindingResponse.proto
// Note: requires additional types generated from: DisposeReaderResponse.proto
// Note: requires additional types generated from: ExecuteReaderResponse.proto
// Note: requires additional types generated from: GetReaderChunkResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Response")]
  public partial class Response : global::ProtoBuf.IExtensible
  {
    public Response() {}
    

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.Response.Type _responseType = Alachisoft.NCache.Common.Protobuf.Response.Type.ADD;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"responseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Alachisoft.NCache.Common.Protobuf.Response.Type.ADD)]
    public Alachisoft.NCache.Common.Protobuf.Response.Type responseType
    {
      get { return _responseType; }
      set { _responseType = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.Exception _exception = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"exception", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.Exception exception
    {
      get { return _exception; }
      set { _exception = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.BulkAddResponse _bulkAdd = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"bulkAdd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.BulkAddResponse bulkAdd
    {
      get { return _bulkAdd; }
      set { _bulkAdd = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.BulkGetResponse _bulkGet = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"bulkGet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.BulkGetResponse bulkGet
    {
      get { return _bulkGet; }
      set { _bulkGet = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.BulkInsertResponse _bulkInsert = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bulkInsert", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.BulkInsertResponse bulkInsert
    {
      get { return _bulkInsert; }
      set { _bulkInsert = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.BulkRemoveResponse _bulkRemove = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bulkRemove", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.BulkRemoveResponse bulkRemove
    {
      get { return _bulkRemove; }
      set { _bulkRemove = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ContainResponse _contain = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"contain", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ContainResponse contain
    {
      get { return _contain; }
      set { _contain = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.CountResponse _count = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.CountResponse count
    {
      get { return _count; }
      set { _count = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetCacheItemResponse _getItem = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"getItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetCacheItemResponse getItem
    {
      get { return _getItem; }
      set { _getItem = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetResponse _get = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"get", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetResponse get
    {
      get { return _get; }
      set { _get = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetEnumeratorResponse _getEnum = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"getEnum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetEnumeratorResponse getEnum
    {
      get { return _getEnum; }
      set { _getEnum = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetHashmapResponse _getHashmap = null;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"getHashmap", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetHashmapResponse getHashmap
    {
      get { return _getHashmap; }
      set { _getHashmap = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetTypeMapResponse _getTypemap = null;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"getTypemap", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetTypeMapResponse getTypemap
    {
      get { return _getTypemap; }
      set { _getTypemap = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.InitializeCacheResponse _initCache = null;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"initCache", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.InitializeCacheResponse initCache
    {
      get { return _initCache; }
      set { _initCache = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.InsertResponse _insert = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"insert", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.InsertResponse insert
    {
      get { return _insert; }
      set { _insert = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.LockResponse _lockResponse = null;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"lockResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.LockResponse lockResponse
    {
      get { return _lockResponse; }
      set { _lockResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.VerifyLockResponse _lockVerify = null;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"lockVerify", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.VerifyLockResponse lockVerify
    {
      get { return _lockVerify; }
      set { _lockVerify = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.RemoveResponse _remove = null;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"remove", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.RemoveResponse remove
    {
      get { return _remove; }
      set { _remove = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.SearchResponse _search = null;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"search", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.SearchResponse search
    {
      get { return _search; }
      set { _search = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.SearchEntriesResponse _searchEntries = null;
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"searchEntries", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.SearchEntriesResponse searchEntries
    {
      get { return _searchEntries; }
      set { _searchEntries = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.AddResponse _addResponse = null;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"addResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.AddResponse addResponse
    {
      get { return _addResponse; }
      set { _addResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ClearResponse _clearResponse = null;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"clearResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ClearResponse clearResponse
    {
      get { return _clearResponse; }
      set { _clearResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.DisposeResponse _disposeResponse = null;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"disposeResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.DisposeResponse disposeResponse
    {
      get { return _disposeResponse; }
      set { _disposeResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.RaiseCustomEventResponse _raiseCustomEventResponse = null;
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"raiseCustomEventResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.RaiseCustomEventResponse raiseCustomEventResponse
    {
      get { return _raiseCustomEventResponse; }
      set { _raiseCustomEventResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.RegisterKeyNotifResponse _registerKeyNotifResponse = null;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"registerKeyNotifResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.RegisterKeyNotifResponse registerKeyNotifResponse
    {
      get { return _registerKeyNotifResponse; }
      set { _registerKeyNotifResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.RegisterNotifResponse _registerNotifResponse = null;
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"registerNotifResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.RegisterNotifResponse registerNotifResponse
    {
      get { return _registerNotifResponse; }
      set { _registerNotifResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.IsLockedResponse _isLockedResponse = null;
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"isLockedResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.IsLockedResponse isLockedResponse
    {
      get { return _isLockedResponse; }
      set { _isLockedResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.UnregisterBulkKeyNotifResponse _unregisterBulkKeyNotifResponse = null;
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"unregisterBulkKeyNotifResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.UnregisterBulkKeyNotifResponse unregisterBulkKeyNotifResponse
    {
      get { return _unregisterBulkKeyNotifResponse; }
      set { _unregisterBulkKeyNotifResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.UnregisterKeyNotifResponse _unregisterKeyNotifResponse = null;
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"unregisterKeyNotifResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.UnregisterKeyNotifResponse unregisterKeyNotifResponse
    {
      get { return _unregisterKeyNotifResponse; }
      set { _unregisterKeyNotifResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetLoggingInfoResponse _getLoggingInfoResponse = null;
    [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"getLoggingInfoResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetLoggingInfoResponse getLoggingInfoResponse
    {
      get { return _getLoggingInfoResponse; }
      set { _getLoggingInfoResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ItemRemoveCallbackResponse _itemRemovedCallback = null;
    [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"itemRemovedCallback", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ItemRemoveCallbackResponse itemRemovedCallback
    {
      get { return _itemRemovedCallback; }
      set { _itemRemovedCallback = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ItemUpdatedCallbackResponse _itemUpdatedCallback = null;
    [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"itemUpdatedCallback", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ItemUpdatedCallbackResponse itemUpdatedCallback
    {
      get { return _itemUpdatedCallback; }
      set { _itemUpdatedCallback = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.CacheStoppedEventResponse _cacheStopped = null;
    [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"cacheStopped", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.CacheStoppedEventResponse cacheStopped
    {
      get { return _cacheStopped; }
      set { _cacheStopped = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ConfigModifiedEventResponse _configModified = null;
    [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"configModified", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ConfigModifiedEventResponse configModified
    {
      get { return _configModified; }
      set { _configModified = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.HashmapChangedEventResponse _hashmapChanged = null;
    [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"hashmapChanged", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.HashmapChangedEventResponse hashmapChanged
    {
      get { return _hashmapChanged; }
      set { _hashmapChanged = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.LoggingInfoModifiedEventResponse _loggingInfoModified = null;
    [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"loggingInfoModified", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.LoggingInfoModifiedEventResponse loggingInfoModified
    {
      get { return _loggingInfoModified; }
      set { _loggingInfoModified = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.QueueFullEventResponse _queueFullEvent = null;
    [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"queueFullEvent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.QueueFullEventResponse queueFullEvent
    {
      get { return _queueFullEvent; }
      set { _queueFullEvent = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.UnlockResponse _unlockResponse = null;
    [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"unlockResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.UnlockResponse unlockResponse
    {
      get { return _unlockResponse; }
      set { _unlockResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.RegisterBulkKeyNotifResponse _registerBulkKeyNotifResponse = null;
    [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"registerBulkKeyNotifResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.RegisterBulkKeyNotifResponse registerBulkKeyNotifResponse
    {
      get { return _registerBulkKeyNotifResponse; }
      set { _registerBulkKeyNotifResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.HeartBeatResponse _heartBeatResponse = null;
    [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"heartBeatResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.HeartBeatResponse heartBeatResponse
    {
      get { return _heartBeatResponse; }
      set { _heartBeatResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.BulkDeleteResponse _bulkDeleteResponse = null;
    [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"bulkDeleteResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.BulkDeleteResponse bulkDeleteResponse
    {
      get { return _bulkDeleteResponse; }
      set { _bulkDeleteResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.DeleteResponse _deleteResponse = null;
    [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"deleteResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.DeleteResponse deleteResponse
    {
      get { return _deleteResponse; }
      set { _deleteResponse = value; }
    }

    private string _intendedRecipient = "";
    [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"intendedRecipient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string intendedRecipient
    {
      get { return _intendedRecipient; }
      set { _intendedRecipient = value; }
    }

    private int _sequenceId = (int)1;
    [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"sequenceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int sequenceId
    {
      get { return _sequenceId; }
      set { _sequenceId = value; }
    }

    private int _numberOfChuncks = (int)1;
    [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"numberOfChuncks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int numberOfChuncks
    {
      get { return _numberOfChuncks; }
      set { _numberOfChuncks = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetNextChunkResponse _getNextChunkResponse = null;
    [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"getNextChunkResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetNextChunkResponse getNextChunkResponse
    {
      get { return _getNextChunkResponse; }
      set { _getNextChunkResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.AddAttributeResponse _addAttributeResponse = null;
    [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"addAttributeResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.AddAttributeResponse addAttributeResponse
    {
      get { return _addAttributeResponse; }
      set { _addAttributeResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.CompactTypeRegisterEvent _compactTypeRegisterEvent = null;
    [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"compactTypeRegisterEvent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.CompactTypeRegisterEvent compactTypeRegisterEvent
    {
      get { return _compactTypeRegisterEvent; }
      set { _compactTypeRegisterEvent = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.BulkEventResponse _bulkEventResponse = null;
    [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"bulkEventResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.BulkEventResponse bulkEventResponse
    {
      get { return _bulkEventResponse; }
      set { _bulkEventResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetProductVersionResponse _getProductVersionResponse = null;
    [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"getProductVersionResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetProductVersionResponse getProductVersionResponse
    {
      get { return _getProductVersionResponse; }
      set { _getProductVersionResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.FragmentedResponse _getResponseFragment = null;
    [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"getResponseFragment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.FragmentedResponse getResponseFragment
    {
      get { return _getResponseFragment; }
      set { _getResponseFragment = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetServerMappingResponse _getServerMappingResponse = null;
    [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"getServerMappingResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetServerMappingResponse getServerMappingResponse
    {
      get { return _getServerMappingResponse; }
      set { _getServerMappingResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetOptimalServerResponse _getOptimalServer = null;
    [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"getOptimalServer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetOptimalServerResponse getOptimalServer
    {
      get { return _getOptimalServer; }
      set { _getOptimalServer = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetRunningServersResponse _getRunningServer = null;
    [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"getRunningServer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetRunningServersResponse getRunningServer
    {
      get { return _getRunningServer; }
      set { _getRunningServer = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.NodeJoinedEventResponse _nodeJoined = null;
    [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"nodeJoined", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.NodeJoinedEventResponse nodeJoined
    {
      get { return _nodeJoined; }
      set { _nodeJoined = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.NodeLeftEventResponse _nodeLeft = null;
    [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"nodeLeft", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.NodeLeftEventResponse nodeLeft
    {
      get { return _nodeLeft; }
      set { _nodeLeft = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetCacheBindingResponse _getCacheBindingResponse = null;
    [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"getCacheBindingResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetCacheBindingResponse getCacheBindingResponse
    {
      get { return _getCacheBindingResponse; }
      set { _getCacheBindingResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.DisposeReaderResponse _disposeReaderResponse = null;
    [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"disposeReaderResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.DisposeReaderResponse disposeReaderResponse
    {
      get { return _disposeReaderResponse; }
      set { _disposeReaderResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ExecuteReaderResponse _executeReaderResponse = null;
    [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"executeReaderResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ExecuteReaderResponse executeReaderResponse
    {
      get { return _executeReaderResponse; }
      set { _executeReaderResponse = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GetReaderChunkResponse _getReaderChunkResponse = null;
    [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"getReaderChunkResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GetReaderChunkResponse getReaderChunkResponse
    {
      get { return _getReaderChunkResponse; }
      set { _getReaderChunkResponse = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Type")]
    public enum Type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADD", Value=1)]
      ADD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADD_BULK", Value=2)]
      ADD_BULK = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_BULK", Value=3)]
      GET_BULK = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSERT_BULK", Value=4)]
      INSERT_BULK = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REMOVE_BULK", Value=5)]
      REMOVE_BULK = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CLEAR", Value=6)]
      CLEAR = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONTAINS", Value=7)]
      CONTAINS = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COUNT", Value=8)]
      COUNT = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DISPOSE", Value=9)]
      DISPOSE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_CACHE_ITEM", Value=10)]
      GET_CACHE_ITEM = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET", Value=11)]
      GET = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_ENUMERATOR", Value=12)]
      GET_ENUMERATOR = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_HASHMAP", Value=13)]
      GET_HASHMAP = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_THRESHOLD_SIZE", Value=14)]
      GET_THRESHOLD_SIZE = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_TYPEINFO_MAP", Value=15)]
      GET_TYPEINFO_MAP = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INIT", Value=16)]
      INIT = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSERT", Value=17)]
      INSERT = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_KEY_NOTIF", Value=18)]
      REGISTER_KEY_NOTIF = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_NOTIF", Value=19)]
      REGISTER_NOTIF = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REMOVE", Value=20)]
      REMOVE = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SEARCH", Value=21)]
      SEARCH = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOCK", Value=22)]
      LOCK = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNLOCK", Value=23)]
      UNLOCK = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ISLOCKED", Value=24)]
      ISLOCKED = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOCK_VERIFY", Value=25)]
      LOCK_VERIFY = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNREGISTER_KEY_NOTIF", Value=26)]
      UNREGISTER_KEY_NOTIF = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNREGISTER_BULK_KEY_NOTIF", Value=27)]
      UNREGISTER_BULK_KEY_NOTIF = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_BULK_KEY_NOTIF", Value=28)]
      REGISTER_BULK_KEY_NOTIF = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_LOGGING_INFO", Value=29)]
      GET_LOGGING_INFO = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SEARCH_ENTRIES", Value=30)]
      SEARCH_ENTRIES = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXCEPTION", Value=31)]
      EXCEPTION = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_REMOVED_CALLBACK", Value=32)]
      ITEM_REMOVED_CALLBACK = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_UPDATED_CALLBACK", Value=33)]
      ITEM_UPDATED_CALLBACK = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CACHE_STOPPED_EVENT", Value=34)]
      CACHE_STOPPED_EVENT = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONFIG_MODIFIED_EVENT", Value=35)]
      CONFIG_MODIFIED_EVENT = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HASHMAP_CHANGED_EVENT", Value=36)]
      HASHMAP_CHANGED_EVENT = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGGING_INFO_MODIFIED_EVENT", Value=37)]
      LOGGING_INFO_MODIFIED_EVENT = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEUE_FULL_EVENT", Value=38)]
      QUEUE_FULL_EVENT = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HEART_BEAT", Value=39)]
      HEART_BEAT = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DELETE_BULK", Value=40)]
      DELETE_BULK = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DELETE", Value=41)]
      DELETE = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_NEXT_CHUNK", Value=42)]
      GET_NEXT_CHUNK = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADD_ATTRIBUTE", Value=43)]
      ADD_ATTRIBUTE = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COMPACT_TYPE_REGISTER_EVENT", Value=44)]
      COMPACT_TYPE_REGISTER_EVENT = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BULK_EVENT", Value=45)]
      BULK_EVENT = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_PRODUCT_VERSION", Value=46)]
      GET_PRODUCT_VERSION = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RESPONSE_FRAGMENT", Value=47)]
      RESPONSE_FRAGMENT = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_SERVER_MAPPING", Value=48)]
      GET_SERVER_MAPPING = 48,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_OPTIMAL_SERVER", Value=49)]
      GET_OPTIMAL_SERVER = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_RUNNING_SERVERS", Value=50)]
      GET_RUNNING_SERVERS = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NODE_JOINED_EVENT", Value=51)]
      NODE_JOINED_EVENT = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NODE_LEFT_EVENT", Value=52)]
      NODE_LEFT_EVENT = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_CACHE_BINDING", Value=53)]
      GET_CACHE_BINDING = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DISPOSE_READER", Value=54)]
      DISPOSE_READER = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXECUTE_READER", Value=55)]
      EXECUTE_READER = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_READER_CHUNK", Value=56)]
      GET_READER_CHUNK = 56
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
