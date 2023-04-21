using Microsoft.AspNetCore.Components;

namespace NyaNyaNya.Models
{
    public class Planet
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }

        public bool IsActive { get; set; }
        public int Index { get; set; }

        public Planet(bool isActive, int index)
        {
            IsActive = isActive;
            Index = index;
        }

        public void PlayPlanet()
        {
            if(IsActive)
            {
                NavigationManager.NavigateTo("/game/" + Index);
            }
        }
    }
}
