//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RecordSet.proto
// Note: requires additional types generated from: RecordColumn.proto
// Note: requires additional types generated from: RecordRow.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecordSet")]
  public partial class RecordSet : global::ProtoBuf.IExtensible
  {
    public RecordSet() {}
    
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.RecordColumn> _columns = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.RecordColumn>();
    [global::ProtoBuf.ProtoMember(1, Name=@"columns", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.RecordColumn> columns
    {
      get { return _columns; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.RecordRow> _rows = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.RecordRow>();
    [global::ProtoBuf.ProtoMember(2, Name=@"rows", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.RecordRow> rows
    {
      get { return _rows; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
