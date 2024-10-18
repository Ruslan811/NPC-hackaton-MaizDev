using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunicationZone : MonoBehaviour
{
    [SerializeField] private NPCService _npc;

    //������� ��� � ���� � ������

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
            _npc.PlayerInteraction();
    }
}
