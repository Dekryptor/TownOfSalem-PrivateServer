﻿using System;

namespace TownOfSalem_Networking.Server
{
    public class LookoutNightAbilityMessage : BaseMessage
    {
        public readonly int Position;

        public LookoutNightAbilityMessage(byte[] data) : base(data)
        {
            try
            {
                Position = data[1] - 1;
            }
            catch (Exception ex)
            {
                ThrowNetworkMessageFormatException(ex);
            }
        }
    }
}
