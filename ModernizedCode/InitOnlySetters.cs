namespace InitOnlySetters
{
    
    class CallingCode
    {
        public void Call()
        {
            /*
             * can't do the following with a readonly field or getter only.
             * therefore data must be initialized in the constructor,
             * unless you use an init only setter.
             * 
             * var columnName = new Column { ColumnName="" };
             */
            
            var column = new Column();
            var col = new Column { ColumnName="" };
        }
    }
    
    
    class Column
    {
        public Column()
        {
            // use "move to initializer" refactor to improve
            // convert these to auto-implemented properties  

            DataType = "string";
            IsPrimaryKey = false;
        }
        
        public string ColumnName { get; init; } = "Column 1";
        public string DataType { get;  }
        public bool IsPrimaryKey { get;  }
    }
    
    
    
    
}