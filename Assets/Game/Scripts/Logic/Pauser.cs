﻿/**
 * Pause game.
 *
 * @filename  LPauser.cs
 * @copyright Copyright (c) 2015 Yaukey/yaukeywang/WangYaoqi (yaukeywang@gmail.com) all rights reserved.
 * @license   The MIT License (MIT)
 * @author    Yaukey
 * @date      2015-09-01
 */

using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour
{
	// Is ready or not.
	private bool m_bReady = false;
	
	// The lua behavior.
	private YwLuaBehaviourBase m_cBehavior = new YwLuaBehaviourBase();

	// Use this for initialization
	void Awake()
	{
		// Directly creat a lua class instance to associate with this monobehavior.
		if (!CreateClassInstance("LgPauser") || !m_bReady)
		{
			return;
		}
		
		m_cBehavior.Awake();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (m_bReady)
		{
			m_cBehavior.Update();
		}
	}

	/**
     * Create a lua class instance for monobehavior instead of do a file.
     * 
     * @param string strFile - The lua class name.
     * @return bool - true if success, otherwise false.
     */
	private bool CreateClassInstance(string strClassName)
	{
		if (!m_cBehavior.CreateClassInstance(strClassName))
		{
			return false;
		}
		
		m_bReady = true;
		return true;
	}
}
