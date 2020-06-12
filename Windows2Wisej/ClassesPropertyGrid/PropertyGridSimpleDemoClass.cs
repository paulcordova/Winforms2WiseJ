using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Drawing.Design;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

// Sample used from article for winform in COdeProyect site
// Using PropertyGrid
// url: https://www.codeproject.com/Articles/22717/Using-PropertyGrid


namespace ClassesPropertyGridTest
{

    #region Test1
    class PropertyGridSimpleDemoClass
    {
        int m_DisplayInt;
        public int DisplayInt
        {
            get { return m_DisplayInt; }
            set { m_DisplayInt = value; }
        }

        string m_DisplayString;
        public string DisplayString
        {
            get { return m_DisplayString; }
            set { m_DisplayString = value; }
        }

        bool m_DisplayBool;
        public bool DisplayBool
        {
            get { return m_DisplayBool; }
            set { m_DisplayBool = value; }
        }

        Color m_DisplayColors;
        public Color DisplayColors
        {
            get { return m_DisplayColors; }
            set { m_DisplayColors = value; }
        }

    }
    #endregion

    #region Test2
        class PropertyGridSimpleDemoClass2
    {
        int m_DisplayInt = 50; // some initialization
        [Browsable(true)] //this property should be visible
        [ReadOnly(true)]  //but just read only
        [Description("sample hint1")] // sample hint1
        [Category("Category1")]// Category that I want
        [DisplayName("Int for Displaying")] // I want to say more, than just DisplayInt
        public int DisplayInt
        {
            get { return m_DisplayInt; }
            set { m_DisplayInt = value; }
        }

        string m_DisplayString;
        [Browsable(true)] //this property should be visible
        [ReadOnly(false)]  //this property is for editing
        [Description("Example Displaying hint 2")] // sample hint2
        [Category("Category1")]// Category that I want
        [DisplayName("Name")] // and more than Display String
        public string DisplayString
        {
            get { return m_DisplayString; }
            set { m_DisplayString = value; }
        }

        bool m_DisplayBool;
        [Category("Category2")]// Category that I want
        [Description("To be or not to be")] // yet one hint
        [DisplayName("To drink or not to drink")] // that is a question
        public bool DisplayBool
        {
            get { return m_DisplayBool; }
            set { m_DisplayBool = value; }
        }


        Color m_DisplayColors;
        [Browsable(false)]//this property shoul be hided;
        public Color DisplayColors
        {
            get { return m_DisplayColors; }
            set { m_DisplayColors = value; }
        }
    }
    #endregion

    #region Test3
        class DrinkerClassConverter : BooleanConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                                         CultureInfo culture,
                                         object value,
                                         Type destType)
        {
            return (bool)value ?
              "Yes" : "Yes, of course";
        }

        public override object ConvertFrom(ITypeDescriptorContext context,
                                        CultureInfo culture,
                                        object value)
        {
            return (string)value == "Yes";
        }


            
    }
        class PropertyGridSimpleDemoClass3
    {
        bool m_DrinkOrNot;

        [DisplayName("Drink or not")]
        [Description("Drink or not")]
        [Category("Make right decision")]
        [TypeConverter(typeof(DrinkerClassConverter))]
        public bool DrinkOrNot
        {
            get { return m_DrinkOrNot; }
            set { m_DrinkOrNot = value; }
        }

    }
    #endregion

    #region Test4

    enum DrinkDoses
    {
        [Description("Half of litre")]
        litre,
        [Description("One litre")]
        oneLitre,
        [Description("Two litres")]
        twoLitre,
        [Description("Three litres")]
        threeLitres,
        [Description("Four litres")]
        fourLitres,
        [Description("Death dose, five litres")]
        fiveLitres
    }
    class DrinkDosesConverter : EnumConverter
    {
        private Type _enumType;
        /// <summary>Initializing instance</summary>
        /// <param name="type">type Enum</param>
        ///this is only one function, that you must 
        ///to change. All another functions for enums 
        ///you can use by Ctrl+C/Ctrl+V
        public DrinkDosesConverter(Type type)
            : base(type)
        {
            _enumType = type;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context,
                Type destType)
        {
            return destType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture,
            object value, Type destType)
        {
            FieldInfo fi = _enumType.GetField(Enum.GetName(_enumType, value));
            DescriptionAttribute dna =
              (DescriptionAttribute)Attribute.GetCustomAttribute(
                fi, typeof(DescriptionAttribute));

            if (dna != null)
                return dna.Description;
            else
                return value.ToString();
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context,
            Type srcType)
        {
            return srcType == typeof(string);
        }


        public override object ConvertFrom(ITypeDescriptorContext context,
            CultureInfo culture,
            object value)
        {
            foreach (FieldInfo fi in _enumType.GetFields())
            {
                DescriptionAttribute dna =
                  (DescriptionAttribute)Attribute.GetCustomAttribute(
                    fi, typeof(DescriptionAttribute));

                if ((dna != null) && ((string)value == dna.Description))
                    return Enum.Parse(_enumType, fi.Name);
            }
            return Enum.Parse(_enumType, (string)value);
        }
    }
    class DrinkerDoses
    {
        DrinkDoses m_doses;
        [DisplayName("Doses")]
        [Description("Drinker doses")]
        [Category("Alcoholics drinking")]
        [TypeConverter(typeof(DrinkDosesConverter))]
        public DrinkDoses Doses
        {
            get
            {
                return m_doses;
            }
            set
            {
                m_doses = value;
            }
        }

        int m_dataInt;

        public int DataInt
        {
            get { return m_dataInt; }
            set { m_dataInt = value; }
        }
    }

    #endregion

    #region Test5

    enum GameValues
    {
        [Description("Stone")]
        Stone,
        [Description("Scissors")]
        Scissors,
        [Description("Paper")]
        Paper
    }
    class GameEditor : UITypeEditor
    {
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
            string whatImage = e.Value.ToString();
            whatImage += ".bmp";

            // Combine with image in output directory
            string FilePath = Path.Combine(Application.StartupPath, "Images", whatImage);

            //getting picture
            Bitmap bmp = (Bitmap)Bitmap.FromFile(FilePath);
            Rectangle destRect = e.Bounds;
            bmp.MakeTransparent();

            //and drawing it
            e.Graphics.DrawImage(bmp, destRect);
        }
    }
    class GameValuesConverter : EnumConverter
    {
        private Type _enumType;

        public GameValuesConverter(Type type)
            : base(type)
        {
            _enumType = type;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context,
        Type destType)
        {
            return destType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context,
        CultureInfo culture,
            object value, Type destType)
        {
            FieldInfo fi = _enumType.GetField(Enum.GetName(_enumType, value));
            DescriptionAttribute dna =
              (DescriptionAttribute)Attribute.GetCustomAttribute(
                fi, typeof(DescriptionAttribute));

            if (dna != null)
                return dna.Description;
            else
                return value.ToString();
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context,
          Type srcType)
        {
            return srcType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context,
          CultureInfo culture,
          object value)
        {
            foreach (FieldInfo fi in _enumType.GetFields())
            {
                DescriptionAttribute dna =
                  (DescriptionAttribute)Attribute.GetCustomAttribute(
                    fi, typeof(DescriptionAttribute));

                if ((dna != null) && ((string)value == dna.Description))
                    return Enum.Parse(_enumType, fi.Name);
            }

            return Enum.Parse(_enumType, (string)value);
        }

    }

    class GameClassDisplayer
    {
        GameValues m_GameValues;
        [DisplayName("Choose your variant")]
        [Description("You can choose between Stone, scissors, paper")]
        [Category("Choosing")]
        //[TypeConverter(typeof(GameEditor))]
        [Editor(typeof(GameEditor), typeof(UITypeEditor))]
        public GameValues DisplayGameValues
        {
            get
            {
                return m_GameValues;
            }
            set
            {
                m_GameValues = value;
            }
        }
    }


    #endregion
}
