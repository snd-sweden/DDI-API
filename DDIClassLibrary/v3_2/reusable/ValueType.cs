﻿using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ValueType
    {
        public ValueType()
        {
        }

        public ValueType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space { get; set; }
        
        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(ValueType content)
        {
            return content.Content;
        }

        public static implicit operator ValueType(string n)
        {
            return new ValueType(n);
        }

        public override bool Equals(object obj)
        {
            return this.Content == (string)obj;
        }

        public override int GetHashCode()
        {
            return this.Content.GetHashCode();
        }

        #endregion conversion

        #region unary

        public static ValueType operator +(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator -(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator !(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator ~(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator ++(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator --(ValueType content)
        {
            throw new Exception();
        }

        public static bool operator true(ValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(ValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ValueType operator +(ValueType content, string n)
        {
            return content.Content + n;
        }

        public static ValueType operator -(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator *(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator /(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator %(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator &(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator |(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator ^(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator <<(ValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ValueType operator >>(ValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ValueType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ValueType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ValueType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}