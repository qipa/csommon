//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FriendV1Data.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendFriendObjV1")]
  public partial class FriendFriendObjV1 : global::ProtoBuf.IExtensible
  {
    public FriendFriendObjV1() {}
    
    private long _UserId = (long)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long UserId
    {
      get { return _UserId; }
      set { _UserId = value; }
    }
    private string _UserName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UserName
    {
      get { return _UserName; }
      set { _UserName = value; }
    }
    private int _Level = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private int _Prof = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Prof", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Prof
    {
      get { return _Prof; }
      set { _Prof = value; }
    }
    private string _Signature = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Signature
    {
      get { return _Signature; }
      set { _Signature = value; }
    }
    private int _TeamId = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"TeamId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TeamId
    {
      get { return _TeamId; }
      set { _TeamId = value; }
    }
    private int _TeamMemberNum = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TeamMemberNum", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int TeamMemberNum
    {
      get { return _TeamMemberNum; }
      set { _TeamMemberNum = value; }
    }
    private bool _Online = (bool)false;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Online", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool Online
    {
      get { return _Online; }
      set { _Online = value; }
    }
    private int _GoodFeeling = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"GoodFeeling", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int GoodFeeling
    {
      get { return _GoodFeeling; }
      set { _GoodFeeling = value; }
    }
    private int _GuildId = (int)-1;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"GuildId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int GuildId
    {
      get { return _GuildId; }
      set { _GuildId = value; }
    }
    private string _GuildName = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"GuildName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string GuildName
    {
      get { return _GuildName; }
      set { _GuildName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendFriendDataV1")]
  public partial class FriendFriendDataV1 : global::ProtoBuf.IExtensible
  {
    public FriendFriendDataV1() {}
    
    private readonly global::System.Collections.Generic.List<FriendFriendObjV1> _FriendList = new global::System.Collections.Generic.List<FriendFriendObjV1>();
    [global::ProtoBuf.ProtoMember(1, Name=@"FriendList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FriendFriendObjV1> FriendList
    {
      get { return _FriendList; }
    }
  
    private readonly global::System.Collections.Generic.List<FriendFriendObjV1> _BlackList = new global::System.Collections.Generic.List<FriendFriendObjV1>();
    [global::ProtoBuf.ProtoMember(2, Name=@"BlackList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FriendFriendObjV1> BlackList
    {
      get { return _BlackList; }
    }
  
    private readonly global::System.Collections.Generic.List<FriendFriendObjV1> _ContactsList = new global::System.Collections.Generic.List<FriendFriendObjV1>();
    [global::ProtoBuf.ProtoMember(3, Name=@"ContactsList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FriendFriendObjV1> ContactsList
    {
      get { return _ContactsList; }
    }
  
    private readonly global::System.Collections.Generic.List<long> _StrangerFriendList = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(4, Name=@"StrangerFriendList", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<long> StrangerFriendList
    {
      get { return _StrangerFriendList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}