﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon.Finance.Indicators
{

    public enum CandleRange
    {
       Min1,
       Min2,
       Min3,
       Min5,
       Min10,
       Min15,
       Min30,
       Min60
    }
    public interface IIndicatorStats
    {
        bool ShowErrors { get; set; }
    }
    public interface IIndicator
    {
        string Name { get; set; }
        string Author { get; set; }
        long Version { get; set; }
        bool MultiTimeFrame { get; set; }
        bool MultiInput { get; set; }
        bool NeedExtraData { get; set; }

    }
    public class RootTA : IIndicator, IIndicatorStats
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public long Version { get; set; }
        public bool MultiTimeFrame { get; set; }
        public bool MultiInput { get; set; }
        public bool NeedExtraData { get; set; }
        public bool ShowErrors { get; set; }

        public virtual void FillData()
        {

        }
        
        public virtual void Compute()
        {

        }
        public virtual bool HasEnoughData()
        {
            return true;
        }
    }
}
