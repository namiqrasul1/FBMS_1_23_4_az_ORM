namespace Lesson10Dapper.Models.DTOs;

public record BookDto
{
    public int Pages { get; init; }
    public string Name { get; init; }
}