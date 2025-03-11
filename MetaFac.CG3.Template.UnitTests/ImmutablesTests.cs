using Shouldly;
using System.Collections.Generic;
using System.Collections.Immutable;
using T_Namespace_.Immutables;
using T_Namespace_.Interfaces;
using Xunit;

namespace MetaFac.CG3.Template.UnitTests
{
    using T_ConcreteOtherType_ = System.Int64;
    //>>using (Ignored()) {
    using T_IndexType_ = System.String;
    //>>}

    public class ImmutablesTests
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

            var duplicate = new T_ClassName_(external);
            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }

        [Fact]
        public void Create_NonEmpty()
        {
            var builder = T_ClassName_.Empty.ToBuilder();
            builder.T_UnaryModelFieldName_ = new T_ModelType_(123);
            builder.T_ArrayModelFieldName_ = ImmutableList<T_ModelType_?>.Empty.AddRange(new[] { new T_ModelType_(234) });
            builder.T_IndexModelFieldName_ = ImmutableDictionary<T_IndexType_, T_ModelType_?>.Empty.AddRange(new[]
            {
                new KeyValuePair<T_IndexType_, T_ModelType_?>("987", new T_ModelType_(456)),
                new KeyValuePair<T_IndexType_, T_ModelType_?>("876", null)
            });

            builder.T_UnaryOtherFieldName_ = 123L;
            builder.T_ArrayOtherFieldName_ = ImmutableList<T_ConcreteOtherType_>.Empty.AddRange(new[] { 234L });
            builder.T_IndexOtherFieldName_ = ImmutableDictionary<T_IndexType_, T_ConcreteOtherType_>.Empty.AddRange(new[]
            {
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_>("987", 456L),
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_>("876", default)
            });

            builder.T_UnaryMaybeFieldName_ = null;
            builder.T_ArrayMaybeFieldName_ = ImmutableList<T_ConcreteOtherType_?>.Empty.AddRange(new T_ConcreteOtherType_?[] { 234L });
            builder.T_IndexMaybeFieldName_ = ImmutableDictionary<T_IndexType_, T_ConcreteOtherType_?>.Empty.AddRange(new[]
            {
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_?>("987", 456L),
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_?>("876", default)
            });

            T_ClassName_ concrete = builder.Build();

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
            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }
    }
}