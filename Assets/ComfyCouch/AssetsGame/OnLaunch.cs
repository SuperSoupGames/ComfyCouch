/// <summary>
/// PreMain
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
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLaunch:MonoBehaviour
{

	// This is NOT a Unity method! (the compiler flag below, is, though)
    [RuntimeInitializeOnLoadMethod]
    static void Run ()
    {
        if(SceneManager.GetSceneByBuildIndex(0).isLoaded == true && Application.isEditor == false)
        {
            CBUG.Error("Globals already loaded! Are we in editor?");
            return;
        }
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }
}
