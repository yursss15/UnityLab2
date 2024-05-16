using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameLocatorInstaller : MonoBehaviour
{
    [SerializeField]
    private GameLocator gameLocator;

    [SerializeField]
    private MonoBehaviour[] gameServicess;

    private void Awake()
    {
        foreach (var service in this.gameServicess)
        {
            this.gameLocator.AddService(service);
        }
    }
}
