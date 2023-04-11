using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource correct;
    public AudioSource wrong;

    public void correctSound()
    {
        correct.Play();
    }

    public void wrongSound()
    {
        wrong.Play();
    }
}

