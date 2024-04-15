namespace Data
{
    class Column
    {
        public Column(string columnName, string dataType, bool isPrimaryKey)
        {
            this.ColumnName = columnName;
            this.DataType = dataType;
            this.IsPrimaryKey = isPrimaryKey;
        }
        public string ColumnName { get; }
        public string DataType { get;  }
        public bool IsPrimaryKey { get;  }
    }
}