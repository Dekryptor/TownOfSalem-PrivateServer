﻿


using System;
using System.Collections.Generic;

namespace TownOfSalem_Networking.Server
{
    public class PurchasedTauntsMessage : BaseMessage
    {
        public Dictionary<int, int> Taunts = new Dictionary<int, int>();

        public PurchasedTauntsMessage(byte[] data) : base(data)
        {
            try
            {
                var str1 = BytesToString(data, 1);
                foreach (var str2 in str1.Split(','))
                {
                    var strArray = str2.Split('*');
                    Taunts.Add(int.Parse(strArray[0]), int.Parse(strArray[1]));
                }
            }
            catch (Exception ex)
            {
                ThrowNetworkMessageFormatException(ex);
            }
        }
    }
}
