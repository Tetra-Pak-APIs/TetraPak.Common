using TetraPak.Serialization;
using Xunit;

namespace TetraPak.Common.Tests
{
    public class JsonKeyFormatTests
    {
        [Fact]
        public void CamelCaseTests()
        {
            const string Expected = "camelCase";
            Assert.Equal(Expected, "camelCase".ToCamelCaseIdentifier());
            Assert.Equal(Expected, "CamelCase".ToCamelCaseIdentifier());
            Assert.Equal(Expected, "camel_case".ToCamelCaseIdentifier());
            Assert.Equal(Expected, "camel_Case".ToCamelCaseIdentifier());
            Assert.Equal(Expected, "camel-case".ToCamelCaseIdentifier());
            Assert.Equal(Expected, "camel-Case".ToCamelCaseIdentifier());
        }
        
        [Fact]
        public void PascalCaseTests()
        {
            const string Expected = "PascalCase";
            Assert.Equal(Expected, "pascalCase".ToPascalCaseIdentifier());
            Assert.Equal(Expected, "PascalCase".ToPascalCaseIdentifier());
            Assert.Equal(Expected, "pascal_case".ToPascalCaseIdentifier());
            Assert.Equal(Expected, "pascal_Case".ToPascalCaseIdentifier());
            Assert.Equal(Expected, "pascal-case".ToPascalCaseIdentifier());
            Assert.Equal(Expected, "pascal-Case".ToPascalCaseIdentifier());
        }
        
        [Fact]
        public void SnakeCaseTests()
        {
            const string Expected = "snake_case";
            Assert.Equal(Expected, "snakeCase".ToSnakeCaseIdentifier());
            Assert.Equal(Expected, "SnakeCase".ToSnakeCaseIdentifier());
            Assert.Equal(Expected, "snake_case".ToSnakeCaseIdentifier());
            Assert.Equal(Expected, "snake_Case".ToSnakeCaseIdentifier());
            Assert.Equal(Expected, "snake-case".ToSnakeCaseIdentifier());
            Assert.Equal(Expected, "snake-Case".ToSnakeCaseIdentifier());
        }
        
        [Fact]
        public void KebabCaseTests()
        {
            const string Expected = "kebab-case";
            Assert.Equal(Expected, "kebabCase".ToKebabCaseIdentifier());
            Assert.Equal(Expected, "KebabCase".ToKebabCaseIdentifier());
            Assert.Equal(Expected, "kebab_case".ToKebabCaseIdentifier());
            Assert.Equal(Expected, "kebab_Case".ToKebabCaseIdentifier());
            Assert.Equal(Expected, "kebab-case".ToKebabCaseIdentifier());
            Assert.Equal(Expected, "kebab-Case".ToKebabCaseIdentifier());
        }
        
    }
}