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
            
        }

        [Key]
        [Column("LifeCycleStatusID")]
        public int LifeCycleStatusId { get; set; }
        [Required]
        [StringLength(20)]
        public string StatusName { get; set; }
        public int CycleTime { get; set; }

    }
}
