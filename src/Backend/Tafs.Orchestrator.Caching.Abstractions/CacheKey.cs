﻿//
//  CacheKey.cs
//
//  Author:
//       Devin Duanne <dduanne@tafs.com>
//
//  Copyright (c) TAFS, LLC.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Text;
using JetBrains.Annotations;

namespace Tafs.Orchestrator.Caching.Abstractions
{
    /// <summary>
    /// The base type for a cache key.
    /// </summary>
    [PublicAPI]
    public abstract record CacheKey
    {
        /// <summary>
        /// Appends the canonical string representation of this cache key to <paramref name="stringBuilder"/>.
        /// </summary>
        /// <param name="stringBuilder">The <see cref="StringBuilder"/>.</param>
        /// <returns>The original <paramref name="stringBuilder"/>, for chaining.</returns>
        protected abstract StringBuilder AppendToString(StringBuilder stringBuilder);

        /// <summary>
        /// Gets the canonical string representation of this cache key.
        /// </summary>
        /// <returns>The canonical string representation of this cache key.</returns>
        public virtual string ToCanonicalString()
        {
            return AppendToString(new StringBuilder()).ToString();
        }

        private sealed record StringCacheKey(string KeyString) : CacheKey
        {
            // We provide an implementation here to avoid the StringBuilder call when the key only contains a simple string.
            public override string ToCanonicalString()
                => KeyString;

            protected override StringBuilder AppendToString(StringBuilder stringBuilder)
                => stringBuilder.Append(KeyString);
        }

        private sealed record ResourceCacheKey(string Context, string KeyString) : CacheKey
        {
            // We provide an implementation here to avoid the StringBuilder call when the key only contains a simple string
            // concatenation.
            public override string ToCanonicalString()
                => $"{Context}:{KeyString}";

            protected override StringBuilder AppendToString(StringBuilder stringBuilder)
                => stringBuilder.Append($"{Context}:{KeyString}");
        }

        /// <summary>
        /// Creates a string-based cache key from an input string.
        /// </summary>
        /// <param name="keyString">The key string.</param>
        /// <returns>
        /// A new string-based cache key. This key is equal to other keys created by this method as long as
        /// <paramref name="keyString"/> is the same.</returns>
        public static CacheKey StringKey(string keyString)
        {
            return new StringCacheKey(keyString);
        }

        /// <summary>
        /// Creates a string-based cache key from a context string and key string. The context of a key can be, for
        /// instance, a GUID or the name of the application domain that manages this key. Therefore, two keys with the same
        /// <paramref name="keyString"/> can be functionally distinct by belonging to different contexts.
        /// </summary>
        /// <param name="context">The key context.</param>
        /// <param name="keyString">The key string.</param>
        /// <returns>
        /// A new string-based cache key. This key is equal to other keys created by this method as long as
        /// <paramref name="context"/> and <paramref name="keyString"/> are the same.</returns>
        /// <remarks>
        /// <paramref name="context"/> should not contain <c>:</c> (colon symbol) as this can make the separation between
        /// context and key string ambiguous.
        /// </remarks>
        public static CacheKey LocalizedStringKey(string context, string keyString)
        {
            return new ResourceCacheKey(context, keyString);
        }
    }
}
