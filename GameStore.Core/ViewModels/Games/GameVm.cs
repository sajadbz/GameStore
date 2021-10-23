using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.ViewModels.Games
{
    public class GameVm
    {
        public long Id { get; set; }        
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Year { get; set; }        
        public string Platform { get; set; }
        public Image Image { get; set; }
        public string ImageName { get; set; }

        #region Group
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        #endregion

        #region Game Requirement
        public string CPU { get; set; }        
        public string GPU { get; set; }        
        public string RAM { get; set; }        
        public string FreeSpace { get; set; }
        public string Note { get; set; }
        #endregion
    }    
}
