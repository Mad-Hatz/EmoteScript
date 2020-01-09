﻿using EmoteScript.Entity.Enum;

namespace EmoteScript.Emotes
{
    public class InqInt64Stat : Emote
    {
        public InqInt64Stat() : base(EmoteType.InqInt64Stat)
        {
            Init();
        }

        public InqInt64Stat(PropertyInt64 stat, int min, int max)

            : base(EmoteType.InqInt64Stat)
        {
            Init();
            
            Stat = (int)stat;
            Min = min;
            Max = max;
        }

        public void Init()
        {
            AddBranches(Branch.Test);
        }
    }
}
