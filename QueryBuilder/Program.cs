using System;

using System.Text;

public class QueryBuilder
{
    private string selectClause = "";
    private string fromClause = "";
    private string whereClause = "";
    private string orderByClause = "";

    public QueryBuilder Select(string columns)
    {
        selectClause = $"SELECT {columns}";
        return this;
    }

    public QueryBuilder From(string table)
    {
        fromClause = $"FROM {table}";
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        whereClause = $"WHERE {condition}";
        return this;
    }

    public QueryBuilder OrderBy(string column)
    {
        orderByClause = $"ORDER BY {column}";
        return this;
    }

    public string Build()
    {
        StringBuilder sb = new StringBuilder();

        if (!string.IsNullOrEmpty(selectClause))
            sb.Append(selectClause + " ");

        if (!string.IsNullOrEmpty(fromClause))
            sb.Append(fromClause + " ");

        if (!string.IsNullOrEmpty(whereClause))
            sb.Append(whereClause + " ");

        if (!string.IsNullOrEmpty(orderByClause))
            sb.Append(orderByClause);

        return sb.ToString().Trim();
    }
}