namespace Core.Dto.Sample;

public record ResModel
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public int Age { get; init; }
}