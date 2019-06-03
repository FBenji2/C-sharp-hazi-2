using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HF2
{
    [XmlRoot("Jedi"), Serializable]
    public class Jedi
    {
        [XmlIgnore]
        private string name;
        [XmlIgnore]
        private int midicount;

        [XmlAttribute("Név")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [XmlAttribute("MidiChlorianSzam")]
        public int MidiChlorianCount
        {
            get
            {
                return midicount;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("You are not a true jedi!"); else midicount = value;
            }
        }
        public Jedi()
        {
            Name = "Jozsi";
            MidiChlorianCount = 5000;
        }
    }
}
