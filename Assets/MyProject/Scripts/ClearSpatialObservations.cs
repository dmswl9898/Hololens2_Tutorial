﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit;
using UnityEngine;

public class ClearSpatialObservations : MonoBehaviour
{
    /// <summary>
    /// Indicates whether observations are to be cleared (true) or if the observer is to be resumed (false).
    /// </summary>
    private bool clearObservations = true;

    /// <summary>
    /// Toggles the state of the observers.
    /// </summary>
    public void ToggleObservers()
    {
        var spatialAwarenessSystem = CoreServices.SpatialAwarenessSystem;
        if (spatialAwarenessSystem != null)
        {
            if (clearObservations)
            {
                spatialAwarenessSystem.SuspendObservers();
                spatialAwarenessSystem.ClearObservations();
                clearObservations = false;
            }
            else
            {
                spatialAwarenessSystem.ResumeObservers();
                clearObservations = true;
            }
        }
    }
}