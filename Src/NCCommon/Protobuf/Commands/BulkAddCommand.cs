//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BulkAddCommand.proto
// Note: requires additional types generated from: AddCommand.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BulkAddCommand")]
  public partial class BulkAddCommand : global::ProtoBuf.IExtensible
  {
    public BulkAddCommand() {}
    

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private int _datasourceItemAddedCallbackId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"datasourceItemAddedCallbackId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int datasourceItemAddedCallbackId
    {
      get { return _datasourceItemAddedCallbackId; }
      set { _datasourceItemAddedCallbackId = value; }
    }

    private string _providerName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"providerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string providerName
    {
      get { return _providerName; }
      set { _providerName = value; }
    }
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.AddCommand> _addCommand = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.AddCommand>();
    [global::ProtoBuf.ProtoMember(4, Name=@"addCommand", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.AddCommand> addCommand
    {
      get { return _addCommand; }
    }
  

    private bool _returnVersions = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"returnVersions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool returnVersions
    {
      get { return _returnVersions; }
      set { _returnVersions = value; }
    }

    private long _clientLastViewId = (long)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"clientLastViewId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long clientLastViewId
    {
      get { return _clientLastViewId; }
      set { _clientLastViewId = value; }
    }

    private string _intendedRecipient = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"intendedRecipient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string intendedRecipient
    {
      get { return _intendedRecipient; }
      set { _intendedRecipient = value; }
    }

    private string _version = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string version
    {
      get { return _version; }
      set { _version = value; }
    }

    private int _MethodOverload = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"MethodOverload", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int MethodOverload
    {
      get { return _MethodOverload; }
      set { _MethodOverload = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
        public int commandID;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}