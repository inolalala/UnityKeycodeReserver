﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeReserve;

public class KeyEventInvoker : MonoBehaviour {

    private ReservedKeyEventRepository reservedKeyEventRepository;

    void Awake()
    {
        reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
    }

    void Update()
    {
        reservedKeyEventRepository.WatchKeyInputOnUpdate();
    }
}
