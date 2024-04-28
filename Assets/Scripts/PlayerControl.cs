using Unity.Netcode;
using UnityEngine;

public class PlayerControl : NetworkBehaviour
{
    [SerializeField] private float walkSeepd = 3.5f;

    [SerializeField] private Vector2 defaultPositionRange = new Vector2(-4, 40);

    [SerializeField] private NetworkVariable<float> forwardBackPosition = new NetworkVariable<float>();
}
