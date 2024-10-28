using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Place : DefaultObserverEventHandler
{
    [SerializeField] private GameObject carPrefab;
    private GameObject placedCar;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (placedCar == null)
        {
            PlaceObject(transform.position);
            // placedCar = Instantiate(carPrefab, transform.position, transform.rotation);
        }
    }

    private void PlaceObject(Vector3 position)
    {
        placedCar = Instantiate(carPrefab, position, Quaternion.identity);
    }
}