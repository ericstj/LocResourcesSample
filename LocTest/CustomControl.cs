using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocTest
{
    public partial class CustomControl : Control
    {
        public CustomControl()
        {
            InitializeComponent();
            ByteArrayProp = new byte[8];
            StreamProp = new MemoryStream(new byte[8]);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        [Category("Loc")]
        [Localizable(true)]
        public string StringProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public int IntProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public bool BoolProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public char CharProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public byte ByteProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public sbyte SByteProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public short ShortProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public long LongProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public ushort UShortProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public uint UIntProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public ulong ULongProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public float FloatProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public double DoubleProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        public decimal DecimalProp { get; set; }


        [Category("Loc")]
        [Localizable(true)]
        public DateTime DateTimeProp { get; set; }


        [Category("Loc")]
        [Localizable(true)]
        public TimeSpan TimeSpanProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        [Editor(typeof(System.ComponentModel.Design.ArrayEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public byte[] ByteArrayProp { get; set; }

        [Category("Loc")]
        [Localizable(true)]
        [Editor(typeof(BinaryEditor), typeof(UITypeEditor))]
        public Stream StreamProp { get; set; }


    }
}
