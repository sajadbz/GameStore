using GameStore.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities.Games
{
    public class Game : BaseEntity<long>
    {

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Year { get; set; }
        [MaxLength(500)]
        public string Platform { get; set; }
        
        [MaxLength(50)]
        public string ImageName { get; set; }

        #region Relations
        public int GroupId { get; set; }
        public GameGroup Group { get; set; }

        public GameRequirement GameRequirement { get; set; }
        #endregion
    }
}
