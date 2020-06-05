using System;

namespace KhongMinhKhiem_LAB456.Models
{
    internal class StingLenghtAttribute : Attribute
    {
        private int v;

        public StingLenghtAttribute(int v)
        {
            this.v = v;
        }
    }
}