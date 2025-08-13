using Ejemplo4;
var animal = new Animal();//Instanciando un objeto (Creando)
var perro = new Perro();//Instanciando un objeto (Creando)
var gato = new Gato();//Instanciando un objeto (Creando)
animal.Comer();
gato.Comer();
perro.Comer();//Metodo sobre escrito, para el perro.
perro.Ladrar();//Metodo unico del perro
AnimalService.Alimmentar(gato);//Estoy implementando un servicio
AnimalService.Alimmentar(perro);
AnimalService.Alimmentar(animal);