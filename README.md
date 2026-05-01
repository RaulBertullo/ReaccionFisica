
EJERCICIO 1:

En este proyecto he trabajado distintos sistemas de física en Unity 3D con el objetivo de comprender el funcionamiento de las fuerzas, la masa y la gravedad en un entorno interactivo.
Principalmente he creado una escena con tres tipos de cohetes y les he aplicado una misma fuerza de empuje (300000N) a los tres cohetes al pulsar una tecla, y cada uno responde de forma diferente según su masa:

Cohete 1: 5000 kg = aceleración menor

Cohete 2: 3000 kg = aceleración media

Cohete 3: 2000 kg = aceleración mayor 

De esta forma se puede observar claramente cómo, con la misma fuerza aplicada, la masa influye directamente en la aceleración del objeto.
También he implementado el sistema utilizando el New Input System de Unity, activando el lanzamiento mediante una acción de input.


EJERCICIO 2: 

En este ejercicio he creado un sistema de gravedad personalizada hacia un planeta, simulando un “mini mundo” donde un jugador puede moverse sobre la superficie de una esfera.
He implementado dos modelos diferentes de gravedad para comparar su comportamiento:

En este modelo he utilizado:

ForceMode.Acceleration

Este modo ignora la masa del Rigidbody, por lo que todos los jugadores caen con la misma aceleración independientemente de su peso.
El jugador es atraído hacia el centro del planeta
La masa no influye en el resultado
Se comporta como un sistema simplificado típico de videojuegos.

En este segundo modelo he utilizado:

ForceMode.Force

En este caso sí se tiene en cuenta la masa del Rigidbody, aplicando una simulación más cercana a la física real.

La fuerza de atracción depende de la masa del jugador
Jugadores más pesados responden de forma distinta a la gravedad
Se observa una diferencia clara en el comportamiento físico


Además de la gravedad, he implementado un sistema de movimiento sobre la superficie del planeta utilizando el New Input System. El movimiento se calcula en base a la orientación del planeta para que el jugador pueda desplazarse de forma natural sobre una esfera.
