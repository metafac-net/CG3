﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace MetaFac.CG3.Models
{
    public class JsonModelDef : IEquatable<JsonModelDef>
    {
        public int? Tag { get; set; }
        public string? Name { get; set; }
        public List<JsonClassDef>? ClassDefs { get; set; }
        public Dictionary<string, string>? Tokens { get; set; }

        public JsonModelDef() { }

        public JsonModelDef(ModelDefinition source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            Tag = source.Tag;
            Name = source.Name;
            ClassDefs = source.ClassDefs.Select(cd => new JsonClassDef(cd)).ToList();
            Tokens = new Dictionary<string, string>(source.Tokens);
        }

        public bool Equals(JsonModelDef? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return Tag == other.Tag
                   && string.Equals(Name, other.Name)
                   && ClassDefs.IsEqualTo(other.ClassDefs)
                   && Tokens.IsEqualTo(other.Tokens);
        }

        public override bool Equals(object? obj)
        {
            return obj is JsonModelDef other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Tag?.GetHashCode() ?? 0;
                hashCode = hashCode * 397 ^ (Name?.GetHashCode() ?? 0);
                // order sensitive
                if (ClassDefs != null)
                {
                    hashCode = hashCode * 397 ^ ClassDefs.Count.GetHashCode();
                    for (int i = 0; i < ClassDefs.Count; i++)
                    {
                        hashCode = hashCode * 397 ^ ClassDefs[i].GetHashCode();
                    }
                }
                // order ignored
                if (Tokens != null)
                {
                    hashCode = hashCode * 397 ^ Tokens.Count.GetHashCode();
                    foreach (var kvp in Tokens)
                    {
                        hashCode = hashCode ^ kvp.Key.GetHashCode();
                        if (kvp.Value != null) hashCode = hashCode ^ kvp.Value.GetHashCode();
                    }
                }
                return hashCode;
            }
        }
    }
}