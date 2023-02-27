using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommonFunction : MonoBehaviour
{
    [SerializeField] GameObject player;

    public void TeleportTo(Transform to)
    {
        player.transform.position = to.position;
        player.transform.rotation = to.rotation;
    }
}
