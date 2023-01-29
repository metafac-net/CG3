//------------------------------------------------------------------------------
//   Warning: This code was automatically generated.
//   Changes to this file may cause incorrect behavior
//   and will be lost when this file is regenerated.
//------------------------------------------------------------------------------
//
// |metacode:version=0.1|
// |metacode:generator_header|
using System;
using System.Linq;
using MetaFac.CG3.Generators;

namespace MetaFac.CG3.Generator.ClassesV2
{
    public partial class Generator : GeneratorBase
    {
        public Generator() : base("MetaCode.TS3.ClassesV2") { }
        protected override void OnGenerate(TemplateScope outerScope)
        {
// |metacode:generator_body|
Define("BooleanFieldType","Boolean");
Define("SByteFieldType","SByte");
Define("ByteFieldType","Byte");
Define("Int16FieldType","Int16");
Define("UInt16FieldType","UInt16");
Define("CharFieldType","Char");
Define("Int32FieldType","Int32");
Define("UInt32FieldType","UInt32");
Define("SingleFieldType","Single");
Define("Int64FieldType","Int64");
Define("UInt64FieldType","UInt64");
Define("DoubleFieldType","Double");
Define("DateTimeFieldType","DateTime");
Define("TimeSpanFieldType","TimeSpan");
Define("DateTimeZoneFieldType","DateTimeOffset");
Define("DecimalFieldType","Decimal");
Define("GuidFieldType","Guid");
Define("StringFieldType","String");
Define("BinaryFieldType","byte[]");
Define("ExternalBoolean","T_BooleanFieldType_");
Define("ExternalSByte","T_SByteFieldType_");
Define("ExternalByte","T_ByteFieldType_");
Define("ExternalInt16","T_Int16FieldType_");
Define("ExternalUInt16","T_UInt16FieldType_");
Define("ExternalChar","T_CharFieldType_");
Define("ExternalInt32","T_Int32FieldType_");
Define("ExternalUInt32","T_UInt32FieldType_");
Define("ExternalSingle","T_SingleFieldType_");
Define("ExternalInt64","T_Int64FieldType_");
Define("ExternalUInt64","T_UInt64FieldType_");
Define("ExternalDouble","T_DoubleFieldType_");
Define("ExternalDateTime","T_DateTimeFieldType_");
Define("ExternalTimeSpan","T_TimeSpanFieldType_");
Define("ExternalDateTimeOffset","T_DateTimeZoneFieldType_");
Define("ExternalDecimal","T_DecimalFieldType_");
Define("ExternalGuid","T_GuidFieldType_");
Define("ExternalString","T_StringFieldType_");
Define("ExternalBinaryFieldType","T_BinaryFieldType_");
Define("BinaryFieldType","ReadOnlyMemory<byte>");
Define("BaseClassName","EntityBase");
Emit("#region Auto-generated");
Emit("//");
Emit("// Warning: This code was automatically generated. Changes to this file may");
Emit("// cause incorrect behavior and will be lost when this file is regenerated.");
Emit("//");
Emit("// This file was generated by the MetaFac.CG3.CLI tool (or mfcg3)");
Emit("// using a MetaFac generator and modified according to supplied model(s).");
Emit("//");
Emit("// Generator: T_GeneratorId_ T_GeneratorVersion_");
Emit("// Metadata : T_MetadataSource_ T_MetadataVersion_");
Emit("//");
Emit("// For more information about using this tool, the help command is:");
Emit("// mcts3 g2c --help");
Emit("//");
Emit("// To download and install the tool, the .NET CLI command is:");
Emit("// dotnet tool install --global MetaFac.CG3.CLI");
Emit("//");
Emit("//--------------------------------------------------------------------------------");
Emit("#endregion");
Emit("#nullable enable");
Emit("using MetaFac.Mutability;");
Emit("using MetaFac.CG3.Runtime;");
Emit("using System;");
Emit("using System.Collections.Generic;");
Emit("using System.Collections.Immutable;");
Emit("using System.Linq;");
Emit("using System.Runtime.CompilerServices;");
Emit("using T_Namespace_.Contracts;");
Emit("");
Emit("namespace T_Namespace_.ClassesV2");
Emit("{");
    using (Ignored()) {
Emit("    using T_ExternalOtherType_ = System.Int64;");
Emit("    using T_IndexType_ = System.String;");
    }
Emit("");
    using (Ignored()) {
Emit("    public class T_ModelType_ : EntityBase, IT_ModelType_, IEquatable<T_ModelType_>");
Emit("    {");
Emit("        public static T_ModelType_? CreateFrom(IT_ModelType_? source)");
Emit("        {");
Emit("            if (source is null) return null;");
Emit("            if (source is T_ModelType_ concrete) return concrete;");
Emit("            return new T_ModelType_(source);");
Emit("        }");
Emit("");
Emit("        [MethodImpl(MethodImplOptions.NoInlining)]");
Emit("        private static void ThrowIsReadonly()");
Emit("        {");
Emit("            throw new InvalidOperationException(\"Cannot set properties when frozen\");");
Emit("        }");
Emit("");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        private ref T CheckNotFrozen<T>(ref T value)");
Emit("        {");
Emit("            if (_isFrozen) ThrowIsReadonly();");
Emit("            return ref value;");
Emit("        }");
Emit("");
Emit("        protected override int OnGetEntityTag() => 0;");
Emit("");
Emit("        private int _testData;");
Emit("        public int TestData");
Emit("        {");
Emit("            get => _testData;");
Emit("            set => _testData = CheckNotFrozen(ref value);");
Emit("        }");
Emit("");
Emit("        public T_ModelType_() { }");
Emit("        public T_ModelType_(int testData)");
Emit("        {");
Emit("            _testData = testData;");
Emit("        }");
Emit("        public T_ModelType_(IT_ModelType_ source)");
Emit("        {");
Emit("            if (source is null) throw new ArgumentNullException(nameof(source));");
Emit("            _testData = source.TestData;");
Emit("        }");
Emit("");
Emit("        public virtual bool Equals(T_ModelType_? other) => true;");
Emit("        public override int GetHashCode() => 0;");
Emit("        public override bool Equals(object? obj) => obj is T_ModelType_ other && Equals(other);");
Emit("    }");
    }
Emit("");
Emit("    public abstract class EntityBase : IFreezable, IEntityBase");
Emit("    {");
Emit("        public static EntityBase Empty => throw new NotSupportedException();");
Emit("        public const int ClassTag = 0;");
Emit("        public EntityBase() { }");
Emit("        public EntityBase(EntityBase? source) { }");
Emit("        public EntityBase(IEntityBase? source) { }");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public void CopyFrom(IEntityBase? source) { }");
Emit("        protected abstract int OnGetEntityTag();");
Emit("        public int GetEntityTag() => OnGetEntityTag();");
Emit("        public virtual bool Equals(EntityBase? other) => true;");
Emit("        public override int GetHashCode() => 0;");
Emit("");
Emit("        protected volatile bool _isFrozen = false;");
Emit("        public bool IsFreezable() => true;");
Emit("        public bool IsFrozen() => _isFrozen;");
Emit("        protected virtual void OnFreeze() { }");
Emit("        public void Freeze()");
Emit("        {");
Emit("            if (_isFrozen) return;");
Emit("            OnFreeze();");
Emit("            _isFrozen = true;");
Emit("        }");
Emit("        public bool TryFreeze()");
Emit("        {");
Emit("            if (_isFrozen) return false;");
Emit("            OnFreeze();");
Emit("            _isFrozen = true;");
Emit("            return true;");
Emit("        }");
Emit("    }");
Emit("");
    using (Ignored()) {
Emit("    public class T_BaseClassName_ : EntityBase, IT_BaseClassName_");
Emit("    {");
Emit("        private static readonly T_BaseClassName_ _empty = new T_BaseClassName_();");
Emit("        public static new T_BaseClassName_ Empty => _empty;");
Emit("");
Emit("        public new const int ClassTag = 999;");
Emit("        public T_BaseClassName_() { }");
Emit("        public T_BaseClassName_(T_BaseClassName_? source) : base(source) { }");
Emit("        public T_BaseClassName_(IT_BaseClassName_? source) : base(source) { }");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public void CopyFrom(IT_BaseClassName_? source)");
Emit("        {");
Emit("            base.CopyFrom(source);");
Emit("        }");
Emit("");
Emit("        protected override int OnGetEntityTag() => 0;");
Emit("        public virtual bool Equals(T_BaseClassName_? other) => true;");
Emit("        public override int GetHashCode() => 0;");
Emit("    }");
    }
Emit("");
    foreach (var cs in outerScope.Iterators["Classes"].Iterations) {
    using (NewScope(cs)) {
    if (cs.Tokens.ContainsKey("IsAbstract")) {
Emit("    public abstract partial class T_ClassName2_");
Emit("    {");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public static T_ClassName_? CreateFrom(IT_ClassName_? source)");
Emit("        {");
Emit("            if (source is null) return null;");
Emit("            int classTag = source.GetEntityTag();");
Emit("            switch (classTag)");
Emit("            {");
                foreach (var derived in cs.Iterators["AllDerivedClasses"].Iterations) {
                    using (NewScope(derived)) {
Emit("                case T_ClassName_.ClassTag: return T_ClassName_.CreateFrom((IT_ClassName_)source);");
                }}
Emit("                default:");
Emit("                    throw new InvalidOperationException($\"Unable to create {typeof(T_ClassName_)} from {source.GetType().Name}\");");
Emit("            }");
Emit("        }");
Emit("");
Emit("    }");
    } else {
Emit("    public partial class T_ClassName_");
Emit("    {");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public static T_ClassName_? CreateFrom(IT_ClassName_? source)");
Emit("        {");
Emit("            if (source is null) return null;");
Emit("            if (source is T_ClassName_ thisClass && thisClass._isFrozen) return thisClass;");
Emit("            return new T_ClassName_(source);");
Emit("        }");
Emit("");
Emit("        private static T_ClassName_ CreateEmpty()");
Emit("        {");
Emit("            var empty = new T_ClassName_();");
Emit("            empty.Freeze();");
Emit("            return empty;");
Emit("        }");
Emit("        private static readonly T_ClassName_ _empty = CreateEmpty();");
Emit("        public static new T_ClassName_ Empty => _empty;");
Emit("");
Emit("    }");
    }
Emit("    public partial class T_ClassName_ : T_BaseClassName_, IT_ClassName_, IEquatable<T_ClassName_>");
Emit("    {");
Emit("        [MethodImpl(MethodImplOptions.NoInlining)]");
Emit("        private static void ThrowIsReadonly()");
Emit("        {");
Emit("            throw new InvalidOperationException(\"Cannot set properties when frozen\");");
Emit("        }");
Emit("");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        private ref T CheckNotFrozen<T>(ref T value)");
Emit("        {");
Emit("            if (_isFrozen) ThrowIsReadonly();");
Emit("            return ref value;");
Emit("        }");
Emit("");
Emit("        protected override void OnFreeze()");
Emit("        {");
            foreach (var fs in cs.Iterators["Fields"].Iterations) {
              using (NewScope(fs)) {
                var fieldInfo = new FieldInfo(fs, _engine.Current);
            switch (fieldInfo.Kind)
            {
                case FieldKind.UnaryModel:
Emit("            field_T_UnaryModelFieldName_?.Freeze();");
                break; case FieldKind.ArrayModel:
Emit("            if (!(field_T_ArrayModelFieldName_ is null))");
Emit("            {");
Emit("                foreach (var element in field_T_ArrayModelFieldName_)");
Emit("                {");
Emit("                    element?.Freeze();");
Emit("                }");
Emit("            }");
                break; case FieldKind.IndexModel:
Emit("            if (!(field_T_IndexModelFieldName_ is null))");
Emit("            {");
Emit("                foreach (var element in field_T_IndexModelFieldName_.Values)");
Emit("                {");
Emit("                    element?.Freeze();");
Emit("                }");
Emit("            }");
                break; default: break;
            }
            }}
Emit("            base.OnFreeze();");
Emit("        }");
Emit("");
        using (Ignored()) {
Emit("        private const int T_ClassTag_ = 99;");
        }
Emit("        public new const int ClassTag = T_ClassTag_;");
Emit("        protected override int OnGetEntityTag() => ClassTag;");
Emit("");
        foreach (var fs in cs.Iterators["Fields"].Iterations) {
          using (NewScope(fs)) {
            var fieldInfo = new FieldInfo(fs, _engine.Current);
        switch (fieldInfo.Kind)
        {
            case FieldKind.UnaryModel:
Emit("        private T_ModelType_? field_T_UnaryModelFieldName_;");
Emit("        IT_ModelType_? IT_ClassName_.T_UnaryModelFieldName_ => field_T_UnaryModelFieldName_;");
Emit("        public T_ModelType_? T_UnaryModelFieldName_");
Emit("        {");
Emit("            get => field_T_UnaryModelFieldName_;");
Emit("            set => field_T_UnaryModelFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.ArrayModel:
Emit("        public ImmutableList<T_ModelType_?>? field_T_ArrayModelFieldName_;");
Emit("        IReadOnlyList<IT_ModelType_?>? IT_ClassName_.T_ArrayModelFieldName_ => field_T_ArrayModelFieldName_;");
Emit("        public ImmutableList<T_ModelType_?>? T_ArrayModelFieldName_");
Emit("        {");
Emit("            get => field_T_ArrayModelFieldName_;");
Emit("            set => field_T_ArrayModelFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.IndexModel:
Emit("        private ImmutableDictionary<T_IndexType_, T_ModelType_?>? field_T_IndexModelFieldName_;");
Emit("        IReadOnlyDictionary<T_IndexType_, IT_ModelType_?>? IT_ClassName_.T_IndexModelFieldName_");
Emit("            => field_T_IndexModelFieldName_ is null ? null");
Emit("            : new DictionaryFacade<T_IndexType_, IT_ModelType_?, T_ModelType_?>(field_T_IndexModelFieldName_, (x) => x);");
Emit("        public ImmutableDictionary<T_IndexType_, T_ModelType_?>? T_IndexModelFieldName_");
Emit("        {");
Emit("            get => field_T_IndexModelFieldName_;");
Emit("            set => field_T_IndexModelFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.UnaryMaybe:
Emit("        private T_ExternalOtherType_? field_T_UnaryMaybeFieldName_;");
Emit("        T_ExternalOtherType_? IT_ClassName_.T_UnaryMaybeFieldName_ => field_T_UnaryMaybeFieldName_;");
Emit("        public T_ExternalOtherType_? T_UnaryMaybeFieldName_");
Emit("        {");
Emit("            get => field_T_UnaryMaybeFieldName_;");
Emit("            set => field_T_UnaryMaybeFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.ArrayMaybe:
Emit("        private ImmutableList<T_ExternalOtherType_?>? field_T_ArrayMaybeFieldName_;");
Emit("        IReadOnlyList<T_ExternalOtherType_?>? IT_ClassName_.T_ArrayMaybeFieldName_ => field_T_ArrayMaybeFieldName_;");
Emit("        public ImmutableList<T_ExternalOtherType_?>? T_ArrayMaybeFieldName_");
Emit("        {");
Emit("            get => field_T_ArrayMaybeFieldName_;");
Emit("            set => field_T_ArrayMaybeFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.IndexMaybe:
Emit("        private ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>? field_T_IndexMaybeFieldName_;");
Emit("        IReadOnlyDictionary<T_IndexType_, T_ExternalOtherType_?>? IT_ClassName_.T_IndexMaybeFieldName_ => field_T_IndexMaybeFieldName_;");
Emit("        public ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>? T_IndexMaybeFieldName_");
Emit("        {");
Emit("            get => field_T_IndexMaybeFieldName_;");
Emit("            set => field_T_IndexMaybeFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.UnaryOther:
Emit("        private T_ExternalOtherType_ field_T_UnaryOtherFieldName_;");
Emit("        T_ExternalOtherType_ IT_ClassName_.T_UnaryOtherFieldName_ => field_T_UnaryOtherFieldName_;");
Emit("        public T_ExternalOtherType_ T_UnaryOtherFieldName_");
Emit("        {");
Emit("            get => field_T_UnaryOtherFieldName_;");
Emit("            set => field_T_UnaryOtherFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.ArrayOther:
Emit("        private ImmutableList<T_ExternalOtherType_>? field_T_ArrayOtherFieldName_;");
Emit("        IReadOnlyList<T_ExternalOtherType_>? IT_ClassName_.T_ArrayOtherFieldName_ => field_T_ArrayOtherFieldName_;");
Emit("        public ImmutableList<T_ExternalOtherType_>? T_ArrayOtherFieldName_");
Emit("        {");
Emit("            get => field_T_ArrayOtherFieldName_;");
Emit("            set => field_T_ArrayOtherFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.IndexOther:
Emit("        private ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>? field_T_IndexOtherFieldName_;");
Emit("        IReadOnlyDictionary<T_IndexType_, T_ExternalOtherType_>? IT_ClassName_.T_IndexOtherFieldName_ => T_IndexOtherFieldName_;");
Emit("        public ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>? T_IndexOtherFieldName_");
Emit("        {");
Emit("            get => field_T_IndexOtherFieldName_;");
Emit("            set => field_T_IndexOtherFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.UnaryBuffer:
Emit("        private ReadOnlyMemory<byte> field_T_UnaryBufferFieldName_;");
Emit("        ReadOnlyMemory<byte> IT_ClassName_.T_UnaryBufferFieldName_ => field_T_UnaryBufferFieldName_;");
Emit("        public ReadOnlyMemory<byte> T_UnaryBufferFieldName_");
Emit("        {");
Emit("            get => field_T_UnaryBufferFieldName_;");
Emit("            set => field_T_UnaryBufferFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.ArrayBuffer:
Emit("        private ImmutableList<ReadOnlyMemory<byte>>? field_T_ArrayBufferFieldName_;");
Emit("        IReadOnlyList<ReadOnlyMemory<byte>>? IT_ClassName_.T_ArrayBufferFieldName_ => field_T_ArrayBufferFieldName_;");
Emit("        public ImmutableList<ReadOnlyMemory<byte>>? T_ArrayBufferFieldName_");
Emit("        {");
Emit("            get => field_T_ArrayBufferFieldName_;");
Emit("            set => field_T_ArrayBufferFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.IndexBuffer:
Emit("        private ImmutableDictionary<T_IndexType_, ReadOnlyMemory<byte>>? field_T_IndexBufferFieldName_;");
Emit("        IReadOnlyDictionary<T_IndexType_, ReadOnlyMemory<byte>>? IT_ClassName_.T_IndexBufferFieldName_ => field_T_IndexBufferFieldName_;");
Emit("        public ImmutableDictionary<T_IndexType_, ReadOnlyMemory<byte>>? T_IndexBufferFieldName_");
Emit("        {");
Emit("            get => field_T_IndexBufferFieldName_;");
Emit("            set => field_T_IndexBufferFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.UnaryString:
Emit("        private String? field_T_UnaryStringFieldName_;");
Emit("        String? IT_ClassName_.T_UnaryStringFieldName_ => field_T_UnaryStringFieldName_;");
Emit("        public String? T_UnaryStringFieldName_");
Emit("        {");
Emit("            get => field_T_UnaryStringFieldName_;");
Emit("            set => field_T_UnaryStringFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.ArrayString:
Emit("        private ImmutableList<String?>? field_T_ArrayStringFieldName_;");
Emit("        IReadOnlyList<String?>? IT_ClassName_.T_ArrayStringFieldName_ => field_T_ArrayStringFieldName_;");
Emit("        public ImmutableList<String?>? T_ArrayStringFieldName_");
Emit("        {");
Emit("            get => field_T_ArrayStringFieldName_;");
Emit("            set => field_T_ArrayStringFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; case FieldKind.IndexString:
Emit("        private ImmutableDictionary<T_IndexType_, String?>? field_T_IndexStringFieldName_;");
Emit("        IReadOnlyDictionary<T_IndexType_, String?>? IT_ClassName_.T_IndexStringFieldName_ => field_T_IndexStringFieldName_;");
Emit("        public ImmutableDictionary<T_IndexType_, String?>? T_IndexStringFieldName_");
Emit("        {");
Emit("            get => field_T_IndexStringFieldName_;");
Emit("            set => field_T_IndexStringFieldName_ = CheckNotFrozen(ref value);");
Emit("        }");
            break; default: break;
        }
        }}
Emit("");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public T_ClassName_() : base()");
Emit("        {");
Emit("        }");
Emit("");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public T_ClassName_(T_ClassName_? source) : base(source)");
Emit("        {");
Emit("            if (source is null) throw new ArgumentNullException(nameof(source));");
            foreach (var fs in cs.Iterators["Fields"].Iterations) {
              using (NewScope(fs)) {
                var fieldInfo = new FieldInfo(fs, _engine.Current);
            switch (fieldInfo.Kind)
            {
                case FieldKind.UnaryModel:
Emit("            field_T_UnaryModelFieldName_ = source.T_UnaryModelFieldName_;");
                break; case FieldKind.ArrayModel:
Emit("            field_T_ArrayModelFieldName_ = source.T_ArrayModelFieldName_;");
                break; case FieldKind.IndexModel:
Emit("            field_T_IndexModelFieldName_ = source.T_IndexModelFieldName_;");
                break; case FieldKind.UnaryMaybe:
Emit("            field_T_UnaryMaybeFieldName_ = source.T_UnaryMaybeFieldName_;");
                break; case FieldKind.ArrayMaybe:
Emit("            field_T_ArrayMaybeFieldName_ = source.T_ArrayMaybeFieldName_;");
                break; case FieldKind.IndexMaybe:
Emit("            field_T_IndexMaybeFieldName_ = source.T_IndexMaybeFieldName_;");
                break; case FieldKind.UnaryOther:
Emit("            field_T_UnaryOtherFieldName_ = source.T_UnaryOtherFieldName_;");
                break; case FieldKind.ArrayOther:
Emit("            field_T_ArrayOtherFieldName_ = source.T_ArrayOtherFieldName_;");
                break; case FieldKind.IndexOther:
Emit("            field_T_IndexOtherFieldName_ = source.T_IndexOtherFieldName_;");
                break; case FieldKind.UnaryBuffer:
Emit("            field_T_UnaryBufferFieldName_ = source.T_UnaryBufferFieldName_;");
                break; case FieldKind.ArrayBuffer:
Emit("            field_T_ArrayBufferFieldName_ = source.T_ArrayBufferFieldName_;");
                break; case FieldKind.IndexBuffer:
Emit("            field_T_IndexBufferFieldName_ = source.T_IndexBufferFieldName_;");
                break; case FieldKind.UnaryString:
Emit("            field_T_UnaryStringFieldName_ = source.T_UnaryStringFieldName_;");
                break; case FieldKind.ArrayString:
Emit("            field_T_ArrayStringFieldName_ = source.T_ArrayStringFieldName_;");
                break; case FieldKind.IndexString:
Emit("            field_T_IndexStringFieldName_ = source.T_IndexStringFieldName_;");
                break; default: break;
            }
            }}
Emit("        }");
Emit("");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public T_ClassName_(IT_ClassName_? source) : base(source)");
Emit("        {");
Emit("            if (source is null) throw new ArgumentNullException(nameof(source));");
            foreach (var fs in cs.Iterators["Fields"].Iterations) {
              using (NewScope(fs)) {
                var fieldInfo = new FieldInfo(fs, _engine.Current);
            switch (fieldInfo.Kind)
            {
                case FieldKind.UnaryModel:
Emit("            field_T_UnaryModelFieldName_ = T_ModelType_.CreateFrom(source.T_UnaryModelFieldName_);");
                break; case FieldKind.ArrayModel:
Emit("            field_T_ArrayModelFieldName_ = source.T_ArrayModelFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<T_ModelType_?>.Empty.AddRange(source.T_ArrayModelFieldName_.Select(x => T_ModelType_.CreateFrom(x)));");
                break; case FieldKind.IndexModel:
Emit("            field_T_IndexModelFieldName_ = source.T_IndexModelFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty.AddRange(");
Emit("                    source.T_IndexModelFieldName_.Select(x => new KeyValuePair<T_IndexType_, T_ModelType_?>(x.Key, T_ModelType_.CreateFrom(x.Value))));");
                break; case FieldKind.UnaryMaybe:
Emit("            field_T_UnaryMaybeFieldName_ = source.T_UnaryMaybeFieldName_;");
                break; case FieldKind.ArrayMaybe:
Emit("            field_T_ArrayMaybeFieldName_ = source.T_ArrayMaybeFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<T_ExternalOtherType_?>.Empty.AddRange(source.T_ArrayMaybeFieldName_);");
                break; case FieldKind.IndexMaybe:
Emit("            field_T_IndexMaybeFieldName_ = source.T_IndexMaybeFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>.Empty.AddRange(source.T_IndexMaybeFieldName_);");
                break; case FieldKind.UnaryOther:
Emit("            field_T_UnaryOtherFieldName_ = source.T_UnaryOtherFieldName_;");
                break; case FieldKind.ArrayOther:
Emit("            field_T_ArrayOtherFieldName_ = source.T_ArrayOtherFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<T_ExternalOtherType_>.Empty.AddRange(source.T_ArrayOtherFieldName_);");
                break; case FieldKind.IndexOther:
Emit("            field_T_IndexOtherFieldName_ = source.T_IndexOtherFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>.Empty.AddRange(source.T_IndexOtherFieldName_);");
                break; case FieldKind.UnaryBuffer:
Emit("            field_T_UnaryBufferFieldName_ = source.T_UnaryBufferFieldName_;");
                break; case FieldKind.ArrayBuffer:
Emit("            field_T_ArrayBufferFieldName_ = source.T_ArrayBufferFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<ReadOnlyMemory<byte>>.Empty.AddRange(source.T_ArrayBufferFieldName_);");
                break; case FieldKind.IndexBuffer:
Emit("            field_T_IndexBufferFieldName_ = source.T_IndexBufferFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, ReadOnlyMemory<byte>>.Empty.AddRange(source.T_IndexBufferFieldName_);");
                break; case FieldKind.UnaryString:
Emit("            field_T_UnaryStringFieldName_ = source.T_UnaryStringFieldName_;");
                break; case FieldKind.ArrayString:
Emit("            field_T_ArrayStringFieldName_ = source.T_ArrayStringFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<String?>.Empty.AddRange(source.T_ArrayStringFieldName_);");
                break; case FieldKind.IndexString:
Emit("            field_T_IndexStringFieldName_ = source.T_IndexStringFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, String?>.Empty.AddRange(source.T_IndexStringFieldName_);");
                break; default: break;
            }
            }}
Emit("        }");
Emit("");
Emit("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
Emit("        public void CopyFrom(IT_ClassName_? source)");
Emit("        {");
Emit("            if (source is null) return;");
Emit("            if (_isFrozen) ThrowIsReadonly();");
Emit("            base.CopyFrom(source);");
            foreach (var fs in cs.Iterators["Fields"].Iterations) {
              using (NewScope(fs)) {
                var fieldInfo = new FieldInfo(fs, _engine.Current);
            switch (fieldInfo.Kind)
            {
                case FieldKind.UnaryModel:
Emit("            field_T_UnaryModelFieldName_ = T_ModelType_.CreateFrom(source.T_UnaryModelFieldName_);");
                break; case FieldKind.ArrayModel:
Emit("            field_T_ArrayModelFieldName_ = source.T_ArrayModelFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<T_ModelType_?>.Empty.AddRange(source.T_ArrayModelFieldName_.Select(x => T_ModelType_.CreateFrom(x)));");
                break; case FieldKind.IndexModel:
Emit("            field_T_IndexModelFieldName_ = source.T_IndexModelFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty.AddRange(");
Emit("                    source.T_IndexModelFieldName_.Select(x => new KeyValuePair<T_IndexType_, T_ModelType_?>(x.Key, T_ModelType_.CreateFrom(x.Value))));");
                break; case FieldKind.UnaryMaybe:
Emit("            field_T_UnaryMaybeFieldName_ = source.T_UnaryMaybeFieldName_;");
                break; case FieldKind.ArrayMaybe:
Emit("            field_T_ArrayMaybeFieldName_ = source.T_ArrayMaybeFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<T_ExternalOtherType_?>.Empty.AddRange(source.T_ArrayMaybeFieldName_);");
                break; case FieldKind.IndexMaybe:
Emit("            field_T_IndexMaybeFieldName_ = source.T_IndexMaybeFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>.Empty.AddRange(source.T_IndexMaybeFieldName_);");
                break; case FieldKind.UnaryOther:
Emit("            field_T_UnaryOtherFieldName_ = source.T_UnaryOtherFieldName_;");
                break; case FieldKind.ArrayOther:
Emit("            field_T_ArrayOtherFieldName_ = source.T_ArrayOtherFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<T_ExternalOtherType_>.Empty.AddRange(source.T_ArrayOtherFieldName_);");
                break; case FieldKind.IndexOther:
Emit("            field_T_IndexOtherFieldName_ = source.T_IndexOtherFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>.Empty.AddRange(source.T_IndexOtherFieldName_);");
                break; case FieldKind.UnaryBuffer:
Emit("            field_T_UnaryBufferFieldName_ = source.T_UnaryBufferFieldName_;");
                break; case FieldKind.ArrayBuffer:
Emit("            field_T_ArrayBufferFieldName_ = source.T_ArrayBufferFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<ReadOnlyMemory<byte>>.Empty.AddRange(source.T_ArrayBufferFieldName_);");
                break; case FieldKind.IndexBuffer:
Emit("            field_T_IndexBufferFieldName_ = source.T_IndexBufferFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, ReadOnlyMemory<byte>>.Empty.AddRange(source.T_IndexBufferFieldName_);");
                break; case FieldKind.UnaryString:
Emit("            field_T_UnaryStringFieldName_ = source.T_UnaryStringFieldName_;");
                break; case FieldKind.ArrayString:
Emit("            field_T_ArrayStringFieldName_ = source.T_ArrayStringFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableList<String?>.Empty.AddRange(source.T_ArrayStringFieldName_);");
                break; case FieldKind.IndexString:
Emit("            field_T_IndexStringFieldName_ = source.T_IndexStringFieldName_ is null");
Emit("                ? default");
Emit("                : ImmutableDictionary<T_IndexType_, String?>.Empty.AddRange(source.T_IndexStringFieldName_);");
                break; default: break;
            }
            }}
Emit("        }");
Emit("");
Emit("        public virtual bool Equals(T_ClassName_? other)");
Emit("        {");
Emit("            if (other is null) return false;");
Emit("            if (ReferenceEquals(other, this)) return true;");
            foreach (var fs in cs.Iterators["Fields"].Iterations) {
              using (NewScope(fs)) {
                var fieldInfo = new FieldInfo(fs, _engine.Current);
            switch (fieldInfo.Kind)
            {
                case FieldKind.UnaryModel:
Emit("            if (!T_UnaryModelFieldName_.ValueEquals(other.T_UnaryModelFieldName_)) return false;");
                break; case FieldKind.ArrayModel:
Emit("            if (!T_ArrayModelFieldName_.ArrayEquals(other.T_ArrayModelFieldName_)) return false;");
                break; case FieldKind.IndexModel:
Emit("            if (!T_IndexModelFieldName_.IndexEquals(other.T_IndexModelFieldName_)) return false;");
                break; case FieldKind.UnaryMaybe:
Emit("            if (!T_UnaryMaybeFieldName_.ValueEquals(other.T_UnaryMaybeFieldName_)) return false;");
                break; case FieldKind.ArrayMaybe:
Emit("            if (!T_ArrayMaybeFieldName_.ArrayEquals(other.T_ArrayMaybeFieldName_)) return false;");
                break; case FieldKind.IndexMaybe:
Emit("            if (!T_IndexMaybeFieldName_.IndexEquals(other.T_IndexMaybeFieldName_)) return false;");
                break; case FieldKind.UnaryOther:
Emit("            if (!T_UnaryOtherFieldName_.ValueEquals(other.T_UnaryOtherFieldName_)) return false;");
                break; case FieldKind.ArrayOther:
Emit("            if (!T_ArrayOtherFieldName_.ArrayEquals(other.T_ArrayOtherFieldName_)) return false;");
                break; case FieldKind.IndexOther:
Emit("            if (!T_IndexOtherFieldName_.IndexEquals(other.T_IndexOtherFieldName_)) return false;");
                break; case FieldKind.UnaryBuffer:
Emit("            if (!T_UnaryBufferFieldName_.ValueEquals(other.T_UnaryBufferFieldName_)) return false;");
                break; case FieldKind.ArrayBuffer:
Emit("            if (!T_ArrayBufferFieldName_.ArrayEquals(other.T_ArrayBufferFieldName_)) return false;");
                break; case FieldKind.IndexBuffer:
Emit("            if (!T_IndexBufferFieldName_.IndexEquals(other.T_IndexBufferFieldName_)) return false;");
                break; case FieldKind.UnaryString:
Emit("            if (!T_UnaryStringFieldName_.ValueEquals(other.T_UnaryStringFieldName_)) return false;");
                break; case FieldKind.ArrayString:
Emit("            if (!T_ArrayStringFieldName_.ArrayEquals(other.T_ArrayStringFieldName_)) return false;");
                break; case FieldKind.IndexString:
Emit("            if (!T_IndexStringFieldName_.IndexEquals(other.T_IndexStringFieldName_)) return false;");
                break; default: break;
            }
            }}
Emit("            return base.Equals(other);");
Emit("        }");
Emit("");
Emit("        public override bool Equals(object? obj) => obj is T_ClassName_ other && Equals(other);");
Emit("");
Emit("        private int CalcHashCode()");
Emit("        {");
Emit("            HashCode hc = new HashCode();");
            foreach (var fs in cs.Iterators["Fields"].Iterations) {
              using (NewScope(fs)) {
                var fieldInfo = new FieldInfo(fs, _engine.Current);
            switch (fieldInfo.Kind)
            {
                case FieldKind.UnaryModel:
Emit("            hc.Add(T_UnaryModelFieldName_.CalcHashUnary());");
                break; case FieldKind.ArrayModel:
Emit("            hc.Add(T_ArrayModelFieldName_.CalcHashArray());");
                break; case FieldKind.IndexModel:
Emit("            hc.Add(T_IndexModelFieldName_.CalcHashIndex());");
                break; case FieldKind.UnaryMaybe:
Emit("            hc.Add(T_UnaryMaybeFieldName_.CalcHashUnary());");
                break; case FieldKind.ArrayMaybe:
Emit("            hc.Add(T_ArrayMaybeFieldName_.CalcHashArray());");
                break; case FieldKind.IndexMaybe:
Emit("            hc.Add(T_IndexMaybeFieldName_.CalcHashIndex());");
                break; case FieldKind.UnaryOther:
Emit("            hc.Add(T_UnaryOtherFieldName_.CalcHashUnary());");
                break; case FieldKind.ArrayOther:
Emit("            hc.Add(T_ArrayOtherFieldName_.CalcHashArray());");
                break; case FieldKind.IndexOther:
Emit("            hc.Add(T_IndexOtherFieldName_.CalcHashIndex());");
                break; case FieldKind.UnaryBuffer:
Emit("            hc.Add(T_UnaryBufferFieldName_.CalcHashUnary());");
                break; case FieldKind.ArrayBuffer:
Emit("            hc.Add(T_ArrayBufferFieldName_.CalcHashArray());");
                break; case FieldKind.IndexBuffer:
Emit("            hc.Add(T_IndexBufferFieldName_.CalcHashIndex());");
                break; case FieldKind.UnaryString:
Emit("            hc.Add(T_UnaryStringFieldName_.CalcHashUnary());");
                break; case FieldKind.ArrayString:
Emit("            hc.Add(T_ArrayStringFieldName_.CalcHashArray());");
                break; case FieldKind.IndexString:
Emit("            hc.Add(T_IndexStringFieldName_.CalcHashIndex());");
                break; default: break;
            }
            }}
Emit("            hc.Add(base.GetHashCode());");
Emit("            return hc.ToHashCode();");
Emit("        }");
Emit("");
Emit("        private int? _hashCode = null;");
Emit("        public override int GetHashCode()");
Emit("        {");
Emit("            if (_hashCode is null)");
Emit("                _hashCode = CalcHashCode();");
Emit("            return _hashCode.Value;");
Emit("        }");
Emit("    }");
Emit("");
    }}
Emit("");
    using (Ignored()) {
Emit("    public class T_SuperClassName_ : T_ClassName_, IT_SuperClassName_");
Emit("    {");
Emit("        public T_SuperClassName_() { }");
Emit("        public T_SuperClassName_(T_SuperClassName_? source) : base(source) { }");
Emit("        public T_SuperClassName_(IT_SuperClassName_? source) : base(source) { }");
Emit("        public virtual bool Equals(T_SuperClassName_? other) => true;");
Emit("        public override int GetHashCode() => 0;");
Emit("    }");
    }
Emit("}");
// |metacode:generator_footer|
        }
    }
}
// |metacode:generator_end|
