using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    [Table("HealthStatus")]
    public partial class HealthStatusDTO
    {
        public HealthStatusDTO()
        {
            
        }

        [Key]
        [Column("HealthStatusID")]
        public int HealthStatusId { get; set; }
        [Required]
        [StringLength(20)]
        public string StatusName { get; set; }

    }
}
