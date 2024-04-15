namespace ModernizedCode
{
    public class Column
    {
        public Column()
        {
            ColumnName = "Column 1";
            DataType = "string";
            IsPrimaryKey = false;
        }
        public string ColumnName { get; init; }
        public string DataType { get; set; }
        public bool IsPrimaryKey { get; set; }
    }

    
    
    
    
    
    
    class UseColumn
    {
        public void Initialize()
        {
  
        }
    }
}