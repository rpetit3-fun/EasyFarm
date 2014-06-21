
/*///////////////////////////////////////////////////////////////////
<EasyFarm, general farming utility for FFXI.>
Copyright (C) <2013 - 2014>  <Zerolimits>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
*////////////////////////////////////////////////////////////////////

﻿using EasyFarm.Classes;

class RestState : BaseState
{
    public RestState(ref GameEngine gameEngine) : base(ref gameEngine) { }

    public override bool CheckState()
    {
        return _engine.PlayerData.shouldRest && _engine.IsWorking;
    }

    public override void EnterState() { }

    public override void RunState()
    {
        if (!_engine.PlayerData.IsResting)
        {
            _engine.RestingService.On();
        }
    }

    public override void ExitState() { }
}