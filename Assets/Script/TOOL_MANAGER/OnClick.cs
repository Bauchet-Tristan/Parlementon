using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnClick : MonoBehaviour
{
    public UnityEvent _onClick,_onEnterOver,_onExitOver;

    public void OnMouseDown()
    {
        if(Time.timeScale == 0 )
        {

        }
        else
        {
            _onClick.Invoke();
        }
    }

    public void OnMouseEnter()
    {
        if(Time.timeScale == 0 )
        {

        }
        else
        {
            _onEnterOver.Invoke();
        }
    }

    private void OnMouseExit()
    {
        if(Time.timeScale == 0 )
        {

        }
        else
        {
            _onExitOver.Invoke();
        }
    }

}
