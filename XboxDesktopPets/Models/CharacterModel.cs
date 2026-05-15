using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XboxDesktopPets.Models
{
    public class CharacterModel
    {
        public string Name { get; set; }
        public float MoveSpeed { get; set; }
        public string ImagePath { get; set; }
        public string SoundPath { get; set; }
        public bool IsFalling { get; set; }
        public Saga Saga { get; set; }
    }
}
