using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.Games
{
    public class GameRequirement
    {
        //[Key]
        //public int Id { get; set; }
        [MaxLength(50)]
        public string CPU { get; set; }
        [MaxLength(50)]
        public string GPU { get; set; }
        [MaxLength(50)]
        public string RAM { get; set; }
        [MaxLength(50)]
        public string FreeSpace { get; set; }
        public string Note { get; set; }

        #region Navigation Peroperty
        [Key]
        public long GameId { get; set; }
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }

        #endregion
    }
}
