﻿using EmoteScript.Entity.Enum;

namespace EmoteScript.Emotes
{
    public class InqFellowQuest : Emote
    {
        public InqFellowQuest() : base(EmoteType.InqFellowQuest)
        {
            Init();
        }
        
        public InqFellowQuest(string quest)

            : base(EmoteType.InqFellowQuest)
        {
            Init();
            
            Message = quest;
        }

        public void Init()
        {
            AddBranches(Branch.QuestFellow);
        }
    }
}
