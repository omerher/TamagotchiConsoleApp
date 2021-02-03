using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    public class AnimalDTO
    {
        public AnimalDTO()
        {

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
    }
}
