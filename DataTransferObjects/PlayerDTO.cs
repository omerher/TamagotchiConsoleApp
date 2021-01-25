using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    public partial class PlayerDTO
    {
        public PlayerDTO()
        {
            Animals = new HashSet<AnimalDTO>();
        }

        [Key]
        [Column("PlayerID")]
        public int PlayerId { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [Required]
        [StringLength(40)]
        public string PlayerEmail { get; set; }
        [StringLength(15)]
        public string Gender { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [Column("ActiveAnimalID")]
        public int? ActiveAnimalId { get; set; }

        [ForeignKey(nameof(ActiveAnimalId))]
        [InverseProperty(nameof(AnimalDTO.PlayerNavigation))]
        public virtual AnimalDTO ActiveAnimal { get; set; }
        [InverseProperty(nameof(AnimalDTO.Player))]
        public virtual ICollection<AnimalDTO> Animals { get; set; }
    }
}
