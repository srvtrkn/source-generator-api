namespace Application.Attributes;

[AttributeUsage(AttributeTargets.Interface)]
public sealed class GenerateApiEndpointAttribute : Attribute
{
    public string RoutePrefix { get; set; } = string.Empty;
    public string Tag { get; set; } = string.Empty;
}
