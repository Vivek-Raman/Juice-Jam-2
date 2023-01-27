using Cinemachine;
using UnityEngine;

namespace wannaB.Camera
{
public class CameraManager : MonoBehaviour
{
    private CinemachineImpulseSource _impulseSource;
    private bool _isSourceSet = false;

    public void ShakeScreen(float force)
    {
        if (!_isSourceSet) return;
        _impulseSource.GenerateImpulseAtPositionWithVelocity(_impulseSource.transform.position,
            _impulseSource.m_DefaultVelocity * force);
    }

    public void RegisterImpulseSource(CinemachineImpulseSource source)
    {
        this._impulseSource = source;
        this._isSourceSet = true;
    }
}
}
