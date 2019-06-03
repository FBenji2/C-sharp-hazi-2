using System;
using System.Collections.Generic;
using System.Text;

namespace HF2
{
    class JediCouncil
    {
        private List<Jedi> members = new List<Jedi>();
        public event CouncilChangedDelegate CouncilChanged;
        public delegate void CouncilChangedDelegate(string message);

        public List<Jedi> GetBeginners()
        {
            return members.FindAll(FindJedi);
        }

        bool FindJedi(Jedi jedi)
        {
            return 5000 > jedi.MidiChlorianCount;
        }


        public void Add(Jedi newJedi)
        {
            members.Add(newJedi);
            if (CouncilChanged != null)
                CouncilChanged("Új taggal bővültünk");
        }

        public void Remove()
        {
            members.RemoveAt(0);
            if(CouncilChanged!=null)
            {
                if (members.Count > 0)
                    CouncilChanged("Zavart érzek az erőben");
                else
                    CouncilChanged("A tanács elesett");
            }
        }


    }
}
