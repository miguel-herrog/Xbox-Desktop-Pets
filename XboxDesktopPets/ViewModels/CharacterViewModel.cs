using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XboxDesktopPets.Models;

namespace XboxDesktopPets.ViewModels
{
    public class CharacterViewModel : ViewModelBase
    {
        // 1. Lo convertimos en Propiedad para que la interfaz lo pueda leer
        public CharacterModel Character { get; set; }

        // 2. Constructor sin parámetros (se ejecuta al abrir la app)
        public CharacterViewModel()
        {
            // 3. Creamos la instancia
            Character = new CharacterModel
            {
                Name = "Master Chief",
                MoveSpeed = 5.0f,
                IsFalling = false,
                ImagePath = "Assets/Sprites/MasterChief_Idle.png",
                SoundPath = "Assets/Sounds/Halo_Shield.wav",
                Saga = Saga.Halo
            };
        }
    }
}