namespace CloudResourceApi.Types;

public record Server(
    int Id,
    string Name,
    string OperatingSystem,
    string Status
);