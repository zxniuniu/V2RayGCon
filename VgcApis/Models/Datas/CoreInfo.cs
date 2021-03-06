﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VgcApis.Models.Datas
{
    public class CoreInfo
    {
        // private variables will not be serialized

        // plain text of config.json
        public string config; 

        // flags
        public bool 
            isAutoRun, 
            isInjectImport, 
            isSelected, 
            isInjectSkipCNSite, 
            isUntrack;

        public string name, summary, inbIp, customMark, uid;

        public int customInbType, inbPort, foldingLevel;

        public double index;

        public CoreInfo()
        {
            // new server will displays at the bottom
            index = double.MaxValue;

            isSelected = false;
            isUntrack = false;
            
            isAutoRun = false;
            isInjectImport = false;

            foldingLevel = 0;

            customMark = string.Empty;
            
            name = string.Empty;
            summary = string.Empty;
            config = string.Empty;
            uid = string.Empty;
            

            customInbType = 1;
            inbIp = "127.0.0.1";
            inbPort = 1080;
        }
    }
}
