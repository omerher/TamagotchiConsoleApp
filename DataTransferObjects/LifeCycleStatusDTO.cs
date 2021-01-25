using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    [Table("LifeCycleStatus")]
    public partial class LifeCycleStatusDTO
    {
        public LifeCycleStatusDTO()
        {
            ActivitiesHistories = new HashSet<ActivitiesHistoryDTO>();
            Animals = new HashSet<AnimalDTO>();
        }

        [Key]
        [Column("LifeCycleStatusID")]
        public int LifeCycleStatusId { get; set; }
        [Required]
        [StringLength(20)]
        public string StatusName { get; set; }
        public int CycleTime { get; set; }

        [InverseProperty(nameof(ActivitiesHistoryDTO.AnimalCycleStatus))]
        public virtual ICollection<ActivitiesHistoryDTO> ActivitiesHistories { get; set; }
        [InverseProperty(nameof(AnimalDTO.LifeCycle))]
        public virtual ICollection<AnimalDTO> Animals { get; set; }
    }
}
