//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SkillRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcSyncDataAsk")]
  public partial class SkillRpcSyncDataAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcSyncDataAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcSyncDataReply")]
  public partial class SkillRpcSyncDataReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcSyncDataReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcLearnAsk")]
  public partial class SkillRpcLearnAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcLearnAsk() {}
    
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcLearnReply")]
  public partial class SkillRpcLearnReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcLearnReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcLvUpAsk")]
  public partial class SkillRpcLvUpAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcLvUpAsk() {}
    
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcLvUpReply")]
  public partial class SkillRpcLvUpReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcLvUpReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcChangeShortcutAsk")]
  public partial class SkillRpcChangeShortcutAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcChangeShortcutAsk() {}
    
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private int _Pos = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Pos
    {
      get { return _Pos; }
      set { _Pos = value; }
    }
    private int _Id = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcChangeShortcutReply")]
  public partial class SkillRpcChangeShortcutReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcChangeShortcutReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private int _Pos = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Pos
    {
      get { return _Pos; }
      set { _Pos = value; }
    }
    private int _Id = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcUseShortcutAsk")]
  public partial class SkillRpcUseShortcutAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcUseShortcutAsk() {}
    
    private int _Id = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcUseShortcutReply")]
  public partial class SkillRpcUseShortcutReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcUseShortcutReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _Id = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcOneKeyLvUpAsk")]
  public partial class SkillRpcOneKeyLvUpAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcOneKeyLvUpAsk() {}
    
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcOneKeyLvUpReply")]
  public partial class SkillRpcOneKeyLvUpReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcOneKeyLvUpReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentChangeSkillAsk")]
  public partial class SkillRpcTalentChangeSkillAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentChangeSkillAsk() {}
    
    private int _Index = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentChangeSkillReply")]
  public partial class SkillRpcTalentChangeSkillReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentChangeSkillReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentResetAsk")]
  public partial class SkillRpcTalentResetAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentResetAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentResetReply")]
  public partial class SkillRpcTalentResetReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentResetReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentLvObj")]
  public partial class SkillRpcTalentLvObj : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentLvObj() {}
    
    private int _Index = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private int _Level = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentLvUpAsk")]
  public partial class SkillRpcTalentLvUpAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentLvUpAsk() {}
    
    private readonly global::System.Collections.Generic.List<SkillRpcTalentLvObj> _Talent = new global::System.Collections.Generic.List<SkillRpcTalentLvObj>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Talent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SkillRpcTalentLvObj> Talent
    {
      get { return _Talent; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcTalentLvUpReply")]
  public partial class SkillRpcTalentLvUpReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcTalentLvUpReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcLifeSkillUpAsk")]
  public partial class SkillRpcLifeSkillUpAsk : global::ProtoBuf.IExtensible
  {
    public SkillRpcLifeSkillUpAsk() {}
    
    private int _LifeSkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"LifeSkillId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LifeSkillId
    {
      get { return _LifeSkillId; }
      set { _LifeSkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillRpcLifeSkillUpReply")]
  public partial class SkillRpcLifeSkillUpReply : global::ProtoBuf.IExtensible
  {
    public SkillRpcLifeSkillUpReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}