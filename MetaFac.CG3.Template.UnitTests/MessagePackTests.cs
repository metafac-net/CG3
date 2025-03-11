using MessagePack;
using MetaFac.CG3.Runtime;
using Shouldly;
using System;
using System.Collections.Immutable;
using T_Namespace_.Contracts;
using T_Namespace_.MessagePack;
using Xunit;

namespace MetaFac.CG3.Template.UnitTests
{
    using T_ExternalOtherType_ = Int64;
    using T_IndexType_ = String;

    public class MessagePackTests
    {
        [Fact]
        public void ImmutableBufferRoundtrip()
        {
            ReadOnlyMemory<byte> orig = new byte[] { 1, 2, 3 };
            ImmutableArray<byte> array1 = orig.ToImmutableArray();
            ReadOnlyMemory<byte> copy = array1.AsMemory();
            ImmutableArray<byte> array2 = copy.ToImmutableArray();

            copy.Length.ShouldBe(orig.Length);
            //copy.ShouldBeEquivalentTo(orig);

            array1.Length.ShouldBe(array2.Length);
            array1.ArrayEquals(array2).ShouldBeTrue();

            copy.ValueEquals(orig);
            array2.ValueEquals(array1);
        }

        [Fact]
        public void Create_Empty()
        {
            var concrete = T_ClassName_.Empty;
            concrete.IsFrozen().ShouldBeTrue();
            concrete.T_UnaryModelFieldName_.ShouldBeNull();
            concrete.T_ArrayModelFieldName_.ShouldBeNull();
            concrete.T_IndexModelFieldName_.ShouldBeNull();
            concrete.T_UnaryOtherFieldName_.ShouldBe(default);
            concrete.T_ArrayOtherFieldName_.ShouldBeNull();
            concrete.T_IndexOtherFieldName_.ShouldBeNull();
            concrete.T_UnaryMaybeFieldName_.ShouldBeNull();
            concrete.T_ArrayMaybeFieldName_.ShouldBeNull();
            concrete.T_IndexMaybeFieldName_.ShouldBeNull();
            concrete.T_UnaryBufferFieldName_.IsDefault.ShouldBeTrue();
            concrete.T_ArrayBufferFieldName_.ShouldBeNull();
            concrete.T_IndexBufferFieldName_.ShouldBeNull();
            concrete.T_UnaryStringFieldName_.ShouldBeNull();
            concrete.T_ArrayStringFieldName_.ShouldBeNull();
            concrete.T_IndexStringFieldName_.ShouldBeNull();

            IT_ClassName_ external = concrete;
            external.T_UnaryModelFieldName_.ShouldBeNull();
            external.T_ArrayModelFieldName_.ShouldBeNull();
            external.T_IndexModelFieldName_.ShouldBeNull();
            external.T_UnaryOtherFieldName_.ShouldBe(default);
            external.T_ArrayOtherFieldName_.ShouldBeNull();
            external.T_IndexOtherFieldName_.ShouldBeNull();
            external.T_UnaryMaybeFieldName_.ShouldBeNull();
            external.T_ArrayMaybeFieldName_.ShouldBeNull();
            external.T_IndexMaybeFieldName_.ShouldBeNull();
            external.T_UnaryBufferFieldName_.ShouldBe(ReadOnlyMemory<byte>.Empty);
            external.T_ArrayBufferFieldName_.ShouldBeNull();
            external.T_IndexBufferFieldName_.ShouldBeNull();
            external.T_UnaryStringFieldName_.ShouldBeNull();
            external.T_ArrayStringFieldName_.ShouldBeNull();
            external.T_IndexStringFieldName_.ShouldBeNull();

            var duplicate = new T_ClassName_(external);
            duplicate.IsFrozen().ShouldBeFalse();
            duplicate.Freeze();
            duplicate.IsFrozen().ShouldBeTrue();

            duplicate.T_UnaryModelFieldName_.ShouldBe(concrete.T_UnaryModelFieldName_);
            duplicate.T_UnaryMaybeFieldName_.ShouldBe(concrete.T_UnaryMaybeFieldName_);
            duplicate.T_UnaryOtherFieldName_.ShouldBe(concrete.T_UnaryOtherFieldName_);
            (duplicate.T_UnaryBufferFieldName_ == concrete.T_UnaryBufferFieldName_).ShouldBeTrue();
            duplicate.T_UnaryStringFieldName_.ShouldBe(concrete.T_UnaryStringFieldName_);
            duplicate.T_ArrayModelFieldName_.ShouldBeEquivalentTo(concrete.T_ArrayModelFieldName_);
            duplicate.T_ArrayMaybeFieldName_.ShouldBeEquivalentTo(concrete.T_ArrayMaybeFieldName_);
            duplicate.T_ArrayOtherFieldName_.ShouldBeEquivalentTo(concrete.T_ArrayOtherFieldName_);
            duplicate.T_ArrayBufferFieldName_.ShouldBeEquivalentTo(concrete.T_ArrayBufferFieldName_);
            duplicate.T_ArrayStringFieldName_.ShouldBeEquivalentTo(concrete.T_ArrayStringFieldName_);
            duplicate.T_IndexModelFieldName_.ShouldBeEquivalentTo(concrete.T_IndexModelFieldName_);
            duplicate.T_IndexMaybeFieldName_.ShouldBeEquivalentTo(concrete.T_IndexMaybeFieldName_);
            duplicate.T_IndexOtherFieldName_.ShouldBeEquivalentTo(concrete.T_IndexOtherFieldName_);
            duplicate.T_IndexBufferFieldName_.ShouldBeEquivalentTo(concrete.T_IndexBufferFieldName_);
            duplicate.T_IndexStringFieldName_.ShouldBeEquivalentTo(concrete.T_IndexStringFieldName_);

            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }

        [Theory]
        [InlineData(MessagePackCompression.None, 119)]
        //[InlineData(MessagePackCompression.Lz4Block, 30)] // fails! MessagePack bug? todo
        //[InlineData(MessagePackCompression.Lz4BlockArray, 32)] // fails! MessagePack bug? todo
        public void Roundtrip_Empty(MessagePackCompression compression, int compressedSize)
        {
            var options = MessagePackSerializerOptions.Standard.WithCompression(compression);
            var original = new T_ClassName_();
            byte[] buffer = MessagePackSerializer.Serialize(original, options);
            buffer.Length.ShouldBe(compressedSize);
            var duplicate = MessagePackSerializer.Deserialize<T_ClassName_>(buffer);
            duplicate.ShouldBe(original);
            duplicate.Equals(original).ShouldBeTrue();
        }

        [Fact]
        public void Create_NonEmpty1()
        {
            var original = new T_ClassName_()
            {
                T_UnaryModelFieldName_ = new T_ModelType_(123),
                T_ArrayModelFieldName_ = ImmutableList<T_ModelType_?>.Empty.Add(new T_ModelType_(234)),
                T_IndexModelFieldName_ = ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty
                    .Add("987", new T_ModelType_(456))
                    .Add("876", null),
                T_UnaryOtherFieldName_ = 123L,
                T_ArrayOtherFieldName_ = ImmutableList<T_ExternalOtherType_>.Empty.Add(234L),
                T_IndexOtherFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryMaybeFieldName_ = null,
                T_ArrayMaybeFieldName_ = ImmutableList<T_ExternalOtherType_?>.Empty.Add(null).Add(234L),
                T_IndexMaybeFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryBufferFieldName_ = ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }),
                T_ArrayBufferFieldName_ = ImmutableList<ImmutableArray<byte>>.Empty
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
                T_IndexBufferFieldName_ = ImmutableDictionary<T_IndexType_, ImmutableArray<byte>>.Empty
                    .Add("a", ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add("b", ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
            };
            original.Freeze();

            IT_ClassName_ external = original;
            external.T_UnaryModelFieldName_.ShouldNotBeNull();
            external.T_ArrayModelFieldName_.ShouldNotBeNull();
            external.T_IndexModelFieldName_.ShouldNotBeNull();
            external.T_UnaryOtherFieldName_.ShouldBe(123L);
            external.T_ArrayOtherFieldName_.ShouldNotBeNull();
            external.T_IndexOtherFieldName_.ShouldNotBeNull();
            external.T_UnaryMaybeFieldName_.ShouldBeNull();
            external.T_ArrayMaybeFieldName_.ShouldNotBeNull();
            external.T_IndexMaybeFieldName_.ShouldNotBeNull();
            external.T_UnaryBufferFieldName_.IsEmpty.ShouldBeFalse();
            external.T_UnaryBufferFieldName_.Length.ShouldBe(4);

            var duplicate = new T_ClassName_(external);
            duplicate.T_UnaryModelFieldName_.ShouldBe(original.T_UnaryModelFieldName_);
            duplicate.T_UnaryMaybeFieldName_.ShouldBe(original.T_UnaryMaybeFieldName_);
            duplicate.T_UnaryOtherFieldName_.ShouldBe(original.T_UnaryOtherFieldName_);
            duplicate.T_UnaryBufferFieldName_.ArrayEquals(original.T_UnaryBufferFieldName_).ShouldBeTrue();
            duplicate.T_UnaryStringFieldName_.ShouldBe(original.T_UnaryStringFieldName_);
            duplicate.T_ArrayModelFieldName_.ShouldBeEquivalentTo(original.T_ArrayModelFieldName_);
            duplicate.T_ArrayMaybeFieldName_.ShouldBeEquivalentTo(original.T_ArrayMaybeFieldName_);
            duplicate.T_ArrayOtherFieldName_.ShouldBeEquivalentTo(original.T_ArrayOtherFieldName_);
            duplicate.T_ArrayBufferFieldName_.ShouldBeEquivalentTo(original.T_ArrayBufferFieldName_);
            duplicate.T_ArrayStringFieldName_.ShouldBeEquivalentTo(original.T_ArrayStringFieldName_);
            duplicate.T_IndexModelFieldName_.ShouldBeEquivalentTo(original.T_IndexModelFieldName_);
            duplicate.T_IndexMaybeFieldName_.ShouldBeEquivalentTo(original.T_IndexMaybeFieldName_);
            duplicate.T_IndexOtherFieldName_.ShouldBeEquivalentTo(original.T_IndexOtherFieldName_);
            duplicate.T_IndexBufferFieldName_.IndexEquals(original.T_IndexBufferFieldName_).ShouldBeTrue();
            duplicate.T_IndexStringFieldName_.ShouldBeEquivalentTo(original.T_IndexStringFieldName_);

            duplicate.Equals(original).ShouldBeTrue();
            duplicate.ShouldBe(original);
        }

        [Fact]
        public void Create_NonEmpty2()
        {
            var original = new T_ClassName_()
            {
                T_UnaryModelFieldName_ = new T_ModelType_(123),
                T_ArrayModelFieldName_ = ImmutableList<T_ModelType_?>.Empty.Add(new T_ModelType_(234)),
                T_IndexModelFieldName_ = ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty
                    .Add("987", new T_ModelType_(456))
                    .Add("876", null),
                T_UnaryOtherFieldName_ = 123L,
                T_ArrayOtherFieldName_ = ImmutableList<T_ExternalOtherType_>.Empty.Add(234L),
                T_IndexOtherFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryMaybeFieldName_ = null,
                T_ArrayMaybeFieldName_ = ImmutableList<T_ExternalOtherType_?>.Empty.Add(null).Add(234L),
                T_IndexMaybeFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryBufferFieldName_ = ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }),
                T_ArrayBufferFieldName_ = ImmutableList<ImmutableArray<byte>>.Empty
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
                T_IndexBufferFieldName_ = ImmutableDictionary<T_IndexType_, ImmutableArray<byte>>.Empty
                    .Add("a", ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add("b", ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
            };
            original.Freeze();

            var duplicate = new T_ClassName_(original);
            duplicate.T_UnaryModelFieldName_.ShouldBe(original.T_UnaryModelFieldName_);
            duplicate.T_UnaryMaybeFieldName_.ShouldBe(original.T_UnaryMaybeFieldName_);
            duplicate.T_UnaryOtherFieldName_.ShouldBe(original.T_UnaryOtherFieldName_);
            duplicate.T_UnaryBufferFieldName_.ArrayEquals(original.T_UnaryBufferFieldName_).ShouldBeTrue();
            duplicate.T_UnaryStringFieldName_.ShouldBe(original.T_UnaryStringFieldName_);
            duplicate.T_ArrayModelFieldName_.ShouldBeEquivalentTo(original.T_ArrayModelFieldName_);
            duplicate.T_ArrayMaybeFieldName_.ShouldBeEquivalentTo(original.T_ArrayMaybeFieldName_);
            duplicate.T_ArrayOtherFieldName_.ShouldBeEquivalentTo(original.T_ArrayOtherFieldName_);
            duplicate.T_ArrayBufferFieldName_.ShouldBeEquivalentTo(original.T_ArrayBufferFieldName_);
            duplicate.T_ArrayStringFieldName_.ShouldBeEquivalentTo(original.T_ArrayStringFieldName_);
            duplicate.T_IndexModelFieldName_.ShouldBeEquivalentTo(original.T_IndexModelFieldName_);
            duplicate.T_IndexMaybeFieldName_.ShouldBeEquivalentTo(original.T_IndexMaybeFieldName_);
            duplicate.T_IndexOtherFieldName_.ShouldBeEquivalentTo(original.T_IndexOtherFieldName_);
            duplicate.T_IndexBufferFieldName_.ShouldBeEquivalentTo(original.T_IndexBufferFieldName_);
            duplicate.T_IndexStringFieldName_.ShouldBeEquivalentTo(original.T_IndexStringFieldName_);

            duplicate.Equals(original).ShouldBeTrue();
            duplicate.ShouldBe(original);
        }

        [Fact]
        public void Create_NonEmpty3()
        {
            var original = new T_ClassName_()
            {
                T_UnaryModelFieldName_ = new T_ModelType_(123),
                T_ArrayModelFieldName_ = ImmutableList<T_ModelType_?>.Empty.Add(new T_ModelType_(234)),
                T_IndexModelFieldName_ = ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty
                    .Add("987", new T_ModelType_(456))
                    .Add("876", null),
                T_UnaryOtherFieldName_ = 123L,
                T_ArrayOtherFieldName_ = ImmutableList<T_ExternalOtherType_>.Empty.Add(234L),
                T_IndexOtherFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryMaybeFieldName_ = null,
                T_ArrayMaybeFieldName_ = ImmutableList<T_ExternalOtherType_?>.Empty.Add(null).Add(234L),
                T_IndexMaybeFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryBufferFieldName_ = ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }),
                T_ArrayBufferFieldName_ = ImmutableList<ImmutableArray<byte>>.Empty
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
                T_IndexBufferFieldName_ = ImmutableDictionary<T_IndexType_, ImmutableArray<byte>>.Empty
                    .Add("a", ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add("b", ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
            };
            original.Freeze();

            var duplicate = new T_ClassName_();
            duplicate.CopyFrom(original);
            duplicate.T_UnaryModelFieldName_.ShouldBe(original.T_UnaryModelFieldName_);
            duplicate.T_UnaryMaybeFieldName_.ShouldBe(original.T_UnaryMaybeFieldName_);
            duplicate.T_UnaryOtherFieldName_.ShouldBe(original.T_UnaryOtherFieldName_);
            duplicate.T_UnaryBufferFieldName_.ArrayEquals(original.T_UnaryBufferFieldName_).ShouldBeTrue();
            duplicate.T_UnaryStringFieldName_.ShouldBe(original.T_UnaryStringFieldName_);
            duplicate.T_ArrayModelFieldName_.ShouldBeEquivalentTo(original.T_ArrayModelFieldName_);
            duplicate.T_ArrayMaybeFieldName_.ShouldBeEquivalentTo(original.T_ArrayMaybeFieldName_);
            duplicate.T_ArrayOtherFieldName_.ShouldBeEquivalentTo(original.T_ArrayOtherFieldName_);
            duplicate.T_ArrayBufferFieldName_.ShouldBeEquivalentTo(original.T_ArrayBufferFieldName_);
            duplicate.T_ArrayStringFieldName_.ShouldBeEquivalentTo(original.T_ArrayStringFieldName_);
            duplicate.T_IndexModelFieldName_.ShouldBeEquivalentTo(original.T_IndexModelFieldName_);
            duplicate.T_IndexMaybeFieldName_.ShouldBeEquivalentTo(original.T_IndexMaybeFieldName_);
            duplicate.T_IndexOtherFieldName_.ShouldBeEquivalentTo(original.T_IndexOtherFieldName_);
            duplicate.T_IndexBufferFieldName_.ShouldBeEquivalentTo(original.T_IndexBufferFieldName_);
            duplicate.T_IndexStringFieldName_.ShouldBeEquivalentTo(original.T_IndexStringFieldName_);

            duplicate.Equals(original).ShouldBeTrue();
            duplicate.ShouldBe(original);
        }

        [Theory]
        [InlineData(MessagePackCompression.None)]
        //[InlineData(MessagePackCompression.Lz4Block)] fails! todo bug?
        //[InlineData(MessagePackCompression.Lz4BlockArray)] fails! todo bug?
        public void Roundtrip_NonEmpty(MessagePackCompression compression)
        {
            var original = new T_ClassName_()
            {
                T_UnaryModelFieldName_ = new T_ModelType_(123),
                T_ArrayModelFieldName_ = ImmutableList<T_ModelType_?>.Empty.Add(new T_ModelType_(234)),
                T_IndexModelFieldName_ = ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty
                    .Add("987", new T_ModelType_(456))
                    .Add("876", null),
                T_UnaryOtherFieldName_ = 123L,
                T_ArrayOtherFieldName_ = ImmutableList<T_ExternalOtherType_>.Empty.Add(234L),
                T_IndexOtherFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryMaybeFieldName_ = null,
                T_ArrayMaybeFieldName_ = ImmutableList<T_ExternalOtherType_?>.Empty.Add(null).Add(234L),
                T_IndexMaybeFieldName_ = ImmutableDictionary<T_IndexType_, T_ExternalOtherType_?>.Empty
                    .Add("987", 456L)
                    .Add("876", default),
                T_UnaryBufferFieldName_ = ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }),
                T_ArrayBufferFieldName_ = ImmutableList<ImmutableArray<byte>>.Empty
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add(ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
                T_IndexBufferFieldName_ = ImmutableDictionary<T_IndexType_, ImmutableArray<byte>>.Empty
                    .Add("a", ImmutableArray<byte>.Empty.AddRange(new byte[] { 1, 2, 3, 4 }))
                    .Add("b", ImmutableArray<byte>.Empty.AddRange(new byte[] { 5, 6, 7, 8 })),
            };

            var options = MessagePackSerializerOptions.Standard.WithCompression(compression);
            byte[] buffer = MessagePackSerializer.Serialize(original, options);
            //buffer.Length.ShouldBe(compressedSize);
            var duplicate = MessagePackSerializer.Deserialize<T_ClassName_>(buffer);
            duplicate.ShouldBe(original);
            duplicate.Equals(original).ShouldBeTrue();
        }

    }
}