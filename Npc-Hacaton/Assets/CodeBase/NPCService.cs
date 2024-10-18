using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class NPCService : MonoBehaviour
{
    private const string AnimationKey = "IsInteraction";
    [SerializeField] private TextMeshPro _text;
    [SerializeField] private Animator _anim;

    protected virtual string playerMessage { get; }
    protected virtual string nightMessage { get; }


    public virtual void NightInteraction()
    {
        TextOutput(nightMessage);
    }

    public virtual void PlayerInteraction()
    {
        TextOutput(playerMessage);
        _anim.SetInteger(AnimationKey, 1);
    }

    private void TextOutput(string message)
    {
        _text.text = message;
    }
}