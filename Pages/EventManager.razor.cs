using System.Text.Json;
using EventEaseApp.Components;
using EventEaseApp.Models;

namespace EventEaseApp.Pages
{
    public partial class EventManager
    {
        private List<Event> events;
        private AddEventModal addEventModal;

        protected override async Task OnInitializedAsync()
        {
            await LoadEventsAsync();
        }

        private async Task LoadEventsAsync()
        {
            string eventsJson = await LocalStorageService.GetItemAsync("events");
            try
            {
                events = string.IsNullOrEmpty(eventsJson) ? [] 
                : JsonSerializer.Deserialize<List<Event>>(eventsJson) ?? [];
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                events = [];
            }
        }

        private void ShowAddEventModal()
        {
            addEventModal.Show();
        }
    }
}
