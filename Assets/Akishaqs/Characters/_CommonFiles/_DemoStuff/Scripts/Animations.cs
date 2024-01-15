using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animations : MonoBehaviour
{
    Animator _anim;
    public Text _animClipName;
    public GameObject _player;
    string _currentClipName;
    AnimatorClipInfo[] _currentClipInfo;

    void Start()
    {
        _anim = _player.GetComponent<Animator>();
    }

    public void next()
    {
        _anim.SetTrigger("ToNext");
    }
    public void previous()
    {
        _anim.SetTrigger("ToPrevious");
    }

}
