public class ContaCorrente     //classe pública      
{ 
    public string Titular;      //para criar variável, colocar seu tipo
    public int Agencia;
    public int Numero;
    public double Saldo;

    public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo){
        this.Titular = Titular;
        this.Agencia = Agencia;
        this.Numero = Numero;  
        this.Saldo = Saldo;
    }
    public bool Sacar(double valorSaque) {  //Método: SACAR do tipo booleano (true or false)
        if (this.Saldo >= valorSaque){
            this.Saldo = this.Saldo - valorSaque;
            return true;
        }
        return false;
    }
}


// int, string, double, float são "atributos"!

// CLasse seria a "forma" do bolo.

// C# oferece a possibilidade de termos classes públicas e privadas.
    //Classes Públicas (public class): 
    //Classes Privadas (private class): 

// nome da classe, atributo embaixo

//classe= modificador de acesso, class, nome

//construtor = classe, terá um método escrito que receberá o mesmo nome que a classe. Não tem retorno

//atributo = modificador de acesso, tipo e nome do atributo

//Método = dentro da classe, modificador de acesso. SEMPRE UMA AÇÃO