using System.Reflection.PortableExecutable;

namespace HelloWord;
internal class Carro
{
    public string Modelo { get; set; }

    public DateOnly LancadoEm { get; set; }

   public Cor Cor { get; set; }

    public void NomeDoModelo() => Console.WriteLine(Modelo);
}