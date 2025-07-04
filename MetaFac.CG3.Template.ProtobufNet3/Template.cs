﻿//------------------------------------------------------------------------------
//   Warning: This code was automatically generated.
//   Changes to this file may cause incorrect behavior
//   and will be lost when this file is regenerated.
//------------------------------------------------------------------------------
//
// |metacode:version=0.1|
// |metacode:template_begin|
//>>Define("BooleanFieldType","Boolean");
//>>Define("SByteFieldType","SByte");
//>>Define("ByteFieldType","Byte");
//>>Define("Int16FieldType","Int16");
//>>Define("UInt16FieldType","UInt16");
//>>Define("CharFieldType","Char");
//>>Define("Int32FieldType","Int32");
//>>Define("UInt32FieldType","UInt32");
//>>Define("SingleFieldType","Single");
//>>Define("Int64FieldType","Int64");
//>>Define("UInt64FieldType","UInt64");
//>>Define("DoubleFieldType","Double");
//>>Define("DateTimeFieldType","DateTime");
//>>Define("TimeSpanFieldType","TimeSpan");
//>>Define("DateTimeZoneFieldType","DateTimeOffset");
//>>Define("DecimalFieldType","Decimal");
//>>Define("GuidFieldType","Guid");
//>>Define("StringFieldType","String");
//>>Define("BinaryFieldType","byte[]");
//>>Define("ConcreteBoolean","T_BooleanFieldType_");
//>>Define("ConcreteSByte","T_SByteFieldType_");
//>>Define("ConcreteByte","T_ByteFieldType_");
//>>Define("ConcreteInt16","T_Int16FieldType_");
//>>Define("ConcreteUInt16","T_UInt16FieldType_");
//>>Define("ConcreteChar","T_CharFieldType_");
//>>Define("ConcreteInt32","T_Int32FieldType_");
//>>Define("ConcreteUInt32","T_UInt32FieldType_");
//>>Define("ConcreteSingle","T_SingleFieldType_");
//>>Define("ConcreteInt64","T_Int64FieldType_");
//>>Define("ConcreteUInt64","T_UInt64FieldType_");
//>>Define("ConcreteDouble","T_DoubleFieldType_");
//>>Define("ConcreteDateTime","T_DateTimeFieldType_");
//>>Define("ConcreteTimeSpan","T_TimeSpanFieldType_");
//>>Define("ConcreteDateTimeOffset","T_DateTimeZoneFieldType_");
//>>Define("ConcreteDecimal","T_DecimalFieldType_");
//>>Define("ConcreteGuid","T_GuidFieldType_");
//>>Define("ConcreteString","T_StringFieldType_");
//>>Define("ConcreteBinaryFieldType","T_BinaryFieldType_");
//>>Define("ExternalBoolean","T_BooleanFieldType_");
//>>Define("ExternalSByte","T_SByteFieldType_");
//>>Define("ExternalByte","T_ByteFieldType_");
//>>Define("ExternalInt16","T_Int16FieldType_");
//>>Define("ExternalUInt16","T_UInt16FieldType_");
//>>Define("ExternalChar","T_CharFieldType_");
//>>Define("ExternalInt32","T_Int32FieldType_");
//>>Define("ExternalUInt32","T_UInt32FieldType_");
//>>Define("ExternalSingle","T_SingleFieldType_");
//>>Define("ExternalInt64","T_Int64FieldType_");
//>>Define("ExternalUInt64","T_UInt64FieldType_");
//>>Define("ExternalDouble","T_DoubleFieldType_");
//>>Define("ExternalDateTime","T_DateTimeFieldType_");
//>>Define("ExternalTimeSpan","T_TimeSpanFieldType_");
//>>Define("ExternalDateTimeOffset","T_DateTimeZoneFieldType_");
//>>Define("ExternalDecimal","T_DecimalFieldType_");
//>>Define("ExternalGuid","T_GuidFieldType_");
//>>Define("ExternalString","T_StringFieldType_");
//>>Define("ExternalBinaryFieldType","T_BinaryFieldType_");
//>>Define("BinaryFieldType","byte[]");
//>>Define("ConcreteDateTime","DateTimeData");
//>>Define("ExternalDateTime","DateTime");
//>>Define("ConcreteDateTimeOffset","DateTimeOffsetData");
//>>Define("ExternalDateTimeOffset","DateTimeOffset");
//>>Define("BaseClassName","object");
// <auto-generated />
#region Auto-generated
//--------------------------------------------------------------------------------
// Warning: This file was automatically generated. Changes to this file may
// cause incorrect behavior and will be lost when this file is regenerated.
//
// This file was generated using MetaFac.CG3 tools and user supplied metadata.
//
// To download and install the tool, the .NET CLI command is:
// dotnet tool install --global MetaFac.CG3.CLI
//
// For more information about using this tool, the help command is:
// mfcg3 g2c --help
//--------------------------------------------------------------------------------
#endregion
#nullable enable
using DataFac.Memory;
using MetaFac.CG3.Runtime;
using MetaFac.CG3.Runtime.ProtobufNet3;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using T_Namespace_.Interfaces;

namespace T_Namespace_.ProtobufNet3
{
    //>>using (Ignored()) {
    using T_ConcreteOtherType_ = System.Int64;
    using T_ExternalOtherType_ = System.Int64;
    using T_IndexType_ = System.String;
    //>>}

    //>>using (Ignored()) {
    [ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
    public class T_ModelType_ : IT_ModelType_, IEquatable<T_ModelType_>
    {
        public static T_ModelType_? CreateFrom(IT_ModelType_? source)
        {
            if (source is null) return null;
            return new T_ModelType_(source);
        }

        [ProtoMember(1)]
        public int TestData { get; set; }

        public T_ModelType_() { }
        public T_ModelType_(IT_ModelType_? source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            TestData = source.TestData;
        }
        public bool Equals(T_ModelType_? other)
        {
            if (ReferenceEquals(other, this)) return true;
            if (other is null) return false;
            return other.TestData == TestData;
        }

        public override bool Equals(object? obj)
        {
            return (obj is T_ModelType_ other) && Equals(other);
        }

        public override int GetHashCode()
        {
            return TestData.GetHashCode();
        }
    }

    internal static class ConversionHelpers
    {
        public static T_ExternalOtherType_ ToExternal(this T_ConcreteOtherType_ value) => value;
        public static T_ExternalOtherType_? ToExternal(this T_ConcreteOtherType_? value, int notUsed) => value;
        public static T_ConcreteOtherType_ ToInternal(this T_ExternalOtherType_ value) => value;
        public static T_ConcreteOtherType_? ToInternal(this T_ExternalOtherType_? value) => value;
    }
    //>>}

    //>>foreach (var cs in outerScope.Iterators["Classes"].Iterations) {
    //>>using (NewScope(cs)) {
    [ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
    //todo when we support polymorphism
    //    foreach AllDerivedClasses
    //    [ProtoInclude(1000 + ClassTags.T_ClassName_, typeof(T_ClassName_))]
    //    endfor
    public sealed partial class T_ClassName_ : IT_ClassName_, IEquatable<T_ClassName_>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T_ClassName_? CreateFrom(IT_ClassName_? source)
        {
            if (source is null) return null;
            return new T_ClassName_(source);
        }

        //>>using (Ignored()) {
        private const int T_ClassTag_ = 9000;
        private const int T_FieldTag_ = 100;
        private const DataFormat T_ProtobufDataFormat_ = DataFormat.Default;
        //>>}
        private const int ClassTag = T_ClassTag_;

        //>>foreach (var fs in cs.Iterators["Fields"].Iterations) {
        //>>  using (NewScope(fs)) {
        //>>    var fieldInfo = new FieldInfo(fs, _engine.Current);
        //>>    Define("ProtobufDataFormat", fieldInfo.IsSignedType? "DataFormat.ZigZag" : "DataFormat.Default");
        [ProtoMember(T_FieldTag_, DataFormat = T_ProtobufDataFormat_)]
        //>>using (Ignored()) {
        public int IgnoreThisField { get; set; }
        //>>}
        //>>switch (fieldInfo.Kind)
        //>>{
        //>>    case FieldKind.UnaryModel:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 1)]
        //>>}
        public T_ModelType_? T_UnaryModelFieldName_ { get; set; }
        //>>    break; case FieldKind.ArrayModel:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 2)]
        //>>}
        public T_ModelType_?[]? T_ArrayModelFieldName_ { get; set; }
        //>>    break; case FieldKind.IndexModel:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 3)]
        //>>}
        public Dictionary<T_IndexType_, T_ModelType_?>? T_IndexModelFieldName_ { get; set; }
        //>>    break; case FieldKind.UnaryMaybe:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 4)]
        //>>}
        public T_ConcreteOtherType_? T_UnaryMaybeFieldName_ { get; set; }
        //>>    break; case FieldKind.ArrayMaybe:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 5)]
        //>>}
        public T_ConcreteOtherType_?[]? T_ArrayMaybeFieldName_ { get; set; }
        //>>    break; case FieldKind.IndexMaybe:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 6)]
        //>>}
        public Dictionary<T_IndexType_, T_ConcreteOtherType_?>? T_IndexMaybeFieldName_ { get; set; }
        //>>    break; case FieldKind.UnaryOther:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 7)]
        //>>}
        public T_ConcreteOtherType_ T_UnaryOtherFieldName_ { get; set; }
        //>>    break; case FieldKind.ArrayOther:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 8)]
        //>>}
        public T_ConcreteOtherType_[]? T_ArrayOtherFieldName_ { get; set; }
        //>>    break; case FieldKind.IndexOther:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 9)]
        //>>}
        public Dictionary<T_IndexType_, T_ConcreteOtherType_>? T_IndexOtherFieldName_ { get; set; }
        //>>    break; case FieldKind.UnaryBuffer:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 10)]
        //>>}
        public byte[]? T_UnaryBufferFieldName_ { get; set; }
        //>>    break; case FieldKind.ArrayBuffer:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 11)]
        //>>}
        public byte[]?[]? T_ArrayBufferFieldName_ { get; set; }
        //>>    break; case FieldKind.IndexBuffer:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 12)]
        //>>}
        public Dictionary<T_IndexType_, byte[]?>? T_IndexBufferFieldName_ { get; set; }
        //>>    break; case FieldKind.UnaryString:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 13)]
        //>>}
        public String? T_UnaryStringFieldName_ { get; set; }
        //>>    break; case FieldKind.ArrayString:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 14)]
        //>>}
        public String?[]? T_ArrayStringFieldName_ { get; set; }
        //>>    break; case FieldKind.IndexString:
        //>>using (Ignored()) {
        [ProtoMember(T_FieldTag_ + 15)]
        //>>}
        public Dictionary<T_IndexType_, String?>? T_IndexStringFieldName_ { get; set; }
        //>>    break; default:
        //>>        throw new ArgumentOutOfRangeException("fieldInfo.Kind", fieldInfo.Kind, $"ordinal={(int)fieldInfo.Kind}");
        //>>}
        //>>}}

        //>>foreach (var fs in cs.Iterators["Fields"].Iterations) {
        //>>  using (NewScope(fs)) {
        //>>    var fieldInfo = new FieldInfo(fs, _engine.Current);
        //>>switch (fieldInfo.Kind)
        //>>{
        //>>    case FieldKind.UnaryModel:
        IT_ModelType_? IT_ClassName_.T_UnaryModelFieldName_ => T_UnaryModelFieldName_;
        //>>    break; case FieldKind.ArrayModel:
        IEnumerable<IT_ModelType_?>? IT_ClassName_.T_ArrayModelFieldName_ => T_ArrayModelFieldName_;
        //>>    break; case FieldKind.IndexModel:
        IEnumerable<KeyValuePair<T_IndexType_, IT_ModelType_?>>? IT_ClassName_.T_IndexModelFieldName_ => T_IndexModelFieldName_
            ?.Select(kvp => new KeyValuePair<T_IndexType_, IT_ModelType_?>(kvp.Key, kvp.Value));
        //>>    break; case FieldKind.UnaryMaybe:
        T_ExternalOtherType_? IT_ClassName_.T_UnaryMaybeFieldName_ => T_UnaryMaybeFieldName_.ToExternal();
        //>>    break; case FieldKind.ArrayMaybe:
        IEnumerable<T_ExternalOtherType_?>? IT_ClassName_.T_ArrayMaybeFieldName_ => T_ArrayMaybeFieldName_
            ?.Select(x => x.ToExternal());
        //>>    break; case FieldKind.IndexMaybe:
        IEnumerable<KeyValuePair<T_IndexType_, T_ExternalOtherType_?>>? IT_ClassName_.T_IndexMaybeFieldName_ => T_IndexMaybeFieldName_
            ?.Select(kvp => new KeyValuePair<T_IndexType_, T_ExternalOtherType_?>(kvp.Key, kvp.Value.ToExternal()));
        //>>    break; case FieldKind.UnaryOther:
        T_ExternalOtherType_ IT_ClassName_.T_UnaryOtherFieldName_ => T_UnaryOtherFieldName_.ToExternal();
        //>>    break; case FieldKind.ArrayOther:
        IEnumerable<T_ExternalOtherType_>? IT_ClassName_.T_ArrayOtherFieldName_ => T_ArrayOtherFieldName_
            ?.Select(x => x.ToExternal());
        //>>    break; case FieldKind.IndexOther:
        IEnumerable<KeyValuePair<T_IndexType_, T_ExternalOtherType_>>? IT_ClassName_.T_IndexOtherFieldName_ => T_IndexOtherFieldName_
            ?.Select(kvp => new KeyValuePair<T_IndexType_, T_ExternalOtherType_>(kvp.Key, kvp.Value.ToExternal()));
        //>>    break; case FieldKind.UnaryBuffer:
        Octets? IT_ClassName_.T_UnaryBufferFieldName_ => T_UnaryBufferFieldName_ is null? null: Octets.UnsafeWrap(T_UnaryBufferFieldName_);
        //>>    break; case FieldKind.ArrayBuffer:
        IEnumerable<Octets?>? IT_ClassName_.T_ArrayBufferFieldName_ => T_ArrayBufferFieldName_?.Select(b => b is null ? null : Octets.UnsafeWrap(b));
        //>>    break; case FieldKind.IndexBuffer:
        IEnumerable<KeyValuePair<T_IndexType_, Octets?>>? IT_ClassName_.T_IndexBufferFieldName_ => T_IndexBufferFieldName_
            ?.Select(kvp => new KeyValuePair<T_IndexType_, Octets?>(kvp.Key, kvp.Value is null ? null : Octets.UnsafeWrap(kvp.Value)));
        //>>    break; case FieldKind.UnaryString:
        String? IT_ClassName_.T_UnaryStringFieldName_ => T_UnaryStringFieldName_;
        //>>    break; case FieldKind.ArrayString:
        IEnumerable<String?>? IT_ClassName_.T_ArrayStringFieldName_ => T_ArrayStringFieldName_;
        //>>    break; case FieldKind.IndexString:
        IEnumerable<KeyValuePair<T_IndexType_, String?>>? IT_ClassName_.T_IndexStringFieldName_ => T_IndexStringFieldName_
            ?.Select(kvp => new KeyValuePair<T_IndexType_, String?>(kvp.Key, kvp.Value));
        //>>    break; default: break;
        //>>}
        //>>}}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T_ClassName_()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T_ClassName_(IT_ClassName_ source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            //>>foreach (var fs in cs.Iterators["Fields"].Iterations) {
            //>>  using (NewScope(fs)) {
            //>>    var fieldInfo = new FieldInfo(fs, _engine.Current);
            //>>switch (fieldInfo.Kind)
            //>>{
            //>>    case FieldKind.UnaryModel:
            T_UnaryModelFieldName_ = T_ModelType_.CreateFrom(source.T_UnaryModelFieldName_);
            //>>    break; case FieldKind.ArrayModel:
            T_ArrayModelFieldName_ = source.T_ArrayModelFieldName_?.Select(x => T_ModelType_.CreateFrom(x)).ToArray();
            //>>    break; case FieldKind.IndexModel:
            T_IndexModelFieldName_ = source.T_IndexModelFieldName_?.ToDictionary(kvp => kvp.Key, kvp => T_ModelType_.CreateFrom(kvp.Value));
            //>>    break; case FieldKind.UnaryMaybe:
            T_UnaryMaybeFieldName_ = source.T_UnaryMaybeFieldName_.ToInternal();
            //>>    break; case FieldKind.ArrayMaybe:
            T_ArrayMaybeFieldName_ = source.T_ArrayMaybeFieldName_?.Select(x => x.ToInternal()).ToArray();
            //>>    break; case FieldKind.IndexMaybe:
            T_IndexMaybeFieldName_ = source.T_IndexMaybeFieldName_?.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.ToInternal());
            //>>    break; case FieldKind.UnaryOther:
            T_UnaryOtherFieldName_ = source.T_UnaryOtherFieldName_.ToInternal();
            //>>    break; case FieldKind.ArrayOther:
            T_ArrayOtherFieldName_ = source.T_ArrayOtherFieldName_?.Select(x => x.ToInternal()).ToArray();
            //>>    break; case FieldKind.IndexOther:
            T_IndexOtherFieldName_ = source.T_IndexOtherFieldName_?.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.ToInternal());
            //>>    break; case FieldKind.UnaryBuffer:
            T_UnaryBufferFieldName_ = source.T_UnaryBufferFieldName_?.ToByteArray();
            //>>    break; case FieldKind.ArrayBuffer:
            T_ArrayBufferFieldName_ = source.T_ArrayBufferFieldName_?.Select(b => b?.ToByteArray()).ToArray();
            //>>    break; case FieldKind.IndexBuffer:
            T_IndexBufferFieldName_ = source.T_IndexBufferFieldName_?.ToDictionary(kvp => kvp.Key, kvp => kvp.Value?.ToByteArray());
            //>>    break; case FieldKind.UnaryString:
            T_UnaryStringFieldName_ = source.T_UnaryStringFieldName_;
            //>>    break; case FieldKind.ArrayString:
            T_ArrayStringFieldName_ = source.T_ArrayStringFieldName_?.ToArray();
            //>>    break; case FieldKind.IndexString:
            T_IndexStringFieldName_ = source.T_IndexStringFieldName_?.ToDictionary(kvp => kvp.Key, kvp => (String?)kvp.Value);
            //>>    break; default: break;
            //>>}
            //>>}}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(T_ClassName_? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            //>>foreach (var fs in cs.Iterators["Fields"].Iterations) {
            //>>  using (NewScope(fs)) {
            //>>    var fieldInfo = new FieldInfo(fs, _engine.Current);
            //>>switch (fieldInfo.Kind)
            //>>{
            //>>    case FieldKind.UnaryModel:
            if (!T_UnaryModelFieldName_.ValueEquals(other.T_UnaryModelFieldName_)) return false;
            //>>    break; case FieldKind.ArrayModel:
            if (!T_ArrayModelFieldName_.ArrayEquals(other.T_ArrayModelFieldName_)) return false;
            //>>    break; case FieldKind.IndexModel:
            if (!T_IndexModelFieldName_.IndexEquals(other.T_IndexModelFieldName_)) return false;
            //>>    break; case FieldKind.UnaryMaybe:
            if (!T_UnaryMaybeFieldName_.ValueEquals(other.T_UnaryMaybeFieldName_)) return false;
            //>>    break; case FieldKind.ArrayMaybe:
            if (!T_ArrayMaybeFieldName_.ArrayEquals(other.T_ArrayMaybeFieldName_)) return false;
            //>>    break; case FieldKind.IndexMaybe:
            if (!T_IndexMaybeFieldName_.IndexEquals(other.T_IndexMaybeFieldName_)) return false;
            //>>    break; case FieldKind.UnaryOther:
            if (!T_UnaryOtherFieldName_.ValueEquals(other.T_UnaryOtherFieldName_)) return false;
            //>>    break; case FieldKind.ArrayOther:
            if (!T_ArrayOtherFieldName_.ArrayEquals(other.T_ArrayOtherFieldName_)) return false;
            //>>    break; case FieldKind.IndexOther:
            if (!T_IndexOtherFieldName_.IndexEquals(other.T_IndexOtherFieldName_)) return false;
            //>>    break; case FieldKind.UnaryBuffer:
            if (!T_UnaryBufferFieldName_.ValueEquals(other.T_UnaryBufferFieldName_)) return false;
            //>>    break; case FieldKind.ArrayBuffer:
            if (!T_ArrayBufferFieldName_.ArrayEquals(other.T_ArrayBufferFieldName_)) return false;
            //>>    break; case FieldKind.IndexBuffer:
            if (!T_IndexBufferFieldName_.IndexEquals(other.T_IndexBufferFieldName_)) return false;
            //>>    break; case FieldKind.UnaryString:
            if (!T_UnaryStringFieldName_.ValueEquals(other.T_UnaryStringFieldName_)) return false;
            //>>    break; case FieldKind.ArrayString:
            if (!T_ArrayStringFieldName_.ArrayEquals(other.T_ArrayStringFieldName_)) return false;
            //>>    break; case FieldKind.IndexString:
            if (!T_IndexStringFieldName_.IndexEquals(other.T_IndexStringFieldName_)) return false;
            //>>    break; default: break;
            //>>}
            //>>}}
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(T_ClassName_ left, T_ClassName_ right)
        {
            if (left is null) return (right is null);
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(T_ClassName_ left, T_ClassName_ right)
        {
            if (left is null) return !(right is null);
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object? obj)
        {
            return obj is T_ClassName_ other && Equals(other);
        }

        public override int GetHashCode()
        {
            int hash = 0;
            unchecked
            {
                //>>foreach (var fs in cs.Iterators["Fields"].Iterations) {
                //>>  using (NewScope(fs)) {
                //>>    var fieldInfo = new FieldInfo(fs, _engine.Current);
                //>>switch (fieldInfo.Kind)
                //>>{
                //>>    case FieldKind.UnaryModel:
                hash = (hash * 397) ^ T_UnaryModelFieldName_.CalcHashUnary();
                //>>    break; case FieldKind.ArrayModel:
                hash = (hash * 397) ^ T_ArrayModelFieldName_.CalcHashArray();
                //>>    break; case FieldKind.IndexModel:
                hash = (hash * 397) ^ T_IndexModelFieldName_.CalcHashIndex();
                //>>    break; case FieldKind.UnaryMaybe:
                hash = (hash * 397) ^ T_UnaryMaybeFieldName_.CalcHashUnary();
                //>>    break; case FieldKind.ArrayMaybe:
                hash = (hash * 397) ^ T_ArrayMaybeFieldName_.CalcHashArray();
                //>>    break; case FieldKind.IndexMaybe:
                hash = (hash * 397) ^ T_IndexMaybeFieldName_.CalcHashIndex();
                //>>    break; case FieldKind.UnaryOther:
                hash = (hash * 397) ^ T_UnaryOtherFieldName_.CalcHashUnary();
                //>>    break; case FieldKind.ArrayOther:
                hash = (hash * 397) ^ T_ArrayOtherFieldName_.CalcHashArray();
                //>>    break; case FieldKind.IndexOther:
                hash = (hash * 397) ^ T_IndexOtherFieldName_.CalcHashIndex();
                //>>    break; case FieldKind.UnaryBuffer:
                hash = (hash * 397) ^ T_UnaryBufferFieldName_.CalcHashUnary();
                //>>    break; case FieldKind.ArrayBuffer:
                hash = (hash * 397) ^ T_ArrayBufferFieldName_.CalcHashArray();
                //>>    break; case FieldKind.IndexBuffer:
                hash = (hash * 397) ^ T_IndexBufferFieldName_.CalcHashIndex();
                //>>    break; case FieldKind.UnaryString:
                hash = (hash * 397) ^ T_UnaryStringFieldName_.CalcHashUnary();
                //>>    break; case FieldKind.ArrayString:
                hash = (hash * 397) ^ T_ArrayStringFieldName_.CalcHashArray();
                //>>    break; case FieldKind.IndexString:
                hash = (hash * 397) ^ T_IndexStringFieldName_.CalcHashIndex();
                //>>    break; default: break;
                //>>}
                //>>}}
            }
            return hash;
        }

    }

    //>>}}

}
// |metacode:template_end|
