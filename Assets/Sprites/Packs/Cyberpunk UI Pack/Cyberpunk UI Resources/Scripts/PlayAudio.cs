using UnityEngine;

namespace Cyberpunk_UI_Pack.Cyberpunk_UI_Resources.Scripts
{
    public class PlayAudio : MonoBehaviour
    {
        public AudioSource ass;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        public void Play()
        {
            ass.Play();
        }
    }
}
