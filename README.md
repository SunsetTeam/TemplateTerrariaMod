# Terraria template mod
A mod template for "Terraria" that does not depend on a specific PC and is prepared for use in git.
## Required programs
1) `Visual Studio` (Tested with `Visual Studio 2019 Community`)
2) `tModLoader` ([official installation guide](https://github.com/tModLoader/tModLoader/wiki/tModLoader-guide-for-players))
Note: Don't forget to download `ModCompile` via the `tModLoader` menu and enable developer mode.
## Preparing
### Preparing project
1) DON'T open `Visual Studio` now! Project is not ready!
2) Copy `sample_csproj_user` file and rename it to `TemplateTerrariaMod.csproj.user` (this file contains settings specific to each developer's PC, and it is gitignored) and open it.
3) Change `C:\GOG Games\tModLoader` to the path to the folder where  `tModLoader` is installed (`tModLoader.exe` and `tModLoaderServer.exe` are located in this folder)
4) Save file and open project in `Visual Studio`

Note: these actions should be performed by each developer when downloading the source code for the first time. Keep the original `sample_csproj_user` file, it is necessary for new developers.
### Renaming mod
(Note: In-code name: `BestModEver`. Display name: `Best mod ever`)
1) Rename project in `Solution explorer` to in-code name of your mod.
2) Open `???.csproj.user` file and change `TemplateTerrariaMod` to the in-code name of your mod.
3) Open `TemplateMod.cs` file and change `TemplateTerrariaMod` to in-code name of your mod.
4) Reopen project. *Now, project is ready to compile. Next actions is optional.*
5) Rename `TemplateMod.cs` file and `TemplateMod` class to in-code name of your mod.
6) Open `build.txt` file and add:
```
author = Authors here
version = Version here. Example: 1.2.3.4
displayName = Display name of your mod here
homepage = Don't add this line if you don't have your own website
```
7) Open `description.txt` file and add description of your mod
