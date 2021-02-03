using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    public partial class ActivitiesHistoryDTO
    {
        [Key]
        [Column("HistoryID")]
        public int HistoryId { get; set; }
        [Column("AnimalID")]
        public int? AnimalId { get; set; }
        [Column("ActivityID")]
        public int? ActivityId { get; set; }
        public int AnimalAge { get; set; }
        [Column("AWeight")]
        public int Aweight { get; set; }
        [Column("AHunger")]
        public int Ahunger { get; set; }
        [Column("AHappiness")]
        public int Ahappiness { get; set; }
        [Column("ACleanliness")]
        public int Acleanliness { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [Column("AnimalCycleStatusID")]
        public int? AnimalCycleStatusId { get; set; }
        [Column("AnimalHealthStatusID")]
        public int? AnimalHealthStatusId { get; set; }

    }
}
