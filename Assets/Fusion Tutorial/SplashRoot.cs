using UnityEngine;
using UnityEngine.AddressableAssets;

public class SplashRoot : MonoBehaviour
{

    private void Start()
    {
        Addressables.LoadSceneAsync("Playground_Multiplayer");
    }
}