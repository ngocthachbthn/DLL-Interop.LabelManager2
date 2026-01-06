namespace LabelManager2
{
    using System;

    public enum EnumImageDitherMethod
    {
        objsImageDitherMethodNone = 0,
        objsImageDitherMethodBayer = 1,
        objsImageDitherMethodBurkes = 2,
        objsImageDitherMethodFloyd = 4,
        objsImageDitherMethodGrayscale = 8,
        objsImageDitherMethodFixedPalette = 0x10,
        objsImageDitherMethodOcPreePalette = 0x20,
        objsImageDitherMethodMedianCut = 0x40
    }
}

