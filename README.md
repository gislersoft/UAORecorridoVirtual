# UAORecorridoVirtual
Este es un recorrido virtual de pruebas por la UAO hecho en unity para la materia de fundamentos de realidad virtual

### About Free Assets
All assets downloaded from the asset store in this repositort has the FREE license for personal use, please refer to asset store to grab your copy this is a public an academic repository not intended for comercial use.

### Setup

For Windows users:

> **IMPORTANT!!** : Please, before sending any change to the repo verify that you are using **EXACTLY OR COMPATIBLE** this Unity version: **``` 2020.1.0b5.3485 Personal ```**

1. Download git https://git-scm.com/downloads
2. Create a public github account
3. Go to https://github.com/gislersoft/UAORecorridoVirtual and fork the repository.
4. Create a Unity Project in any local folder. Example: C:\Users\gislersoft\Documents\Unity\UAO\VideoJuegos3D\UAORecorridoVirtual
5. Make sure that this option is turned on **Edit** → **Project Settings** → **Editor** → **Force Serialize References On One Line**
6. Switch to Force Text in **Edit** → **Project Settings** → **Editor** → **Asset Serialization** → Force Text
7. Open git bash (From step 1).
8. ``` cd "C:\Users\gislersoft\Documents\Unity\UAO\VideoJuegos3D\UAORecorridoVirtual" ```
9. ``` git init ```
10. ``` git remote add origin https://github.com/gislersoft/UAORecorridoVirtual.git ```
11. ``` git remote add fork https://github.com/<YOUR GIT HUB USER HERE>/UAORecorridoVirtual.git ```
12. ``` git fetch --all ``` Note: This will take a while until all objects are downloaded.
13. ``` git reset --hard origin/master ``` This will discard all your local changes and just overwrite everything with a copy from the remote branch
