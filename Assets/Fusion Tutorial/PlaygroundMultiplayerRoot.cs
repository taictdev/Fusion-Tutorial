using Fusion;
using UnityEngine;

public class PlaygroundMultiplayerRoot : MonoBehaviour
{
    [SerializeField] private NetworkRunner _runner;

    private void Start()
    {
        _runner.StartGame(new StartGameArgs
        {
            GameMode = GameMode.Shared,
            SessionName = "TestSession",
        });
    }
}