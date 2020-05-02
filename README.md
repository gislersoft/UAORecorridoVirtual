# UAORecorridoVirtual
Este es un recorrido virtual de pruebas por la UAO hecho en unity para la materia de fundamentos de realidad virtual

### About Free Assets
All assets downloaded from the asset store in this repositort has the FREE license for personal use, please refer to asset store to grab your copy this is a public an academic repository not intended for comercial use.

### Pasos actividad

1. Crear carpeta en donde va a estar su repositorio (C:\Users\gislersoft\Documents\Repositorio)
2. Ir a la consola de git.
2. ```cd "C:\Users\gislersoft\Documents\Repositorio"```
3. ```git clone https://github.com/gislersoft/UAORecorridoVirtual```
4. Ir a su github 
5. Hacer fork del repositorio a su cuenta
6. Copiar la URL de su repositorio (La pueden tomar del boton clone (El verde))
6. Ir a la consola de git y ejecutar ```cd "UAORecorridoVirtual"```
7. ```git remote add fork <URL>```
8. Ir a Unity Hub
9. Darle click a Add y buscar la carpeta donde quedo clonado su repo
10. Abrir el proyecto en Unity
11. Hacer una copia de la escena de pruebas GislerGarces
12. Cambiarle a su nombre y guardar
13. verificar con git status los cambios
13. ```git add .``` (agregar su escena y el meta de escena solamente)
    sugerencia hacer ```git add <archivo>```
14. verificar con git status los cambios
15. ```git commit -m "Agregando escena SuNombre"```
16. ```git push fork master```
17. Les va a pedir las credenciales de github
18. Ir a su repositori en github y verificar que el cambio esta
19. Hacer un Pull Request (Darle click en New Pull Request)
20. Colocar un mensaje con su cambio, colocan su nombre


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

### Integrantes
Juan Camilo Bolaños Aldanas
