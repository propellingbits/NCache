//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetCommand.proto
// Note: requires additional types generated from: LockInfo.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetCommand")]
  public partial class GetCommand : global::ProtoBuf.IExtensible
  {
    public GetCommand() {}
    

    private string _key = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private int _flag = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flag
    {
      get { return _flag; }
      set { _flag = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.LockInfo _lockInfo = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"lockInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.LockInfo lockInfo
    {
      get { return _lockInfo; }
      set { _lockInfo = value; }
    }

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }

    private string _providerName = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"providerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string providerName
    {
      get { return _providerName; }
      set { _providerName = value; }
    }

    private int _threadId = (int)-1;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"threadId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int threadId
    {
      get { return _threadId; }
      set { _threadId = value; }
    }


    private int _readMode = (int)-1;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"readMode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int readMode
    {
      get { return _readMode; }
      set { _readMode = value; }
    }
    private int _MethodOverload = (int)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MethodOverload", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int MethodOverload
    {
      get { return _MethodOverload; }
      set { _MethodOverload = value; }
    }

    private int _commandID = (int)-1;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"commandID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int commandID
    {
      get { return _commandID; }
      set { _commandID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}