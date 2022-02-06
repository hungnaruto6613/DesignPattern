using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builder
{
    public class FieldCode
    {
        public string FieldName, TypeName;
        public override string ToString()
        {
            return $"public {TypeName} {FieldName};";
        }
    }

    public class ClassCode
    {
        public string ClassName;
        public List<FieldCode> Fields = new List<FieldCode>();
 
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {ClassName}");
            sb.AppendLine("{");
            foreach (FieldCode field in Fields)
            {
                sb.AppendLine($"{new string(' ', 4)} {field.ToString()}");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class ClassBuilder
    {
        private ClassCode code = new ClassCode();
        public ClassBuilder(string className)
        {
            code.ClassName = className;
        }

        public ClassBuilder AddField(string fieldName, string typeName)
        {
            code.Fields.Add(new FieldCode()
            {
                FieldName = fieldName,
                TypeName = typeName
            });
            return this;
        }

        public override string ToString()
        {
            return code.ToString();
        }
    }
}
