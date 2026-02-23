## Esquema del proyecto
### Descripcion
Un programa que simula el proceso que se tiene qeu seguir para poder ser admitido y estudiante de la universidad de la guajira, pasando desde el proceso de inscripcion hasta el de cargar documentos.

Sigue una secuencia logica para poder llegar a cada paso, demostrando la naturaleza de un algoritmo. 

para este proceso se tubieron que identificar algunas variables con las cuales trabajar: 

1. Un diccionario que alamcenara toda la infromacion basica del usuario para utilizarla en proceso de verificación, teniendo la funcion de imitar a una bas de datos. 
2. variables globales para valores del administrado. 
3. un diccionario que contengan las carreras y facultades a las que el aspirante pueda inscribirse. 

### Explicación lógica

    Se establecen varaibles globales para trabajar con la aplicación 
        una variable de tipo diccionario para almacenar los datos del usuario
        una varaible de tipo diccionario para almacenar carreras y facultades
        dos varialbes para establecer valores de administrador
            varaible del nombre del Admi
            variable para la contraseña del Admi
    se inizializa la aplicación desde el metodo Main
    El Metodo Main dirige el flujo asia DisplayOptions para mostrarle al usuario las opciones que tiene
    el Usuario ingresa una entrada 
    se procesa la entrada mediante una sentencia switch que permite evaluar los valores de la variable opcion y entrega resultados diferentes
        si el usuario elige 1 se inicia el proceso de inscripcion
        si el usuario elige 2 se da el resultado de la inscripcion
            si el usuario paso los filtros se le dice que se dirija a las pruebas
            de lo contrario se le dice que no paso
        si el usuario elige 3 el estudiante realizara su pruba y tendra el resultado inmediato
            dependinedo de la carrera del usuario se deplegara una evalaucion diferente
                si el usuario responde de manera correcta es admitido y se le avisa que debera de subir los documentos 
                de lo contrario se le dice que perdio la prueba y no es admitido
        si el usuario elige 4, el usuario debera de subir los documentos si no se delplegara un mensaje de error (puede que si puede que no)
        si el usuario elige 5, se desplegara el ingreso de sus credenciales
            si el usuario ingresa las credenciales correctas accedera a las funciones de administrador
                se deplegara las acciones que puede hacer, el administrador decide si las hace o no - esta parte esta en prueba pueden ocurrir errores en la ejecución
            de lo contrario se le negara el aceso
        si el usuario elige 6, se terminara el programa

    fin de la ejecucion



