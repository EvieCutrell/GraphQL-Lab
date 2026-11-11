namespace CloudResourceApi.Types;

[QueryType]
public static partial class Query
{
    public static Server GetServer() => 
        new Server(
            1,
            "web-server-01",
            "Ubuntu 24.04",
            "Running"
        );    
}
