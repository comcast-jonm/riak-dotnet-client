//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: riak_ts.proto
// Note: requires additional types generated from: riak.proto
namespace RiakClient.Messages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsQueryReq")]
  public partial class TsQueryReq : global::ProtoBuf.IExtensible
  {
    public TsQueryReq() {}
    
    private TsInterpolation _query = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"query", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TsInterpolation query
    {
      get { return _query; }
      set { _query = value; }
    }
    private bool? _stream;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stream", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool stream
    {
      get { return _stream?? (bool)false; }
      set { _stream = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool streamSpecified
    {
      get { return this._stream != null; }
      set { if (value == (this._stream== null)) this._stream = value ? this.stream : (bool?)null; }
    }
    private bool ShouldSerializestream() { return streamSpecified; }
    private void Resetstream() { streamSpecified = false; }
    
    private byte[] _cover_context;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cover_context", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] cover_context
    {
      get { return _cover_context?? null; }
      set { _cover_context = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool cover_contextSpecified
    {
      get { return this._cover_context != null; }
      set { if (value == (this._cover_context== null)) this._cover_context = value ? this.cover_context : (byte[])null; }
    }
    private bool ShouldSerializecover_context() { return cover_contextSpecified; }
    private void Resetcover_context() { cover_contextSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsQueryResp")]
  public partial class TsQueryResp : global::ProtoBuf.IExtensible
  {
    public TsQueryResp() {}
    
    private readonly global::System.Collections.Generic.List<TsColumnDescription> _columns = new global::System.Collections.Generic.List<TsColumnDescription>();
    [global::ProtoBuf.ProtoMember(1, Name=@"columns", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsColumnDescription> columns
    {
      get { return _columns; }
    }
  
    private readonly global::System.Collections.Generic.List<TsRow> _rows = new global::System.Collections.Generic.List<TsRow>();
    [global::ProtoBuf.ProtoMember(2, Name=@"rows", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsRow> rows
    {
      get { return _rows; }
    }
  
    private bool? _done;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool done
    {
      get { return _done?? (bool)true; }
      set { _done = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool doneSpecified
    {
      get { return this._done != null; }
      set { if (value == (this._done== null)) this._done = value ? this.done : (bool?)null; }
    }
    private bool ShouldSerializedone() { return doneSpecified; }
    private void Resetdone() { doneSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsGetReq")]
  public partial class TsGetReq : global::ProtoBuf.IExtensible
  {
    public TsGetReq() {}
    
    private byte[] _table;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] table
    {
      get { return _table; }
      set { _table = value; }
    }
    private readonly global::System.Collections.Generic.List<TsCell> _key = new global::System.Collections.Generic.List<TsCell>();
    [global::ProtoBuf.ProtoMember(2, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsCell> key
    {
      get { return _key; }
    }
  
    private uint? _timeout;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timeout
    {
      get { return _timeout?? default(uint); }
      set { _timeout = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timeoutSpecified
    {
      get { return this._timeout != null; }
      set { if (value == (this._timeout== null)) this._timeout = value ? this.timeout : (uint?)null; }
    }
    private bool ShouldSerializetimeout() { return timeoutSpecified; }
    private void Resettimeout() { timeoutSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsGetResp")]
  public partial class TsGetResp : global::ProtoBuf.IExtensible
  {
    public TsGetResp() {}
    
    private readonly global::System.Collections.Generic.List<TsColumnDescription> _columns = new global::System.Collections.Generic.List<TsColumnDescription>();
    [global::ProtoBuf.ProtoMember(1, Name=@"columns", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsColumnDescription> columns
    {
      get { return _columns; }
    }
  
    private readonly global::System.Collections.Generic.List<TsRow> _rows = new global::System.Collections.Generic.List<TsRow>();
    [global::ProtoBuf.ProtoMember(2, Name=@"rows", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsRow> rows
    {
      get { return _rows; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsPutReq")]
  public partial class TsPutReq : global::ProtoBuf.IExtensible
  {
    public TsPutReq() {}
    
    private byte[] _table;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] table
    {
      get { return _table; }
      set { _table = value; }
    }
    private readonly global::System.Collections.Generic.List<TsColumnDescription> _columns = new global::System.Collections.Generic.List<TsColumnDescription>();
    [global::ProtoBuf.ProtoMember(2, Name=@"columns", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsColumnDescription> columns
    {
      get { return _columns; }
    }
  
    private readonly global::System.Collections.Generic.List<TsRow> _rows = new global::System.Collections.Generic.List<TsRow>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rows", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsRow> rows
    {
      get { return _rows; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsPutResp")]
  public partial class TsPutResp : global::ProtoBuf.IExtensible
  {
    public TsPutResp() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsDelReq")]
  public partial class TsDelReq : global::ProtoBuf.IExtensible
  {
    public TsDelReq() {}
    
    private byte[] _table;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] table
    {
      get { return _table; }
      set { _table = value; }
    }
    private readonly global::System.Collections.Generic.List<TsCell> _key = new global::System.Collections.Generic.List<TsCell>();
    [global::ProtoBuf.ProtoMember(2, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsCell> key
    {
      get { return _key; }
    }
  
    private byte[] _vclock;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"vclock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] vclock
    {
      get { return _vclock?? null; }
      set { _vclock = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool vclockSpecified
    {
      get { return this._vclock != null; }
      set { if (value == (this._vclock== null)) this._vclock = value ? this.vclock : (byte[])null; }
    }
    private bool ShouldSerializevclock() { return vclockSpecified; }
    private void Resetvclock() { vclockSpecified = false; }
    
    private uint? _timeout;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timeout
    {
      get { return _timeout?? default(uint); }
      set { _timeout = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timeoutSpecified
    {
      get { return this._timeout != null; }
      set { if (value == (this._timeout== null)) this._timeout = value ? this.timeout : (uint?)null; }
    }
    private bool ShouldSerializetimeout() { return timeoutSpecified; }
    private void Resettimeout() { timeoutSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsDelResp")]
  public partial class TsDelResp : global::ProtoBuf.IExtensible
  {
    public TsDelResp() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsInterpolation")]
  public partial class TsInterpolation : global::ProtoBuf.IExtensible
  {
    public TsInterpolation() {}
    
    private byte[] _base;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"base", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] @base
    {
      get { return _base; }
      set { _base = value; }
    }
    private readonly global::System.Collections.Generic.List<RpbPair> _interpolations = new global::System.Collections.Generic.List<RpbPair>();
    [global::ProtoBuf.ProtoMember(2, Name=@"interpolations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbPair> interpolations
    {
      get { return _interpolations; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsColumnDescription")]
  public partial class TsColumnDescription : global::ProtoBuf.IExtensible
  {
    public TsColumnDescription() {}
    
    private byte[] _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] name
    {
      get { return _name; }
      set { _name = value; }
    }
    private TsColumnType _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public TsColumnType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsRow")]
  public partial class TsRow : global::ProtoBuf.IExtensible
  {
    public TsRow() {}
    
    private readonly global::System.Collections.Generic.List<TsCell> _cells = new global::System.Collections.Generic.List<TsCell>();
    [global::ProtoBuf.ProtoMember(1, Name=@"cells", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsCell> cells
    {
      get { return _cells; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsCell")]
  public partial class TsCell : global::ProtoBuf.IExtensible
  {
    public TsCell() {}
    
    private byte[] _varchar_value;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"varchar_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] varchar_value
    {
      get { return _varchar_value?? null; }
      set { _varchar_value = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool varchar_valueSpecified
    {
      get { return this._varchar_value != null; }
      set { if (value == (this._varchar_value== null)) this._varchar_value = value ? this.varchar_value : (byte[])null; }
    }
    private bool ShouldSerializevarchar_value() { return varchar_valueSpecified; }
    private void Resetvarchar_value() { varchar_valueSpecified = false; }
    
    private long? _sint64_value;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sint64_value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long sint64_value
    {
      get { return _sint64_value?? default(long); }
      set { _sint64_value = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool sint64_valueSpecified
    {
      get { return this._sint64_value != null; }
      set { if (value == (this._sint64_value== null)) this._sint64_value = value ? this.sint64_value : (long?)null; }
    }
    private bool ShouldSerializesint64_value() { return sint64_valueSpecified; }
    private void Resetsint64_value() { sint64_valueSpecified = false; }
    
    private long? _timestamp_value;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"timestamp_value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long timestamp_value
    {
      get { return _timestamp_value?? default(long); }
      set { _timestamp_value = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timestamp_valueSpecified
    {
      get { return this._timestamp_value != null; }
      set { if (value == (this._timestamp_value== null)) this._timestamp_value = value ? this.timestamp_value : (long?)null; }
    }
    private bool ShouldSerializetimestamp_value() { return timestamp_valueSpecified; }
    private void Resettimestamp_value() { timestamp_valueSpecified = false; }
    
    private bool? _boolean_value;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"boolean_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool boolean_value
    {
      get { return _boolean_value?? default(bool); }
      set { _boolean_value = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool boolean_valueSpecified
    {
      get { return this._boolean_value != null; }
      set { if (value == (this._boolean_value== null)) this._boolean_value = value ? this.boolean_value : (bool?)null; }
    }
    private bool ShouldSerializeboolean_value() { return boolean_valueSpecified; }
    private void Resetboolean_value() { boolean_valueSpecified = false; }
    
    private double? _double_value;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"double_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double double_value
    {
      get { return _double_value?? default(double); }
      set { _double_value = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool double_valueSpecified
    {
      get { return this._double_value != null; }
      set { if (value == (this._double_value== null)) this._double_value = value ? this.double_value : (double?)null; }
    }
    private bool ShouldSerializedouble_value() { return double_valueSpecified; }
    private void Resetdouble_value() { double_valueSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsListKeysReq")]
  public partial class TsListKeysReq : global::ProtoBuf.IExtensible
  {
    public TsListKeysReq() {}
    
    private byte[] _table;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] table
    {
      get { return _table; }
      set { _table = value; }
    }
    private uint? _timeout;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timeout
    {
      get { return _timeout?? default(uint); }
      set { _timeout = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timeoutSpecified
    {
      get { return this._timeout != null; }
      set { if (value == (this._timeout== null)) this._timeout = value ? this.timeout : (uint?)null; }
    }
    private bool ShouldSerializetimeout() { return timeoutSpecified; }
    private void Resettimeout() { timeoutSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsListKeysResp")]
  public partial class TsListKeysResp : global::ProtoBuf.IExtensible
  {
    public TsListKeysResp() {}
    
    private readonly global::System.Collections.Generic.List<TsRow> _keys = new global::System.Collections.Generic.List<TsRow>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsRow> keys
    {
      get { return _keys; }
    }
  
    private bool? _done;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool done
    {
      get { return _done?? default(bool); }
      set { _done = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool doneSpecified
    {
      get { return this._done != null; }
      set { if (value == (this._done== null)) this._done = value ? this.done : (bool?)null; }
    }
    private bool ShouldSerializedone() { return doneSpecified; }
    private void Resetdone() { doneSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsCoverageReq")]
  public partial class TsCoverageReq : global::ProtoBuf.IExtensible
  {
    public TsCoverageReq() {}
    
    private TsInterpolation _query = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"query", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TsInterpolation query
    {
      get { return _query; }
      set { _query = value; }
    }
    private byte[] _table;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] table
    {
      get { return _table; }
      set { _table = value; }
    }
    private byte[] _replace_cover;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"replace_cover", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] replace_cover
    {
      get { return _replace_cover?? null; }
      set { _replace_cover = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool replace_coverSpecified
    {
      get { return this._replace_cover != null; }
      set { if (value == (this._replace_cover== null)) this._replace_cover = value ? this.replace_cover : (byte[])null; }
    }
    private bool ShouldSerializereplace_cover() { return replace_coverSpecified; }
    private void Resetreplace_cover() { replace_coverSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<byte[]> _unavailable_cover = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(4, Name=@"unavailable_cover", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> unavailable_cover
    {
      get { return _unavailable_cover; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsCoverageResp")]
  public partial class TsCoverageResp : global::ProtoBuf.IExtensible
  {
    public TsCoverageResp() {}
    
    private readonly global::System.Collections.Generic.List<TsCoverageEntry> _entries = new global::System.Collections.Generic.List<TsCoverageEntry>();
    [global::ProtoBuf.ProtoMember(1, Name=@"entries", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TsCoverageEntry> entries
    {
      get { return _entries; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsCoverageEntry")]
  public partial class TsCoverageEntry : global::ProtoBuf.IExtensible
  {
    public TsCoverageEntry() {}
    
    private byte[] _ip;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] ip
    {
      get { return _ip; }
      set { _ip = value; }
    }
    private uint _port;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint port
    {
      get { return _port; }
      set { _port = value; }
    }
    private byte[] _cover_context;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"cover_context", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] cover_context
    {
      get { return _cover_context; }
      set { _cover_context = value; }
    }
    private TsRange _range = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"range", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TsRange range
    {
      get { return _range; }
      set { _range = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TsRange")]
  public partial class TsRange : global::ProtoBuf.IExtensible
  {
    public TsRange() {}
    
    private byte[] _field_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"field_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] field_name
    {
      get { return _field_name; }
      set { _field_name = value; }
    }
    private long _lower_bound;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"lower_bound", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long lower_bound
    {
      get { return _lower_bound; }
      set { _lower_bound = value; }
    }
    private bool _lower_bound_inclusive;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"lower_bound_inclusive", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool lower_bound_inclusive
    {
      get { return _lower_bound_inclusive; }
      set { _lower_bound_inclusive = value; }
    }
    private long _upper_bound;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"upper_bound", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long upper_bound
    {
      get { return _upper_bound; }
      set { _upper_bound = value; }
    }
    private bool _upper_bound_inclusive;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"upper_bound_inclusive", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool upper_bound_inclusive
    {
      get { return _upper_bound_inclusive; }
      set { _upper_bound_inclusive = value; }
    }
    private byte[] _desc;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"TsColumnType")]
    public enum TsColumnType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"VARCHAR", Value=0)]
      VARCHAR = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SINT64", Value=1)]
      SINT64 = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOUBLE", Value=2)]
      DOUBLE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TIMESTAMP", Value=3)]
      TIMESTAMP = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOOLEAN", Value=4)]
      BOOLEAN = 4
    }
  
}