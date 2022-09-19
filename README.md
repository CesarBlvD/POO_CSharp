# POO_CSharp

## TheStore

Encapsulamiento: Informacion que solo la clase debe saber, no mostrar a la gente exterior
Campo: El campo es un dato de la clase
Modificador de acceso: Public, private, internal
propiedad: permite exponer la informacion a un dato public string Name { get => name; set => name = value; }, public string Name { get; set; }
Metodos: son acciones que una clase es capaz de realizar (verbos)


## Clases

Rectangulo rectangulo = new Rectangulo();
creacion de objetos nuevos de la clase en este caso rectangulo

modificado de acceso por default siempre es private

constructores: es un tipo de metodo especial que se ejecuta de forma automatica cuando se crea la instancia de una clase (puede recibir parametros pero no devuelve)

SobreCargaDeConstructores: Mas de una definicion de un constructor de una clase pasando diferentes parametros al constructor para llevar a cabo diferentes operaciones

con static no se requiere instanciar un objeto, las clases estaticas todos sus miembros deben ser estaticos 

El acoplamiento esta relacionado con que tan dependientes son una clase con otra

## Acoplamiento

Cohesion una clase debe tener una alta relacion entre sus funcionalidad pero sin perder el proposito de ser del control o de la clase 
## The store 2

repositorio: son componentes o clases que encapsulan la logica necesaria para acceder a las fuentes de datos, logra mejor capacidad de almacenamiento
Herencia: relacion que existe entre multiples clases 

## Interfaces

Interfaz: Contrato entre lsa misma interfaz y una clase que implementa dicha interfaz, las interfaces no pueden incluir campos, todos los metodos deben de ser publicos, para implementar una interfaz es requerido mandar a llamar todos los metodos que se esten utilizando en dicha interfaz
Abstract: no puede crear instancias de una clase ya que esta pensada para compartir ciertos miembros pero que no puedan ser utilizados de otra forma, un metodo abstracto no puede ser privado
Metodo virtual y uno abstracto: un metodo abstracto va a tener siempre dentro de una clase abstracta, metodo virtual tiene cierta logica de implementacion y el abstracto no contiene logica de implementacion y tiene que ser implementada obligatoriamente en las clases derivadas de la clase abstracta
