//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: TalismanV1Data.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalismanDataFabaoV1")]
  public partial class TalismanDataFabaoV1 : global::ProtoBuf.IExtensible
  {
    public TalismanDataFabaoV1() {}
    
    private readonly global::System.Collections.Generic.List<TalismanFabaoInfoV1> _FabaoArr = new global::System.Collections.Generic.List<TalismanFabaoInfoV1>();
    [global::ProtoBuf.ProtoMember(1, Name=@"FabaoArr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TalismanFabaoInfoV1> FabaoArr
    {
      get { return _FabaoArr; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalismanFabaoInfoV1")]
  public partial class TalismanFabaoInfoV1 : global::ProtoBuf.IExtensible
  {
    public TalismanFabaoInfoV1() {}
    
    private int _ID = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _Lv = (int)1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Lv", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int Lv
    {
      get { return _Lv; }
      set { _Lv = value; }
    }
    private int _IsActived = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IsActived", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int IsActived
    {
      get { return _IsActived; }
      set { _IsActived = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _ActivedCondID = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"ActivedCondID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> ActivedCondID
    {
      get { return _ActivedCondID; }
    }
  
    private int _Exp = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int Exp
    {
      get { return _Exp; }
      set { _Exp = value; }
    }
    private int _HitType = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"HitType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int HitType
    {
      get { return _HitType; }
      set { _HitType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}