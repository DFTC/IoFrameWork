// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace protocol {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class VersionMsg {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_protocol_VersionReq__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.VersionReq, global::protocol.VersionReq.Builder> internal__static_protocol_VersionReq__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_protocol_VersionRsp__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.VersionRsp, global::protocol.VersionRsp.Builder> internal__static_protocol_VersionRsp__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static VersionMsg() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBWZXJzaW9uTXNnLnByb3RvEghwcm90b2NvbBoRSWRlbnRpdHlNc2cucHJv", 
            "dG8iZwoKVmVyc2lvblJlcRInCgRJZGVuGAEgAigLMhkucHJvdG9jb2wuSWRl", 
            "bnRpdHlJbmZvTXNnEjAKBFR5cGUYAiABKA4yFS5wcm90b2NvbC5WZXJzaW9u", 
            "VHlwZToLQUxMX1ZFUlNJT04iVQoKVmVyc2lvblJzcBInCgRJZGVuGAEgAigL", 
            "MhkucHJvdG9jb2wuSWRlbnRpdHlJbmZvTXNnEgwKBENvZGUYAiACKA0SEAoG", 
            "UmVzdWx0GAMgASgJOgAqVQoLVmVyc2lvblR5cGUSDwoLQUxMX1ZFUlNJT04Q", 
            "ABITCg9BTkRST0lEX1ZFUlNJT04QARIPCgtBUFBfVkVSU0lPThACEg8KC1ZS", 
          "UF9WRVJTSU9OEAM="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_protocol_VersionReq__Descriptor = Descriptor.MessageTypes[0];
        internal__static_protocol_VersionReq__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.VersionReq, global::protocol.VersionReq.Builder>(internal__static_protocol_VersionReq__Descriptor,
                new string[] { "Iden", "Type", });
        internal__static_protocol_VersionRsp__Descriptor = Descriptor.MessageTypes[1];
        internal__static_protocol_VersionRsp__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.VersionRsp, global::protocol.VersionRsp.Builder>(internal__static_protocol_VersionRsp__Descriptor,
                new string[] { "Iden", "Code", "Result", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::protocol.IdentityMsg.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Enums
  public enum VersionType {
    ALL_VERSION = 0,
    ANDROID_VERSION = 1,
    APP_VERSION = 2,
    VRP_VERSION = 3,
  }
  
  #endregion
  
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VersionReq : pb::GeneratedMessage<VersionReq, VersionReq.Builder> {
    private VersionReq() { }
    private static readonly VersionReq defaultInstance = new VersionReq().MakeReadOnly();
    private static readonly string[] _versionReqFieldNames = new string[] { "Iden", "Type" };
    private static readonly uint[] _versionReqFieldTags = new uint[] { 10, 16 };
    public static VersionReq DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override VersionReq DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override VersionReq ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.VersionMsg.internal__static_protocol_VersionReq__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<VersionReq, VersionReq.Builder> InternalFieldAccessors {
      get { return global::protocol.VersionMsg.internal__static_protocol_VersionReq__FieldAccessorTable; }
    }
    
    public const int IdenFieldNumber = 1;
    private bool hasIden;
    private global::protocol.IdentityInfoMsg iden_;
    public bool HasIden {
      get { return hasIden; }
    }
    public global::protocol.IdentityInfoMsg Iden {
      get { return iden_ ?? global::protocol.IdentityInfoMsg.DefaultInstance; }
    }
    
    public const int TypeFieldNumber = 2;
    private bool hasType;
    private global::protocol.VersionType type_ = global::protocol.VersionType.ALL_VERSION;
    public bool HasType {
      get { return hasType; }
    }
    public global::protocol.VersionType Type {
      get { return type_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasIden) return false;
        if (!Iden.IsInitialized) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _versionReqFieldNames;
      if (hasIden) {
        output.WriteMessage(1, field_names[0], Iden);
      }
      if (hasType) {
        output.WriteEnum(2, field_names[1], (int) Type, Type);
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
      if (hasIden) {
        size += pb::CodedOutputStream.ComputeMessageSize(1, Iden);
      }
      if (hasType) {
        size += pb::CodedOutputStream.ComputeEnumSize(2, (int) Type);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static VersionReq ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static VersionReq ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static VersionReq ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static VersionReq ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static VersionReq ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static VersionReq ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static VersionReq ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static VersionReq ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static VersionReq ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static VersionReq ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private VersionReq MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(VersionReq prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<VersionReq, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(VersionReq cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private VersionReq result;
      
      private VersionReq PrepareBuilder() {
        if (resultIsReadOnly) {
          VersionReq original = result;
          result = new VersionReq();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override VersionReq MessageBeingBuilt {
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
        get { return global::protocol.VersionReq.Descriptor; }
      }
      
      public override VersionReq DefaultInstanceForType {
        get { return global::protocol.VersionReq.DefaultInstance; }
      }
      
      public override VersionReq BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is VersionReq) {
          return MergeFrom((VersionReq) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(VersionReq other) {
        if (other == global::protocol.VersionReq.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasIden) {
          MergeIden(other.Iden);
        }
        if (other.HasType) {
          Type = other.Type;
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
            int field_ordinal = global::System.Array.BinarySearch(_versionReqFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _versionReqFieldTags[field_ordinal];
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
              global::protocol.IdentityInfoMsg.Builder subBuilder = global::protocol.IdentityInfoMsg.CreateBuilder();
              if (result.hasIden) {
                subBuilder.MergeFrom(Iden);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Iden = subBuilder.BuildPartial();
              break;
            }
            case 16: {
              object unknown;
              if(input.ReadEnum(ref result.type_, out unknown)) {
                result.hasType = true;
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(2, (ulong)(int)unknown);
              }
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasIden {
       get { return result.hasIden; }
      }
      public global::protocol.IdentityInfoMsg Iden {
        get { return result.Iden; }
        set { SetIden(value); }
      }
      public Builder SetIden(global::protocol.IdentityInfoMsg value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasIden = true;
        result.iden_ = value;
        return this;
      }
      public Builder SetIden(global::protocol.IdentityInfoMsg.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasIden = true;
        result.iden_ = builderForValue.Build();
        return this;
      }
      public Builder MergeIden(global::protocol.IdentityInfoMsg value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasIden &&
            result.iden_ != global::protocol.IdentityInfoMsg.DefaultInstance) {
            result.iden_ = global::protocol.IdentityInfoMsg.CreateBuilder(result.iden_).MergeFrom(value).BuildPartial();
        } else {
          result.iden_ = value;
        }
        result.hasIden = true;
        return this;
      }
      public Builder ClearIden() {
        PrepareBuilder();
        result.hasIden = false;
        result.iden_ = null;
        return this;
      }
      
      public bool HasType {
       get { return result.hasType; }
      }
      public global::protocol.VersionType Type {
        get { return result.Type; }
        set { SetType(value); }
      }
      public Builder SetType(global::protocol.VersionType value) {
        PrepareBuilder();
        result.hasType = true;
        result.type_ = value;
        return this;
      }
      public Builder ClearType() {
        PrepareBuilder();
        result.hasType = false;
        result.type_ = global::protocol.VersionType.ALL_VERSION;
        return this;
      }
    }
    static VersionReq() {
      object.ReferenceEquals(global::protocol.VersionMsg.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VersionRsp : pb::GeneratedMessage<VersionRsp, VersionRsp.Builder> {
    private VersionRsp() { }
    private static readonly VersionRsp defaultInstance = new VersionRsp().MakeReadOnly();
    private static readonly string[] _versionRspFieldNames = new string[] { "Code", "Iden", "Result" };
    private static readonly uint[] _versionRspFieldTags = new uint[] { 16, 10, 26 };
    public static VersionRsp DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override VersionRsp DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override VersionRsp ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.VersionMsg.internal__static_protocol_VersionRsp__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<VersionRsp, VersionRsp.Builder> InternalFieldAccessors {
      get { return global::protocol.VersionMsg.internal__static_protocol_VersionRsp__FieldAccessorTable; }
    }
    
    public const int IdenFieldNumber = 1;
    private bool hasIden;
    private global::protocol.IdentityInfoMsg iden_;
    public bool HasIden {
      get { return hasIden; }
    }
    public global::protocol.IdentityInfoMsg Iden {
      get { return iden_ ?? global::protocol.IdentityInfoMsg.DefaultInstance; }
    }
    
    public const int CodeFieldNumber = 2;
    private bool hasCode;
    private uint code_;
    public bool HasCode {
      get { return hasCode; }
    }
    [global::System.CLSCompliant(false)]
    public uint Code {
      get { return code_; }
    }
    
    public const int ResultFieldNumber = 3;
    private bool hasResult;
    private string result_ = "";
    public bool HasResult {
      get { return hasResult; }
    }
    public string Result {
      get { return result_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasIden) return false;
        if (!hasCode) return false;
        if (!Iden.IsInitialized) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _versionRspFieldNames;
      if (hasIden) {
        output.WriteMessage(1, field_names[1], Iden);
      }
      if (hasCode) {
        output.WriteUInt32(2, field_names[0], Code);
      }
      if (hasResult) {
        output.WriteString(3, field_names[2], Result);
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
      if (hasIden) {
        size += pb::CodedOutputStream.ComputeMessageSize(1, Iden);
      }
      if (hasCode) {
        size += pb::CodedOutputStream.ComputeUInt32Size(2, Code);
      }
      if (hasResult) {
        size += pb::CodedOutputStream.ComputeStringSize(3, Result);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static VersionRsp ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static VersionRsp ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static VersionRsp ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static VersionRsp ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static VersionRsp ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static VersionRsp ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static VersionRsp ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static VersionRsp ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static VersionRsp ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static VersionRsp ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private VersionRsp MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(VersionRsp prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<VersionRsp, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(VersionRsp cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private VersionRsp result;
      
      private VersionRsp PrepareBuilder() {
        if (resultIsReadOnly) {
          VersionRsp original = result;
          result = new VersionRsp();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override VersionRsp MessageBeingBuilt {
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
        get { return global::protocol.VersionRsp.Descriptor; }
      }
      
      public override VersionRsp DefaultInstanceForType {
        get { return global::protocol.VersionRsp.DefaultInstance; }
      }
      
      public override VersionRsp BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is VersionRsp) {
          return MergeFrom((VersionRsp) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(VersionRsp other) {
        if (other == global::protocol.VersionRsp.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasIden) {
          MergeIden(other.Iden);
        }
        if (other.HasCode) {
          Code = other.Code;
        }
        if (other.HasResult) {
          Result = other.Result;
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
            int field_ordinal = global::System.Array.BinarySearch(_versionRspFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _versionRspFieldTags[field_ordinal];
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
              global::protocol.IdentityInfoMsg.Builder subBuilder = global::protocol.IdentityInfoMsg.CreateBuilder();
              if (result.hasIden) {
                subBuilder.MergeFrom(Iden);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Iden = subBuilder.BuildPartial();
              break;
            }
            case 16: {
              result.hasCode = input.ReadUInt32(ref result.code_);
              break;
            }
            case 26: {
              result.hasResult = input.ReadString(ref result.result_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasIden {
       get { return result.hasIden; }
      }
      public global::protocol.IdentityInfoMsg Iden {
        get { return result.Iden; }
        set { SetIden(value); }
      }
      public Builder SetIden(global::protocol.IdentityInfoMsg value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasIden = true;
        result.iden_ = value;
        return this;
      }
      public Builder SetIden(global::protocol.IdentityInfoMsg.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasIden = true;
        result.iden_ = builderForValue.Build();
        return this;
      }
      public Builder MergeIden(global::protocol.IdentityInfoMsg value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasIden &&
            result.iden_ != global::protocol.IdentityInfoMsg.DefaultInstance) {
            result.iden_ = global::protocol.IdentityInfoMsg.CreateBuilder(result.iden_).MergeFrom(value).BuildPartial();
        } else {
          result.iden_ = value;
        }
        result.hasIden = true;
        return this;
      }
      public Builder ClearIden() {
        PrepareBuilder();
        result.hasIden = false;
        result.iden_ = null;
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
      
      public bool HasResult {
        get { return result.hasResult; }
      }
      public string Result {
        get { return result.Result; }
        set { SetResult(value); }
      }
      public Builder SetResult(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasResult = true;
        result.result_ = value;
        return this;
      }
      public Builder ClearResult() {
        PrepareBuilder();
        result.hasResult = false;
        result.result_ = "";
        return this;
      }
    }
    static VersionRsp() {
      object.ReferenceEquals(global::protocol.VersionMsg.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
