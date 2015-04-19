﻿
/*///////////////////////////////////////////////////////////////////
<EasyFarm, general farming utility for FFXI.>
Copyright (C) <2013>  <Zerolimits>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
*/
///////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyFarm.Classes;
using EasyFarm.Views.Settings;

namespace EasyFarmTests
{
    [TestClass]
    public class TestBattleSettings
    {
        [TestInitialize]
        public void Setup()
        {
            // Wipe all static changed data for 
            // every config test. 
            Config.Instance = new Config();
        }

        [TestMethod]
        public void ApproachReflectedInConfigTest()
        {
            // Create the view model. 
            BattleSettingsViewModel BattleSettingsVM = 
                new BattleSettingsViewModel();

            // Set approach to false in the vm which should also set it
            // to false in the config. 
            BattleSettingsVM.ShouldApproach = false;

            // Assert it is indeed false. 
            Assert.IsFalse(Config.Instance.IsApproachEnabled);
        }

        [TestMethod]
        public void EngageReflectedInConfigTest()
        {
            // Create the view model. 
            BattleSettingsViewModel BattleSettingsVM =
                new BattleSettingsViewModel();

            // Set approach to false in the vm which should also set it
            // to false in the config. 
            BattleSettingsVM.ShouldEngage = false;

            // Assert it is indeed false. 
            Assert.IsFalse(Config.Instance.IsEngageEnabled);
        }
    }
}