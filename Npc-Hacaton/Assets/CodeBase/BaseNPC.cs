using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNPC : NPCService
{
    protected override string playerMessage => _playerMessage;
    

    [SerializeField] private string _playerMessage;


    public void BasePlayerInteraction()
    {
        PlayerInteraction();
    }

    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        Debug.Log("Player");
    }
}
