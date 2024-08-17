using DG.Tweening;
using UnityEngine;

public class BehaviorDOTween : MonoBehaviour
{
    public Transform capsule, cube, quad;
    
    public void ChangeScale()
    {
        //Scale the capsule from 0 to 1 in 1 second
        capsule.DOScale(Vector3.zero, 1f).From();
    }

    public void ChangePosition()
    {
        //check easings.net for more easing functions
        cube.DOMoveX(3f, 1f).SetEase(Ease.InOutBounce);
    }
}
