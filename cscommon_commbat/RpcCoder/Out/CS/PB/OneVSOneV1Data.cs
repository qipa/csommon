//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OneVSOneV1Data.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OneVSOneOneVSOneDateV1")]
  public partial class OneVSOneOneVSOneDateV1 : global::ProtoBuf.IExtensible
  {
    public OneVSOneOneVSOneDateV1() {}
    
    private readonly global::System.Collections.Generic.List<OneSData> _SkillDate = new global::System.Collections.Generic.List<OneSData>();
    [global::ProtoBuf.ProtoMember(4, Name=@"SkillDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OneSData> SkillDate
    {
      get { return _SkillDate; }
    }
  
    private int _Log = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Log", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Log
    {
      get { return _Log; }
      set { _Log = value; }
    }
    private int _OneVSOneNum = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"OneVSOneNum", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int OneVSOneNum
    {
      get { return _OneVSOneNum; }
      set { _OneVSOneNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}