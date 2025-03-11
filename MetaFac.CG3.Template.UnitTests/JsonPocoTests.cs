using Shouldly;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using T_Namespace_.Interfaces;
using T_Namespace_.JsonPoco;
using Xunit;

namespace MetaFac.CG3.Template.UnitTests
{
    using T_ConcreteOtherType_ = System.Int64;
    //>>using (Ignored()) {
    using T_IndexType_ = System.String;
    //>>}

    public class JsonPocoTests
    {
        [Fact]
        public void Create_Empty()
        {
            var concrete = new T_ClassName_();
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
            external.T_UnaryStringFieldName_.ShouldBe(default);
            external.T_ArrayStringFieldName_.ShouldBeNull();
            external.T_IndexStringFieldName_.ShouldBeNull();

            var duplicate = new T_ClassName_(external);
            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }

        [Fact]
        public void Create_NonEmpty()
        {
            var concrete = new T_ClassName_();
            concrete.T_UnaryModelFieldName_ = new T_ModelType_() { TestData = 123 };
            concrete.T_ArrayModelFieldName_ = new[] { new T_ModelType_() { TestData = 234 } };
            concrete.T_IndexModelFieldName_ = new Dictionary<T_IndexType_, T_ModelType_?>()
            {
                ["987"] = new T_ModelType_() { TestData = 456 },
                ["876"] = null,
            };

            concrete.T_UnaryOtherFieldName_ = 123L;
            concrete.T_ArrayOtherFieldName_ = new[] { 234L };
            concrete.T_IndexOtherFieldName_ = new Dictionary<T_IndexType_, T_ConcreteOtherType_>()
            {
                ["987"] = 456L,
                ["876"] = default,
            };

            concrete.T_UnaryMaybeFieldName_ = null;
            concrete.T_ArrayMaybeFieldName_ = new T_ConcreteOtherType_?[] { null, 234L };
            concrete.T_IndexMaybeFieldName_ = new Dictionary<T_IndexType_, T_ConcreteOtherType_?>()
            {
                ["987"] = 456L,
                ["876"] = null,
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
            duplicate.ShouldBe(concrete);
            duplicate.Equals(concrete).ShouldBeTrue();
        }

        [Fact]
        public void Roundtrip_Json_Empty()
        {
            var original = new T_ClassName_();
            var options = new JsonSerializerOptions() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            string json = JsonSerializer.Serialize(original, options);
            json.ShouldBe("{\"T_UnaryOtherFieldName_\":0}");
            var duplicate = JsonSerializer.Deserialize<T_ClassName_>(json);
            duplicate.ShouldBe(original);
            duplicate!.Equals(original).ShouldBeTrue();
        }

        [Fact]
        public void Roundtrip_Json_NonEmpty()
        {
            var original = new T_ClassName_();
            original.T_UnaryModelFieldName_ = new T_ModelType_() { TestData = 123 };
            original.T_ArrayModelFieldName_ = new[] { new T_ModelType_() { TestData = 234 } };
            original.T_IndexModelFieldName_ = new Dictionary<T_IndexType_, T_ModelType_?>()
            {
                ["987"] = new T_ModelType_() { TestData = 456 },
                ["876"] = null,
            };

            original.T_UnaryOtherFieldName_ = 123L;
            original.T_ArrayOtherFieldName_ = new[] { 234L };
            original.T_IndexOtherFieldName_ = new Dictionary<T_IndexType_, T_ConcreteOtherType_>()
            {
                ["987"] = 456L,
                ["876"] = default,
            };

            original.T_UnaryMaybeFieldName_ = null;
            original.T_ArrayMaybeFieldName_ = new T_ConcreteOtherType_?[] { null, 234L };
            original.T_IndexMaybeFieldName_ = new Dictionary<T_IndexType_, T_ConcreteOtherType_?>()
            {
                ["987"] = 456L,
                ["876"] = null,
            };

            string json = JsonSerializer.Serialize(original);
            var duplicate = JsonSerializer.Deserialize<T_ClassName_>(json);
            duplicate.ShouldBe(original);
            duplicate!.Equals(original).ShouldBeTrue();
        }

    }
}