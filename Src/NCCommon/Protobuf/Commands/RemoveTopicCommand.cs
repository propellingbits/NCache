//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RemoveTopicCommand.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveTopicCommand")]
  public partial class RemoveTopicCommand : global::ProtoBuf.IExtensible
  {
    public RemoveTopicCommand() {}
    

    private string _topicName = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"topicName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string topicName
    {
      get { return _topicName; }
      set { _topicName = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private bool _forcefully = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"forcefully", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool forcefully
    {
      get { return _forcefully; }
      set { _forcefully = value; }
    }

    private long _clientLastViewId = (long)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"clientLastViewId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long clientLastViewId
    {
      get { return _clientLastViewId; }
      set { _clientLastViewId = value; }
    }

    private string _version = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string version
    {
      get { return _version; }
      set { _version = value; }
    }

    private int _commandVersion = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"commandVersion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int commandVersion
    {
      get { return _commandVersion; }
      set { _commandVersion = value; }
    }

    private string _intendedRecipient = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"intendedRecipient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string intendedRecipient
    {
      get { return _intendedRecipient; }
      set { _intendedRecipient = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}