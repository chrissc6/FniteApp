using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FniteApp.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string WeaponType { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string RarityType { get; set; }
        public string Rating { get; set; }
        public decimal DPS { get; set; }
        public int DamageB { get; set; }
        public int DamageH { get; set; }
        public decimal FireRate { get; set; }
        public int MagazineSize { get; set; }
        public decimal ReloadTime { get; set; }
        public int StructureDamage { get; set; }
        public string BulletType { get; set; }
        public bool BRStatus { get; set; }
        public bool VaultedStatus { get; set; }
    }
}
