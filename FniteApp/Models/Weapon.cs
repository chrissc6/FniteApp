using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FniteApp.Models
{
    public class Weapon
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string WeaponType { get; set; } = "Ranged";

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string RarityType { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        [Column(TypeName = "decimal(5, 1)")]
        public decimal DPS { get; set; }
        public int DamageB { get; set; }
        public int? DamageH { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal FireRate { get; set; }
        public int MagazineSize { get; set; } = 30;

        [Column(TypeName = "decimal(5, 3)")]
        public decimal ReloadTime { get; set; }
        public int StructureDamage { get; set; }

        [StringLength(50)]
        public string BulletType { get; set; }
        public bool BRStatus { get; set; } = true;
        public bool VaultedStatus { get; set; } = false;
    }
}
