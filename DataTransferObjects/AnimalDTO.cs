using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    public partial class AnimalDTO
    {
        public AnimalDTO()
        {
            ActivitiesHistories = new HashSet<ActivitiesHistoryDTO>();
        }

        [Key]
        [Column("AnimalID")]
        public int AnimalId { get; set; }
        [Column("PlayerID")]
        public int? PlayerId { get; set; }
        [Required]
        [StringLength(20)]
        public string AnimalName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("AWeight")]
        public int Aweight { get; set; }
        [Column("AHunger")]
        public int Ahunger { get; set; }
        [Column("ACleanliness")]
        public int Acleanliness { get; set; }
        [Column("AHappiness")]
        public int Ahappiness { get; set; }
        [Column("HealthStatusID")]
        public int? HealthStatusId { get; set; }
        [Column("LifeCycleID")]
        public int? LifeCycleId { get; set; }

        [ForeignKey(nameof(HealthStatusId))]
        [InverseProperty("Animals")]
        public virtual HealthStatusDTO HealthStatus { get; set; }
        [ForeignKey(nameof(LifeCycleId))]
        [InverseProperty(nameof(LifeCycleStatusDTO.Animals))]
        public virtual LifeCycleStatusDTO LifeCycle { get; set; }
        [ForeignKey(nameof(PlayerId))]
        [InverseProperty("Animals")]
        public virtual PlayerDTO Player { get; set; }
        [InverseProperty("ActiveAnimal")]
        public virtual PlayerDTO PlayerNavigation { get; set; }
        [InverseProperty(nameof(ActivitiesHistoryDTO.Animal))]
        public virtual ICollection<ActivitiesHistoryDTO> ActivitiesHistories { get; set; }
    }
}
