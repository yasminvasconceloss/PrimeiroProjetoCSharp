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
}