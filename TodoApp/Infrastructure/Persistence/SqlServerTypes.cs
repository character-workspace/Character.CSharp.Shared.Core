namespace TodoApp.Infrastructure.Persistence;

public static class SqlServerTypes
{
    public const string DateTime2 = "DATETIME2";
    
    public const string NVarcharMax = "nvarchar(max)";
    
    public static string Varchar(int length) => $"VARCHAR({length})";
}