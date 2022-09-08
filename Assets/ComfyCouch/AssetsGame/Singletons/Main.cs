/// <summary>
/// Main
/// License: GNU AGPLv3
/// Copyright (C) 2022 Super Soup Games
/// 
/// This program is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Affero General Public License as published
/// by the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
/// 
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Affero General Public License for more details.
/// 
/// You should have received a copy of the GNU Affero General Public License
/// along with this program.  If not, see <https://www.gnu.org/licenses/>.
///  
/// Contact: support@supersoupgames.com
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public enum Scenes
    {
        Null,
        Globals,
        Splash
    }

    public static Scenes SceneCurrent = Scenes.Null;

    // Start is called before the first frame update
    void Start()
    {
        CBUG.Do("Hello World ... UwU");
        StatusBoard.WriteMessage("TESTING!!!!!!!!!!!!!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
