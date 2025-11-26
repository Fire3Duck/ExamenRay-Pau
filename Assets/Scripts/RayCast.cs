using UnityEngine;
using UnityEngine.InputSystem;

public class RayCast : MonoBehaviour

{
    InputAction _clickAction;
    InputAction _positionAction;
    Vector2 _mousePosition;


    void Awake()
    {
        _clickAction = InputSystem.actions["Attack"];
        _positionAction = InputSystem.actions["Look"];
    }


    void Update()
    {
        _mousePosition = _positionAction.ReadValue<Vector2>();


        if(_clickAction.WasPerformedThisFrame())
        {
            ShootRaycast();
        }
    }


    private void ShootRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Cubo1")
            {
                BoxRotation box = hit.transform.GetComponent<BoxRotation>();


                if (box != null)
                {
                    Debug.Log("Cubo1");
                    
                }
            }

            if (hit.transform.tag == "Cubo2")
            {
                BoxRotation box = hit.transform.GetComponent<BoxRotation>();


                if (box != null)
                {
                    Debug.Log("Cubo2");
                }
            }

            if (hit.transform.tag == "Bola")
            {
                Sphere sphere = hit.transform.GetComponent<Sphere>();


                if (sphere != null)
                {
                    Debug.Log("Bola");
                }
            }
        }
    }
}