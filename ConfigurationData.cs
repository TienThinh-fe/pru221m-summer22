﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data with default values
    static float teddyBearMoveUnitsPerSecond = 5;
    static float cooldownSeconds = 1;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the teddy bear move units per second
    /// </summary>
    /// <value>teddy bear move units per second</value>
    public float TeddyBearMoveUnitsPerSecond
    {
        get { return teddyBearMoveUnitsPerSecond; }
    }
        
    /// <summary>
    /// Gets the cooldown seconds for shooting
    /// </summary>
    /// <value>cooldown seconds</value>
    public float CooldownSeconds
    {
        get { return cooldownSeconds; }    
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        try
        {
            string filepath = Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName);
            var lines = File.ReadAllLines(filepath);

            int index = 0;

            foreach(string line in lines)
            {
                if (index == 0)
                {
                    index++;
                    continue;
                }
                SetConfigurationDataFields(line.Substring(1, line.Length - 2));
            }                
        } catch (Exception ex)
        {
            Debug.LogError("ERROR WHEN READING CSV FILE: " + ex.Message);
        } finally
        {
            Debug.Log("FINALLY OF READING CSV FILE");
        }
    }


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    static void SetConfigurationDataFields(string csvValues)
    {
        string[] configValue = csvValues.Split(", ");
        teddyBearMoveUnitsPerSecond = Convert.ToInt32(configValue[0]);
        cooldownSeconds = Convert.ToInt32(configValue[1]);
    }

    #endregion
}
