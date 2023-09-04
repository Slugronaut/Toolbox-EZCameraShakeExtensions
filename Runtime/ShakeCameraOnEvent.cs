using UnityEngine;
using EZCameraShake;

namespace Peg.Extensions
{
    /// <summary>
    /// Shakes the camera upon receiving a specified message.
    /// </summary>
    public class ShakeCameraOnEvent : AbstractOperationOnEvent
    {
        [Tooltip("Intensity of the shake.")]
        public float Magnitude = 1;
        [Tooltip("Roughness of the shake. Lower values are smoother, higher values are more jarring.")]
        public float Roughness = 1;
        [Tooltip("How long to fade in the shake in seconds.")]
        public float FadeInTime = 0.1f;
        [Tooltip("How long to fade out the shake in seconds.")]
        public float FadeOutTime = 0.1f;
        [Tooltip("How much the shake influences the position on each axis.")]
        public Vector3 PosInfluence = Vector3.one;
        [Tooltip("How much the shake influences the rotation on each axis.")]
        public Vector3 RotInfluence = Vector3.zero;


        public override void PerformOp()
        {
            CameraShaker.Instance.ShakeOnce(Magnitude, Roughness, FadeInTime, FadeOutTime, PosInfluence, RotInfluence);
        }
    }
}
