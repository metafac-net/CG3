using MetaFac.Collections.Freezables;
using Shouldly;
using System.Collections.Generic;
using T_Namespace_.Freezables;
using T_Namespace_.Interfaces;
using Xunit;

namespace MetaFac.CG3.Template.UnitTests
{
    using T_ConcreteOtherType_ = System.Int64;
    //>>using (Ignored()) {
    using T_IndexType_ = System.String;
    //>>}

    public class FreezablesTests
    {
        [Fact]
        public void Create_Empty()
        {
            var concrete = new T_ClassName_();
            concrete.IsFrozen().ShouldBeFalse();
            concrete.Freeze();
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
            duplicate.IsFrozen().ShouldBeFalse();
            duplicate.Freeze();
            duplicate.IsFrozen().ShouldBeTrue();
            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }

        [Fact]
        public void Create_NonEmpty()
        {
            var concrete = new T_ClassName_();
            concrete.IsFrozen().ShouldBeFalse();
            concrete.T_UnaryModelFieldName_ = new T_ModelType_(123);
            concrete.T_ArrayModelFieldName_ = new FreezableArray<T_ModelType_?>(new[] { new T_ModelType_(234) });
            concrete.T_IndexModelFieldName_ = new FreezableHashedDictionary<T_IndexType_, T_ModelType_?>(new[]
            {
                new KeyValuePair<T_IndexType_, T_ModelType_?>("987", new T_ModelType_(456)),
                new KeyValuePair<T_IndexType_, T_ModelType_?>("876", null)
            });

            concrete.T_UnaryOtherFieldName_ = 123L;
            concrete.T_ArrayOtherFieldName_ = new FreezableArray<T_ConcreteOtherType_>(new[] { 234L });
            concrete.T_IndexOtherFieldName_ = new FreezableHashedDictionary<T_IndexType_, T_ConcreteOtherType_>(new[]
            {
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_>("987", 456L),
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_>("876", default)
            });

            concrete.T_UnaryMaybeFieldName_ = null;
            concrete.T_ArrayMaybeFieldName_ = new FreezableArray<T_ConcreteOtherType_?>(new T_ConcreteOtherType_?[] { 234L });
            concrete.T_IndexMaybeFieldName_ = new FreezableHashedDictionary<T_IndexType_, T_ConcreteOtherType_?>(new[]
            {
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_?>("987", 456L),
                new KeyValuePair<T_IndexType_, T_ConcreteOtherType_?>("876", default)
            });
            concrete.Freeze();
            concrete.IsFrozen().ShouldBeTrue();

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
            duplicate.IsFrozen().ShouldBeFalse();
            duplicate.Freeze();
            duplicate.IsFrozen().ShouldBeTrue();
            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }
    }
}