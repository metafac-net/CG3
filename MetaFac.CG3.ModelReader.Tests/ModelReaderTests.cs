using Shouldly;
using MetaFac.CG3.Models;
using System.Linq;
using System.Reflection;
using Xunit;

namespace MetaFac.CG3.ModelReader.Tests
{
    public class ModelReaderTests
    {
        [Fact]
        public void RoundtripModelViaJson()
        {
            // arrange
            string ns = typeof(TestModel.BuiltinTypes).Namespace!;
            ModelContainer metadata = ModelParser.ParseAssembly(Assembly.GetExecutingAssembly(), ns);
            metadata.Tokens.Count.ShouldBe(0);
            metadata.ModelDefs.Count.ShouldBe(1);
            string originalJson = metadata.ToJson(true);

            // act
            var metadata2 = ModelContainer.FromJson(originalJson);

            // assert
            metadata2.ShouldBe(metadata);

            // act again
            string duplicateJson = metadata2.ToJson(true);

            // assert
            duplicateJson.ShouldBe(originalJson);
        }

        [Fact]
        public void ReadBuiltinTypes()
        {
            string ns = typeof(TestModel.BuiltinTypes).Namespace!;
            ModelContainer metadata = ModelParser.ParseAssembly(Assembly.GetExecutingAssembly(), ns);
            metadata.Tokens.Count.ShouldBe(0);
            metadata.ModelDefs.Count.ShouldBe(1);
            var modelDef = metadata.ModelDefs[0];
            modelDef.Tokens.Count.ShouldBe(0);
            modelDef.ClassDefs.Count.ShouldBe(3);
            var classDef = modelDef.ClassDefs[0];
            classDef.Name.ShouldBe("BuiltinTypes");
            classDef.Tokens.Count.ShouldBe(0);
            classDef.FieldDefs.Count.ShouldBe(19);
        }

        [Fact]
        public void ReadExternalTypes()
        {
            string ns = typeof(TestModel.ExternalTypes).Namespace!;
            ModelContainer metadata = ModelParser.ParseAssembly(Assembly.GetExecutingAssembly(), ns);
            metadata.Tokens.Count.ShouldBe(0);
            metadata.ModelDefs.Count.ShouldBe(1);
            var modelDef = metadata.ModelDefs[0];
            var classDef = modelDef.ClassDefs.Where(cd => cd.Name == "ExternalTypes").Single();
            classDef.Tokens.Count.ShouldBe(0);
            classDef.FieldDefs.Count.ShouldBe(1);

            // external type
            var field0 = classDef.FieldDefs[0];
            field0.Tag.ShouldBe(1);
            field0.Name.ShouldBe("Quantities");
            field0.ProxyDef.ShouldNotBeNull();
            field0.ProxyDef!.ExternalName.ShouldBe("LabApps.Units.Quantity");
            field0.ProxyDef.ConcreteName.ShouldBe("QuantityValue");
            field0.ArrayRank.ShouldBe(1);
            field0.InnerType.ShouldBe("Quantity");
        }

        [Fact]
        public void ReadEnumeratorTypes()
        {
            string ns = typeof(TestModel.ExternalTypes).Namespace!;
            ModelContainer metadata = ModelParser.ParseAssembly(Assembly.GetExecutingAssembly(), ns);
            metadata.Tokens.Count.ShouldBe(0);
            metadata.ModelDefs.Count.ShouldBe(1);
            var modelDef = metadata.ModelDefs[0];
            var classDef = modelDef.ClassDefs.Where(cd => cd.Name == "EnumeratorTypes").Single();
            classDef.Tokens.Count.ShouldBe(0);
            classDef.FieldDefs.Count.ShouldBe(3);

            // enumerator types
            {
                var fieldDef = classDef.FieldDefs[0];
                fieldDef.Tag.ShouldBe(1);
                fieldDef.Name.ShouldBe("DaysOfWeek");
                fieldDef.ProxyDef.ShouldBeNull();
                fieldDef.ArrayRank.ShouldBe(1);
                fieldDef.InnerType.ShouldBe("System.DayOfWeek");
            }
            {
                var fieldDef = classDef.FieldDefs[1];
                fieldDef.Tag.ShouldBe(2);
                fieldDef.Name.ShouldBe("MyCustomEnums");
                fieldDef.ProxyDef.ShouldBeNull();
                fieldDef.ArrayRank.ShouldBe(1);
                fieldDef.InnerType.ShouldBe("MetaFac.CG3.ModelReader.Tests.TestModel.MyCustomEnum");
            }
            {
                var fieldDef = classDef.FieldDefs[2];
                fieldDef.Tag.ShouldBe(3);
                fieldDef.Name.ShouldBe("MyDateTimeKinds");
                fieldDef.ProxyDef.ShouldNotBeNull();
                fieldDef.ProxyDef!.ExternalName.ShouldBe("System.DateTimeKind");
                fieldDef.ProxyDef.ConcreteName.ShouldBe("MyDateTimeKindValue");
                fieldDef.ArrayRank.ShouldBe(1);
                fieldDef.InnerType.ShouldBe("MyDateTimeKind");
            }
        }

    }
}