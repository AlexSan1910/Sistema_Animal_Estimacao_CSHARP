namespace Exercicios{

public class Animal{

    // Definindo propriedades privadas

    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set { _nome = value.ToUpper(); }
    }
    
    private string _tipoAnimal;
    public string TipoAnimal
    {
        get { return _tipoAnimal; }
        set {     // Tratativa para tipoAnimal receber só gato, cachorro ou peixe.

             if (value == "gato" || value == "cachorro" || value == "Peixe"){
                _tipoAnimal = value.ToUpper(); 
            }
            else{
                _tipoAnimal = "Peixe";
            }
            
        }
    }
    
}
}