﻿#region License
//  Copyright 1994-2024 DUWENINK - http://github.com/DUWENINK/dbhelpers
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
#endregion

using System;
using System.Data.Common;
using System.Globalization;

namespace DBHelpers
{
    public static class DataReaderExtensions
    {
        public static T Get<T>(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.To<T>(reader[ordinal], provider);
        }

        public static T Get<T>(this DbDataReader reader, int ordinal)
        {
            return DBConvert.To<T>(reader[ordinal], CultureInfo.CurrentCulture);
        }

        public static T Get<T>(this DbDataReader reader, string name, IFormatProvider provider)
        {
            return DBConvert.To<T>(reader[name], provider);
        }

        public static T Get<T>(this DbDataReader reader, string name)
        {
            return DBConvert.To<T>(reader[name], CultureInfo.CurrentCulture);
        }
    }
}
