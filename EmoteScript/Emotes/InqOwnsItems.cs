﻿using EmoteScript.Entity.Enum;

namespace EmoteScript.Emotes
{
    public class InqOwnsItems : Emote
    {
        public InqOwnsItems() : base(EmoteType.InqOwnsItems)
        {
            Init();
        }
        
        public InqOwnsItems(uint wcid, int stackSize = 1)

            : base(EmoteType.InqOwnsItems)
        {
            Init();
            
            WeenieClassId = wcid;
            StackSize = stackSize;
        }

        public void Init()
        {
            AddBranches(Branch.Test);
        }
    }
}
