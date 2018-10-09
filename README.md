:file_folder: *[Link a doc compartido](https://docs.google.com/document/d/16V_OOEla8nEn8hH2GuC_dxklCVNUUzVLNqQCLVRWIbY/edit?ts=571a5f6d)*
# General
## a) Durante el desarrollo de la aplicación vamos a usar las buenas prácticas incluidas en los siguientes sitios:
<br>
**Git** <br>
Labels: https://robinpowered.com/blog/best-practice-system-for-organizing-and-tagging-github-issues/ <br>
Issues: https://guides.github.com/features/issues/ <br>
Pull/Merge request: http://codeinthehole.com/writing/pull-requests-and-other-good-practices-for-teams-using-github/ <br>
Versioning: http://semver.org/ <br>
Branching: http://nvie.com/posts/a-successful-git-branching-model/ <br>
Branch Naming: http://stackoverflow.com/questions/273695/git-branch-naming-best-practices/ <br>

**.NET** <br>
http://10rem.net/articles/net-naming-conventions-and-programming-standards---best-practices <br>
http://www.codeproject.com/Articles/539179/Some-practices-to-write-better-Csharp-NET-code <br>
http://www.dofactory.com/reference/csharp-coding-standards <br>

<br>
## b) Tipos Branches:<br>
master: Versiones estables (cada 15 días o si subimos archivos nuevos lo actualizamos)<br>
develop: Este es el branch principal sobre el cual trabajamos. (Branch de master)<br>
feat/issue... : Es el branch que generamos cuando agregamos alguna funcionalidad al proyecto. (Branch de develop)<br>
fix/issue... : Es el branch que generamos cuando queremos arreglar alguna funcionalidad del proyecto. (Branch de develop)<br>
<br>
## c) Cómo usamos git:<br>
### c.1) Empezar con tarea:<br>
```
En develop: <br>
    git checkout -b feat/issue + numerodeissue (Ej: feat/issue1)
    git checkout -b fix/issue + numerodeissue (Ej: fix/issue4)
```
### c.2) Mergear trabajo:<br>
```
    a. git status
    b. Si hay cosas por commitear que no son del issue entonces hacemos:
        b1. git stash
    c. git checkout develop
    d. git pull origin develop
    e. git merge --no-ff nuestrobranch (--no-ff hace que no se pierdan los mensajes de commit del branch)
        e1. En caso de conflicto, lo arreglamos y commit del merge.
    d. git push origin develop
    f. git branch -D nuestrobranch (Borramos branch local)
    g. git push origin :nuestrobranch (Borramos branch remoto)
    h. Creamos nuevo branch y, si hiciese falta, hacemos: git stash pop

```
## d) Herramientas recomendadas para mantener un código uniforme:<br>
SQL: http://poorsql.com/<br>
.NET: https://stylecop.codeplex.com/<br>
<br>
## e) Cómo commitear:<br>
```
1. Los commits comunes deben estar en el siguiente formato:
[Acción] mensaje de que se hizo #numerodeissue;

2. Los commits de cierre de un issue deben estar en el siguiente formato:
[Acción] mensaje de que se hizo; [:Issue] closes #numerodeissue;

Otras formas de cerra el issue desde un commit pueden encontrarse en:
https://help.github.com/articles/closing-issues-via-commit-messages/

```
## f) Cómo trabajar con issues y merge request:<br>
```
1. Los issue deben llevar un nombre significativo de que se va a hacer, una descripción de la tarea,
un weight (sería cuánto tiempo pensas que va a llevar o la dificultad),
un milestone (sprint1, sprint2, etc.) y labels (feat, fix, .net, etc.).
2. Al ponerse a trabajar con un issue asignarselo y agregarle el tag "in progress".
3. Al finalizar un issue: cerrarlo, quitar tag "in progress" y, si hace falta, poner tag de "peer review".
4. Si vemos un issue que ya está hecho: cerrarlo y aclarar en que commit ya se encuentra la tarea realizada o el bug arreglado.
5. Si hicimos un cambio grosero y queremos que algún otro integrante lo revise podemos generar un "Merge request".
```
----------------------------------------------------------------------------------------------------------------------
<br>
# Leer!!! (Antes de enviar entrega)
<br>
Fechas: (Todas las entregas son hasta las 12:00hs)<br>
15/05/2016: Fecha límite entrega DER y de registración de grupo.<br>
15/06/2016: Entrega TP<br>
15/07/2016: Fecha límite 2° recuperatorio<br>
<br>
1º) Limpiar solución desde Visual Studio (Proyecto => Limpiar Solución.)<br>
2º) Verificar archivo de configuración: Conexión con BD + Fecha del sistema (especificada por nosotros)<br>
3º) Verificar que todo el código en C# y el SQL esté comentado.<br>
4º) \data solo debe tener el script de creación y debe haber una BD limpia igual a la que nos dieron.<br>
El script debe generar un user: admin pass: w23e rol: nombre: Administrador General : Funcionalidades: todas las existentes.<br>
5º) Pasar Readme.txt, Estrategia.pdf, \src y \data a un ".zip123" con el siguiente formato:<br>
<br>
`TP1C2016<b><curso><b><nombreGrupo><Nro de grupo>` <br>
<br>
`<b>: espacio en blanco`
<br>
<br>
6º) Enviar la entrega al mail: gestiondedatos.entregas@gmail.com  (El mail debe ser entregado por el representante.) <br>
con el asunto:  `TP1C2016<b><curso><b><nombreGrupo><Nro de grupo>`
<br>
con el cuerpo: <br>
<br>
Grupo: <br>
Curso: <br>
`Integrantes: <apellido>, <nombres>, <legajo>`
<br>
<br>
💻