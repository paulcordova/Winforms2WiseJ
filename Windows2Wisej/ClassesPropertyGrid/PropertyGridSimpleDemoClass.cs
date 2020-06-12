using System;
using System.Collections.Generic;

using System.Text;
using System.Drawing;

namespace ClassesPropertyGridTest
{
    
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
}
