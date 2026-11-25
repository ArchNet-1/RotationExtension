// ArchNet · Rotation Extension
// Spins its GameObject around an axis at a set speed (loading icons, coins, fans…).
// Play() / Stop() can be called from code or from a UnityEvent.
// Docs: https://archnet-plateform.fr/#RotationExtension

using UnityEngine;
using UnityEngine.Serialization;

namespace ArchNet.Extension
{
    [AddComponentMenu("ArchNet/Rotation")]
    public class RotationExtension : MonoBehaviour
    {
        [FormerlySerializedAs("_isActive")]
        [SerializeField] bool _playing;
        [Tooltip("Degrees per second.")]
        [SerializeField] float _speed = 90f;
        [SerializeField] Vector3 _axis = Vector3.forward;
        [FormerlySerializedAs("_forward")]
        [SerializeField] bool _clockwise;
        [SerializeField] Space _space = Space.World;

        public bool IsPlaying => _playing;
        public float Speed { get => _speed; set => _speed = value; }
        public bool Clockwise { get => _clockwise; set => _clockwise = value; }

        public void Play() => _playing = true;
        public void Stop() => _playing = false;

        void Update()
        {
            if (!_playing) return;
            float angle = _speed * Time.deltaTime * (_clockwise ? -1f : 1f);
            transform.Rotate(_axis, angle, _space);
        }
    }
}
