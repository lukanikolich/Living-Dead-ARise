// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ror.schema.upload
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct UploadChunkResponse : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static UploadChunkResponse GetRootAsUploadChunkResponse(ByteBuffer _bb) { return GetRootAsUploadChunkResponse(_bb, new UploadChunkResponse()); }
  public static UploadChunkResponse GetRootAsUploadChunkResponse(ByteBuffer _bb, UploadChunkResponse obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public UploadChunkResponse __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ror.schema.upload.UploadSessionInfo? SessionInfo { get { int o = __p.__offset(4); return o != 0 ? (ror.schema.upload.UploadSessionInfo?)(new ror.schema.upload.UploadSessionInfo()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public ror.schema.upload.UploadChunkInfo? ChunkInfo { get { int o = __p.__offset(6); return o != 0 ? (ror.schema.upload.UploadChunkInfo?)(new ror.schema.upload.UploadChunkInfo()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public ror.schema.upload.ChunkStatus Status { get { int o = __p.__offset(8); return o != 0 ? (ror.schema.upload.ChunkStatus)__p.bb.GetSbyte(o + __p.bb_pos) : ror.schema.upload.ChunkStatus.none; } }
  public bool MutateStatus(ror.schema.upload.ChunkStatus status) { int o = __p.__offset(8); if (o != 0) { __p.bb.PutSbyte(o + __p.bb_pos, (sbyte)status); return true; } else { return false; } }
  public string StatusMessage { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStatusMessageBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStatusMessageBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStatusMessageArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<ror.schema.upload.UploadChunkResponse> CreateUploadChunkResponse(FlatBufferBuilder builder,
      Offset<ror.schema.upload.UploadSessionInfo> sessionInfoOffset = default(Offset<ror.schema.upload.UploadSessionInfo>),
      Offset<ror.schema.upload.UploadChunkInfo> chunkInfoOffset = default(Offset<ror.schema.upload.UploadChunkInfo>),
      ror.schema.upload.ChunkStatus status = ror.schema.upload.ChunkStatus.none,
      StringOffset statusMessageOffset = default(StringOffset)) {
    builder.StartTable(4);
    UploadChunkResponse.AddStatusMessage(builder, statusMessageOffset);
    UploadChunkResponse.AddChunkInfo(builder, chunkInfoOffset);
    UploadChunkResponse.AddSessionInfo(builder, sessionInfoOffset);
    UploadChunkResponse.AddStatus(builder, status);
    return UploadChunkResponse.EndUploadChunkResponse(builder);
  }

  public static void StartUploadChunkResponse(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddSessionInfo(FlatBufferBuilder builder, Offset<ror.schema.upload.UploadSessionInfo> sessionInfoOffset) { builder.AddOffset(0, sessionInfoOffset.Value, 0); }
  public static void AddChunkInfo(FlatBufferBuilder builder, Offset<ror.schema.upload.UploadChunkInfo> chunkInfoOffset) { builder.AddOffset(1, chunkInfoOffset.Value, 0); }
  public static void AddStatus(FlatBufferBuilder builder, ror.schema.upload.ChunkStatus status) { builder.AddSbyte(2, (sbyte)status, 0); }
  public static void AddStatusMessage(FlatBufferBuilder builder, StringOffset statusMessageOffset) { builder.AddOffset(3, statusMessageOffset.Value, 0); }
  public static Offset<ror.schema.upload.UploadChunkResponse> EndUploadChunkResponse(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ror.schema.upload.UploadChunkResponse>(o);
  }
  public static void FinishUploadChunkResponseBuffer(FlatBufferBuilder builder, Offset<ror.schema.upload.UploadChunkResponse> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedUploadChunkResponseBuffer(FlatBufferBuilder builder, Offset<ror.schema.upload.UploadChunkResponse> offset) { builder.FinishSizePrefixed(offset.Value); }
  public UploadChunkResponseT UnPack() {
    var _o = new UploadChunkResponseT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(UploadChunkResponseT _o) {
    _o.SessionInfo = this.SessionInfo.HasValue ? this.SessionInfo.Value.UnPack() : null;
    _o.ChunkInfo = this.ChunkInfo.HasValue ? this.ChunkInfo.Value.UnPack() : null;
    _o.Status = this.Status;
    _o.StatusMessage = this.StatusMessage;
  }
  public static Offset<ror.schema.upload.UploadChunkResponse> Pack(FlatBufferBuilder builder, UploadChunkResponseT _o) {
    if (_o == null) return default(Offset<ror.schema.upload.UploadChunkResponse>);
    var _sessionInfo = _o.SessionInfo == null ? default(Offset<ror.schema.upload.UploadSessionInfo>) : ror.schema.upload.UploadSessionInfo.Pack(builder, _o.SessionInfo);
    var _chunkInfo = _o.ChunkInfo == null ? default(Offset<ror.schema.upload.UploadChunkInfo>) : ror.schema.upload.UploadChunkInfo.Pack(builder, _o.ChunkInfo);
    var _statusMessage = _o.StatusMessage == null ? default(StringOffset) : builder.CreateString(_o.StatusMessage);
    return CreateUploadChunkResponse(
      builder,
      _sessionInfo,
      _chunkInfo,
      _o.Status,
      _statusMessage);
  }
};

public class UploadChunkResponseT
{
  public ror.schema.upload.UploadSessionInfoT SessionInfo { get; set; }
  public ror.schema.upload.UploadChunkInfoT ChunkInfo { get; set; }
  public ror.schema.upload.ChunkStatus Status { get; set; }
  public string StatusMessage { get; set; }

  public UploadChunkResponseT() {
    this.SessionInfo = null;
    this.ChunkInfo = null;
    this.Status = ror.schema.upload.ChunkStatus.none;
    this.StatusMessage = null;
  }
  public static UploadChunkResponseT DeserializeFromBinary(byte[] fbBuffer) {
    return UploadChunkResponse.GetRootAsUploadChunkResponse(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    fbb.Finish(UploadChunkResponse.Pack(fbb, this).Value);
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
