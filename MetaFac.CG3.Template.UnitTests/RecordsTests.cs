using Shouldly;
using System.Collections.Generic;
using System.Collections.Immutable;
using T_Namespace_.Interfaces;
using T_Namespace_.Records;
using Xunit;

namespace MetaFac.CG3.Template.UnitTests
{
    using T_ConcreteOtherType_ = System.Int64;
    using T_IndexType_ = System.String;

    public class RecordsTests
    {
        [Fact]
        public void Create_Empty()
        {
            var concrete = T_ClassName_.Empty;
            concrete.T_UnaryModelFieldName_.ShouldBeNull();
            concrete.T_ArrayModelFieldName_.ShouldBeNull();
            concrete.T_IndexModelFieldName_.ShouldBeNull();
            concrete.T_UnaryOtherFieldName_.ShouldBe(default);
            concrete.T_ArrayOtherFieldName_.ShouldBeNull();
            concrete.T_IndexOtherFieldName_.ShouldBeNull();
            concrete.T_UnaryMaybeFieldName_.ShouldBeNull();
            concrete.T_ArrayMaybeFieldName_.ShouldBeNull();
            concrete.T_IndexMaybeFieldName_.ShouldBeNull();
            concrete.T_UnaryBufferFieldName_.ShouldBeNull();
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
            external.T_UnaryBufferFieldName_.ShouldBeNull();
            external.T_ArrayBufferFieldName_.ShouldBeNull();
            external.T_IndexBufferFieldName_.ShouldBeNull();
            external.T_UnaryStringFieldName_.ShouldBeNull();
            external.T_ArrayStringFieldName_.ShouldBeNull();
            external.T_IndexStringFieldName_.ShouldBeNull();

            var duplicate = new T_ClassName_(external);
            duplicate.T_UnaryModelFieldName_.ShouldBeNull();
            duplicate.T_ArrayModelFieldName_.ShouldBeNull();
            duplicate.T_IndexModelFieldName_.ShouldBeNull();
            duplicate.T_UnaryOtherFieldName_.ShouldBe(default);
            duplicate.T_ArrayOtherFieldName_.ShouldBeNull();
            duplicate.T_IndexOtherFieldName_.ShouldBeNull();
            duplicate.T_UnaryMaybeFieldName_.ShouldBeNull();
            duplicate.T_ArrayMaybeFieldName_.ShouldBeNull();
            duplicate.T_IndexMaybeFieldName_.ShouldBeNull();
            duplicate.T_UnaryBufferFieldName_.ShouldBeNull();
            duplicate.T_ArrayBufferFieldName_.ShouldBeNull();
            duplicate.T_IndexBufferFieldName_.ShouldBeNull();
            duplicate.T_UnaryStringFieldName_.ShouldBeNull();
            duplicate.T_ArrayStringFieldName_.ShouldBeNull();
            duplicate.T_IndexStringFieldName_.ShouldBeNull();

            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }

        [Fact]
        public void Create_NonEmpty()
        {
            var concrete = new T_ClassName_()
            {
                T_UnaryModelFieldName_ = new T_ModelType_(123),
                T_ArrayModelFieldName_ = ImmutableList<T_ModelType_?>.Empty.AddRange(new[] { new T_ModelType_(234) }),
                T_IndexModelFieldName_ = ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty.AddRange(new[]
                {
                    new KeyValuePair<T_IndexType_, T_ModelType_?>("987", new T_ModelType_(456)),
                    new KeyValuePair<T_IndexType_, T_ModelType_?>("876", null)
                }),
                T_UnaryOtherFieldName_ = 123L,
                T_ArrayOtherFieldName_ = ImmutableList<T_ConcreteOtherType_>.Empty.AddRange(new[] { 234L }),
                T_IndexOtherFieldName_ = ImmutableDictionary<T_IndexType_, T_ConcreteOtherType_>.Empty.AddRange(new[]
                {
                    new KeyValuePair<T_IndexType_, T_ConcreteOtherType_>("987", 456L),
                    new KeyValuePair<T_IndexType_, T_ConcreteOtherType_>("876", default)
                }),
                T_UnaryMaybeFieldName_ = null,
                T_ArrayMaybeFieldName_ = ImmutableList<T_ConcreteOtherType_?>.Empty.AddRange(new T_ConcreteOtherType_?[] { 234L }),
                T_IndexMaybeFieldName_ = ImmutableDictionary<T_IndexType_, T_ConcreteOtherType_?>.Empty.AddRange(new[]
                {
                    new KeyValuePair<T_IndexType_, T_ConcreteOtherType_?>("987", 456L),
                    new KeyValuePair<T_IndexType_, T_ConcreteOtherType_?>("876", default)
                }),
            };

            IT_ClassName_ external = concrete;
            external.T_UnaryModelFieldName_.ShouldNotBeNull();
            external.T_ArrayModelFieldName_.ShouldNotBeNull();
            external.T_IndexModelFieldName_.ShouldNotBeNull();
            external.T_UnaryOtherFieldName_.ShouldBe(123L);
            external.T_ArrayOtherFieldName_.ShouldNotBeNull();
            external.T_IndexOtherFieldName_.ShouldNotBeNull();
            external.T_UnaryMaybeFieldName_.ShouldBeNull();
            external.T_ArrayMaybeFieldName_.ShouldNotBeNull();
            external.T_IndexMaybeFieldName_.ShouldNotBeNull();

            var duplicate = new T_ClassName_(external);
            duplicate.T_UnaryModelFieldName_.ShouldBe(concrete.T_UnaryModelFieldName_);
            duplicate.T_UnaryMaybeFieldName_.ShouldBe(concrete.T_UnaryMaybeFieldName_);
            duplicate.T_UnaryOtherFieldName_.ShouldBe(concrete.T_UnaryOtherFieldName_);
            Equals(duplicate.T_UnaryBufferFieldName_, concrete.T_UnaryBufferFieldName_).ShouldBeTrue();
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

            duplicate.Equals(concrete).ShouldBeTrue();
            duplicate.ShouldBe(concrete);
        }
    }
}
