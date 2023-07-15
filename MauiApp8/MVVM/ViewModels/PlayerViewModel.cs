using MauiApp8.MVVM.Models;
using System.Collections.ObjectModel;

namespace MauiApp8.MVVM.ViewModels;

public class PlayerViewModel
{
    public ObservableCollection<Player> Players { get; set; }

    public PlayerViewModel()
    {
        Players = new ObservableCollection<Player>
        {
            new Player
            {
                Name = "Cameron Heyward", 
                Image="cameron_heyward.png",
                Information = "Five-tie Pro Bowler (2018, 2019, 2020, 2021, 2022)",
                InProBowl=false
            },
            new Player
            {
                Name = "George Pickens", 
                Image="george_pickens.png",
                Information = "A vertical receiver who dominates opponents with size and great hands",
                InProBowl=false
            },
            new Player
            {
                Name = "Kenny Pickett", 
                Image="kenny_pickett.png",
                Information = "Pitt's all-time leader in passing yards (12,303), pass completions (1,045), total offense (13,112), touchdown responsibility (102) and passing touchdowns (81)",
                InProBowl=false
            },
            new Player
            {
                Name = "Minkah Fitzpatrick", 
                Image="minkah_fitzpatrick.png",
                Information = "314 tackles (212 solo), 33 passes defenssed, 13 interceptions, 5 tackles for loss, 4 fumble recoveries, four forced fumbles, 33 interception returns for TDs",
                InProBowl=false
            },
            new Player
            {
                Name = "Najee Harris", 
                Image="najee_harris.png",
                Information = "1,200 rusing yards and seven rushing touchdowns on 307 attempts and added 74 catches for 397 receiving yards and three recieving touchdowns as a rookie",
                InProBowl=false
            },
            new Player
            {
                Name = "TJ Watt", 
                Image="tj_watt.png",
                Information = "Led the NFL with 22.5 sacks (despite missing 2 full games and portions of 4 others), tied with Pro Football hall of Famer Michael Strahan (22.5 sacks in 2001) for the most in a season",
                InProBowl=true
            },
        };
    }
}
