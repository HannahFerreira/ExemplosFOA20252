
// ALTERE O PROGRAMA PARA QUE SOLICITE O USUARIO INFORMAR O SEU SALARIO E AO FINAL MOSTRAR O DESCONTO O IRPF DO SALARIO FORMADO USE A TABELA DE DESCONTO

double salario;
Console.Write("Digite seu Salario: ");
salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Desconto IRPF: " + (salario * 0.15));


