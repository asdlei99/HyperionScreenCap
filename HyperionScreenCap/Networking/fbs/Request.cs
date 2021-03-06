// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace hyperionnet
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Request : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Request GetRootAsRequest(ByteBuffer _bb) { return GetRootAsRequest(_bb, new Request()); }
  public static Request GetRootAsRequest(ByteBuffer _bb, Request obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Request __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public hyperionnet.Command CommandType { get { int o = __p.__offset(4); return o != 0 ? (hyperionnet.Command)__p.bb.Get(o + __p.bb_pos) : hyperionnet.Command.NONE; } }
  public TTable? Command<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }

  public static Offset<hyperionnet.Request> CreateRequest(FlatBufferBuilder builder,
      hyperionnet.Command command_type = hyperionnet.Command.NONE,
      int commandOffset = 0) {
    builder.StartTable(2);
    Request.AddCommand(builder, commandOffset);
    Request.AddCommandType(builder, command_type);
    return Request.EndRequest(builder);
  }

  public static void StartRequest(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddCommandType(FlatBufferBuilder builder, hyperionnet.Command commandType) { builder.AddByte(0, (byte)commandType, 0); }
  public static void AddCommand(FlatBufferBuilder builder, int commandOffset) { builder.AddOffset(1, commandOffset, 0); }
  public static Offset<hyperionnet.Request> EndRequest(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 6);  // command
    return new Offset<hyperionnet.Request>(o);
  }
  public static void FinishRequestBuffer(FlatBufferBuilder builder, Offset<hyperionnet.Request> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedRequestBuffer(FlatBufferBuilder builder, Offset<hyperionnet.Request> offset) { builder.FinishSizePrefixed(offset.Value); }
  public RequestT UnPack() {
    var _o = new RequestT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RequestT _o) {
    _o.Command = new hyperionnet.CommandUnion();
    _o.Command.Type = this.CommandType;
    switch (this.CommandType) {
      default: break;
      case hyperionnet.Command.Color:
        _o.Command.Value = this.Command<hyperionnet.Color>().HasValue ? this.Command<hyperionnet.Color>().Value.UnPack() : null;
        break;
      case hyperionnet.Command.Image:
        _o.Command.Value = this.Command<hyperionnet.Image>().HasValue ? this.Command<hyperionnet.Image>().Value.UnPack() : null;
        break;
      case hyperionnet.Command.Clear:
        _o.Command.Value = this.Command<hyperionnet.Clear>().HasValue ? this.Command<hyperionnet.Clear>().Value.UnPack() : null;
        break;
      case hyperionnet.Command.Register:
        _o.Command.Value = this.Command<hyperionnet.Register>().HasValue ? this.Command<hyperionnet.Register>().Value.UnPack() : null;
        break;
    }
  }
  public static Offset<hyperionnet.Request> Pack(FlatBufferBuilder builder, RequestT _o) {
    if (_o == null) return default(Offset<hyperionnet.Request>);
    var _command_type = _o.Command == null ? hyperionnet.Command.NONE : _o.Command.Type;
    var _command = _o.Command == null ? 0 : hyperionnet.CommandUnion.Pack(builder, _o.Command);
    return CreateRequest(
      builder,
      _command_type,
      _command);
  }
};

public class RequestT
{
  public hyperionnet.CommandUnion Command { get; set; }

  public RequestT() {
    this.Command = null;
  }
  public static RequestT DeserializeFromBinary(byte[] fbBuffer) {
    return Request.GetRootAsRequest(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    fbb.Finish(Request.Pack(fbb, this).Value);
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
