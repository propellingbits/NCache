//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WriteToStreamCommand.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WriteToStreamCommand")]
  public partial class WriteToStreamCommand : global::ProtoBuf.IExtensible
  {
    public WriteToStreamCommand() {}
    

    private string _key = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private string _lockHandle = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lockHandle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lockHandle
    {
      get { return _lockHandle; }
      set { _lockHandle = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private int _srcOffSet = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"srcOffSet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int srcOffSet
    {
      get { return _srcOffSet; }
      set { _srcOffSet = value; }
    }

    private int _dstOffSet = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"dstOffSet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dstOffSet
    {
      get { return _dstOffSet; }
      set { _dstOffSet = value; }
    }

    private int _length = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"length", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int length
    {
      get { return _length; }
      set { _length = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _buffer = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(7, Name=@"buffer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> buffer
    {
      get { return _buffer; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}