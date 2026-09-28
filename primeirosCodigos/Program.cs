// variaveis
int num1 = 1;
Console.WriteLine(num1);


float num2 = 1.2f; // precisa colocar o 'f' no final para indicar pro compilador q é um numero 'float'
//num2 = num2 / 2; testando
//float num2 = 1.5; isso da erro pq é uma atribuição q é pra variaveis do tipo 'double' e precisa do 'f' no final para funcionar
Console.WriteLine(num2);

double num3 = 1.59d; // tem uma maior capacidade q o 'float' e é melhor colocar o 'd' no final para diferenciar do 'float'
Console.WriteLine(num3);

long num4 = 1L; // tem uma maior capacidade q o 'int' e é melhor colocar o 'L' no final para diferenciar do 'int'
Console.WriteLine(num4);

char c = 'n'; // usar aspas simples
Console.WriteLine(c);

string s = "Nathan"; // usar aspas duplas
Console.WriteLine(s);

bool b = true; // true ou false
Console.WriteLine(b);

const float pi = 3.14f; // adicionar o const no começo deixa essa variavel imutavel

string s2 = "Aredes";
Console.WriteLine(s + s2); // usar o '+' em strings faz a concatenação delas sem espaço

int numInt = (int)num2; // pode converter os tipos tambem fazendo (novoTipo)variavelQueQuerConverter
Console.WriteLine(numInt);
Console.WriteLine(Convert.ToString(pi)); // tambem é possivel converter usando 'Convert.To(tipo)'