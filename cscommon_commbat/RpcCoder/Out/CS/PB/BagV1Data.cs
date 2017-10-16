//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BagV1Data.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BagPackageDataV1")]
  public partial class BagPackageDataV1 : global::ProtoBuf.IExtensible
  {
    public BagPackageDataV1() {}
    
    private readonly global::System.Collections.Generic.List<BagGridInfoV1> _GridArray = new global::System.Collections.Generic.List<BagGridInfoV1>();
    [global::ProtoBuf.ProtoMember(1, Name=@"GridArray", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BagGridInfoV1> GridArray
    {
      get { return _GridArray; }
    }
  
    private readonly global::System.Collections.Generic.List<BagEquipObj> _EquipAllData = new global::System.Collections.Generic.List<BagEquipObj>();
    [global::ProtoBuf.ProtoMember(4, Name=@"EquipAllData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BagEquipObj> EquipAllData
    {
      get { return _EquipAllData; }
    }
  
    private readonly global::System.Collections.Generic.List<BagGridInfoV1> _WearEquipContainer = new global::System.Collections.Generic.List<BagGridInfoV1>();
    [global::ProtoBuf.ProtoMember(5, Name=@"WearEquipContainer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BagGridInfoV1> WearEquipContainer
    {
      get { return _WearEquipContainer; }
    }
  
    private readonly global::System.Collections.Generic.List<BagGridInfoV1> _StorageBagGrid = new global::System.Collections.Generic.List<BagGridInfoV1>();
    [global::ProtoBuf.ProtoMember(7, Name=@"StorageBagGrid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BagGridInfoV1> StorageBagGrid
    {
      get { return _StorageBagGrid; }
    }
  
    private int _StorageBank = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"StorageBank", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int StorageBank
    {
      get { return _StorageBank; }
      set { _StorageBank = value; }
    }
    private readonly global::System.Collections.Generic.List<BagTalismanObjV1> _TalismanData = new global::System.Collections.Generic.List<BagTalismanObjV1>();
    [global::ProtoBuf.ProtoMember(9, Name=@"TalismanData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BagTalismanObjV1> TalismanData
    {
      get { return _TalismanData; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _TalismanForeverAttr = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(10, Name=@"TalismanForeverAttr", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> TalismanForeverAttr
    {
      get { return _TalismanForeverAttr; }
    }
  
    private readonly global::System.Collections.Generic.List<KeyValue2IntBool> _AutoPickup = new global::System.Collections.Generic.List<KeyValue2IntBool>();
    [global::ProtoBuf.ProtoMember(11, Name=@"AutoPickup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<KeyValue2IntBool> AutoPickup
    {
      get { return _AutoPickup; }
    }
  
    private readonly global::System.Collections.Generic.List<KeyValue2IntInt> _UseItemDay = new global::System.Collections.Generic.List<KeyValue2IntInt>();
    [global::ProtoBuf.ProtoMember(15, Name=@"UseItemDay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<KeyValue2IntInt> UseItemDay
    {
      get { return _UseItemDay; }
    }
  
    private readonly global::System.Collections.Generic.List<KeyValue2IntInt> _UseItemWeek = new global::System.Collections.Generic.List<KeyValue2IntInt>();
    [global::ProtoBuf.ProtoMember(16, Name=@"UseItemWeek", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<KeyValue2IntInt> UseItemWeek
    {
      get { return _UseItemWeek; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BagGridInfoV1")]
  public partial class BagGridInfoV1 : global::ProtoBuf.IExtensible
  {
    public BagGridInfoV1() {}
    
    private int _TemplateID = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TemplateID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TemplateID
    {
      get { return _TemplateID; }
      set { _TemplateID = value; }
    }
    private int _Num = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int Num
    {
      get { return _Num; }
      set { _Num = value; }
    }
    private int _ItemType = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ItemType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int ItemType
    {
      get { return _ItemType; }
      set { _ItemType = value; }
    }
    private int _Pos = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Pos
    {
      get { return _Pos; }
      set { _Pos = value; }
    }
    private int _Value = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Value
    {
      get { return _Value; }
      set { _Value = value; }
    }
    private long _Index = (long)-1;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private bool _Bind = (bool)false;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Bind", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool Bind
    {
      get { return _Bind; }
      set { _Bind = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BagTalismanObjV1")]
  public partial class BagTalismanObjV1 : global::ProtoBuf.IExtensible
  {
    public BagTalismanObjV1() {}
    
    private long _ItemID = (long)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long ItemID
    {
      get { return _ItemID; }
      set { _ItemID = value; }
    }
    private int _TemplateId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TemplateId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TemplateId
    {
      get { return _TemplateId; }
      set { _TemplateId = value; }
    }
    private int _CurExp = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CurExp", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int CurExp
    {
      get { return _CurExp; }
      set { _CurExp = value; }
    }
    private int _EquipScore = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"EquipScore", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int EquipScore
    {
      get { return _EquipScore; }
      set { _EquipScore = value; }
    }
    private int _StarLevel = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"StarLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int StarLevel
    {
      get { return _StarLevel; }
      set { _StarLevel = value; }
    }
    private readonly global::System.Collections.Generic.List<BagSlotInfoV1> _GatherSpriteSlot = new global::System.Collections.Generic.List<BagSlotInfoV1>();
    [global::ProtoBuf.ProtoMember(8, Name=@"GatherSpriteSlot", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BagSlotInfoV1> GatherSpriteSlot
    {
      get { return _GatherSpriteSlot; }
    }
  
    private int _TailsManLevel = (int)-1;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"TailsManLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TailsManLevel
    {
      get { return _TailsManLevel; }
      set { _TailsManLevel = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _TalismanAttr = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(10, Name=@"TalismanAttr", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> TalismanAttr
    {
      get { return _TalismanAttr; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BagSlotInfoV1")]
  public partial class BagSlotInfoV1 : global::ProtoBuf.IExtensible
  {
    public BagSlotInfoV1() {}
    
    private int _SlotId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SlotId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SlotId
    {
      get { return _SlotId; }
      set { _SlotId = value; }
    }
    private int _SlotType = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SlotType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SlotType
    {
      get { return _SlotType; }
      set { _SlotType = value; }
    }
    private int _SlotSkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SlotSkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SlotSkillId
    {
      get { return _SlotSkillId; }
      set { _SlotSkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}