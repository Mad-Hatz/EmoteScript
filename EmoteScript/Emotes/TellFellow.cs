﻿using EmoteScript.Entity.Enum;

namespace EmoteScript.Emotes
{
    public class TellFellow : Emote
    {
        public TellFellow()
            
            : base(EmoteType.TellFellow)
        {

        }
        
        public TellFellow(string message)
            
            : base(EmoteType.TellFellow)
        {
            Message = message;
        }
    }
}
