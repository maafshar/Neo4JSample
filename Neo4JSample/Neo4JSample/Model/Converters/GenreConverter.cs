﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Neo4JSample.Converters.Parameters;

namespace Neo4JSample.Model.Converters
{
    public class GenreConverter : BaseDictionaryConverter<Genre>
    {
        protected override void InternalConvert(Genre source, Dictionary<string, object> target)
        {
            target["name"] = source.Name;
        }
    }
}
