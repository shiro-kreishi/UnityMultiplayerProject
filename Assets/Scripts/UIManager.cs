using System;
using Core.Singletons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button startServerBtn;
    [SerializeField] private Button startHostBtn;
    [SerializeField] private Button startClientBtn;
    [SerializeField] private TextMeshProUGUI playersInGameText;

    private void Awake()
    {
        Cursor.visible = true;
    }

    private void Start()
    {
        startServerBtn.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartServer())
            {
                Logger.Instance.LogInfo("Server started...");
            }
            else
            {
                Logger.Instance.LogInfo("Server could not be started...");
            }
        });
        
        startHostBtn.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartHost())
            {
                Logger.Instance.LogInfo("Host started...");
            }
            else
            {
                Logger.Instance.LogInfo("Host could not be started...");
            }
        });
        
        startClientBtn.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartClient())
            {
                Logger.Instance.LogInfo("Client started...");
            }
            else
            {
                Logger.Instance.LogInfo("Client could not be started...");
            }
        });
    }

    private void Update()
    {
        playersInGameText.text = $"Players in game: { PlayersManager.Instance.PlayersInGame }";
    }
    
    
}
