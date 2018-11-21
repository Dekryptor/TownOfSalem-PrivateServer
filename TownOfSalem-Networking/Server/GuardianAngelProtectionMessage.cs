﻿using System;

namespace TownOfSalem_Networking.Server
{
    public class GuardianAngelProtectionMessage : BaseMessage
    {
        public readonly int Position;

        public GuardianAngelProtectionMessage(byte[] data) : base(data)
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
