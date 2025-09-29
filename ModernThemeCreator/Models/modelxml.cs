using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernThemeCreator.Models
{

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CustomTheme
    {
        private string idField;

        private CustomThemeAppHeaderColors appHeaderColorsField;

        private string basePaletteColorField;

        private byte vibrancyField;

        private sbyte hueTorsionField;

        private string fontField;

        /// <remarks/>
        public CustomThemeAppHeaderColors AppHeaderColors
        {
            get
            {
                return this.appHeaderColorsField;
            }
            set
            {
                this.appHeaderColorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string basePaletteColor
        {
            get
            {
                return this.basePaletteColorField;
            }
            set
            {
                this.basePaletteColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte vibrancy
        {
            get
            {
                return this.vibrancyField;
            }
            set
            {
                this.vibrancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte hueTorsion
        {
            get
            {
                return this.hueTorsionField;
            }
            set
            {
                this.hueTorsionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string font
        {
            get
            {
                return this.fontField;
            }
            set
            {
                this.fontField = value;
            }
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CustomThemeAppHeaderColors
    {

        private string backgroundField;

        private string foregroundField;

        private string backgroundHoverField;

        private string foregroundHoverField;

        private string backgroundPressedField;

        private string foregroundPressedField;

        private string backgroundSelectedField;

        private string foregroundSelectedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string background
        {
            get
            {
                return this.backgroundField;
            }
            set
            {
                this.backgroundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foreground
        {
            get
            {
                return this.foregroundField;
            }
            set
            {
                this.foregroundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string backgroundHover
        {
            get
            {
                return this.backgroundHoverField;
            }
            set
            {
                this.backgroundHoverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foregroundHover
        {
            get
            {
                return this.foregroundHoverField;
            }
            set
            {
                this.foregroundHoverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string backgroundPressed
        {
            get
            {
                return this.backgroundPressedField;
            }
            set
            {
                this.backgroundPressedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foregroundPressed
        {
            get
            {
                return this.foregroundPressedField;
            }
            set
            {
                this.foregroundPressedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string backgroundSelected
        {
            get
            {
                return this.backgroundSelectedField;
            }
            set
            {
                this.backgroundSelectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foregroundSelected
        {
            get
            {
                return this.foregroundSelectedField;
            }
            set
            {
                this.foregroundSelectedField = value;
            }
        }
    }


    //// NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    //public partial class AppHeaderColors
    //{
    //    private string idField;

    //    private string backgroundField;

    //    private string foregroundField;

    //    private string backgroundHoverField;

    //    private string foregroundHoverField;

    //    private string backgroundPressedField;

    //    private string foregroundPressedField;

    //    private string backgroundSelectedField;

    //    private string foregroundSelectedField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string background
    //    {
    //        get
    //        {
    //            return this.backgroundField;
    //        }
    //        set
    //        {
    //            this.backgroundField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string foreground
    //    {
    //        get
    //        {
    //            return this.foregroundField;
    //        }
    //        set
    //        {
    //            this.foregroundField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string backgroundHover
    //    {
    //        get
    //        {
    //            return this.backgroundHoverField;
    //        }
    //        set
    //        {
    //            this.backgroundHoverField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string foregroundHover
    //    {
    //        get
    //        {
    //            return this.foregroundHoverField;
    //        }
    //        set
    //        {
    //            this.foregroundHoverField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string backgroundPressed
    //    {
    //        get
    //        {
    //            return this.backgroundPressedField;
    //        }
    //        set
    //        {
    //            this.backgroundPressedField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string foregroundPressed
    //    {
    //        get
    //        {
    //            return this.foregroundPressedField;
    //        }
    //        set
    //        {
    //            this.foregroundPressedField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string backgroundSelected
    //    {
    //        get
    //        {
    //            return this.backgroundSelectedField;
    //        }
    //        set
    //        {
    //            this.backgroundSelectedField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string foregroundSelected
    //    {
    //        get
    //        {
    //            return this.foregroundSelectedField;
    //        }
    //        set
    //        {
    //            this.foregroundSelectedField = value;
    //        }
    //    }
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }
    //}
}
