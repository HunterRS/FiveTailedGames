using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRandomization : MonoBehaviour
{
    public AudioClip[] soundClips;
    public AudioSource[] soundSource;
        
    private float timer = 0;
    private float wait = 0;

    private int audioIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        soundSource[0].clip = soundClips[(int)Mathf.Floor(Random.value * soundClips.Length)];
        soundSource[1].clip = soundClips[(int)Mathf.Floor(Random.value * soundClips.Length)];
        gameObject.transform.localPosition = new Vector3(Random.value * 16 - 8, 0,1);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= wait){
            RandomSwitchAndPlay();
            wait = 5 + (Random.value * 5);
            timer = 0;
            gameObject.transform.localPosition = new Vector3(Random.value * 16 - 8, 0,1);
        }
        timer += Time.deltaTime;
    }

    public void RandomSwitchAndPlay(){
        if(audioIndex == 0){
            soundSource[0].clip = soundClips[(int)Mathf.Floor(Random.value * soundClips.Length)];
            soundSource[0].Play();
            audioIndex = 1;
        }
        else if(audioIndex == 1){
            soundSource[1].clip = soundClips[(int)Mathf.Floor(Random.value * soundClips.Length)];
            soundSource[1].Play();
            audioIndex = 0;
        }

    }
}
