
using UnityEngine;

namespace RayWenderlich.SpaceInvadersUnity
{
    public class MusicControl : MonoBehaviour
    {
        [SerializeField]
        private AudioSource source;

        internal void StopPlaying() => source.Stop();
    }
}