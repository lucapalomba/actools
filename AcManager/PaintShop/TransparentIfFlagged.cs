﻿using System.Windows.Media;
using JetBrains.Annotations;

namespace AcManager.PaintShop {
    public class TransparentIfFlagged : SolidColorIfFlagged {
        public TransparentIfFlagged([NotNull] TextureFileName[] textures, bool inverse) : base(textures, inverse, Colors.Black, 0d) { }

        public override string DisplayName { get; set; } = "Transparent If Enabled";
    }
}