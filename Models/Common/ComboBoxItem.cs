using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Models.Common
{
    public class ComboBoxItem<T>
    {
        public const string DisplayMember = "Text";
        public const string ValueMember = "Value";
        public string Text { get; set; }
        public T Value { get; set; }

        public ComboBoxItem(string text , T value)
        {
            Text = text;
            Value = value;
        }
    }
}
