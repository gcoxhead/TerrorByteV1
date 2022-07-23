using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
 public AudioSource Alarm;
 public AudioSource Blip;

 public void playBlip()
 {
    Blip.Play();
 }

 public void playAlarm()
 {
    Alarm.Play();
 }

}
