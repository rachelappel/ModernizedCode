﻿namespace ModernizedCode.Misc;

public class RawStrings
{
   void MakeString()
   {
        var longMessage = """
            This is a long message.
            It has several lines.
                Some are indented
                        more than others.
            Some should start at the first column.
            Some have "quoted text" in them.
        """;
   }
}