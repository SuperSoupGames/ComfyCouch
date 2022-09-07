using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SuperSoupGames {
    namespace Legal {
        public static class Copyright 
        {
            private static Dictionary<ILegal, UsageStats> KiteLionGamesSoftware = new Dictionary<ILegal, UsageStats>();

            private struct UsageStats {
                public DateTime UseDate;
                public string SoftwareName;
            }

            public static void RecordUsage (ILegal Obj) {
                UsageStats ObjStats = new UsageStats { UseDate = DateTime.Now, SoftwareName = Obj.SuperSoupGamesSoftwareName};
                KiteLionGamesSoftware.Add(Obj, ObjStats);
            }
        }

        public interface ILegal{
            string SuperSoupGamesSoftwareName { get; }
        }
    }
}
