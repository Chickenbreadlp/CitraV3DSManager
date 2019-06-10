# CitraV3DSManager
Citra v3DS Manager is an Application that let's you Create & switch between multiple Virtual 3DS Systems.
It works by switching out the entire Citra SysNand and SDMC.

As of right now, Citra v3DS Manager is only available for Windows.

## Installation
To install this Software, follw these Steps:
- Download the lates release of CitraV3DSManager
- Extract the `.zip` Contents to a new Folder anywhere on your Computer
- Execute `CitraV3DSManager.exe`

## Usage
### Set Up Citra Folder
To use the Citra v3DS Manager, you have to Select the Folder in which Citra Saves it's logs, the SysNand and the virtual SD-Card (aka SDMC).
This Folder can be usually found in %AppData%\Citra. The Folder-Picker opens the %AppData% Folder, so all you have to do is to find the Citra Folder there and select it.
An easy way to check, where exactly this Folder is, is to open Citra, then go into to the Emulation Settings -> Logs and then click on Show Log location.
%AppData% refers to the Roaming folder within the Appdata Folder.

As of right now, the Citra v3DS Manager deos not remeber the Citra Folder, which means you have to do this Step every time you run the Software.

After you selected the Citra folder for the first time, you'll be saked to give your current Savestates a Name. You can rename the current one at any time.

During the first setup, a new Folder within the Citra folder will be created called `v3DS`. This folder will contain all your not-in-use v3DS as well as a text file with the name of currently-in-use v3DS.

### Managing v3DS Systems
Once you've selected the Citra Folder, you can add a new v3DS or duplicate you current v3DS. When doing so, a new Window will pop-up where you can give the new v3DS a name.
After clicking on `Set` a new folder within the `v3DS` folder will be created with the name you set. If you slected `Duplicate`, then the current NAND and SDMC will be copied into this new folder.

You can also switch your current v3DS with any other v3DS you've previously created. You can only delete v3DS Systems, you're currently not using.
This is the only action, that'll ask you before doing anything.
