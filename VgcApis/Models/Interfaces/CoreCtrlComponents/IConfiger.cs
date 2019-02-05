﻿using System;

namespace VgcApis.Models.Interfaces.CoreCtrlComponents
{
    public interface IConfiger
    {
        string GetConfig();
        void SetConfig(string newConfig);

        bool IsSuitableToBeUsedAsSysProxy(
          bool isGlobal,
          out bool isSocks,
          out int port);

        void UpdateSummaryThen(Action next = null);
        void GetterInboundInfoThen(Action<string> next);
    }
}
