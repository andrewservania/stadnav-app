using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StadNavDesktopTool
{
    class Language
    {
        int idValue;
        string nameValue;

        public Language(int iLanguageID, string strLanguageName)
        {
            this.ID = iLanguageID;
            this.Name = strLanguageName;
        }

        public int ID 
        { 
            get { return idValue; }
            set { idValue = value; } 
        }

        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        public override string ToString()
        {
            return "[" + ID + "] " + Name;
        }
    }
}
