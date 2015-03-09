﻿using Hl7.Fhir.Introspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spark.Core
{
    public static class EnumHelper
    {

        public static string GetLiteral(Enum item)
        {
            Type type = item.GetType();
            EnumMapping mapping = EnumMapping.Create(type);

            // Caching these mappings should probably optimize performance. But for now load seems managable.
            string literal = mapping.GetLiteral(item);
            return literal;
        }

    }
}
