//Para você Ruan que não se lembra ao certo o que seria o params dentro do C#, vou explicar
//Não tem haver com o useParams do React, aqui ele tem outra utilidade, que funciona com array
//params é usado antes da tipagem que vc quer usar em algo que vá usar um array
//sim... Com letra minuscula mesmo
// vou te dar um exemplo de dentro da classe:

// public int ExibirNumeros(int[] numeros)
// 
// foreach(int n in numeros){      //para cada "n"(n de numero) em "numeros", faça isso:
// Console.WriteLine(n)   
//

// Aqui, ele teria que receber no parametro de outro lugar a lista de numeros para rodar, certo?
// então fariamos algo mais ou menos assim em outro metodo:

// public int ListaNumeros(){
// 
// ExibirNumeros(new int[] {1, 2, 3, 4, 5 }) }

// Ta vendo que teve que colocar new... int[]... abrir chaves pra dizer que pertence ao array...
// o Params evita isso, deixando mais simples. Vou mostrar com o mesmo exemplo.
// presta atenção que agora tem um "params" antes do int(tipagem) no método.

// public int ExibirNumeros(params int[] numeros)
// 
// foreach(int n in numeros){
// Console.WriteLine(n)  

//viu o params? agora saca só como podemos passar valor pra ele:

// public int ListaNumeros(){
// 
// ExibirNumeros(1, 2, 3, 4, 5)}

//VIU??? pulou toda aquela baboseira e é exatamente pra isso que o params serve.

// agora dá uma olhada no exercicio pra entender melhor. Ta dentro da classe :)

using Params;

ParamsExercicio exercicio = new ParamsExercicio();

exercicio.ListaNomes();
exercicio.ExibirNomes();