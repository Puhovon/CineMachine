using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartTimeLine : MonoBehaviour
{
    [SerializeField] private PlayableDirector _playableDirector;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            _playableDirector.Play();
    }
}
