using MauiApp4.Models;
using System.Collections.ObjectModel;

namespace MauiApp4.ViewModels;

public class PlayerViewModel
{
    public ObservableCollection<ListModel> MyPlayers { get; set; } = new ObservableCollection<ListModel>
    {
        new ListModel
        {
            Name = "Cameron Heyward", Image="cameron_heyward.png"
        },
        new ListModel
        {
            Name = "George Pickens", Image="george_pickens.png"
        },
        new ListModel
        {
            Name = "Kenny Pickett", Image="kenny_pickett.png"
        },
        new ListModel
        {
            Name = "Minkah Fitzpatrick", Image="minkah_fitzpatrick.png"
        },
        new ListModel
        {
            Name = "Najee Harris", Image="najee_harris.png"
        },
        new ListModel
        {
            Name = "TJ Watt", Image="tj_watt.png"
        },
    };

    public Command<ListModel> DeletePlayerCommand { get; set; }

    public PlayerViewModel()
    {
        DeletePlayerCommand = new Command<ListModel>(model =>
        {
            MyPlayers.Remove(model);
        });
    }
}