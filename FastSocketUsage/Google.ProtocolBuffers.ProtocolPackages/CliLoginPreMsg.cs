// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace protocol {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CliLoginPreMsg {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_protocol_CliLoginPreReq__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.CliLoginPreReq, global::protocol.CliLoginPreReq.Builder> internal__static_protocol_CliLoginPreReq__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_protocol_CliLoginPreRsp__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.CliLoginPreRsp, global::protocol.CliLoginPreRsp.Builder> internal__static_protocol_CliLoginPreRsp__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static CliLoginPreMsg() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDbGlMb2dpblByZU1zZy5wcm90bxIIcHJvdG9jb2wiIQoOQ2xpTG9naW5Q", 
            "cmVSZXESDwoHVXNyTmFtZRgBIAIoCSIrCg5DbGlMb2dpblByZVJzcBIMCgRD", 
          "b2RlGAEgAigNEgsKA0tleRgCIAIoCQ=="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_protocol_CliLoginPreReq__Descriptor = Descriptor.MessageTypes[0];
        internal__static_protocol_CliLoginPreReq__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.CliLoginPreReq, global::protocol.CliLoginPreReq.Builder>(internal__static_protocol_CliLoginPreReq__Descriptor,
                new string[] { "UsrName", });
        internal__static_protocol_CliLoginPreRsp__Descriptor = Descriptor.MessageTypes[1];
        internal__static_protocol_CliLoginPreRsp__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.CliLoginPreRsp, global::protocol.CliLoginPreRsp.Builder>(internal__static_protocol_CliLoginPreRsp__Descriptor,
                new string[] { "Code", "Key", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CliLoginPreReq : pb::GeneratedMessage<CliLoginPreReq, CliLoginPreReq.Builder> {
    private CliLoginPreReq() { }
    private static readonly CliLoginPreReq defaultInstance = new CliLoginPreReq().MakeReadOnly();
    private static readonly string[] _cliLoginPreReqFieldNames = new string[] { "UsrName" };
    private static readonly uint[] _cliLoginPreReqFieldTags = new uint[] { 10 };
    public static CliLoginPreReq DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override CliLoginPreReq DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override CliLoginPreReq ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.CliLoginPreMsg.internal__static_protocol_CliLoginPreReq__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<CliLoginPreReq, CliLoginPreReq.Builder> InternalFieldAccessors {
      get { return global::protocol.CliLoginPreMsg.internal__static_protocol_CliLoginPreReq__FieldAccessorTable; }
    }
    
    public const int UsrNameFieldNumber = 1;
    private bool hasUsrName;
    private string usrName_ = "";
    public bool HasUsrName {
      get { return hasUsrName; }
    }
    public string UsrName {
      get { return usrName_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasUsrName) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _cliLoginPreReqFieldNames;
      if (hasUsrName) {
        output.WriteString(1, field_names[0], UsrName);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasUsrName) {
        size += pb::CodedOutputStream.ComputeStringSize(1, UsrName);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static CliLoginPreReq ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static CliLoginPreReq ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static CliLoginPreReq ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CliLoginPreReq ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private CliLoginPreReq MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(CliLoginPreReq prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<CliLoginPreReq, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(CliLoginPreReq cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private CliLoginPreReq result;
      
      private CliLoginPreReq PrepareBuilder() {
        if (resultIsReadOnly) {
          CliLoginPreReq original = result;
          result = new CliLoginPreReq();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override CliLoginPreReq MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::protocol.CliLoginPreReq.Descriptor; }
      }
      
      public override CliLoginPreReq DefaultInstanceForType {
        get { return global::protocol.CliLoginPreReq.DefaultInstance; }
      }
      
      public override CliLoginPreReq BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is CliLoginPreReq) {
          return MergeFrom((CliLoginPreReq) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(CliLoginPreReq other) {
        if (other == global::protocol.CliLoginPreReq.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasUsrName) {
          UsrName = other.UsrName;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_cliLoginPreReqFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _cliLoginPreReqFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasUsrName = input.ReadString(ref result.usrName_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasUsrName {
        get { return result.hasUsrName; }
      }
      public string UsrName {
        get { return result.UsrName; }
        set { SetUsrName(value); }
      }
      public Builder SetUsrName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasUsrName = true;
        result.usrName_ = value;
        return this;
      }
      public Builder ClearUsrName() {
        PrepareBuilder();
        result.hasUsrName = false;
        result.usrName_ = "";
        return this;
      }
    }
    static CliLoginPreReq() {
      object.ReferenceEquals(global::protocol.CliLoginPreMsg.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CliLoginPreRsp : pb::GeneratedMessage<CliLoginPreRsp, CliLoginPreRsp.Builder> {
    private CliLoginPreRsp() { }
    private static readonly CliLoginPreRsp defaultInstance = new CliLoginPreRsp().MakeReadOnly();
    private static readonly string[] _cliLoginPreRspFieldNames = new string[] { "Code", "Key" };
    private static readonly uint[] _cliLoginPreRspFieldTags = new uint[] { 8, 18 };
    public static CliLoginPreRsp DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override CliLoginPreRsp DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override CliLoginPreRsp ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.CliLoginPreMsg.internal__static_protocol_CliLoginPreRsp__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<CliLoginPreRsp, CliLoginPreRsp.Builder> InternalFieldAccessors {
      get { return global::protocol.CliLoginPreMsg.internal__static_protocol_CliLoginPreRsp__FieldAccessorTable; }
    }
    
    public const int CodeFieldNumber = 1;
    private bool hasCode;
    private uint code_;
    public bool HasCode {
      get { return hasCode; }
    }
    [global::System.CLSCompliant(false)]
    public uint Code {
      get { return code_; }
    }
    
    public const int KeyFieldNumber = 2;
    private bool hasKey;
    private string key_ = "";
    public bool HasKey {
      get { return hasKey; }
    }
    public string Key {
      get { return key_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasCode) return false;
        if (!hasKey) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _cliLoginPreRspFieldNames;
      if (hasCode) {
        output.WriteUInt32(1, field_names[0], Code);
      }
      if (hasKey) {
        output.WriteString(2, field_names[1], Key);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasCode) {
        size += pb::CodedOutputStream.ComputeUInt32Size(1, Code);
      }
      if (hasKey) {
        size += pb::CodedOutputStream.ComputeStringSize(2, Key);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static CliLoginPreRsp ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static CliLoginPreRsp ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static CliLoginPreRsp ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CliLoginPreRsp ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private CliLoginPreRsp MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(CliLoginPreRsp prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<CliLoginPreRsp, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(CliLoginPreRsp cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private CliLoginPreRsp result;
      
      private CliLoginPreRsp PrepareBuilder() {
        if (resultIsReadOnly) {
          CliLoginPreRsp original = result;
          result = new CliLoginPreRsp();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override CliLoginPreRsp MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::protocol.CliLoginPreRsp.Descriptor; }
      }
      
      public override CliLoginPreRsp DefaultInstanceForType {
        get { return global::protocol.CliLoginPreRsp.DefaultInstance; }
      }
      
      public override CliLoginPreRsp BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is CliLoginPreRsp) {
          return MergeFrom((CliLoginPreRsp) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(CliLoginPreRsp other) {
        if (other == global::protocol.CliLoginPreRsp.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasCode) {
          Code = other.Code;
        }
        if (other.HasKey) {
          Key = other.Key;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_cliLoginPreRspFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _cliLoginPreRspFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasCode = input.ReadUInt32(ref result.code_);
              break;
            }
            case 18: {
              result.hasKey = input.ReadString(ref result.key_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasCode {
        get { return result.hasCode; }
      }
      [global::System.CLSCompliant(false)]
      public uint Code {
        get { return result.Code; }
        set { SetCode(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetCode(uint value) {
        PrepareBuilder();
        result.hasCode = true;
        result.code_ = value;
        return this;
      }
      public Builder ClearCode() {
        PrepareBuilder();
        result.hasCode = false;
        result.code_ = 0;
        return this;
      }
      
      public bool HasKey {
        get { return result.hasKey; }
      }
      public string Key {
        get { return result.Key; }
        set { SetKey(value); }
      }
      public Builder SetKey(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }
      public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = "";
        return this;
      }
    }
    static CliLoginPreRsp() {
      object.ReferenceEquals(global::protocol.CliLoginPreMsg.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code