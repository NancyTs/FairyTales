﻿#if UNITY_2017_1_OR_NEWER
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{

#if UNITY_5_1 || UNITY_5_2 || UNITY_5_3_OR_NEWER
    //[HelpURL("http://pixelcrushers.com/dialogue_system/manual/html/cinemachine_priority_on_dialogue_event.html")]
#endif
    [AddComponentMenu("Dialogue System/Trigger/On Dialogue Event/Cinemachine Camera Priority On Dialogue Event")]
    public class CinemachineCameraPriorityOnDialogueEvent : ActOnDialogueEvent
    {

        [Tooltip("The Cinemachine virtual camera whose priority to control.")]
        public Cinemachine.CinemachineVirtualCamera virtualCamera;

        [Tooltip("Set the virtual camera to this priority when the start event occurs.")]
        public int onStart = 99;

        [Tooltip("Set the virtual camera to this priority when the end event occurs.")]
        public int onEnd = 0;

        public override void TryStartActions(Transform actor)
        {
            if (virtualCamera == null) return;
            virtualCamera.Priority = onStart;
        }

        public override void TryEndActions(Transform actor)
        {
            if (virtualCamera == null) return;
            virtualCamera.Priority = onEnd;
        }
    }
}
#endif