// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace protocol {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UdpMsg {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_protocol_UdpData__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.UdpData, global::protocol.UdpData.Builder> internal__static_protocol_UdpData__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static UdpMsg() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxVZHBNc2cucHJvdG8SCHByb3RvY29sGhFJZGVudGl0eU1zZy5wcm90byKD", 
            "AQoHVWRwRGF0YRIqCgRJZGVuGAEgAigLMhwucHJvdG9jb2wuSWRlbnRpdHlJ", 
            "bmZvQ2xpTXNnEhIKB0NoYW5uZWwYAiABKA06ATASEwoIRGF0YVR5cGUYAyAB", 
          "KA06ATASEwoIRGF0YVNpemUYBCABKA06ATASDgoERGF0YRgFIAEoDDoA"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_protocol_UdpData__Descriptor = Descriptor.MessageTypes[0];
        internal__static_protocol_UdpData__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.UdpData, global::protocol.UdpData.Builder>(internal__static_protocol_UdpData__Descriptor,
                new string[] { "Iden", "Channel", "DataType", "DataSize", "Data", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::protocol.IdentityMsg.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UdpData : pb::GeneratedMessage<UdpData, UdpData.Builder> {
    private UdpData() { }
    private static readonly UdpData defaultInstance = new UdpData().MakeReadOnly();
    private static readonly string[] _udpDataFieldNames = new string[] { "Channel", "Data", "DataSize", "DataType", "Iden" };
    private static readonly uint[] _udpDataFieldTags = new uint[] { 16, 42, 32, 24, 10 };
    public static UdpData DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override UdpData DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override UdpData ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.UdpMsg.internal__static_protocol_UdpData__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<UdpData, UdpData.Builder> InternalFieldAccessors {
      get { return global::protocol.UdpMsg.internal__static_protocol_UdpData__FieldAccessorTable; }
    }
    
    public const int IdenFieldNumber = 1;
    private bool hasIden;
    private global::protocol.IdentityInfoCliMsg iden_;
    public bool HasIden {
      get { return hasIden; }
    }
    public global::protocol.IdentityInfoCliMsg Iden {
      get { return iden_ ?? global::protocol.IdentityInfoCliMsg.DefaultInstance; }
    }
    
    public const int ChannelFieldNumber = 2;
    private bool hasChannel;
    private uint channel_;
    public bool HasChannel {
      get { return hasChannel; }
    }
    [global::System.CLSCompliant(false)]
    public uint Channel {
      get { return channel_; }
    }
    
    public const int DataTypeFieldNumber = 3;
    private bool hasDataType;
    private uint dataType_;
    public bool HasDataType {
      get { return hasDataType; }
    }
    [global::System.CLSCompliant(false)]
    public uint DataType {
      get { return dataType_; }
    }
    
    public const int DataSizeFieldNumber = 4;
    private bool hasDataSize;
    private uint dataSize_;
    public bool HasDataSize {
      get { return hasDataSize; }
    }
    [global::System.CLSCompliant(false)]
    public uint DataSize {
      get { return dataSize_; }
    }
    
    public const int DataFieldNumber = 5;
    private bool hasData;
    private pb::ByteString data_ = (pb::ByteString) global::protocol.UdpData.Descriptor.Fields[4].DefaultValue;
    public bool HasData {
      get { return hasData; }
    }
    public pb::ByteString Data {
      get { return data_; }
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
      string[] field_names = _udpDataFieldNames;
      if (hasIden) {
        output.WriteMessage(1, field_names[4], Iden);
      }
      if (hasChannel) {
        output.WriteUInt32(2, field_names[0], Channel);
      }
      if (hasDataType) {
        output.WriteUInt32(3, field_names[3], DataType);
      }
      if (hasDataSize) {
        output.WriteUInt32(4, field_names[2], DataSize);
      }
      if (hasData) {
        output.WriteBytes(5, field_names[1], Data);
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
      if (hasChannel) {
        size += pb::CodedOutputStream.ComputeUInt32Size(2, Channel);
      }
      if (hasDataType) {
        size += pb::CodedOutputStream.ComputeUInt32Size(3, DataType);
      }
      if (hasDataSize) {
        size += pb::CodedOutputStream.ComputeUInt32Size(4, DataSize);
      }
      if (hasData) {
        size += pb::CodedOutputStream.ComputeBytesSize(5, Data);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static UdpData ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UdpData ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UdpData ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UdpData ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UdpData ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UdpData ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static UdpData ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static UdpData ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static UdpData ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UdpData ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private UdpData MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(UdpData prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<UdpData, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(UdpData cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private UdpData result;
      
      private UdpData PrepareBuilder() {
        if (resultIsReadOnly) {
          UdpData original = result;
          result = new UdpData();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override UdpData MessageBeingBuilt {
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
        get { return global::protocol.UdpData.Descriptor; }
      }
      
      public override UdpData DefaultInstanceForType {
        get { return global::protocol.UdpData.DefaultInstance; }
      }
      
      public override UdpData BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is UdpData) {
          return MergeFrom((UdpData) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(UdpData other) {
        if (other == global::protocol.UdpData.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasIden) {
          MergeIden(other.Iden);
        }
        if (other.HasChannel) {
          Channel = other.Channel;
        }
        if (other.HasDataType) {
          DataType = other.DataType;
        }
        if (other.HasDataSize) {
          DataSize = other.DataSize;
        }
        if (other.HasData) {
          Data = other.Data;
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
            int field_ordinal = global::System.Array.BinarySearch(_udpDataFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _udpDataFieldTags[field_ordinal];
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
              global::protocol.IdentityInfoCliMsg.Builder subBuilder = global::protocol.IdentityInfoCliMsg.CreateBuilder();
              if (result.hasIden) {
                subBuilder.MergeFrom(Iden);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Iden = subBuilder.BuildPartial();
              break;
            }
            case 16: {
              result.hasChannel = input.ReadUInt32(ref result.channel_);
              break;
            }
            case 24: {
              result.hasDataType = input.ReadUInt32(ref result.dataType_);
              break;
            }
            case 32: {
              result.hasDataSize = input.ReadUInt32(ref result.dataSize_);
              break;
            }
            case 42: {
              result.hasData = input.ReadBytes(ref result.data_);
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
      public global::protocol.IdentityInfoCliMsg Iden {
        get { return result.Iden; }
        set { SetIden(value); }
      }
      public Builder SetIden(global::protocol.IdentityInfoCliMsg value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasIden = true;
        result.iden_ = value;
        return this;
      }
      public Builder SetIden(global::protocol.IdentityInfoCliMsg.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasIden = true;
        result.iden_ = builderForValue.Build();
        return this;
      }
      public Builder MergeIden(global::protocol.IdentityInfoCliMsg value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasIden &&
            result.iden_ != global::protocol.IdentityInfoCliMsg.DefaultInstance) {
            result.iden_ = global::protocol.IdentityInfoCliMsg.CreateBuilder(result.iden_).MergeFrom(value).BuildPartial();
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
      
      public bool HasChannel {
        get { return result.hasChannel; }
      }
      [global::System.CLSCompliant(false)]
      public uint Channel {
        get { return result.Channel; }
        set { SetChannel(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetChannel(uint value) {
        PrepareBuilder();
        result.hasChannel = true;
        result.channel_ = value;
        return this;
      }
      public Builder ClearChannel() {
        PrepareBuilder();
        result.hasChannel = false;
        result.channel_ = 0;
        return this;
      }
      
      public bool HasDataType {
        get { return result.hasDataType; }
      }
      [global::System.CLSCompliant(false)]
      public uint DataType {
        get { return result.DataType; }
        set { SetDataType(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetDataType(uint value) {
        PrepareBuilder();
        result.hasDataType = true;
        result.dataType_ = value;
        return this;
      }
      public Builder ClearDataType() {
        PrepareBuilder();
        result.hasDataType = false;
        result.dataType_ = 0;
        return this;
      }
      
      public bool HasDataSize {
        get { return result.hasDataSize; }
      }
      [global::System.CLSCompliant(false)]
      public uint DataSize {
        get { return result.DataSize; }
        set { SetDataSize(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetDataSize(uint value) {
        PrepareBuilder();
        result.hasDataSize = true;
        result.dataSize_ = value;
        return this;
      }
      public Builder ClearDataSize() {
        PrepareBuilder();
        result.hasDataSize = false;
        result.dataSize_ = 0;
        return this;
      }
      
      public bool HasData {
        get { return result.hasData; }
      }
      public pb::ByteString Data {
        get { return result.Data; }
        set { SetData(value); }
      }
      public Builder SetData(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = value;
        return this;
      }
      public Builder ClearData() {
        PrepareBuilder();
        result.hasData = false;
        result.data_ = (pb::ByteString) global::protocol.UdpData.Descriptor.Fields[4].DefaultValue;
        return this;
      }
    }
    static UdpData() {
      object.ReferenceEquals(global::protocol.UdpMsg.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code