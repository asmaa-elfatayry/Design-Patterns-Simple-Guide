
namespace FacadeExample;

public class HomeTheaterFacade
{
    private TV _tv;
    private DVDPlayer _player;
    private SoundSystem _soundSystem;
    public HomeTheaterFacade()
    {
        _tv = new TV();
        _player = new DVDPlayer();
        _soundSystem = new SoundSystem();
    }

    public void WatchMovie()
    {
        Console.WriteLine("Get ready to watch a movie...");
        _tv.TurnOn();
        _soundSystem.TurnOn();
        _player.Play();
    }

    }
