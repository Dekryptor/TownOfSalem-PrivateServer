﻿using System;

namespace TownOfSalem_Networking.Server
{
    public class PartyInvitePowerNotificationMessage : BaseMessage
    {
        public readonly string Username;

        public PartyInvitePowerNotificationMessage(byte[] data) : base(data)
        {
            try
            {
                Username = BytesToString(data, 1);
            }
            catch (Exception ex)
            {
                ThrowNetworkMessageFormatException(ex);
            }
        }
    }
}
