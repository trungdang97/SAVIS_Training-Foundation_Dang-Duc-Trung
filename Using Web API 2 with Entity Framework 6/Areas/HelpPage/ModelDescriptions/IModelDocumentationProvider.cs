using System;
using System.Reflection;

namespace Using_Web_API_2_with_Entity_Framework_6.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}