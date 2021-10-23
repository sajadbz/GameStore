using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Values
{
    public class Paths
    {
        private static readonly string _base = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string DefaultImage = $"{_base}/upload/games/default.jpg";
        public static readonly string GameImagePath = $"{_base}/upload/games";
    }
}
