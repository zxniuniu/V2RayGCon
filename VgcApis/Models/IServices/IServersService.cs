﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VgcApis.Models.IServices
{
    public interface IServersService
    {
        event EventHandler OnCoreStart, OnCoreClosing;

        string PackServersIntoV4Package(
            List<Interfaces.ICoreServCtrl> servList,
            string orgServerUid,
            string packageName);

        ReadOnlyCollection<Interfaces.ICoreServCtrl> GetTrackableServerList();
        ReadOnlyCollection<Interfaces.ICoreServCtrl> GetAllServersOrderByIndex();
    }
}
